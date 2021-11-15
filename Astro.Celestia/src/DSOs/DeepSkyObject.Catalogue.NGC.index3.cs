using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class DeepSkyObjectCatalogue {
private static void _addNGC_3() {
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3045",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3045"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 209",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 209"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 563",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 563"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)27.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1145",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1145"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1452",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1452"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1455",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1455"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3052",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3052"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3242",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Jupiter's Ghost Nebula"},
        {"Common Name 2", "Ghost of Jupiter"},
        {"Henry Draper", "HD 90255"},
        {"Smithsonian Astrophysical Observation", "SAO 155965"},
        {"Wilson Evans Batten Catalogue", "WEB 9326"},
        {"New General Catalogue", "NGC 3242"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6912",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6912"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)26.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6986",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6986"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1407",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1407"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2211",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2211"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2212",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2212"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)18.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6737",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6737"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)02.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1402",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1402"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)39.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156587"},
        {"Messier Catalogue", "M 9"},
        {"New General Catalogue", "NGC 6333"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 9.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1319",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)26.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5744",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5744"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)43.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 343",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5863",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5863"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)10.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1393",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1393"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5726",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5726"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)42.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6554",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6554"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)09.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4715",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Small Sgr Star Cloud"},
        {"Messier Catalogue", "M 24"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)26.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6603",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6603"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 339",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2989",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2989"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1391",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1391"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4024",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4024"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)58.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1383",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1383"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)37.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 583",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 583"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)29.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 345",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1321",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1394",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1394"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)39.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3544",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3544"},
        {"New General Catalogue 2", "NGC 3571"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3571",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3544"},
        {"New General Catalogue 2", "NGC 3571"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 346",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)41.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1440",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1440"},
        {"New General Catalogue 2", "NGC 1442"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)45.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1442",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1440"},
        {"New General Catalogue 2", "NGC 1442"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)45.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1458",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 335",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 335"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1430",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1430"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)43.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2283",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2283"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62166"},
        {"Wilson Evans Batten Catalogue", "WEB 7420"},
        {"New General Catalogue", "NGC 2440"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)41.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1739",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1739"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1738",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1738"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3076",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3076"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)57.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 417",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 417"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)11.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1781",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1781"},
        {"New General Catalogue 2", "NGC 1794"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)07.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1794",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1781"},
        {"New General Catalogue 2", "NGC 1794"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)07.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 539",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 539"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)25.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4536",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)13.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5216",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1336",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1119",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1119"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)48.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1389",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)32.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-18, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3200",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3200"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5510",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5510"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)13.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5170",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5170"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)29.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5321",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1339",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2139",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2171",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3520",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3520"},
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)05.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4659",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 179",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 179"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)37.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1547",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1547"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 438",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)53.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5247",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5247"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5810",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5810"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2017",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2017"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)39.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4033",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4033"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 648",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 648"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)38.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 146",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 648"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)38.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1993",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1993"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)35.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157361"},
        {"New General Catalogue", "NGC 6356"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 872",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 872"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1345",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1345"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2151",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)52.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 369",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 369"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1099",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1099"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)45.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2479",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2479"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1100",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1100"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)45.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1098",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1098"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1329",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1329"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1583",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1583"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)28.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2089",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2089"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)47.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5890",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5890"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7301",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7301"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)30.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1091",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1091"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)45.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1092",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1092"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1584",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1584"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4657",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1622",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)07.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5716",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5716"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1623",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)07.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2541",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)05.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6507",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6507"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 807",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6647",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6647"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 806",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 915",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 416",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3290",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3290"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 863",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3420",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3420"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 972",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5728",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5728"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5781",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5781"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)56.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1445",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)25.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1309",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 967",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 967"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)32.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 422",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2131",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1519",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1519"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)08.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2409",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "FIRSSE 213"},
        {"New General Catalogue", "NGC 2409"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1412",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)58.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1163",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1163"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)00.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6613",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 18"},
        {"New General Catalogue", "NGC 6613"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 9.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)19.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1667",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1671",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2013",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 93",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3459",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3459"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)54.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7230",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7230"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)14.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 734",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 734"},
        {"New General Catalogue 2", "NGC 756"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)54.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2358",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2358"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)16.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3409",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3409"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 453",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3431",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3431"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1114",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1114"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)49.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1639",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)40.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4763",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4763"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-17, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1313",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2296",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2296"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 452",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2296"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)48.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6645",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6645"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1670",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3887",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3887"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)47.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5815",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5815"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5078",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)02.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3836",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3836"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6561",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6561"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)10.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1741",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)51.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2076",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2076"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)46.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 532",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5017",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5017"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)12.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5597",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5597"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2907",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2907"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4701",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 60.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 690",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 690"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)47.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 756",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 734"},
        {"New General Catalogue 2", "NGC 756"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5595",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5595"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4629",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5793",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5793"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7709",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7709"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 303",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 303"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)54.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1745",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)53.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 902",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 902"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)22.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6596",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6596"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)17.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7218",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7218"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)10.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2975",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2975"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1125",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1125"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)51.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3141",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3141"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)09.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5054",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5054"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3140",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3140"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)09.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5796",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5796"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5959",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5959"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)37.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7763",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5037",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5037"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)15.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1337",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7754",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7754"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)49.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 363",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 363"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)06.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5663",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5663"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)33.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 594",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)33.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1758",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2848",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2848"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)20.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7759",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7759"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 725",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 725"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)52.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2428",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2428"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)39.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2847",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)20.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5047",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5047"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7165",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7165"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 989",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 989"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2837",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4997",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4997"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)10.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5030",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5030"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)13.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5035",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5035"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)14.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1338",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7821",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7821"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)05.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 333",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 333"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)58.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161801"},
        {"Wilson Evans Batten Catalogue", "WEB 14701"},
        {"New General Catalogue", "NGC 6439"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)48.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2851",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2851"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1461",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1461"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)48.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2924",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2924"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)35.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5049",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5049"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)16.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 546",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5044",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5044"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)15.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4050",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4050"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 487",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 487"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2430",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2430"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)39.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5046",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5046"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1335",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2811",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2811"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 149",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1074",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1074"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3508",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3508"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1491",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1334",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6774",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6774"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1604",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1333",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)52.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 86",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)13.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2622",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3508"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4476",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)39.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4622",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)52.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1358",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1075",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1075"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5817",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5817"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6618",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NGC 6618 Horseshoe"},
        {"Common Name 2", "Checkmark Nebula"},
        {"Common Name 3", "Lobster Nebula"},
        {"Common Name 4", "omega Nebula"},
        {"Common Name 5", "Swan Nebula"},
        {"Henry Draper", "HD 168520"},
        {"Wilson Evans Batten Catalogue", "WEB 15351"},
        {"Messier Catalogue", "M 17"},
        {"New General Catalogue", "NGC 6618"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 46.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)20.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2610",
    secondaryIds: new Dictionary<string,string>{
        {"Wilson Evans Batten Catalogue", "WEB 8079"},
        {"New General Catalogue", "NGC 2610"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)33.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5816",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3128",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3128"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3127",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3127"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5031",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5031"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 890",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)28.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 887",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 887"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 500",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)12.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 764",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)57.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3456",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3456"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4706",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4707",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)20.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 82",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)09.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1440",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)16.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-16, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1906",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1906"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)24.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 79",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3578",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4035",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4035"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5194",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)17.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5038",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5038"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)15.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1372",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1372"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)37.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1388",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1388"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)38.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1262",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1262"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)15.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 78",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1561",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1561"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)23.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1650",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1650"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 921",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 921"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1730",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1730"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2113",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1730"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1034",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1034"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)38.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1356",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2104",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)56.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3178",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3178"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)16.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5010",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5010"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)12.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 400",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)03.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7251",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7251"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1562",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1562"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1565",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1565"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)23.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5309",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)50.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1563",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1563"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1564",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1564"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2063",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1840",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)43.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1105",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1105"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 276",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)58.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2064",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1832",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1832"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)12.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1191",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1191"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1192",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1192"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5198",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1190",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1190"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1866",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)54.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1368",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1368"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1189",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1189"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1199",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1199"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1209",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1209"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)06.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2360",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Caroline's Cluster"},
        {"New General Catalogue", "NGC 2360"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 13.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)17.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7492",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7492"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)08.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 244",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 244"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 130",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1081",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1081"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1231",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1231"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)09.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1413",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1413"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)40.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1610",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 415",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7255",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7255"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)21.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 393",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)47.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7246",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7246"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)17.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 407",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 829",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4984",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4984"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)09.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1188",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1188"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1975",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)39.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1405",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1405"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)40.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2763",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2763"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)06.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5892",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "FATH 703"},
        {"New General Catalogue", "NGC 5892"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)13.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3505",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2414",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2414"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 36",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)37.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 38",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)38.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 42",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)41.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 77",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1464",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1471"},
        {"New General Catalogue 2", "NGC 1464"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)51.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2478",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)54.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4756",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4756"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 80",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)08.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1309",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1309"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)22.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1471",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1471"},
        {"New General Catalogue 2", "NGC 1464"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1343",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 37",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)38.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1686",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1686"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)52.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 73",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 73"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1083",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1083"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1710",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1710"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2108",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1710"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4877",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4877"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1509",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)47.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1354",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1354"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1322",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1323",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)30.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2662",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2662"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1157",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1157"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1821",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1821"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)11.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7717",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7717"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)37.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1065",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1065"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1263",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1263"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)15.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 254",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1065"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1089",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1089"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)46.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 253",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1150",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1150"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1181",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1181"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4856",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4856"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1151",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1151"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1180",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1180"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)57.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 321",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)24.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-15, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 682",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 682"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)49.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 251",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)41.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3479",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3479"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4924",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4924"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)02.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6605",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6605"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)17.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 147",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2425",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2425"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)38.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5073",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5073"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 252",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)41.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5756",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5756"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)47.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 122",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1172",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1172"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)01.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 141",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2437",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 46"},
        {"New General Catalogue", "NGC 2437"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 27.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2781",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2781"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)11.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6822",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Barnard's Galaxy"},
        {"New General Catalogue", "NGC 6822"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4895",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Barnard's Galaxy"},
        {"New General Catalogue", "NGC 6822"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 8.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)45.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 367",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)20.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1076",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1076"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)43.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62099"},
        {"Wilson Evans Batten Catalogue", "WEB 7416"},
        {"New General Catalogue", "NGC 2438"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)41.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2902",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2902"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)30.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 543",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2902"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)30.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 327",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)31.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1308",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 815",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 815"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 187",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 187"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2846",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)19.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 328",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4887",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4887"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 814",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 814"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)02.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4455",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5664"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5420",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5420"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5883",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5883"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)15.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4221",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)18.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5849",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5849"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5664",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5664"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 318",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)20.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3831",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5880",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5880"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)15.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2890",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2890"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4094",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4094"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 228",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1139",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1139"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)52.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4902",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4902"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 944",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 944"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2422",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 47"},
        {"New General Catalogue", "NGC 2422"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 4.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 30.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)36.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3825",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1342",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3827",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 261",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1120"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3838",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1120",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1120"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)49.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 326",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)30.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3824",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5204",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1158",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1158"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3799",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3819",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1203",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1203A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2501",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2501"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2993",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2993"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2992",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2992"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)45.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4724",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4724"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4727",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4727"},
        {"New General Catalogue 2", "NGC 4740"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3822",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 207",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 207"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 245",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)38.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3469",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3469"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)56.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3999",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2674",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2674"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)48.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5878",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5878"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4726",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4726"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4740",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4727"},
        {"New General Catalogue 2", "NGC 4740"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3834",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 270",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3715",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3715"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 272",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2668",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)15.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4114",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4114"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7298",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7298"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 178",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 178"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 39",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 178"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 41",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)39.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5809",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5809"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 579",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)56.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5388",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6818",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Little Gem Nebula"},
        {"Henry Draper", "HD 186282"},
        {"Wilson Evans Batten Catalogue", "WEB 17041"},
        {"New General Catalogue", "NGC 6818"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)44.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3502",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3502"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)02.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5228",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7302"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 9",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)19.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1957",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1957"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4862",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4862"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7302",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7302"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 268",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)55.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3734",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3734"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5094",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5094"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 269",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)55.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1954",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1954"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3591",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3591"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1330",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)46.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1520",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)58.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4863",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4863"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1295",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1290"},
        {"New General Catalogue 2", "NGC 1295"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)20.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4177",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4177"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)12.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7300",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7300"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)31.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-14, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1853",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)48.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1290",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1290"},
        {"New General Catalogue 2", "NGC 1295"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2401",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2401"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 679",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3962",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3962"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)54.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1341",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 102",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 102"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)24.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1103",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1103"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)48.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4899",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4899"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5745",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5745"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)45.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2132",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)32.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5802",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5802"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5801",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5801"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5803",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5803"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 991",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)17.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 210",
    secondaryIds: new Dictionary<string,string>{
        {"Wilson Evans Batten Catalogue", "WEB 5071"},
        {"New General Catalogue", "NGC 210"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)40.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2423",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2423"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 19.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)37.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 665",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3727",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3727"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)33.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5268",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)42.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1346",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3823",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3823"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)42.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1350",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 689",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3661"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3667",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3667"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3661",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3661"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5995",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5995"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)48.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6611",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Eagle Nebula"},
        {"Common Name 2", "Star Queen"},
        {"Messier Catalogue", "M 16"},
        {"New General Catalogue", "NGC 6611"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 35.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)18.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4703",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Eagle Nebula"},
        {"Common Name 2", "Star Queen"},
        {"Messier Catalogue", "M 16"},
        {"New General Catalogue", "NGC 6611"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 47",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)42.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1354",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 720",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 720"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)53.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4829",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4829"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4823",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4823"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4491",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)44.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1055",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)47.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1332",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)51.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2318",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2318"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)59.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4820",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4820"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 58",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1357",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1357"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)33.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4825",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4825"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 166",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 166"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)35.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4220",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4177",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5327",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)30.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1514",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7776"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)54.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1430",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)08.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1469",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1623",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1623"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)34.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1714",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1431",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)07.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1495",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1421",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1421"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)42.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 62",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 62"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)17.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 28",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 650",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4897",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4897"},
        {"New General Catalogue 2", "NGC 4891"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1453",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)46.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1499",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)32.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 51",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)46.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4891",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4897"},
        {"New General Catalogue 2", "NGC 4891"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)00.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7828",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7828"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7829",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7829"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)06.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4748",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4748"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1345",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 60",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3546",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3546"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)09.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1352",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7761",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7761"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)49.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5361",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)51.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7776",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7776"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)52.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 135",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 135"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 27",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 706",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)33.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1344",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1348",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1408",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 26",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 144",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)37.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 250",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)40.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2578",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2578"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)21.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4722",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4722"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 3833",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4722"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1347",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 125",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)29.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2375",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2377",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2379",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4714",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4714"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2374",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2374"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 19.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 743",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)53.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1349",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1353",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7171",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7171"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)01.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 160",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)46.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4723",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4723"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 785",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5978",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5978"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)42.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2361",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 786",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4855",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4855"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5105",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5105"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)21.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1538",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1538"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2359",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2359"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6639",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6639"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1351",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 283",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 283"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)53.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2047",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)14.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7131",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7131"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)47.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 285",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 285"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)53.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2045",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2345",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2345"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 542",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3693",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3693"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5605",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5605"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)25.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5916",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5916"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1355",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 284",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 284"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 468",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)17.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2612",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2612"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4217",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176654"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)01.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1417",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7269",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7269"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)25.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4847",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 299",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 340",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)39.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4392",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)15.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 263",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 263"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 286",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 286"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2413",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2413"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5915",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5915"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)21.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 16",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)27.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2889",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5110",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5110"},
        {"New General Catalogue 2", "NGC 5111"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 655",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 655"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)42.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1296",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1296"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)18.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4844",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)58.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5099",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5099"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)21.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4838",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4838"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5028",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5028"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)13.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6171",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 107"},
        {"New General Catalogue", "NGC 6171"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)32.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4804",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4804"},
        {"New General Catalogue 2", "NGC 4802"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 20",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)28.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-13, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44519"},
        {"Wilson Evans Batten Catalogue", "WEB 6012"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)21.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7134",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7134"},
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)48.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 375",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5111",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5110"},
        {"New General Catalogue 2", "NGC 5111"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)22.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7723",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7723"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)38.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 99",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 380",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2542",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)11.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7308",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7308"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1448",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7308"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)34.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7450",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7450"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)00.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6309",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Box Nebula"},
        {"Henry Draper", "HD 155752"},
        {"Wilson Evans Batten Catalogue", "WEB 14234"},
        {"New General Catalogue", "NGC 6309"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2856",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7005",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)02.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 647",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3831",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3831"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 56",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)51.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3411",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3411"},
        {"New General Catalogue 2", "NGC 3402"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 715",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 715"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)53.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2539",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2539"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 22.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)10.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7444",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7444"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7443",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7443"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)00.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 220",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1247",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)16.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1433",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)12.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 317",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)19.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4836",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4836"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5076",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5076"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4235",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 23",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)30.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26847"},
        {"Geneva Identification System", "GEN# +1.00026847"},
        {"Wilson Evans Batten Catalogue", "WEB 3770"},
        {"New General Catalogue", "NGC 1535"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 10.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)14.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 618",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3296"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 884",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)22.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1494",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)30.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3296",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3296"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2593",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)36.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1456",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35914"},
        {"Wilson Evans Batten Catalogue", "WEB 4952"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)27.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3297",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3297"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)35.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5079",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5079"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 129",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)31.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 169",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6836",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6836"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)54.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3402",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3411"},
        {"New General Catalogue 2", "NGC 3402"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 761",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)06.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 766",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)10.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 154",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 154"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3280",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3280"},
        {"New General Catalogue 2", "NGC 3280A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5077",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5077"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1471",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)08.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 108",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 128",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3295",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)32.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 617",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 652",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3421"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6994",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 73"},
        {"New General Catalogue", "NGC 6994"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 98",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 291",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)07.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 368",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)22.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4794",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4794"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3143",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3143"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)10.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4354",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)58.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 95",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)19.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 224",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)24.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 437",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)51.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3777",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3777"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4329",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4329"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)23.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4782",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4782"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5088",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5088"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)20.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 920",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)45.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6835",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6835"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4188",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4188"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)14.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4783",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4783"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5072",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5072"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6981",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 72"},
        {"New General Catalogue", "NGC 6981"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.4,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 573",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3058"},
        {"New General Catalogue 2", "NGC 3058A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)53.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1489",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 441",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)02.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3058",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3058"},
        {"New General Catalogue 2", "NGC 3058A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4792",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4792"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 672",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)08.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5070",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5070"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)19.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5097",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5097"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 887",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)24.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 927",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)45.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 376",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 377",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3421",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3421"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 924",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)45.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2494",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)36.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2947",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2947"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)38.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3145",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3145"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)10.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 547",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2947"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)36.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1162",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1162"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3422",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3422"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 537",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 593",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 593"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)32.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 513",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)33.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6898",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6898"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)21.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5082",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1204",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1204"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)04.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7010",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7010"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1716",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2517",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2517"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)02.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2962",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5146",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5146"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)26.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 378",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4225",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4225"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7727",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7727"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 10.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)39.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3663",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3663"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5119",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5119"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)23.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6897",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6897"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4263",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4263"},
        {"New General Catalogue 2", "NGC 4265"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4265",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4263"},
        {"New General Catalogue 2", "NGC 4265"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)19.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3030",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3030"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)50.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6604",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6604"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 60.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)18.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7724",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7724"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)39.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 362",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)16.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 601",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 599"},
        {"New General Catalogue 2", "NGC 601"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)33.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1606",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)58.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 599",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 599"},
        {"New General Catalogue 2", "NGC 601"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)32.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1338",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1338"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)29.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)10, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 367",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 367"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1118",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1118"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)50.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 681",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)18.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3404",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3404"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 17",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 34"},
        {"New General Catalogue 2", "NGC 17"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 34",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 34"},
        {"New General Catalogue 2", "NGC 17"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)11.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2482",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)27.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2609",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3404"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)50.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 929",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 929"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)27.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1196",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1196"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 287",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)05.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 699",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 699"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4802",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4804"},
        {"New General Catalogue 2", "NGC 4802"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)55.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6625",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6625"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 9.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)23.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)03, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 589",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 589"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)32.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1195",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1195"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3970",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3970"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)55.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6631",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6631"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 285",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)04.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1498",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1498"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)00.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4524",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4524"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)33.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 35",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 35"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)11.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 271",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3974",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3974"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)55.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-12, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7813",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7813"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)03.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1200",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1200"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2881",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2881"},
        {"New General Catalogue 2", "NGC 2881A"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5384",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7813"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3138",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3138"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)09.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1787",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3133",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3133"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)07.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 217",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)16.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2855",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2855"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)21.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5741",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5741"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)54, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3678"},
        {"Geneva Identification System", "GEN# -0.01200134"},
        {"New General Catalogue", "NGC 246"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 8.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5318",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7646"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1784",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1784"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)05.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7646",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7646"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)24.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 350",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)44.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7378",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7378"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)47.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5742",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5742"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)45.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 369",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)23.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3139",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3139"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)10.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7136",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)49.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 247",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)40.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2396",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2396"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 10.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)28.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 654",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)53.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 306",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)13.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 695",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 303",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)12.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4280",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2879",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)25.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4279",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4279"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3321",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3321"},
        {"New General Catalogue 2", "NGC 3322"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)38.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3322",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3321"},
        {"New General Catalogue 2", "NGC 3322"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)38.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4285",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4285"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4484",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4484"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)28.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 19",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)28.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 433",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2889",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2889"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3361",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3361"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4594",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sombrero"},
        {"Common Name 2", "Sombrero Galaxy"},
        {"Henry Draper", "HD 110124"},
        {"Messier Catalogue", "M 104"},
        {"New General Catalogue", "NGC 4594"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 8.3,
    diametre: Angle.HoursMinutesSeconds(0, 0, 8.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4680",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4680"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)46.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3360",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3360"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)44.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 703",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7158",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7158"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)57.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 18",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4201",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4201"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)14.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4173",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2884",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2884"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)26.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 704",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4176",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4933B"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)06.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3707",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3707"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 773",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 773"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)59.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1013",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1013"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)37.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5891",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5891"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)16.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1529",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)05.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1888",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1888"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3704",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3704"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)30.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5254",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5254"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)39.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5872",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5872"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)11.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1889",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1889"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)22.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4933",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4933"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)03.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 255",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 255"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)47.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7073",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7073"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)29.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4134",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)04.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2525",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2525"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)05.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4700",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4700"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3452",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3452"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)54.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3942",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3942"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)51.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4360",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6931",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6931"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)33.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4920",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4920"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7009",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Saturn Nebula"},
        {"Henry Draper", "HD 200516"},
        {"Hipparcos Number", "HIP 103992"},
        {"Wilson Evans Batten Catalogue", "WEB 18944"},
        {"New General Catalogue", "NGC 7009"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: 8.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 873",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 873"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)16.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4243",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4240"},
        {"New General Catalogue 2", "NGC 4243"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5861",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5861"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)09.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1045",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1045"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)40.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2327",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2327"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)04.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1597",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1597"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)31.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3696",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3696"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)28.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5858",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5858"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1509",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1509"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)04.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2026",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)03.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1091",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)08.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1721",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1721"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1725",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1725"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1728",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1728"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1767",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)00.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2595",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)37.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4708",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4708"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)49.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6985",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6985A"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)56.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3711",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3711"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)29.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1818",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)34.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1006",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1006"},
        {"New General Catalogue 2", "NGC 1010"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)37.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1010",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1006"},
        {"New General Catalogue 2", "NGC 1010"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)37.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 950",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 950"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)29.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1011",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1011"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)37.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1017",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1017"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)37.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)01, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7371",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7371"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)46.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-11, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1723",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1723"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)59.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3892",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3892"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)48.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 981",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 981"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)32.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7425",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7425"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)57.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3541",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3541"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4372",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)05.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)53, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3965",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 230",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)28.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 942",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 942"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)29.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 943",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 943"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)29.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1287",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 44.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)31.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 726",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 726"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)55.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1897",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)10.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)49, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2506",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2506"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.6,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)00.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 155",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 155"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4216",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)17.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7808",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7808"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1238",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1238"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)10.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4822",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4822"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)57.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 977",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 977"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)33.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1357",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)05.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2177",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 120.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)05.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 301",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 301"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 302",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2343",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2343"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 6.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 7.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)08.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 717",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3779"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)39.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5122",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5122"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)24.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1843",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1843"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)14.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3676",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3676"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3775",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3775"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)38.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3779",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3779"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)38.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4784",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4784"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2142",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)01.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4982",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)08.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 945",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 945"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)28.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4781",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4781"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1463",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)59.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7447",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7447"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)00.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 948",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 948"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)28.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4760",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4760"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1247",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1247"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)12.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2351",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2351"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)13.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)29, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4742",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4742"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)51.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 681",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 681"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)49.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2869",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2863"},
        {"New General Catalogue 2", "NGC 2869"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3537",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3537"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)08.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1474",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1474"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)54.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2868",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2868"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)23.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1479",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)25, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2863",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2863"},
        {"New General Catalogue 2", "NGC 2869"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)23.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6649",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6649"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.9,
    diametre: Angle.HoursMinutesSeconds(0, 0, 6.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)33.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2368",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2368"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 12.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)21.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2979",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2979"},
        {"New General Catalogue 2", "NGC 3050"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)43.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4766",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4766"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)23, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3050",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2979"},
        {"New General Catalogue 2", "NGC 3050"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)54.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1451",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)46.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)22, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1154",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1154"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)58.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7309",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7309"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)34.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)21, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1155",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1155"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)58.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4939",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4939"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 5.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7105",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)40.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)20, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 848",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 848"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)10.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4757",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4757"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)52.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6814",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 6814"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)42.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)19, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1284",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1284"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)17.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2353",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2353"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.1,
    diametre: Angle.HoursMinutesSeconds(0, 0, 20.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)14.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5304",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)18.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)18, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3636",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3636"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)20.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4671",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)17, (int)55.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)17, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1480",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)54.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3637",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3637"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)20.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)16, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 567",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 567"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)26.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4790",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4790"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)54.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)15, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5066",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5066"},
        {"New General Catalogue 2", "NGC 5069"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)14, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5130",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5130"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)24.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)13, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1479",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)54.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4663",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4663"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 811",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4663"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5069",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5066"},
        {"New General Catalogue 2", "NGC 5069"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)18.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)12, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 839",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 839"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)09.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1436",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)13.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)11, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 838",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 838"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)09.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2952",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2952"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4358",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)09, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 833",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 833"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.9 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)09.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 835",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 835"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5067",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)18.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 971",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)03.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)08, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 163",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 163"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)36.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1575",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1575"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1577",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1577"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)26.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)07, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 165",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 165"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 811",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 811"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)06, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 401",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)04.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2054",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Asterism,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)05, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2335",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2335"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 7.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 12.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)06.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4658",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4658"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)44.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5885",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5885"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.7,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)15.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)05, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4682",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4682"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)47.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)04, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 217",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 217"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)41.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1140",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1140"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.4 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)54.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)02, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 624",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 624"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)35.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4364",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-10, (int)00, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1602",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)55.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1331",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)20, (int)47.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)59, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3723",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3723"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)32.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)58, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3375",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3375"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)47.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4368",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1421",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)03.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)57, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 806",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 806"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)03.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4240",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4240"},
        {"New General Catalogue 2", "NGC 4243"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)17.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)56, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 309",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 309"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.8,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)56.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1419",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)03.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1426",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)22, (int)03.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)55, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 480",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 480"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)20.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)52, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3732",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3732"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 714",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3763"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)51, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1363",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1363"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)34.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1364",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1364"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)35.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1445",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1445"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)44.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3763",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3763"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)36.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)50, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 688",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)23.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3672",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3672"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 4.1 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)25.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)48, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 617",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 617"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)33.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1738",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)47, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4361",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)46, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2978",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2978"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.2 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)43.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 2910",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.3 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)31.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)45, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2149",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2149"},
    },
    @class: DeepSkyObjectClass.Nebula,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3905",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3905"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)49.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)44, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1880",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)06.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 5442",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 5442"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)43, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 151",
    secondaryIds: new Dictionary<string,string>{
        {"Wilson Evans Batten Catalogue", "WEB 5092"},
        {"New General Catalogue", "NGC 151"},
        {"New General Catalogue 2", "NGC 153"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 11.5,
    diametre: Angle.HoursMinutesSeconds(0, 0, 3.7 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 153",
    secondaryIds: new Dictionary<string,string>{
        {"Wilson Evans Batten Catalogue", "WEB 5092"},
        {"New General Catalogue", "NGC 151"},
        {"New General Catalogue 2", "NGC 153"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)34.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 701",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 701"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 12.2,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.5 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)51.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)42, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1434",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1434"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)44.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3724",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3724"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)41, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 210",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)09.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1205",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1205"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)02.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1182",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1182"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)03.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2377",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2377"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)24.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)40, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2225",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2225"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)26.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2226",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)26.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3722",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3722"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)39, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 4363",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)04.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)38, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 2980",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 2980"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 1.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)43.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3730",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3730"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.7, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)37, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1216",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1216"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)07.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3789",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3789"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 16.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)38.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)36, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 767",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 767"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)58.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1215",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1215"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)07.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 3721",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 3721"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)11, (int)34.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)35, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 1556",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)35.1, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1018",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1018"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)38.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)34, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 5",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.8 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)17.4, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)33, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1014",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)37.8, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1208",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1208"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)06.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1214",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1214"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)03, (int)06.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4768",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4769",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)32, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1632",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1632"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)37.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 382",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 2.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)37.9, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4770",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4770"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)53.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)31, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 50",
    secondaryIds: new Dictionary<string,string>{
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 14.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 0.6 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)00, (int)46.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)30, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 747",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 747"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)56.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)28, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "IC 386",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1632"},
    },
    @class: DeepSkyObjectClass.Other,
    apparentMagnitude: null,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)04, (int)40.0, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)27, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 1078",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 1078"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)44.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4716",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4716"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.5, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 4717",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 4717"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)50.6, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)26, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 6694",
    secondaryIds: new Dictionary<string,string>{
        {"Messier Catalogue", "M 26"},
        {"New General Catalogue", "NGC 6694"},
    },
    @class: DeepSkyObjectClass.StarCluster,
    apparentMagnitude: 8.0,
    diametre: Angle.HoursMinutesSeconds(0, 0, 15.0 * 60),
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)45.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 7665",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 7665"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 13.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)23, (int)27.2, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)24, 0)
    )
)
);
_NGC.Add(
new DeepSkyObject(
    primaryId: "NGC 640",
    secondaryIds: new Dictionary<string,string>{
        {"New General Catalogue", "NGC 640"},
    },
    @class: DeepSkyObjectClass.Galaxy,
    apparentMagnitude: 15.0,
    diametre: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)01, (int)39.3, 0),
        dec: Angle.DegreesMinutesSeconds((int)-09, (int)23, 0)
    )
)
);
}
}

}
