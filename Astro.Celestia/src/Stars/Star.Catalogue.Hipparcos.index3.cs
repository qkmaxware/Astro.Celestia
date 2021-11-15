using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_3() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49855"},
        {"Hipparcos Number", "HIP 32235"},
        {"Geneva Identification System", "GEN# +1.00049855"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.94263154),
        dec: Angle.Degrees(-71.97664499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210055"},
        {"Hipparcos Number", "HIP 109494"},
        {"Smithsonian Astrophysical Observation", "SAO 258004"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.71849480),
        dec: Angle.Degrees(-71.97577786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170776"},
        {"Hipparcos Number", "HIP 91345"},
        {"Smithsonian Astrophysical Observation", "SAO 257611"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.46942672),
        dec: Angle.Degrees(-71.97468741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311440"},
        {"Hipparcos Number", "HIP 43629"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.28286596),
        dec: Angle.Degrees(-71.96891985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42081"},
        {"Hipparcos Number", "HIP 28573"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.45975476),
        dec: Angle.Degrees(-71.95979270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141789"},
        {"Hipparcos Number", "HIP 78076"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.12263256),
        dec: Angle.Degrees(-71.95665279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197070"},
        {"Hipparcos Number", "HIP 102508"},
        {"Geneva Identification System", "GEN# +1.00197070"},
        {"Smithsonian Astrophysical Observation", "SAO 257849"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.61538600),
        dec: Angle.Degrees(-71.94953611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11569"},
        {"Hipparcos Number", "HIP 8558"},
        {"Geneva Identification System", "GEN# +1.00011569"},
        {"Smithsonian Astrophysical Observation", "SAO 255822"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.60115485),
        dec: Angle.Degrees(-71.94899988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 268.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29880"},
        {"Hipparcos Number", "HIP 21423"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.99132582),
        dec: Angle.Degrees(-71.94525620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143720"},
        {"Hipparcos Number", "HIP 79036"},
        {"Geneva Identification System", "GEN# +1.00143720"},
        {"Smithsonian Astrophysical Observation", "SAO 257363"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.99139773),
        dec: Angle.Degrees(-71.94455477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9684"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.14593360),
        dec: Angle.Degrees(-71.94402755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86055"},
        {"Hipparcos Number", "HIP 48430"},
        {"Smithsonian Astrophysical Observation", "SAO 256665"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.10957501),
        dec: Angle.Degrees(-71.94340734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175008"},
        {"Hipparcos Number", "HIP 93272"},
        {"Smithsonian Astrophysical Observation", "SAO 257645"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.99351469),
        dec: Angle.Degrees(-71.93257974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88664"},
        {"Hipparcos Number", "HIP 49827"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.58638159),
        dec: Angle.Degrees(-71.93129500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100326"},
        {"Hipparcos Number", "HIP 56240"},
        {"Geneva Identification System", "GEN# +1.00100326"},
        {"Smithsonian Astrophysical Observation", "SAO 256848"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.93366683),
        dec: Angle.Degrees(-71.92855777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196480"},
        {"Hipparcos Number", "HIP 102231"},
        {"Geneva Identification System", "GEN# +1.00196480"},
        {"Smithsonian Astrophysical Observation", "SAO 257843"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.72561836),
        dec: Angle.Degrees(-71.92742347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156961"},
        {"Hipparcos Number", "HIP 85403"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.77942648),
        dec: Angle.Degrees(-71.92715546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167130"},
        {"Hipparcos Number", "HIP 89899"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.16649494),
        dec: Angle.Degrees(-71.92285287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146584"},
        {"Hipparcos Number", "HIP 80255"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.75963996),
        dec: Angle.Degrees(-71.91832411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107098"},
        {"Hipparcos Number", "HIP 60082"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.80867124),
        dec: Angle.Degrees(-71.91705483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1372"},
        {"Hipparcos Number", "HIP 1387"},
        {"Geneva Identification System", "GEN# +1.00001372"},
        {"Wilson Evans Batten Catalogue", "WEB 253"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.33941193),
        dec: Angle.Degrees(-71.91576594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145421"},
        {"Hipparcos Number", "HIP 79780"},
        {"Renson", "Renson 41180"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.23036573),
        dec: Angle.Degrees(-71.90643737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133049"},
        {"Hipparcos Number", "HIP 73980"},
        {"Geneva Identification System", "GEN# +1.00133049"},
        {"Smithsonian Astrophysical Observation", "SAO 257238"},
        {"Wilson Evans Batten Catalogue", "WEB 12633"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.78411730),
        dec: Angle.Degrees(-71.90493487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19400"},
        {"Hipparcos Number", "HIP 14131"},
        {"Fundamental Katalog 5th Edition", "FK5 113"},
        {"Geneva Identification System", "GEN# +1.00019400"},
        {"Renson", "Renson 4850"},
        {"Smithsonian Astrophysical Observation", "SAO 255945"},
        {"Wilson Evans Batten Catalogue", "WEB 2780"},
    },
    visualMagnitude: 5.51,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.56415553),
        dec: Angle.Degrees(-71.90249547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162048"},
        {"Hipparcos Number", "HIP 87772"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.95669061),
        dec: Angle.Degrees(-71.89649739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148650"},
        {"Hipparcos Number", "HIP 81259"},
        {"Smithsonian Astrophysical Observation", "SAO 257413"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.95573114),
        dec: Angle.Degrees(-71.89416837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96269"},
        {"Hipparcos Number", "HIP 54099"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.05455286),
        dec: Angle.Degrees(-71.89199433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49532"},
        {"Hipparcos Number", "HIP 32081"},
        {"Smithsonian Astrophysical Observation", "SAO 256328"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.53263699),
        dec: Angle.Degrees(-71.88956489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143530"},
        {"Hipparcos Number", "HIP 78929"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.68802112),
        dec: Angle.Degrees(-71.88667359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107013"},
        {"Hipparcos Number", "HIP 60035"},
        {"Geneva Identification System", "GEN# +1.00107013"},
        {"Smithsonian Astrophysical Observation", "SAO 256925"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.67828183),
        dec: Angle.Degrees(-71.88313961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2466"},
        {"Hipparcos Number", "HIP 2186"},
        {"Geneva Identification System", "GEN# +1.00002466"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.90926363),
        dec: Angle.Degrees(-71.88263949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74698"},
        {"Hipparcos Number", "HIP 42532"},
        {"Geneva Identification System", "GEN# +1.00074698"},
        {"Smithsonian Astrophysical Observation", "SAO 256538"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.07217422),
        dec: Angle.Degrees(-71.87728610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146310"},
        {"Hipparcos Number", "HIP 80152"},
        {"Smithsonian Astrophysical Observation", "SAO 257389"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.40626976),
        dec: Angle.Degrees(-71.87383134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184974"},
        {"Hipparcos Number", "HIP 97027"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.78518748),
        dec: Angle.Degrees(-71.87338520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40223"},
        {"Hipparcos Number", "HIP 27601"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.65842830),
        dec: Angle.Degrees(-71.87144027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188963"},
        {"Hipparcos Number", "HIP 98776"},
        {"Geneva Identification System", "GEN# +1.00188963"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.91685995),
        dec: Angle.Degrees(-71.86859777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118685"},
        {"Hipparcos Number", "HIP 66783"},
        {"Smithsonian Astrophysical Observation", "SAO 257077"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.30688414),
        dec: Angle.Degrees(-71.86835438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194646"},
        {"Hipparcos Number", "HIP 101327"},
        {"Smithsonian Astrophysical Observation", "SAO 257819"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.06136981),
        dec: Angle.Degrees(-71.86415593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17686"},
        {"Hipparcos Number", "HIP 12895"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.43847321),
        dec: Angle.Degrees(-71.84485252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 147.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114673"},
        {"Hipparcos Number", "HIP 64555"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.48317866),
        dec: Angle.Degrees(-71.84408245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149841"},
        {"Hipparcos Number", "HIP 81883"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.88737438),
        dec: Angle.Degrees(-71.84307898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33263"},
        {"Hipparcos Number", "HIP 23447"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.59894095),
        dec: Angle.Degrees(-71.84249485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150139"},
        {"Hipparcos Number", "HIP 82032"},
        {"Smithsonian Astrophysical Observation", "SAO 257429"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.36164461),
        dec: Angle.Degrees(-71.83994715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311358"},
        {"Hipparcos Number", "HIP 40436"},
        {"Smithsonian Astrophysical Observation", "SAO 256490"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.85282502),
        dec: Angle.Degrees(-71.83849482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216976"},
        {"Hipparcos Number", "HIP 113510"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.82050786),
        dec: Angle.Degrees(-71.83660043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7031"},
        {"Hipparcos Number", "HIP 5367"},
        {"Smithsonian Astrophysical Observation", "SAO 255746"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.16071637),
        dec: Angle.Degrees(-71.83531899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199434"},
        {"Hipparcos Number", "HIP 103803"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.50545125),
        dec: Angle.Degrees(-71.83334916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103575"},
        {"Hipparcos Number", "HIP 58127"},
        {"Geneva Identification System", "GEN# +1.00103575"},
        {"Smithsonian Astrophysical Observation", "SAO 256883"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.83894843),
        dec: Angle.Degrees(-71.82719696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75246"},
        {"Hipparcos Number", "HIP 42841"},
        {"Geneva Identification System", "GEN# +1.00075246"},
        {"Smithsonian Astrophysical Observation", "SAO 256545"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.814,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.94253032),
        dec: Angle.Degrees(-71.82602234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94145"},
        {"Hipparcos Number", "HIP 52957"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.46366697),
        dec: Angle.Degrees(-71.82254282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180839"},
        {"Hipparcos Number", "HIP 95405"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.11074407),
        dec: Angle.Degrees(-71.81604934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114239"},
        {"Hipparcos Number", "HIP 64331"},
        {"Geneva Identification System", "GEN# +1.00114239"},
        {"Renson", "Renson 33050"},
        {"Smithsonian Astrophysical Observation", "SAO 257015"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.78283016),
        dec: Angle.Degrees(-71.81422197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105161"},
        {"Hipparcos Number", "HIP 59051"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.62492851),
        dec: Angle.Degrees(-71.81313674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18765"},
        {"Hipparcos Number", "HIP 13676"},
        {"Geneva Identification System", "GEN# +1.00018765"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.04651305),
        dec: Angle.Degrees(-71.81103948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99372"},
        {"Hipparcos Number", "HIP 55712"},
        {"Geneva Identification System", "GEN# +1.00099372"},
        {"Smithsonian Astrophysical Observation", "SAO 256835"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.24225481),
        dec: Angle.Degrees(-71.81046623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81771"},
        {"Hipparcos Number", "HIP 46040"},
        {"Smithsonian Astrophysical Observation", "SAO 256611"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84482631),
        dec: Angle.Degrees(-71.80866592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6827"},
        {"Hipparcos Number", "HIP 5242"},
        {"Geneva Identification System", "GEN# +1.00006827"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.76191671),
        dec: Angle.Degrees(-71.80750527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311564"},
        {"Hipparcos Number", "HIP 47460"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.12854585),
        dec: Angle.Degrees(-71.80459713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8271"},
        {"Hipparcos Number", "HIP 6218"},
        {"Geneva Identification System", "GEN# +1.00008271"},
        {"Smithsonian Astrophysical Observation", "SAO 255763"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.92888065),
        dec: Angle.Degrees(-71.80282291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203212"},
        {"Hipparcos Number", "HIP 105768"},
        {"Geneva Identification System", "GEN# +1.00203212"},
        {"Smithsonian Astrophysical Observation", "SAO 257920"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.32505314),
        dec: Angle.Degrees(-71.79907257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91179"},
        {"Hipparcos Number", "HIP 51319"},
        {"Smithsonian Astrophysical Observation", "SAO 256717"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.23739250),
        dec: Angle.Degrees(-71.79789277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73373"},
        {"Hipparcos Number", "HIP 41916"},
        {"Smithsonian Astrophysical Observation", "SAO 256523"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.18596132),
        dec: Angle.Degrees(-71.79548916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135338"},
        {"Hipparcos Number", "HIP 74999"},
        {"Smithsonian Astrophysical Observation", "SAO 257264"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.87115306),
        dec: Angle.Degrees(-71.79202090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94817"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.40248306),
        dec: Angle.Degrees(-71.78626570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168479"},
        {"Hipparcos Number", "HIP 90380"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.63066542),
        dec: Angle.Degrees(-71.78605768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98877"},
        {"Hipparcos Number", "HIP 55457"},
        {"Geneva Identification System", "GEN# +1.00098877"},
        {"Smithsonian Astrophysical Observation", "SAO 256830"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.36424800),
        dec: Angle.Degrees(-71.78598575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90378"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.62161137),
        dec: Angle.Degrees(-71.78441142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103941"},
        {"Hipparcos Number", "HIP 58351"},
        {"Renson", "Renson 30030"},
        {"Smithsonian Astrophysical Observation", "SAO 256890"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.49578849),
        dec: Angle.Degrees(-71.78316710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168873"},
        {"Hipparcos Number", "HIP 90553"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.15844138),
        dec: Angle.Degrees(-71.78296262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4577"},
        {"Hipparcos Number", "HIP 3616"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.59583180),
        dec: Angle.Degrees(-71.78242174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82458"},
        {"Hipparcos Number", "HIP 46407"},
        {"Geneva Identification System", "GEN# +1.00082458"},
        {"Smithsonian Astrophysical Observation", "SAO 256625"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.95494967),
        dec: Angle.Degrees(-71.78120370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208373"},
        {"Hipparcos Number", "HIP 108551"},
        {"Smithsonian Astrophysical Observation", "SAO 257986"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.84297037),
        dec: Angle.Degrees(-71.77943247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49268"},
        {"Hipparcos Number", "HIP 31977"},
        {"Geneva Identification System", "GEN# +1.00049268J"},
        {"Smithsonian Astrophysical Observation", "SAO 256326"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.23984360),
        dec: Angle.Degrees(-71.77509320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88130"},
        {"Hipparcos Number", "HIP 49509"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.62857000),
        dec: Angle.Degrees(-71.77396215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181488"},
        {"Hipparcos Number", "HIP 95626"},
        {"Geneva Identification System", "GEN# +1.00181488"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.74841637),
        dec: Angle.Degrees(-71.77223686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186484"},
        {"Hipparcos Number", "HIP 97644"},
        {"Smithsonian Astrophysical Observation", "SAO 257742"},
        {"Wilson Evans Batten Catalogue", "WEB 17169"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.68117476),
        dec: Angle.Degrees(-71.77144402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87518"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.20863975),
        dec: Angle.Degrees(-71.76964322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82937"},
        {"Hipparcos Number", "HIP 46666"},
        {"Smithsonian Astrophysical Observation", "SAO 256630"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.72064825),
        dec: Angle.Degrees(-71.76927204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169979"},
        {"Hipparcos Number", "HIP 90997"},
        {"Geneva Identification System", "GEN# +1.00169979"},
        {"Smithsonian Astrophysical Observation", "SAO 257603"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.44772031),
        dec: Angle.Degrees(-71.76863697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102521"},
        {"Hipparcos Number", "HIP 57531"},
        {"Smithsonian Astrophysical Observation", "SAO 256875"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.87213152),
        dec: Angle.Degrees(-71.76837752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147247"},
        {"Hipparcos Number", "HIP 80554"},
        {"Smithsonian Astrophysical Observation", "SAO 257398"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.70434818),
        dec: Angle.Degrees(-71.76820653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158281"},
        {"Hipparcos Number", "HIP 86042"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.75900687),
        dec: Angle.Degrees(-71.76695668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122003"},
        {"Hipparcos Number", "HIP 68572"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.58267615),
        dec: Angle.Degrees(-71.76626521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63056"},
        {"Hipparcos Number", "HIP 37403"},
        {"Smithsonian Astrophysical Observation", "SAO 256435"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.19632964),
        dec: Angle.Degrees(-71.76296550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23253"},
        {"Hipparcos Number", "HIP 16939"},
        {"Fundamental Katalog 5th Edition", "FK5 4326"},
        {"Smithsonian Astrophysical Observation", "SAO 256003"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.50174357),
        dec: Angle.Degrees(-71.75994602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183295"},
        {"Hipparcos Number", "HIP 96320"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.76611054),
        dec: Angle.Degrees(-71.75484892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311443"},
        {"Hipparcos Number", "HIP 42855"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.00046641),
        dec: Angle.Degrees(-71.75293808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57920"},
        {"Hipparcos Number", "HIP 35243"},
        {"Geneva Identification System", "GEN# +1.00057920"},
        {"Smithsonian Astrophysical Observation", "SAO 256390"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.23978324),
        dec: Angle.Degrees(-71.74989632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97618"},
        {"Hipparcos Number", "HIP 54740"},
        {"Smithsonian Astrophysical Observation", "SAO 256810"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.12443241),
        dec: Angle.Degrees(-71.74937914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208324"},
        {"Hipparcos Number", "HIP 108524"},
        {"Smithsonian Astrophysical Observation", "SAO 257985"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.78472534),
        dec: Angle.Degrees(-71.74872720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95894"},
        {"Hipparcos Number", "HIP 53925"},
        {"Geneva Identification System", "GEN# +1.00095894"},
        {"Smithsonian Astrophysical Observation", "SAO 256785"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.51301934),
        dec: Angle.Degrees(-71.74707312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37878"},
        {"Hipparcos Number", "HIP 26178"},
        {"Smithsonian Astrophysical Observation", "SAO 256206"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.71330486),
        dec: Angle.Degrees(-71.74624897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139004"},
        {"Hipparcos Number", "HIP 76811"},
        {"Smithsonian Astrophysical Observation", "SAO 257309"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.24798787),
        dec: Angle.Degrees(-71.74476832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124816"},
        {"Hipparcos Number", "HIP 69994"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.84760147),
        dec: Angle.Degrees(-71.74379173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6623"},
        {"Hipparcos Number", "HIP 5082"},
        {"Geneva Identification System", "GEN# +1.00006623"},
        {"Smithsonian Astrophysical Observation", "SAO 255735"},
        {"Wilson Evans Batten Catalogue", "WEB 1046"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.28229565),
        dec: Angle.Degrees(-71.73406152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111290"},
        {"Hipparcos Number", "HIP 62587"},
        {"Geneva Identification System", "GEN# +1.00111290"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.37787555),
        dec: Angle.Degrees(-71.73146471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311354"},
        {"Hipparcos Number", "HIP 41243"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.22998817),
        dec: Angle.Degrees(-71.72254855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68950"},
        {"Hipparcos Number", "HIP 39899"},
        {"Smithsonian Astrophysical Observation", "SAO 256476"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.23689609),
        dec: Angle.Degrees(-71.72184010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311363"},
        {"Hipparcos Number", "HIP 39770"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.92215940),
        dec: Angle.Degrees(-71.72061294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64142"},
        {"Hipparcos Number", "HIP 37924"},
        {"Geneva Identification System", "GEN# +1.00064142"},
        {"Smithsonian Astrophysical Observation", "SAO 256447"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.57591332),
        dec: Angle.Degrees(-71.72043724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14585"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.07226653),
        dec: Angle.Degrees(-71.71941502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216804"},
        {"Hipparcos Number", "HIP 113394"},
        {"Smithsonian Astrophysical Observation", "SAO 258091"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.47601644),
        dec: Angle.Degrees(-71.71816346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269475"},
        {"Hipparcos Number", "HIP 25146"},
        {"Geneva Identification System", "GEN# +1.00269475"},
    },
    visualMagnitude: 11.58,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.71329723),
        dec: Angle.Degrees(-71.71785664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90457"},
        {"Hipparcos Number", "HIP 50913"},
        {"Smithsonian Astrophysical Observation", "SAO 256708"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.94801884),
        dec: Angle.Degrees(-71.71557859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110760"},
        {"Hipparcos Number", "HIP 62247"},
        {"Smithsonian Astrophysical Observation", "SAO 256979"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.35858001),
        dec: Angle.Degrees(-71.71129563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139536"},
        {"Hipparcos Number", "HIP 77049"},
        {"Geneva Identification System", "GEN# +1.00139536"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.99724528),
        dec: Angle.Degrees(-71.70467384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9163"},
        {"Hipparcos Number", "HIP 6812"},
        {"Fundamental Katalog 5th Edition", "FK5 2097"},
        {"Geneva Identification System", "GEN# +1.00009163"},
        {"Smithsonian Astrophysical Observation", "SAO 255779"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.91238195),
        dec: Angle.Degrees(-71.70424184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24115"},
        {"Hipparcos Number", "HIP 17488"},
        {"Geneva Identification System", "GEN# +1.00024115"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.19774876),
        dec: Angle.Degrees(-71.70343498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44447"},
        {"Hipparcos Number", "HIP 29673"},
        {"Geneva Identification System", "GEN# +1.00044447"},
        {"Smithsonian Astrophysical Observation", "SAO 256285"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.77519937),
        dec: Angle.Degrees(-71.70289813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117461"},
        {"Hipparcos Number", "HIP 66095"},
        {"Smithsonian Astrophysical Observation", "SAO 257061"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.22760123),
        dec: Angle.Degrees(-71.70048215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225231"},
        {"Hipparcos Number", "HIP 361"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.14780002),
        dec: Angle.Degrees(-71.69499867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92304"},
        {"Hipparcos Number", "HIP 51967"},
        {"Smithsonian Astrophysical Observation", "SAO 256733"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.25655050),
        dec: Angle.Degrees(-71.69163572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86963"},
        {"Hipparcos Number", "HIP 48907"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.64759984),
        dec: Angle.Degrees(-71.68945769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83817"},
        {"Hipparcos Number", "HIP 47188"},
        {"Renson", "Renson 23900"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.25848307),
        dec: Angle.Degrees(-71.68918962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111039"},
        {"Hipparcos Number", "HIP 62426"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.90167696),
        dec: Angle.Degrees(-71.68344316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15749"},
        {"Smithsonian Astrophysical Observation", "SAO 255984"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.72789784),
        dec: Angle.Degrees(-71.68249531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154079"},
        {"Hipparcos Number", "HIP 83952"},
        {"Geneva Identification System", "GEN# +1.00154079"},
        {"Smithsonian Astrophysical Observation", "SAO 257466"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.41340761),
        dec: Angle.Degrees(-71.67985147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141303"},
        {"Hipparcos Number", "HIP 77867"},
        {"Smithsonian Astrophysical Observation", "SAO 257332"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.50227964),
        dec: Angle.Degrees(-71.67694610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145585"},
        {"Hipparcos Number", "HIP 79830"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.41980942),
        dec: Angle.Degrees(-71.67279211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189973"},
        {"Hipparcos Number", "HIP 99226"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.14439524),
        dec: Angle.Degrees(-71.66898810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108314"},
        {"Hipparcos Number", "HIP 60763"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.82915446),
        dec: Angle.Degrees(-71.66744480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133684"},
        {"Hipparcos Number", "HIP 74254"},
        {"Smithsonian Astrophysical Observation", "SAO 257244"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.63253934),
        dec: Angle.Degrees(-71.66438959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221086"},
        {"Hipparcos Number", "HIP 115973"},
        {"Smithsonian Astrophysical Observation", "SAO 258149"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.45639709),
        dec: Angle.Degrees(-71.66317423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74046"},
        {"Hipparcos Number", "HIP 42210"},
        {"Smithsonian Astrophysical Observation", "SAO 256528"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09277717),
        dec: Angle.Degrees(-71.65995678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193234"},
        {"Hipparcos Number", "HIP 100679"},
        {"Geneva Identification System", "GEN# +1.00193234"},
        {"Smithsonian Astrophysical Observation", "SAO 257803"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.18397448),
        dec: Angle.Degrees(-71.65912675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24188"},
        {"Hipparcos Number", "HIP 17543"},
        {"Fundamental Katalog 5th Edition", "FK5 2269"},
        {"Geneva Identification System", "GEN# +1.00024188"},
        {"Renson", "Renson 6210"},
        {"Smithsonian Astrophysical Observation", "SAO 256025"},
        {"Wilson Evans Batten Catalogue", "WEB 3329"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.34873335),
        dec: Angle.Degrees(-71.65823679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44408"},
        {"Hipparcos Number", "HIP 29660"},
        {"Fundamental Katalog 5th Edition", "FK5 2482"},
        {"Smithsonian Astrophysical Observation", "SAO 256284"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.72824139),
        dec: Angle.Degrees(-71.65602983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101603"},
        {"Hipparcos Number", "HIP 56978"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.20867275),
        dec: Angle.Degrees(-71.65571043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94131"},
        {"Hipparcos Number", "HIP 52947"},
        {"Geneva Identification System", "GEN# +1.00094131"},
        {"Smithsonian Astrophysical Observation", "SAO 256759"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.42551615),
        dec: Angle.Degrees(-71.65420489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137366"},
        {"Hipparcos Number", "HIP 75959"},
        {"Smithsonian Astrophysical Observation", "SAO 257284"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.70497336),
        dec: Angle.Degrees(-71.65408347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47673"},
        {"Hipparcos Number", "HIP 31242"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.29437788),
        dec: Angle.Degrees(-71.64830702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11798"},
        {"Hipparcos Number", "HIP 8745"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.12922825),
        dec: Angle.Degrees(-71.64800921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17814"},
        {"Hipparcos Number", "HIP 12987"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.75353311),
        dec: Angle.Degrees(-71.64702131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110022"},
        {"Hipparcos Number", "HIP 61833"},
        {"Smithsonian Astrophysical Observation", "SAO 256969"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.07146849),
        dec: Angle.Degrees(-71.64519662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164872"},
        {"Hipparcos Number", "HIP 89002"},
        {"Geneva Identification System", "GEN# +1.00164872"},
        {"Smithsonian Astrophysical Observation", "SAO 257568"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.47854333),
        dec: Angle.Degrees(-71.64504138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11084"},
        {"Hipparcos Number", "HIP 8228"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.49108870),
        dec: Angle.Degrees(-71.64441840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190423"},
        {"Hipparcos Number", "HIP 99407"},
        {"Smithsonian Astrophysical Observation", "SAO 257779"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.64486395),
        dec: Angle.Degrees(-71.64230484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26823"},
        {"Hipparcos Number", "HIP 19330"},
        {"Geneva Identification System", "GEN# +1.00026823"},
        {"Smithsonian Astrophysical Observation", "SAO 256064"},
        {"Wilson Evans Batten Catalogue", "WEB 3716"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.13937720),
        dec: Angle.Degrees(-71.64010608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 106.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38417"},
        {"Hipparcos Number", "HIP 26567"},
        {"Renson", "Renson 10330"},
        {"Smithsonian Astrophysical Observation", "SAO 256219"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.73056280),
        dec: Angle.Degrees(-71.63900603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92899"},
        {"Hipparcos Number", "HIP 52305"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.31565355),
        dec: Angle.Degrees(-71.63742854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14979"},
        {"Hipparcos Number", "HIP 10941"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.22969768),
        dec: Angle.Degrees(-71.63513805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11598"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.37986475),
        dec: Angle.Degrees(-71.63298935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 299.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72801"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.21345748),
        dec: Angle.Degrees(-71.63086999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96143"},
        {"Hipparcos Number", "HIP 54044"},
        {"Geneva Identification System", "GEN# +1.00096143"},
        {"Smithsonian Astrophysical Observation", "SAO 256791"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.88249235),
        dec: Angle.Degrees(-71.62884835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220443"},
        {"Hipparcos Number", "HIP 115588"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.20416645),
        dec: Angle.Degrees(-71.62741583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111442"},
        {"Hipparcos Number", "HIP 62671"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.63368267),
        dec: Angle.Degrees(-71.62290102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209555"},
        {"Hipparcos Number", "HIP 109219"},
        {"Smithsonian Astrophysical Observation", "SAO 257999"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.88271701),
        dec: Angle.Degrees(-71.62283409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109885"},
        {"Hipparcos Number", "HIP 61751"},
        {"Geneva Identification System", "GEN# +1.00109885"},
        {"Smithsonian Astrophysical Observation", "SAO 256968"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.82990318),
        dec: Angle.Degrees(-71.62179788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80160"},
        {"Hipparcos Number", "HIP 45275"},
        {"Celescope Catalog", "CEL 3241"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.41445260),
        dec: Angle.Degrees(-71.61786381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213851"},
        {"Hipparcos Number", "HIP 111632"},
        {"Fundamental Katalog 5th Edition", "FK5 5996"},
        {"Smithsonian Astrophysical Observation", "SAO 258054"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.21800035),
        dec: Angle.Degrees(-71.61618681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200772"},
        {"Hipparcos Number", "HIP 104498"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.52009067),
        dec: Angle.Degrees(-71.61095682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13220"},
        {"Hipparcos Number", "HIP 9773"},
        {"Geneva Identification System", "GEN# +1.00013220"},
        {"Smithsonian Astrophysical Observation", "SAO 255847"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.42167101),
        dec: Angle.Degrees(-71.60684671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39581"},
        {"Hipparcos Number", "HIP 27272"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.69816337),
        dec: Angle.Degrees(-71.60351033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102239"},
        {"Hipparcos Number", "HIP 57347"},
        {"Smithsonian Astrophysical Observation", "SAO 256870"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.36903862),
        dec: Angle.Degrees(-71.60348635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82350"},
        {"Hipparcos Number", "HIP 46358"},
        {"Geneva Identification System", "GEN# +1.00082350"},
        {"Smithsonian Astrophysical Observation", "SAO 256623"},
        {"Wilson Evans Batten Catalogue", "WEB 8764"},
    },
    visualMagnitude: 5.46,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.77707532),
        dec: Angle.Degrees(-71.60209195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181982"},
        {"Hipparcos Number", "HIP 95773"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.19357886),
        dec: Angle.Degrees(-71.59696945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52224"},
        {"Hipparcos Number", "HIP 33115"},
        {"Smithsonian Astrophysical Observation", "SAO 256348"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.45743299),
        dec: Angle.Degrees(-71.59687091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111079"},
        {"Hipparcos Number", "HIP 62451"},
        {"Geneva Identification System", "GEN# +1.00111079"},
        {"Smithsonian Astrophysical Observation", "SAO 256980"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.98099011),
        dec: Angle.Degrees(-71.59613922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126360"},
        {"Hipparcos Number", "HIP 70804"},
        {"Smithsonian Astrophysical Observation", "SAO 257164"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.20510731),
        dec: Angle.Degrees(-71.59026852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176372"},
        {"Hipparcos Number", "HIP 93829"},
        {"Smithsonian Astrophysical Observation", "SAO 257657"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.61283457),
        dec: Angle.Degrees(-71.58220669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82904"},
        {"Hipparcos Number", "HIP 46661"},
        {"Geneva Identification System", "GEN# +1.00082904"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.70614702),
        dec: Angle.Degrees(-71.58034668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89124"},
        {"Hipparcos Number", "HIP 50106"},
        {"Geneva Identification System", "GEN# +1.00089124"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.44513141),
        dec: Angle.Degrees(-71.57678286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144633"},
        {"Hipparcos Number", "HIP 79435"},
        {"Smithsonian Astrophysical Observation", "SAO 257370"},
    },
    visualMagnitude: 8.13,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.17958192),
        dec: Angle.Degrees(-71.57503892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220006"},
        {"Hipparcos Number", "HIP 115333"},
        {"Smithsonian Astrophysical Observation", "SAO 258131"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.41037438),
        dec: Angle.Degrees(-71.57457409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31853"},
        {"Hipparcos Number", "HIP 22686"},
        {"Geneva Identification System", "GEN# +1.00031853"},
        {"Smithsonian Astrophysical Observation", "SAO 256138"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.18082283),
        dec: Angle.Degrees(-71.57294696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 133.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165564"},
        {"Hipparcos Number", "HIP 89284"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.28101721),
        dec: Angle.Degrees(-71.57148301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202731"},
        {"Hipparcos Number", "HIP 105518"},
        {"Smithsonian Astrophysical Observation", "SAO 257915"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.56766992),
        dec: Angle.Degrees(-71.57128509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138914"},
        {"Hipparcos Number", "HIP 76747"},
        {"Geneva Identification System", "GEN# +1.00138914"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.08032925),
        dec: Angle.Degrees(-71.56775532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117373"},
        {"Hipparcos Number", "HIP 66038"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.07905290),
        dec: Angle.Degrees(-71.56213534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91345"},
        {"Hipparcos Number", "HIP 51415"},
        {"Geneva Identification System", "GEN# +1.00091345"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.52019966),
        dec: Angle.Degrees(-71.56102562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201559"},
        {"Hipparcos Number", "HIP 104889"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.70559112),
        dec: Angle.Degrees(-71.55629347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89928"},
        {"Hipparcos Number", "HIP 50567"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.94255046),
        dec: Angle.Degrees(-71.55488214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189995"},
        {"Hipparcos Number", "HIP 99227"},
        {"Renson", "Renson 52720"},
        {"Smithsonian Astrophysical Observation", "SAO 257778"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.14764791),
        dec: Angle.Degrees(-71.55251492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6222"},
        {"Hipparcos Number", "HIP 4793"},
        {"Geneva Identification System", "GEN# +1.00006222"},
        {"Smithsonian Astrophysical Observation", "SAO 255730"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.38785937),
        dec: Angle.Degrees(-71.54945038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112985"},
        {"Hipparcos Number", "HIP 63613"},
        {"Fundamental Katalog 5th Edition", "FK5 487"},
        {"Geneva Identification System", "GEN# +1.00112985"},
        {"Smithsonian Astrophysical Observation", "SAO 257000"},
        {"Wilson Evans Batten Catalogue", "WEB 11256"},
    },
    visualMagnitude: 3.61,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.56573968),
        dec: Angle.Degrees(-71.54879865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177222"},
        {"Hipparcos Number", "HIP 94168"},
        {"Fundamental Katalog 5th Edition", "FK5 3524"},
        {"Smithsonian Astrophysical Observation", "SAO 257662"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.53445204),
        dec: Angle.Degrees(-71.54855070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63429"},
        {"Hipparcos Number", "HIP 37598"},
        {"Fundamental Katalog 5th Edition", "FK5 4696"},
        {"Smithsonian Astrophysical Observation", "SAO 256445"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.71664387),
        dec: Angle.Degrees(-71.54197613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3376"},
        {"Hipparcos Number", "HIP 2806"},
        {"Smithsonian Astrophysical Observation", "SAO 255683"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.92982790),
        dec: Angle.Degrees(-71.54124302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203851"},
        {"Hipparcos Number", "HIP 106063"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.24926889),
        dec: Angle.Degrees(-71.53973056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14199"},
        {"Hipparcos Number", "HIP 10405"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.51812492),
        dec: Angle.Degrees(-71.53789250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91540"},
        {"Hipparcos Number", "HIP 51545"},
        {"Geneva Identification System", "GEN# +1.00091540"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.91881281),
        dec: Angle.Degrees(-71.53654650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175033"},
        {"Hipparcos Number", "HIP 93271"},
        {"Smithsonian Astrophysical Observation", "SAO 257646"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.99286399),
        dec: Angle.Degrees(-71.53472985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106419"},
        {"Hipparcos Number", "HIP 59714"},
        {"Geneva Identification System", "GEN# +1.00106419"},
        {"Smithsonian Astrophysical Observation", "SAO 256917"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.70554880),
        dec: Angle.Degrees(-71.53428007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119286"},
        {"Hipparcos Number", "HIP 67098"},
        {"Fundamental Katalog 5th Edition", "FK5 5216"},
        {"Smithsonian Astrophysical Observation", "SAO 257087"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.28676147),
        dec: Angle.Degrees(-71.53297445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35324"},
        {"Hipparcos Number", "HIP 24656"},
        {"Smithsonian Astrophysical Observation", "SAO 256173"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.35767891),
        dec: Angle.Degrees(-71.53292522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198652"},
        {"Hipparcos Number", "HIP 103374"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.15692101),
        dec: Angle.Degrees(-71.53141028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214636"},
        {"Hipparcos Number", "HIP 112066"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.48754875),
        dec: Angle.Degrees(-71.52857924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198210"},
        {"Hipparcos Number", "HIP 103129"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.42168910),
        dec: Angle.Degrees(-71.51788325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71046"},
        {"Hipparcos Number", "HIP 40817"},
        {"Geneva Identification System", "GEN# +1.00071046A"},
        {"Renson", "Renson 19636"},
        {"Smithsonian Astrophysical Observation", "SAO 256497"},
        {"Wilson Evans Batten Catalogue", "WEB 7920"},
    },
    visualMagnitude: 5.33,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.95414818),
        dec: Angle.Degrees(-71.51499632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180498"},
        {"Hipparcos Number", "HIP 95279"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.76500599),
        dec: Angle.Degrees(-71.50859273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36062"},
        {"Hipparcos Number", "HIP 25100"},
        {"Geneva Identification System", "GEN# +1.00036062"},
        {"Smithsonian Astrophysical Observation", "SAO 256180"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.60545345),
        dec: Angle.Degrees(-71.50666803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46921"},
        {"Hipparcos Number", "HIP 30922"},
        {"Geneva Identification System", "GEN# +1.00046921"},
        {"Smithsonian Astrophysical Observation", "SAO 256306"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.34876269),
        dec: Angle.Degrees(-71.50666635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101713"},
        {"Hipparcos Number", "HIP 57043"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.42664001),
        dec: Angle.Degrees(-71.50636278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30306"},
        {"Hipparcos Number", "HIP 21731"},
        {"Geneva Identification System", "GEN# +1.00030306"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.99219451),
        dec: Angle.Degrees(-71.50552959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71066"},
        {"Hipparcos Number", "HIP 40834"},
        {"Geneva Identification System", "GEN# +1.00071066"},
        {"Renson", "Renson 19650"},
        {"Smithsonian Astrophysical Observation", "SAO 256499"},
    },
    visualMagnitude: 5.63,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.00232960),
        dec: Angle.Degrees(-71.50546247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169127"},
        {"Hipparcos Number", "HIP 90644"},
        {"Smithsonian Astrophysical Observation", "SAO 257596"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.42822023),
        dec: Angle.Degrees(-71.50425255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140470"},
        {"Hipparcos Number", "HIP 77475"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.28149834),
        dec: Angle.Degrees(-71.50322870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205582"},
        {"Hipparcos Number", "HIP 107010"},
        {"Geneva Identification System", "GEN# +1.00205582"},
        {"Smithsonian Astrophysical Observation", "SAO 257945"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.09640829),
        dec: Angle.Degrees(-71.50320116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 387.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30568"},
        {"Hipparcos Number", "HIP 21897"},
        {"Geneva Identification System", "GEN# +1.00030568"},
        {"Smithsonian Astrophysical Observation", "SAO 256121"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.60209325),
        dec: Angle.Degrees(-71.49588470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132004"},
        {"Hipparcos Number", "HIP 73500"},
        {"Fundamental Katalog 5th Edition", "FK5 3181"},
        {"Geneva Identification System", "GEN# +1.00132004"},
        {"Smithsonian Astrophysical Observation", "SAO 257225"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.34426493),
        dec: Angle.Degrees(-71.49076193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104570"},
        {"Hipparcos Number", "HIP 58706"},
        {"Geneva Identification System", "GEN# +1.00104570"},
        {"Smithsonian Astrophysical Observation", "SAO 256897"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.61910492),
        dec: Angle.Degrees(-71.48900826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13927"},
        {"Hipparcos Number", "HIP 10248"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.95384878),
        dec: Angle.Degrees(-71.48403541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88189"},
        {"Hipparcos Number", "HIP 49546"},
        {"Geneva Identification System", "GEN# +1.00088189"},
        {"Smithsonian Astrophysical Observation", "SAO 256683"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.74963671),
        dec: Angle.Degrees(-71.47797340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113120"},
        {"Hipparcos Number", "HIP 63688"},
        {"Geneva Identification System", "GEN# +1.00113120"},
        {"Smithsonian Astrophysical Observation", "SAO 257003"},
        {"Wilson Evans Batten Catalogue", "WEB 11267"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.77233515),
        dec: Angle.Degrees(-71.47572327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4341"},
    },
    visualMagnitude: 11.99,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.91832290),
        dec: Angle.Degrees(-71.47515232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211851"},
        {"Hipparcos Number", "HIP 110490"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.71625808),
        dec: Angle.Degrees(-71.47439214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159886"},
        {"Hipparcos Number", "HIP 86759"},
        {"Smithsonian Astrophysical Observation", "SAO 257524"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.91556436),
        dec: Angle.Degrees(-71.47259143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59640"},
        {"Hipparcos Number", "HIP 35946"},
        {"Fundamental Katalog 5th Edition", "FK5 2576"},
        {"Smithsonian Astrophysical Observation", "SAO 256408"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.15463980),
        dec: Angle.Degrees(-71.47075644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184561"},
        {"Hipparcos Number", "HIP 96853"},
        {"Smithsonian Astrophysical Observation", "SAO 257717"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.30602733),
        dec: Angle.Degrees(-71.47037704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116909"},
        {"Hipparcos Number", "HIP 65784"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.28704548),
        dec: Angle.Degrees(-71.46907279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14643"},
        {"Hipparcos Number", "HIP 10722"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.50333918),
        dec: Angle.Degrees(-71.46747297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127162"},
        {"Hipparcos Number", "HIP 71215"},
        {"Geneva Identification System", "GEN# +1.00127162"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.45043688),
        dec: Angle.Degrees(-71.46693127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181464"},
        {"Hipparcos Number", "HIP 95607"},
        {"Geneva Identification System", "GEN# +1.00181464"},
        {"Smithsonian Astrophysical Observation", "SAO 257686"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.68590230),
        dec: Angle.Degrees(-71.46605310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181354"},
        {"Hipparcos Number", "HIP 95565"},
        {"Smithsonian Astrophysical Observation", "SAO 257685"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.58281039),
        dec: Angle.Degrees(-71.46588929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17215"},
        {"Hipparcos Number", "HIP 12548"},
        {"Geneva Identification System", "GEN# +1.00017215J"},
        {"Smithsonian Astrophysical Observation", "SAO 255913"},
        {"Wilson Evans Batten Catalogue", "WEB 2563"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.36258001),
        dec: Angle.Degrees(-71.46233499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53830"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.20006260),
        dec: Angle.Degrees(-71.45817695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86089"},
        {"Hipparcos Number", "HIP 48458"},
        {"Geneva Identification System", "GEN# +1.00086089"},
        {"Smithsonian Astrophysical Observation", "SAO 256667"},
        {"Wilson Evans Batten Catalogue", "WEB 9035"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.20217514),
        dec: Angle.Degrees(-71.45444658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146006"},
        {"Hipparcos Number", "HIP 80002"},
        {"Smithsonian Astrophysical Observation", "SAO 257386"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.96464567),
        dec: Angle.Degrees(-71.44876214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21139"},
        {"Hipparcos Number", "HIP 15485"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.90159966),
        dec: Angle.Degrees(-71.44184105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225253"},
        {"Hipparcos Number", "HIP 377"},
        {"Fundamental Katalog 5th Edition", "FK5 1001"},
        {"Geneva Identification System", "GEN# +1.00225253"},
        {"Renson", "Renson 61770"},
        {"Smithsonian Astrophysical Observation", "SAO 255631"},
        {"Wilson Evans Batten Catalogue", "WEB 56"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.17188841),
        dec: Angle.Degrees(-71.43685835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97472"},
        {"Hipparcos Number", "HIP 54673"},
        {"Geneva Identification System", "GEN# +1.00097472"},
        {"Smithsonian Astrophysical Observation", "SAO 256808"},
    },
    visualMagnitude: 6.34,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.87321458),
        dec: Angle.Degrees(-71.43619887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66771"},
        {"Hipparcos Number", "HIP 39045"},
        {"Geneva Identification System", "GEN# +1.00066771"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.82247946),
        dec: Angle.Degrees(-71.43345724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171759"},
        {"Hipparcos Number", "HIP 91792"},
        {"Fundamental Katalog 5th Edition", "FK5 698"},
        {"Geneva Identification System", "GEN# +1.00171759"},
        {"Smithsonian Astrophysical Observation", "SAO 257620"},
        {"Wilson Evans Batten Catalogue", "WEB 15794"},
    },
    visualMagnitude: 4.01,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.75889095),
        dec: Angle.Degrees(-71.42772867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1174"},
        {"Hipparcos Number", "HIP 1250"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.92054998),
        dec: Angle.Degrees(-71.42612010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216000"},
        {"Hipparcos Number", "HIP 112844"},
        {"Geneva Identification System", "GEN# +1.00216000"},
        {"Smithsonian Astrophysical Observation", "SAO 258077"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.78715883),
        dec: Angle.Degrees(-71.42519619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108341"},
        {"Hipparcos Number", "HIP 60788"},
        {"Geneva Identification System", "GEN# +1.00108341"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.88172932),
        dec: Angle.Degrees(-71.42325821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9643"},
        {"Hipparcos Number", "HIP 7142"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.01125757),
        dec: Angle.Degrees(-71.42200061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100595"},
        {"Hipparcos Number", "HIP 56394"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.41653685),
        dec: Angle.Degrees(-71.41220159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211372"},
        {"Hipparcos Number", "HIP 110209"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.86258075),
        dec: Angle.Degrees(-71.40863576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104937"},
        {"Hipparcos Number", "HIP 58930"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.25192500),
        dec: Angle.Degrees(-71.40620266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187051"},
        {"Hipparcos Number", "HIP 97911"},
        {"Smithsonian Astrophysical Observation", "SAO 257745"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.45323096),
        dec: Angle.Degrees(-71.40608766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269172"},
        {"Hipparcos Number", "HIP 24006"},
        {"Geneva Identification System", "GEN# +1.00269172"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.41212965),
        dec: Angle.Degrees(-71.40062132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149859"},
        {"Hipparcos Number", "HIP 81877"},
        {"Smithsonian Astrophysical Observation", "SAO 257427"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.86963373),
        dec: Angle.Degrees(-71.40050454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18982",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18982"},
        {"Smithsonian Astrophysical Observation", "SAO 256058"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.00533199),
        dec: Angle.Degrees(-71.39960615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124729"},
        {"Hipparcos Number", "HIP 69956"},
        {"Smithsonian Astrophysical Observation", "SAO 257135"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.73243091),
        dec: Angle.Degrees(-71.39648428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53989"},
        {"Hipparcos Number", "HIP 33766"},
        {"Geneva Identification System", "GEN# +1.00053989"},
        {"Smithsonian Astrophysical Observation", "SAO 256359"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.18945860),
        dec: Angle.Degrees(-71.39635780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131394"},
        {"Hipparcos Number", "HIP 73219"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.46186201),
        dec: Angle.Degrees(-71.39299609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86606"},
        {"Hipparcos Number", "HIP 48715"},
        {"Fundamental Katalog 5th Edition", "FK5 2799"},
        {"Geneva Identification System", "GEN# +1.00086606"},
        {"Smithsonian Astrophysical Observation", "SAO 256672"},
        {"Wilson Evans Batten Catalogue", "WEB 9060"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.04066795),
        dec: Angle.Degrees(-71.38930933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129331"},
        {"Hipparcos Number", "HIP 72207"},
        {"Renson", "Renson 36870"},
        {"Smithsonian Astrophysical Observation", "SAO 257192"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.52372866),
        dec: Angle.Degrees(-71.36289422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112585"},
        {"Hipparcos Number", "HIP 63384"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.83276243),
        dec: Angle.Degrees(-71.35978019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123689"},
        {"Hipparcos Number", "HIP 69406"},
        {"Geneva Identification System", "GEN# +1.00123689"},
        {"Smithsonian Astrophysical Observation", "SAO 257124"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.15408154),
        dec: Angle.Degrees(-71.34987870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197372"},
        {"Hipparcos Number", "HIP 102669"},
        {"Smithsonian Astrophysical Observation", "SAO 257851"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.07082590),
        dec: Angle.Degrees(-71.34899819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158786"},
        {"Hipparcos Number", "HIP 86268"},
        {"Smithsonian Astrophysical Observation", "SAO 257514"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.40624035),
        dec: Angle.Degrees(-71.34471997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27036"},
        {"Hipparcos Number", "HIP 19479"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.58429610),
        dec: Angle.Degrees(-71.34379590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269006"},
        {"Hipparcos Number", "HIP 23428"},
        {"Geneva Identification System", "GEN# +1.00269006"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.53079377),
        dec: Angle.Degrees(-71.33697655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114028"},
        {"Hipparcos Number", "HIP 64200"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.36494713),
        dec: Angle.Degrees(-71.33502914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58045"},
        {"Hipparcos Number", "HIP 35308"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.40199129),
        dec: Angle.Degrees(-71.33441573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72444"},
    },
    visualMagnitude: 12.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.20865230),
        dec: Angle.Degrees(-71.32832080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41412"},
        {"Hipparcos Number", "HIP 28264"},
        {"Smithsonian Astrophysical Observation", "SAO 256257"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.57937305),
        dec: Angle.Degrees(-71.32555015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170286"},
        {"Hipparcos Number", "HIP 91107"},
        {"Smithsonian Astrophysical Observation", "SAO 257605"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.76241914),
        dec: Angle.Degrees(-71.32392239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136289"},
        {"Hipparcos Number", "HIP 75447"},
        {"Smithsonian Astrophysical Observation", "SAO 257272"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.20276031),
        dec: Angle.Degrees(-71.32299309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194835"},
        {"Hipparcos Number", "HIP 101403"},
        {"Smithsonian Astrophysical Observation", "SAO 257820"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.25795037),
        dec: Angle.Degrees(-71.32050165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20862"},
        {"Hipparcos Number", "HIP 15248"},
        {"Smithsonian Astrophysical Observation", "SAO 255971"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.17280603),
        dec: Angle.Degrees(-71.31824115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75932"},
        {"Hipparcos Number", "HIP 43201"},
        {"Renson", "Renson 21240"},
        {"Smithsonian Astrophysical Observation", "SAO 256554"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.01310576),
        dec: Angle.Degrees(-71.31607622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33285"},
        {"Hipparcos Number", "HIP 23467"},
        {"Fundamental Katalog 5th Edition", "FK5 2380"},
        {"Geneva Identification System", "GEN# +1.00033285"},
        {"Smithsonian Astrophysical Observation", "SAO 256154"},
        {"Wilson Evans Batten Catalogue", "WEB 4568"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.67918703),
        dec: Angle.Degrees(-71.31432608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87285"},
        {"Geneva Identification System", "GEN# -0.07102179"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.52797634),
        dec: Angle.Degrees(-71.30986646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223134"},
        {"Hipparcos Number", "HIP 117326"},
        {"Smithsonian Astrophysical Observation", "SAO 258186"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.84676740),
        dec: Angle.Degrees(-71.30677560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38634"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.66617953),
        dec: Angle.Degrees(-71.30348202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151826"},
        {"Hipparcos Number", "HIP 82857"},
        {"Geneva Identification System", "GEN# +1.00151826"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.00043761),
        dec: Angle.Degrees(-71.29419026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224246"},
        {"Hipparcos Number", "HIP 118021"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.10026130),
        dec: Angle.Degrees(-71.29408942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171778"},
        {"Hipparcos Number", "HIP 91813"},
        {"Smithsonian Astrophysical Observation", "SAO 257621"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.79472047),
        dec: Angle.Degrees(-71.28839212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28722"},
        {"Hipparcos Number", "HIP 20662"},
        {"Smithsonian Astrophysical Observation", "SAO 256089"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.40916546),
        dec: Angle.Degrees(-71.28760164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146296"},
        {"Hipparcos Number", "HIP 80114"},
        {"Cincinnati Publication", "Ci 20 977"},
        {"Geneva Identification System", "GEN# +1.00146296"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.30066217),
        dec: Angle.Degrees(-71.28593611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -463.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -416.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225168"},
        {"Hipparcos Number", "HIP 315"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.99220988),
        dec: Angle.Degrees(-71.27863488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111876"},
        {"Hipparcos Number", "HIP 62916"},
        {"Geneva Identification System", "GEN# +1.00111876"},
        {"Smithsonian Astrophysical Observation", "SAO 256986"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.41594612),
        dec: Angle.Degrees(-71.27347858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55197"},
        {"Hipparcos Number", "HIP 34212"},
        {"Geneva Identification System", "GEN# +1.00055197"},
        {"Smithsonian Astrophysical Observation", "SAO 256369"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.40490042),
        dec: Angle.Degrees(-71.27292200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 262.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91424"},
        {"Hipparcos Number", "HIP 51467"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.68669971),
        dec: Angle.Degrees(-71.26988261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3112"},
        {"Hipparcos Number", "HIP 2629"},
        {"Fundamental Katalog 5th Edition", "FK5 2035"},
        {"Geneva Identification System", "GEN# +1.00003112"},
        {"Renson", "Renson 810"},
        {"Smithsonian Astrophysical Observation", "SAO 255679"},
        {"Wilson Evans Batten Catalogue", "WEB 481"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.34677242),
        dec: Angle.Degrees(-71.26621472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69600"},
        {"Hipparcos Number", "HIP 40173"},
        {"Geneva Identification System", "GEN# +1.00069600"},
        {"Smithsonian Astrophysical Observation", "SAO 256485"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.06646343),
        dec: Angle.Degrees(-71.26593650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195390"},
        {"Hipparcos Number", "HIP 101643"},
        {"Smithsonian Astrophysical Observation", "SAO 257825"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.05172232),
        dec: Angle.Degrees(-71.26107261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155056"},
        {"Hipparcos Number", "HIP 84420"},
        {"Smithsonian Astrophysical Observation", "SAO 257477"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.88566971),
        dec: Angle.Degrees(-71.25889902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13021"},
        {"Hipparcos Number", "HIP 9651"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.01771400),
        dec: Angle.Degrees(-71.25301220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1209"},
        {"Hipparcos Number", "HIP 1281"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.01317121),
        dec: Angle.Degrees(-71.25139922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102238"},
        {"Hipparcos Number", "HIP 57352"},
        {"Geneva Identification System", "GEN# +1.00102238"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.38345869),
        dec: Angle.Degrees(-71.24481212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213020"},
        {"Hipparcos Number", "HIP 111151"},
        {"Smithsonian Astrophysical Observation", "SAO 258046"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.78291132),
        dec: Angle.Degrees(-71.23890352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2386"},
        {"Hipparcos Number", "HIP 2124"},
        {"Geneva Identification System", "GEN# +1.00002386"},
        {"Smithsonian Astrophysical Observation", "SAO 255671"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.72774941),
        dec: Angle.Degrees(-71.23770125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17653"},
        {"Hipparcos Number", "HIP 12884"},
        {"Fundamental Katalog 5th Edition", "FK5 2192"},
        {"Geneva Identification System", "GEN# +1.00017653"},
        {"Smithsonian Astrophysical Observation", "SAO 255919"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.40357139),
        dec: Angle.Degrees(-71.23595606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196786"},
        {"Hipparcos Number", "HIP 102376"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.15139086),
        dec: Angle.Degrees(-71.23386136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124156"},
        {"Hipparcos Number", "HIP 69642"},
        {"Smithsonian Astrophysical Observation", "SAO 257129"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.79997476),
        dec: Angle.Degrees(-71.23365508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119700"},
        {"Hipparcos Number", "HIP 67302"},
        {"Smithsonian Astrophysical Observation", "SAO 257089"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.89273504),
        dec: Angle.Degrees(-71.23109832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4557"},
        {"Hipparcos Number", "HIP 3601"},
        {"Geneva Identification System", "GEN# +1.00004557"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.53179651),
        dec: Angle.Degrees(-71.22947970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104423"},
        {"Hipparcos Number", "HIP 58627"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.34778888),
        dec: Angle.Degrees(-71.22721406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98404"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.92159023),
        dec: Angle.Degrees(-71.21896294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97535"},
        {"Hipparcos Number", "HIP 54712"},
        {"Celescope Catalog", "CEL 3846"},
        {"Geneva Identification System", "GEN# +1.00097535J"},
        {"Smithsonian Astrophysical Observation", "SAO 256809"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.02310661),
        dec: Angle.Degrees(-71.21745689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138263"},
        {"Hipparcos Number", "HIP 76386"},
        {"Smithsonian Astrophysical Observation", "SAO 257299"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.02424091),
        dec: Angle.Degrees(-71.21663505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19307"},
        {"Hipparcos Number", "HIP 14083"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.39479222),
        dec: Angle.Degrees(-71.21057279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219026"},
        {"Hipparcos Number", "HIP 114693"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.50792897),
        dec: Angle.Degrees(-71.21016659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108251"},
        {"Hipparcos Number", "HIP 60734"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.71416799),
        dec: Angle.Degrees(-71.20957956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206873"},
        {"Hipparcos Number", "HIP 107670"},
        {"Renson", "Renson 57550"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.15023057),
        dec: Angle.Degrees(-71.20767423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89555"},
        {"Hipparcos Number", "HIP 50376"},
        {"Smithsonian Astrophysical Observation", "SAO 256697"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.28886973),
        dec: Angle.Degrees(-71.20576317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17367"},
        {"Hipparcos Number", "HIP 12674"},
        {"Smithsonian Astrophysical Observation", "SAO 255915"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.71020560),
        dec: Angle.Degrees(-71.20456333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157739"},
        {"Hipparcos Number", "HIP 85764"},
        {"Smithsonian Astrophysical Observation", "SAO 257506"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.87567509),
        dec: Angle.Degrees(-71.20444487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122908"},
        {"Hipparcos Number", "HIP 69037"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.98181434),
        dec: Angle.Degrees(-71.20202210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85767"},
    },
    visualMagnitude: 11.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.88250250),
        dec: Angle.Degrees(-71.20173758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215804"},
        {"Hipparcos Number", "HIP 112729"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.43822131),
        dec: Angle.Degrees(-71.19920885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192845"},
        {"Hipparcos Number", "HIP 100466"},
        {"Smithsonian Astrophysical Observation", "SAO 257797"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.60382693),
        dec: Angle.Degrees(-71.19603236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78940"},
    },
    visualMagnitude: 11.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.71739147),
        dec: Angle.Degrees(-71.19230527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195190"},
        {"Hipparcos Number", "HIP 101570"},
        {"Fundamental Katalog 5th Edition", "FK5 3642"},
        {"Smithsonian Astrophysical Observation", "SAO 257823"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.77641961),
        dec: Angle.Degrees(-71.18880857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94189"},
        {"Hipparcos Number", "HIP 52986"},
        {"Smithsonian Astrophysical Observation", "SAO 256761"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.58119854),
        dec: Angle.Degrees(-71.18122265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 222.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161499"},
        {"Hipparcos Number", "HIP 87473"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.08478610),
        dec: Angle.Degrees(-71.17716707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74726",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74726"},
    },
    visualMagnitude: 11.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.07554942),
        dec: Angle.Degrees(-71.17672943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120498"},
        {"Hipparcos Number", "HIP 67745"},
        {"Smithsonian Astrophysical Observation", "SAO 257096"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.16172409),
        dec: Angle.Degrees(-71.17621950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188205"},
        {"Hipparcos Number", "HIP 98414"},
        {"Geneva Identification System", "GEN# +1.00188205"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.94418168),
        dec: Angle.Degrees(-71.16894302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4333"},
        {"Hipparcos Number", "HIP 3488"},
        {"Fundamental Katalog 5th Edition", "FK5 4064"},
        {"Geneva Identification System", "GEN# +1.00004333"},
        {"Smithsonian Astrophysical Observation", "SAO 255700"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.13020057),
        dec: Angle.Degrees(-71.16867658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25938"},
        {"Hipparcos Number", "HIP 18729"},
        {"Fundamental Katalog 5th Edition", "FK5 1114"},
        {"Geneva Identification System", "GEN# +1.00025938"},
        {"Smithsonian Astrophysical Observation", "SAO 256053"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.18181862),
        dec: Angle.Degrees(-71.16688137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150981"},
        {"Hipparcos Number", "HIP 82416"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.63865725),
        dec: Angle.Degrees(-71.16626658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91908"},
        {"Hipparcos Number", "HIP 51740"},
        {"Smithsonian Astrophysical Observation", "SAO 256729"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.57358241),
        dec: Angle.Degrees(-71.16491650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311476"},
        {"Hipparcos Number", "HIP 45651"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.57858337),
        dec: Angle.Degrees(-71.16405674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179067"},
        {"Hipparcos Number", "HIP 94786"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.29625921),
        dec: Angle.Degrees(-71.16267509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90076"},
        {"Henry Draper 2", "HD 90077"},
        {"Hipparcos Number", "HIP 50682"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.24267118),
        dec: Angle.Degrees(-71.16264028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140950"},
        {"Hipparcos Number", "HIP 77690"},
        {"Smithsonian Astrophysical Observation", "SAO 257327"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.91886306),
        dec: Angle.Degrees(-71.15962885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311613"},
        {"Hipparcos Number", "HIP 50648"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.15709717),
        dec: Angle.Degrees(-71.15536814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5028"},
        {"Hipparcos Number", "HIP 3961"},
        {"Geneva Identification System", "GEN# +1.00005028"},
        {"Smithsonian Astrophysical Observation", "SAO 255713"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.71847773),
        dec: Angle.Degrees(-71.15152645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90037"},
        {"Hipparcos Number", "HIP 50651"},
        {"Smithsonian Astrophysical Observation", "SAO 256702"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.16820163),
        dec: Angle.Degrees(-71.14853875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135789"},
        {"Hipparcos Number", "HIP 75183"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.46337125),
        dec: Angle.Degrees(-71.14638921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16757"},
        {"Hipparcos Number", "HIP 12188"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.24790120),
        dec: Angle.Degrees(-71.14611006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210368"},
        {"Hipparcos Number", "HIP 109680"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.27116336),
        dec: Angle.Degrees(-71.14529337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 323.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122146"},
        {"Hipparcos Number", "HIP 68649"},
        {"Smithsonian Astrophysical Observation", "SAO 257109"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.78059552),
        dec: Angle.Degrees(-71.14207684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178683"},
        {"Hipparcos Number", "HIP 94658"},
        {"Smithsonian Astrophysical Observation", "SAO 257672"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.92828395),
        dec: Angle.Degrees(-71.14112547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77406"},
        {"Hipparcos Number", "HIP 43996"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.38356657),
        dec: Angle.Degrees(-71.13797801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164113"},
        {"Hipparcos Number", "HIP 88678"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.54762927),
        dec: Angle.Degrees(-71.13752549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148373"},
        {"Hipparcos Number", "HIP 81074"},
        {"Geneva Identification System", "GEN# +1.00148373"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.39225588),
        dec: Angle.Degrees(-71.13751935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132907"},
        {"Hipparcos Number", "HIP 73897"},
        {"Geneva Identification System", "GEN# +1.00132907"},
        {"Smithsonian Astrophysical Observation", "SAO 257236"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.54600835),
        dec: Angle.Degrees(-71.13188059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203818"},
        {"Hipparcos Number", "HIP 106035"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.17211030),
        dec: Angle.Degrees(-71.13022529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49267"},
        {"Hipparcos Number", "HIP 31991"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.26878486),
        dec: Angle.Degrees(-71.12576427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12299"},
        {"Hipparcos Number", "HIP 9109"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.33129136),
        dec: Angle.Degrees(-71.12566028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207306"},
        {"Hipparcos Number", "HIP 107883"},
        {"Smithsonian Astrophysical Observation", "SAO 257967"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.88134361),
        dec: Angle.Degrees(-71.12421375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147694"},
        {"Hipparcos Number", "HIP 80752"},
        {"Geneva Identification System", "GEN# +1.00147694"},
        {"Smithsonian Astrophysical Observation", "SAO 257403"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.31302301),
        dec: Angle.Degrees(-71.12389778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43226"},
        {"Hipparcos Number", "HIP 29124"},
        {"Renson", "Renson 11480"},
        {"Smithsonian Astrophysical Observation", "SAO 256272"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.12198562),
        dec: Angle.Degrees(-71.11999225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99871"},
        {"Hipparcos Number", "HIP 55980"},
        {"Geneva Identification System", "GEN# +1.00099871"},
        {"Smithsonian Astrophysical Observation", "SAO 256844"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.08798153),
        dec: Angle.Degrees(-71.11766877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222313"},
        {"Hipparcos Number", "HIP 116785"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.02035295),
        dec: Angle.Degrees(-71.11663644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8190"},
        {"Hipparcos Number", "HIP 6155"},
        {"Geneva Identification System", "GEN# +1.00008190"},
        {"Smithsonian Astrophysical Observation", "SAO 255761"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.73973472),
        dec: Angle.Degrees(-71.11571415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86532"},
        {"Hipparcos Number", "HIP 48685"},
        {"Smithsonian Astrophysical Observation", "SAO 256671"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.93626960),
        dec: Angle.Degrees(-71.11542372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79370"},
        {"Hipparcos Number", "HIP 44939"},
        {"Smithsonian Astrophysical Observation", "SAO 256589"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.30789061),
        dec: Angle.Degrees(-71.11346802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42727"},
    },
    visualMagnitude: 10.33,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.60695527),
        dec: Angle.Degrees(-71.11328050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152010"},
        {"Hipparcos Number", "HIP 82944"},
        {"Fundamental Katalog 5th Edition", "FK5 3341"},
        {"Smithsonian Astrophysical Observation", "SAO 257446"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.25443644),
        dec: Angle.Degrees(-71.11155701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95207"},
        {"Hipparcos Number", "HIP 53588"},
        {"Smithsonian Astrophysical Observation", "SAO 256776"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.44740829),
        dec: Angle.Degrees(-71.10742136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31080"},
        {"Hipparcos Number", "HIP 22214"},
        {"Geneva Identification System", "GEN# +1.00031080"},
        {"Smithsonian Astrophysical Observation", "SAO 256129"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.65946847),
        dec: Angle.Degrees(-71.10660745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3815"},
        {"Hipparcos Number", "HIP 3120"},
        {"Smithsonian Astrophysical Observation", "SAO 255693"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.92117533),
        dec: Angle.Degrees(-71.10354711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23425"},
        {"Hipparcos Number", "HIP 17095"},
        {"Geneva Identification System", "GEN# +1.00023425"},
        {"Smithsonian Astrophysical Observation", "SAO 256009"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.92405890),
        dec: Angle.Degrees(-71.09842275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160931"},
        {"Hipparcos Number", "HIP 87217"},
        {"Fundamental Katalog 5th Edition", "FK5 3409"},
        {"Geneva Identification System", "GEN# +1.00160931"},
        {"Smithsonian Astrophysical Observation", "SAO 257530"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.27993259),
        dec: Angle.Degrees(-71.09527565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195849"},
        {"Hipparcos Number", "HIP 101894"},
        {"Smithsonian Astrophysical Observation", "SAO 257834"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.73435110),
        dec: Angle.Degrees(-71.09443752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162401"},
        {"Hipparcos Number", "HIP 87898"},
        {"Smithsonian Astrophysical Observation", "SAO 257544"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.32244154),
        dec: Angle.Degrees(-71.09402686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209435"},
        {"Hipparcos Number", "HIP 109152"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.64632720),
        dec: Angle.Degrees(-71.09375373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206504"},
        {"Hipparcos Number", "HIP 107486"},
        {"Smithsonian Astrophysical Observation", "SAO 257956"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.56128721),
        dec: Angle.Degrees(-71.08469149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113883"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.95314052),
        dec: Angle.Degrees(-71.08446731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96525"},
        {"Hipparcos Number", "HIP 54225"},
        {"Smithsonian Astrophysical Observation", "SAO 256796"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.42582052),
        dec: Angle.Degrees(-71.08441460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311475"},
        {"Hipparcos Number", "HIP 45825"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.15524051),
        dec: Angle.Degrees(-71.08312451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127699"},
        {"Hipparcos Number", "HIP 71447"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.17248706),
        dec: Angle.Degrees(-71.08300829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146309"},
        {"Hipparcos Number", "HIP 80137"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.34811360),
        dec: Angle.Degrees(-71.07531163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223027"},
        {"Hipparcos Number", "HIP 117248"},
        {"Smithsonian Astrophysical Observation", "SAO 258182"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.61632002),
        dec: Angle.Degrees(-71.07436538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195459"},
        {"Hipparcos Number", "HIP 101676"},
        {"Smithsonian Astrophysical Observation", "SAO 257829"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.14981118),
        dec: Angle.Degrees(-71.07138140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169188"},
        {"Hipparcos Number", "HIP 90663"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.48423946),
        dec: Angle.Degrees(-71.07129250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88625"},
        {"Hipparcos Number", "HIP 49816"},
        {"Geneva Identification System", "GEN# +1.00088625"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.54440330),
        dec: Angle.Degrees(-71.06987126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144009"},
        {"Hipparcos Number", "HIP 79143"},
        {"Cincinnati Publication", "Ci 20 964"},
        {"Geneva Identification System", "GEN# +1.00144009"},
        {"Smithsonian Astrophysical Observation", "SAO 257366"},
        {"Wilson Evans Batten Catalogue", "WEB 13380"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.30758068),
        dec: Angle.Degrees(-71.06865107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -393.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174175"},
        {"Hipparcos Number", "HIP 92887"},
        {"Smithsonian Astrophysical Observation", "SAO 257639"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.89099620),
        dec: Angle.Degrees(-71.06739295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269660"},
        {"Hipparcos Number", "HIP 25815"},
        {"Geneva Identification System", "GEN# +8.58710042"},
        {"Geneva Identification System 2", "GEN# +1.00269660"},
    },
    visualMagnitude: 11.17,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.69904140),
        dec: Angle.Degrees(-71.06731541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191830"},
        {"Hipparcos Number", "HIP 100003"},
        {"Smithsonian Astrophysical Observation", "SAO 257787"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.32659056),
        dec: Angle.Degrees(-71.06714179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137509"},
        {"Hipparcos Number", "HIP 76011"},
        {"Geneva Identification System", "GEN# +1.00137509"},
        {"Renson", "Renson 39090"},
        {"Smithsonian Astrophysical Observation", "SAO 257290"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.86310651),
        dec: Angle.Degrees(-71.06209051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163730"},
        {"Hipparcos Number", "HIP 88489"},
        {"Geneva Identification System", "GEN# +1.00163730"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.02876091),
        dec: Angle.Degrees(-71.06029959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34711"},
        {"Hipparcos Number", "HIP 24309"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.24744860),
        dec: Angle.Degrees(-71.05933960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89050"},
        {"Hipparcos Number", "HIP 50071"},
        {"Smithsonian Astrophysical Observation", "SAO 256690"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.34622776),
        dec: Angle.Degrees(-71.05680519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72072"},
        {"Hipparcos Number", "HIP 41304"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.41306358),
        dec: Angle.Degrees(-71.05072593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110511"},
        {"Hipparcos Number", "HIP 62110"},
        {"Geneva Identification System", "GEN# +1.00110511"},
        {"Smithsonian Astrophysical Observation", "SAO 256975"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.94904866),
        dec: Angle.Degrees(-71.03783105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71591"},
        {"Hipparcos Number", "HIP 41093"},
        {"Geneva Identification System", "GEN# +1.00071591"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.74937139),
        dec: Angle.Degrees(-71.03598313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105514"},
        {"Hipparcos Number", "HIP 59235"},
        {"Smithsonian Astrophysical Observation", "SAO 256909"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.23299438),
        dec: Angle.Degrees(-71.03543545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63110"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.97221014),
        dec: Angle.Degrees(-71.02981235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110119"},
        {"Hipparcos Number", "HIP 61877"},
        {"Smithsonian Astrophysical Observation", "SAO 256972"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.20574370),
        dec: Angle.Degrees(-71.02250649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31336"},
        {"Hipparcos Number", "HIP 22338"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.16022992),
        dec: Angle.Degrees(-71.01978295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77324"},
        {"Hipparcos Number", "HIP 43958"},
        {"Smithsonian Astrophysical Observation", "SAO 256568"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.28567094),
        dec: Angle.Degrees(-71.01691920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81178"},
        {"Hipparcos Number", "HIP 45757"},
        {"Geneva Identification System", "GEN# +1.00081178"},
        {"Smithsonian Astrophysical Observation", "SAO 256604"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.96007825),
        dec: Angle.Degrees(-71.00920994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206399"},
        {"Hipparcos Number", "HIP 107423"},
        {"Fundamental Katalog 5th Edition", "FK5 3735"},
        {"Geneva Identification System", "GEN# +1.00206399"},
        {"Smithsonian Astrophysical Observation", "SAO 257955"},
    },
    visualMagnitude: 6.02,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.37002172),
        dec: Angle.Degrees(-71.00882172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202122"},
        {"Hipparcos Number", "HIP 105167"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.55695952),
        dec: Angle.Degrees(-71.00829759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219747"},
        {"Hipparcos Number", "HIP 115153"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.87577011),
        dec: Angle.Degrees(-71.00472238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96216"},
        {"Hipparcos Number", "HIP 54079"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.98957940),
        dec: Angle.Degrees(-71.00070884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153831"},
        {"Hipparcos Number", "HIP 83833"},
        {"Smithsonian Astrophysical Observation", "SAO 257463"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.00086682),
        dec: Angle.Degrees(-71.00012190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46134"},
        {"Hipparcos Number", "HIP 30531"},
        {"Smithsonian Astrophysical Observation", "SAO 256303"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.26260894),
        dec: Angle.Degrees(-70.99793447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100957"},
        {"Hipparcos Number", "HIP 56608"},
        {"Geneva Identification System", "GEN# +1.00100957"},
        {"Smithsonian Astrophysical Observation", "SAO 256854"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.10059243),
        dec: Angle.Degrees(-70.99607081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145547"},
        {"Hipparcos Number", "HIP 79802"},
        {"Smithsonian Astrophysical Observation", "SAO 257376"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.30575407),
        dec: Angle.Degrees(-70.99135347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39675"},
        {"Hipparcos Number", "HIP 27351"},
        {"Smithsonian Astrophysical Observation", "SAO 256237"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.89261394),
        dec: Angle.Degrees(-70.98897801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148488"},
        {"Hipparcos Number", "HIP 81141"},
        {"Fundamental Katalog 5th Edition", "FK5 3306"},
        {"Geneva Identification System", "GEN# +1.00148488"},
        {"Smithsonian Astrophysical Observation", "SAO 257409"},
        {"Wilson Evans Batten Catalogue", "WEB 13719"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.58070589),
        dec: Angle.Degrees(-70.98806509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197828"},
        {"Hipparcos Number", "HIP 102905"},
        {"Geneva Identification System", "GEN# +1.00197828"},
        {"Smithsonian Astrophysical Observation", "SAO 257858"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.71051065),
        dec: Angle.Degrees(-70.98409403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98387"},
        {"Hipparcos Number", "HIP 55169"},
        {"Geneva Identification System", "GEN# +1.00098387"},
        {"Smithsonian Astrophysical Observation", "SAO 256821"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.42979298),
        dec: Angle.Degrees(-70.97749011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64263"},
    },
    visualMagnitude: 11.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.57534591),
        dec: Angle.Degrees(-70.97227327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79027"},
        {"Hipparcos Number", "HIP 44737"},
        {"Smithsonian Astrophysical Observation", "SAO 256585"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.74937877),
        dec: Angle.Degrees(-70.96981383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213741"},
        {"Hipparcos Number", "HIP 111564"},
        {"Smithsonian Astrophysical Observation", "SAO 258052"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.02777321),
        dec: Angle.Degrees(-70.96383950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51557"},
        {"Hipparcos Number", "HIP 32912"},
        {"Fundamental Katalog 5th Edition", "FK5 267"},
        {"Geneva Identification System", "GEN# +1.00051557"},
        {"Smithsonian Astrophysical Observation", "SAO 256344"},
        {"Wilson Evans Batten Catalogue", "WEB 6622"},
    },
    visualMagnitude: 5.41,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.86241294),
        dec: Angle.Degrees(-70.96347336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221638"},
        {"Hipparcos Number", "HIP 116350"},
        {"Geneva Identification System", "GEN# +1.00221638"},
        {"Smithsonian Astrophysical Observation", "SAO 258158"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.64366406),
        dec: Angle.Degrees(-70.96331022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147022"},
        {"Hipparcos Number", "HIP 80437"},
        {"Smithsonian Astrophysical Observation", "SAO 257397"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.28353558),
        dec: Angle.Degrees(-70.96042868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13907"},
        {"Hipparcos Number", "HIP 10256"},
        {"Geneva Identification System", "GEN# +1.00013907"},
        {"Smithsonian Astrophysical Observation", "SAO 255860"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.97979958),
        dec: Angle.Degrees(-70.95096967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269221"},
        {"Hipparcos Number", "HIP 24264"},
        {"Geneva Identification System", "GEN# +1.00269221"},
    },
    visualMagnitude: 11.26,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.12343891),
        dec: Angle.Degrees(-70.94513744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45797"},
        {"Hipparcos Number", "HIP 30360"},
        {"Smithsonian Astrophysical Observation", "SAO 256298"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.78256791),
        dec: Angle.Degrees(-70.94482331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215617"},
        {"Hipparcos Number", "HIP 112620"},
        {"Smithsonian Astrophysical Observation", "SAO 258068"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.13464466),
        dec: Angle.Degrees(-70.93340200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48611"},
        {"Hipparcos Number", "HIP 31692"},
        {"Geneva Identification System", "GEN# +1.00048611"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.46182951),
        dec: Angle.Degrees(-70.93333845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 300.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6662"},
        {"Hipparcos Number", "HIP 5107"},
        {"Geneva Identification System", "GEN# +1.00006662"},
        {"Smithsonian Astrophysical Observation", "SAO 255738"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.36284599),
        dec: Angle.Degrees(-70.93330092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83392"},
        {"Hipparcos Number", "HIP 46957"},
        {"Renson", "Renson 23790"},
        {"Smithsonian Astrophysical Observation", "SAO 256638"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.57038313),
        dec: Angle.Degrees(-70.93206619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30612"},
        {"Hipparcos Number", "HIP 21949"},
        {"Fundamental Katalog 5th Edition", "FK5 177"},
        {"Geneva Identification System", "GEN# +1.00030612"},
        {"Renson", "Renson 7940"},
        {"Smithsonian Astrophysical Observation", "SAO 256122"},
        {"Wilson Evans Batten Catalogue", "WEB 4220"},
    },
    visualMagnitude: 5.53,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.76644496),
        dec: Angle.Degrees(-70.93111187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196392"},
        {"Hipparcos Number", "HIP 102165"},
        {"Smithsonian Astrophysical Observation", "SAO 257841"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.52151909),
        dec: Angle.Degrees(-70.93084486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131505"},
        {"Hipparcos Number", "HIP 73254"},
        {"Smithsonian Astrophysical Observation", "SAO 257215"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.56885441),
        dec: Angle.Degrees(-70.93045013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32415"},
        {"Hipparcos Number", "HIP 22998"},
        {"Geneva Identification System", "GEN# +1.00032415"},
        {"Smithsonian Astrophysical Observation", "SAO 256146"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.21162363),
        dec: Angle.Degrees(-70.92509361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125855"},
        {"Hipparcos Number", "HIP 70532"},
        {"Smithsonian Astrophysical Observation", "SAO 257151"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.43671548),
        dec: Angle.Degrees(-70.92470267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24418"},
        {"Hipparcos Number", "HIP 17716"},
        {"Geneva Identification System", "GEN# +1.00024418"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.91323686),
        dec: Angle.Degrees(-70.92178803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25805"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.67829432),
        dec: Angle.Degrees(-70.91975369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141863"},
        {"Hipparcos Number", "HIP 78079"},
        {"Geneva Identification System", "GEN# +1.00141863"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.14365689),
        dec: Angle.Degrees(-70.91929560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37262"},
        {"Hipparcos Number", "HIP 25811"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.69115569),
        dec: Angle.Degrees(-70.91903110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48467"},
        {"Hipparcos Number", "HIP 31633"},
        {"Smithsonian Astrophysical Observation", "SAO 256320"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.28999995),
        dec: Angle.Degrees(-70.91774532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100497"},
        {"Hipparcos Number", "HIP 56344"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.25231713),
        dec: Angle.Degrees(-70.91583950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15978"},
        {"Hipparcos Number", "HIP 11628"},
        {"Renson", "Renson 3970"},
        {"Smithsonian Astrophysical Observation", "SAO 255894"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.51549522),
        dec: Angle.Degrees(-70.91479263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57434"},
        {"Smithsonian Astrophysical Observation", "SAO 256873"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.61596743),
        dec: Angle.Degrees(-70.91027298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220520"},
        {"Hipparcos Number", "HIP 115622"},
        {"Smithsonian Astrophysical Observation", "SAO 258139"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.33628637),
        dec: Angle.Degrees(-70.90983564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209840"},
        {"Hipparcos Number", "HIP 109365"},
        {"Smithsonian Astrophysical Observation", "SAO 258002"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.35240799),
        dec: Angle.Degrees(-70.90406104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102354"},
        {"Hipparcos Number", "HIP 57418"},
        {"Geneva Identification System", "GEN# +1.00102354"},
        {"Renson", "Renson 29520"},
        {"Smithsonian Astrophysical Observation", "SAO 256872"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.58169038),
        dec: Angle.Degrees(-70.90399845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222076"},
        {"Hipparcos Number", "HIP 116630"},
        {"Geneva Identification System", "GEN# +1.00222076"},
        {"Smithsonian Astrophysical Observation", "SAO 258165"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.53373426),
        dec: Angle.Degrees(-70.90341815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29533"},
        {"Hipparcos Number", "HIP 21211"},
        {"Smithsonian Astrophysical Observation", "SAO 256102"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.24307652),
        dec: Angle.Degrees(-70.89692989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91326"},
        {"Hipparcos Number", "HIP 51424"},
        {"Fundamental Katalog 5th Edition", "FK5 4930"},
        {"Smithsonian Astrophysical Observation", "SAO 256720"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.53302803),
        dec: Angle.Degrees(-70.88817060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140485"},
        {"Hipparcos Number", "HIP 77468"},
        {"Smithsonian Astrophysical Observation", "SAO 257322"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.26167363),
        dec: Angle.Degrees(-70.88569736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149022"},
        {"Hipparcos Number", "HIP 81438"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.50287826),
        dec: Angle.Degrees(-70.88413796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101317"},
        {"Hipparcos Number", "HIP 56822"},
        {"Smithsonian Astrophysical Observation", "SAO 256860"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.72151541),
        dec: Angle.Degrees(-70.88377535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7518"},
        {"Hipparcos Number", "HIP 5695"},
        {"Geneva Identification System", "GEN# +1.00007518"},
        {"Smithsonian Astrophysical Observation", "SAO 255752"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.31787599),
        dec: Angle.Degrees(-70.88115348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62404"},
        {"Hipparcos Number", "HIP 37143"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.48614284),
        dec: Angle.Degrees(-70.88060549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96706"},
        {"Hipparcos Number", "HIP 54327"},
        {"Fundamental Katalog 5th Edition", "FK5 1288"},
        {"Geneva Identification System", "GEN# +1.00096706"},
        {"Smithsonian Astrophysical Observation", "SAO 256800"},
        {"Wilson Evans Batten Catalogue", "WEB 9812"},
    },
    visualMagnitude: 5.58,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.70803819),
        dec: Angle.Degrees(-70.87793836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103517"},
        {"Hipparcos Number", "HIP 58097"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.73091286),
        dec: Angle.Degrees(-70.87755068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159829"},
        {"Hipparcos Number", "HIP 86712"},
        {"Renson", "Renson 44960"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.76949581),
        dec: Angle.Degrees(-70.87261831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223643"},
        {"Hipparcos Number", "HIP 117657"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.92057676),
        dec: Angle.Degrees(-70.87053252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5795"},
        {"Hipparcos Number", "HIP 4524"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.48868738),
        dec: Angle.Degrees(-70.86921844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224229"},
        {"Hipparcos Number", "HIP 118018"},
        {"Smithsonian Astrophysical Observation", "SAO 258201"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.08067230),
        dec: Angle.Degrees(-70.86878367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9850"},
        {"Hipparcos Number", "HIP 7256"},
        {"Geneva Identification System", "GEN# +1.00009850"},
        {"Smithsonian Astrophysical Observation", "SAO 255792"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.37707418),
        dec: Angle.Degrees(-70.86778623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210117"},
        {"Hipparcos Number", "HIP 109519"},
        {"Smithsonian Astrophysical Observation", "SAO 258005"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.78421674),
        dec: Angle.Degrees(-70.86739888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60203",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60203"},
        {"Geneva Identification System", "GEN# +6.10170682"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.18052415),
        dec: Angle.Degrees(-70.86361811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12865"},
        {"Hipparcos Number", "HIP 9558"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.69559159),
        dec: Angle.Degrees(-70.86352008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93344"},
        {"Hipparcos Number", "HIP 52520"},
        {"Geneva Identification System", "GEN# +1.00093344"},
        {"Smithsonian Astrophysical Observation", "SAO 256750"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.08376292),
        dec: Angle.Degrees(-70.85972326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104569"},
        {"Hipparcos Number", "HIP 58719"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.65578578),
        dec: Angle.Degrees(-70.85926733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201477"},
        {"Hipparcos Number", "HIP 104840"},
        {"Geneva Identification System", "GEN# +1.00201477"},
        {"Smithsonian Astrophysical Observation", "SAO 257898"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.57351449),
        dec: Angle.Degrees(-70.85787911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9162"},
        {"Hipparcos Number", "HIP 6824"},
        {"Smithsonian Astrophysical Observation", "SAO 255780"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.94583132),
        dec: Angle.Degrees(-70.85730529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30337"},
        {"Hipparcos Number", "HIP 21769"},
        {"Smithsonian Astrophysical Observation", "SAO 256117"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.13996263),
        dec: Angle.Degrees(-70.85675782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93359"},
        {"Hipparcos Number", "HIP 52537"},
        {"Geneva Identification System", "GEN# +1.00093359"},
        {"Smithsonian Astrophysical Observation", "SAO 256751"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.13508599),
        dec: Angle.Degrees(-70.85525541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115585"},
        {"Hipparcos Number", "HIP 65036"},
        {"Geneva Identification System", "GEN# +1.00115585"},
        {"Smithsonian Astrophysical Observation", "SAO 257030"},
        {"Wilson Evans Batten Catalogue", "WEB 11491"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.96369673),
        dec: Angle.Degrees(-70.85494655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -391.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194276"},
        {"Hipparcos Number", "HIP 101128"},
        {"Smithsonian Astrophysical Observation", "SAO 257812"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.48890267),
        dec: Angle.Degrees(-70.85454065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105583"},
        {"Hipparcos Number", "HIP 59277"},
        {"Renson", "Renson 30530"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.39353671),
        dec: Angle.Degrees(-70.85064544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72979"},
        {"Hipparcos Number", "HIP 41740"},
        {"Smithsonian Astrophysical Observation", "SAO 256520"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.68238216),
        dec: Angle.Degrees(-70.84258240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92317"},
        {"Hipparcos Number", "HIP 51982"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.31535515),
        dec: Angle.Degrees(-70.83998076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 624"},
        {"Hipparcos Number", "HIP 839"},
        {"Geneva Identification System", "GEN# +1.00000624"},
        {"Smithsonian Astrophysical Observation", "SAO 255641"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.57458042),
        dec: Angle.Degrees(-70.83688393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77855"},
        {"Hipparcos Number", "HIP 44218"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.09779045),
        dec: Angle.Degrees(-70.83539075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37181"},
        {"Hipparcos Number", "HIP 25780"},
        {"Geneva Identification System", "GEN# +1.00037181"},
        {"Smithsonian Astrophysical Observation", "SAO 256199"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.56635412),
        dec: Angle.Degrees(-70.82960343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106638"},
        {"Hipparcos Number", "HIP 59838"},
        {"Geneva Identification System", "GEN# +1.00106638"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.05321919),
        dec: Angle.Degrees(-70.82662278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37027"},
        {"Hipparcos Number", "HIP 25690"},
        {"Geneva Identification System", "GEN# +1.00037027"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.28699677),
        dec: Angle.Degrees(-70.82550858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70103"},
        {"Hipparcos Number", "HIP 40391"},
        {"Geneva Identification System", "GEN# +1.00070103"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.69916810),
        dec: Angle.Degrees(-70.82486147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141037"},
        {"Hipparcos Number", "HIP 77722"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.01298311),
        dec: Angle.Degrees(-70.82109208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222668"},
        {"Hipparcos Number", "HIP 117014"},
        {"Fundamental Katalog 5th Edition", "FK5 6100"},
        {"Geneva Identification System", "GEN# +1.00222668"},
        {"Smithsonian Astrophysical Observation", "SAO 258173"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.82032557),
        dec: Angle.Degrees(-70.81827106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189898"},
        {"Hipparcos Number", "HIP 99162"},
        {"Smithsonian Astrophysical Observation", "SAO 257774"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.98363692),
        dec: Angle.Degrees(-70.81506559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84708"},
    },
    visualMagnitude: 12.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.73319094),
        dec: Angle.Degrees(-70.81302237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17567"},
        {"Hipparcos Number", "HIP 12827"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.22868916),
        dec: Angle.Degrees(-70.81089468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 113.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205727"},
        {"Hipparcos Number", "HIP 107061"},
        {"Geneva Identification System", "GEN# +1.00205727"},
        {"Smithsonian Astrophysical Observation", "SAO 257949"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.25393615),
        dec: Angle.Degrees(-70.80702892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177695"},
        {"Hipparcos Number", "HIP 94318"},
        {"Smithsonian Astrophysical Observation", "SAO 257666"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.95956433),
        dec: Angle.Degrees(-70.80677851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121103"},
        {"Hipparcos Number", "HIP 68077"},
        {"Geneva Identification System", "GEN# +1.00121103"},
        {"Smithsonian Astrophysical Observation", "SAO 257102"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.08034109),
        dec: Angle.Degrees(-70.80548201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171106"},
        {"Hipparcos Number", "HIP 91454"},
        {"Geneva Identification System", "GEN# +1.00171106"},
        {"Smithsonian Astrophysical Observation", "SAO 257614"},
        {"Wilson Evans Batten Catalogue", "WEB 15719"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.78946670),
        dec: Angle.Degrees(-70.80316352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130368"},
        {"Hipparcos Number", "HIP 72709"},
        {"Geneva Identification System", "GEN# +1.00130368"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.98784921),
        dec: Angle.Degrees(-70.80259371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98836"},
        {"Hipparcos Number", "HIP 55446"},
        {"Geneva Identification System", "GEN# +1.00098836"},
        {"Smithsonian Astrophysical Observation", "SAO 256829"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.33279973),
        dec: Angle.Degrees(-70.80207279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70872"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.40043241),
        dec: Angle.Degrees(-70.79188304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54153"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.17030290),
        dec: Angle.Degrees(-70.78855236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118522"},
        {"Hipparcos Number", "HIP 66668"},
        {"Geneva Identification System", "GEN# +1.00118522"},
        {"Smithsonian Astrophysical Observation", "SAO 257074"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.00247190),
        dec: Angle.Degrees(-70.78776786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132366"},
        {"Hipparcos Number", "HIP 73645"},
        {"Smithsonian Astrophysical Observation", "SAO 257229"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.80417638),
        dec: Angle.Degrees(-70.78707351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69218"},
        {"Hipparcos Number", "HIP 40030"},
        {"Geneva Identification System", "GEN# +1.00069218"},
        {"Wilson Evans Batten Catalogue", "WEB 7808"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.64401763),
        dec: Angle.Degrees(-70.78396531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106147"},
        {"Hipparcos Number", "HIP 59582"},
        {"Smithsonian Astrophysical Observation", "SAO 256913"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.27893191),
        dec: Angle.Degrees(-70.78307235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116202"},
        {"Hipparcos Number", "HIP 65393"},
        {"Geneva Identification System", "GEN# +1.00116202"},
        {"Smithsonian Astrophysical Observation", "SAO 257037"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.03530758),
        dec: Angle.Degrees(-70.78272669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32375"},
        {"Hipparcos Number", "HIP 22974"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.15466578),
        dec: Angle.Degrees(-70.78229386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64981"},
        {"Hipparcos Number", "HIP 38299"},
        {"Smithsonian Astrophysical Observation", "SAO 256454"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.69719657),
        dec: Angle.Degrees(-70.77824281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85498"},
        {"Hipparcos Number", "HIP 48130"},
        {"Smithsonian Astrophysical Observation", "SAO 256659"},
    },
    visualMagnitude: 8.88,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.18739147),
        dec: Angle.Degrees(-70.77344255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59426"},
        {"Hipparcos Number", "HIP 35882"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.96650851),
        dec: Angle.Degrees(-70.77262752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16419"},
        {"Hipparcos Number", "HIP 11926"},
        {"Smithsonian Astrophysical Observation", "SAO 255902"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.48040618),
        dec: Angle.Degrees(-70.76800882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145690"},
        {"Hipparcos Number", "HIP 79838"},
        {"Smithsonian Astrophysical Observation", "SAO 257378"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.44444954),
        dec: Angle.Degrees(-70.76577016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27478"},
        {"Hipparcos Number", "HIP 19791"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.63004330),
        dec: Angle.Degrees(-70.76011231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120377"},
        {"Hipparcos Number", "HIP 67681"},
        {"Geneva Identification System", "GEN# +1.00120377"},
        {"Renson", "Renson 34700"},
        {"Smithsonian Astrophysical Observation", "SAO 257094"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.98018418),
        dec: Angle.Degrees(-70.75555966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165861"},
        {"Hipparcos Number", "HIP 89382"},
        {"Fundamental Katalog 5th Edition", "FK5 3446"},
        {"Geneva Identification System", "GEN# +1.00165861"},
        {"Smithsonian Astrophysical Observation", "SAO 257575"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.60050940),
        dec: Angle.Degrees(-70.75117670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31814"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.77247077),
        dec: Angle.Degrees(-70.74507717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84891"},
        {"Hipparcos Number", "HIP 47809"},
        {"Smithsonian Astrophysical Observation", "SAO 256652"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.19420542),
        dec: Angle.Degrees(-70.74189437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53321"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.59452610),
        dec: Angle.Degrees(-70.74115382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104015"},
        {"Hipparcos Number", "HIP 58402"},
        {"Geneva Identification System", "GEN# +1.00104015"},
        {"Smithsonian Astrophysical Observation", "SAO 256891"},
        {"Wilson Evans Batten Catalogue", "WEB 10440"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.62533078),
        dec: Angle.Degrees(-70.73999836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35679"},
        {"Hipparcos Number", "HIP 24895"},
        {"Renson", "Renson 9210"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.03930406),
        dec: Angle.Degrees(-70.73907284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136917"},
        {"Hipparcos Number", "HIP 75719"},
        {"Geneva Identification System", "GEN# +1.00136917"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.04151793),
        dec: Angle.Degrees(-70.73488619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89721"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.65718440),
        dec: Angle.Degrees(-70.73262039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90414"},
        {"Hipparcos Number", "HIP 50898"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.90857264),
        dec: Angle.Degrees(-70.72924513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87351"},
        {"Hipparcos Number", "HIP 49105"},
        {"Smithsonian Astrophysical Observation", "SAO 256676"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.32648191),
        dec: Angle.Degrees(-70.72819141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107983"},
        {"Hipparcos Number", "HIP 60580"},
        {"Geneva Identification System", "GEN# +1.00107983"},
        {"Smithsonian Astrophysical Observation", "SAO 256940"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.25558487),
        dec: Angle.Degrees(-70.72764936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92191"},
        {"Hipparcos Number", "HIP 51906"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.07070967),
        dec: Angle.Degrees(-70.72616069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154556"},
        {"Hipparcos Number", "HIP 84158"},
        {"Geneva Identification System", "GEN# +1.00154556"},
        {"Smithsonian Astrophysical Observation", "SAO 257472"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.08269833),
        dec: Angle.Degrees(-70.72089238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53272"},
        {"Smithsonian Astrophysical Observation", "SAO 256770"},
    },
    visualMagnitude: 5.99,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.42553924),
        dec: Angle.Degrees(-70.72033781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203397"},
        {"Hipparcos Number", "HIP 105820"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.47861435),
        dec: Angle.Degrees(-70.71766841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66195"},
        {"Hipparcos Number", "HIP 38828"},
        {"Geneva Identification System", "GEN# +1.00066195"},
        {"Renson", "Renson 18240"},
        {"Smithsonian Astrophysical Observation", "SAO 256460"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.19550347),
        dec: Angle.Degrees(-70.71643601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196938"},
        {"Hipparcos Number", "HIP 102425"},
        {"Geneva Identification System", "GEN# +1.00196938"},
        {"Smithsonian Astrophysical Observation", "SAO 257847"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.32907447),
        dec: Angle.Degrees(-70.71476461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133426"},
        {"Hipparcos Number", "HIP 74115"},
        {"Renson", "Renson 37850"},
        {"Smithsonian Astrophysical Observation", "SAO 257242"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.20296020),
        dec: Angle.Degrees(-70.71052256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269018"},
        {"Hipparcos Number", "HIP 23527"},
        {"Geneva Identification System", "GEN# +1.00269018"},
    },
    visualMagnitude: 11.71,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.87325972),
        dec: Angle.Degrees(-70.69983565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159098"},
        {"Hipparcos Number", "HIP 86381"},
        {"Renson", "Renson 44750"},
        {"Smithsonian Astrophysical Observation", "SAO 257517"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.77034534),
        dec: Angle.Degrees(-70.69423152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16940"},
        {"Hipparcos Number", "HIP 12338"},
        {"Smithsonian Astrophysical Observation", "SAO 255910"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.72165172),
        dec: Angle.Degrees(-70.67985754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223914"},
        {"Hipparcos Number", "HIP 117827"},
        {"Geneva Identification System", "GEN# +1.00223914"},
        {"Smithsonian Astrophysical Observation", "SAO 258194"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.45592275),
        dec: Angle.Degrees(-70.67909966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14748"},
        {"Hipparcos Number", "HIP 10799"},
        {"Smithsonian Astrophysical Observation", "SAO 255872"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.74480018),
        dec: Angle.Degrees(-70.67768650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73990"},
        {"Hipparcos Number", "HIP 42206"},
        {"Smithsonian Astrophysical Observation", "SAO 256527"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.08631508),
        dec: Angle.Degrees(-70.67667701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211701"},
        {"Hipparcos Number", "HIP 110403"},
        {"Smithsonian Astrophysical Observation", "SAO 258026"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.43349191),
        dec: Angle.Degrees(-70.67575495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8781"},
        {"Hipparcos Number", "HIP 6552"},
        {"Geneva Identification System", "GEN# +1.00008781"},
        {"Smithsonian Astrophysical Observation", "SAO 255774"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.05080768),
        dec: Angle.Degrees(-70.67536344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42030"},
        {"Hipparcos Number", "HIP 28587"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.51996664),
        dec: Angle.Degrees(-70.67529715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134263"},
        {"Hipparcos Number", "HIP 74497"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.35479298),
        dec: Angle.Degrees(-70.67310214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109753"},
        {"Hipparcos Number", "HIP 61634"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.50009276),
        dec: Angle.Degrees(-70.66356355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191309"},
        {"Hipparcos Number", "HIP 99776"},
        {"Smithsonian Astrophysical Observation", "SAO 257785"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.64651961),
        dec: Angle.Degrees(-70.66305705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1572"},
        {"Hipparcos Number", "HIP 1564"},
        {"Smithsonian Astrophysical Observation", "SAO 255658"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.85828558),
        dec: Angle.Degrees(-70.66156637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210742"},
        {"Hipparcos Number", "HIP 109880"},
        {"Smithsonian Astrophysical Observation", "SAO 258017"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.82086317),
        dec: Angle.Degrees(-70.65288564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82748"},
    },
    visualMagnitude: 12.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.68753596),
        dec: Angle.Degrees(-70.65040950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166275"},
        {"Hipparcos Number", "HIP 89533"},
        {"Smithsonian Astrophysical Observation", "SAO 257577"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.04499035),
        dec: Angle.Degrees(-70.64468427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97335"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.74084158),
        dec: Angle.Degrees(-70.64270738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97762"},
        {"Hipparcos Number", "HIP 54833"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.38637861),
        dec: Angle.Degrees(-70.63784808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59239"},
        {"Hipparcos Number", "HIP 35809"},
        {"Smithsonian Astrophysical Observation", "SAO 256402"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.77884347),
        dec: Angle.Degrees(-70.63667142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157342"},
        {"Hipparcos Number", "HIP 85540"},
        {"Fundamental Katalog 5th Edition", "FK5 5540"},
        {"Smithsonian Astrophysical Observation", "SAO 257502"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.21356880),
        dec: Angle.Degrees(-70.63362344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112608"},
        {"Hipparcos Number", "HIP 63387"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.83599874),
        dec: Angle.Degrees(-70.63268733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13205"},
        {"Hipparcos Number", "HIP 9783"},
        {"Smithsonian Astrophysical Observation", "SAO 255848"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.44772423),
        dec: Angle.Degrees(-70.63129918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139190"},
        {"Hipparcos Number", "HIP 76873"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.46629905),
        dec: Angle.Degrees(-70.63067823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116458"},
        {"Hipparcos Number", "HIP 65522"},
        {"Geneva Identification System", "GEN# +1.00116458"},
        {"Renson", "Renson 33590"},
        {"Smithsonian Astrophysical Observation", "SAO 257042"},
        {"Wilson Evans Batten Catalogue", "WEB 11565"},
    },
    visualMagnitude: 5.65,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.45999506),
        dec: Angle.Degrees(-70.62725069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217405"},
        {"Hipparcos Number", "HIP 113745"},
        {"Smithsonian Astrophysical Observation", "SAO 258098"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.53415178),
        dec: Angle.Degrees(-70.62700680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185618"},
        {"Hipparcos Number", "HIP 97226"},
        {"Smithsonian Astrophysical Observation", "SAO 257727"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.41233172),
        dec: Angle.Degrees(-70.62656764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32956"},
        {"Hipparcos Number", "HIP 23294"},
        {"Fundamental Katalog 5th Edition", "FK5 4456"},
        {"Geneva Identification System", "GEN# +1.00032956"},
        {"Smithsonian Astrophysical Observation", "SAO 256149"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.16455019),
        dec: Angle.Degrees(-70.62405962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98660"},
        {"Hipparcos Number", "HIP 55334"},
        {"Geneva Identification System", "GEN# +1.00098660"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.97007186),
        dec: Angle.Degrees(-70.61848249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92009"},
        {"Hipparcos Number", "HIP 51812"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.78519472),
        dec: Angle.Degrees(-70.61371282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78360"},
        {"Hipparcos Number", "HIP 44445"},
        {"Geneva Identification System", "GEN# +1.00078360"},
        {"Smithsonian Astrophysical Observation", "SAO 256580"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.82523957),
        dec: Angle.Degrees(-70.60664775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48527"},
        {"Hipparcos Number", "HIP 31666"},
        {"Geneva Identification System", "GEN# +1.00048527"},
        {"Smithsonian Astrophysical Observation", "SAO 256321"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.41062657),
        dec: Angle.Degrees(-70.60365625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129811"},
        {"Hipparcos Number", "HIP 72435"},
        {"Fundamental Katalog 5th Edition", "FK5 5313"},
        {"Smithsonian Astrophysical Observation", "SAO 257197"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.17732586),
        dec: Angle.Degrees(-70.59895818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216813"},
        {"Hipparcos Number", "HIP 113382"},
        {"Smithsonian Astrophysical Observation", "SAO 258090"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.44175396),
        dec: Angle.Degrees(-70.59895473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44312"},
        {"Hipparcos Number", "HIP 29649"},
        {"Smithsonian Astrophysical Observation", "SAO 256283"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.70973431),
        dec: Angle.Degrees(-70.59785821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218"},
        {"Hipparcos Number", "HIP 558"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.69675999),
        dec: Angle.Degrees(-70.58944075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154758"},
        {"Hipparcos Number", "HIP 84265"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.37734472),
        dec: Angle.Degrees(-70.58836081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87991"},
        {"Hipparcos Number", "HIP 49440"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.40651758),
        dec: Angle.Degrees(-70.58795748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48794"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.27283056),
        dec: Angle.Degrees(-70.58412195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149771"},
        {"Hipparcos Number", "HIP 81817"},
        {"Smithsonian Astrophysical Observation", "SAO 257426"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.66799260),
        dec: Angle.Degrees(-70.58042243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54180"},
        {"Hipparcos Number", "HIP 33860"},
        {"Geneva Identification System", "GEN# +1.00054180"},
        {"Smithsonian Astrophysical Observation", "SAO 256363"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.44187873),
        dec: Angle.Degrees(-70.56643446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175350"},
        {"Hipparcos Number", "HIP 93370"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.26706004),
        dec: Angle.Degrees(-70.56028272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134403"},
        {"Hipparcos Number", "HIP 74574"},
        {"Geneva Identification System", "GEN# +1.00134403"},
        {"Smithsonian Astrophysical Observation", "SAO 257254"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.55342704),
        dec: Angle.Degrees(-70.55925432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207430"},
        {"Hipparcos Number", "HIP 107957"},
        {"Fundamental Katalog 5th Edition", "FK5 5931"},
        {"Smithsonian Astrophysical Observation", "SAO 257972"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.07720614),
        dec: Angle.Degrees(-70.54945322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115881"},
        {"Hipparcos Number", "HIP 65234"},
        {"Geneva Identification System", "GEN# +1.00115881"},
        {"Smithsonian Astrophysical Observation", "SAO 257032"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.52669039),
        dec: Angle.Degrees(-70.54704619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110080"},
        {"Hipparcos Number", "HIP 61847"},
        {"Geneva Identification System", "GEN# +1.00110080"},
        {"Smithsonian Astrophysical Observation", "SAO 256971"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.13342430),
        dec: Angle.Degrees(-70.54675950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108447"},
        {"Hipparcos Number", "HIP 60841"},
        {"Geneva Identification System", "GEN# +1.00108447"},
        {"Smithsonian Astrophysical Observation", "SAO 256945"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.06090842),
        dec: Angle.Degrees(-70.54511854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23116"},
        {"Hipparcos Number", "HIP 16882"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.31762984),
        dec: Angle.Degrees(-70.54406468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14259"},
        {"Hipparcos Number", "HIP 10458"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.69781173),
        dec: Angle.Degrees(-70.54384501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54558"},
        {"Hipparcos Number", "HIP 33990"},
        {"Smithsonian Astrophysical Observation", "SAO 256366"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.79264244),
        dec: Angle.Degrees(-70.54159320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6550"},
        {"Hipparcos Number", "HIP 5038"},
        {"Smithsonian Astrophysical Observation", "SAO 255734"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.12990522),
        dec: Angle.Degrees(-70.54035809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116566"},
        {"Hipparcos Number", "HIP 65559"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.61994389),
        dec: Angle.Degrees(-70.54002603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78764"},
        {"Hipparcos Number", "HIP 44626"},
        {"Celescope Catalog", "CEL 3189"},
        {"Geneva Identification System", "GEN# +1.00078764"},
        {"Smithsonian Astrophysical Observation", "SAO 256583"},
        {"Wilson Evans Batten Catalogue", "WEB 8538"},
    },
    visualMagnitude: 4.66,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.40992522),
        dec: Angle.Degrees(-70.53852074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130141"},
        {"Hipparcos Number", "HIP 72589"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.63686331),
        dec: Angle.Degrees(-70.53834435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207918"},
        {"Hipparcos Number", "HIP 108256"},
        {"Smithsonian Astrophysical Observation", "SAO 257982"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.97340675),
        dec: Angle.Degrees(-70.53672274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130140"},
        {"Hipparcos Number", "HIP 72585"},
        {"Geneva Identification System", "GEN# +1.00130140"},
        {"Smithsonian Astrophysical Observation", "SAO 257203"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.62907783),
        dec: Angle.Degrees(-70.53512182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192116"},
        {"Hipparcos Number", "HIP 100106"},
        {"Smithsonian Astrophysical Observation", "SAO 257792"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61773338),
        dec: Angle.Degrees(-70.53233635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188227"},
        {"Hipparcos Number", "HIP 98408"},
        {"Smithsonian Astrophysical Observation", "SAO 257754"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.92412347),
        dec: Angle.Degrees(-70.53156593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162157"},
        {"Hipparcos Number", "HIP 87778"},
        {"Geneva Identification System", "GEN# +1.00162157"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.96374015),
        dec: Angle.Degrees(-70.53120606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87784"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.97951045),
        dec: Angle.Degrees(-70.52704894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61904"},
        {"Hipparcos Number", "HIP 36943"},
        {"Smithsonian Astrophysical Observation", "SAO 256427"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.91781314),
        dec: Angle.Degrees(-70.52363266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50160"},
        {"Hipparcos Number", "HIP 32396"},
        {"Smithsonian Astrophysical Observation", "SAO 256335"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.45723197),
        dec: Angle.Degrees(-70.52265279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209770"},
        {"Hipparcos Number", "HIP 109325"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.23162753),
        dec: Angle.Degrees(-70.52183957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131084"},
        {"Hipparcos Number", "HIP 73054"},
        {"Geneva Identification System", "GEN# +1.00131084"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.94599849),
        dec: Angle.Degrees(-70.52032634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134606"},
        {"Hipparcos Number", "HIP 74653"},
        {"Geneva Identification System", "GEN# +1.00134606"},
        {"Smithsonian Astrophysical Observation", "SAO 257257"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.81398270),
        dec: Angle.Degrees(-70.51922374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47213"},
        {"Hipparcos Number", "HIP 31071"},
        {"Fundamental Katalog 5th Edition", "FK5 4592"},
        {"Geneva Identification System", "GEN# +1.00047213"},
        {"Smithsonian Astrophysical Observation", "SAO 256311"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.80133091),
        dec: Angle.Degrees(-70.51608278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170809"},
        {"Hipparcos Number", "HIP 91317"},
        {"Geneva Identification System", "GEN# +1.00170809"},
        {"Smithsonian Astrophysical Observation", "SAO 257610"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.39301204),
        dec: Angle.Degrees(-70.51436451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89520"},
        {"Hipparcos Number", "HIP 50365"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.25161980),
        dec: Angle.Degrees(-70.51309852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69407"},
        {"Hipparcos Number", "HIP 40105"},
        {"Smithsonian Astrophysical Observation", "SAO 256484"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.88328016),
        dec: Angle.Degrees(-70.51146729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183277"},
        {"Hipparcos Number", "HIP 96276"},
        {"Geneva Identification System", "GEN# +1.00183277"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.64719804),
        dec: Angle.Degrees(-70.51136322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51801"},
        {"Hipparcos Number", "HIP 33003"},
        {"Smithsonian Astrophysical Observation", "SAO 256346"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.15309457),
        dec: Angle.Degrees(-70.51024315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40811"},
        {"Hipparcos Number", "HIP 27952"},
        {"Geneva Identification System", "GEN# +1.00040811"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.71455230),
        dec: Angle.Degrees(-70.50942841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 178.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208595"},
        {"Hipparcos Number", "HIP 108636"},
        {"Smithsonian Astrophysical Observation", "SAO 257989"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.12163482),
        dec: Angle.Degrees(-70.50709980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147714"},
        {"Hipparcos Number", "HIP 80740"},
        {"Renson", "Renson 41670"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.26540594),
        dec: Angle.Degrees(-70.50230351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55865"},
        {"Hipparcos Number", "HIP 34481"},
        {"Fundamental Katalog 5th Edition", "FK5 1189"},
        {"Geneva Identification System", "GEN# +1.00055865"},
        {"Smithsonian Astrophysical Observation", "SAO 256374"},
        {"Wilson Evans Batten Catalogue", "WEB 6906"},
    },
    visualMagnitude: 3.78,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.18676883),
        dec: Angle.Degrees(-70.49919435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64931"},
        {"Hipparcos Number", "HIP 38286"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.66463521),
        dec: Angle.Degrees(-70.49866424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55864"},
        {"Hipparcos Number", "HIP 34473"},
        {"Geneva Identification System", "GEN# +1.00055864"},
        {"Smithsonian Astrophysical Observation", "SAO 256373"},
        {"Wilson Evans Batten Catalogue", "WEB 6905"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.17642280),
        dec: Angle.Degrees(-70.49734046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158914"},
        {"Hipparcos Number", "HIP 86304"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.51651533),
        dec: Angle.Degrees(-70.49334756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225300"},
        {"Hipparcos Number", "HIP 409"},
        {"Geneva Identification System", "GEN# +1.00225300"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.24608894),
        dec: Angle.Degrees(-70.49241628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210712"},
        {"Hipparcos Number", "HIP 109864"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.76686081),
        dec: Angle.Degrees(-70.49040213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222805"},
        {"Hipparcos Number", "HIP 117105"},
        {"Fundamental Katalog 5th Edition", "FK5 3905"},
        {"Geneva Identification System", "GEN# +1.00222805"},
        {"Smithsonian Astrophysical Observation", "SAO 258178"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.10417971),
        dec: Angle.Degrees(-70.49037556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 245.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52493"},
        {"Hipparcos Number", "HIP 33273"},
        {"Smithsonian Astrophysical Observation", "SAO 256351"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.81613054),
        dec: Angle.Degrees(-70.48911423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218009"},
        {"Hipparcos Number", "HIP 114073"},
        {"Smithsonian Astrophysical Observation", "SAO 258102"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.54946311),
        dec: Angle.Degrees(-70.48814845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174319"},
        {"Hipparcos Number", "HIP 92939"},
        {"Smithsonian Astrophysical Observation", "SAO 257640"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.03393383),
        dec: Angle.Degrees(-70.48701351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20954"},
        {"Hipparcos Number", "HIP 15340"},
        {"Smithsonian Astrophysical Observation", "SAO 255974"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.45551111),
        dec: Angle.Degrees(-70.48061196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40277"},
        {"Hipparcos Number", "HIP 27662"},
        {"Geneva Identification System", "GEN# +1.00040277"},
        {"Renson", "Renson 10730"},
        {"Smithsonian Astrophysical Observation", "SAO 256245"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.85968379),
        dec: Angle.Degrees(-70.47942723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95208"},
    },
    visualMagnitude: 12.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.52798698),
        dec: Angle.Degrees(-70.47918042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114887"},
        {"Hipparcos Number", "HIP 64665"},
        {"Geneva Identification System", "GEN# +1.00114887"},
        {"Smithsonian Astrophysical Observation", "SAO 257022"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.82598313),
        dec: Angle.Degrees(-70.47794809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19492"},
        {"Hipparcos Number", "HIP 14218"},
        {"Smithsonian Astrophysical Observation", "SAO 255947"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.83910535),
        dec: Angle.Degrees(-70.47703686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180371"},
        {"Hipparcos Number", "HIP 95210"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.53586262),
        dec: Angle.Degrees(-70.47576310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22385"},
        {"Hipparcos Number", "HIP 16395"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.78238327),
        dec: Angle.Degrees(-70.47325730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83019"},
        {"Hipparcos Number", "HIP 46755"},
        {"Celescope Catalog", "CEL 3321"},
        {"Geneva Identification System", "GEN# +1.00083019"},
        {"Smithsonian Astrophysical Observation", "SAO 256631"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.93972296),
        dec: Angle.Degrees(-70.46963101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175007"},
        {"Hipparcos Number", "HIP 93238"},
        {"Geneva Identification System", "GEN# +1.00175007"},
        {"Smithsonian Astrophysical Observation", "SAO 257644"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.87197851),
        dec: Angle.Degrees(-70.46836740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50431"},
        {"Hipparcos Number", "HIP 32507"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.76144690),
        dec: Angle.Degrees(-70.46833581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5785"},
        {"Hipparcos Number", "HIP 4513"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.46735756),
        dec: Angle.Degrees(-70.45846647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102685"},
        {"Hipparcos Number", "HIP 57626"},
        {"Geneva Identification System", "GEN# +1.00102685"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.23596777),
        dec: Angle.Degrees(-70.45329962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28110"},
        {"Hipparcos Number", "HIP 20248"},
        {"Smithsonian Astrophysical Observation", "SAO 256081"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.08022196),
        dec: Angle.Degrees(-70.45036675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310327"},
        {"Hipparcos Number", "HIP 53477"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.09587682),
        dec: Angle.Degrees(-70.44917342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62688"},
        {"Hipparcos Number", "HIP 37307"},
        {"Smithsonian Astrophysical Observation", "SAO 256432"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.88169831),
        dec: Angle.Degrees(-70.44560604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118344"},
        {"Hipparcos Number", "HIP 66574"},
        {"Fundamental Katalog 5th Edition", "FK5 3086"},
        {"Geneva Identification System", "GEN# +1.00118344"},
        {"Smithsonian Astrophysical Observation", "SAO 257070"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.69096307),
        dec: Angle.Degrees(-70.44475263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2040"},
        {"Hipparcos Number", "HIP 1909"},
        {"Smithsonian Astrophysical Observation", "SAO 255668"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.02986749),
        dec: Angle.Degrees(-70.44391842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156244"},
        {"Hipparcos Number", "HIP 85013"},
        {"Smithsonian Astrophysical Observation", "SAO 257492"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.63086285),
        dec: Angle.Degrees(-70.44198769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220691"},
        {"Hipparcos Number", "HIP 115722"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.67384481),
        dec: Angle.Degrees(-70.43792364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69087"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.10991832),
        dec: Angle.Degrees(-70.43595474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50002"},
        {"Hipparcos Number", "HIP 32332"},
        {"Geneva Identification System", "GEN# +1.00050002"},
        {"Smithsonian Astrophysical Observation", "SAO 256331"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.23197446),
        dec: Angle.Degrees(-70.43377284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117514"},
        {"Hipparcos Number", "HIP 66104"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.26438121),
        dec: Angle.Degrees(-70.43370857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212211"},
        {"Hipparcos Number", "HIP 110668"},
        {"Fundamental Katalog 5th Edition", "FK5 3788"},
        {"Geneva Identification System", "GEN# +1.00212211"},
        {"Smithsonian Astrophysical Observation", "SAO 258034"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.29329897),
        dec: Angle.Degrees(-70.43147060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116284"},
        {"Hipparcos Number", "HIP 65433"},
        {"Smithsonian Astrophysical Observation", "SAO 257040"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16452610),
        dec: Angle.Degrees(-70.42992375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -251.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93550"},
        {"Hipparcos Number", "HIP 52642"},
        {"Smithsonian Astrophysical Observation", "SAO 256755"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.46794307),
        dec: Angle.Degrees(-70.42905150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199819"},
        {"Hipparcos Number", "HIP 103978"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.01256718),
        dec: Angle.Degrees(-70.42854190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199005"},
        {"Hipparcos Number", "HIP 103542"},
        {"Geneva Identification System", "GEN# +1.00199005"},
        {"Smithsonian Astrophysical Observation", "SAO 257869"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.66711919),
        dec: Angle.Degrees(-70.42219286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27346"},
        {"Hipparcos Number", "HIP 19704"},
        {"Fundamental Katalog 5th Edition", "FK5 2311"},
        {"Geneva Identification System", "GEN# +1.00027346"},
        {"Smithsonian Astrophysical Observation", "SAO 256073"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.31229186),
        dec: Angle.Degrees(-70.42058526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110118"},
        {"Hipparcos Number", "HIP 61888"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.22424643),
        dec: Angle.Degrees(-70.42048562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12851"},
        {"Hipparcos Number", "HIP 9540"},
        {"Geneva Identification System", "GEN# +1.00012851"},
        {"Smithsonian Astrophysical Observation", "SAO 255842"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.65744321),
        dec: Angle.Degrees(-70.41954385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124198"},
        {"Hipparcos Number", "HIP 69654"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.83806577),
        dec: Angle.Degrees(-70.41704857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75911"},
        {"Hipparcos Number", "HIP 43221"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.07197992),
        dec: Angle.Degrees(-70.41700911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118925"},
        {"Hipparcos Number", "HIP 66896"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.63774866),
        dec: Angle.Degrees(-70.41684896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134735"},
        {"Hipparcos Number", "HIP 74701"},
        {"Fundamental Katalog 5th Edition", "FK5 3200"},
        {"Geneva Identification System", "GEN# +1.00134735"},
        {"Smithsonian Astrophysical Observation", "SAO 257258"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.99388395),
        dec: Angle.Degrees(-70.41357161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82007"},
        {"Hipparcos Number", "HIP 46215"},
        {"Smithsonian Astrophysical Observation", "SAO 256616"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.33144001),
        dec: Angle.Degrees(-70.41273449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118230"},
        {"Hipparcos Number", "HIP 66506"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.49282429),
        dec: Angle.Degrees(-70.41196486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81910"},
        {"Hipparcos Number", "HIP 46145"},
        {"Celescope Catalog", "CEL 3290"},
        {"Geneva Identification System", "GEN# +1.00081910J"},
        {"Smithsonian Astrophysical Observation", "SAO 256612"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.16116563),
        dec: Angle.Degrees(-70.40996167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225252"},
        {"Hipparcos Number", "HIP 372"},
        {"Geneva Identification System", "GEN# +1.00225252"},
        {"Smithsonian Astrophysical Observation", "SAO 255630"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.16559564),
        dec: Angle.Degrees(-70.40421693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59663"},
        {"Hipparcos Number", "HIP 35999"},
        {"Fundamental Katalog 5th Edition", "FK5 4668"},
        {"Smithsonian Astrophysical Observation", "SAO 256410"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.28793950),
        dec: Angle.Degrees(-70.40385878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70350"},
        {"Hipparcos Number", "HIP 40511"},
        {"Geneva Identification System", "GEN# +1.00070350"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.06284349),
        dec: Angle.Degrees(-70.40146012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137331"},
        {"Hipparcos Number", "HIP 75903"},
        {"Fundamental Katalog 5th Edition", "FK5 5372"},
        {"Smithsonian Astrophysical Observation", "SAO 257283"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.55270855),
        dec: Angle.Degrees(-70.39421804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1261"},
        {"Hipparcos Number", "HIP 1309"},
        {"Smithsonian Astrophysical Observation", "SAO 255651"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.10158735),
        dec: Angle.Degrees(-70.39239137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80766"},
        {"Hipparcos Number", "HIP 45582"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.35849428),
        dec: Angle.Degrees(-70.38900445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74405"},
        {"Hipparcos Number", "HIP 42425"},
        {"Celescope Catalog", "CEL 2768"},
        {"Fundamental Katalog 5th Edition", "FK5 2683"},
        {"Geneva Identification System", "GEN# +1.00074405"},
        {"Smithsonian Astrophysical Observation", "SAO 256535"},
        {"Wilson Evans Batten Catalogue", "WEB 8161"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.77136771),
        dec: Angle.Degrees(-70.38665235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184309"},
        {"Hipparcos Number", "HIP 96705"},
        {"Smithsonian Astrophysical Observation", "SAO 257714"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.89210791),
        dec: Angle.Degrees(-70.38328643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61655"},
        {"Hipparcos Number", "HIP 36845"},
        {"Smithsonian Astrophysical Observation", "SAO 256425"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.64085111),
        dec: Angle.Degrees(-70.38206695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28815"},
        {"Hipparcos Number", "HIP 20743"},
        {"Smithsonian Astrophysical Observation", "SAO 256091"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.67616998),
        dec: Angle.Degrees(-70.38107994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128574"},
        {"Hipparcos Number", "HIP 71826"},
        {"Renson", "Renson 36570"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.39289927),
        dec: Angle.Degrees(-70.37867775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97175"},
        {"Hipparcos Number", "HIP 54550"},
        {"Celescope Catalog", "CEL 3827"},
        {"Geneva Identification System", "GEN# +1.00097175"},
        {"Smithsonian Astrophysical Observation", "SAO 256805"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.43835278),
        dec: Angle.Degrees(-70.36771683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88474"},
        {"Hipparcos Number", "HIP 49732"},
        {"Geneva Identification System", "GEN# +1.00088474"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.28963850),
        dec: Angle.Degrees(-70.36611988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97986"},
        {"Hipparcos Number", "HIP 54923"},
        {"Geneva Identification System", "GEN# +1.00097986"},
        {"Renson", "Renson 28260"},
        {"Smithsonian Astrophysical Observation", "SAO 256816"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.70603757),
        dec: Angle.Degrees(-70.36047222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24502"},
        {"Hipparcos Number", "HIP 17802"},
        {"Geneva Identification System", "GEN# +1.00024502"},
        {"Smithsonian Astrophysical Observation", "SAO 256032"},
        {"Wilson Evans Batten Catalogue", "WEB 3417"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.15792089),
        dec: Angle.Degrees(-70.35969166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207365"},
        {"Hipparcos Number", "HIP 107911"},
        {"Geneva Identification System", "GEN# +1.00207365"},
        {"Smithsonian Astrophysical Observation", "SAO 257969"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.94745700),
        dec: Angle.Degrees(-70.35157130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310407"},
        {"Hipparcos Number", "HIP 54777"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.21218449),
        dec: Angle.Degrees(-70.35039701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154178"},
        {"Hipparcos Number", "HIP 83966"},
        {"Smithsonian Astrophysical Observation", "SAO 257468"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.45208527),
        dec: Angle.Degrees(-70.34932842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99040"},
        {"Smithsonian Astrophysical Observation", "SAO 257768"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.61869319),
        dec: Angle.Degrees(-70.34836012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215729"},
        {"Hipparcos Number", "HIP 112694"},
        {"Geneva Identification System", "GEN# +1.00215729"},
        {"Smithsonian Astrophysical Observation", "SAO 258070"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.32270149),
        dec: Angle.Degrees(-70.34806201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7304"},
        {"Hipparcos Number", "HIP 5565"},
        {"Smithsonian Astrophysical Observation", "SAO 255750"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.84623108),
        dec: Angle.Degrees(-70.34711200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219078"},
        {"Hipparcos Number", "HIP 114718"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.56793840),
        dec: Angle.Degrees(-70.33830385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67706"},
        {"Hipparcos Number", "HIP 39451"},
        {"Smithsonian Astrophysical Observation", "SAO 256471"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.96322349),
        dec: Angle.Degrees(-70.33734249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142086"},
        {"Hipparcos Number", "HIP 78181"},
    },
    visualMagnitude: 10.68,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.44917926),
        dec: Angle.Degrees(-70.32529059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196641"},
        {"Hipparcos Number", "HIP 102286"},
        {"Smithsonian Astrophysical Observation", "SAO 257845"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.88745087),
        dec: Angle.Degrees(-70.32487674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219746"},
        {"Hipparcos Number", "HIP 115151"},
        {"Smithsonian Astrophysical Observation", "SAO 258128"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.87070911),
        dec: Angle.Degrees(-70.32307622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114462"},
        {"Hipparcos Number", "HIP 64435"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.09879132),
        dec: Angle.Degrees(-70.32187983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163073"},
        {"Hipparcos Number", "HIP 88173"},
        {"Smithsonian Astrophysical Observation", "SAO 257548"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.11907324),
        dec: Angle.Degrees(-70.32017460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165357"},
        {"Hipparcos Number", "HIP 89162"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.94660467),
        dec: Angle.Degrees(-70.31853696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107185"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.66072723),
        dec: Angle.Degrees(-70.31710543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182163"},
        {"Hipparcos Number", "HIP 95800"},
        {"Geneva Identification System", "GEN# +1.00182163"},
        {"Smithsonian Astrophysical Observation", "SAO 257694"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.29203264),
        dec: Angle.Degrees(-70.31508056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92479"},
        {"Hipparcos Number", "HIP 52079"},
        {"Smithsonian Astrophysical Observation", "SAO 256738"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.62799150),
        dec: Angle.Degrees(-70.30984724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110160"},
    },
    visualMagnitude: 11.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.70034558),
        dec: Angle.Degrees(-70.30569553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123377"},
        {"Hipparcos Number", "HIP 69241"},
        {"Fundamental Katalog 5th Edition", "FK5 3123"},
        {"Geneva Identification System", "GEN# +1.00123377"},
        {"Smithsonian Astrophysical Observation", "SAO 257119"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.62879682),
        dec: Angle.Degrees(-70.30545037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171722"},
        {"Hipparcos Number", "HIP 91744"},
        {"Fundamental Katalog 5th Edition", "FK5 5643"},
        {"Smithsonian Astrophysical Observation", "SAO 257619"},
    },
    visualMagnitude: 7.25,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.62502709),
        dec: Angle.Degrees(-70.30312137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8834"},
        {"Smithsonian Astrophysical Observation", "SAO 255828"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.40377311),
        dec: Angle.Degrees(-70.30173680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153142"},
        {"Hipparcos Number", "HIP 83473"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.90022113),
        dec: Angle.Degrees(-70.30013152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4192"},
        {"Hipparcos Number", "HIP 3392"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.80385436),
        dec: Angle.Degrees(-70.29696318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15155"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.83874809),
        dec: Angle.Degrees(-70.29565804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 281.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139658"},
        {"Hipparcos Number", "HIP 77088"},
        {"Geneva Identification System", "GEN# +1.00139658"},
        {"Smithsonian Astrophysical Observation", "SAO 257313"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.09626858),
        dec: Angle.Degrees(-70.29357855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135142"},
        {"Hipparcos Number", "HIP 74874"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.53394266),
        dec: Angle.Degrees(-70.29210345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128218"},
        {"Hipparcos Number", "HIP 71661"},
        {"Smithsonian Astrophysical Observation", "SAO 257178"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.86027427),
        dec: Angle.Degrees(-70.29004063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41050"},
        {"Hipparcos Number", "HIP 28115"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.13734801),
        dec: Angle.Degrees(-70.28955961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84798"},
        {"Hipparcos Number", "HIP 47753"},
        {"Geneva Identification System", "GEN# +1.00084798"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.02877785),
        dec: Angle.Degrees(-70.28767347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270196"},
        {"Hipparcos Number", "HIP 27655"},
        {"Geneva Identification System", "GEN# +1.00270196"},
    },
    visualMagnitude: 11.61,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.83656955),
        dec: Angle.Degrees(-70.28591765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209635"},
        {"Hipparcos Number", "HIP 109245"},
        {"Geneva Identification System", "GEN# +1.00209635"},
        {"Smithsonian Astrophysical Observation", "SAO 258000"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.97161384),
        dec: Angle.Degrees(-70.28573357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84696"},
        {"Hipparcos Number", "HIP 47695"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.87006584),
        dec: Angle.Degrees(-70.28007945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26109"},
        {"Hipparcos Number", "HIP 18842"},
        {"Smithsonian Astrophysical Observation", "SAO 256054"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.60590224),
        dec: Angle.Degrees(-70.27214326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188146"},
        {"Hipparcos Number", "HIP 98372"},
        {"Smithsonian Astrophysical Observation", "SAO 257752"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.79018790),
        dec: Angle.Degrees(-70.26878213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113224"},
        {"Hipparcos Number", "HIP 63749"},
        {"Smithsonian Astrophysical Observation", "SAO 257006"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.97328239),
        dec: Angle.Degrees(-70.26840745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139508"},
        {"Hipparcos Number", "HIP 77017"},
        {"Smithsonian Astrophysical Observation", "SAO 257312"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.88254939),
        dec: Angle.Degrees(-70.26664806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89331"},
        {"Hipparcos Number", "HIP 50249"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.90967069),
        dec: Angle.Degrees(-70.26324662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3452"},
        {"Hipparcos Number", "HIP 2879"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.11746040),
        dec: Angle.Degrees(-70.26271153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31335"},
        {"Hipparcos Number", "HIP 22366"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.22778012),
        dec: Angle.Degrees(-70.25921225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132991"},
        {"Hipparcos Number", "HIP 73926"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.60991337),
        dec: Angle.Degrees(-70.25438710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219381"},
        {"Hipparcos Number", "HIP 114917"},
        {"Smithsonian Astrophysical Observation", "SAO 258124"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.15729844),
        dec: Angle.Degrees(-70.25102847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71613"},
        {"Hipparcos Number", "HIP 41119"},
        {"Smithsonian Astrophysical Observation", "SAO 256506"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.85558972),
        dec: Angle.Degrees(-70.24867256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2137"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.77291014),
        dec: Angle.Degrees(-70.24850054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 371.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160073"},
        {"Hipparcos Number", "HIP 86794"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.02783892),
        dec: Angle.Degrees(-70.24160561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142391"},
        {"Hipparcos Number", "HIP 78329"},
    },
    visualMagnitude: 10.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.90819579),
        dec: Angle.Degrees(-70.24133905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70398"},
        {"Hipparcos Number", "HIP 40540"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.16713397),
        dec: Angle.Degrees(-70.23940279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126508"},
        {"Hipparcos Number", "HIP 70871"},
        {"Smithsonian Astrophysical Observation", "SAO 257165"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.39026193),
        dec: Angle.Degrees(-70.23842765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171042"},
        {"Hipparcos Number", "HIP 91425"},
        {"Smithsonian Astrophysical Observation", "SAO 257612"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.67645075),
        dec: Angle.Degrees(-70.23541798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82444"},
    },
    visualMagnitude: 11.48,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.73474693),
        dec: Angle.Degrees(-70.23245598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201816"},
        {"Hipparcos Number", "HIP 105013"},
        {"Renson", "Renson 56280"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.04720071),
        dec: Angle.Degrees(-70.23226136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78845"},
        {"Hipparcos Number", "HIP 44663"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.52235738),
        dec: Angle.Degrees(-70.23190685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164076"},
        {"Hipparcos Number", "HIP 88621"},
        {"Smithsonian Astrophysical Observation", "SAO 257561"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.40316699),
        dec: Angle.Degrees(-70.22964297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270011"},
        {"Hipparcos Number", "HIP 26884"},
        {"Geneva Identification System", "GEN# +1.00270011"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.61652894),
        dec: Angle.Degrees(-70.22782737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138965"},
        {"Hipparcos Number", "HIP 76736"},
        {"Fundamental Katalog 5th Edition", "FK5 3233"},
        {"Geneva Identification System", "GEN# +1.00138965"},
        {"Smithsonian Astrophysical Observation", "SAO 257308"},
        {"Wilson Evans Batten Catalogue", "WEB 13021"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.04844303),
        dec: Angle.Degrees(-70.22774887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102839"},
        {"Hipparcos Number", "HIP 57696"},
        {"Fundamental Katalog 5th Edition", "FK5 2945"},
        {"Geneva Identification System", "GEN# +1.00102839"},
        {"Smithsonian Astrophysical Observation", "SAO 251604"},
        {"Wilson Evans Batten Catalogue", "WEB 10360"},
    },
    visualMagnitude: 4.98,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.48594609),
        dec: Angle.Degrees(-70.22578580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17981"},
        {"Hipparcos Number", "HIP 13153"},
        {"Smithsonian Astrophysical Observation", "SAO 255925"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.28971352),
        dec: Angle.Degrees(-70.21861662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225299"},
        {"Hipparcos Number", "HIP 407"},
        {"Geneva Identification System", "GEN# +1.00225299"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.24427458),
        dec: Angle.Degrees(-70.21220744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63492"},
        {"Geneva Identification System", "GEN# -0.06901743"},
        {"Smithsonian Astrophysical Observation", "SAO 252121"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.14200835),
        dec: Angle.Degrees(-70.20990290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58356"},
        {"Hipparcos Number", "HIP 35492"},
        {"Geneva Identification System", "GEN# +1.00058356"},
        {"Smithsonian Astrophysical Observation", "SAO 256395"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.87437065),
        dec: Angle.Degrees(-70.20833708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100857"},
        {"Hipparcos Number", "HIP 56552"},
        {"Smithsonian Astrophysical Observation", "SAO 251473"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.92845986),
        dec: Angle.Degrees(-70.20719797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36175"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.75974462),
        dec: Angle.Degrees(-70.20257500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186531"},
        {"Hipparcos Number", "HIP 97621"},
        {"Geneva Identification System", "GEN# +1.00186531"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.61843001),
        dec: Angle.Degrees(-70.19614809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100546"},
        {"Hipparcos Number", "HIP 56379"},
        {"Celescope Catalog", "CEL 3915"},
        {"Geneva Identification System", "GEN# +1.00100546"},
        {"Smithsonian Astrophysical Observation", "SAO 251457"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.35628150),
        dec: Angle.Degrees(-70.19478853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110361"},
        {"Hipparcos Number", "HIP 62011"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.63916405),
        dec: Angle.Degrees(-70.19433484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144484"},
        {"Hipparcos Number", "HIP 79334"},
        {"Smithsonian Astrophysical Observation", "SAO 257369"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.87146090),
        dec: Angle.Degrees(-70.19425877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6160"},
        {"Hipparcos Number", "HIP 4746"},
        {"Geneva Identification System", "GEN# +1.00006160"},
    },
    visualMagnitude: 10.11,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.25700035),
        dec: Angle.Degrees(-70.19131855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186302"},
        {"Hipparcos Number", "HIP 97507"},
        {"Geneva Identification System", "GEN# +1.00186302"},
        {"Smithsonian Astrophysical Observation", "SAO 257737"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.27696531),
        dec: Angle.Degrees(-70.18787856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45895"},
        {"Hipparcos Number", "HIP 30447"},
        {"Geneva Identification System", "GEN# +1.00045895"},
        {"Smithsonian Astrophysical Observation", "SAO 256301"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.00851799),
        dec: Angle.Degrees(-70.18686816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118326"},
        {"Hipparcos Number", "HIP 66572"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.68764714),
        dec: Angle.Degrees(-70.18658993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189472"},
        {"Hipparcos Number", "HIP 98957"},
        {"Renson", "Renson 52510"},
        {"Smithsonian Astrophysical Observation", "SAO 257766"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.37055983),
        dec: Angle.Degrees(-70.18450549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269157"},
        {"Hipparcos Number", "HIP 24066"},
        {"Geneva Identification System", "GEN# +1.00269157"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.56453317),
        dec: Angle.Degrees(-70.17777998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6045"},
        {"Hipparcos Number", "HIP 4684"},
        {"Geneva Identification System", "GEN# +1.00006045"},
        {"Smithsonian Astrophysical Observation", "SAO 255728"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.04204344),
        dec: Angle.Degrees(-70.17678900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123627"},
        {"Hipparcos Number", "HIP 69371"},
        {"Geneva Identification System", "GEN# +1.00123627"},
        {"Renson", "Renson 35410"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.00557226),
        dec: Angle.Degrees(-70.17516138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151540"},
        {"Hipparcos Number", "HIP 82658"},
        {"Smithsonian Astrophysical Observation", "SAO 257440"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.45710910),
        dec: Angle.Degrees(-70.17094961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58542"},
        {"Hipparcos Number", "HIP 35559"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.06998806),
        dec: Angle.Degrees(-70.17007624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149250"},
        {"Hipparcos Number", "HIP 81554"},
        {"Renson", "Renson 42230"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.83782249),
        dec: Angle.Degrees(-70.16854599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77832"},
        {"Hipparcos Number", "HIP 44226"},
        {"Geneva Identification System", "GEN# +1.00077832"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.12197447),
        dec: Angle.Degrees(-70.16682076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162447"},
        {"Hipparcos Number", "HIP 87891"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.30468602),
        dec: Angle.Degrees(-70.16426989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201210"},
        {"Hipparcos Number", "HIP 104685"},
        {"Smithsonian Astrophysical Observation", "SAO 257895"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.07936912),
        dec: Angle.Degrees(-70.16153330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30956"},
        {"Hipparcos Number", "HIP 22155"},
        {"Geneva Identification System", "GEN# +1.00030956"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.50555293),
        dec: Angle.Degrees(-70.16103546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71864"},
        {"Hipparcos Number", "HIP 41217"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.15727373),
        dec: Angle.Degrees(-70.15868514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103766"},
        {"Hipparcos Number", "HIP 58247"},
        {"Smithsonian Astrophysical Observation", "SAO 251651"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.18944486),
        dec: Angle.Degrees(-70.15617308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140393"},
        {"Hipparcos Number", "HIP 77424"},
        {"Renson", "Renson 39900"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.09134814),
        dec: Angle.Degrees(-70.15503249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106111"},
        {"Hipparcos Number", "HIP 59551"},
        {"Geneva Identification System", "GEN# +1.00106111"},
        {"Smithsonian Astrophysical Observation", "SAO 251791"},
        {"Wilson Evans Batten Catalogue", "WEB 10586"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.19596584),
        dec: Angle.Degrees(-70.15178663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114571"},
        {"Hipparcos Number", "HIP 64491"},
        {"Geneva Identification System", "GEN# +1.00114571"},
        {"Smithsonian Astrophysical Observation", "SAO 252198"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.28334214),
        dec: Angle.Degrees(-70.15166010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39194"},
        {"Hipparcos Number", "HIP 27080"},
        {"Cincinnati Publication", "Ci 18 734"},
        {"Cincinnati Publication 2", "Ci 20 353"},
        {"Geneva Identification System", "GEN# +1.00039194"},
        {"Smithsonian Astrophysical Observation", "SAO 256232"},
        {"Wilson Evans Batten Catalogue", "WEB 5331"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.13520683),
        dec: Angle.Degrees(-70.14658241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -309.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1239.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146893"},
        {"Hipparcos Number", "HIP 80342"},
        {"Smithsonian Astrophysical Observation", "SAO 257394"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.01868252),
        dec: Angle.Degrees(-70.14514870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9849"},
        {"Hipparcos Number", "HIP 7272"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.41575940),
        dec: Angle.Degrees(-70.13522225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99205"},
        {"Hipparcos Number", "HIP 55644"},
        {"Geneva Identification System", "GEN# +1.00099205"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.98505534),
        dec: Angle.Degrees(-70.13389532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131566"},
        {"Hipparcos Number", "HIP 73268"},
        {"Smithsonian Astrophysical Observation", "SAO 252968"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.62203036),
        dec: Angle.Degrees(-70.12924825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9232"},
        {"Hipparcos Number", "HIP 6875"},
        {"Geneva Identification System", "GEN# +1.00009232"},
        {"Smithsonian Astrophysical Observation", "SAO 255782"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.12130240),
        dec: Angle.Degrees(-70.12789157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203499"},
        {"Hipparcos Number", "HIP 105870"},
        {"Smithsonian Astrophysical Observation", "SAO 257922"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.62437103),
        dec: Angle.Degrees(-70.12733483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201371"},
        {"Hipparcos Number", "HIP 104755"},
        {"Fundamental Katalog 5th Edition", "FK5 1554"},
        {"Geneva Identification System", "GEN# +1.00201371"},
        {"Smithsonian Astrophysical Observation", "SAO 257896"},
        {"Wilson Evans Batten Catalogue", "WEB 19051"},
    },
    visualMagnitude: 5.06,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.33516015),
        dec: Angle.Degrees(-70.12621725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224866"},
        {"Hipparcos Number", "HIP 108"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.33655323),
        dec: Angle.Degrees(-70.12530771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70878"},
    },
    visualMagnitude: 10.30,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)29, 41.2300),
        dec: Angle.DegreesMinutesSeconds((int)-70, (int)07, 30.900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102401"},
        {"Hipparcos Number", "HIP 57453"},
        {"Geneva Identification System", "GEN# +1.00102401"},
        {"Smithsonian Astrophysical Observation", "SAO 251584"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.66539777),
        dec: Angle.Degrees(-70.12378771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156190"},
        {"Hipparcos Number", "HIP 84979"},
        {"Fundamental Katalog 5th Edition", "FK5 642"},
        {"Geneva Identification System", "GEN# +1.00156190"},
        {"Smithsonian Astrophysical Observation", "SAO 257491"},
        {"Wilson Evans Batten Catalogue", "WEB 14354"},
    },
    visualMagnitude: 5.39,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.52449572),
        dec: Angle.Degrees(-70.12317887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70877"},
        {"Geneva Identification System", "GEN# -0.06902055"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.41281183),
        dec: Angle.Degrees(-70.12225700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56478"},
        {"Hipparcos Number", "HIP 34706"},
        {"Smithsonian Astrophysical Observation", "SAO 256378"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.82061267),
        dec: Angle.Degrees(-70.11966254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121254"},
        {"Hipparcos Number", "HIP 68163"},
        {"Geneva Identification System", "GEN# +1.00121254"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.32268045),
        dec: Angle.Degrees(-70.11832976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85012"},
        {"Hipparcos Number", "HIP 47892"},
        {"Celescope Catalog", "CEL 3381"},
        {"Geneva Identification System", "GEN# +1.00085012J"},
        {"Smithsonian Astrophysical Observation", "SAO 250689"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.41818420),
        dec: Angle.Degrees(-70.11826269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207870"},
        {"Hipparcos Number", "HIP 108220"},
        {"Smithsonian Astrophysical Observation", "SAO 257979"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.86435212),
        dec: Angle.Degrees(-70.11528049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41925"},
        {"Hipparcos Number", "HIP 28566"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.43461271),
        dec: Angle.Degrees(-70.11385095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73406"},
        {"Hipparcos Number", "HIP 41985"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.37426939),
        dec: Angle.Degrees(-70.11375924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83306"},
    },
    visualMagnitude: 11.80,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.37999734),
        dec: Angle.Degrees(-70.11366676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137927"},
        {"Hipparcos Number", "HIP 76184"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.41580295),
        dec: Angle.Degrees(-70.11052121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199834"},
        {"Hipparcos Number", "HIP 103982"},
        {"Smithsonian Astrophysical Observation", "SAO 257880"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.01986400),
        dec: Angle.Degrees(-70.10785070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180964"},
        {"Hipparcos Number", "HIP 95390"},
        {"Geneva Identification System", "GEN# +1.00180964"},
        {"Smithsonian Astrophysical Observation", "SAO 257682"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.07575257),
        dec: Angle.Degrees(-70.10724090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169864"},
        {"Hipparcos Number", "HIP 90922"},
        {"Geneva Identification System", "GEN# +1.00169864"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.20822744),
        dec: Angle.Degrees(-70.10341745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15439"},
        {"Hipparcos Number", "HIP 11303"},
        {"Geneva Identification System", "GEN# +1.00015439"},
        {"Smithsonian Astrophysical Observation", "SAO 255883"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.37560135),
        dec: Angle.Degrees(-70.10191106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77048"},
        {"Hipparcos Number", "HIP 43823"},
        {"Smithsonian Astrophysical Observation", "SAO 250383"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.87600179),
        dec: Angle.Degrees(-70.10048181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48733"},
        {"Hipparcos Number", "HIP 31725"},
        {"Geneva Identification System", "GEN# +1.00048733"},
        {"Smithsonian Astrophysical Observation", "SAO 256322"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.55380588),
        dec: Angle.Degrees(-70.09431807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72337"},
        {"Hipparcos Number", "HIP 41451"},
        {"Geneva Identification System", "GEN# +1.00072337"},
        {"Smithsonian Astrophysical Observation", "SAO 250235"},
        {"Wilson Evans Batten Catalogue", "WEB 8015"},
    },
    visualMagnitude: 5.51,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.81994813),
        dec: Angle.Degrees(-70.09359517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64980"},
        {"Hipparcos Number", "HIP 38311"},
        {"Geneva Identification System", "GEN# +1.00064980"},
        {"Wilson Evans Batten Catalogue", "WEB 7539"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.73682643),
        dec: Angle.Degrees(-70.08851135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84185"},
        {"Geneva Identification System", "GEN# -0.06902698"},
        {"Renson", "Renson 43680"},
    },
    visualMagnitude: 9.33,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.13705688),
        dec: Angle.Degrees(-70.08570008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147584"},
        {"Hipparcos Number", "HIP 80686"},
        {"Fundamental Katalog 5th Edition", "FK5 610"},
        {"Geneva Identification System", "GEN# +1.00147584"},
        {"Smithsonian Astrophysical Observation", "SAO 253554"},
        {"Wilson Evans Batten Catalogue", "WEB 13646"},
    },
    visualMagnitude: 4.90,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.11583852),
        dec: Angle.Degrees(-70.08467012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91561"},
        {"Hipparcos Number", "HIP 51578"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.01853798),
        dec: Angle.Degrees(-70.08425431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177542"},
        {"Hipparcos Number", "HIP 94245"},
        {"Geneva Identification System", "GEN# +1.00177542"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.75888964),
        dec: Angle.Degrees(-70.08117119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164750"},
        {"Hipparcos Number", "HIP 88888"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.19150821),
        dec: Angle.Degrees(-70.07963078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134453"},
        {"Hipparcos Number", "HIP 74582"},
        {"Geneva Identification System", "GEN# +1.00134453"},
        {"Smithsonian Astrophysical Observation", "SAO 253062"},
        {"Wilson Evans Batten Catalogue", "WEB 12728"},
    },
    visualMagnitude: 5.75,
    bvColour: 3.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.57986595),
        dec: Angle.Degrees(-70.07945566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202400"},
        {"Hipparcos Number", "HIP 105294"},
        {"Renson", "Renson 56390"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.90926663),
        dec: Angle.Degrees(-70.07828139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81896"},
        {"Hipparcos Number", "HIP 46143"},
        {"Smithsonian Astrophysical Observation", "SAO 250572"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.15482482),
        dec: Angle.Degrees(-70.07577997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85543"},
        {"Hipparcos Number", "HIP 48179"},
        {"Geneva Identification System", "GEN# +1.00085543"},
        {"Smithsonian Astrophysical Observation", "SAO 250711"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.30789421),
        dec: Angle.Degrees(-70.07501969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216437"},
        {"Hipparcos Number", "HIP 113137"},
        {"Fundamental Katalog 5th Edition", "FK5 865"},
        {"Geneva Identification System", "GEN# +1.00216437"},
        {"Smithsonian Astrophysical Observation", "SAO 258084"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.66482152),
        dec: Angle.Degrees(-70.07388667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195832"},
        {"Hipparcos Number", "HIP 101865"},
        {"Fundamental Katalog 5th Edition", "FK5 5815"},
        {"Geneva Identification System", "GEN# +1.00195832"},
        {"Smithsonian Astrophysical Observation", "SAO 257833"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.62558717),
        dec: Angle.Degrees(-70.07277365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29946"},
        {"Hipparcos Number", "HIP 21527"},
        {"Smithsonian Astrophysical Observation", "SAO 256111"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.33321819),
        dec: Angle.Degrees(-70.07108474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221669"},
        {"Hipparcos Number", "HIP 116363"},
        {"Geneva Identification System", "GEN# +1.00221669"},
        {"Smithsonian Astrophysical Observation", "SAO 258159"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.68876450),
        dec: Angle.Degrees(-70.06982396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11306"},
        {"Hipparcos Number", "HIP 8394"},
        {"Geneva Identification System", "GEN# +1.00011306"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.07882716),
        dec: Angle.Degrees(-70.06957596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207896"},
        {"Hipparcos Number", "HIP 108232"},
        {"Geneva Identification System", "GEN# +1.00207896"},
        {"Smithsonian Astrophysical Observation", "SAO 257980"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.89229955),
        dec: Angle.Degrees(-70.06822366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176315"},
        {"Hipparcos Number", "HIP 93756"},
        {"Smithsonian Astrophysical Observation", "SAO 257655"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.38502576),
        dec: Angle.Degrees(-70.06680317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63428"},
        {"Hipparcos Number", "HIP 37631"},
        {"Geneva Identification System", "GEN# +1.00063428"},
        {"Smithsonian Astrophysical Observation", "SAO 249940"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.83287816),
        dec: Angle.Degrees(-70.06389556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36598"},
        {"Hipparcos Number", "HIP 25452"},
        {"Geneva Identification System", "GEN# +1.00036598"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.66074576),
        dec: Angle.Degrees(-70.06368899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129147"},
        {"Hipparcos Number", "HIP 72095"},
        {"Geneva Identification System", "GEN# +1.00129147"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.23100180),
        dec: Angle.Degrees(-70.06025834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143364"},
        {"Hipparcos Number", "HIP 78804"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.32283335),
        dec: Angle.Degrees(-70.05854450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219048"},
        {"Hipparcos Number", "HIP 114708"},
        {"Geneva Identification System", "GEN# +1.00219048"},
        {"Smithsonian Astrophysical Observation", "SAO 258119"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.53330638),
        dec: Angle.Degrees(-70.05839192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 384"},
        {"Hipparcos Number", "HIP 662"},
        {"Smithsonian Astrophysical Observation", "SAO 255637"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.04986865),
        dec: Angle.Degrees(-70.05583226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12491"},
        {"Hipparcos Number", "HIP 9290"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.84260276),
        dec: Angle.Degrees(-70.05511788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94745"},
        {"Hipparcos Number", "HIP 53340"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.63785568),
        dec: Angle.Degrees(-70.05497016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18489"},
        {"Hipparcos Number", "HIP 13515"},
        {"Smithsonian Astrophysical Observation", "SAO 255933"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.51859135),
        dec: Angle.Degrees(-70.05023813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268957"},
        {"Hipparcos Number", "HIP 23397"},
        {"Geneva Identification System", "GEN# +1.00268957"},
        {"Wilson Evans Batten Catalogue", "WEB 4543"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.43492980),
        dec: Angle.Degrees(-70.04855497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 129.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120564"},
        {"Hipparcos Number", "HIP 67767"},
        {"Smithsonian Astrophysical Observation", "SAO 252491"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.24659667),
        dec: Angle.Degrees(-70.04723974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182510"},
        {"Hipparcos Number", "HIP 95946"},
        {"Smithsonian Astrophysical Observation", "SAO 257699"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.67658321),
        dec: Angle.Degrees(-70.04706574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155875"},
        {"Hipparcos Number", "HIP 84827"},
        {"Geneva Identification System", "GEN# +1.00155875J"},
        {"Smithsonian Astrophysical Observation", "SAO 253870"},
        {"Wilson Evans Batten Catalogue", "WEB 14318"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.05316269),
        dec: Angle.Degrees(-70.04488738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222667"},
        {"Hipparcos Number", "HIP 116996"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.77651159),
        dec: Angle.Degrees(-70.04429444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218245"},
        {"Hipparcos Number", "HIP 114226"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.98485337),
        dec: Angle.Degrees(-70.03969852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221977"},
        {"Hipparcos Number", "HIP 116561"},
        {"Smithsonian Astrophysical Observation", "SAO 258163"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.32422050),
        dec: Angle.Degrees(-70.03829493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89080"},
        {"Hipparcos Number", "HIP 50099"},
        {"Fundamental Katalog 5th Edition", "FK5 385"},
        {"Geneva Identification System", "GEN# +1.00089080"},
        {"Smithsonian Astrophysical Observation", "SAO 250885"},
        {"Wilson Evans Batten Catalogue", "WEB 9211"},
    },
    visualMagnitude: 3.29,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.43449551),
        dec: Angle.Degrees(-70.03792169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132520"},
        {"Hipparcos Number", "HIP 73697"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.95242267),
        dec: Angle.Degrees(-70.03715332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111953"},
        {"Hipparcos Number", "HIP 62981"},
        {"Geneva Identification System", "GEN# +1.00111953"},
        {"Smithsonian Astrophysical Observation", "SAO 252081"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.57449709),
        dec: Angle.Degrees(-70.03678267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125781"},
        {"Hipparcos Number", "HIP 70493"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.28056147),
        dec: Angle.Degrees(-70.02959930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67279"},
        {"Hipparcos Number", "HIP 39274"},
        {"Smithsonian Astrophysical Observation", "SAO 250086"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.46519026),
        dec: Angle.Degrees(-70.02740812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24062"},
        {"Hipparcos Number", "HIP 17486"},
        {"Geneva Identification System", "GEN# +1.00024062"},
        {"Smithsonian Astrophysical Observation", "SAO 256022"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.19526667),
        dec: Angle.Degrees(-70.02641392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67200"},
        {"Hipparcos Number", "HIP 39242"},
        {"Geneva Identification System", "GEN# +1.00067200"},
        {"Smithsonian Astrophysical Observation", "SAO 250085"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.38546675),
        dec: Angle.Degrees(-70.02413365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24085"},
        {"Hipparcos Number", "HIP 17515"},
        {"Geneva Identification System", "GEN# +1.00024085"},
        {"Smithsonian Astrophysical Observation", "SAO 256023"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.25652394),
        dec: Angle.Degrees(-70.02386363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185560"},
        {"Hipparcos Number", "HIP 97185"},
        {"Smithsonian Astrophysical Observation", "SAO 257725"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.29326179),
        dec: Angle.Degrees(-70.01640741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194508"},
        {"Hipparcos Number", "HIP 101205"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.71611402),
        dec: Angle.Degrees(-70.01507792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65902"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.63324031),
        dec: Angle.Degrees(-70.01336504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41846"},
        {"Hipparcos Number", "HIP 28529"},
        {"Renson", "Renson 11170"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.33029264),
        dec: Angle.Degrees(-70.01330766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104936"},
        {"Hipparcos Number", "HIP 58928"},
        {"Smithsonian Astrophysical Observation", "SAO 251724"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.25053204),
        dec: Angle.Degrees(-70.00214678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110357"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.26850744),
        dec: Angle.Degrees(-69.99696738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 149.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28701"},
        {"Hipparcos Number", "HIP 20677"},
        {"Geneva Identification System", "GEN# +1.00028701"},
        {"Smithsonian Astrophysical Observation", "SAO 256088"},
        {"Wilson Evans Batten Catalogue", "WEB 3961"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.44000768),
        dec: Angle.Degrees(-69.99369813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9581"},
        {"Hipparcos Number", "HIP 7107"},
        {"Smithsonian Astrophysical Observation", "SAO 255788"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.89075706),
        dec: Angle.Degrees(-69.99258850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118684"},
        {"Hipparcos Number", "HIP 66750"},
        {"Smithsonian Astrophysical Observation", "SAO 252404"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.21203768),
        dec: Angle.Degrees(-69.99085594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110406"},
        {"Hipparcos Number", "HIP 62029"},
        {"Geneva Identification System", "GEN# +1.00110406"},
        {"Smithsonian Astrophysical Observation", "SAO 252001"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.71145906),
        dec: Angle.Degrees(-69.98935885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135739"},
        {"Hipparcos Number", "HIP 75130"},
        {"Geneva Identification System", "GEN# +1.00135739"},
        {"Smithsonian Astrophysical Observation", "SAO 253116"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.28843936),
        dec: Angle.Degrees(-69.98812105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113362"},
        {"Hipparcos Number", "HIP 63813"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.18673335),
        dec: Angle.Degrees(-69.98728725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10576"},
        {"Hipparcos Number", "HIP 7814"},
        {"Geneva Identification System", "GEN# +1.00010576"},
        {"Smithsonian Astrophysical Observation", "SAO 255802"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.13265980),
        dec: Angle.Degrees(-69.98695754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 235.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51211"},
        {"Hipparcos Number", "HIP 32813"},
        {"Geneva Identification System", "GEN# +1.00051211"},
        {"Smithsonian Astrophysical Observation", "SAO 249662"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.60536348),
        dec: Angle.Degrees(-69.98622227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172647"},
        {"Hipparcos Number", "HIP 92192"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.83524405),
        dec: Angle.Degrees(-69.98468724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45669"},
        {"Hipparcos Number", "HIP 30321"},
        {"Geneva Identification System", "GEN# +1.00045669"},
        {"Smithsonian Astrophysical Observation", "SAO 249532"},
        {"Wilson Evans Batten Catalogue", "WEB 6028"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.65929247),
        dec: Angle.Degrees(-69.98412773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158221"},
        {"Hipparcos Number", "HIP 85953"},
        {"Geneva Identification System", "GEN# +1.00158221"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.50652618),
        dec: Angle.Degrees(-69.98289164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95123"},
        {"Hipparcos Number", "HIP 53534"},
        {"Geneva Identification System", "GEN# +1.00095123"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.28835890),
        dec: Angle.Degrees(-69.98062336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183414"},
        {"Hipparcos Number", "HIP 96334"},
        {"Geneva Identification System", "GEN# +1.00183414"},
        {"Wilson Evans Batten Catalogue", "WEB 16891"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.79052534),
        dec: Angle.Degrees(-69.97515380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67559"},
        {"Hipparcos Number", "HIP 39406"},
        {"Smithsonian Astrophysical Observation", "SAO 250098"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.83824204),
        dec: Angle.Degrees(-69.97161661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127597"},
        {"Hipparcos Number", "HIP 71390"},
        {"Smithsonian Astrophysical Observation", "SAO 252806"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.97913853),
        dec: Angle.Degrees(-69.97053142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146132"},
        {"Hipparcos Number", "HIP 80022"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.01882668),
        dec: Angle.Degrees(-69.96335436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223493"},
        {"Hipparcos Number", "HIP 117543"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.56387073),
        dec: Angle.Degrees(-69.96302702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268819"},
        {"Hipparcos Number", "HIP 22900"},
        {"Geneva Identification System", "GEN# +1.00268819"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.88523081),
        dec: Angle.Degrees(-69.96252319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121645"},
        {"Hipparcos Number", "HIP 68355"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.88404609),
        dec: Angle.Degrees(-69.95817565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60228"},
        {"Renson", "Renson 31110"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.25995168),
        dec: Angle.Degrees(-69.95173939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41329"},
    },
    visualMagnitude: 11.46,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.48333785),
        dec: Angle.Degrees(-69.95143183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24697"},
        {"Hipparcos Number", "HIP 17947"},
        {"Smithsonian Astrophysical Observation", "SAO 256036"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.55971765),
        dec: Angle.Degrees(-69.94644813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175167"},
        {"Hipparcos Number", "HIP 93281"},
        {"Geneva Identification System", "GEN# +1.00175167"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.00353366),
        dec: Angle.Degrees(-69.94377402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106910"},
        {"Hipparcos Number", "HIP 59971"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.49197133),
        dec: Angle.Degrees(-69.94297401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114371"},
        {"Hipparcos Number", "HIP 64390"},
        {"Geneva Identification System", "GEN# +1.00114371"},
        {"Smithsonian Astrophysical Observation", "SAO 252185"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.96408969),
        dec: Angle.Degrees(-69.94201974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170466"},
        {"Hipparcos Number", "HIP 91146"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.90539499),
        dec: Angle.Degrees(-69.93888115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160921"},
        {"Hipparcos Number", "HIP 87175"},
        {"Smithsonian Astrophysical Observation", "SAO 254035"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.15930421),
        dec: Angle.Degrees(-69.93104506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96268"},
        {"Hipparcos Number", "HIP 54115"},
        {"Geneva Identification System", "GEN# +1.00096268"},
        {"Smithsonian Astrophysical Observation", "SAO 251248"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.08964592),
        dec: Angle.Degrees(-69.92903009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108930"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.01983996),
        dec: Angle.Degrees(-69.92476985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 625.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109092"},
        {"Hipparcos Number", "HIP 61227"},
        {"Smithsonian Astrophysical Observation", "SAO 251949"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.19501578),
        dec: Angle.Degrees(-69.92430055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17073"},
        {"Hipparcos Number", "HIP 12458"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.10983021),
        dec: Angle.Degrees(-69.91844848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90478"},
        {"Hipparcos Number", "HIP 50942"},
        {"Smithsonian Astrophysical Observation", "SAO 250947"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.05906997),
        dec: Angle.Degrees(-69.91768601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105027"},
        {"Hipparcos Number", "HIP 58974"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.38711151),
        dec: Angle.Degrees(-69.91320084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15639"},
        {"Hipparcos Number", "HIP 11413"},
        {"Smithsonian Astrophysical Observation", "SAO 255887"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.77084352),
        dec: Angle.Degrees(-69.90767968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98195"},
        {"Hipparcos Number", "HIP 55072"},
        {"Geneva Identification System", "GEN# +1.00098195"},
        {"Smithsonian Astrophysical Observation", "SAO 251339"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.12771466),
        dec: Angle.Degrees(-69.90711307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219330"},
        {"Hipparcos Number", "HIP 114879"},
        {"Geneva Identification System", "GEN# +1.00219330"},
        {"Smithsonian Astrophysical Observation", "SAO 258123"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.03895720),
        dec: Angle.Degrees(-69.90455099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200148"},
        {"Hipparcos Number", "HIP 104142"},
        {"Smithsonian Astrophysical Observation", "SAO 257883"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.49452297),
        dec: Angle.Degrees(-69.90450479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40156"},
        {"Hipparcos Number", "HIP 27633"},
        {"Geneva Identification System", "GEN# +1.00040156"},
        {"Smithsonian Astrophysical Observation", "SAO 249378"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.75243839),
        dec: Angle.Degrees(-69.90237049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 270198"},
        {"Hipparcos Number", "HIP 27643"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.77388304),
        dec: Angle.Degrees(-69.90170232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68561"},
        {"Hipparcos Number", "HIP 39791"},
        {"Geneva Identification System", "GEN# +1.00068561"},
        {"Renson", "Renson 19010"},
        {"Smithsonian Astrophysical Observation", "SAO 250130"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.96376538),
        dec: Angle.Degrees(-69.89928963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94433"},
        {"Hipparcos Number", "HIP 53143"},
        {"Smithsonian Astrophysical Observation", "SAO 251158"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.06612678),
        dec: Angle.Degrees(-69.89797586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85649"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.55529556),
        dec: Angle.Degrees(-69.89556718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86216"},
        {"Hipparcos Number", "HIP 48523"},
        {"Renson", "Renson 24650"},
        {"Smithsonian Astrophysical Observation", "SAO 250742"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.44864502),
        dec: Angle.Degrees(-69.89527495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109374"},
        {"Hipparcos Number", "HIP 61392"},
        {"Geneva Identification System", "GEN# +1.00109374"},
        {"Smithsonian Astrophysical Observation", "SAO 251956"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.71050261),
        dec: Angle.Degrees(-69.89162375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61437"},
        {"Hipparcos Number", "HIP 36766"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.42797211),
        dec: Angle.Degrees(-69.89117636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11357"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.56161717),
        dec: Angle.Degrees(-69.48075361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 169.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24394"},
        {"Hipparcos Number", "HIP 17720"},
        {"Smithsonian Astrophysical Observation", "SAO 256027"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.92074750),
        dec: Angle.Degrees(-69.88881017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14706"},
        {"Hipparcos Number", "HIP 10786"},
        {"Smithsonian Astrophysical Observation", "SAO 255871"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.72177773),
        dec: Angle.Degrees(-69.88681637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104191"},
        {"Hipparcos Number", "HIP 58504"},
        {"Geneva Identification System", "GEN# +1.00104191"},
        {"Smithsonian Astrophysical Observation", "SAO 251674"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.97300128),
        dec: Angle.Degrees(-69.88465882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103226"},
        {"Hipparcos Number", "HIP 57928"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.21834367),
        dec: Angle.Degrees(-69.88416767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149486"},
        {"Hipparcos Number", "HIP 81658"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.21115416),
        dec: Angle.Degrees(-69.88339289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90857"},
        {"Hipparcos Number", "HIP 51151"},
        {"Smithsonian Astrophysical Observation", "SAO 250963"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.73480858),
        dec: Angle.Degrees(-69.88267337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11221"},
        {"Hipparcos Number", "HIP 8336"},
        {"Smithsonian Astrophysical Observation", "SAO 255816"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.87764426),
        dec: Angle.Degrees(-69.88223281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98447",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98447"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.04606359),
        dec: Angle.Degrees(-69.88182551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111828"},
        {"Hipparcos Number", "HIP 62865"},
        {"Geneva Identification System", "GEN# +1.00111828"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.27710916),
        dec: Angle.Degrees(-69.88013757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1391"},
        {"Hipparcos Number", "HIP 1404"},
        {"Geneva Identification System", "GEN# +1.00001391"},
        {"Smithsonian Astrophysical Observation", "SAO 255654"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.39394680),
        dec: Angle.Degrees(-69.87844481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134899"},
        {"Hipparcos Number", "HIP 74759"},
        {"Geneva Identification System", "GEN# +1.00134899"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.18751240),
        dec: Angle.Degrees(-69.87773793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124751"},
        {"Hipparcos Number", "HIP 69932"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.66657759),
        dec: Angle.Degrees(-69.87749672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179953"},
        {"Hipparcos Number", "HIP 95037"},
        {"Smithsonian Astrophysical Observation", "SAO 254527"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.06429229),
        dec: Angle.Degrees(-69.87742977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99356"},
        {"Hipparcos Number", "HIP 55720"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.25788361),
        dec: Angle.Degrees(-69.87625024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122419"},
        {"Hipparcos Number", "HIP 68784"},
        {"Geneva Identification System", "GEN# +1.00122419"},
        {"Smithsonian Astrophysical Observation", "SAO 252586"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.18942083),
        dec: Angle.Degrees(-69.87207280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26492"},
        {"Hipparcos Number", "HIP 19128"},
        {"Geneva Identification System", "GEN# +1.00026492"},
        {"Smithsonian Astrophysical Observation", "SAO 256060"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51247971),
        dec: Angle.Degrees(-69.87137959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22599"},
        {"Hipparcos Number", "HIP 16564"},
        {"Smithsonian Astrophysical Observation", "SAO 256000"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.30751193),
        dec: Angle.Degrees(-69.87006667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141877"},
        {"Hipparcos Number", "HIP 78071"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.11165919),
        dec: Angle.Degrees(-69.86547380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68038"},
        {"Hipparcos Number", "HIP 39596"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.37698970),
        dec: Angle.Degrees(-69.86368027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140047"},
        {"Hipparcos Number", "HIP 77264"},
        {"Geneva Identification System", "GEN# +1.00140047"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.61816455),
        dec: Angle.Degrees(-69.86242323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147500"},
        {"Hipparcos Number", "HIP 80638"},
        {"Smithsonian Astrophysical Observation", "SAO 253552"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.97102137),
        dec: Angle.Degrees(-69.86135790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204731"},
        {"Hipparcos Number", "HIP 106506"},
        {"Smithsonian Astrophysical Observation", "SAO 257936"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.58131438),
        dec: Angle.Degrees(-69.86101007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130942"},
        {"Hipparcos Number", "HIP 72983"},
        {"Smithsonian Astrophysical Observation", "SAO 252948"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.72521374),
        dec: Angle.Degrees(-69.86092469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196785"},
        {"Hipparcos Number", "HIP 102345"},
        {"Smithsonian Astrophysical Observation", "SAO 257846"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.05286415),
        dec: Angle.Degrees(-69.85555222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71971"},
        {"Hipparcos Number", "HIP 41281"},
        {"Smithsonian Astrophysical Observation", "SAO 250227"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.32881207),
        dec: Angle.Degrees(-69.85086225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269327"},
        {"Hipparcos Number", "HIP 24694"},
        {"Geneva Identification System", "GEN# +1.00269327"},
    },
    visualMagnitude: 10.75,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.44322532),
        dec: Angle.Degrees(-69.84923159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268835"},
        {"Hipparcos Number", "HIP 22989"},
        {"Geneva Identification System", "GEN# +1.00268835"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.19615144),
        dec: Angle.Degrees(-69.84021424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137552"},
        {"Hipparcos Number", "HIP 76002"},
        {"Geneva Identification System", "GEN# +1.00137552"},
        {"Smithsonian Astrophysical Observation", "SAO 253190"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.82489251),
        dec: Angle.Degrees(-69.83666114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76614"},
        {"Hipparcos Number", "HIP 43604"},
        {"Celescope Catalog", "CEL 3061"},
        {"Geneva Identification System", "GEN# +1.00076614"},
        {"Renson", "Renson 21600"},
        {"Smithsonian Astrophysical Observation", "SAO 250368"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.20461343),
        dec: Angle.Degrees(-69.83063018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176478"},
        {"Hipparcos Number", "HIP 93810"},
        {"Smithsonian Astrophysical Observation", "SAO 254458"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.57734335),
        dec: Angle.Degrees(-69.83005228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173904"},
        {"Hipparcos Number", "HIP 92730"},
        {"Smithsonian Astrophysical Observation", "SAO 254400"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.44099942),
        dec: Angle.Degrees(-69.82975810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63584"},
        {"Hipparcos Number", "HIP 37720"},
        {"Geneva Identification System", "GEN# +1.00063584"},
        {"Smithsonian Astrophysical Observation", "SAO 249943"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.05456897),
        dec: Angle.Degrees(-69.82161624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112321"},
        {"Hipparcos Number", "HIP 63214"},
        {"Smithsonian Astrophysical Observation", "SAO 252102"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.28797267),
        dec: Angle.Degrees(-69.81774227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92047"},
        {"Hipparcos Number", "HIP 51843"},
        {"Smithsonian Astrophysical Observation", "SAO 251029"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.87655710),
        dec: Angle.Degrees(-69.81745667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183811"},
        {"Hipparcos Number", "HIP 96487"},
        {"Geneva Identification System", "GEN# +1.00183811"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.22732934),
        dec: Angle.Degrees(-69.81673501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18036"},
        {"Hipparcos Number", "HIP 13189"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.42778058),
        dec: Angle.Degrees(-69.81177732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204318"},
        {"Hipparcos Number", "HIP 106269"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.87186030),
        dec: Angle.Degrees(-69.81158374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53608"},
        {"Hipparcos Number", "HIP 33680"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.95561821),
        dec: Angle.Degrees(-69.80964619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87285"},
        {"Hipparcos Number", "HIP 49071"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.23052245),
        dec: Angle.Degrees(-69.80684905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80807"},
        {"Hipparcos Number", "HIP 45620"},
        {"Celescope Catalog", "CEL 3266"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.47917885),
        dec: Angle.Degrees(-69.80468837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80807B"},
        {"Hipparcos Number", "HIP 45622"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.48185926),
        dec: Angle.Degrees(-69.80195281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124792"},
        {"Hipparcos Number", "HIP 69946"},
        {"Geneva Identification System", "GEN# +1.00124792"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.70627605),
        dec: Angle.Degrees(-69.79999885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105139"},
        {"Hipparcos Number", "HIP 59043"},
        {"Geneva Identification System", "GEN# +1.00105139"},
        {"Smithsonian Astrophysical Observation", "SAO 251736"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.57669181),
        dec: Angle.Degrees(-69.79826464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95558"},
        {"Hipparcos Number", "HIP 53772"},
        {"Smithsonian Astrophysical Observation", "SAO 251210"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.03713860),
        dec: Angle.Degrees(-69.79818180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142173"},
        {"Hipparcos Number", "HIP 78201"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.53110816),
        dec: Angle.Degrees(-69.79547708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48400"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.01305397),
        dec: Angle.Degrees(-69.79119260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85944"},
        {"Hipparcos Number", "HIP 48395"},
        {"Geneva Identification System", "GEN# +1.00085944"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.99457909),
        dec: Angle.Degrees(-69.78887117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174340"},
        {"Hipparcos Number", "HIP 92923"},
        {"Geneva Identification System", "GEN# +1.00174340"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.98340396),
        dec: Angle.Degrees(-69.78833602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45080"},
        {"Hipparcos Number", "HIP 30038"},
        {"Geneva Identification System", "GEN# +1.00045080"},
        {"Smithsonian Astrophysical Observation", "SAO 249514"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.81332976),
        dec: Angle.Degrees(-69.78471797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20659"},
        {"Hipparcos Number", "HIP 15120"},
        {"Smithsonian Astrophysical Observation", "SAO 248765"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.73953644),
        dec: Angle.Degrees(-69.78275434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215053"},
        {"Hipparcos Number", "HIP 112280"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.13903426),
        dec: Angle.Degrees(-69.77753325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89097"},
        {"Hipparcos Number", "HIP 50118"},
        {"Smithsonian Astrophysical Observation", "SAO 250886"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.47033184),
        dec: Angle.Degrees(-69.77636432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77870"},
        {"Hipparcos Number", "HIP 44255"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.19020162),
        dec: Angle.Degrees(-69.77010030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148236"},
        {"Hipparcos Number", "HIP 80978"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.04883220),
        dec: Angle.Degrees(-69.76555184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102043"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.20032592),
        dec: Angle.Degrees(-69.76269518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43678"},
        {"Hipparcos Number", "HIP 29363"},
        {"Geneva Identification System", "GEN# +1.00043678"},
        {"Smithsonian Astrophysical Observation", "SAO 249474"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.83910764),
        dec: Angle.Degrees(-69.76043712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1164"},
        {"Hipparcos Number", "HIP 1246"},
        {"Smithsonian Astrophysical Observation", "SAO 255648"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.88890687),
        dec: Angle.Degrees(-69.75145198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134806"},
        {"Hipparcos Number", "HIP 74719"},
        {"Smithsonian Astrophysical Observation", "SAO 253074"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.04922383),
        dec: Angle.Degrees(-69.75029255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161094"},
        {"Hipparcos Number", "HIP 87242"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.38644908),
        dec: Angle.Degrees(-69.74837515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89407",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89407"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.68078619),
        dec: Angle.Degrees(-69.74116582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224052"},
        {"Hipparcos Number", "HIP 117908"},
        {"Smithsonian Astrophysical Observation", "SAO 258200"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.74024335),
        dec: Angle.Degrees(-69.73613259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203133"},
        {"Hipparcos Number", "HIP 105678"},
        {"Geneva Identification System", "GEN# +1.00203133"},
        {"Smithsonian Astrophysical Observation", "SAO 254990"},
    },
    visualMagnitude: 6.28,
    bvColour: 2.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.06972656),
        dec: Angle.Degrees(-69.73386384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11301"},
        {"Hipparcos Number", "HIP 8388"},
        {"Smithsonian Astrophysical Observation", "SAO 248439"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.04717650),
        dec: Angle.Degrees(-69.72925263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110041"},
        {"Hipparcos Number", "HIP 61829"},
        {"Celescope Catalog", "CEL 4138"},
        {"Geneva Identification System", "GEN# +1.00110041"},
        {"Smithsonian Astrophysical Observation", "SAO 251988"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.06684647),
        dec: Angle.Degrees(-69.72918387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199231"},
        {"Hipparcos Number", "HIP 103664"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.05762941),
        dec: Angle.Degrees(-69.72753801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27693"},
        {"Hipparcos Number", "HIP 19957"},
        {"Geneva Identification System", "GEN# +1.00027693"},
        {"Smithsonian Astrophysical Observation", "SAO 248983"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.19266968),
        dec: Angle.Degrees(-69.72686806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3787"},
        {"Hipparcos Number", "HIP 3103"},
        {"Renson", "Renson 1030"},
        {"Smithsonian Astrophysical Observation", "SAO 248231"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.88411127),
        dec: Angle.Degrees(-69.72467388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113956"},
        {"Hipparcos Number", "HIP 64145"},
        {"Smithsonian Astrophysical Observation", "SAO 252166"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.19769823),
        dec: Angle.Degrees(-69.72328908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146412"},
        {"Hipparcos Number", "HIP 80144"},
        {"Fundamental Katalog 5th Edition", "FK5 5441"},
        {"Geneva Identification System", "GEN# +1.00146412"},
        {"Smithsonian Astrophysical Observation", "SAO 253508"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.37616159),
        dec: Angle.Degrees(-69.72280134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123492"},
        {"Hipparcos Number", "HIP 69298"},
        {"Geneva Identification System", "GEN# +1.00123492"},
        {"Smithsonian Astrophysical Observation", "SAO 252636"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.75805146),
        dec: Angle.Degrees(-69.71926784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13219"},
        {"Hipparcos Number", "HIP 9793"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.48449701),
        dec: Angle.Degrees(-69.71884605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8519"},
        {"Hipparcos Number", "HIP 6377"},
        {"Geneva Identification System", "GEN# +1.00008519J"},
        {"Smithsonian Astrophysical Observation", "SAO 248370"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.49438626),
        dec: Angle.Degrees(-69.71877898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45238",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Miaplacidus"},
        {"Henry Draper", "HD 80007"},
        {"Hipparcos Number", "HIP 45238"},
        {"Celescope Catalog", "CEL 3237"},
        {"Fundamental Katalog 5th Edition", "FK5 348"},
        {"Geneva Identification System", "GEN# +1.00080007"},
        {"Smithsonian Astrophysical Observation", "SAO 250495"},
        {"Wilson Evans Batten Catalogue", "WEB 8622"},
    },
    visualMagnitude: 1.67,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.30100329),
        dec: Angle.Degrees(-69.71747245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42288"},
        {"Hipparcos Number", "HIP 28703"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.94087495),
        dec: Angle.Degrees(-69.71025766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131741"},
        {"Hipparcos Number", "HIP 73348"},
        {"Geneva Identification System", "GEN# +1.00131741"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.84474146),
        dec: Angle.Degrees(-69.70721569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49359"},
        {"Hipparcos Number", "HIP 32073"},
        {"Smithsonian Astrophysical Observation", "SAO 249630"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.52034133),
        dec: Angle.Degrees(-69.70658361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212523"},
        {"Hipparcos Number", "HIP 110830"},
        {"Smithsonian Astrophysical Observation", "SAO 255219"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.80875374),
        dec: Angle.Degrees(-69.70483166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88797"},
        {"Hipparcos Number", "HIP 49935"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.94337175),
        dec: Angle.Degrees(-69.70189908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19038"},
        {"Hipparcos Number", "HIP 13931"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.87526650),
        dec: Angle.Degrees(-69.69696747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83253"},
        {"Hipparcos Number", "HIP 46902"},
        {"Renson", "Renson 23740"},
        {"Smithsonian Astrophysical Observation", "SAO 250624"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.36839366),
        dec: Angle.Degrees(-69.69149740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46116"},
        {"Hipparcos Number", "HIP 30565"},
        {"Fundamental Katalog 5th Edition", "FK5 2495"},
        {"Geneva Identification System", "GEN# +1.00046116"},
        {"Smithsonian Astrophysical Observation", "SAO 249550"},
        {"Wilson Evans Batten Catalogue", "WEB 6095"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.36937934),
        dec: Angle.Degrees(-69.69078672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 200.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197699"},
        {"Hipparcos Number", "HIP 102826"},
        {"Smithsonian Astrophysical Observation", "SAO 254873"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.47010381),
        dec: Angle.Degrees(-69.68935491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210399"},
        {"Hipparcos Number", "HIP 109674"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.25312198),
        dec: Angle.Degrees(-69.68549858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39980"},
        {"Hipparcos Number", "HIP 27546"},
        {"Smithsonian Astrophysical Observation", "SAO 249372"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.49678095),
        dec: Angle.Degrees(-69.68499936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19299"},
        {"Hipparcos Number", "HIP 14102"},
        {"Fundamental Katalog 5th Edition", "FK5 4278"},
        {"Smithsonian Astrophysical Observation", "SAO 248711"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.46557118),
        dec: Angle.Degrees(-69.68398519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217421"},
        {"Hipparcos Number", "HIP 113749"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.54688894),
        dec: Angle.Degrees(-69.68169214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115671"},
        {"Hipparcos Number", "HIP 65113"},
        {"Geneva Identification System", "GEN# +1.00115671"},
        {"Smithsonian Astrophysical Observation", "SAO 252271"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.16053933),
        dec: Angle.Degrees(-69.68053848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26218"},
    },
    visualMagnitude: 13.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.80915722),
        dec: Angle.Degrees(-69.67980172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114912"},
        {"Hipparcos Number", "HIP 64682"},
        {"Geneva Identification System", "GEN# +1.00114912"},
        {"Smithsonian Astrophysical Observation", "SAO 252225"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.85735777),
        dec: Angle.Degrees(-69.67919729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37836"},
        {"Hipparcos Number", "HIP 26222"},
        {"Geneva Identification System", "GEN# +1.00037836"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.81929196),
        dec: Angle.Degrees(-69.67734537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224789"},
        {"Hipparcos Number", "HIP 57"},
        {"Geneva Identification System", "GEN# +1.00224789"},
        {"Smithsonian Astrophysical Observation", "SAO 255621"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.16828557),
        dec: Angle.Degrees(-69.67580068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101088"},
        {"Hipparcos Number", "HIP 56673"},
        {"Geneva Identification System", "GEN# +1.00101088"},
        {"Smithsonian Astrophysical Observation", "SAO 251489"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.31131841),
        dec: Angle.Degrees(-69.67421809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129060"},
        {"Hipparcos Number", "HIP 72048"},
        {"Geneva Identification System", "GEN# +1.00129060"},
        {"Smithsonian Astrophysical Observation", "SAO 252862"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.05951017),
        dec: Angle.Degrees(-69.67389796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101531"},
        {"Hipparcos Number", "HIP 56937"},
        {"Fundamental Katalog 5th Edition", "FK5 5030"},
        {"Smithsonian Astrophysical Observation", "SAO 251529"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.08537306),
        dec: Angle.Degrees(-69.67170442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94911"},
        {"Hipparcos Number", "HIP 53421"},
        {"Smithsonian Astrophysical Observation", "SAO 251182"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.92308729),
        dec: Angle.Degrees(-69.66575038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74183"},
        {"Hipparcos Number", "HIP 42329"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.45442203),
        dec: Angle.Degrees(-69.66421630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103259"},
        {"Hipparcos Number", "HIP 57956"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.30433751),
        dec: Angle.Degrees(-69.66339144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224569"},
        {"Hipparcos Number", "HIP 118244"},
        {"Smithsonian Astrophysical Observation", "SAO 255616"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.75651275),
        dec: Angle.Degrees(-69.65432124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153646"},
        {"Hipparcos Number", "HIP 83697"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.59089414),
        dec: Angle.Degrees(-69.65415712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211770"},
        {"Hipparcos Number", "HIP 110430"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.51177690),
        dec: Angle.Degrees(-69.65327268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66010"},
        {"Hipparcos Number", "HIP 38782"},
        {"Geneva Identification System", "GEN# +1.00066010"},
        {"Smithsonian Astrophysical Observation", "SAO 250026"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.06866411),
        dec: Angle.Degrees(-69.64648908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 169.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111558"},
        {"Hipparcos Number", "HIP 62722"},
        {"Geneva Identification System", "GEN# +1.00111558"},
        {"Wilson Evans Batten Catalogue", "WEB 11122"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.79990221),
        dec: Angle.Degrees(-69.64520631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36788"},
    },
    visualMagnitude: 11.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.49510644),
        dec: Angle.Degrees(-69.64115158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138732"},
        {"Hipparcos Number", "HIP 76595"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.64969903),
        dec: Angle.Degrees(-69.63901105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82006"},
        {"Hipparcos Number", "HIP 46233"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.39014440),
        dec: Angle.Degrees(-69.63707409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89266"},
        {"Hipparcos Number", "HIP 50231"},
        {"Geneva Identification System", "GEN# +1.00089266"},
        {"Smithsonian Astrophysical Observation", "SAO 250897"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.81406369),
        dec: Angle.Degrees(-69.63663055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181958"},
        {"Hipparcos Number", "HIP 95718"},
        {"Geneva Identification System", "GEN# +1.00181958"},
        {"Smithsonian Astrophysical Observation", "SAO 254578"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.02718657),
        dec: Angle.Degrees(-69.63203953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205348"},
        {"Hipparcos Number", "HIP 106834"},
        {"Geneva Identification System", "GEN# +1.00205348"},
        {"Smithsonian Astrophysical Observation", "SAO 255038"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.57070170),
        dec: Angle.Degrees(-69.63011948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207241"},
        {"Hipparcos Number", "HIP 107835"},
        {"Fundamental Katalog 5th Edition", "FK5 820"},
        {"Geneva Identification System", "GEN# +1.00207241"},
        {"Smithsonian Astrophysical Observation", "SAO 255087"},
        {"Wilson Evans Batten Catalogue", "WEB 19444"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.69677354),
        dec: Angle.Degrees(-69.62940458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116890"},
        {"Hipparcos Number", "HIP 65755"},
        {"Geneva Identification System", "GEN# +1.00116890"},
        {"Renson", "Renson 33720"},
        {"Smithsonian Astrophysical Observation", "SAO 252321"},
        {"Wilson Evans Batten Catalogue", "WEB 11637"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.19510174),
        dec: Angle.Degrees(-69.62711260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1685"},
        {"Hipparcos Number", "HIP 1647"},
        {"Fundamental Katalog 5th Edition", "FK5 2018"},
        {"Geneva Identification System", "GEN# +1.00001685"},
        {"Smithsonian Astrophysical Observation", "SAO 248167"},
        {"Wilson Evans Batten Catalogue", "WEB 301"},
    },
    visualMagnitude: 5.50,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.16267858),
        dec: Angle.Degrees(-69.62491154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21563"},
        {"Hipparcos Number", "HIP 15840"},
        {"Geneva Identification System", "GEN# +1.00021563"},
        {"Smithsonian Astrophysical Observation", "SAO 248797"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.00948316),
        dec: Angle.Degrees(-69.62465075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70049"},
        {"Hipparcos Number", "HIP 40396"},
        {"Smithsonian Astrophysical Observation", "SAO 250167"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.71050350),
        dec: Angle.Degrees(-69.62266798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84295"},
        {"Hipparcos Number", "HIP 47489"},
        {"Geneva Identification System", "GEN# +1.00084295"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.20450187),
        dec: Angle.Degrees(-69.62014316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144702"},
        {"Hipparcos Number", "HIP 79402"},
        {"Smithsonian Astrophysical Observation", "SAO 253453"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.07376967),
        dec: Angle.Degrees(-69.61959505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129330"},
        {"Hipparcos Number", "HIP 72171"},
        {"Geneva Identification System", "GEN# +1.00129330"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.43323523),
        dec: Angle.Degrees(-69.61923560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156337"},
        {"Hipparcos Number", "HIP 85040"},
        {"Smithsonian Astrophysical Observation", "SAO 253885"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.71181427),
        dec: Angle.Degrees(-69.61882838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28201"},
        {"Hipparcos Number", "HIP 20339"},
        {"Geneva Identification System", "GEN# +1.00028201"},
        {"Smithsonian Astrophysical Observation", "SAO 249010"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.36119456),
        dec: Angle.Degrees(-69.61574246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29079"},
        {"Hipparcos Number", "HIP 20920"},
        {"Geneva Identification System", "GEN# +1.00029079"},
        {"Smithsonian Astrophysical Observation", "SAO 249041"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.26848116),
        dec: Angle.Degrees(-69.61221792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195402"},
        {"Hipparcos Number", "HIP 101626"},
        {"Geneva Identification System", "GEN# +1.00195402"},
        {"Smithsonian Astrophysical Observation", "SAO 254820"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.96528696),
        dec: Angle.Degrees(-69.61047763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91202"},
        {"Hipparcos Number", "HIP 51359"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.35656115),
        dec: Angle.Degrees(-69.60966909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16205"},
        {"Hipparcos Number", "HIP 11819"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.10565162),
        dec: Angle.Degrees(-69.60526016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109761"},
        {"Hipparcos Number", "HIP 61635"},
        {"Fundamental Katalog 5th Edition", "FK5 5113"},
        {"Geneva Identification System", "GEN# +1.00109761"},
        {"Smithsonian Astrophysical Observation", "SAO 251977"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.50557132),
        dec: Angle.Degrees(-69.60313949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184359"},
        {"Hipparcos Number", "HIP 96708"},
        {"Smithsonian Astrophysical Observation", "SAO 254619"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.89472366),
        dec: Angle.Degrees(-69.60243212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166925"},
        {"Hipparcos Number", "HIP 89737"},
        {"Smithsonian Astrophysical Observation", "SAO 254198"},
    },
    visualMagnitude: 8.05,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.69508308),
        dec: Angle.Degrees(-69.59891008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113433"},
        {"Hipparcos Number", "HIP 63858"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.31007812),
        dec: Angle.Degrees(-69.59638430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143450"},
        {"Hipparcos Number", "HIP 78824"},
        {"Smithsonian Astrophysical Observation", "SAO 253412"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.36642817),
        dec: Angle.Degrees(-69.59580592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36436"},
        {"Hipparcos Number", "HIP 25369"},
        {"Smithsonian Astrophysical Observation", "SAO 249273"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.41017980),
        dec: Angle.Degrees(-69.59551844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144106"},
        {"Hipparcos Number", "HIP 79145"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.31242924),
        dec: Angle.Degrees(-69.58985743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122078"},
        {"Hipparcos Number", "HIP 68586"},
        {"Geneva Identification System", "GEN# +1.00122078"},
        {"Smithsonian Astrophysical Observation", "SAO 252567"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.60893015),
        dec: Angle.Degrees(-69.58951398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127126"},
        {"Hipparcos Number", "HIP 71155"},
        {"Geneva Identification System", "GEN# +1.00127126"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.29684279),
        dec: Angle.Degrees(-69.58814949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199190"},
        {"Hipparcos Number", "HIP 103654"},
        {"Cincinnati Publication", "Ci 20 1244"},
        {"Geneva Identification System", "GEN# +1.00199190"},
        {"Smithsonian Astrophysical Observation", "SAO 254915"},
        {"Wilson Evans Batten Catalogue", "WEB 18860"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.02098891),
        dec: Angle.Degrees(-69.57874959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 453.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -282.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121574"},
        {"Hipparcos Number", "HIP 68320"},
        {"Geneva Identification System", "GEN# +1.00121574"},
        {"Smithsonian Astrophysical Observation", "SAO 252537"},
        {"Wilson Evans Batten Catalogue", "WEB 11987"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.78820968),
        dec: Angle.Degrees(-69.57697245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59946"},
        {"Hipparcos Number", "HIP 36138"},
        {"Smithsonian Astrophysical Observation", "SAO 249856"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.66270364),
        dec: Angle.Degrees(-69.57646246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78763"},
        {"Hipparcos Number", "HIP 44650"},
        {"Celescope Catalog", "CEL 3190"},
        {"Geneva Identification System", "GEN# +1.00078763"},
        {"Smithsonian Astrophysical Observation", "SAO 250442"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.46927297),
        dec: Angle.Degrees(-69.57521830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105056"},
        {"Hipparcos Number", "HIP 58998"},
        {"Geneva Identification System", "GEN# +1.00105056"},
        {"Smithsonian Astrophysical Observation", "SAO 251733"},
        {"Wilson Evans Batten Catalogue", "WEB 10507"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.45786118),
        dec: Angle.Degrees(-69.57304930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10799"},
        {"Hipparcos Number", "HIP 8029"},
        {"Smithsonian Astrophysical Observation", "SAO 248426"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.77329448),
        dec: Angle.Degrees(-69.57251858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141504"},
        {"Hipparcos Number", "HIP 77892"},
        {"Geneva Identification System", "GEN# +1.00141504"},
        {"Smithsonian Astrophysical Observation", "SAO 253333"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.60405474),
        dec: Angle.Degrees(-69.56970145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7042"},
        {"Hipparcos Number", "HIP 5386"},
        {"Smithsonian Astrophysical Observation", "SAO 248328"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.23193794),
        dec: Angle.Degrees(-69.56638187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160860"},
        {"Hipparcos Number", "HIP 87131"},
        {"Smithsonian Astrophysical Observation", "SAO 254028"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.03742491),
        dec: Angle.Degrees(-69.56013794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189839"},
        {"Hipparcos Number", "HIP 99104"},
        {"Smithsonian Astrophysical Observation", "SAO 254725"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.80759772),
        dec: Angle.Degrees(-69.55545014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115001"},
        {"Hipparcos Number", "HIP 64730"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.01215178),
        dec: Angle.Degrees(-69.55057680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34437"},
        {"Hipparcos Number", "HIP 24173"},
        {"Smithsonian Astrophysical Observation", "SAO 249217"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.86740548),
        dec: Angle.Degrees(-69.54601930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110450"},
        {"Hipparcos Number", "HIP 62055"},
        {"Geneva Identification System", "GEN# +1.00110450"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.78145314),
        dec: Angle.Degrees(-69.54561405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27444"},
        {"Hipparcos Number", "HIP 19776"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.59744861),
        dec: Angle.Degrees(-69.54512198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210098"},
        {"Hipparcos Number", "HIP 109483"},
        {"Smithsonian Astrophysical Observation", "SAO 255161"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.69501715),
        dec: Angle.Degrees(-69.54328776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37120"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.41695950),
        dec: Angle.Degrees(-69.54235047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2493"},
        {"Hipparcos Number", "HIP 2214"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.00171793),
        dec: Angle.Degrees(-69.54224064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109892"},
        {"Hipparcos Number", "HIP 61737"},
        {"Celescope Catalog", "CEL 4136"},
        {"Geneva Identification System", "GEN# +1.00109892"},
        {"Smithsonian Astrophysical Observation", "SAO 251983"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.81036573),
        dec: Angle.Degrees(-69.54199701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187188"},
        {"Hipparcos Number", "HIP 97926"},
        {"Smithsonian Astrophysical Observation", "SAO 254675"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.51690368),
        dec: Angle.Degrees(-69.54137352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269216"},
        {"Hipparcos Number", "HIP 24347"},
        {"Geneva Identification System", "GEN# +1.00269216"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.37823715),
        dec: Angle.Degrees(-69.53990311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130635"},
        {"Hipparcos Number", "HIP 72832"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.30095727),
        dec: Angle.Degrees(-69.53816219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92507"},
        {"Hipparcos Number", "HIP 52094"},
        {"Geneva Identification System", "GEN# +1.00092507"},
        {"Renson", "Renson 26680"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.66691432),
        dec: Angle.Degrees(-69.53548059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82322"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.31169780),
        dec: Angle.Degrees(-69.53294748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138681"},
        {"Hipparcos Number", "HIP 76564"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.55604193),
        dec: Angle.Degrees(-69.53169317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97900"},
        {"Hipparcos Number", "HIP 54897"},
        {"Smithsonian Astrophysical Observation", "SAO 251330"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.60449607),
        dec: Angle.Degrees(-69.53117744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215408"},
        {"Hipparcos Number", "HIP 112468"},
        {"Smithsonian Astrophysical Observation", "SAO 255312"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.72208436),
        dec: Angle.Degrees(-69.52764740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5457"},
        {"Hipparcos Number", "HIP 4293"},
        {"Fundamental Katalog 5th Edition", "FK5 34"},
        {"Geneva Identification System", "GEN# +1.00005457"},
        {"Smithsonian Astrophysical Observation", "SAO 248281"},
        {"Wilson Evans Batten Catalogue", "WEB 772"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.75124739),
        dec: Angle.Degrees(-69.52697888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25505"},
        {"Hipparcos Number", "HIP 18530"},
        {"Geneva Identification System", "GEN# +1.00025505"},
        {"Smithsonian Astrophysical Observation", "SAO 248916"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.44533860),
        dec: Angle.Degrees(-69.52566871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14182"},
        {"Hipparcos Number", "HIP 10431"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.59490533),
        dec: Angle.Degrees(-69.48706073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 269661"},
        {"Hipparcos Number", "HIP 25822"},
        {"Geneva Identification System", "GEN# +1.00269661"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.70866058),
        dec: Angle.Degrees(-69.52483500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15701"},
        {"Hipparcos Number", "HIP 11455"},
        {"Smithsonian Astrophysical Observation", "SAO 248570"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.94525039),
        dec: Angle.Degrees(-69.52406944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96903"},
        {"Hipparcos Number", "HIP 54410"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.00735046),
        dec: Angle.Degrees(-69.52274611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104811"},
        {"Henry Draper 2", "HD 104812"},
        {"Hipparcos Number", "HIP 58848"},
        {"Geneva Identification System", "GEN# +1.00104812"},
        {"Smithsonian Astrophysical Observation", "SAO 251716"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.03739679),
        dec: Angle.Degrees(-69.52197291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196303"},
        {"Hipparcos Number", "HIP 102071"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.27904043),
        dec: Angle.Degrees(-69.52121968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11915"},
        {"Hipparcos Number", "HIP 8869"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.53381077),
        dec: Angle.Degrees(-69.51679862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63583"},
        {"Hipparcos Number", "HIP 37735"},
        {"Geneva Identification System", "GEN# +1.00063583"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.08603096),
        dec: Angle.Degrees(-69.51123856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168599"},
        {"Hipparcos Number", "HIP 90374"},
        {"Smithsonian Astrophysical Observation", "SAO 254238"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.61458621),
        dec: Angle.Degrees(-69.50924203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
