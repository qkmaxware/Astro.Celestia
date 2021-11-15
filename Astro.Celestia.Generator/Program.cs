using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Qkmaxware.Astro.Query;

namespace Astro.Celestia.Generator {
    class Program {
        private static readonly string outputPath = Path.Combine("Astro.Celestia", "src");
        private static readonly string dataPath = Path.Combine("Astro.Celestia.Generator", "data");

        private class EntityData {
            public string primary;
            public Dictionary<string,string> secondaries;
            public string raDegrees;
            public (string hr, string min, string s) ra;
            public string decDegrees;
            public (string hr, string min, string s) dec;
            public string raPmMasPerYr;
            public string decPmMasPerYr;

            public string vmag;
            public string amag;
            public string arcMinutes;
            public string bv;
            public string type;
        }

        static void Main(string[] args) {
            FetchSimbadAliases();
            ExportStars(false);
            ExportDSOs(false);
        }

        private static void FetchSimbadAliases(bool refresh = false) {
            // Fetch all UIDs
            List<string> uids = new List<string>();
            foreach (var stellarData in IterateDelimetedDataFile(Path.Combine(dataPath, "heasarc", "HipparcosMain.BrowseTargets.14989.1636393019.txt"))) {
                uids.Add(stellarData["name"]);
            }
            foreach (var stellarData in IterateDelimetedDataFile(Path.Combine(dataPath, "heasarc", "NGC2000.BrowseTargets.24918.1636393851.txt"))) {
                uids.Add(stellarData["name"]);
            }

            var regex = new Regex(@"\s+");

            // Configure SIMBAD querying
            string common_name_identifier = "NAME"; // special, allow multiple
            var simbad_id_aliases = new Dictionary<string, string>{
                // Universal
                { common_name_identifier, "Common Name" },
                // Stars
                { "ADS", "Aitken" },
                { "AKARI-FITS-V1", "AKARI/FITS Bright Source Catalogue" },
                { "BD", "Bonner Durchmusterung" },
                { "HD", "Henry Draper"},
                { "HIP", "Hipparcos Number"},
                { "CEL", "Celescope Catalog" },
                { "Ci", "Cincinnati Publication" },
                { "CSI", "Catalogue of Stellar Identifiers" },
                { "FK1", "Fundamental Katalog 1st Edition" },
                { "FK2", "Fundamental Katalog 2nd Edition" },
                { "FK3", "Fundamental Katalog 3rd Edition" },
                { "FK4", "Fundamental Katalog 4th Edition" },
                { "FK5", "Fundamental Katalog 5th Edition" },
                { "GEN#", "Geneva Identification System" },
                { "Renson", "Renson" },
                { "SAO", "Smithsonian Astrophysical Observation" },
                { "SSC", "Smithsonian Stellar Catalogue" },
                { "WEB", "Wilson Evans Batten Catalogue" },
                //DSOs
                { "M", "Messier Catalogue" },
                { "NGC", "New General Catalogue" }
            }; 

            // Fetch all previous known aliases
            var aliases = readSimbadAliases();

            using (var writer = new StreamWriter(Path.Combine(dataPath, "simbad", "aliases.txt"))){
                // Write header
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("SIMBAD Alternative IDs");
                writer.WriteLine();
                writer.Write("|UID");
                foreach (var kv in simbad_id_aliases) {
                    writer.Write("|");
                    writer.Write(kv.Value);
                }
                writer.WriteLine("|");
                writer.Flush();

                Console.Write("Fetching SIMBAD aliases for known UIDs...");
                var left = Console.CursorLeft;
                var top = Console.CursorTop;
                var iterator = 1;
                foreach (var entity in uids) {
                    var matches = new Dictionary<string,List<string>>();

                    if (!refresh && aliases.ContainsKey(entity)) {
                        // We aren't auto-refreshing entities and have already downloaded these so reuse them
                        matches = aliases[entity];
                    } else {
                        // Query simbad (the API class does rate limiting automatically for us... I hope it works)
                        var result = SimbadAPI.WithIdentifier(entity).FirstOrDefault();
                        
                        // Add identifiers from simbad to the entity data object
                        if (result != null && result.IdentifierList != null) {
                            foreach (string id in result.IdentifierList) {
                                var identifier = regex.Replace(id, " "); // Replace multiple whitespace with single whitespace
                                var parts = identifier.Split(' ', 2);
                                var catalogue = parts[0].Trim();
                                if (catalogue == common_name_identifier) {
                                    identifier = identifier.Replace(common_name_identifier, string.Empty).Trim();
                                }
                                if (simbad_id_aliases.ContainsKey(catalogue)) {
                                    var catName = simbad_id_aliases[catalogue];
                                    if (matches.ContainsKey(catName)) {
                                        matches[catName].Add(identifier);
                                    } else {
                                        matches[catName] = new List<string>{ identifier };
                                    }
                                }
                            }
                        }
                    }

                    // Write all matches to file
                    writer.Write("|" + entity);
                    foreach (var kv in simbad_id_aliases) {
                        writer.Write("|");
                        if (matches.ContainsKey(kv.Value)) {
                            writer.Write(string.Join(';', matches[kv.Value]));
                        }
                    }
                    writer.WriteLine("|");
                    writer.Flush();

                    // Update progress
                    Console.SetCursorPosition(left, top);
                    Console.Write((iterator++) + "/" + uids.Count);
                }
                Console.WriteLine(" Done");
            }
        }

        private static void ExportStars(bool doOnly1 = false) {
            // --------------------------------------------------------------------------------------------------------------------------------------------------
            // Iterate stars in the Hipparcos Main data set (stars)
            // --------------------------------------------------------------------------------------------------------------------------------------------------
            // Process main data set
            // https://heasarc.gsfc.nasa.gov/W3Browse/star-catalog/hipparcos.html 
            var stars = new Dictionary<string, EntityData>();
            Console.Write("[Hipparcos] Parsing entity list...");
            foreach (var stellarData in IterateDelimetedDataFile(Path.Combine(dataPath, "heasarc", "HipparcosMain.BrowseTargets.14989.1636393019.txt"))) {
                var primaryId = stellarData["name"];
                var secondaryIds = new Dictionary<string, string>();
                // Read important data
                var data = new EntityData {
                    primary = primaryId,
                    secondaries = secondaryIds,
                    ra = ParseHMS(stellarData["ra"]),       // 20 15 38.5300|+43 38 54.000
                    dec = ParseHMS(stellarData["dec"]),
                    raDegrees = stellarData["ra_deg"],      // +123123.0 (better than above, but can be missing)  
                    decDegrees = stellarData["dec_deg"],
                    raPmMasPerYr = stellarData["pm_ra"],   // expressed in milliarcseconds per Julian year (mas/yr)
                    decPmMasPerYr = stellarData["pm_dec"]  // expressed in milliarcseconds per Julian year (mas/yr)
                };
                if (string.IsNullOrEmpty(data.raPmMasPerYr)) {
                    data.raPmMasPerYr = "0";
                } 
                if (string.IsNullOrEmpty(data.decPmMasPerYr)) {
                    data.decPmMasPerYr = "0";
                }
                // Read in special properties
                data.vmag = stellarData["vmag"].Trim(); // double
                if (string.IsNullOrEmpty(data.vmag)) {
                    data.vmag = "null";
                }
                data.bv = stellarData["bv_color"].Trim(); // double
                if (string.IsNullOrEmpty(data.bv)) {
                    data.bv = "null";
                }
                // Assign
                stars[primaryId] = data;

                if (doOnly1)
                    break; // TEMP, only do 1 for testing 
            }
            Console.WriteLine("Done");
            // Merge list of star names into secondary id fields
            Console.Write("[Hipparcos] Matching SIMBAD aliases...");
            var aliases = readSimbadAliases();
            foreach (var entity in stars) {
                if (aliases.ContainsKey(entity.Key)) {
                    var entityAliases = aliases[entity.Key];
                    foreach (var category in entityAliases) {
                        foreach (var alias in category.Value) {
                            if (!string.IsNullOrEmpty(alias))
                                entity.Value.secondaries[uniqueKey(category.Key, entity.Value.secondaries)] = alias;
                        }
                    }
                }
            }
            Console.WriteLine(" Done");
            // Write out file
            var uniqueCatalogueName = "Hipparcos";
            Console.Write("[Hipparcos] Emitting class...");
            writeCsFiles("Stars", "Star.Catalogue", "StarCatalogue", uniqueCatalogueName, "Star", stars, EmitStar);
            Console.WriteLine("Done");
        }

        private static void EmitStar(TextWriter writer, EntityData data) {
            writer.WriteLine($"new Star(");
            writer.WriteLine($"    primaryId: \"{data.primary}\",");
            writer.WriteLine($"    secondaryIds: new Dictionary<string,string>{{");
            foreach (var idPair in data.secondaries) {
                writer.WriteLine($"        {{\"{idPair.Key}\", \"{idPair.Value}\"}},");
            }
            writer.WriteLine($"    }},");
            writer.WriteLine($"    visualMagnitude: {data.vmag},");
            writer.WriteLine($"    bvColour: {data.bv},");
            if (!string.IsNullOrEmpty(data.raDegrees) && !string.IsNullOrEmpty(data.decDegrees)) {
            writer.WriteLine($"    coordinates: new EquatorialCoordinate(");
            writer.WriteLine($"        ra:  Angle.Degrees({data.raDegrees}),");
            writer.WriteLine($"        dec: Angle.Degrees({data.decDegrees})");
            writer.WriteLine($"    ),");
            } else {
            writer.WriteLine($"    coordinates: new EquatorialCoordinate(");
            writer.WriteLine($"        ra:  Angle.HoursMinutesSeconds((int){data.ra.hr}, (int){data.ra.min}, {data.ra.s}),");
            writer.WriteLine($"        dec: Angle.DegreesMinutesSeconds((int){data.dec.hr}, (int){data.dec.min}, {data.dec.s})");
            writer.WriteLine($"    ),"); 
            }
            writer.WriteLine($"    motion: new ProperMotion(");
            writer.WriteLine($"        dra:  Angle.HoursMinutesSeconds(0, 0, {data.raPmMasPerYr} / 1000),");      // conversion to arcseconds divide by 1000
            writer.WriteLine($"        ddec: Angle.DegreesMinutesSeconds(0, 0, {data.decPmMasPerYr} / 1000),");
            writer.WriteLine($"        duration:  Duration.Seconds(31557600)");
            writer.WriteLine($"    )");
            writer.WriteLine($")");
        }

        private static void ExportDSOs(bool doOnly1 = false) {
            // --------------------------------------------------------------------------------------------------------------------------------------------------
            // Iterate DSO's in the NGC data set (galaxy, nebula, star-cluster)
            // --------------------------------------------------------------------------------------------------------------------------------------------------
            // Process main data set
            // https://heasarc.gsfc.nasa.gov/W3Browse/general-catalog/ngc2000.html
            var dsos = new Dictionary<string, EntityData>();
            Console.Write("[NGC 2000] Parsing entity list...");
            foreach (var stellarData in IterateDelimetedDataFile(Path.Combine(dataPath, "heasarc", "NGC2000.BrowseTargets.24918.1636393851.txt"))) {
                var primaryId = stellarData["name"];
                var secondaryIds = new Dictionary<string, string>();
                // Read important data
                var data = new EntityData {
                    primary = primaryId,
                    secondaries = secondaryIds,
                    ra = ParseHMS(stellarData["ra"]),
                    dec = ParseHMS(stellarData["dec"])
                };
                // Read in special properties
                data.amag = stellarData["app_mag"];
                if (string.IsNullOrEmpty(data.amag)) {
                    data.amag = "null";
                }
                data.arcMinutes = stellarData["ang_diameter"];
                data.type = stellarData["source_type"] switch {
                    "Gx" => "DeepSkyObjectClass.Galaxy",
                    "OC" => "DeepSkyObjectClass.StarCluster",
                    "Gb" => "DeepSkyObjectClass.StarCluster",
                    "Nb" => "DeepSkyObjectClass.Nebula",
                    "Pl" => "DeepSkyObjectClass.Nebula",
                    "C+N" => "DeepSkyObjectClass.StarCluster",
                    "Ast" => "DeepSkyObjectClass.Asterism",
                    "Kt" => "DeepSkyObjectClass.Nebula",
                    "TS" => "DeepSkyObjectClass.StarCluster",
                    "DS" => "DeepSkyObjectClass.StarCluster",
                    "SS" => "DeepSkyObjectClass.StarCluster",
                    _ => "DeepSkyObjectClass.Other"
                };
                
                // Assign
                dsos[primaryId] = data;
                if (doOnly1)
                    break; // TEMP, only do 1 for testing 
            }
            Console.WriteLine("Done");
            // Merge list of dso names into secondary id fields
            Console.Write("[NGC 2000] Matching SIMBAD aliases...");
            var aliases = readSimbadAliases();
            foreach (var entity in dsos) {
                if (aliases.ContainsKey(entity.Key)) {
                    var entityAliases = aliases[entity.Key];
                    foreach (var category in entityAliases) {
                        foreach (var alias in category.Value) {
                            if (!string.IsNullOrEmpty(alias))
                                entity.Value.secondaries[uniqueKey(category.Key,  entity.Value.secondaries)] = alias;
                        }
                    }
                }
            }
            Console.WriteLine(" Done");
            // Write out file
            var uniqueCatalogueName = "NGC";
            Console.Write("[NGC 2000] Emitting class...");
            writeCsFiles("DSOs", "DeepSkyObject.Catalogue", "DeepSkyObjectCatalogue", uniqueCatalogueName, "DeepSkyObject", dsos, EmitDso);
            Console.WriteLine("Done");
        }

        private static void EmitDso(TextWriter writer, EntityData data) {
            writer.WriteLine($"new DeepSkyObject(");
            writer.WriteLine($"    primaryId: \"{data.primary}\",");
            writer.WriteLine($"    secondaryIds: new Dictionary<string,string>{{");
            foreach (var idPair in data.secondaries) {
                writer.WriteLine($"        {{\"{idPair.Key}\", \"{idPair.Value}\"}},");
            }
            writer.WriteLine($"    }},");
            writer.WriteLine($"    @class: {data.type},");
            writer.WriteLine($"    apparentMagnitude: {data.amag},");
            if (!string.IsNullOrEmpty(data.arcMinutes)) {
            writer.WriteLine($"    diametre: Angle.HoursMinutesSeconds(0, 0, {data.arcMinutes} * 60),");
            } else {
            writer.WriteLine($"    diametre: null,");
            }
            writer.WriteLine($"    coordinates: new EquatorialCoordinate(");
            writer.WriteLine($"        ra:  Angle.HoursMinutesSeconds((int){data.ra.hr}, (int){data.ra.min}, {data.ra.s}),");
            writer.WriteLine($"        dec: Angle.DegreesMinutesSeconds((int){data.dec.hr}, (int){data.dec.min}, {data.dec.s})");
            writer.WriteLine($"    )");
            writer.WriteLine($")");
        }

        private static void writeCsFiles(string folder, string filename, string containerClass, string uniqueCatalogueName, string entityClass, Dictionary<string, EntityData> objects, Action<TextWriter, EntityData> entitySerializer) {
            filename = filename + "." + uniqueCatalogueName;
            var groupSize = 1000;
            var objectCount = objects.Count;
            var groups = objects.Values
                        .Select((v, i) => new { Value = v, Index = i }) 
                        .GroupBy(x => x.Index / groupSize).ToList();
            var groupCount = groups.Count;
            
            using (var writer = new StreamWriter(Path.Combine(outputPath, folder, filename + ".cs"))) {
                // Header
                writer.WriteLine(
@"using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class " + containerClass + @" {
    
    private static List<" + entityClass + @"> _" + uniqueCatalogueName + @" = null; 
    public static IEnumerable<" + entityClass + @"> " + uniqueCatalogueName + @"{
        get {
            if (_" + uniqueCatalogueName + @" == null) {
                _" + uniqueCatalogueName + @" = new List<" + entityClass + @">(" + objectCount + @");
                _rebuild" + uniqueCatalogueName + @"();
            }
            return _" + uniqueCatalogueName + @".AsReadOnly();
        }
    }
    
    private static void _rebuild" + uniqueCatalogueName + @"() {");
                for (var i = 0; i < groupCount; i++) {
                    writer.WriteLine("_add" + uniqueCatalogueName + "_" + i + "();");
                }

                // Footer
                writer.WriteLine(
@"  }
}

}"  
                );
            }

            for (var i = 0; i < groupCount; i++) {
            var group = groups[i];
            using (var writer = new StreamWriter(Path.Combine(outputPath, folder, filename + ".index" + i + ".cs"))) {
                // Header
                writer.WriteLine(
@"using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class " + containerClass + @" {"
                );
                writer.WriteLine("private static void _add" + uniqueCatalogueName + "_" + i + "() {");

                // Data
                foreach (var entity in group) {
                    writer.WriteLine("_" + uniqueCatalogueName + ".Add(");
                    entitySerializer.Invoke(writer, entity.Value);
                    writer.WriteLine(");");
                }

                writer.WriteLine("}");

                // Footer
                writer.WriteLine(
@"}

}"  
                );
            }
            }
        }

        private static (string hr, string min, string s) ParseHMS(string data) {
            var parts = data.Split(' ', 3);
            return (parts.ElementAtOrDefault(0) ?? "0", parts.ElementAtOrDefault(1) ?? "0", parts.ElementAtOrDefault(2) ?? "0");
        }

        private static Dictionary<string, Dictionary<string, List<string>>> readSimbadAliases() {
            var aliases = new Dictionary<string, Dictionary<string, List<string>>>();
            var path = Path.Combine(dataPath, "simbad", "aliases.txt");
            foreach (var aliasRow in IterateDelimetedDataFile(path)) {
                var objectId = aliasRow["UID"];
                var objectAliases = aliasRow.ToDictionary(
                    (key) => key.Key,
                    (element) => element.Value.Split(';').ToList()
                );
                objectAliases.Remove("UID");
                if (aliases.ContainsKey(objectId)) {
                    throw new Exception("Duplicate object unique IDs");
                } else {
                    aliases[objectId] = objectAliases;
                }
            }

            return aliases;
        }

        private static string uniqueKey<T>(string @base, Dictionary<string, T> dict) {
            var idx = 2;
            var name = @base;
            while (dict.ContainsKey(name)) {
                name = @base + " " + (idx++);
            }
            return name;
        }

        private static IEnumerable<Dictionary<string, string>> IterateDelimetedDataFile(string path, char separator = '|') {
            using (var reader = new StreamReader(path)) {
                // Skip line 1
                reader.ReadLine();
                // Skip line 2
                reader.ReadLine();
                // Line 3 is catalogue name (ie. Results from heasarc_bsc5p: Bright Star Catalog)
                var catalogueLine = reader.ReadLine();
                var catalogueName = catalogueLine.Split(':').Last()?.Trim();
                // Skip line 4
                reader.ReadLine();
                // Line 5, headers start here
                var headers = reader.ReadLine().Split(separator);
                for(var i = 0; i < headers.Length; i++) {
                    headers[i] = headers[i].Trim();
                }
                // Line 6, data starts here
                string dataLine;
                while((dataLine = reader.ReadLine()) != null) {
                    var parts = dataLine.Split(separator);
                    Dictionary<string, string> row = new Dictionary<string, string>();
                    for (var i = 0; i < headers.Length; i++) {
                        string header = headers[i];
                        string part = i >= 0 && i < parts.Length ? parts[i].Trim() : null;
                        row[header] = part;
                    }
                    yield return row;
                }
            }
        }
    }
}
