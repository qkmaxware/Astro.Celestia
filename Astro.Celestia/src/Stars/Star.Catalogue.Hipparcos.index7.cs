using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_7() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30611"},
        {"Hipparcos Number", "HIP 22071"},
        {"Smithsonian Astrophysical Observation", "SAO 249093"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.21279026),
        dec: Angle.Degrees(-63.77938946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143058"},
        {"Hipparcos Number", "HIP 78531"},
        {"Geneva Identification System", "GEN# +1.00143058"},
        {"Smithsonian Astrophysical Observation", "SAO 253381"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.48675530),
        dec: Angle.Degrees(-63.77818911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34002"},
        {"Hipparcos Number", "HIP 24004"},
        {"Geneva Identification System", "GEN# +1.00034002"},
        {"Smithsonian Astrophysical Observation", "SAO 249205"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.40547523),
        dec: Angle.Degrees(-63.77759831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142941"},
        {"Hipparcos Number", "HIP 78476"},
        {"Geneva Identification System", "GEN# +1.00142941"},
        {"Smithsonian Astrophysical Observation", "SAO 253377"},
        {"Wilson Evans Batten Catalogue", "WEB 13269"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.29466406),
        dec: Angle.Degrees(-63.77652924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80459"},
        {"Hipparcos Number", "HIP 45541"},
        {"Celescope Catalog", "CEL 3258"},
        {"Geneva Identification System", "GEN# +1.00080459"},
        {"Smithsonian Astrophysical Observation", "SAO 250521"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.23175729),
        dec: Angle.Degrees(-63.77515562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115718"},
        {"Hipparcos Number", "HIP 65084"},
        {"Geneva Identification System", "GEN# +1.00115718"},
        {"Smithsonian Astrophysical Observation", "SAO 252272"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.10388153),
        dec: Angle.Degrees(-63.77478138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5740"},
        {"Hipparcos Number", "HIP 4509"},
        {"Geneva Identification System", "GEN# +1.00005740"},
        {"Smithsonian Astrophysical Observation", "SAO 248290"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.45763059),
        dec: Angle.Degrees(-63.77417538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65192"},
        {"Hipparcos Number", "HIP 38542"},
        {"Smithsonian Astrophysical Observation", "SAO 249999"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.38844211),
        dec: Angle.Degrees(-63.76989312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159135"},
        {"Hipparcos Number", "HIP 86233"},
        {"Smithsonian Astrophysical Observation", "SAO 253981"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.33680517),
        dec: Angle.Degrees(-63.76878232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216316"},
        {"Hipparcos Number", "HIP 113019"},
        {"Geneva Identification System", "GEN# +1.00216316"},
        {"Smithsonian Astrophysical Observation", "SAO 255345"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.31673434),
        dec: Angle.Degrees(-63.76483137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140886"},
        {"Hipparcos Number", "HIP 77526"},
        {"Smithsonian Astrophysical Observation", "SAO 253308"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.44310373),
        dec: Angle.Degrees(-63.76472230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89275"},
        {"Hipparcos Number", "HIP 50277"},
        {"Celescope Catalog", "CEL 3487"},
        {"Geneva Identification System", "GEN# +1.00089275"},
        {"Smithsonian Astrophysical Observation", "SAO 250900"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.98319985),
        dec: Angle.Degrees(-63.76410404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159946"},
        {"Hipparcos Number", "HIP 86600"},
        {"Smithsonian Astrophysical Observation", "SAO 254001"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.45838156),
        dec: Angle.Degrees(-63.76266156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55546"},
        {"Hipparcos Number", "HIP 34509"},
        {"Smithsonian Astrophysical Observation", "SAO 249752"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.25766096),
        dec: Angle.Degrees(-63.76133671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7457"},
        {"Hipparcos Number", "HIP 5692"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.31053619),
        dec: Angle.Degrees(-63.76047291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115602"},
        {"Hipparcos Number", "HIP 65010"},
        {"Smithsonian Astrophysical Observation", "SAO 252261"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.88781897),
        dec: Angle.Degrees(-63.75544454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4878"},
        {"Hipparcos Number", "HIP 3878"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.44995041),
        dec: Angle.Degrees(-63.75275824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41904"},
        {"Hipparcos Number", "HIP 28669"},
        {"Smithsonian Astrophysical Observation", "SAO 249431"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.79390689),
        dec: Angle.Degrees(-63.75143088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176729"},
        {"Hipparcos Number", "HIP 93784"},
        {"Smithsonian Astrophysical Observation", "SAO 254460"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.49092407),
        dec: Angle.Degrees(-63.74474297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107584",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107584"},
        {"Geneva Identification System", "GEN# -0.06404166"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.84926749),
        dec: Angle.Degrees(-63.74464526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 289.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88579"},
        {"Smithsonian Astrophysical Observation", "SAO 254130"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.29117322),
        dec: Angle.Degrees(-63.74224264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71425"},
        {"Hipparcos Number", "HIP 41144"},
        {"Smithsonian Astrophysical Observation", "SAO 250214"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.91892216),
        dec: Angle.Degrees(-63.73232599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41515"},
        {"Hipparcos Number", "HIP 28507"},
        {"Smithsonian Astrophysical Observation", "SAO 249422"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.27259321),
        dec: Angle.Degrees(-63.73002989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23931"},
        {"Hipparcos Number", "HIP 17524"},
        {"Geneva Identification System", "GEN# +1.00023931"},
        {"Smithsonian Astrophysical Observation", "SAO 248881"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.28391630),
        dec: Angle.Degrees(-63.72909275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197848"},
        {"Hipparcos Number", "HIP 102798"},
        {"Smithsonian Astrophysical Observation", "SAO 254874"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.39543893),
        dec: Angle.Degrees(-63.72882308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15222"},
        {"Hipparcos Number", "HIP 11224"},
        {"Smithsonian Astrophysical Observation", "SAO 248552"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.11610149),
        dec: Angle.Degrees(-63.72777132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48018"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.82967417),
        dec: Angle.Degrees(-63.72065264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 199.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64016"},
        {"Hipparcos Number", "HIP 38034"},
        {"Smithsonian Astrophysical Observation", "SAO 249967"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.92975357),
        dec: Angle.Degrees(-63.71911547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215769"},
        {"Hipparcos Number", "HIP 112655"},
        {"Geneva Identification System", "GEN# +1.00215769"},
        {"Smithsonian Astrophysical Observation", "SAO 255324"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.23031121),
        dec: Angle.Degrees(-63.71841605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81700"},
        {"Hipparcos Number", "HIP 46126"},
        {"Geneva Identification System", "GEN# +1.00081700"},
        {"Smithsonian Astrophysical Observation", "SAO 250565"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.09516805),
        dec: Angle.Degrees(-63.71817026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118969"},
        {"Hipparcos Number", "HIP 66859"},
        {"Smithsonian Astrophysical Observation", "SAO 252418"},
        {"Wilson Evans Batten Catalogue", "WEB 11787"},
    },
    visualMagnitude: 9.99,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.55144139),
        dec: Angle.Degrees(-63.71405689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65951"},
        {"Hipparcos Number", "HIP 38880"},
        {"Geneva Identification System", "GEN# +1.00065951"},
        {"Smithsonian Astrophysical Observation", "SAO 250033"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.33978544),
        dec: Angle.Degrees(-63.71221686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106803"},
        {"Geneva Identification System", "GEN# +6.20145085"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.48288667),
        dec: Angle.Degrees(-63.71168532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125881"},
        {"Hipparcos Number", "HIP 70459"},
        {"Geneva Identification System", "GEN# +1.00125881"},
        {"Smithsonian Astrophysical Observation", "SAO 252736"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19298028),
        dec: Angle.Degrees(-63.70621965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17504"},
        {"Hipparcos Number", "HIP 12871"},
        {"Geneva Identification System", "GEN# +1.00017504"},
        {"Smithsonian Astrophysical Observation", "SAO 248642"},
        {"Wilson Evans Batten Catalogue", "WEB 2616"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.36438582),
        dec: Angle.Degrees(-63.70453152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77186"},
        {"Hipparcos Number", "HIP 44009"},
        {"Geneva Identification System", "GEN# +1.00077186"},
        {"Smithsonian Astrophysical Observation", "SAO 250400"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.42430615),
        dec: Angle.Degrees(-63.70394383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103574"},
        {"Hipparcos Number", "HIP 58128"},
        {"Celescope Catalog", "CEL 4015"},
        {"Geneva Identification System", "GEN# +1.00103574"},
        {"Smithsonian Astrophysical Observation", "SAO 251643"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.84031706),
        dec: Angle.Degrees(-63.70354674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124910"},
        {"Hipparcos Number", "HIP 69934"},
        {"Smithsonian Astrophysical Observation", "SAO 252696"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.67543735),
        dec: Angle.Degrees(-63.70337787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76748"},
        {"Hipparcos Number", "HIP 43760"},
        {"Geneva Identification System", "GEN# +1.00076748"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.71421610),
        dec: Angle.Degrees(-63.70166012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212702"},
        {"Hipparcos Number", "HIP 110890"},
        {"Smithsonian Astrophysical Observation", "SAO 255225"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.99664245),
        dec: Angle.Degrees(-63.69907316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30310"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.61907901),
        dec: Angle.Degrees(-63.69821940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 262.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5068"},
        {"Hipparcos Number", "HIP 4015"},
        {"Smithsonian Astrophysical Observation", "SAO 248267"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.87032195),
        dec: Angle.Degrees(-63.69767460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124925"},
        {"Hipparcos Number", "HIP 69941"},
        {"Geneva Identification System", "GEN# +1.00124925"},
        {"Smithsonian Astrophysical Observation", "SAO 252697"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.69263325),
        dec: Angle.Degrees(-63.69564512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3222"},
        {"Hipparcos Number", "HIP 2743"},
        {"Geneva Identification System", "GEN# +1.00003222"},
        {"Smithsonian Astrophysical Observation", "SAO 248215"},
        {"Wilson Evans Batten Catalogue", "WEB 492"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.75687799),
        dec: Angle.Degrees(-63.69382810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 881.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -534.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79985"},
        {"Hipparcos Number", "HIP 45320"},
        {"Geneva Identification System", "GEN# +1.00079985"},
        {"Smithsonian Astrophysical Observation", "SAO 250501"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.54445911),
        dec: Angle.Degrees(-63.69327265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92568"},
        {"Hipparcos Number", "HIP 52178"},
        {"Geneva Identification System", "GEN# +3.26020023"},
        {"Renson", "Renson 26710"},
        {"Smithsonian Astrophysical Observation", "SAO 251055"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.89817051),
        dec: Angle.Degrees(-63.69277557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38116"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.16376454),
        dec: Angle.Degrees(-63.69170006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166251"},
        {"Hipparcos Number", "HIP 89370"},
        {"Geneva Identification System", "GEN# +1.00166251"},
        {"Smithsonian Astrophysical Observation", "SAO 254179"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.56814899),
        dec: Angle.Degrees(-63.68954100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64186"},
        {"Hipparcos Number", "HIP 38114"},
        {"Smithsonian Astrophysical Observation", "SAO 249972"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.16088244),
        dec: Angle.Degrees(-63.68889973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212608"},
        {"Hipparcos Number", "HIP 110839"},
        {"Smithsonian Astrophysical Observation", "SAO 255223"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.83526922),
        dec: Angle.Degrees(-63.68791050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201868"},
        {"Hipparcos Number", "HIP 104932"},
        {"Smithsonian Astrophysical Observation", "SAO 254961"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.83419272),
        dec: Angle.Degrees(-63.68772529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115363"},
        {"Hipparcos Number", "HIP 64896"},
        {"Geneva Identification System", "GEN# +1.00115363"},
        {"Smithsonian Astrophysical Observation", "SAO 252250"},
        {"Wilson Evans Batten Catalogue", "WEB 11470"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.52865160),
        dec: Angle.Degrees(-63.68711726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132539J"},
        {"Hipparcos Number", "HIP 73609"},
        {"Smithsonian Astrophysical Observation", "SAO 252997"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.68729789),
        dec: Angle.Degrees(-63.68678400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114427"},
        {"Geneva Identification System", "GEN# +6.20145126"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.60729982),
        dec: Angle.Degrees(-63.68661819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 500.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121474"},
        {"Hipparcos Number", "HIP 68191"},
        {"Fundamental Katalog 5th Edition", "FK5 514"},
        {"Geneva Identification System", "GEN# +1.00121474"},
        {"Smithsonian Astrophysical Observation", "SAO 252531"},
        {"Wilson Evans Batten Catalogue", "WEB 11964"},
    },
    visualMagnitude: 4.71,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.41223681),
        dec: Angle.Degrees(-63.68661603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145544"},
        {"Hipparcos Number", "HIP 79664"},
        {"Fundamental Katalog 5th Edition", "FK5 602"},
        {"Geneva Identification System", "GEN# +1.00145544"},
        {"Smithsonian Astrophysical Observation", "SAO 253474"},
        {"Wilson Evans Batten Catalogue", "WEB 13480"},
    },
    visualMagnitude: 3.86,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.85944228),
        dec: Angle.Degrees(-63.68564897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154902"},
        {"Hipparcos Number", "HIP 84188"},
        {"Smithsonian Astrophysical Observation", "SAO 253826"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.14290781),
        dec: Angle.Degrees(-63.68536642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201188"},
        {"Hipparcos Number", "HIP 104580"},
        {"Smithsonian Astrophysical Observation", "SAO 254949"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.76617712),
        dec: Angle.Degrees(-63.68482205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45461"},
        {"Hipparcos Number", "HIP 30352"},
        {"Geneva Identification System", "GEN# +1.00045461"},
        {"Smithsonian Astrophysical Observation", "SAO 249531"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.75615393),
        dec: Angle.Degrees(-63.68317619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101085"},
        {"Hipparcos Number", "HIP 56692"},
        {"Celescope Catalog", "CEL 3929"},
        {"Geneva Identification System", "GEN# +1.00101085"},
        {"Smithsonian Astrophysical Observation", "SAO 251493"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.36710523),
        dec: Angle.Degrees(-63.68298780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13389"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.08699952),
        dec: Angle.Degrees(-63.68135287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 979.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 630.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76285"},
        {"Hipparcos Number", "HIP 43524"},
        {"Geneva Identification System", "GEN# +1.00076285"},
        {"Smithsonian Astrophysical Observation", "SAO 250357"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.96979095),
        dec: Angle.Degrees(-63.68117034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1861"},
        {"Hipparcos Number", "HIP 1776"},
        {"Smithsonian Astrophysical Observation", "SAO 248173"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.63162093),
        dec: Angle.Degrees(-63.67751902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103807"},
        {"Hipparcos Number", "HIP 58278"},
        {"Geneva Identification System", "GEN# +1.00103807"},
        {"Smithsonian Astrophysical Observation", "SAO 251655"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.27826371),
        dec: Angle.Degrees(-63.67671697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165040"},
        {"Hipparcos Number", "HIP 88866"},
        {"Fundamental Katalog 5th Edition", "FK5 3437"},
        {"Geneva Identification System", "GEN# +1.00165040"},
        {"Renson", "Renson 46610"},
        {"Smithsonian Astrophysical Observation", "SAO 254147"},
        {"Wilson Evans Batten Catalogue", "WEB 15068"},
    },
    visualMagnitude: 4.33,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.14496186),
        dec: Angle.Degrees(-63.66804844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1454"},
        {"Hipparcos Number", "HIP 1472"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.58118773),
        dec: Angle.Degrees(-63.66678454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22708"},
        {"Hipparcos Number", "HIP 16746"},
        {"Geneva Identification System", "GEN# +1.00022708"},
        {"Renson", "Renson 5780"},
        {"Smithsonian Astrophysical Observation", "SAO 248846"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.85388923),
        dec: Angle.Degrees(-63.66549347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117609"},
        {"Hipparcos Number", "HIP 66109"},
        {"Geneva Identification System", "GEN# +1.00117609"},
        {"Smithsonian Astrophysical Observation", "SAO 252358"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.27615638),
        dec: Angle.Degrees(-63.66396785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119612"},
        {"Hipparcos Number", "HIP 67192"},
        {"Smithsonian Astrophysical Observation", "SAO 252437"},
    },
    visualMagnitude: 8.33,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.55107909),
        dec: Angle.Degrees(-63.66364025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195371"},
        {"Hipparcos Number", "HIP 101524"},
        {"Smithsonian Astrophysical Observation", "SAO 254817"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.61066832),
        dec: Angle.Degrees(-63.66187000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190710"},
        {"Hipparcos Number", "HIP 99358"},
        {"Fundamental Katalog 5th Edition", "FK5 5775"},
        {"Smithsonian Astrophysical Observation", "SAO 254736"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.50548409),
        dec: Angle.Degrees(-63.65873726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128698"},
        {"Hipparcos Number", "HIP 71786"},
        {"Smithsonian Astrophysical Observation", "SAO 252842"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.26418443),
        dec: Angle.Degrees(-63.65818114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39307"},
        {"Smithsonian Astrophysical Observation", "SAO 250084"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.55192931),
        dec: Angle.Degrees(-63.65768208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112459"},
        {"Hipparcos Number", "HIP 63260"},
        {"Geneva Identification System", "GEN# +1.00112459"},
        {"Renson", "Renson 32680"},
        {"Smithsonian Astrophysical Observation", "SAO 252107"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.44299027),
        dec: Angle.Degrees(-63.65686217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221410"},
        {"Hipparcos Number", "HIP 116184"},
        {"Fundamental Katalog 5th Edition", "FK5 6082"},
        {"Smithsonian Astrophysical Observation", "SAO 255511"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.11744714),
        dec: Angle.Degrees(-63.65492633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102940"},
        {"Hipparcos Number", "HIP 57765"},
        {"Celescope Catalog", "CEL 3993"},
        {"Geneva Identification System", "GEN# +1.00102940"},
        {"Smithsonian Astrophysical Observation", "SAO 251609"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.68940893),
        dec: Angle.Degrees(-63.65053266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65216"},
        {"Hipparcos Number", "HIP 38558"},
        {"Geneva Identification System", "GEN# +1.00065216"},
        {"Smithsonian Astrophysical Observation", "SAO 250002"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.42284489),
        dec: Angle.Degrees(-63.64767769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 145.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35502"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.90515620),
        dec: Angle.Degrees(-63.64679765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100444"},
        {"Hipparcos Number", "HIP 56331"},
        {"Celescope Catalog", "CEL 3913"},
        {"Geneva Identification System", "GEN# +1.00100444"},
        {"Smithsonian Astrophysical Observation", "SAO 251454"},
        {"Wilson Evans Batten Catalogue", "WEB 10129"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.22227257),
        dec: Angle.Degrees(-63.64679340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204902"},
        {"Hipparcos Number", "HIP 106509"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.58766487),
        dec: Angle.Degrees(-63.64358123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133792"},
        {"Hipparcos Number", "HIP 74181"},
        {"Geneva Identification System", "GEN# +1.00133792"},
        {"Renson", "Renson 37970"},
        {"Smithsonian Astrophysical Observation", "SAO 253034"},
        {"Wilson Evans Batten Catalogue", "WEB 12668"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.35639755),
        dec: Angle.Degrees(-63.64288115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112109"},
        {"Hipparcos Number", "HIP 63041"},
        {"Geneva Identification System", "GEN# +1.00112109"},
        {"Smithsonian Astrophysical Observation", "SAO 252088"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.76650000),
        dec: Angle.Degrees(-63.64075552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112607"},
        {"Hipparcos Number", "HIP 63365"},
        {"Celescope Catalog", "CEL 4186"},
        {"Geneva Identification System", "GEN# +1.00112607"},
        {"Smithsonian Astrophysical Observation", "SAO 252114"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.75553581),
        dec: Angle.Degrees(-63.64061263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88256"},
        {"Hipparcos Number", "HIP 49679"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.11877325),
        dec: Angle.Degrees(-63.63802610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 143.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120598"},
        {"Hipparcos Number", "HIP 67724"},
        {"Smithsonian Astrophysical Observation", "SAO 252487"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.11022739),
        dec: Angle.Degrees(-63.63731889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 307739"},
        {"Hipparcos Number", "HIP 50992"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.24843622),
        dec: Angle.Degrees(-63.63624038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 660"},
        {"Hipparcos Number", "HIP 863"},
        {"Smithsonian Astrophysical Observation", "SAO 248133"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.65757354),
        dec: Angle.Degrees(-63.63430723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75434",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75434"},
        {"Geneva Identification System", "GEN# -0.06303580"},
        {"Smithsonian Astrophysical Observation", "SAO 253146"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.16931717),
        dec: Angle.Degrees(-63.63382254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72277"},
        {"Hipparcos Number", "HIP 41540"},
        {"Smithsonian Astrophysical Observation", "SAO 250237"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.06709740),
        dec: Angle.Degrees(-63.63187677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32670"},
        {"Hipparcos Number", "HIP 23273"},
        {"Smithsonian Astrophysical Observation", "SAO 249163"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.10777551),
        dec: Angle.Degrees(-63.63078811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134708"},
        {"Hipparcos Number", "HIP 74601"},
        {"Smithsonian Astrophysical Observation", "SAO 253066"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.64192231),
        dec: Angle.Degrees(-63.63021495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211574"},
        {"Hipparcos Number", "HIP 110259"},
        {"Smithsonian Astrophysical Observation", "SAO 255199"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.00697391),
        dec: Angle.Degrees(-63.62822563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18959"},
        {"Hipparcos Number", "HIP 13953"},
        {"Smithsonian Astrophysical Observation", "SAO 248705"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.92667455),
        dec: Angle.Degrees(-63.62821354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218340"},
        {"Hipparcos Number", "HIP 114236"},
        {"Smithsonian Astrophysical Observation", "SAO 255410"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.05097648),
        dec: Angle.Degrees(-63.62800567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73834"},
        {"Hipparcos Number", "HIP 42251"},
        {"Celescope Catalog", "CEL 2722"},
        {"Geneva Identification System", "GEN# +1.00073834"},
        {"Smithsonian Astrophysical Observation", "SAO 250284"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.21959817),
        dec: Angle.Degrees(-63.62762806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52840",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52840"},
        {"Geneva Identification System", "GEN# +3.26020057"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.05569880),
        dec: Angle.Degrees(-63.62760624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212618"},
        {"Hipparcos Number", "HIP 110844"},
        {"Smithsonian Astrophysical Observation", "SAO 255224"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.85402858),
        dec: Angle.Degrees(-63.62453810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93796"},
        {"Hipparcos Number", "HIP 52839"},
        {"Geneva Identification System", "GEN# +3.26020056"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.05444440),
        dec: Angle.Degrees(-63.62364634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152730"},
        {"Hipparcos Number", "HIP 83135"},
        {"Geneva Identification System", "GEN# +1.00152730"},
        {"Smithsonian Astrophysical Observation", "SAO 253761"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.83599673),
        dec: Angle.Degrees(-63.62351993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190733"},
        {"Hipparcos Number", "HIP 99371"},
        {"Smithsonian Astrophysical Observation", "SAO 254737"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.54220547),
        dec: Angle.Degrees(-63.62295296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12680"},
        {"Hipparcos Number", "HIP 9469"},
        {"Geneva Identification System", "GEN# +1.00012680"},
        {"Smithsonian Astrophysical Observation", "SAO 248482"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.45878638),
        dec: Angle.Degrees(-63.62275719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53707"},
        {"Hipparcos Number", "HIP 33857"},
        {"Smithsonian Astrophysical Observation", "SAO 249717"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.43470238),
        dec: Angle.Degrees(-63.61977638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99703"},
        {"Hipparcos Number", "HIP 55897"},
        {"Geneva Identification System", "GEN# +1.00099703"},
        {"Smithsonian Astrophysical Observation", "SAO 251411"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.86302475),
        dec: Angle.Degrees(-63.61855593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191056"},
        {"Hipparcos Number", "HIP 99521"},
        {"Smithsonian Astrophysical Observation", "SAO 254746"},
    },
    visualMagnitude: 7.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.96122507),
        dec: Angle.Degrees(-63.61698346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106873"},
        {"Hipparcos Number", "HIP 59943"},
        {"Smithsonian Astrophysical Observation", "SAO 251832"},
    },
    visualMagnitude: 7.42,
    bvColour: 2.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44064878),
        dec: Angle.Degrees(-63.61614752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31645"},
        {"Hipparcos Number", "HIP 22719"},
        {"Smithsonian Astrophysical Observation", "SAO 249135"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.28711933),
        dec: Angle.Degrees(-63.61593818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135291"},
        {"Hipparcos Number", "HIP 74837"},
        {"Fundamental Katalog 5th Edition", "FK5 3205"},
        {"Geneva Identification System", "GEN# +1.00135291"},
        {"Smithsonian Astrophysical Observation", "SAO 253088"},
        {"Wilson Evans Batten Catalogue", "WEB 12765"},
    },
    visualMagnitude: 4.85,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.41203255),
        dec: Angle.Degrees(-63.61048662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84247"},
        {"Hipparcos Number", "HIP 47525"},
        {"Smithsonian Astrophysical Observation", "SAO 250666"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.33570721),
        dec: Angle.Degrees(-63.60984622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11148"},
        {"Hipparcos Number", "HIP 8338"},
        {"Smithsonian Astrophysical Observation", "SAO 248437"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.88875345),
        dec: Angle.Degrees(-63.60857883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76395"},
        {"Hipparcos Number", "HIP 43583"},
        {"Smithsonian Astrophysical Observation", "SAO 250363"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.14305942),
        dec: Angle.Degrees(-63.60583872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85139"},
        {"Hipparcos Number", "HIP 48030"},
        {"Smithsonian Astrophysical Observation", "SAO 250697"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.86218123),
        dec: Angle.Degrees(-63.60101712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225134"},
        {"Hipparcos Number", "HIP 299"},
        {"Smithsonian Astrophysical Observation", "SAO 248109"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.93377179),
        dec: Angle.Degrees(-63.60066163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145765"},
        {"Hipparcos Number", "HIP 79746"},
        {"Smithsonian Astrophysical Observation", "SAO 253479"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.12949192),
        dec: Angle.Degrees(-63.59953338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128792"},
        {"Hipparcos Number", "HIP 71831"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.40971219),
        dec: Angle.Degrees(-63.59595109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 538"},
        {"Hipparcos Number", "HIP 785"},
        {"Smithsonian Astrophysical Observation", "SAO 248129"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.42218904),
        dec: Angle.Degrees(-63.58967752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156310"},
        {"Hipparcos Number", "HIP 84918"},
        {"Smithsonian Astrophysical Observation", "SAO 253878"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.30619616),
        dec: Angle.Degrees(-63.58215361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39842"},
        {"Hipparcos Number", "HIP 27596"},
        {"Smithsonian Astrophysical Observation", "SAO 249369"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.64854983),
        dec: Angle.Degrees(-63.58111973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114886"},
        {"Hipparcos Number", "HIP 64624"},
        {"Celescope Catalog", "CEL 4219"},
        {"Geneva Identification System", "GEN# +1.00114886J"},
        {"Smithsonian Astrophysical Observation", "SAO 252220"},
        {"Wilson Evans Batten Catalogue", "WEB 11429"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.68496648),
        dec: Angle.Degrees(-63.58105530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128637"},
        {"Hipparcos Number", "HIP 71763"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.18415345),
        dec: Angle.Degrees(-63.57907686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104857"},
        {"Hipparcos Number", "HIP 58875"},
        {"Smithsonian Astrophysical Observation", "SAO 251719"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.13637025),
        dec: Angle.Degrees(-63.57721765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16010"},
        {"Hipparcos Number", "HIP 11748"},
        {"Smithsonian Astrophysical Observation", "SAO 248589"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.89741819),
        dec: Angle.Degrees(-63.57544119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62115"},
        {"Hipparcos Number", "HIP 37166"},
        {"Geneva Identification System", "GEN# +1.00062115"},
        {"Smithsonian Astrophysical Observation", "SAO 249905"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.56454232),
        dec: Angle.Degrees(-63.57360854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187394"},
        {"Hipparcos Number", "HIP 97900"},
        {"Geneva Identification System", "GEN# +1.00187394"},
        {"Smithsonian Astrophysical Observation", "SAO 254679"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.43290411),
        dec: Angle.Degrees(-63.57276604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214257"},
        {"Hipparcos Number", "HIP 111791"},
        {"Smithsonian Astrophysical Observation", "SAO 255268"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.64858244),
        dec: Angle.Degrees(-63.57254569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210206"},
        {"Hipparcos Number", "HIP 109485"},
        {"Smithsonian Astrophysical Observation", "SAO 255162"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.70321287),
        dec: Angle.Degrees(-63.56936210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122234"},
        {"Hipparcos Number", "HIP 68625"},
        {"Geneva Identification System", "GEN# +1.00122234"},
        {"Smithsonian Astrophysical Observation", "SAO 252573"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.71240519),
        dec: Angle.Degrees(-63.56785203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66591"},
        {"Hipparcos Number", "HIP 39138"},
        {"Fundamental Katalog 5th Edition", "FK5 2624"},
        {"Geneva Identification System", "GEN# +1.00066591"},
        {"Smithsonian Astrophysical Observation", "SAO 250069"},
        {"Wilson Evans Batten Catalogue", "WEB 7674"},
    },
    visualMagnitude: 4.81,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.08320513),
        dec: Angle.Degrees(-63.56750271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126777"},
        {"Hipparcos Number", "HIP 70917"},
        {"Smithsonian Astrophysical Observation", "SAO 252761"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.53662815),
        dec: Angle.Degrees(-63.56677690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119635"},
        {"Hipparcos Number", "HIP 67208"},
        {"Smithsonian Astrophysical Observation", "SAO 252438"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57805566),
        dec: Angle.Degrees(-63.56260236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161050"},
        {"Hipparcos Number", "HIP 87100"},
        {"Geneva Identification System", "GEN# +1.00161050"},
        {"Smithsonian Astrophysical Observation", "SAO 254033"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.94186719),
        dec: Angle.Degrees(-63.56246188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221554"},
        {"Hipparcos Number", "HIP 116276"},
        {"Smithsonian Astrophysical Observation", "SAO 255515"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.39134187),
        dec: Angle.Degrees(-63.55917044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30749"},
        {"Hipparcos Number", "HIP 22149"},
        {"Geneva Identification System", "GEN# +1.00030749"},
        {"Smithsonian Astrophysical Observation", "SAO 249102"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.49386982),
        dec: Angle.Degrees(-63.55791634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21257"},
        {"Hipparcos Number", "HIP 15701"},
        {"Smithsonian Astrophysical Observation", "SAO 248788"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.56789982),
        dec: Angle.Degrees(-63.55760818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91271"},
        {"Hipparcos Number", "HIP 51446"},
        {"Smithsonian Astrophysical Observation", "SAO 250990"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.60497274),
        dec: Angle.Degrees(-63.55666603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99953"},
        {"Hipparcos Number", "HIP 56050"},
        {"Celescope Catalog", "CEL 3907"},
        {"Geneva Identification System", "GEN# +1.00099953"},
        {"Smithsonian Astrophysical Observation", "SAO 251422"},
        {"Wilson Evans Batten Catalogue", "WEB 10064"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.31310000),
        dec: Angle.Degrees(-63.55394067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59873"},
        {"Hipparcos Number", "HIP 36244"},
        {"Smithsonian Astrophysical Observation", "SAO 249858"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.95385529),
        dec: Angle.Degrees(-63.55346439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215741"},
        {"Hipparcos Number", "HIP 112638"},
        {"Smithsonian Astrophysical Observation", "SAO 255323"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.19516779),
        dec: Angle.Degrees(-63.55182741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141139"},
        {"Hipparcos Number", "HIP 77646"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.77934618),
        dec: Angle.Degrees(-63.55163642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74237"},
        {"Hipparcos Number", "HIP 42458"},
        {"Smithsonian Astrophysical Observation", "SAO 250294"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.84843504),
        dec: Angle.Degrees(-63.55141988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48360"},
        {"Hipparcos Number", "HIP 31764"},
        {"Smithsonian Astrophysical Observation", "SAO 249608"},
    },
    visualMagnitude: 9.21,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.65226566),
        dec: Angle.Degrees(-63.54985564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111055"},
        {"Hipparcos Number", "HIP 62400"},
        {"Renson", "Renson 32280"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.82735894),
        dec: Angle.Degrees(-63.54958997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37403"},
        {"Hipparcos Number", "HIP 26089"},
        {"Smithsonian Astrophysical Observation", "SAO 249312"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.46322284),
        dec: Angle.Degrees(-63.54729698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32107"},
        {"Hipparcos Number", "HIP 22959"},
        {"Smithsonian Astrophysical Observation", "SAO 249151"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.10321942),
        dec: Angle.Degrees(-63.54663797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128456"},
        {"Hipparcos Number", "HIP 71678"},
        {"Fundamental Katalog 5th Edition", "FK5 5302"},
        {"Smithsonian Astrophysical Observation", "SAO 252837"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.91254388),
        dec: Angle.Degrees(-63.54545526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41704"},
        {"Hipparcos Number", "HIP 28599"},
        {"Smithsonian Astrophysical Observation", "SAO 249426"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.54158267),
        dec: Angle.Degrees(-63.54534222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14705"},
        {"Hipparcos Number", "HIP 10866"},
        {"Geneva Identification System", "GEN# +1.00014705"},
        {"Smithsonian Astrophysical Observation", "SAO 248533"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.95833109),
        dec: Angle.Degrees(-63.54480179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219935"},
        {"Hipparcos Number", "HIP 115241"},
        {"Smithsonian Astrophysical Observation", "SAO 255464"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.13460661),
        dec: Angle.Degrees(-63.54336151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34620"},
        {"Hipparcos Number", "HIP 24423"},
        {"Geneva Identification System", "GEN# +1.00034620"},
        {"Smithsonian Astrophysical Observation", "SAO 249226"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.60239735),
        dec: Angle.Degrees(-63.54142361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148029"},
        {"Hipparcos Number", "HIP 80764"},
        {"Smithsonian Astrophysical Observation", "SAO 253571"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.35428500),
        dec: Angle.Degrees(-63.54107275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18120"},
        {"Hipparcos Number", "HIP 13333"},
        {"Smithsonian Astrophysical Observation", "SAO 248667"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.89980168),
        dec: Angle.Degrees(-63.54061374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204167"},
        {"Hipparcos Number", "HIP 106096"},
        {"Smithsonian Astrophysical Observation", "SAO 255005"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.37643933),
        dec: Angle.Degrees(-63.53945553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220312"},
        {"Hipparcos Number", "HIP 115472"},
        {"Smithsonian Astrophysical Observation", "SAO 255478"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.87348459),
        dec: Angle.Degrees(-63.53562453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171825"},
        {"Hipparcos Number", "HIP 91638"},
        {"Geneva Identification System", "GEN# +1.00171825"},
        {"Smithsonian Astrophysical Observation", "SAO 254332"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.31917854),
        dec: Angle.Degrees(-63.53442810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219558"},
        {"Hipparcos Number", "HIP 115005"},
        {"Smithsonian Astrophysical Observation", "SAO 255450"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.38534039),
        dec: Angle.Degrees(-63.53422607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39979"},
        {"Hipparcos Number", "HIP 27674"},
        {"Smithsonian Astrophysical Observation", "SAO 249377"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.87938771),
        dec: Angle.Degrees(-63.53125439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96215"},
        {"Hipparcos Number", "HIP 54133"},
    },
    visualMagnitude: 9.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.12802069),
        dec: Angle.Degrees(-63.52713048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35529"},
        {"Hipparcos Number", "HIP 24963"},
        {"Smithsonian Astrophysical Observation", "SAO 249256"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.20931369),
        dec: Angle.Degrees(-63.52518625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90837"},
        {"Hipparcos Number", "HIP 51203"},
        {"Fundamental Katalog 5th Edition", "FK5 4928"},
        {"Geneva Identification System", "GEN# +1.00090837"},
        {"Smithsonian Astrophysical Observation", "SAO 250965"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.87615280),
        dec: Angle.Degrees(-63.52328570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11325"},
        {"Hipparcos Number", "HIP 8472"},
        {"Renson", "Renson 2800"},
        {"Smithsonian Astrophysical Observation", "SAO 248442"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.30540764),
        dec: Angle.Degrees(-63.51664179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67990"},
        {"Hipparcos Number", "HIP 39684"},
        {"Smithsonian Astrophysical Observation", "SAO 250111"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.65079483),
        dec: Angle.Degrees(-63.51604577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133740"},
        {"Hipparcos Number", "HIP 74163"},
        {"Smithsonian Astrophysical Observation", "SAO 253032"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.30228711),
        dec: Angle.Degrees(-63.51587670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123927"},
        {"Hipparcos Number", "HIP 69419"},
        {"Geneva Identification System", "GEN# +1.00123927"},
        {"Smithsonian Astrophysical Observation", "SAO 252647"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.20943401),
        dec: Angle.Degrees(-63.51514751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85970"},
        {"Hipparcos Number", "HIP 48470"},
        {"Smithsonian Astrophysical Observation", "SAO 250737"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.26086979),
        dec: Angle.Degrees(-63.51293247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120416"},
        {"Hipparcos Number", "HIP 67612"},
        {"Smithsonian Astrophysical Observation", "SAO 252479"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.81040686),
        dec: Angle.Degrees(-63.51263251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66975"},
        {"Hipparcos Number", "HIP 39287"},
        {"Smithsonian Astrophysical Observation", "SAO 250083"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.50206819),
        dec: Angle.Degrees(-63.50956305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92896"},
        {"Hipparcos Number", "HIP 52357"},
        {"Geneva Identification System", "GEN# +3.26020032"},
        {"Smithsonian Astrophysical Observation", "SAO 251075"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.49870254),
        dec: Angle.Degrees(-63.50731218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200166"},
        {"Hipparcos Number", "HIP 104058"},
        {"Smithsonian Astrophysical Observation", "SAO 254932"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.22218578),
        dec: Angle.Degrees(-63.50702486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109000"},
        {"Hipparcos Number", "HIP 61158"},
        {"Geneva Identification System", "GEN# +1.00109000"},
        {"Smithsonian Astrophysical Observation", "SAO 251946"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.98397037),
        dec: Angle.Degrees(-63.50589876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209829"},
        {"Hipparcos Number", "HIP 109274"},
        {"Geneva Identification System", "GEN# +1.00209829"},
        {"Smithsonian Astrophysical Observation", "SAO 255151"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.06947936),
        dec: Angle.Degrees(-63.50511934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16068"},
        {"Smithsonian Astrophysical Observation", "SAO 248809"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.74129364),
        dec: Angle.Degrees(-63.50474885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70801"},
        {"Hipparcos Number", "HIP 40855"},
        {"Smithsonian Astrophysical Observation", "SAO 250193"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.04907712),
        dec: Angle.Degrees(-63.50380622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21749"},
        {"Hipparcos Number", "HIP 16069"},
        {"Cincinnati Publication", "Ci 20 238"},
        {"Geneva Identification System", "GEN# +1.00021749"},
        {"Smithsonian Astrophysical Observation", "SAO 248808"},
        {"Wilson Evans Batten Catalogue", "WEB 3065"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.74482544),
        dec: Angle.Degrees(-63.49849914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 356.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63969"},
        {"Hipparcos Number", "HIP 38023"},
        {"Smithsonian Astrophysical Observation", "SAO 249966"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.89024081),
        dec: Angle.Degrees(-63.49798687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19128"},
        {"Hipparcos Number", "HIP 14078"},
        {"Smithsonian Astrophysical Observation", "SAO 248709"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.35874451),
        dec: Angle.Degrees(-63.49624671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95911"},
        {"Hipparcos Number", "HIP 53992"},
        {"Smithsonian Astrophysical Observation", "SAO 251231"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.68774967),
        dec: Angle.Degrees(-63.49462554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61311"},
        {"Hipparcos Number", "HIP 36840"},
        {"Smithsonian Astrophysical Observation", "SAO 249885"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.63045797),
        dec: Angle.Degrees(-63.49396760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113432"},
        {"Hipparcos Number", "HIP 63821"},
        {"Geneva Identification System", "GEN# +1.00113432"},
        {"Smithsonian Astrophysical Observation", "SAO 252142"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.20553855),
        dec: Angle.Degrees(-63.49145406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62962"},
        {"Hipparcos Number", "HIP 37555"},
        {"Smithsonian Astrophysical Observation", "SAO 249931"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.61393234),
        dec: Angle.Degrees(-63.48543890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88185"},
        {"Smithsonian Astrophysical Observation", "SAO 254103"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.14636487),
        dec: Angle.Degrees(-63.48311968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199997"},
        {"Hipparcos Number", "HIP 103954"},
        {"Geneva Identification System", "GEN# +1.00199997"},
        {"Smithsonian Astrophysical Observation", "SAO 254928"},
        {"Wilson Evans Batten Catalogue", "WEB 18931"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.94641642),
        dec: Angle.Degrees(-63.48090379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79213"},
    },
    visualMagnitude: 10.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.50114590),
        dec: Angle.Degrees(-63.48079237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31010"},
        {"Hipparcos Number", "HIP 22299"},
        {"Smithsonian Astrophysical Observation", "SAO 249111"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.02681638),
        dec: Angle.Degrees(-63.48030591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183883"},
        {"Hipparcos Number", "HIP 96385"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.94837511),
        dec: Angle.Degrees(-63.47981960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101436"},
        {"Hipparcos Number", "HIP 56897"},
        {"Celescope Catalog", "CEL 3950"},
        {"Geneva Identification System", "GEN# +3.29440118"},
        {"Smithsonian Astrophysical Observation", "SAO 251525"},
        {"Wilson Evans Batten Catalogue", "WEB 10245"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.95818450),
        dec: Angle.Degrees(-63.47876457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101413"},
        {"Hipparcos Number", "HIP 56890"},
        {"Geneva Identification System", "GEN# +3.29440113"},
        {"Smithsonian Astrophysical Observation", "SAO 251524"},
        {"Wilson Evans Batten Catalogue", "WEB 10244"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.94102604),
        dec: Angle.Degrees(-63.47781252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1466"},
        {"Hipparcos Number", "HIP 1481"},
        {"Geneva Identification System", "GEN# +1.00001466"},
        {"Smithsonian Astrophysical Observation", "SAO 248159"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.60835719),
        dec: Angle.Degrees(-63.47735107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97630"},
        {"Hipparcos Number", "HIP 54796"},
        {"Smithsonian Astrophysical Observation", "SAO 251323"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.27489878),
        dec: Angle.Degrees(-63.47668229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144459"},
        {"Hipparcos Number", "HIP 79210"},
        {"Smithsonian Astrophysical Observation", "SAO 253443"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.49902683),
        dec: Angle.Degrees(-63.47643083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98314"},
        {"Hipparcos Number", "HIP 55153"},
        {"Geneva Identification System", "GEN# +1.00098314"},
        {"Smithsonian Astrophysical Observation", "SAO 251342"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.37909657),
        dec: Angle.Degrees(-63.47635470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187997"},
        {"Hipparcos Number", "HIP 98155"},
        {"Smithsonian Astrophysical Observation", "SAO 254688"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.20851995),
        dec: Angle.Degrees(-63.47352741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213493"},
        {"Hipparcos Number", "HIP 111348"},
        {"Smithsonian Astrophysical Observation", "SAO 255252"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.37654107),
        dec: Angle.Degrees(-63.47187248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14913"},
        {"Hipparcos Number", "HIP 11009"},
        {"Smithsonian Astrophysical Observation", "SAO 248543"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.44819342),
        dec: Angle.Degrees(-63.46724199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77455"},
        {"Hipparcos Number", "HIP 44135"},
        {"Geneva Identification System", "GEN# +1.00077455"},
        {"Smithsonian Astrophysical Observation", "SAO 250413"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.83611204),
        dec: Angle.Degrees(-63.46685151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48431"},
        {"Hipparcos Number", "HIP 31798"},
        {"Smithsonian Astrophysical Observation", "SAO 249613"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.72322334),
        dec: Angle.Degrees(-63.46536394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76988"},
        {"Hipparcos Number", "HIP 43879"},
        {"Geneva Identification System", "GEN# +1.00076988"},
        {"Smithsonian Astrophysical Observation", "SAO 250386"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.08023451),
        dec: Angle.Degrees(-63.46421912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25170"},
        {"Hipparcos Number", "HIP 18401"},
        {"Geneva Identification System", "GEN# +1.00025170"},
        {"Smithsonian Astrophysical Observation", "SAO 248912"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.01624183),
        dec: Angle.Degrees(-63.46384651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146913"},
        {"Hipparcos Number", "HIP 80225"},
        {"Smithsonian Astrophysical Observation", "SAO 253523"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.65733816),
        dec: Angle.Degrees(-63.46189425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215240"},
        {"Hipparcos Number", "HIP 112333"},
        {"Smithsonian Astrophysical Observation", "SAO 255305"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.29599620),
        dec: Angle.Degrees(-63.46154689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104723"},
        {"Hipparcos Number", "HIP 58788"},
        {"Smithsonian Astrophysical Observation", "SAO 251710"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.86725817),
        dec: Angle.Degrees(-63.45997645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60038"},
        {"Hipparcos Number", "HIP 36321"},
        {"Geneva Identification System", "GEN# +1.00060038"},
        {"Smithsonian Astrophysical Observation", "SAO 249861"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.14710726),
        dec: Angle.Degrees(-63.45995068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118061"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.24736428),
        dec: Angle.Degrees(-63.45985185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 236.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125370"},
        {"Hipparcos Number", "HIP 70168"},
        {"Smithsonian Astrophysical Observation", "SAO 252713"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.34511116),
        dec: Angle.Degrees(-63.45947323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37279"},
        {"Hipparcos Number", "HIP 25994"},
        {"Renson", "Renson 9980"},
        {"Smithsonian Astrophysical Observation", "SAO 249308"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.22025288),
        dec: Angle.Degrees(-63.45605649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151917"},
        {"Hipparcos Number", "HIP 82726"},
        {"Smithsonian Astrophysical Observation", "SAO 253728"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.63843148),
        dec: Angle.Degrees(-63.45557914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106036"},
        {"Hipparcos Number", "HIP 59502"},
        {"Geneva Identification System", "GEN# +1.00106036"},
        {"Smithsonian Astrophysical Observation", "SAO 251788"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.04303142),
        dec: Angle.Degrees(-63.45408945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110062"},
        {"Hipparcos Number", "HIP 61819"},
        {"Geneva Identification System", "GEN# +1.00110062"},
        {"Smithsonian Astrophysical Observation", "SAO 251989"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.03590253),
        dec: Angle.Degrees(-63.45336166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86183"},
        {"Hipparcos Number", "HIP 48586"},
        {"Celescope Catalog", "CEL 3401"},
        {"Geneva Identification System", "GEN# +1.00086183"},
        {"Smithsonian Astrophysical Observation", "SAO 250744"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.63517734),
        dec: Angle.Degrees(-63.45135027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115400"},
        {"Hipparcos Number", "HIP 64914"},
        {"Geneva Identification System", "GEN# +1.00115400"},
        {"Smithsonian Astrophysical Observation", "SAO 252252"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.58280541),
        dec: Angle.Degrees(-63.44914405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23661"},
        {"Hipparcos Number", "HIP 17366"},
        {"Smithsonian Astrophysical Observation", "SAO 248874"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.77823538),
        dec: Angle.Degrees(-63.44849927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89942"},
        {"Hipparcos Number", "HIP 50672"},
        {"Geneva Identification System", "GEN# +1.00089942"},
        {"Smithsonian Astrophysical Observation", "SAO 250927"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.21134392),
        dec: Angle.Degrees(-63.44830911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122938"},
        {"Henry Draper 2", "HD 122939"},
        {"Hipparcos Number", "HIP 68964"},
        {"Geneva Identification System", "GEN# +1.00122938"},
        {"Smithsonian Astrophysical Observation", "SAO 252599"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.77034512),
        dec: Angle.Degrees(-63.44532555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82405"},
        {"Hipparcos Number", "HIP 46505"},
        {"Smithsonian Astrophysical Observation", "SAO 250595"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.26468259),
        dec: Angle.Degrees(-63.44008590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122989"},
        {"Hipparcos Number", "HIP 68979"},
        {"Geneva Identification System", "GEN# +1.00122989"},
        {"Renson", "Renson 35250"},
        {"Smithsonian Astrophysical Observation", "SAO 252602"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.83051058),
        dec: Angle.Degrees(-63.43540509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44106"},
        {"Hipparcos Number", "HIP 29708"},
        {"Smithsonian Astrophysical Observation", "SAO 249494"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.86686088),
        dec: Angle.Degrees(-63.43476464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78408"},
        {"Hipparcos Number", "HIP 44576"},
        {"Smithsonian Astrophysical Observation", "SAO 250432"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.23455008),
        dec: Angle.Degrees(-63.43457121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156416"},
        {"Hipparcos Number", "HIP 84951"},
        {"Smithsonian Astrophysical Observation", "SAO 253883"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.44471365),
        dec: Angle.Degrees(-63.43418490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99316"},
        {"Hipparcos Number", "HIP 55707"},
        {"Geneva Identification System", "GEN# +1.00099316"},
        {"Smithsonian Astrophysical Observation", "SAO 251397"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.23018292),
        dec: Angle.Degrees(-63.43211197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208711"},
        {"Hipparcos Number", "HIP 108631"},
        {"Smithsonian Astrophysical Observation", "SAO 255125"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.10750968),
        dec: Angle.Degrees(-63.43131519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62281"},
        {"Hipparcos Number", "HIP 37257"},
        {"Smithsonian Astrophysical Observation", "SAO 249912"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.77220558),
        dec: Angle.Degrees(-63.43057122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75728"},
        {"Hipparcos Number", "HIP 43227"},
        {"Smithsonian Astrophysical Observation", "SAO 250330"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.08413115),
        dec: Angle.Degrees(-63.42983711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141891"},
        {"Hipparcos Number", "HIP 77952"},
        {"Cincinnati Publication", "Ci 20 948"},
        {"Fundamental Katalog 5th Edition", "FK5 589"},
        {"Geneva Identification System", "GEN# +1.00141891A"},
        {"Renson", "Renson 40270"},
        {"Smithsonian Astrophysical Observation", "SAO 253346"},
        {"Wilson Evans Batten Catalogue", "WEB 13182"},
    },
    visualMagnitude: 2.83,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.78670013),
        dec: Angle.Degrees(-63.42974973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -401.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101298"},
        {"Hipparcos Number", "HIP 56833"},
        {"Celescope Catalog", "CEL 3942"},
        {"Geneva Identification System", "GEN# +3.29440092"},
        {"Smithsonian Astrophysical Observation", "SAO 251515"},
        {"Wilson Evans Batten Catalogue", "WEB 10236"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.76368351),
        dec: Angle.Degrees(-63.42973882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60609"},
        {"Hipparcos Number", "HIP 36570"},
        {"Smithsonian Astrophysical Observation", "SAO 249872"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.83661048),
        dec: Angle.Degrees(-63.42973871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45701"},
        {"Hipparcos Number", "HIP 30480"},
        {"Geneva Identification System", "GEN# +1.00045701"},
        {"Smithsonian Astrophysical Observation", "SAO 249539"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.11071103),
        dec: Angle.Degrees(-63.42864724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127712"},
        {"Hipparcos Number", "HIP 71355"},
        {"Smithsonian Astrophysical Observation", "SAO 252808"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.88715973),
        dec: Angle.Degrees(-63.42764124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106506"},
        {"Hipparcos Number", "HIP 59764"},
        {"Geneva Identification System", "GEN# +1.00106506"},
        {"Smithsonian Astrophysical Observation", "SAO 251810"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.82751174),
        dec: Angle.Degrees(-63.42506880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32476"},
        {"Hipparcos Number", "HIP 23171"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.77357118),
        dec: Angle.Degrees(-63.42503723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157678"},
        {"Hipparcos Number", "HIP 85547"},
        {"Geneva Identification System", "GEN# +1.00157678"},
        {"Renson", "Renson 44280"},
        {"Smithsonian Astrophysical Observation", "SAO 253935"},
    },
    visualMagnitude: 8.13,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.24783305),
        dec: Angle.Degrees(-63.42390769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40290"},
    },
    visualMagnitude: 11.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.41924132),
        dec: Angle.Degrees(-63.42191243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191603"},
        {"Hipparcos Number", "HIP 99762"},
        {"Fundamental Katalog 5th Edition", "FK5 3619"},
        {"Geneva Identification System", "GEN# +1.00191603"},
        {"Smithsonian Astrophysical Observation", "SAO 254756"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.61232254),
        dec: Angle.Degrees(-63.41586405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101712"},
        {"Hipparcos Number", "HIP 57057"},
        {"Geneva Identification System", "GEN# +3.29440137"},
        {"Smithsonian Astrophysical Observation", "SAO 251544"},
        {"Wilson Evans Batten Catalogue", "WEB 10271"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.45588683),
        dec: Angle.Degrees(-63.41457257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124749"},
        {"Hipparcos Number", "HIP 69868"},
        {"Geneva Identification System", "GEN# +1.00124749"},
        {"Smithsonian Astrophysical Observation", "SAO 252689"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.46588077),
        dec: Angle.Degrees(-63.41334152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95293"},
        {"Hipparcos Number", "HIP 53670"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.71093754),
        dec: Angle.Degrees(-63.40998924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206308"},
        {"Hipparcos Number", "HIP 107285"},
        {"Smithsonian Astrophysical Observation", "SAO 255060"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.96696674),
        dec: Angle.Degrees(-63.40863445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12542"},
        {"Hipparcos Number", "HIP 9393"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.18082759),
        dec: Angle.Degrees(-63.40766455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149926"},
        {"Hipparcos Number", "HIP 81753"},
        {"Smithsonian Astrophysical Observation", "SAO 253659"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.47282072),
        dec: Angle.Degrees(-63.40267655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97728"},
        {"Hipparcos Number", "HIP 54846"},
        {"Geneva Identification System", "GEN# +1.00097728"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.43078532),
        dec: Angle.Degrees(-63.40219521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33684"},
        {"Hipparcos Number", "HIP 23840"},
        {"Fundamental Katalog 5th Edition", "FK5 2389"},
        {"Geneva Identification System", "GEN# +1.00033684"},
        {"Smithsonian Astrophysical Observation", "SAO 249198"},
        {"Wilson Evans Batten Catalogue", "WEB 4653"},
    },
    visualMagnitude: 5.19,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.89171306),
        dec: Angle.Degrees(-63.39957018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117241"},
        {"Hipparcos Number", "HIP 65909"},
        {"Geneva Identification System", "GEN# +1.00117241"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.65894123),
        dec: Angle.Degrees(-63.39855340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120614"},
        {"Hipparcos Number", "HIP 67740"},
        {"Smithsonian Astrophysical Observation", "SAO 252490"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.14337519),
        dec: Angle.Degrees(-63.39612573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4541"},
        {"Wilson Evans Batten Catalogue", "WEB 828"},
    },
    visualMagnitude: 11.56,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.54039653),
        dec: Angle.Degrees(-63.39561285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5266",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5266"},
        {"Geneva Identification System", "GEN# +6.20145183"},
    },
    visualMagnitude: 11.43,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.81787190),
        dec: Angle.Degrees(-63.39462832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14379"},
        {"Hipparcos Number", "HIP 10621"},
        {"Geneva Identification System", "GEN# +1.00014379"},
        {"Smithsonian Astrophysical Observation", "SAO 248526"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.18434802),
        dec: Angle.Degrees(-63.39262247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89517"},
        {"Hipparcos Number", "HIP 50421"},
        {"Smithsonian Astrophysical Observation", "SAO 250908"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.43206138),
        dec: Angle.Degrees(-63.39097410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207403"},
        {"Hipparcos Number", "HIP 107853"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.76633570),
        dec: Angle.Degrees(-63.38866390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80563"},
        {"Hipparcos Number", "HIP 45594"},
        {"Geneva Identification System", "GEN# +1.00080563"},
        {"Smithsonian Astrophysical Observation", "SAO 250525"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.39240997),
        dec: Angle.Degrees(-63.38746794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28093"},
        {"Hipparcos Number", "HIP 20384"},
        {"Fundamental Katalog 5th Edition", "FK5 163"},
        {"Geneva Identification System", "GEN# +1.00028093"},
        {"Smithsonian Astrophysical Observation", "SAO 249009"},
        {"Wilson Evans Batten Catalogue", "WEB 3896"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.47173239),
        dec: Angle.Degrees(-63.38681514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 174.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57808"},
        {"Hipparcos Number", "HIP 35408"},
        {"Smithsonian Astrophysical Observation", "SAO 249817"},
    },
    visualMagnitude: 7.37,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.66192118),
        dec: Angle.Degrees(-63.38672920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86557"},
        {"Hipparcos Number", "HIP 48779"},
        {"Celescope Catalog", "CEL 3415"},
        {"Smithsonian Astrophysical Observation", "SAO 250756"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.23593663),
        dec: Angle.Degrees(-63.38655054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168409"},
        {"Hipparcos Number", "HIP 90155"},
        {"Smithsonian Astrophysical Observation", "SAO 254227"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.97103335),
        dec: Angle.Degrees(-63.38555982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11381"},
        {"Hipparcos Number", "HIP 8508"},
        {"Smithsonian Astrophysical Observation", "SAO 248443"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.42767432),
        dec: Angle.Degrees(-63.38502074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167991"},
        {"Hipparcos Number", "HIP 90018"},
        {"Geneva Identification System", "GEN# +1.00167991"},
        {"Smithsonian Astrophysical Observation", "SAO 254218"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.52472543),
        dec: Angle.Degrees(-63.38161472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171359"},
        {"Hipparcos Number", "HIP 91433"},
        {"Smithsonian Astrophysical Observation", "SAO 254320"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.70664199),
        dec: Angle.Degrees(-63.38076813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105999"},
        {"Hipparcos Number", "HIP 59487"},
        {"Fundamental Katalog 5th Edition", "FK5 5082"},
        {"Geneva Identification System", "GEN# +1.00105999"},
        {"Renson", "Renson 30640"},
        {"Smithsonian Astrophysical Observation", "SAO 251784"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.99947250),
        dec: Angle.Degrees(-63.38074706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174928"},
        {"Hipparcos Number", "HIP 93058"},
        {"Geneva Identification System", "GEN# +1.00174928"},
        {"Smithsonian Astrophysical Observation", "SAO 254418"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.33637024),
        dec: Angle.Degrees(-63.37926628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139167"},
        {"Hipparcos Number", "HIP 76741"},
        {"Smithsonian Astrophysical Observation", "SAO 253246"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.06843591),
        dec: Angle.Degrees(-63.37810676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19339"},
        {"Hipparcos Number", "HIP 14222"},
        {"Geneva Identification System", "GEN# +1.00019339"},
        {"Smithsonian Astrophysical Observation", "SAO 248717"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.85056606),
        dec: Angle.Degrees(-63.37496994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117430"},
        {"Hipparcos Number", "HIP 65993"},
        {"Smithsonian Astrophysical Observation", "SAO 252343"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.95644094),
        dec: Angle.Degrees(-63.37494486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114800"},
        {"Hipparcos Number", "HIP 64578"},
        {"Celescope Catalog", "CEL 4218"},
        {"Geneva Identification System", "GEN# +1.00114800"},
        {"Smithsonian Astrophysical Observation", "SAO 252219"},
        {"Wilson Evans Batten Catalogue", "WEB 11421"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.54806596),
        dec: Angle.Degrees(-63.37373127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101205"},
        {"Hipparcos Number", "HIP 56769"},
        {"Celescope Catalog", "CEL 3938"},
        {"Geneva Identification System", "GEN# +3.29440059"},
        {"Smithsonian Astrophysical Observation", "SAO 251511"},
        {"Wilson Evans Batten Catalogue", "WEB 10214"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.58487608),
        dec: Angle.Degrees(-63.37275081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143289"},
        {"Hipparcos Number", "HIP 78653"},
        {"Geneva Identification System", "GEN# +1.00143289J"},
        {"Smithsonian Astrophysical Observation", "SAO 253397"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.84360834),
        dec: Angle.Degrees(-63.36673126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8641"},
        {"Hipparcos Number", "HIP 6508"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.89901611),
        dec: Angle.Degrees(-63.36564231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181378"},
        {"Hipparcos Number", "HIP 95403"},
        {"Smithsonian Astrophysical Observation", "SAO 254560"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.10649633),
        dec: Angle.Degrees(-63.36147918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86591"},
        {"Smithsonian Astrophysical Observation", "SAO 254005"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.44567918),
        dec: Angle.Degrees(-60.43268324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208913"},
        {"Hipparcos Number", "HIP 108740"},
        {"Smithsonian Astrophysical Observation", "SAO 255129"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.41478075),
        dec: Angle.Degrees(-63.36101400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129093"},
        {"Hipparcos Number", "HIP 72001"},
        {"Geneva Identification System", "GEN# +1.00129093"},
        {"Smithsonian Astrophysical Observation", "SAO 252859"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.86828277),
        dec: Angle.Degrees(-63.35810409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87569"},
        {"Hipparcos Number", "HIP 49278"},
        {"Smithsonian Astrophysical Observation", "SAO 250796"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.87742983),
        dec: Angle.Degrees(-63.35681273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120613"},
        {"Hipparcos Number", "HIP 67736"},
        {"Smithsonian Astrophysical Observation", "SAO 252488"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.13680766),
        dec: Angle.Degrees(-63.35610202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129998"},
        {"Hipparcos Number", "HIP 72431"},
        {"Smithsonian Astrophysical Observation", "SAO 252895"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.14945115),
        dec: Angle.Degrees(-63.35534513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6769"},
        {"Hipparcos Number", "HIP 5238"},
        {"Smithsonian Astrophysical Observation", "SAO 248323"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.74590454),
        dec: Angle.Degrees(-63.35489593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176581"},
        {"Hipparcos Number", "HIP 93735"},
        {"Smithsonian Astrophysical Observation", "SAO 254455"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.29456295),
        dec: Angle.Degrees(-63.35476749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159201"},
        {"Hipparcos Number", "HIP 86270"},
        {"Geneva Identification System", "GEN# +1.00159201"},
        {"Smithsonian Astrophysical Observation", "SAO 253982"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.40783596),
        dec: Angle.Degrees(-63.35374923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189174"},
        {"Hipparcos Number", "HIP 98684"},
        {"Smithsonian Astrophysical Observation", "SAO 254713"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.65320771),
        dec: Angle.Degrees(-63.35045419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175820"},
        {"Hipparcos Number", "HIP 93403"},
        {"Smithsonian Astrophysical Observation", "SAO 254438"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.34256434),
        dec: Angle.Degrees(-63.34975169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56533"},
        {"Hipparcos Number", "HIP 34890"},
        {"Geneva Identification System", "GEN# +1.00056533"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.28098206),
        dec: Angle.Degrees(-63.34634800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -266.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 577.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86868"},
        {"Hipparcos Number", "HIP 48942"},
        {"Geneva Identification System", "GEN# +1.00086868"},
        {"Smithsonian Astrophysical Observation", "SAO 250771"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.77340820),
        dec: Angle.Degrees(-63.34521794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205508"},
        {"Hipparcos Number", "HIP 106836"},
        {"Smithsonian Astrophysical Observation", "SAO 255043"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.57711295),
        dec: Angle.Degrees(-63.34270209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34830"},
        {"Hipparcos Number", "HIP 24536"},
        {"Smithsonian Astrophysical Observation", "SAO 249231"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.96506447),
        dec: Angle.Degrees(-63.34162264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143832"},
        {"Hipparcos Number", "HIP 78909"},
        {"Geneva Identification System", "GEN# +1.00143832"},
        {"Smithsonian Astrophysical Observation", "SAO 253423"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.61430476),
        dec: Angle.Degrees(-63.34111010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88544"},
        {"Hipparcos Number", "HIP 49834"},
        {"Smithsonian Astrophysical Observation", "SAO 250850"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.62285707),
        dec: Angle.Degrees(-63.34071694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211045"},
        {"Hipparcos Number", "HIP 109976"},
        {"Geneva Identification System", "GEN# +1.00211045"},
        {"Smithsonian Astrophysical Observation", "SAO 255183"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.12056642),
        dec: Angle.Degrees(-63.33813426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89876"},
        {"Hipparcos Number", "HIP 50619"},
        {"Celescope Catalog", "CEL 3513"},
        {"Geneva Identification System", "GEN# +1.00089876"},
        {"Smithsonian Astrophysical Observation", "SAO 250924"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.09862296),
        dec: Angle.Degrees(-63.33670617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117856"},
        {"Hipparcos Number", "HIP 66253"},
        {"Geneva Identification System", "GEN# +1.00117856"},
        {"Smithsonian Astrophysical Observation", "SAO 252371"},
        {"Wilson Evans Batten Catalogue", "WEB 11705"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.68088286),
        dec: Angle.Degrees(-63.33544543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194858"},
        {"Hipparcos Number", "HIP 101259"},
        {"Smithsonian Astrophysical Observation", "SAO 254806"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.87525283),
        dec: Angle.Degrees(-63.33097762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20734"},
        {"Hipparcos Number", "HIP 15272"},
        {"Geneva Identification System", "GEN# +1.00020734"},
        {"Smithsonian Astrophysical Observation", "SAO 248768"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.25235922),
        dec: Angle.Degrees(-63.33078020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132924"},
        {"Hipparcos Number", "HIP 73785"},
        {"Smithsonian Astrophysical Observation", "SAO 253009"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.22020658),
        dec: Angle.Degrees(-63.32613557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60932"},
        {"Hipparcos Number", "HIP 36674"},
        {"Geneva Identification System", "GEN# +1.00060932"},
        {"Smithsonian Astrophysical Observation", "SAO 249877"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.17938261),
        dec: Angle.Degrees(-63.32496242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101131"},
        {"Hipparcos Number", "HIP 56726"},
        {"Celescope Catalog", "CEL 3933"},
        {"Geneva Identification System", "GEN# +3.29440030"},
        {"Smithsonian Astrophysical Observation", "SAO 251500"},
        {"Wilson Evans Batten Catalogue", "WEB 10201"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.45184146),
        dec: Angle.Degrees(-63.32320142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134894"},
        {"Hipparcos Number", "HIP 74668"},
        {"Geneva Identification System", "GEN# +1.00134894"},
        {"Smithsonian Astrophysical Observation", "SAO 253073"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.88009225),
        dec: Angle.Degrees(-63.31734400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198397"},
        {"Hipparcos Number", "HIP 103100"},
        {"Smithsonian Astrophysical Observation", "SAO 254892"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.34373250),
        dec: Angle.Degrees(-63.31662112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40308"},
        {"Hipparcos Number", "HIP 27846"},
        {"Smithsonian Astrophysical Observation", "SAO 249385"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.37537793),
        dec: Angle.Degrees(-63.31661656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52177"},
        {"Hipparcos Number", "HIP 33320"},
        {"Smithsonian Astrophysical Observation", "SAO 249680"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.96139615),
        dec: Angle.Degrees(-63.31660216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73206"},
        {"Hipparcos Number", "HIP 42002"},
        {"Smithsonian Astrophysical Observation", "SAO 250268"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.41117534),
        dec: Angle.Degrees(-63.31579764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45845"},
        {"Hipparcos Number", "HIP 30554"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.35157241),
        dec: Angle.Degrees(-63.31421638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129917"},
        {"Hipparcos Number", "HIP 72390"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.01423165),
        dec: Angle.Degrees(-63.31387891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169220"},
        {"Hipparcos Number", "HIP 90501"},
        {"Smithsonian Astrophysical Observation", "SAO 254251"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.01350157),
        dec: Angle.Degrees(-63.31309068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104671"},
        {"Hipparcos Number", "HIP 58758"},
        {"Celescope Catalog", "CEL 4044"},
        {"Geneva Identification System", "GEN# +1.00104671"},
        {"Renson", "Renson 30280"},
        {"Smithsonian Astrophysical Observation", "SAO 251705"},
        {"Wilson Evans Batten Catalogue", "WEB 10472"},
    },
    visualMagnitude: 4.32,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.75707974),
        dec: Angle.Degrees(-63.31294495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195429"},
        {"Hipparcos Number", "HIP 101543"},
        {"Smithsonian Astrophysical Observation", "SAO 254818"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.68398504),
        dec: Angle.Degrees(-63.31166121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22077"},
        {"Smithsonian Astrophysical Observation", "SAO 249094"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.23271211),
        dec: Angle.Degrees(-63.30966415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208131"},
        {"Hipparcos Number", "HIP 108310"},
        {"Smithsonian Astrophysical Observation", "SAO 255105"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.13480116),
        dec: Angle.Degrees(-63.30491432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114461"},
        {"Hipparcos Number", "HIP 64395"},
        {"Geneva Identification System", "GEN# +1.00114461"},
        {"Smithsonian Astrophysical Observation", "SAO 252187"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.97114319),
        dec: Angle.Degrees(-63.30298568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112452"},
    },
    visualMagnitude: 11.51,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.68697872),
        dec: Angle.Degrees(-63.30119303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 196.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61785"},
        {"Hipparcos Number", "HIP 37050"},
        {"Smithsonian Astrophysical Observation", "SAO 249894"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.20716887),
        dec: Angle.Degrees(-63.30045739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114670"},
        {"Hipparcos Number", "HIP 64506"},
        {"Geneva Identification System", "GEN# +1.00114670"},
        {"Smithsonian Astrophysical Observation", "SAO 252205"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.31921332),
        dec: Angle.Degrees(-63.30018259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93539"},
        {"Hipparcos Number", "HIP 52690"},
        {"Smithsonian Astrophysical Observation", "SAO 251116"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.60823162),
        dec: Angle.Degrees(-63.29956516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28331"},
        {"Hipparcos Number", "HIP 20525"},
        {"Geneva Identification System", "GEN# +1.00028331"},
        {"Smithsonian Astrophysical Observation", "SAO 249013"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.97362339),
        dec: Angle.Degrees(-63.29882854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90661"},
        {"Hipparcos Number", "HIP 51083"},
        {"Celescope Catalog", "CEL 3541"},
        {"Geneva Identification System", "GEN# +1.00090661"},
        {"Smithsonian Astrophysical Observation", "SAO 250956"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.55683263),
        dec: Angle.Degrees(-63.29859561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65908"},
        {"Hipparcos Number", "HIP 38863"},
        {"Geneva Identification System", "GEN# +1.00065908"},
        {"Smithsonian Astrophysical Observation", "SAO 250030"},
        {"Wilson Evans Batten Catalogue", "WEB 7611"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.30316882),
        dec: Angle.Degrees(-63.29688070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 578"},
        {"Hipparcos Number", "HIP 815"},
        {"Geneva Identification System", "GEN# +1.00000578"},
        {"Smithsonian Astrophysical Observation", "SAO 248132"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.51101423),
        dec: Angle.Degrees(-63.29667598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38539"},
        {"Hipparcos Number", "HIP 26855"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.52453206),
        dec: Angle.Degrees(-63.29574841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10634"},
        {"Hipparcos Number", "HIP 7926"},
        {"Smithsonian Astrophysical Observation", "SAO 248423"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.47271809),
        dec: Angle.Degrees(-63.29489215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63220"},
        {"Hipparcos Number", "HIP 37669"},
        {"Smithsonian Astrophysical Observation", "SAO 249939"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.93414577),
        dec: Angle.Degrees(-63.29246471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126731"},
        {"Hipparcos Number", "HIP 70897"},
        {"Smithsonian Astrophysical Observation", "SAO 252758"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.46474416),
        dec: Angle.Degrees(-63.28922598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131661"},
        {"Hipparcos Number", "HIP 73229"},
        {"Smithsonian Astrophysical Observation", "SAO 252970"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.49575834),
        dec: Angle.Degrees(-63.28739066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89520"},
        {"Smithsonian Astrophysical Observation", "SAO 254192"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.01182354),
        dec: Angle.Degrees(-63.28716199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116360"},
        {"Hipparcos Number", "HIP 65431"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16268805),
        dec: Angle.Degrees(-63.28639732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221509"},
        {"Hipparcos Number", "HIP 116248"},
        {"Smithsonian Astrophysical Observation", "SAO 255513"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.32682585),
        dec: Angle.Degrees(-63.28552708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1808"},
        {"Hipparcos Number", "HIP 1747"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.52173959),
        dec: Angle.Degrees(-63.28513222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11540"},
        {"Hipparcos Number", "HIP 8623"},
        {"Smithsonian Astrophysical Observation", "SAO 248452"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.80853904),
        dec: Angle.Degrees(-63.28498735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 116.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4487"},
        {"Hipparcos Number", "HIP 3594"},
        {"Smithsonian Astrophysical Observation", "SAO 248247"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.50014084),
        dec: Angle.Degrees(-63.28472846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123152"},
        {"Hipparcos Number", "HIP 69063"},
        {"Smithsonian Astrophysical Observation", "SAO 252614"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.05175316),
        dec: Angle.Degrees(-63.28241738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20658"},
        {"Hipparcos Number", "HIP 15225"},
        {"Smithsonian Astrophysical Observation", "SAO 248767"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.06733069),
        dec: Angle.Degrees(-63.28067188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59996",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59996"},
        {"Geneva Identification System", "GEN# +9.60140142"},
    },
    visualMagnitude: 9.73,
    bvColour: 2.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.57032715),
        dec: Angle.Degrees(-63.28010771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103516"},
        {"Hipparcos Number", "HIP 58103"},
        {"Celescope Catalog", "CEL 4014"},
        {"Geneva Identification System", "GEN# +1.00103516"},
        {"Smithsonian Astrophysical Observation", "SAO 251640"},
        {"Wilson Evans Batten Catalogue", "WEB 10404"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.75009496),
        dec: Angle.Degrees(-63.27917897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162314"},
        {"Hipparcos Number", "HIP 87704"},
        {"Smithsonian Astrophysical Observation", "SAO 254071"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.71526703),
        dec: Angle.Degrees(-63.27580266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25062"},
        {"Hipparcos Number", "HIP 18333"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.78661580),
        dec: Angle.Degrees(-63.27429218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43312"},
        {"Hipparcos Number", "HIP 29331"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.76457724),
        dec: Angle.Degrees(-63.27418066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12032"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.78360685),
        dec: Angle.Degrees(-57.92748651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117843"},
        {"Hipparcos Number", "HIP 66241"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.64311910),
        dec: Angle.Degrees(-63.27083880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214753"},
        {"Hipparcos Number", "HIP 112048"},
        {"Smithsonian Astrophysical Observation", "SAO 255288"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.42948630),
        dec: Angle.Degrees(-63.27015867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152082"},
        {"Hipparcos Number", "HIP 82806"},
        {"Geneva Identification System", "GEN# +1.00152082J"},
        {"Smithsonian Astrophysical Observation", "SAO 253734"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.85282694),
        dec: Angle.Degrees(-63.26962566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173344"},
        {"Hipparcos Number", "HIP 92330"},
        {"Geneva Identification System", "GEN# +1.00173344"},
        {"Renson", "Renson 48540"},
        {"Smithsonian Astrophysical Observation", "SAO 254375"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.26447387),
        dec: Angle.Degrees(-63.26954122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130366"},
        {"Hipparcos Number", "HIP 72597"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.65215395),
        dec: Angle.Degrees(-63.26831501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137505"},
        {"Hipparcos Number", "HIP 75866"},
        {"Smithsonian Astrophysical Observation", "SAO 253184"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.45249794),
        dec: Angle.Degrees(-63.26725254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211537"},
        {"Hipparcos Number", "HIP 110227"},
        {"Geneva Identification System", "GEN# +1.00211537"},
        {"Smithsonian Astrophysical Observation", "SAO 255197"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.92187523),
        dec: Angle.Degrees(-63.26682047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86254"},
        {"Hipparcos Number", "HIP 48621"},
        {"Smithsonian Astrophysical Observation", "SAO 250748"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.72386620),
        dec: Angle.Degrees(-63.26531376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153077"},
        {"Hipparcos Number", "HIP 83307"},
        {"Smithsonian Astrophysical Observation", "SAO 253771"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.38227702),
        dec: Angle.Degrees(-63.26492516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157480"},
        {"Hipparcos Number", "HIP 85448"},
        {"Smithsonian Astrophysical Observation", "SAO 253927"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.93202811),
        dec: Angle.Degrees(-63.26368453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217964"},
        {"Hipparcos Number", "HIP 114014"},
        {"Smithsonian Astrophysical Observation", "SAO 255398"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.34832147),
        dec: Angle.Degrees(-63.26336302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47545"},
        {"Hipparcos Number", "HIP 31386"},
        {"Geneva Identification System", "GEN# +1.00047545"},
        {"Smithsonian Astrophysical Observation", "SAO 249593"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.69565965),
        dec: Angle.Degrees(-63.26210367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131550"},
        {"Hipparcos Number", "HIP 73170"},
        {"Smithsonian Astrophysical Observation", "SAO 252967"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.30588060),
        dec: Angle.Degrees(-63.26058564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27657"},
        {"Hipparcos Number", "HIP 20020"},
    },
    visualMagnitude: 5.88,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.41777199),
        dec: Angle.Degrees(-63.25549171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84001"},
        {"Hipparcos Number", "HIP 47400"},
        {"Smithsonian Astrophysical Observation", "SAO 250656"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.86458154),
        dec: Angle.Degrees(-63.25506581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82899"},
    },
    visualMagnitude: 12.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)16, (int)56, 27.6300),
        dec: Angle.DegreesMinutesSeconds((int)-57, (int)51, 07.500)
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
    primaryId: "HIP 14744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20094"},
        {"Hipparcos Number", "HIP 14744"},
        {"Geneva Identification System", "GEN# +1.00020094"},
        {"Smithsonian Astrophysical Observation", "SAO 248750"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.59430003),
        dec: Angle.Degrees(-63.25387310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130455"},
        {"Hipparcos Number", "HIP 72649"},
        {"Smithsonian Astrophysical Observation", "SAO 252916"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.80895819),
        dec: Angle.Degrees(-63.25369576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199867"},
        {"Hipparcos Number", "HIP 103887"},
        {"Smithsonian Astrophysical Observation", "SAO 254926"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.74378976),
        dec: Angle.Degrees(-63.25160036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167761"},
        {"Hipparcos Number", "HIP 89928"},
        {"Smithsonian Astrophysical Observation", "SAO 254213"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.24394102),
        dec: Angle.Degrees(-63.25003687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103779"},
        {"Hipparcos Number", "HIP 58266"},
        {"Celescope Catalog", "CEL 4022"},
        {"Geneva Identification System", "GEN# +1.00103779"},
        {"Smithsonian Astrophysical Observation", "SAO 251654"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.23981873),
        dec: Angle.Degrees(-63.24909218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14540"},
        {"Hipparcos Number", "HIP 10754"},
        {"Smithsonian Astrophysical Observation", "SAO 248529"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.58594027),
        dec: Angle.Degrees(-63.24538562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88419",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88419"},
        {"Smithsonian Astrophysical Observation", "SAO 254120"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.79401900),
        dec: Angle.Degrees(-63.24484353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220700"},
        {"Hipparcos Number", "HIP 115698"},
        {"Smithsonian Astrophysical Observation", "SAO 255483"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.61550279),
        dec: Angle.Degrees(-63.23691553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151763"},
        {"Hipparcos Number", "HIP 82633"},
        {"Smithsonian Astrophysical Observation", "SAO 253726"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.37672471),
        dec: Angle.Degrees(-63.23500830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74889"},
        {"Hipparcos Number", "HIP 42796"},
        {"Smithsonian Astrophysical Observation", "SAO 250306"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.80216215),
        dec: Angle.Degrees(-63.23353636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83138"},
        {"Hipparcos Number", "HIP 46913"},
        {"Geneva Identification System", "GEN# +1.00083138"},
        {"Smithsonian Astrophysical Observation", "SAO 250623"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.43572889),
        dec: Angle.Degrees(-63.23149341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118911"},
        {"Hipparcos Number", "HIP 66826"},
        {"Smithsonian Astrophysical Observation", "SAO 252414"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.44067237),
        dec: Angle.Degrees(-63.23110873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192531"},
        {"Hipparcos Number", "HIP 100165"},
        {"Geneva Identification System", "GEN# +1.00192531"},
        {"Smithsonian Astrophysical Observation", "SAO 254772"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.76254422),
        dec: Angle.Degrees(-63.23056312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181872"},
        {"Hipparcos Number", "HIP 95571"},
        {"Geneva Identification System", "GEN# +1.00181872"},
        {"Smithsonian Astrophysical Observation", "SAO 254573"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.59612571),
        dec: Angle.Degrees(-63.22995810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30610"},
        {"Hipparcos Number", "HIP 22081"},
        {"Fundamental Katalog 5th Edition", "FK5 2356"},
        {"Geneva Identification System", "GEN# +1.00030610"},
        {"Smithsonian Astrophysical Observation", "SAO 249095"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.24130644),
        dec: Angle.Degrees(-63.22970760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106840"},
        {"Hipparcos Number", "HIP 59913"},
        {"Geneva Identification System", "GEN# +1.00106840"},
        {"Smithsonian Astrophysical Observation", "SAO 251828"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.34460244),
        dec: Angle.Degrees(-63.22698484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42803"},
        {"Hipparcos Number", "HIP 29112"},
        {"Smithsonian Astrophysical Observation", "SAO 249456"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.08620141),
        dec: Angle.Degrees(-63.22197222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30324"},
        {"Hipparcos Number", "HIP 21892"},
        {"Geneva Identification System", "GEN# +1.00030324"},
        {"Smithsonian Astrophysical Observation", "SAO 249086"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.58753044),
        dec: Angle.Degrees(-63.21568837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82379"},
        {"Hipparcos Number", "HIP 46481"},
        {"Geneva Identification System", "GEN# +1.00082379"},
        {"Smithsonian Astrophysical Observation", "SAO 250592"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.19596562),
        dec: Angle.Degrees(-63.21414638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114012"},
        {"Hipparcos Number", "HIP 64138"},
        {"Geneva Identification System", "GEN# +1.00114012"},
        {"Smithsonian Astrophysical Observation", "SAO 252168"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.16940809),
        dec: Angle.Degrees(-63.21153516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179418"},
        {"Hipparcos Number", "HIP 94732"},
        {"Smithsonian Astrophysical Observation", "SAO 254513"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.13987718),
        dec: Angle.Degrees(-63.21115466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83003"},
    },
    visualMagnitude: 10.62,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.42321971),
        dec: Angle.Degrees(-63.21047023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140004"},
        {"Hipparcos Number", "HIP 77142"},
        {"Smithsonian Astrophysical Observation", "SAO 253274"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.25291919),
        dec: Angle.Degrees(-63.20811039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123151"},
        {"Hipparcos Number", "HIP 69065"},
        {"Fundamental Katalog 5th Edition", "FK5 3121"},
        {"Geneva Identification System", "GEN# +1.00123151"},
        {"Smithsonian Astrophysical Observation", "SAO 252616"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.05947093),
        dec: Angle.Degrees(-63.20803604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33059"},
        {"Hipparcos Number", "HIP 23513"},
        {"Smithsonian Astrophysical Observation", "SAO 249178"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.83689705),
        dec: Angle.Degrees(-63.20581001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97382"},
        {"Hipparcos Number", "HIP 54669"},
        {"Geneva Identification System", "GEN# +1.00097382"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.86310444),
        dec: Angle.Degrees(-63.20571681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132826"},
        {"Hipparcos Number", "HIP 73728"},
        {"Smithsonian Astrophysical Observation", "SAO 253003"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.06861134),
        dec: Angle.Degrees(-63.20287129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10805"},
        {"Hipparcos Number", "HIP 8087"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.96224445),
        dec: Angle.Degrees(-63.20281112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106742"},
        {"Hipparcos Number", "HIP 59865"},
        {"Geneva Identification System", "GEN# +1.00106742"},
        {"Smithsonian Astrophysical Observation", "SAO 251825"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.16006667),
        dec: Angle.Degrees(-63.19792160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101190"},
        {"Hipparcos Number", "HIP 56757"},
        {"Celescope Catalog", "CEL 3937"},
        {"Geneva Identification System", "GEN# +3.29440043"},
        {"Smithsonian Astrophysical Observation", "SAO 251506"},
        {"Wilson Evans Batten Catalogue", "WEB 10212"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.54133457),
        dec: Angle.Degrees(-63.19683914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4332"},
        {"Hipparcos Number", "HIP 3517"},
        {"Smithsonian Astrophysical Observation", "SAO 248245"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.22762590),
        dec: Angle.Degrees(-63.19652630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88118",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88118"},
    },
    visualMagnitude: 12.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.95662066),
        dec: Angle.Degrees(-57.76889782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128105"},
        {"Hipparcos Number", "HIP 71525"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.43370696),
        dec: Angle.Degrees(-63.19641477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139300"},
        {"Hipparcos Number", "HIP 76805"},
        {"Geneva Identification System", "GEN# +1.00139300"},
        {"Smithsonian Astrophysical Observation", "SAO 253249"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.23517364),
        dec: Angle.Degrees(-63.19458767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15363"},
        {"Hipparcos Number", "HIP 11326"},
        {"Geneva Identification System", "GEN# +1.00015363"},
        {"Smithsonian Astrophysical Observation", "SAO 248559"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.44281160),
        dec: Angle.Degrees(-63.19405621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63550"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.33396963),
        dec: Angle.Degrees(-63.19405194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -392.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -410.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164444"},
        {"Hipparcos Number", "HIP 88607"},
        {"Smithsonian Astrophysical Observation", "SAO 254132"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.37819348),
        dec: Angle.Degrees(-63.19397925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158932"},
        {"Hipparcos Number", "HIP 86145"},
        {"Smithsonian Astrophysical Observation", "SAO 253973"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.06474393),
        dec: Angle.Degrees(-63.19345101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161657"},
        {"Hipparcos Number", "HIP 87373"},
        {"Smithsonian Astrophysical Observation", "SAO 254052"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.78300507),
        dec: Angle.Degrees(-63.19329327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46653"},
        {"Hipparcos Number", "HIP 30981"},
        {"Smithsonian Astrophysical Observation", "SAO 249567"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.53568814),
        dec: Angle.Degrees(-63.19196231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181177"},
        {"Hipparcos Number", "HIP 95321"},
        {"Geneva Identification System", "GEN# +1.00181177"},
        {"Smithsonian Astrophysical Observation", "SAO 254552"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.90251404),
        dec: Angle.Degrees(-63.19159231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75451"},
        {"Hipparcos Number", "HIP 43106"},
        {"Smithsonian Astrophysical Observation", "SAO 250325"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.67908096),
        dec: Angle.Degrees(-63.19153730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130248"},
        {"Hipparcos Number", "HIP 72542"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.46666341),
        dec: Angle.Degrees(-63.19111380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56239"},
        {"Hipparcos Number", "HIP 34780"},
        {"Geneva Identification System", "GEN# +1.00056239J"},
        {"Smithsonian Astrophysical Observation", "SAO 249774"},
    },
    visualMagnitude: 6.03,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.00825571),
        dec: Angle.Degrees(-63.19005410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218711"},
        {"Hipparcos Number", "HIP 114485"},
        {"Smithsonian Astrophysical Observation", "SAO 255423"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.79358727),
        dec: Angle.Degrees(-63.18995264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216187"},
        {"Hipparcos Number", "HIP 112924"},
        {"Geneva Identification System", "GEN# +1.00216187J"},
        {"Smithsonian Astrophysical Observation", "SAO 255339"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.04158192),
        dec: Angle.Degrees(-63.18856825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36315"},
        {"Hipparcos Number", "HIP 25441"},
        {"Geneva Identification System", "GEN# +1.00036315"},
        {"Smithsonian Astrophysical Observation", "SAO 249274"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.61928915),
        dec: Angle.Degrees(-63.18338244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75929"},
        {"Hipparcos Number", "HIP 43327"},
        {"Smithsonian Astrophysical Observation", "SAO 250341"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.41502099),
        dec: Angle.Degrees(-63.18195866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57126"},
        {"Hipparcos Number", "HIP 35118"},
        {"Smithsonian Astrophysical Observation", "SAO 249799"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.91013096),
        dec: Angle.Degrees(-63.17985503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85702"},
        {"Hipparcos Number", "HIP 48332"},
        {"Smithsonian Astrophysical Observation", "SAO 250725"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.78185074),
        dec: Angle.Degrees(-63.17759923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141625"},
        {"Hipparcos Number", "HIP 77845"},
        {"Smithsonian Astrophysical Observation", "SAO 253332"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.41788921),
        dec: Angle.Degrees(-63.17505307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35111"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.89990653),
        dec: Angle.Degrees(-63.17465798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155693"},
        {"Hipparcos Number", "HIP 84575"},
        {"Smithsonian Astrophysical Observation", "SAO 253857"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.33564957),
        dec: Angle.Degrees(-63.17436596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27917"},
        {"Hipparcos Number", "HIP 20246"},
        {"Geneva Identification System", "GEN# +1.00027917"},
        {"Smithsonian Astrophysical Observation", "SAO 248997"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.07907323),
        dec: Angle.Degrees(-63.17378083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103170"},
        {"Hipparcos Number", "HIP 57900"},
        {"Geneva Identification System", "GEN# +1.00103170"},
        {"Smithsonian Astrophysical Observation", "SAO 251621"},
        {"Wilson Evans Batten Catalogue", "WEB 10380"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.13470046),
        dec: Angle.Degrees(-63.17019924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156817"},
        {"Hipparcos Number", "HIP 85130"},
        {"Geneva Identification System", "GEN# +1.00156817"},
        {"Smithsonian Astrophysical Observation", "SAO 253901"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.97388324),
        dec: Angle.Degrees(-63.16837234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111992"},
        {"Hipparcos Number", "HIP 62959"},
        {"Smithsonian Astrophysical Observation", "SAO 252082"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.52937922),
        dec: Angle.Degrees(-63.16626695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104841"},
        {"Hipparcos Number", "HIP 58867"},
        {"Celescope Catalog", "CEL 4051"},
        {"Geneva Identification System", "GEN# +1.00104841"},
        {"Smithsonian Astrophysical Observation", "SAO 251717"},
        {"Wilson Evans Batten Catalogue", "WEB 10484"},
    },
    visualMagnitude: 4.72,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.08015725),
        dec: Angle.Degrees(-63.16571094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90966"},
        {"Hipparcos Number", "HIP 51265"},
        {"Celescope Catalog", "CEL 3550"},
        {"Geneva Identification System", "GEN# +1.00090966"},
        {"Smithsonian Astrophysical Observation", "SAO 250969"},
        {"Wilson Evans Batten Catalogue", "WEB 9368"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.07617385),
        dec: Angle.Degrees(-63.16457309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24567"},
        {"Hipparcos Number", "HIP 17992"},
        {"Smithsonian Astrophysical Observation", "SAO 248893"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.68302388),
        dec: Angle.Degrees(-63.16393533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1208"},
        {"Hipparcos Number", "HIP 1293"},
        {"Smithsonian Astrophysical Observation", "SAO 248147"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.04542960),
        dec: Angle.Degrees(-63.16203624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192397"},
        {"Hipparcos Number", "HIP 100091"},
        {"Smithsonian Astrophysical Observation", "SAO 254768"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.58098995),
        dec: Angle.Degrees(-63.16064038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26892"},
        {"Hipparcos Number", "HIP 19530"},
        {"Geneva Identification System", "GEN# +1.00026892"},
        {"Renson", "Renson 6850"},
        {"Smithsonian Astrophysical Observation", "SAO 248959"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.76569319),
        dec: Angle.Degrees(-63.16059632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125466"},
        {"Hipparcos Number", "HIP 70215"},
        {"Geneva Identification System", "GEN# +1.00125466"},
        {"Smithsonian Astrophysical Observation", "SAO 252718"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.48163979),
        dec: Angle.Degrees(-63.15875603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212199"},
        {"Hipparcos Number", "HIP 110593"},
        {"Smithsonian Astrophysical Observation", "SAO 255211"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.07316530),
        dec: Angle.Degrees(-63.15626889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122711"},
        {"Hipparcos Number", "HIP 68829"},
        {"Geneva Identification System", "GEN# +1.00122711"},
        {"Smithsonian Astrophysical Observation", "SAO 252591"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.40632762),
        dec: Angle.Degrees(-63.15528607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169714"},
        {"Hipparcos Number", "HIP 90703"},
        {"Smithsonian Astrophysical Observation", "SAO 254265"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.58853577),
        dec: Angle.Degrees(-63.15183436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85424"},
        {"Hipparcos Number", "HIP 48181"},
        {"Geneva Identification System", "GEN# +1.00085424"},
        {"Smithsonian Astrophysical Observation", "SAO 250707"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.31359253),
        dec: Angle.Degrees(-63.15174338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149319"},
        {"Hipparcos Number", "HIP 81436"},
        {"Smithsonian Astrophysical Observation", "SAO 253633"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.50152461),
        dec: Angle.Degrees(-63.14896298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33539"},
        {"Hipparcos Number", "HIP 23781"},
        {"Geneva Identification System", "GEN# +1.00033539"},
        {"Smithsonian Astrophysical Observation", "SAO 249193"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.65999986),
        dec: Angle.Degrees(-63.14861294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7692"},
        {"Hipparcos Number", "HIP 5873"},
        {"Smithsonian Astrophysical Observation", "SAO 248344"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.84860061),
        dec: Angle.Degrees(-63.14764405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118094"},
        {"Hipparcos Number", "HIP 66372"},
        {"Geneva Identification System", "GEN# +1.00118094"},
        {"Smithsonian Astrophysical Observation", "SAO 252381"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.08747257),
        dec: Angle.Degrees(-63.14567596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158294"},
        {"Hipparcos Number", "HIP 85856"},
        {"Smithsonian Astrophysical Observation", "SAO 253954"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.17728412),
        dec: Angle.Degrees(-63.14519493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147922"},
        {"Hipparcos Number", "HIP 80707"},
        {"Renson", "Renson 41750"},
        {"Smithsonian Astrophysical Observation", "SAO 253565"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.17222931),
        dec: Angle.Degrees(-63.14344722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101795"},
        {"Hipparcos Number", "HIP 57108"},
        {"Celescope Catalog", "CEL 3955"},
        {"Geneva Identification System", "GEN# +1.00101795"},
        {"Smithsonian Astrophysical Observation", "SAO 251547"},
        {"Wilson Evans Batten Catalogue", "WEB 10280"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.60885795),
        dec: Angle.Degrees(-63.14237551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124652"},
        {"Hipparcos Number", "HIP 69813"},
        {"Smithsonian Astrophysical Observation", "SAO 252685"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.32371155),
        dec: Angle.Degrees(-63.13831035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49285"},
        {"Hipparcos Number", "HIP 32199"},
        {"Smithsonian Astrophysical Observation", "SAO 249632"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.82029489),
        dec: Angle.Degrees(-63.13612922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197069"},
        {"Hipparcos Number", "HIP 102375"},
        {"Geneva Identification System", "GEN# +1.00197069"},
        {"Smithsonian Astrophysical Observation", "SAO 254860"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.14918417),
        dec: Angle.Degrees(-63.13578645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81157"},
        {"Geneva Identification System", "GEN# -0.06205377"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.62873774),
        dec: Angle.Degrees(-63.13353182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112169"},
        {"Hipparcos Number", "HIP 63074"},
        {"Geneva Identification System", "GEN# +1.00112169"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.86734087),
        dec: Angle.Degrees(-63.13256515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140045"},
        {"Hipparcos Number", "HIP 77158"},
        {"Geneva Identification System", "GEN# +1.00140045"},
        {"Smithsonian Astrophysical Observation", "SAO 253278"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.30629101),
        dec: Angle.Degrees(-63.13184584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66109"},
        {"Hipparcos Number", "HIP 38960"},
        {"Geneva Identification System", "GEN# +1.00066109"},
        {"Smithsonian Astrophysical Observation", "SAO 250049"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.57304868),
        dec: Angle.Degrees(-63.13159545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188357"},
        {"Hipparcos Number", "HIP 98312"},
        {"Smithsonian Astrophysical Observation", "SAO 254697"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.63535147),
        dec: Angle.Degrees(-63.12796325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123656"},
        {"Hipparcos Number", "HIP 69309"},
        {"Geneva Identification System", "GEN# +1.00123656"},
        {"Smithsonian Astrophysical Observation", "SAO 252642"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.80017213),
        dec: Angle.Degrees(-63.12527933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147349"},
        {"Hipparcos Number", "HIP 80455"},
        {"Geneva Identification System", "GEN# +1.00147349"},
        {"Smithsonian Astrophysical Observation", "SAO 253539"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.34229561),
        dec: Angle.Degrees(-63.12523806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106795"},
        {"Hipparcos Number", "HIP 59896"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.26947436),
        dec: Angle.Degrees(-63.12471693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178766"},
        {"Hipparcos Number", "HIP 94493"},
        {"Smithsonian Astrophysical Observation", "SAO 254500"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.49170552),
        dec: Angle.Degrees(-63.12246730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195772"},
        {"Hipparcos Number", "HIP 101684"},
        {"Geneva Identification System", "GEN# +1.00195772"},
        {"Smithsonian Astrophysical Observation", "SAO 254827"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.15969219),
        dec: Angle.Degrees(-63.12076434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54796"},
        {"Hipparcos Number", "HIP 34245"},
        {"Smithsonian Astrophysical Observation", "SAO 249735"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.49059697),
        dec: Angle.Degrees(-63.11577117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209478"},
        {"Hipparcos Number", "HIP 109094"},
        {"Smithsonian Astrophysical Observation", "SAO 255141"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.48487226),
        dec: Angle.Degrees(-63.11545493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124385"},
        {"Hipparcos Number", "HIP 69670"},
        {"Smithsonian Astrophysical Observation", "SAO 252672"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.90867287),
        dec: Angle.Degrees(-63.11400068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162771"},
        {"Hipparcos Number", "HIP 87868"},
        {"Smithsonian Astrophysical Observation", "SAO 254083"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.23466233),
        dec: Angle.Degrees(-63.11273599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131857"},
        {"Hipparcos Number", "HIP 73322"},
        {"Smithsonian Astrophysical Observation", "SAO 252981"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.74434079),
        dec: Angle.Degrees(-63.11241064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71635"},
        {"Hipparcos Number", "HIP 41245"},
        {"Smithsonian Astrophysical Observation", "SAO 250218"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.23129669),
        dec: Angle.Degrees(-63.11231042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221006"},
        {"Hipparcos Number", "HIP 115908"},
        {"Fundamental Katalog 5th Edition", "FK5 3880"},
        {"Geneva Identification System", "GEN# +1.00221006"},
        {"Renson", "Renson 60580"},
        {"Smithsonian Astrophysical Observation", "SAO 255497"},
        {"Wilson Evans Batten Catalogue", "WEB 20498"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.25387551),
        dec: Angle.Degrees(-63.11062274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141488"},
        {"Hipparcos Number", "HIP 77784"},
        {"Smithsonian Astrophysical Observation", "SAO 253325"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.23561122),
        dec: Angle.Degrees(-63.11039491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86411"},
        {"Hipparcos Number", "HIP 48707"},
        {"Smithsonian Astrophysical Observation", "SAO 250753"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.02258685),
        dec: Angle.Degrees(-63.11030427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204355"},
        {"Hipparcos Number", "HIP 106196"},
        {"Smithsonian Astrophysical Observation", "SAO 255010"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.66188767),
        dec: Angle.Degrees(-63.10679535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207802"},
        {"Hipparcos Number", "HIP 108093"},
        {"Smithsonian Astrophysical Observation", "SAO 255097"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.49698251),
        dec: Angle.Degrees(-63.10383243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200826"},
        {"Hipparcos Number", "HIP 104392"},
        {"Smithsonian Astrophysical Observation", "SAO 254943"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.22370445),
        dec: Angle.Degrees(-63.10321487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114718"},
        {"Hipparcos Number", "HIP 64529"},
        {"Geneva Identification System", "GEN# +1.00114718"},
        {"Smithsonian Astrophysical Observation", "SAO 252207"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.39644458),
        dec: Angle.Degrees(-63.10273883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210205"},
        {"Hipparcos Number", "HIP 109491"},
        {"Geneva Identification System", "GEN# +1.00210205"},
        {"Smithsonian Astrophysical Observation", "SAO 255163"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.71320495),
        dec: Angle.Degrees(-63.09941171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60718",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Acrux"},
        {"Hipparcos Number", "HIP 60718"},
        {"Celescope Catalog", "CEL 4105"},
        {"Geneva Identification System", "GEN# +1.00108248"},
    },
    visualMagnitude: 0.77,
    bvColour: -0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.64975585),
        dec: Angle.Degrees(-63.09905586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194295"},
        {"Hipparcos Number", "HIP 100974"},
        {"Geneva Identification System", "GEN# +1.00194295"},
        {"Smithsonian Astrophysical Observation", "SAO 254797"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.09864488),
        dec: Angle.Degrees(-63.09735267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27606"},
        {"Hipparcos Number", "HIP 19995"},
        {"Fundamental Katalog 5th Edition", "FK5 4394"},
        {"Geneva Identification System", "GEN# +1.00027606"},
        {"Smithsonian Astrophysical Observation", "SAO 248982"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.32288346),
        dec: Angle.Degrees(-63.09591756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156647"},
        {"Hipparcos Number", "HIP 85062"},
        {"Smithsonian Astrophysical Observation", "SAO 253893"},
    },
    visualMagnitude: 8.79,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.76017708),
        dec: Angle.Degrees(-63.09486922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40409"},
        {"Hipparcos Number", "HIP 27890"},
        {"Cincinnati Publication", "Ci 20 360"},
        {"Fundamental Katalog 5th Edition", "FK5 2452"},
        {"Geneva Identification System", "GEN# +1.00040409"},
        {"Smithsonian Astrophysical Observation", "SAO 249390"},
        {"Wilson Evans Batten Catalogue", "WEB 5460"},
    },
    visualMagnitude: 4.65,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.52458376),
        dec: Angle.Degrees(-63.09102096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 573.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2540"},
        {"Smithsonian Astrophysical Observation", "SAO 248205"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.06139856),
        dec: Angle.Degrees(-63.09101331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 530.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94466"},
        {"Hipparcos Number", "HIP 53210"},
        {"Smithsonian Astrophysical Observation", "SAO 251162"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.25478771),
        dec: Angle.Degrees(-63.08779986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311884"},
        {"Hipparcos Number", "HIP 62115"},
        {"Wilson Evans Batten Catalogue", "WEB 11041"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.96252914),
        dec: Angle.Degrees(-63.08744720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56320"},
        {"Hipparcos Number", "HIP 34808"},
        {"Smithsonian Astrophysical Observation", "SAO 249777"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.08132336),
        dec: Angle.Degrees(-63.08581189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217453"},
        {"Hipparcos Number", "HIP 113725"},
        {"Smithsonian Astrophysical Observation", "SAO 255378"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.47934180),
        dec: Angle.Degrees(-63.08555169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51660"},
        {"Hipparcos Number", "HIP 33135"},
        {"Smithsonian Astrophysical Observation", "SAO 249672"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.49266860),
        dec: Angle.Degrees(-63.07914644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 309120"},
        {"Hipparcos Number", "HIP 57649"},
        {"Wilson Evans Batten Catalogue", "WEB 10355"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.31677491),
        dec: Angle.Degrees(-63.07859020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11990"},
        {"Hipparcos Number", "HIP 8965"},
        {"Smithsonian Astrophysical Observation", "SAO 248463"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.86790135),
        dec: Angle.Degrees(-63.07724235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20795"},
        {"Hipparcos Number", "HIP 15325"},
        {"Smithsonian Astrophysical Observation", "SAO 248771"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.42109558),
        dec: Angle.Degrees(-63.07705763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81280"},
        {"Hipparcos Number", "HIP 45923"},
        {"Smithsonian Astrophysical Observation", "SAO 250553"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.46205978),
        dec: Angle.Degrees(-63.07469056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35403"},
        {"Hipparcos Number", "HIP 24887"},
        {"Smithsonian Astrophysical Observation", "SAO 249251"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.01961888),
        dec: Angle.Degrees(-63.07285857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12910",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12910"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.49435118),
        dec: Angle.Degrees(-63.07065140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123320"},
        {"Hipparcos Number", "HIP 69134"},
        {"Geneva Identification System", "GEN# +1.00123320"},
        {"Smithsonian Astrophysical Observation", "SAO 252623"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.28253119),
        dec: Angle.Degrees(-63.06869509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95993"},
        {"Hipparcos Number", "HIP 54026"},
        {"Smithsonian Astrophysical Observation", "SAO 251240"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.80352505),
        dec: Angle.Degrees(-63.06663581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56911"},
        {"Hipparcos Number", "HIP 35028"},
        {"Smithsonian Astrophysical Observation", "SAO 249795"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.67738720),
        dec: Angle.Degrees(-63.06439206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138452"},
        {"Hipparcos Number", "HIP 76348"},
        {"Smithsonian Astrophysical Observation", "SAO 253217"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.91043002),
        dec: Angle.Degrees(-63.06265199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116121"},
        {"Hipparcos Number", "HIP 65307"},
        {"Geneva Identification System", "GEN# +1.00116121"},
        {"Smithsonian Astrophysical Observation", "SAO 252286"},
    },
    visualMagnitude: 9.22,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.76584231),
        dec: Angle.Degrees(-63.06176905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3175"},
        {"Hipparcos Number", "HIP 2702"},
        {"Geneva Identification System", "GEN# +1.00003175"},
        {"Smithsonian Astrophysical Observation", "SAO 248214"},
    },
    visualMagnitude: 9.32,
    bvColour: -0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.59331033),
        dec: Angle.Degrees(-63.06165778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189721"},
        {"Hipparcos Number", "HIP 98919"},
        {"Smithsonian Astrophysical Observation", "SAO 254722"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.28664997),
        dec: Angle.Degrees(-63.06147473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36036"},
        {"Smithsonian Astrophysical Observation", "SAO 249850"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.39871075),
        dec: Angle.Degrees(-63.06040369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110432"},
        {"Hipparcos Number", "HIP 62027"},
        {"Celescope Catalog", "CEL 4145"},
        {"Fundamental Katalog 5th Edition", "FK5 3015"},
        {"Geneva Identification System", "GEN# +1.00110432"},
        {"Smithsonian Astrophysical Observation", "SAO 252002"},
        {"Wilson Evans Batten Catalogue", "WEB 11028"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.70951152),
        dec: Angle.Degrees(-63.05861600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183470"},
        {"Hipparcos Number", "HIP 96209"},
        {"Geneva Identification System", "GEN# +1.00183470"},
        {"Smithsonian Astrophysical Observation", "SAO 254594"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.44757893),
        dec: Angle.Degrees(-63.05820987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145270"},
        {"Hipparcos Number", "HIP 79550"},
        {"Smithsonian Astrophysical Observation", "SAO 253466"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.48228969),
        dec: Angle.Degrees(-63.05780665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166599"},
        {"Hipparcos Number", "HIP 89487"},
        {"Geneva Identification System", "GEN# +1.00166599"},
        {"Smithsonian Astrophysical Observation", "SAO 254189"},
        {"Wilson Evans Batten Catalogue", "WEB 15229"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.91942956),
        dec: Angle.Degrees(-63.05530804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92335"},
        {"Hipparcos Number", "HIP 52044"},
        {"Geneva Identification System", "GEN# +1.00092335"},
        {"Smithsonian Astrophysical Observation", "SAO 251041"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.52588038),
        dec: Angle.Degrees(-63.05521285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202458"},
        {"Hipparcos Number", "HIP 105227"},
        {"Geneva Identification System", "GEN# +1.00202458"},
        {"Smithsonian Astrophysical Observation", "SAO 254972"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.72476543),
        dec: Angle.Degrees(-63.04924394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204479"},
        {"Hipparcos Number", "HIP 106277"},
        {"Smithsonian Astrophysical Observation", "SAO 255013"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.88873046),
        dec: Angle.Degrees(-63.04871691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77033"},
        {"Hipparcos Number", "HIP 43909"},
        {"Smithsonian Astrophysical Observation", "SAO 250390"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.17630352),
        dec: Angle.Degrees(-63.04849194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222215"},
        {"Hipparcos Number", "HIP 116708"},
        {"Smithsonian Astrophysical Observation", "SAO 255536"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.77583548),
        dec: Angle.Degrees(-63.04595029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 307666"},
        {"Hipparcos Number", "HIP 50765"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.49905627),
        dec: Angle.Degrees(-63.04585657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185953"},
        {"Hipparcos Number", "HIP 97224"},
        {"Smithsonian Astrophysical Observation", "SAO 254641"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.40085261),
        dec: Angle.Degrees(-63.04180090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169884"},
        {"Hipparcos Number", "HIP 90758"},
        {"Geneva Identification System", "GEN# +1.00169884"},
        {"Smithsonian Astrophysical Observation", "SAO 254269"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.76147555),
        dec: Angle.Degrees(-63.04101241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164024"},
        {"Hipparcos Number", "HIP 88449"},
        {"Smithsonian Astrophysical Observation", "SAO 254125"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.88032142),
        dec: Angle.Degrees(-63.04100336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139071"},
        {"Hipparcos Number", "HIP 76685"},
        {"Smithsonian Astrophysical Observation", "SAO 253243"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.89057813),
        dec: Angle.Degrees(-63.04004660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61415"},
        {"Hipparcos Number", "HIP 36891"},
        {"Smithsonian Astrophysical Observation", "SAO 249887"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.76998347),
        dec: Angle.Degrees(-63.03968098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21516"},
        {"Hipparcos Number", "HIP 15893"},
        {"Smithsonian Astrophysical Observation", "SAO 248798"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.17852175),
        dec: Angle.Degrees(-63.03828990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115625"},
        {"Hipparcos Number", "HIP 65022"},
        {"Geneva Identification System", "GEN# +1.00115625"},
        {"Smithsonian Astrophysical Observation", "SAO 252264"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.93365256),
        dec: Angle.Degrees(-63.03628453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157524"},
        {"Hipparcos Number", "HIP 85480"},
        {"Geneva Identification System", "GEN# +1.00157524"},
        {"Smithsonian Astrophysical Observation", "SAO 253928"},
        {"Wilson Evans Batten Catalogue", "WEB 14436"},
    },
    visualMagnitude: 6.22,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.03282619),
        dec: Angle.Degrees(-63.03618478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18675"},
        {"Hipparcos Number", "HIP 13751"},
        {"Smithsonian Astrophysical Observation", "SAO 248692"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.25517093),
        dec: Angle.Degrees(-63.03495116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134345"},
        {"Hipparcos Number", "HIP 74415"},
        {"Geneva Identification System", "GEN# +1.00134345"},
        {"Smithsonian Astrophysical Observation", "SAO 253052"},
        {"Wilson Evans Batten Catalogue", "WEB 12700"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.12358394),
        dec: Angle.Degrees(-63.03346083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3003"},
        {"Hipparcos Number", "HIP 2578"},
        {"Geneva Identification System", "GEN# +1.00003003"},
        {"Smithsonian Astrophysical Observation", "SAO 248208"},
        {"Wilson Evans Batten Catalogue", "WEB 473"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.18247614),
        dec: Angle.Degrees(-63.03137868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29383"},
        {"Hipparcos Number", "HIP 21252"},
        {"Geneva Identification System", "GEN# +1.00029383"},
        {"Smithsonian Astrophysical Observation", "SAO 249053"},
        {"Wilson Evans Batten Catalogue", "WEB 4083"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.38672805),
        dec: Angle.Degrees(-63.02920473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136489"},
        {"Hipparcos Number", "HIP 75381"},
        {"Smithsonian Astrophysical Observation", "SAO 253144"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.05925679),
        dec: Angle.Degrees(-63.02371998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112911"},
        {"Hipparcos Number", "HIP 63534"},
        {"Smithsonian Astrophysical Observation", "SAO 252126"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.29216182),
        dec: Angle.Degrees(-63.02315914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85394"},
        {"Hipparcos Number", "HIP 48166"},
        {"Smithsonian Astrophysical Observation", "SAO 250706"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.26510992),
        dec: Angle.Degrees(-63.02230008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168740"},
        {"Hipparcos Number", "HIP 90304"},
        {"Geneva Identification System", "GEN# +1.00168740"},
        {"Smithsonian Astrophysical Observation", "SAO 254237"},
        {"Wilson Evans Batten Catalogue", "WEB 15452"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.38178872),
        dec: Angle.Degrees(-63.02128653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39656"},
        {"Hipparcos Number", "HIP 27508"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.37456511),
        dec: Angle.Degrees(-63.02104175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137164"},
        {"Hipparcos Number", "HIP 75689"},
        {"Geneva Identification System", "GEN# +1.00137164"},
        {"Smithsonian Astrophysical Observation", "SAO 253175"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.94060769),
        dec: Angle.Degrees(-63.02058313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100841"},
        {"Hipparcos Number", "HIP 56561"},
        {"Celescope Catalog", "CEL 3921"},
        {"Fundamental Katalog 5th Edition", "FK5 436"},
        {"Geneva Identification System", "GEN# +1.00100841A"},
        {"Smithsonian Astrophysical Observation", "SAO 251472"},
        {"Wilson Evans Batten Catalogue", "WEB 10166"},
    },
    visualMagnitude: 3.11,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.94553448),
        dec: Angle.Degrees(-63.01982488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127145"},
        {"Hipparcos Number", "HIP 71093"},
        {"Smithsonian Astrophysical Observation", "SAO 252775"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.07925631),
        dec: Angle.Degrees(-63.01474884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93058"},
        {"Hipparcos Number", "HIP 52448"},
        {"Smithsonian Astrophysical Observation", "SAO 251088"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.83053254),
        dec: Angle.Degrees(-63.00885837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211332"},
        {"Hipparcos Number", "HIP 110102"},
        {"Smithsonian Astrophysical Observation", "SAO 255189"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.55041891),
        dec: Angle.Degrees(-63.00620172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -223.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18408"},
        {"Hipparcos Number", "HIP 13541"},
        {"Smithsonian Astrophysical Observation", "SAO 248680"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.59620587),
        dec: Angle.Degrees(-63.00578453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16078"},
        {"Hipparcos Number", "HIP 11799"},
        {"Geneva Identification System", "GEN# +1.00016078"},
        {"Smithsonian Astrophysical Observation", "SAO 248590"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.05432347),
        dec: Angle.Degrees(-63.00549854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124879"},
        {"Hipparcos Number", "HIP 69909"},
        {"Geneva Identification System", "GEN# +1.00124879J"},
        {"Smithsonian Astrophysical Observation", "SAO 252694"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.61185647),
        dec: Angle.Degrees(-63.00497816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21772"},
        {"Smithsonian Astrophysical Observation", "SAO 249076"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.14389272),
        dec: Angle.Degrees(-63.00415140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175587"},
        {"Hipparcos Number", "HIP 93304"},
        {"Geneva Identification System", "GEN# +1.00175587"},
        {"Smithsonian Astrophysical Observation", "SAO 254431"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.06743034),
        dec: Angle.Degrees(-63.00317400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224472"},
        {"Hipparcos Number", "HIP 118179"},
        {"Smithsonian Astrophysical Observation", "SAO 255612"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.59022663),
        dec: Angle.Degrees(-63.00312343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44216",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44216"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.09623035),
        dec: Angle.Degrees(-63.00092534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65908",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 10.18,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)30, 37.8100),
        dec: Angle.DegreesMinutesSeconds((int)-62, (int)59, 54.000)
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
    primaryId: "HIP 95385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181351"},
        {"Hipparcos Number", "HIP 95385"},
        {"Geneva Identification System", "GEN# +1.00181351"},
        {"Smithsonian Astrophysical Observation", "SAO 254558"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.05314349),
        dec: Angle.Degrees(-62.99824562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78843"},
        {"Hipparcos Number", "HIP 44762"},
        {"Smithsonian Astrophysical Observation", "SAO 250448"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.84308730),
        dec: Angle.Degrees(-62.99695796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62000",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62000"},
        {"Geneva Identification System", "GEN# +2.46090003"},
        {"New General Catalogue", "NGC 4609 3"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.59860630),
        dec: Angle.Degrees(-62.99535795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77554"},
        {"Hipparcos Number", "HIP 44194"},
        {"Smithsonian Astrophysical Observation", "SAO 250414"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.02973594),
        dec: Angle.Degrees(-62.99441125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61997"},
        {"Geneva Identification System", "GEN# +2.46090002"},
        {"Smithsonian Astrophysical Observation", "SAO 251998"},
        {"New General Catalogue", "NGC 4609 2"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.58235540),
        dec: Angle.Degrees(-62.99381231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19320"},
        {"Hipparcos Number", "HIP 14212"},
        {"Smithsonian Astrophysical Observation", "SAO 248715"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.81188443),
        dec: Angle.Degrees(-62.99315976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113754"},
        {"Hipparcos Number", "HIP 64018"},
        {"Geneva Identification System", "GEN# +1.00113754"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.76832348),
        dec: Angle.Degrees(-62.99179237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162464"},
        {"Hipparcos Number", "HIP 87754"},
        {"Smithsonian Astrophysical Observation", "SAO 254076"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.87816677),
        dec: Angle.Degrees(-62.99097862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97530"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.33761469),
        dec: Angle.Degrees(-62.98819234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -500.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35199"},
        {"Hipparcos Number", "HIP 24779"},
        {"Smithsonian Astrophysical Observation", "SAO 249244"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.68305734),
        dec: Angle.Degrees(-62.98491915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8343"},
        {"Hipparcos Number", "HIP 6320"},
        {"Smithsonian Astrophysical Observation", "SAO 248368"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.28919613),
        dec: Angle.Degrees(-62.98204541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144231"},
        {"Hipparcos Number", "HIP 79079"},
        {"Geneva Identification System", "GEN# +1.00144231"},
        {"Renson", "Renson 40860"},
        {"Smithsonian Astrophysical Observation", "SAO 253437"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.13741423),
        dec: Angle.Degrees(-62.98185117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88371"},
        {"Geneva Identification System", "GEN# +6.20145007"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.67958183),
        dec: Angle.Degrees(-62.97869735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -281.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185749"},
        {"Hipparcos Number", "HIP 97140"},
        {"Smithsonian Astrophysical Observation", "SAO 254639"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.14365264),
        dec: Angle.Degrees(-62.97789815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105016"},
        {"Hipparcos Number", "HIP 58960"},
        {"Geneva Identification System", "GEN# +1.00105016"},
        {"Renson", "Renson 30410"},
        {"Smithsonian Astrophysical Observation", "SAO 251730"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.34587712),
        dec: Angle.Degrees(-62.97576444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98386"},
        {"Hipparcos Number", "HIP 55202"},
        {"Smithsonian Astrophysical Observation", "SAO 251350"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.53878908),
        dec: Angle.Degrees(-62.97534196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196831"},
        {"Hipparcos Number", "HIP 102250"},
        {"Smithsonian Astrophysical Observation", "SAO 254855"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.77674872),
        dec: Angle.Degrees(-62.97518968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98410"},
        {"Hipparcos Number", "HIP 55207"},
        {"Geneva Identification System", "GEN# +1.00098410"},
        {"Smithsonian Astrophysical Observation", "SAO 251351"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.57645426),
        dec: Angle.Degrees(-62.97457629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36558"},
    },
    visualMagnitude: 11.52,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.80633578),
        dec: Angle.Degrees(-62.97244308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142221"},
        {"Hipparcos Number", "HIP 78108"},
        {"Smithsonian Astrophysical Observation", "SAO 253355"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.23257805),
        dec: Angle.Degrees(-62.97139946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173082"},
        {"Hipparcos Number", "HIP 92230"},
        {"Smithsonian Astrophysical Observation", "SAO 254371"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.94493236),
        dec: Angle.Degrees(-62.97052744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205097"},
        {"Hipparcos Number", "HIP 106618"},
        {"Geneva Identification System", "GEN# +1.00205097"},
        {"Smithsonian Astrophysical Observation", "SAO 255030"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.92619277),
        dec: Angle.Degrees(-62.96864505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144481"},
        {"Hipparcos Number", "HIP 79208"},
        {"Geneva Identification System", "GEN# +1.00144481"},
        {"Renson", "Renson 40980"},
        {"Smithsonian Astrophysical Observation", "SAO 253444"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.49664072),
        dec: Angle.Degrees(-62.96700696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129092"},
        {"Hipparcos Number", "HIP 72000"},
        {"Geneva Identification System", "GEN# +1.00129092"},
        {"Smithsonian Astrophysical Observation", "SAO 252860"},
        {"Wilson Evans Batten Catalogue", "WEB 12394"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.86727519),
        dec: Angle.Degrees(-62.96665949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193906"},
        {"Hipparcos Number", "HIP 100799"},
        {"Smithsonian Astrophysical Observation", "SAO 254791"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.56929769),
        dec: Angle.Degrees(-62.96646932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8986"},
        {"Hipparcos Number", "HIP 6755"},
        {"Smithsonian Astrophysical Observation", "SAO 248384"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.73595373),
        dec: Angle.Degrees(-62.96619572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2885"},
        {"Hipparcos Number", "HIP 2487"},
        {"Geneva Identification System", "GEN# +1.00002885"},
        {"Smithsonian Astrophysical Observation", "SAO 248202"},
        {"Wilson Evans Batten Catalogue", "WEB 455"},
    },
    visualMagnitude: 4.53,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.88898014),
        dec: Angle.Degrees(-62.96544985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121531"},
        {"Hipparcos Number", "HIP 68222"},
        {"Smithsonian Astrophysical Observation", "SAO 252533"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.49461126),
        dec: Angle.Degrees(-62.96434182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17755"},
        {"Hipparcos Number", "HIP 13074"},
        {"Geneva Identification System", "GEN# +1.00017755"},
        {"Smithsonian Astrophysical Observation", "SAO 248652"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.00509581),
        dec: Angle.Degrees(-62.96388656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96195"},
        {"Hipparcos Number", "HIP 54130"},
        {"Smithsonian Astrophysical Observation", "SAO 251247"},
    },
    visualMagnitude: 8.57,
    bvColour: 2.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.12152065),
        dec: Angle.Degrees(-62.96215003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192197"},
        {"Hipparcos Number", "HIP 100004"},
        {"Smithsonian Astrophysical Observation", "SAO 254766"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.32737210),
        dec: Angle.Degrees(-62.95990553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99341"},
        {"Hipparcos Number", "HIP 55725"},
        {"Smithsonian Astrophysical Observation", "SAO 251398"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.27370444),
        dec: Angle.Degrees(-62.95988884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38539"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.37841892),
        dec: Angle.Degrees(-62.95924056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 267.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2884"},
        {"Hipparcos Number", "HIP 2484"},
        {"Geneva Identification System", "GEN# +1.00002884"},
        {"Smithsonian Astrophysical Observation", "SAO 248201"},
        {"Wilson Evans Batten Catalogue", "WEB 454"},
    },
    visualMagnitude: 4.36,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.88566992),
        dec: Angle.Degrees(-62.95808549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11440"},
        {"Hipparcos Number", "HIP 8561"},
        {"Smithsonian Astrophysical Observation", "SAO 248447"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.60658565),
        dec: Angle.Degrees(-62.95789733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224361"},
        {"Hipparcos Number", "HIP 118092"},
        {"Fundamental Katalog 5th Edition", "FK5 3924"},
        {"Geneva Identification System", "GEN# +1.00224361"},
        {"Renson", "Renson 61460"},
        {"Smithsonian Astrophysical Observation", "SAO 255606"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.33241721),
        dec: Angle.Degrees(-62.95661191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122144"},
        {"Hipparcos Number", "HIP 68556"},
        {"Geneva Identification System", "GEN# +1.00122144"},
        {"Smithsonian Astrophysical Observation", "SAO 252564"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.50398576),
        dec: Angle.Degrees(-62.95566800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44275"},
    },
    visualMagnitude: 10.16,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.23424184),
        dec: Angle.Degrees(-56.95841612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158818"},
        {"Hipparcos Number", "HIP 86095"},
        {"Smithsonian Astrophysical Observation", "SAO 253968"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.91985529),
        dec: Angle.Degrees(-62.95356924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106068"},
        {"Hipparcos Number", "HIP 59517"},
        {"Celescope Catalog", "CEL 4069"},
        {"Geneva Identification System", "GEN# +1.00106068"},
        {"Smithsonian Astrophysical Observation", "SAO 251790"},
        {"Wilson Evans Batten Catalogue", "WEB 10582"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.09161030),
        dec: Angle.Degrees(-62.95077296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150797"},
        {"Hipparcos Number", "HIP 82168"},
        {"Smithsonian Astrophysical Observation", "SAO 253694"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.82341149),
        dec: Angle.Degrees(-62.94997450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61978"},
        {"Geneva Identification System", "GEN# +2.46090013"},
        {"New General Catalogue", "NGC 4609 13"},
    },
    visualMagnitude: 11.22,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.51536401),
        dec: Angle.Degrees(-62.94722603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100199"},
        {"Hipparcos Number", "HIP 56191"},
        {"Celescope Catalog", "CEL 3909"},
        {"Geneva Identification System", "GEN# +1.00100199"},
        {"Smithsonian Astrophysical Observation", "SAO 251434"},
        {"Wilson Evans Batten Catalogue", "WEB 10093"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.77882799),
        dec: Angle.Degrees(-62.94692786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200706"},
        {"Hipparcos Number", "HIP 104323"},
        {"Smithsonian Astrophysical Observation", "SAO 254940"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.00267209),
        dec: Angle.Degrees(-62.94623233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167736"},
        {"Hipparcos Number", "HIP 89916"},
        {"Geneva Identification System", "GEN# +1.00167736"},
        {"Smithsonian Astrophysical Observation", "SAO 254212"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.21663999),
        dec: Angle.Degrees(-62.94609067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79464"},
        {"Hipparcos Number", "HIP 45103"},
        {"Smithsonian Astrophysical Observation", "SAO 250472"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.82586785),
        dec: Angle.Degrees(-62.94568003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157560"},
        {"Hipparcos Number", "HIP 85484"},
        {"Smithsonian Astrophysical Observation", "SAO 253931"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.05599909),
        dec: Angle.Degrees(-62.94532734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166250"},
        {"Hipparcos Number", "HIP 89359"},
        {"Smithsonian Astrophysical Observation", "SAO 254177"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.51573410),
        dec: Angle.Degrees(-62.94451979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134527"},
        {"Hipparcos Number", "HIP 74511"},
        {"Geneva Identification System", "GEN# +1.00134527"},
        {"Smithsonian Astrophysical Observation", "SAO 253061"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.39475976),
        dec: Angle.Degrees(-62.94381003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84046"},
        {"Hipparcos Number", "HIP 47422"},
        {"Geneva Identification System", "GEN# +1.00084046"},
        {"Renson", "Renson 24000"},
        {"Smithsonian Astrophysical Observation", "SAO 250657"},
    },
    visualMagnitude: 6.40,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.93812076),
        dec: Angle.Degrees(-62.94296853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214633"},
        {"Hipparcos Number", "HIP 111993"},
        {"Smithsonian Astrophysical Observation", "SAO 255284"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.26814958),
        dec: Angle.Degrees(-62.94237551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128322"},
        {"Hipparcos Number", "HIP 71622"},
        {"Smithsonian Astrophysical Observation", "SAO 252834"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.72799112),
        dec: Angle.Degrees(-62.94229300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22001"},
        {"Hipparcos Number", "HIP 16245"},
        {"Cincinnati Publication", "Ci 20 240"},
        {"Fundamental Katalog 5th Edition", "FK5 126"},
        {"Geneva Identification System", "GEN# +1.00022001A"},
        {"Smithsonian Astrophysical Observation", "SAO 248819"},
        {"Wilson Evans Batten Catalogue", "WEB 3096"},
    },
    visualMagnitude: 4.71,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.34244352),
        dec: Angle.Degrees(-62.93843436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 383.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 373.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161219"},
        {"Hipparcos Number", "HIP 87169"},
        {"Smithsonian Astrophysical Observation", "SAO 254039"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.14917220),
        dec: Angle.Degrees(-62.93790540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38256"},
        {"Hipparcos Number", "HIP 26672"},
        {"Smithsonian Astrophysical Observation", "SAO 249330"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.02454648),
        dec: Angle.Degrees(-62.93737239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67207"},
        {"Geneva Identification System", "GEN# +2.52810018"},
        {"New General Catalogue", "NGC 5281 18"},
    },
    visualMagnitude: 11.10,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57543171),
        dec: Angle.Degrees(-62.93714543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64677"},
        {"Hipparcos Number", "HIP 38344"},
        {"Geneva Identification System", "GEN# +1.00064677"},
        {"Smithsonian Astrophysical Observation", "SAO 249984"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.80774988),
        dec: Angle.Degrees(-62.93029796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5254"},
        {"Hipparcos Number", "HIP 4170"},
        {"Smithsonian Astrophysical Observation", "SAO 248275"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.31402680),
        dec: Angle.Degrees(-62.92988004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112636"},
        {"Hipparcos Number", "HIP 63377"},
        {"Geneva Identification System", "GEN# +1.00112636"},
        {"Smithsonian Astrophysical Observation", "SAO 252115"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.79042176),
        dec: Angle.Degrees(-62.92953492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112954"},
        {"Hipparcos Number", "HIP 63554"},
        {"Geneva Identification System", "GEN# +1.00112954"},
        {"Smithsonian Astrophysical Observation", "SAO 252127"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.34685254),
        dec: Angle.Degrees(-62.92504790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116110"},
        {"Smithsonian Astrophysical Observation", "SAO 255508"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.89608412),
        dec: Angle.Degrees(-62.92343278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 391.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 210.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224878"},
        {"Hipparcos Number", "HIP 115"},
        {"Smithsonian Astrophysical Observation", "SAO 255624"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.37259669),
        dec: Angle.Degrees(-62.92315760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 309703"},
        {"Hipparcos Number", "HIP 47657"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.75634657),
        dec: Angle.Degrees(-62.92302924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 161.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157290"},
        {"Hipparcos Number", "HIP 85363"},
        {"Smithsonian Astrophysical Observation", "SAO 253921"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.65025066),
        dec: Angle.Degrees(-62.92298640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144596"},
        {"Hipparcos Number", "HIP 79251"},
        {"Geneva Identification System", "GEN# +1.00144596"},
        {"Smithsonian Astrophysical Observation", "SAO 253446"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.61216457),
        dec: Angle.Degrees(-62.92288937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178632"},
        {"Hipparcos Number", "HIP 94460"},
        {"Smithsonian Astrophysical Observation", "SAO 254496"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.38942172),
        dec: Angle.Degrees(-62.92240445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17289"},
        {"Hipparcos Number", "HIP 12726"},
        {"Fundamental Katalog 5th Edition", "FK5 4250"},
        {"Geneva Identification System", "GEN# +1.00017289"},
        {"Smithsonian Astrophysical Observation", "SAO 248631"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.89793044),
        dec: Angle.Degrees(-62.91910911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67204"},
        {"Geneva Identification System", "GEN# +2.52810017"},
        {"New General Catalogue", "NGC 5281 17"},
    },
    visualMagnitude: 10.98,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57375381),
        dec: Angle.Degrees(-62.91863209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156359"},
        {"Hipparcos Number", "HIP 84922"},
        {"Geneva Identification System", "GEN# +1.00156359"},
        {"Smithsonian Astrophysical Observation", "SAO 253880"},
        {"Wilson Evans Batten Catalogue", "WEB 14340"},
    },
    visualMagnitude: 9.67,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.32802568),
        dec: Angle.Degrees(-62.91813575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15414"},
        {"Hipparcos Number", "HIP 11354"},
        {"Smithsonian Astrophysical Observation", "SAO 248563"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.55200459),
        dec: Angle.Degrees(-62.91811548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79655"},
        {"Hipparcos Number", "HIP 45177"},
        {"Celescope Catalog", "CEL 3225"},
        {"Geneva Identification System", "GEN# +1.00079655"},
        {"Smithsonian Astrophysical Observation", "SAO 250482"},
    },
    visualMagnitude: 8.25,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.09489898),
        dec: Angle.Degrees(-62.91601624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69863"},
        {"Henry Draper 2", "HD 69863A"},
        {"Hipparcos Number", "HIP 40429"},
        {"Geneva Identification System", "GEN# +1.00069863"},
        {"Smithsonian Astrophysical Observation", "SAO 250164"},
        {"Wilson Evans Batten Catalogue", "WEB 7877"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.81647486),
        dec: Angle.Degrees(-62.91561677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38511"},
        {"Hipparcos Number", "HIP 26842"},
        {"Smithsonian Astrophysical Observation", "SAO 249335"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.48971999),
        dec: Angle.Degrees(-62.91377822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143999"},
        {"Hipparcos Number", "HIP 78978"},
        {"Geneva Identification System", "GEN# +1.00143999"},
        {"Smithsonian Astrophysical Observation", "SAO 253430"},
        {"Wilson Evans Batten Catalogue", "WEB 13346"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.82919302),
        dec: Angle.Degrees(-62.91055401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119699"},
        {"Hipparcos Number", "HIP 67232"},
        {"Geneva Identification System", "GEN# +2.52810001"},
        {"Smithsonian Astrophysical Observation", "SAO 252442"},
        {"New General Catalogue", "NGC 5281 1"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.65248251),
        dec: Angle.Degrees(-62.90961087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18185"},
        {"Hipparcos Number", "HIP 13387"},
        {"Geneva Identification System", "GEN# +1.00018185"},
        {"Smithsonian Astrophysical Observation", "SAO 248673"},
        {"Wilson Evans Batten Catalogue", "WEB 2681"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.07894232),
        dec: Angle.Degrees(-62.90959822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115845"},
        {"Hipparcos Number", "HIP 65161"},
        {"Smithsonian Astrophysical Observation", "SAO 252275"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.29719062),
        dec: Angle.Degrees(-62.90822577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196317"},
        {"Hipparcos Number", "HIP 101965"},
        {"Geneva Identification System", "GEN# +1.00196317"},
        {"Smithsonian Astrophysical Observation", "SAO 254844"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.96549309),
        dec: Angle.Degrees(-62.90759808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191218"},
        {"Hipparcos Number", "HIP 99576"},
        {"Smithsonian Astrophysical Observation", "SAO 254749"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.11640904),
        dec: Angle.Degrees(-62.90737637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94289"},
        {"Hipparcos Number", "HIP 53089"},
        {"Celescope Catalog", "CEL 3743"},
        {"Geneva Identification System", "GEN# +1.00094289"},
        {"Smithsonian Astrophysical Observation", "SAO 251155"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.91958017),
        dec: Angle.Degrees(-62.90537212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120344"},
        {"Hipparcos Number", "HIP 67572"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.70240290),
        dec: Angle.Degrees(-62.90464482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137586"},
        {"Hipparcos Number", "HIP 75897"},
        {"Smithsonian Astrophysical Observation", "SAO 253186"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.53682626),
        dec: Angle.Degrees(-62.90460057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120979"},
        {"Hipparcos Number", "HIP 67930"},
        {"Geneva Identification System", "GEN# +1.00120979"},
        {"Smithsonian Astrophysical Observation", "SAO 252513"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.67660157),
        dec: Angle.Degrees(-62.90359694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25624"},
        {"Hipparcos Number", "HIP 18689"},
        {"Smithsonian Astrophysical Observation", "SAO 248923"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.05694117),
        dec: Angle.Degrees(-62.90229949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 307727"},
        {"Hipparcos Number", "HIP 51138"},
        {"Cincinnati Publication", "Ci 20 578"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.69967574),
        dec: Angle.Degrees(-62.90171641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -285.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -349.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176172"},
        {"Hipparcos Number", "HIP 93535"},
        {"Geneva Identification System", "GEN# +1.00176172"},
        {"Smithsonian Astrophysical Observation", "SAO 254447"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.76213008),
        dec: Angle.Degrees(-62.90007938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218978"},
        {"Hipparcos Number", "HIP 114628"},
        {"Smithsonian Astrophysical Observation", "SAO 255429"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.31700763),
        dec: Angle.Degrees(-62.89934542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148046"},
        {"Hipparcos Number", "HIP 80766"},
        {"Geneva Identification System", "GEN# +1.00148046"},
        {"Smithsonian Astrophysical Observation", "SAO 253572"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.35397556),
        dec: Angle.Degrees(-62.89855526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71758"},
        {"Hipparcos Number", "HIP 41298"},
        {"Smithsonian Astrophysical Observation", "SAO 250223"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.39603681),
        dec: Angle.Degrees(-62.89713137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180238"},
        {"Hipparcos Number", "HIP 94995"},
        {"Smithsonian Astrophysical Observation", "SAO 254530"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.94778850),
        dec: Angle.Degrees(-62.89697160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68900"},
        {"Hipparcos Number", "HIP 40043"},
        {"Geneva Identification System", "GEN# +1.00068900"},
        {"Smithsonian Astrophysical Observation", "SAO 250141"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.69299396),
        dec: Angle.Degrees(-62.89680556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 150.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35757"},
        {"Hipparcos Number", "HIP 25120"},
        {"Smithsonian Astrophysical Observation", "SAO 249259"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.65934024),
        dec: Angle.Degrees(-62.89589616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 309701"},
        {"Hipparcos Number", "HIP 47490"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.20398290),
        dec: Angle.Degrees(-62.89145297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96567"},
        {"Hipparcos Number", "HIP 54295"},
        {"Smithsonian Astrophysical Observation", "SAO 251268"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.62290312),
        dec: Angle.Degrees(-62.89066339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132888"},
        {"Hipparcos Number", "HIP 73755"},
        {"Geneva Identification System", "GEN# +1.00132888"},
        {"Smithsonian Astrophysical Observation", "SAO 253004"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.14064835),
        dec: Angle.Degrees(-62.88982205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184519"},
        {"Hipparcos Number", "HIP 96628"},
        {"Geneva Identification System", "GEN# +1.00184519"},
        {"Smithsonian Astrophysical Observation", "SAO 254618"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.69612488),
        dec: Angle.Degrees(-62.88978882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2419"},
        {"Hipparcos Number", "HIP 2168"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.84173467),
        dec: Angle.Degrees(-62.88858915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120699"},
        {"Hipparcos Number", "HIP 67771"},
        {"Geneva Identification System", "GEN# +1.00120699"},
        {"Smithsonian Astrophysical Observation", "SAO 252496"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.26732586),
        dec: Angle.Degrees(-62.88804876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222167"},
        {"Hipparcos Number", "HIP 116679"},
        {"Geneva Identification System", "GEN# +1.00222167"},
        {"Smithsonian Astrophysical Observation", "SAO 255531"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.68185498),
        dec: Angle.Degrees(-62.88548214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118804"},
        {"Hipparcos Number", "HIP 66751"},
        {"Smithsonian Astrophysical Observation", "SAO 252408"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.21507595),
        dec: Angle.Degrees(-62.87980210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185693"},
        {"Hipparcos Number", "HIP 97116"},
        {"Smithsonian Astrophysical Observation", "SAO 254637"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.06396388),
        dec: Angle.Degrees(-62.87953413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101995"},
        {"Hipparcos Number", "HIP 57211"},
        {"Celescope Catalog", "CEL 3967"},
        {"Geneva Identification System", "GEN# +1.00101995"},
        {"Smithsonian Astrophysical Observation", "SAO 251559"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.97010100),
        dec: Angle.Degrees(-62.87824289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199342"},
        {"Hipparcos Number", "HIP 103621"},
        {"Smithsonian Astrophysical Observation", "SAO 254916"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.92083462),
        dec: Angle.Degrees(-62.87730677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129422"},
        {"Hipparcos Number", "HIP 72131"},
        {"Geneva Identification System", "GEN# +1.00129422"},
        {"Smithsonian Astrophysical Observation", "SAO 252869"},
        {"Wilson Evans Batten Catalogue", "WEB 12413"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.32186138),
        dec: Angle.Degrees(-62.87545275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155951"},
        {"Hipparcos Number", "HIP 84700"},
        {"Smithsonian Astrophysical Observation", "SAO 253867"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71576058),
        dec: Angle.Degrees(-62.87451877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207257"},
        {"Hipparcos Number", "HIP 107774"},
        {"Geneva Identification System", "GEN# +1.00207257"},
        {"Smithsonian Astrophysical Observation", "SAO 255084"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.50666104),
        dec: Angle.Degrees(-62.87337856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224213"},
        {"Hipparcos Number", "HIP 118007"},
        {"Smithsonian Astrophysical Observation", "SAO 255603"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.03615336),
        dec: Angle.Degrees(-62.87241552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116151"},
        {"Hipparcos Number", "HIP 65317"},
        {"Geneva Identification System", "GEN# +1.00116151"},
        {"Smithsonian Astrophysical Observation", "SAO 252289"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.80703323),
        dec: Angle.Degrees(-62.87136676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5276"},
        {"Hipparcos Number", "HIP 4200"},
        {"Fundamental Katalog 5th Edition", "FK5 2057"},
        {"Geneva Identification System", "GEN# +1.00005276"},
        {"Smithsonian Astrophysical Observation", "SAO 248276"},
        {"Wilson Evans Batten Catalogue", "WEB 755"},
    },
    visualMagnitude: 5.73,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.40741156),
        dec: Angle.Degrees(-62.87135327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181249"},
        {"Hipparcos Number", "HIP 95350"},
        {"Geneva Identification System", "GEN# +1.00181249"},
        {"Smithsonian Astrophysical Observation", "SAO 254555"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.98017305),
        dec: Angle.Degrees(-62.87068320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -457.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223993"},
        {"Hipparcos Number", "HIP 117871"},
        {"Smithsonian Astrophysical Observation", "SAO 255595"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.63742589),
        dec: Angle.Degrees(-62.86765359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124843"},
        {"Hipparcos Number", "HIP 69895"},
        {"Geneva Identification System", "GEN# +1.00124843"},
        {"Smithsonian Astrophysical Observation", "SAO 252692"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.55513500),
        dec: Angle.Degrees(-62.86625187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175782"},
        {"Hipparcos Number", "HIP 93372"},
        {"Smithsonian Astrophysical Observation", "SAO 254436"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.27064835),
        dec: Angle.Degrees(-62.86527746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70269"},
        {"Hipparcos Number", "HIP 40610"},
        {"Geneva Identification System", "GEN# +1.00070269"},
        {"Smithsonian Astrophysical Observation", "SAO 250178"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.37004383),
        dec: Angle.Degrees(-62.86454121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156838"},
        {"Hipparcos Number", "HIP 85147"},
        {"Fundamental Katalog 5th Edition", "FK5 3378"},
        {"Geneva Identification System", "GEN# +1.00156838"},
        {"Smithsonian Astrophysical Observation", "SAO 253903"},
        {"Wilson Evans Batten Catalogue", "WEB 14375"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.00448429),
        dec: Angle.Degrees(-62.86413165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 308352"},
        {"Henry Draper 2", "HD 98242"},
        {"Hipparcos Number", "HIP 55121"},
        {"Smithsonian Astrophysical Observation", "SAO 251340"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.28110846),
        dec: Angle.Degrees(-62.86378157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123188"},
        {"Hipparcos Number", "HIP 69080"},
        {"Geneva Identification System", "GEN# +1.00123188"},
        {"Smithsonian Astrophysical Observation", "SAO 252617"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.09917692),
        dec: Angle.Degrees(-62.86346790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126793"},
        {"Hipparcos Number", "HIP 70922"},
        {"Geneva Identification System", "GEN# +1.00126793"},
        {"Smithsonian Astrophysical Observation", "SAO 252763"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.55280759),
        dec: Angle.Degrees(-62.86219334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76382"},
        {"Hipparcos Number", "HIP 43581"},
        {"Smithsonian Astrophysical Observation", "SAO 250362"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.13623014),
        dec: Angle.Degrees(-62.86087917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90628"},
        {"Hipparcos Number", "HIP 51071"},
        {"Smithsonian Astrophysical Observation", "SAO 250954"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.53106879),
        dec: Angle.Degrees(-62.85947879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39249"},
        {"Smithsonian Astrophysical Observation", "SAO 250080"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.40334738),
        dec: Angle.Degrees(-62.85631827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85315"},
        {"Hipparcos Number", "HIP 48117"},
        {"Geneva Identification System", "GEN# +1.00085315"},
        {"Smithsonian Astrophysical Observation", "SAO 250705"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14875626),
        dec: Angle.Degrees(-62.85536511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107209"},
        {"Hipparcos Number", "HIP 60128"},
        {"Geneva Identification System", "GEN# +1.00107209"},
        {"Smithsonian Astrophysical Observation", "SAO 251848"},
        {"Wilson Evans Batten Catalogue", "WEB 10690"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.97379647),
        dec: Angle.Degrees(-62.85418392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73887"},
        {"Hipparcos Number", "HIP 42286"},
        {"Fundamental Katalog 5th Edition", "FK5 2679"},
        {"Geneva Identification System", "GEN# +1.00073887J"},
        {"Smithsonian Astrophysical Observation", "SAO 250288"},
        {"Wilson Evans Batten Catalogue", "WEB 8122"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.32852740),
        dec: Angle.Degrees(-62.85341217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 309218"},
        {"Hipparcos Number", "HIP 57978"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.38977864),
        dec: Angle.Degrees(-62.85220270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216077"},
        {"Hipparcos Number", "HIP 112847"},
        {"Smithsonian Astrophysical Observation", "SAO 255334"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.79392646),
        dec: Angle.Degrees(-62.85200627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87256"},
        {"Hipparcos Number", "HIP 49124"},
        {"Smithsonian Astrophysical Observation", "SAO 250781"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.38895964),
        dec: Angle.Degrees(-62.85092299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78725"},
        {"Hipparcos Number", "HIP 44721"},
        {"Celescope Catalog", "CEL 3193"},
        {"Geneva Identification System", "GEN# +1.00078725"},
        {"Smithsonian Astrophysical Observation", "SAO 250444"},
    },
    visualMagnitude: 7.54,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.68768536),
        dec: Angle.Degrees(-62.84985825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24"},
        {"Hipparcos Number", "HIP 425"},
        {"Geneva Identification System", "GEN# +1.00000024"},
        {"Smithsonian Astrophysical Observation", "SAO 248112"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.29047896),
        dec: Angle.Degrees(-62.84527102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155206"},
        {"Hipparcos Number", "HIP 84325"},
        {"Smithsonian Astrophysical Observation", "SAO 253842"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.58911449),
        dec: Angle.Degrees(-62.84420976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109550"},
        {"Hipparcos Number", "HIP 61506"},
        {"Geneva Identification System", "GEN# +1.00109550"},
        {"Smithsonian Astrophysical Observation", "SAO 251968"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.03144622),
        dec: Angle.Degrees(-62.84410409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9610"},
        {"Hipparcos Number", "HIP 7177"},
        {"Smithsonian Astrophysical Observation", "SAO 248396"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.12882541),
        dec: Angle.Degrees(-62.84394278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74088"},
        {"Hipparcos Number", "HIP 42381"},
        {"Smithsonian Astrophysical Observation", "SAO 250290"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.61604274),
        dec: Angle.Degrees(-62.84324824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156770"},
        {"Hipparcos Number", "HIP 85113"},
        {"Smithsonian Astrophysical Observation", "SAO 253900"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.92342193),
        dec: Angle.Degrees(-62.84269367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39509"},
        {"Smithsonian Astrophysical Observation", "SAO 250100"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.12719581),
        dec: Angle.Degrees(-62.84071604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223444"},
        {"Hipparcos Number", "HIP 117507"},
        {"Geneva Identification System", "GEN# +1.00223444"},
        {"Smithsonian Astrophysical Observation", "SAO 255578"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.43621756),
        dec: Angle.Degrees(-62.83940298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93485"},
        {"Hipparcos Number", "HIP 52664"},
        {"Smithsonian Astrophysical Observation", "SAO 251109"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.53394565),
        dec: Angle.Degrees(-62.83653954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67536"},
        {"Hipparcos Number", "HIP 39530"},
        {"Geneva Identification System", "GEN# +1.00067536A"},
        {"Smithsonian Astrophysical Observation", "SAO 250101"},
        {"Wilson Evans Batten Catalogue", "WEB 7726"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.17891287),
        dec: Angle.Degrees(-62.83637455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198563"},
        {"Hipparcos Number", "HIP 103184"},
        {"Fundamental Katalog 5th Edition", "FK5 5840"},
        {"Smithsonian Astrophysical Observation", "SAO 254895"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.58357777),
        dec: Angle.Degrees(-62.83549699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104172"},
        {"Hipparcos Number", "HIP 58498"},
        {"Smithsonian Astrophysical Observation", "SAO 251673"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.95371217),
        dec: Angle.Degrees(-62.83163390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104111"},
        {"Hipparcos Number", "HIP 58469"},
        {"Geneva Identification System", "GEN# +1.00104111"},
        {"Smithsonian Astrophysical Observation", "SAO 251670"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.85677288),
        dec: Angle.Degrees(-62.83094991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64625"},
        {"Hipparcos Number", "HIP 38309"},
        {"Smithsonian Astrophysical Observation", "SAO 249981"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.73610299),
        dec: Angle.Degrees(-62.82902480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30880"},
        {"Hipparcos Number", "HIP 22242"},
        {"Geneva Identification System", "GEN# +1.00030880"},
        {"Smithsonian Astrophysical Observation", "SAO 249110"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.81401019),
        dec: Angle.Degrees(-62.82901250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185050"},
        {"Hipparcos Number", "HIP 96860"},
        {"Smithsonian Astrophysical Observation", "SAO 254626"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.32510922),
        dec: Angle.Degrees(-62.82752682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133455"},
        {"Hipparcos Number", "HIP 74023"},
        {"Smithsonian Astrophysical Observation", "SAO 253022"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.91221277),
        dec: Angle.Degrees(-62.82614128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21706"},
        {"Hipparcos Number", "HIP 16051"},
        {"Geneva Identification System", "GEN# +1.00021706"},
        {"Renson", "Renson 5420"},
        {"Smithsonian Astrophysical Observation", "SAO 248807"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.67999833),
        dec: Angle.Degrees(-62.82468470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219370"},
        {"Hipparcos Number", "HIP 114876"},
        {"Smithsonian Astrophysical Observation", "SAO 255440"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.02878247),
        dec: Angle.Degrees(-62.82391521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29399"},
        {"Hipparcos Number", "HIP 21253"},
        {"Geneva Identification System", "GEN# +1.00029399A"},
        {"Smithsonian Astrophysical Observation", "SAO 249054"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.39208243),
        dec: Angle.Degrees(-62.82363051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6283"},
        {"Hipparcos Number", "HIP 4870"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.65496543),
        dec: Angle.Degrees(-62.82356798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99605"},
        {"Hipparcos Number", "HIP 55854"},
        {"Smithsonian Astrophysical Observation", "SAO 251407"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.70832374),
        dec: Angle.Degrees(-62.81987111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34210"},
        {"Hipparcos Number", "HIP 24167"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.84387032),
        dec: Angle.Degrees(-62.81722950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113841",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113841"},
        {"Geneva Identification System", "GEN# -0.06304838"},
        {"Smithsonian Astrophysical Observation", "SAO 255388"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.81686387),
        dec: Angle.Degrees(-62.81685154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216272"},
        {"Hipparcos Number", "HIP 112984"},
        {"Fundamental Katalog 5th Edition", "FK5 6022"},
        {"Geneva Identification System", "GEN# +1.00216272"},
        {"Smithsonian Astrophysical Observation", "SAO 255344"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.21199756),
        dec: Angle.Degrees(-62.81583771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3711"},
        {"Hipparcos Number", "HIP 3079"},
        {"Smithsonian Astrophysical Observation", "SAO 248230"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.77674547),
        dec: Angle.Degrees(-62.81520348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142699"},
        {"Hipparcos Number", "HIP 78326"},
        {"Geneva Identification System", "GEN# +1.00142699"},
        {"Smithsonian Astrophysical Observation", "SAO 253367"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.89996799),
        dec: Angle.Degrees(-62.81497899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216043"},
        {"Hipparcos Number", "HIP 112826"},
        {"Geneva Identification System", "GEN# +1.00216043"},
        {"Smithsonian Astrophysical Observation", "SAO 255333"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.72727587),
        dec: Angle.Degrees(-62.81467854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41411"},
        {"Hipparcos Number", "HIP 28465"},
        {"Smithsonian Astrophysical Observation", "SAO 249417"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.15123386),
        dec: Angle.Degrees(-62.81226092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211299"},
        {"Hipparcos Number", "HIP 110088"},
        {"Smithsonian Astrophysical Observation", "SAO 255187"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.50872353),
        dec: Angle.Degrees(-62.81132529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41298"},
        {"Hipparcos Number", "HIP 28400"},
        {"Geneva Identification System", "GEN# +1.00041298"},
        {"Smithsonian Astrophysical Observation", "SAO 249410"},
        {"Wilson Evans Batten Catalogue", "WEB 5552"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.97541614),
        dec: Angle.Degrees(-62.80891239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17848"},
        {"Hipparcos Number", "HIP 13141"},
        {"Fundamental Katalog 5th Edition", "FK5 2196"},
        {"Geneva Identification System", "GEN# +1.00017848"},
        {"Smithsonian Astrophysical Observation", "SAO 248656"},
        {"Wilson Evans Batten Catalogue", "WEB 2646"},
    },
    visualMagnitude: 5.25,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.25569560),
        dec: Angle.Degrees(-62.80659207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205793"},
        {"Hipparcos Number", "HIP 106995"},
        {"Geneva Identification System", "GEN# +1.00205793"},
        {"Smithsonian Astrophysical Observation", "SAO 255049"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.04110885),
        dec: Angle.Degrees(-62.80619719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99771"},
        {"Hipparcos Number", "HIP 55949"},
        {"Smithsonian Astrophysical Observation", "SAO 251413"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.98700486),
        dec: Angle.Degrees(-62.80513624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174877"},
        {"Hipparcos Number", "HIP 93012"},
        {"Geneva Identification System", "GEN# +1.00174877"},
        {"Smithsonian Astrophysical Observation", "SAO 254415"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.22791532),
        dec: Angle.Degrees(-62.80191774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30132"},
        {"Hipparcos Number", "HIP 21789"},
        {"Smithsonian Astrophysical Observation", "SAO 249077"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.20495542),
        dec: Angle.Degrees(-62.80090731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28667"},
        {"Hipparcos Number", "HIP 20784"},
        {"Geneva Identification System", "GEN# +1.00028667"},
        {"Smithsonian Astrophysical Observation", "SAO 249027"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.77689443),
        dec: Angle.Degrees(-62.79965649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126097"},
        {"Hipparcos Number", "HIP 70546"},
        {"Geneva Identification System", "GEN# +1.00126097"},
        {"Smithsonian Astrophysical Observation", "SAO 252738"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.47213027),
        dec: Angle.Degrees(-62.79805373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37656"},
        {"Hipparcos Number", "HIP 26277"},
        {"Geneva Identification System", "GEN# +1.00037656"},
        {"Wilson Evans Batten Catalogue", "WEB 5158"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.93442645),
        dec: Angle.Degrees(-62.79787593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 249.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140408"},
        {"Hipparcos Number", "HIP 77310"},
        {"Geneva Identification System", "GEN# +1.00140408"},
        {"Smithsonian Astrophysical Observation", "SAO 253290"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.75033666),
        dec: Angle.Degrees(-62.79678215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31875"},
        {"Hipparcos Number", "HIP 22861"},
        {"Geneva Identification System", "GEN# +1.00031875"},
        {"Smithsonian Astrophysical Observation", "SAO 249144"},
        {"Wilson Evans Batten Catalogue", "WEB 4430"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.77841241),
        dec: Angle.Degrees(-62.79556845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64537",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64537"},
        {"Smithsonian Astrophysical Observation", "SAO 252212"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.798,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.42141002),
        dec: Angle.Degrees(-62.79393083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128158"},
        {"Hipparcos Number", "HIP 71551"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.51422827),
        dec: Angle.Degrees(-62.79096525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33476"},
        {"Hipparcos Number", "HIP 23742"},
        {"Geneva Identification System", "GEN# +1.00033476"},
        {"Smithsonian Astrophysical Observation", "SAO 249188"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.54717332),
        dec: Angle.Degrees(-62.79031867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 305.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135652"},
        {"Hipparcos Number", "HIP 74986"},
        {"Smithsonian Astrophysical Observation", "SAO 253106"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.84434278),
        dec: Angle.Degrees(-62.79016076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82901"},
        {"Hipparcos Number", "HIP 46806"},
        {"Geneva Identification System", "GEN# +1.00082901J"},
        {"Smithsonian Astrophysical Observation", "SAO 250614"},
        {"Wilson Evans Batten Catalogue", "WEB 8826"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.06103169),
        dec: Angle.Degrees(-62.78892185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182586"},
        {"Hipparcos Number", "HIP 95819"},
        {"Smithsonian Astrophysical Observation", "SAO 254586"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.33777952),
        dec: Angle.Degrees(-62.78819910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21012"},
        {"Hipparcos Number", "HIP 15535"},
        {"Geneva Identification System", "GEN# +1.00021012"},
        {"Smithsonian Astrophysical Observation", "SAO 248781"},
    },
    visualMagnitude: 10.28,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.03207604),
        dec: Angle.Degrees(-62.78809245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88277"},
        {"Hipparcos Number", "HIP 49693"},
        {"Smithsonian Astrophysical Observation", "SAO 250832"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.16322196),
        dec: Angle.Degrees(-62.78713572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100126"},
        {"Hipparcos Number", "HIP 56156"},
        {"Geneva Identification System", "GEN# +1.00100126"},
        {"Smithsonian Astrophysical Observation", "SAO 251431"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.66759033),
        dec: Angle.Degrees(-62.78655158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26099"},
        {"Hipparcos Number", "HIP 18981"},
        {"Smithsonian Astrophysical Observation", "SAO 248936"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.00328473),
        dec: Angle.Degrees(-62.78602866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68402"},
        {"Smithsonian Astrophysical Observation", "SAO 252551"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.04072909),
        dec: Angle.Degrees(-62.78317421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78407"},
        {"Hipparcos Number", "HIP 44593"},
        {"Smithsonian Astrophysical Observation", "SAO 250434"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.27096844),
        dec: Angle.Degrees(-62.78243234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121857"},
        {"Hipparcos Number", "HIP 68399"},
        {"Geneva Identification System", "GEN# +1.00121857"},
        {"Smithsonian Astrophysical Observation", "SAO 252549"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.02306332),
        dec: Angle.Degrees(-62.78213645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219536"},
        {"Hipparcos Number", "HIP 114989"},
        {"Smithsonian Astrophysical Observation", "SAO 255449"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.33620179),
        dec: Angle.Degrees(-62.78125297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131492"},
        {"Hipparcos Number", "HIP 73129"},
        {"Geneva Identification System", "GEN# +1.00131492"},
        {"Smithsonian Astrophysical Observation", "SAO 252965"},
        {"Wilson Evans Batten Catalogue", "WEB 12533"},
    },
    visualMagnitude: 5.08,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.18334308),
        dec: Angle.Degrees(-62.78098762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36191"},
        {"Hipparcos Number", "HIP 25374"},
        {"Smithsonian Astrophysical Observation", "SAO 249270"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.42489917),
        dec: Angle.Degrees(-62.77893617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49112"},
        {"Hipparcos Number", "HIP 32129"},
        {"Smithsonian Astrophysical Observation", "SAO 249628"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.64932462),
        dec: Angle.Degrees(-62.77713426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104083"},
        {"Hipparcos Number", "HIP 58456"},
        {"Geneva Identification System", "GEN# +1.00104083"},
    },
    visualMagnitude: 8.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.80944692),
        dec: Angle.Degrees(-62.77687422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132923"},
        {"Hipparcos Number", "HIP 73769"},
        {"Smithsonian Astrophysical Observation", "SAO 253007"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.18868675),
        dec: Angle.Degrees(-62.77521337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120578"},
        {"Hipparcos Number", "HIP 67720"},
        {"Smithsonian Astrophysical Observation", "SAO 252486"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.09206952),
        dec: Angle.Degrees(-62.77494520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171970"},
        {"Hipparcos Number", "HIP 91683"},
        {"Smithsonian Astrophysical Observation", "SAO 254336"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.45202277),
        dec: Angle.Degrees(-62.77445932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217155"},
        {"Hipparcos Number", "HIP 113540"},
        {"Geneva Identification System", "GEN# +1.00217155"},
        {"Smithsonian Astrophysical Observation", "SAO 255370"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.93410465),
        dec: Angle.Degrees(-62.77202329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1022"},
        {"Hipparcos Number", "HIP 1146"},
        {"Smithsonian Astrophysical Observation", "SAO 248139"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.58669233),
        dec: Angle.Degrees(-62.77197869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22543"},
        {"Hipparcos Number", "HIP 16634"},
        {"Smithsonian Astrophysical Observation", "SAO 248840"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.50329926),
        dec: Angle.Degrees(-62.77188681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145386"},
        {"Hipparcos Number", "HIP 79598"},
        {"Smithsonian Astrophysical Observation", "SAO 253470"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.61521769),
        dec: Angle.Degrees(-62.77037988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23472"},
        {"Hipparcos Number", "HIP 17264"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.46053888),
        dec: Angle.Degrees(-62.76696977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136999"},
        {"Hipparcos Number", "HIP 75611"},
        {"Geneva Identification System", "GEN# +1.00136999"},
        {"Smithsonian Astrophysical Observation", "SAO 253168"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.72966567),
        dec: Angle.Degrees(-62.76575303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143967"},
        {"Hipparcos Number", "HIP 78951"},
        {"Geneva Identification System", "GEN# +1.00143967"},
        {"Smithsonian Astrophysical Observation", "SAO 253428"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.75696452),
        dec: Angle.Degrees(-62.76265822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26524"},
        {"Hipparcos Number", "HIP 19273"},
        {"Smithsonian Astrophysical Observation", "SAO 248948"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.96423641),
        dec: Angle.Degrees(-62.76254471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12508"},
        {"Hipparcos Number", "HIP 9377"},
        {"Smithsonian Astrophysical Observation", "SAO 248478"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.12481649),
        dec: Angle.Degrees(-62.76253582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93283"},
        {"Hipparcos Number", "HIP 52557"},
        {"Geneva Identification System", "GEN# +1.00093283"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.18589833),
        dec: Angle.Degrees(-62.76194032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86676"},
        {"Hipparcos Number", "HIP 48853"},
        {"Smithsonian Astrophysical Observation", "SAO 250764"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.46403808),
        dec: Angle.Degrees(-62.76116768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221910"},
        {"Hipparcos Number", "HIP 116509"},
        {"Smithsonian Astrophysical Observation", "SAO 255522"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.13170364),
        dec: Angle.Degrees(-62.75520653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41023"},
        {"Hipparcos Number", "HIP 28257"},
        {"Smithsonian Astrophysical Observation", "SAO 249404"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.56053893),
        dec: Angle.Degrees(-62.75495945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28575"},
        {"Hipparcos Number", "HIP 20708"},
        {"Geneva Identification System", "GEN# +1.00028575"},
        {"Smithsonian Astrophysical Observation", "SAO 249024"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.55737771),
        dec: Angle.Degrees(-62.75370447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160859"},
        {"Hipparcos Number", "HIP 86991"},
        {"Geneva Identification System", "GEN# +1.00160859"},
        {"Smithsonian Astrophysical Observation", "SAO 254025"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.64996300),
        dec: Angle.Degrees(-62.75090869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -382.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85656"},
        {"Hipparcos Number", "HIP 48310"},
        {"Geneva Identification System", "GEN# +1.00085656"},
        {"Smithsonian Astrophysical Observation", "SAO 250721"},
        {"Wilson Evans Batten Catalogue", "WEB 9008"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.73165865),
        dec: Angle.Degrees(-62.74513696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41826"},
    },
    visualMagnitude: 10.21,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.91248141),
        dec: Angle.Degrees(-62.74472090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91024"},
        {"Geneva Identification System", "GEN# +6.20145015"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.52942432),
        dec: Angle.Degrees(-62.74375486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14467"},
        {"Hipparcos Number", "HIP 10692"},
        {"Fundamental Katalog 5th Edition", "FK5 4212"},
        {"Smithsonian Astrophysical Observation", "SAO 248528"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.41364010),
        dec: Angle.Degrees(-62.73907378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220780"},
        {"Hipparcos Number", "HIP 115760"},
        {"Smithsonian Astrophysical Observation", "SAO 255488"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.78987071),
        dec: Angle.Degrees(-62.73712704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151570"},
        {"Hipparcos Number", "HIP 82533"},
        {"Smithsonian Astrophysical Observation", "SAO 253721"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.05173634),
        dec: Angle.Degrees(-62.73708788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213365"},
        {"Hipparcos Number", "HIP 111267"},
        {"Smithsonian Astrophysical Observation", "SAO 255244"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.13188772),
        dec: Angle.Degrees(-62.73694794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155190"},
        {"Hipparcos Number", "HIP 84317"},
        {"Smithsonian Astrophysical Observation", "SAO 253841"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.56718125),
        dec: Angle.Degrees(-62.73435475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80864"},
        {"Hipparcos Number", "HIP 45729"},
        {"Celescope Catalog", "CEL 3268"},
        {"Geneva Identification System", "GEN# +1.00080864"},
        {"Smithsonian Astrophysical Observation", "SAO 250535"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.83638048),
        dec: Angle.Degrees(-62.73285881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172941"},
        {"Hipparcos Number", "HIP 92172"},
        {"Geneva Identification System", "GEN# +1.00172941J"},
        {"Smithsonian Astrophysical Observation", "SAO 254365"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.78659483),
        dec: Angle.Degrees(-62.73253622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4576"},
        {"Hipparcos Number", "HIP 3667"},
        {"Smithsonian Astrophysical Observation", "SAO 248252"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.72391720),
        dec: Angle.Degrees(-62.72644438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17538"},
        {"Hipparcos Number", "HIP 12900"},
        {"Smithsonian Astrophysical Observation", "SAO 248643"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.45571832),
        dec: Angle.Degrees(-62.72416338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190206"},
        {"Hipparcos Number", "HIP 99127"},
        {"Smithsonian Astrophysical Observation", "SAO 254729"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.86677635),
        dec: Angle.Degrees(-62.72093482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148888"},
        {"Hipparcos Number", "HIP 81199"},
        {"Smithsonian Astrophysical Observation", "SAO 253611"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.78299466),
        dec: Angle.Degrees(-62.71980412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201996"},
        {"Hipparcos Number", "HIP 105006"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.01276313),
        dec: Angle.Degrees(-62.71773840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128193"},
        {"Hipparcos Number", "HIP 71563"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.54231696),
        dec: Angle.Degrees(-62.71771480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114515"},
        {"Hipparcos Number", "HIP 64423"},
        {"Smithsonian Astrophysical Observation", "SAO 252191"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.06574268),
        dec: Angle.Degrees(-62.71402986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91201"},
        {"Hipparcos Number", "HIP 51407"},
        {"Smithsonian Astrophysical Observation", "SAO 250986"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.49549484),
        dec: Angle.Degrees(-62.71258410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208438"},
        {"Hipparcos Number", "HIP 108463"},
        {"Smithsonian Astrophysical Observation", "SAO 255113"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.58833967),
        dec: Angle.Degrees(-62.71076600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143682"},
        {"Hipparcos Number", "HIP 78834"},
        {"Geneva Identification System", "GEN# +1.00143682"},
        {"Smithsonian Astrophysical Observation", "SAO 253418"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.39700403),
        dec: Angle.Degrees(-62.70897045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155797"},
        {"Hipparcos Number", "HIP 84622"},
        {"Smithsonian Astrophysical Observation", "SAO 253861"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.48183277),
        dec: Angle.Degrees(-62.70279891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34915"},
        {"Hipparcos Number", "HIP 24595"},
        {"Smithsonian Astrophysical Observation", "SAO 249232"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.13966244),
        dec: Angle.Degrees(-62.70070266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219077"},
        {"Hipparcos Number", "HIP 114699"},
        {"Cincinnati Publication", "Ci 20 1405"},
        {"Geneva Identification System", "GEN# +1.00219077"},
        {"Smithsonian Astrophysical Observation", "SAO 255435"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.52491363),
        dec: Angle.Degrees(-62.69897068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 477.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -425.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16899"},
        {"Hipparcos Number", "HIP 12404"},
        {"Smithsonian Astrophysical Observation", "SAO 248617"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.93552496),
        dec: Angle.Degrees(-62.69638935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104705"},
        {"Hipparcos Number", "HIP 58783"},
        {"Celescope Catalog", "CEL 4045"},
        {"Geneva Identification System", "GEN# +1.00104705"},
        {"Smithsonian Astrophysical Observation", "SAO 251709"},
        {"Wilson Evans Batten Catalogue", "WEB 10474"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.84965025),
        dec: Angle.Degrees(-62.69606593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143414"},
        {"Hipparcos Number", "HIP 78689"},
        {"Geneva Identification System", "GEN# +1.00143414"},
        {"Smithsonian Astrophysical Observation", "SAO 253405"},
        {"Wilson Evans Batten Catalogue", "WEB 13300"},
    },
    visualMagnitude: 10.09,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.95563964),
        dec: Angle.Degrees(-62.69328932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101602"},
        {"Hipparcos Number", "HIP 56991"},
        {"Smithsonian Astrophysical Observation", "SAO 251537"},
        {"Wilson Evans Batten Catalogue", "WEB 10260"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.24394352),
        dec: Angle.Degrees(-62.69248563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13086"},
        {"Hipparcos Number", "HIP 9784"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.45090634),
        dec: Angle.Degrees(-62.68931650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34048"},
        {"Hipparcos Number", "HIP 24074"},
        {"Geneva Identification System", "GEN# +1.00034048"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.58092243),
        dec: Angle.Degrees(-62.68893934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42505"},
        {"Hipparcos Number", "HIP 28964"},
        {"Geneva Identification System", "GEN# +1.00042505"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.68230619),
        dec: Angle.Degrees(-62.68303897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 175.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111858"},
        {"Hipparcos Number", "HIP 62864"},
        {"Smithsonian Astrophysical Observation", "SAO 252066"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.27716547),
        dec: Angle.Degrees(-62.68236545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138773"},
        {"Hipparcos Number", "HIP 76513"},
        {"Geneva Identification System", "GEN# +1.00138773"},
        {"Renson", "Renson 39520"},
        {"Smithsonian Astrophysical Observation", "SAO 253236"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.39354567),
        dec: Angle.Degrees(-62.68139400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70890",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Proxima Cen"},
        {"Common Name 2", "Proxima"},
        {"Common Name 3", "Proxima Centauri"},
        {"Hipparcos Number", "HIP 70890"},
        {"Cincinnati Publication", "Ci 20 861"},
        {"Geneva Identification System", "GEN# +6.10010551"},
        {"Geneva Identification System 2", "GEN# +6.00105721"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.44894751),
        dec: Angle.Degrees(-62.68135207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3775.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 768.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161498"},
        {"Hipparcos Number", "HIP 87296"},
        {"Smithsonian Astrophysical Observation", "SAO 254049"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.55730684),
        dec: Angle.Degrees(-62.68074791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136488"},
        {"Hipparcos Number", "HIP 75377"},
        {"Smithsonian Astrophysical Observation", "SAO 253143"},
        {"Wilson Evans Batten Catalogue", "WEB 12859"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.04713983),
        dec: Angle.Degrees(-62.67709306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4510"},
        {"Hipparcos Number", "HIP 3614"},
        {"Geneva Identification System", "GEN# +1.00004510"},
        {"Smithsonian Astrophysical Observation", "SAO 248248"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.56968612),
        dec: Angle.Degrees(-62.67573949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133281"},
        {"Hipparcos Number", "HIP 73948"},
        {"Geneva Identification System", "GEN# +1.00133281"},
        {"Renson", "Renson 37840"},
        {"Smithsonian Astrophysical Observation", "SAO 253018"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.67209068),
        dec: Angle.Degrees(-62.67534316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197220"},
        {"Hipparcos Number", "HIP 102452"},
        {"Geneva Identification System", "GEN# +1.00197220"},
        {"Smithsonian Astrophysical Observation", "SAO 254865"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.41054537),
        dec: Angle.Degrees(-62.67310637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112854"},
        {"Hipparcos Number", "HIP 63499"},
        {"Smithsonian Astrophysical Observation", "SAO 252124"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.16867023),
        dec: Angle.Degrees(-62.66571113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116734"},
        {"Hipparcos Number", "HIP 65604"},
        {"Geneva Identification System", "GEN# +1.00116734"},
        {"Smithsonian Astrophysical Observation", "SAO 252309"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.77320778),
        dec: Angle.Degrees(-62.65992483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193809"},
        {"Hipparcos Number", "HIP 100761"},
        {"Geneva Identification System", "GEN# +1.00193809"},
        {"Smithsonian Astrophysical Observation", "SAO 254788"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.43120130),
        dec: Angle.Degrees(-62.65937380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134399"},
        {"Hipparcos Number", "HIP 74446"},
        {"Geneva Identification System", "GEN# +1.00134399"},
        {"Smithsonian Astrophysical Observation", "SAO 253055"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.20534353),
        dec: Angle.Degrees(-62.65821590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114792"},
        {"Hipparcos Number", "HIP 64564"},
        {"Geneva Identification System", "GEN# +1.00114792"},
        {"Smithsonian Astrophysical Observation", "SAO 252218"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.50799071),
        dec: Angle.Degrees(-62.65388122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203779"},
        {"Hipparcos Number", "HIP 105915"},
        {"Smithsonian Astrophysical Observation", "SAO 255000"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.76833815),
        dec: Angle.Degrees(-62.65381903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88115"},
        {"Hipparcos Number", "HIP 49608"},
        {"Celescope Catalog", "CEL 3445"},
        {"Geneva Identification System", "GEN# +1.00088115"},
        {"Smithsonian Astrophysical Observation", "SAO 250822"},
        {"Wilson Evans Batten Catalogue", "WEB 9148"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.88246119),
        dec: Angle.Degrees(-62.65357901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9425"},
        {"Hipparcos Number", "HIP 7056"},
        {"Smithsonian Astrophysical Observation", "SAO 248392"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.73990521),
        dec: Angle.Degrees(-62.65277036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99897"},
        {"Hipparcos Number", "HIP 56021"},
        {"Geneva Identification System", "GEN# +1.00099897"},
        {"Smithsonian Astrophysical Observation", "SAO 251420"},
        {"Wilson Evans Batten Catalogue", "WEB 10058"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.22579382),
        dec: Angle.Degrees(-62.65273584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146579"},
        {"Hipparcos Number", "HIP 80089"},
        {"Smithsonian Astrophysical Observation", "SAO 253510"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.20966475),
        dec: Angle.Degrees(-62.65197350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153775"},
        {"Hipparcos Number", "HIP 83628"},
        {"Smithsonian Astrophysical Observation", "SAO 253789"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.37290058),
        dec: Angle.Degrees(-62.65103240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102878"},
        {"Hipparcos Number", "HIP 57741"},
        {"Celescope Catalog", "CEL 3990"},
        {"Geneva Identification System", "GEN# +1.00102878"},
        {"Smithsonian Astrophysical Observation", "SAO 251605"},
        {"Wilson Evans Batten Catalogue", "WEB 10363"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.61368682),
        dec: Angle.Degrees(-62.64938330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116781"},
        {"Hipparcos Number", "HIP 65637"},
        {"Geneva Identification System", "GEN# +1.00116781J"},
        {"Smithsonian Astrophysical Observation", "SAO 252312"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.85444308),
        dec: Angle.Degrees(-62.64900994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21398"},
        {"Smithsonian Astrophysical Observation", "SAO 249062"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.89827729),
        dec: Angle.Degrees(-62.64830337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149130"},
        {"Hipparcos Number", "HIP 81329"},
        {"Geneva Identification System", "GEN# +1.00149130"},
        {"Smithsonian Astrophysical Observation", "SAO 253623"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.16069878),
        dec: Angle.Degrees(-62.64794477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173813"},
        {"Hipparcos Number", "HIP 92545"},
        {"Geneva Identification System", "GEN# +1.00173813"},
        {"Smithsonian Astrophysical Observation", "SAO 254387"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.88170623),
        dec: Angle.Degrees(-62.64698505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111464"},
        {"Hipparcos Number", "HIP 62651"},
        {"Geneva Identification System", "GEN# +1.00111464"},
        {"Smithsonian Astrophysical Observation", "SAO 252046"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.55853027),
        dec: Angle.Degrees(-62.64134379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22497"},
        {"Hipparcos Number", "HIP 16589"},
        {"Geneva Identification System", "GEN# +1.00022497"},
        {"Smithsonian Astrophysical Observation", "SAO 248837"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.39342193),
        dec: Angle.Degrees(-62.64065642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31481"},
    },
    visualMagnitude: 12.39,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.90024614),
        dec: Angle.Degrees(-62.64007181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30319"},
        {"Smithsonian Astrophysical Observation", "SAO 249528"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.65457647),
        dec: Angle.Degrees(-62.63865382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94097"},
        {"Hipparcos Number", "HIP 52977"},
        {"Celescope Catalog", "CEL 3734"},
        {"Geneva Identification System", "GEN# +1.00094097"},
        {"Smithsonian Astrophysical Observation", "SAO 251145"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.55423086),
        dec: Angle.Degrees(-62.63572471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161747"},
        {"Hipparcos Number", "HIP 87392"},
        {"Smithsonian Astrophysical Observation", "SAO 254054"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.89152124),
        dec: Angle.Degrees(-62.63547408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121949"},
        {"Hipparcos Number", "HIP 68442"},
        {"Smithsonian Astrophysical Observation", "SAO 252555"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.18008106),
        dec: Angle.Degrees(-62.63364551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142733"},
        {"Hipparcos Number", "HIP 78339"},
        {"Smithsonian Astrophysical Observation", "SAO 253369"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.93714173),
        dec: Angle.Degrees(-62.63314589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81336"},
        {"Geneva Identification System", "GEN# -0.06205390"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.17449554),
        dec: Angle.Degrees(-62.63225171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117923"},
        {"Hipparcos Number", "HIP 66289"},
        {"Smithsonian Astrophysical Observation", "SAO 252375"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.79645728),
        dec: Angle.Degrees(-62.63066184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176250"},
        {"Hipparcos Number", "HIP 93585"},
        {"Geneva Identification System", "GEN# +1.00176250"},
        {"Smithsonian Astrophysical Observation", "SAO 254452"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.89240311),
        dec: Angle.Degrees(-62.62781288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 307505"},
        {"Hipparcos Number", "HIP 49624"},
        {"Smithsonian Astrophysical Observation", "SAO 250824"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.91890322),
        dec: Angle.Degrees(-62.62553742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112216"},
        {"Hipparcos Number", "HIP 63112"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.97774588),
        dec: Angle.Degrees(-62.61897113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49266"},
        {"Hipparcos Number", "HIP 32207"},
        {"Smithsonian Astrophysical Observation", "SAO 249633"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.84023349),
        dec: Angle.Degrees(-62.61657341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 308348"},
        {"Hipparcos Number", "HIP 54816"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.32448233),
        dec: Angle.Degrees(-62.61276206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104432"},
        {"Hipparcos Number", "HIP 58630"},
        {"Celescope Catalog", "CEL 4035"},
        {"Geneva Identification System", "GEN# +1.00104432"},
        {"Smithsonian Astrophysical Observation", "SAO 251684"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.34863350),
        dec: Angle.Degrees(-62.60985532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141585"},
        {"Hipparcos Number", "HIP 77817"},
        {"Geneva Identification System", "GEN# +1.00141585"},
        {"Smithsonian Astrophysical Observation", "SAO 253328"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.34557097),
        dec: Angle.Degrees(-62.60654867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195683"},
        {"Hipparcos Number", "HIP 101637"},
        {"Geneva Identification System", "GEN# +1.00195683"},
        {"Smithsonian Astrophysical Observation", "SAO 254824"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.01546942),
        dec: Angle.Degrees(-62.60405922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18797"},
        {"Hipparcos Number", "HIP 13860"},
        {"Geneva Identification System", "GEN# +1.00018797"},
        {"Smithsonian Astrophysical Observation", "SAO 248698"},
    },
    visualMagnitude: 9.80,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.61289011),
        dec: Angle.Degrees(-62.60339740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147814"},
        {"Hipparcos Number", "HIP 80647"},
        {"Geneva Identification System", "GEN# +1.00147814"},
        {"Smithsonian Astrophysical Observation", "SAO 253556"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.99031842),
        dec: Angle.Degrees(-62.59891660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15918"},
        {"Hipparcos Number", "HIP 11701"},
        {"Geneva Identification System", "GEN# +1.00015918"},
        {"Smithsonian Astrophysical Observation", "SAO 248582"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.73451947),
        dec: Angle.Degrees(-62.59616088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82136"},
        {"Hipparcos Number", "HIP 46384"},
        {"Smithsonian Astrophysical Observation", "SAO 250587"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.87310608),
        dec: Angle.Degrees(-62.59424324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12695"},
        {"Hipparcos Number", "HIP 9499"},
        {"Geneva Identification System", "GEN# +1.00012695"},
        {"Smithsonian Astrophysical Observation", "SAO 248484"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.55008416),
        dec: Angle.Degrees(-62.59219399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119796"},
        {"Henry Draper 2", "HD 119796A"},
        {"Hipparcos Number", "HIP 67261"},
        {"Geneva Identification System", "GEN# +1.00119796"},
        {"Smithsonian Astrophysical Observation", "SAO 252448"},
    },
    visualMagnitude: 6.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.79529414),
        dec: Angle.Degrees(-62.58970553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91026"},
        {"Hipparcos Number", "HIP 51306"},
        {"Geneva Identification System", "GEN# +1.00091026"},
        {"Smithsonian Astrophysical Observation", "SAO 250974"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.19364117),
        dec: Angle.Degrees(-62.58865558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168263"},
        {"Hipparcos Number", "HIP 90087"},
        {"Smithsonian Astrophysical Observation", "SAO 254223"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.76312942),
        dec: Angle.Degrees(-62.58770229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125331"},
        {"Hipparcos Number", "HIP 70133"},
        {"Geneva Identification System", "GEN# +1.00125331"},
        {"Smithsonian Astrophysical Observation", "SAO 252710"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.26521431),
        dec: Angle.Degrees(-62.58697644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89122"},
        {"Hipparcos Number", "HIP 50197"},
        {"Geneva Identification System", "GEN# +1.00089122"},
        {"Smithsonian Astrophysical Observation", "SAO 250893"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.71076118),
        dec: Angle.Degrees(-62.58686537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -238.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16226"},
        {"Hipparcos Number", "HIP 11900"},
        {"Geneva Identification System", "GEN# +1.00016226"},
        {"Smithsonian Astrophysical Observation", "SAO 248595"},
        {"Wilson Evans Batten Catalogue", "WEB 2463"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.38984476),
        dec: Angle.Degrees(-62.58675030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207283"},
        {"Hipparcos Number", "HIP 107783"},
        {"Smithsonian Astrophysical Observation", "SAO 255085"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.52718983),
        dec: Angle.Degrees(-62.58672238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86703"},
        {"Hipparcos Number", "HIP 48873"},
        {"Geneva Identification System", "GEN# +1.00086703"},
        {"Smithsonian Astrophysical Observation", "SAO 250766"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.52993573),
        dec: Angle.Degrees(-62.58541517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91027"},
        {"Hipparcos Number", "HIP 51308"},
        {"Celescope Catalog", "CEL 3552"},
        {"Geneva Identification System", "GEN# +1.00091027"},
        {"Smithsonian Astrophysical Observation", "SAO 250976"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.20214134),
        dec: Angle.Degrees(-62.58402340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115071"},
        {"Hipparcos Number", "HIP 64737"},
        {"Celescope Catalog", "CEL 4222"},
        {"Geneva Identification System", "GEN# +1.00115071"},
        {"Smithsonian Astrophysical Observation", "SAO 252233"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.02002835),
        dec: Angle.Degrees(-62.58374253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220194"},
        {"Hipparcos Number", "HIP 115397"},
        {"Geneva Identification System", "GEN# +1.00220194"},
        {"Smithsonian Astrophysical Observation", "SAO 255472"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.63909440),
        dec: Angle.Degrees(-62.58369698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105627"},
        {"Hipparcos Number", "HIP 59288"},
        {"Celescope Catalog", "CEL 4061"},
        {"Geneva Identification System", "GEN# +1.00105627"},
        {"Smithsonian Astrophysical Observation", "SAO 251769"},
        {"Wilson Evans Batten Catalogue", "WEB 10544"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.43579622),
        dec: Angle.Degrees(-62.58184493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35918"},
        {"Hipparcos Number", "HIP 25231"},
        {"Smithsonian Astrophysical Observation", "SAO 249264"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.94166992),
        dec: Angle.Degrees(-62.58178137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178711"},
        {"Hipparcos Number", "HIP 94480"},
        {"Geneva Identification System", "GEN# +1.00178711"},
        {"Smithsonian Astrophysical Observation", "SAO 254498"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.43596922),
        dec: Angle.Degrees(-62.58052008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104495"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.51680966),
        dec: Angle.Degrees(-62.57955418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 311863"},
        {"Hipparcos Number", "HIP 62359"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.68061201),
        dec: Angle.Degrees(-62.57935539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175534"},
        {"Hipparcos Number", "HIP 93267"},
        {"Smithsonian Astrophysical Observation", "SAO 254429"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.98926643),
        dec: Angle.Degrees(-62.57912995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20766"},
        {"Hipparcos Number", "HIP 15330"},
        {"Cincinnati Publication", "Ci 20 224"},
        {"Geneva Identification System", "GEN# +1.00020766"},
        {"Smithsonian Astrophysical Observation", "SAO 248770"},
        {"Wilson Evans Batten Catalogue", "WEB 2948"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.43528798),
        dec: Angle.Degrees(-62.57689893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1337.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 648.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33946"},
    },
    visualMagnitude: 12.12,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.66337044),
        dec: Angle.Degrees(-62.57450811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153388"},
        {"Hipparcos Number", "HIP 83455"},
        {"Smithsonian Astrophysical Observation", "SAO 253777"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.83383101),
        dec: Angle.Degrees(-62.57372802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130679"},
        {"Hipparcos Number", "HIP 72754"},
        {"Geneva Identification System", "GEN# +1.00130679"},
        {"Smithsonian Astrophysical Observation", "SAO 252927"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.09763545),
        dec: Angle.Degrees(-62.57205994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33942"},
        {"Smithsonian Astrophysical Observation", "SAO 249718"},
    },
    visualMagnitude: 9.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.65740374),
        dec: Angle.Degrees(-62.57096267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146958"},
        {"Hipparcos Number", "HIP 80233"},
        {"Geneva Identification System", "GEN# +1.00146958"},
        {"Smithsonian Astrophysical Observation", "SAO 253524"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.69572835),
        dec: Angle.Degrees(-62.56926062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101545"},
        {"Hipparcos Number", "HIP 56961"},
        {"Celescope Catalog", "CEL 3952"},
        {"Geneva Identification System", "GEN# +3.29440132"},
        {"Smithsonian Astrophysical Observation", "SAO 251533"},
        {"Wilson Evans Batten Catalogue", "WEB 10253"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.15421034),
        dec: Angle.Degrees(-62.56810342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136227"},
        {"Hipparcos Number", "HIP 75258"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.65917683),
        dec: Angle.Degrees(-62.56698282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186725"},
        {"Hipparcos Number", "HIP 97575"},
        {"Geneva Identification System", "GEN# +1.00186725"},
        {"Smithsonian Astrophysical Observation", "SAO 254662"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.48286713),
        dec: Angle.Degrees(-62.56679858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199189"},
        {"Hipparcos Number", "HIP 103541"},
        {"Smithsonian Astrophysical Observation", "SAO 254912"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.66708835),
        dec: Angle.Degrees(-62.56454200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21521"},
        {"Hipparcos Number", "HIP 15912"},
        {"Smithsonian Astrophysical Observation", "SAO 248799"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.22976855),
        dec: Angle.Degrees(-62.56295241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112341"},
        {"Smithsonian Astrophysical Observation", "SAO 255306"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.32169990),
        dec: Angle.Degrees(-62.56244946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26636"},
        {"Hipparcos Number", "HIP 19369"},
        {"Smithsonian Astrophysical Observation", "SAO 248951"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.23452627),
        dec: Angle.Degrees(-62.56231034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47520"},
        {"Hipparcos Number", "HIP 31381"},
        {"Smithsonian Astrophysical Observation", "SAO 249592"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.69104357),
        dec: Angle.Degrees(-62.56202283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195869"},
        {"Hipparcos Number", "HIP 101731"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.30785977),
        dec: Angle.Degrees(-62.56194849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116607"},
        {"Hipparcos Number", "HIP 65543"},
        {"Geneva Identification System", "GEN# +1.00116607"},
        {"Smithsonian Astrophysical Observation", "SAO 252307"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53892392),
        dec: Angle.Degrees(-62.56055464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112123"},
        {"Hipparcos Number", "HIP 63036"},
        {"Celescope Catalog", "CEL 4169"},
        {"Geneva Identification System", "GEN# +1.00112123"},
        {"Smithsonian Astrophysical Observation", "SAO 252089"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.76086329),
        dec: Angle.Degrees(-62.55884702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46367"},
        {"Hipparcos Number", "HIP 30848"},
        {"Smithsonian Astrophysical Observation", "SAO 249559"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.17439518),
        dec: Angle.Degrees(-62.55772219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22597"},
        {"Hipparcos Number", "HIP 16682"},
        {"Geneva Identification System", "GEN# +1.00022597"},
        {"Smithsonian Astrophysical Observation", "SAO 248841"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.65974993),
        dec: Angle.Degrees(-62.55735235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83833"},
        {"Hipparcos Number", "HIP 47309"},
        {"Geneva Identification System", "GEN# +1.00083833J"},
        {"Smithsonian Astrophysical Observation", "SAO 250646"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.61380887),
        dec: Angle.Degrees(-62.55590735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149770"},
        {"Hipparcos Number", "HIP 81649"},
        {"Geneva Identification System", "GEN# +1.00149770J"},
        {"Smithsonian Astrophysical Observation", "SAO 253648"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.18513630),
        dec: Angle.Degrees(-62.55459119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83945"},
        {"Hipparcos Number", "HIP 47379"},
        {"Geneva Identification System", "GEN# +1.00083945"},
        {"Smithsonian Astrophysical Observation", "SAO 250652"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.79199823),
        dec: Angle.Degrees(-62.55447464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150097"},
        {"Hipparcos Number", "HIP 81823"},
        {"Smithsonian Astrophysical Observation", "SAO 253672"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.70174910),
        dec: Angle.Degrees(-62.55390958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206691"},
        {"Hipparcos Number", "HIP 107496"},
        {"Fundamental Katalog 5th Edition", "FK5 3738"},
        {"Smithsonian Astrophysical Observation", "SAO 255068"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.58222142),
        dec: Angle.Degrees(-62.54970361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215158"},
        {"Hipparcos Number", "HIP 112286"},
        {"Smithsonian Astrophysical Observation", "SAO 255301"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.15511214),
        dec: Angle.Degrees(-62.54830632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211729"},
        {"Hipparcos Number", "HIP 110355"},
        {"Geneva Identification System", "GEN# +1.00211729"},
        {"Smithsonian Astrophysical Observation", "SAO 255205"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.26558075),
        dec: Angle.Degrees(-62.54818775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14805"},
        {"Hipparcos Number", "HIP 10927"},
        {"Smithsonian Astrophysical Observation", "SAO 248540"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.17951904),
        dec: Angle.Degrees(-62.54604506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143238"},
        {"Hipparcos Number", "HIP 78603"},
        {"Geneva Identification System", "GEN# +1.00143238"},
        {"Smithsonian Astrophysical Observation", "SAO 253390"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.71887986),
        dec: Angle.Degrees(-62.54152474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149041"},
        {"Hipparcos Number", "HIP 81278"},
        {"Geneva Identification System", "GEN# +1.00149041"},
        {"Smithsonian Astrophysical Observation", "SAO 253617"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.01019868),
        dec: Angle.Degrees(-62.54023525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212522"},
        {"Hipparcos Number", "HIP 110781"},
        {"Fundamental Katalog 5th Edition", "FK5 5978"},
        {"Smithsonian Astrophysical Observation", "SAO 255218"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.64671523),
        dec: Angle.Degrees(-62.53955465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106538"},
        {"Hipparcos Number", "HIP 59781"},
        {"Smithsonian Astrophysical Observation", "SAO 251814"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.86797351),
        dec: Angle.Degrees(-62.53902969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181137"},
        {"Hipparcos Number", "HIP 95296"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.81186158),
        dec: Angle.Degrees(-62.53782148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196845"},
        {"Hipparcos Number", "HIP 102265"},
        {"Geneva Identification System", "GEN# +1.00196845"},
        {"Smithsonian Astrophysical Observation", "SAO 254856"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.81745471),
        dec: Angle.Degrees(-62.53752243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89203"},
        {"Hipparcos Number", "HIP 50242"},
        {"Celescope Catalog", "CEL 3483"},
        {"Geneva Identification System", "GEN# +1.00089203"},
        {"Smithsonian Astrophysical Observation", "SAO 250896"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.88236258),
        dec: Angle.Degrees(-62.53701162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129594"},
        {"Hipparcos Number", "HIP 72206"},
        {"Geneva Identification System", "GEN# +1.00129594"},
        {"Smithsonian Astrophysical Observation", "SAO 252873"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.51497962),
        dec: Angle.Degrees(-62.53568851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109891"},
        {"Hipparcos Number", "HIP 61715"},
        {"Smithsonian Astrophysical Observation", "SAO 251982"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.75378247),
        dec: Angle.Degrees(-62.52944786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74277"},
        {"Hipparcos Number", "HIP 42490"},
        {"Smithsonian Astrophysical Observation", "SAO 250295"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.93412391),
        dec: Angle.Degrees(-62.52749053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115669"},
        {"Hipparcos Number", "HIP 65050"},
        {"Smithsonian Astrophysical Observation", "SAO 252268"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.00887586),
        dec: Angle.Degrees(-62.52660375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173050"},
        {"Hipparcos Number", "HIP 92213"},
        {"Smithsonian Astrophysical Observation", "SAO 254370"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.89565968),
        dec: Angle.Degrees(-62.52560313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212580"},
        {"Hipparcos Number", "HIP 110812"},
        {"Geneva Identification System", "GEN# +1.00212580"},
        {"Smithsonian Astrophysical Observation", "SAO 255220"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.76036698),
        dec: Angle.Degrees(-62.52480059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75070"},
        {"Hipparcos Number", "HIP 42889"},
        {"Geneva Identification System", "GEN# +1.00075070"},
        {"Smithsonian Astrophysical Observation", "SAO 250316"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.10625897),
        dec: Angle.Degrees(-62.52475001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141055"},
        {"Hipparcos Number", "HIP 77600"},
        {"Geneva Identification System", "GEN# +1.00141055"},
        {"Smithsonian Astrophysical Observation", "SAO 253310"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.63869671),
        dec: Angle.Degrees(-62.52294340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28732"},
        {"Hipparcos Number", "HIP 20825"},
        {"Geneva Identification System", "GEN# +1.00028732"},
        {"Smithsonian Astrophysical Observation", "SAO 249029"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.94184598),
        dec: Angle.Degrees(-62.52121428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130888"},
        {"Hipparcos Number", "HIP 72853"},
        {"Smithsonian Astrophysical Observation", "SAO 252939"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.36193161),
        dec: Angle.Degrees(-62.51947388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157272"},
        {"Hipparcos Number", "HIP 85353"},
        {"Geneva Identification System", "GEN# +1.00157272"},
        {"Smithsonian Astrophysical Observation", "SAO 253919"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.62574065),
        dec: Angle.Degrees(-62.51400261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205138"},
        {"Hipparcos Number", "HIP 106627"},
        {"Smithsonian Astrophysical Observation", "SAO 255031"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.96316296),
        dec: Angle.Degrees(-62.51386252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139969"},
        {"Hipparcos Number", "HIP 77106"},
        {"Smithsonian Astrophysical Observation", "SAO 253271"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.16455942),
        dec: Angle.Degrees(-62.51365956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131925"},
        {"Hipparcos Number", "HIP 73347"},
        {"Smithsonian Astrophysical Observation", "SAO 252982"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.84133556),
        dec: Angle.Degrees(-62.50888392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127996"},
        {"Hipparcos Number", "HIP 71475"},
        {"Smithsonian Astrophysical Observation", "SAO 252821"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.26248230),
        dec: Angle.Degrees(-62.50863968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75908"},
        {"Hipparcos Number", "HIP 43324"},
        {"Geneva Identification System", "GEN# +1.00075908"},
        {"Smithsonian Astrophysical Observation", "SAO 250339"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.40672131),
        dec: Angle.Degrees(-62.50827384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163585"},
        {"Hipparcos Number", "HIP 88228"},
        {"Smithsonian Astrophysical Observation", "SAO 254107"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.25792159),
        dec: Angle.Degrees(-62.50798393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20807"},
        {"Hipparcos Number", "HIP 15371"},
        {"Cincinnati Publication", "Ci 20 226"},
        {"Geneva Identification System", "GEN# +1.00020807"},
        {"Smithsonian Astrophysical Observation", "SAO 248774"},
        {"Wilson Evans Batten Catalogue", "WEB 2954"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.54640411),
        dec: Angle.Degrees(-62.50793537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1331.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 646.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84810"},
        {"Hipparcos Number", "HIP 47854"},
        {"Fundamental Katalog 5th Edition", "FK5 1254"},
        {"Geneva Identification System", "GEN# +1.00084810"},
        {"Smithsonian Astrophysical Observation", "SAO 250683"},
        {"Wilson Evans Batten Catalogue", "WEB 8953"},
    },
    visualMagnitude: 3.69,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31178147),
        dec: Angle.Degrees(-62.50792328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122669"},
        {"Hipparcos Number", "HIP 68817"},
        {"Geneva Identification System", "GEN# +1.00122669"},
        {"Smithsonian Astrophysical Observation", "SAO 252590"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.34183356),
        dec: Angle.Degrees(-62.50739110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47603"},
        {"Hipparcos Number", "HIP 31438"},
        {"Smithsonian Astrophysical Observation", "SAO 249595"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.80827977),
        dec: Angle.Degrees(-62.50269542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168690"},
        {"Hipparcos Number", "HIP 90278"},
        {"Geneva Identification System", "GEN# +1.00168690"},
        {"Smithsonian Astrophysical Observation", "SAO 254235"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.30584007),
        dec: Angle.Degrees(-62.50165411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118846"},
        {"Hipparcos Number", "HIP 66768"},
        {"Smithsonian Astrophysical Observation", "SAO 252410"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.27899915),
        dec: Angle.Degrees(-62.49935079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109047"},
        {"Hipparcos Number", "HIP 61187"},
        {"Geneva Identification System", "GEN# +1.00109047"},
        {"Smithsonian Astrophysical Observation", "SAO 251947"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.06123951),
        dec: Angle.Degrees(-62.49927191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95096"},
        {"Hipparcos Number", "HIP 53567"},
        {"Smithsonian Astrophysical Observation", "SAO 251194"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.37517558),
        dec: Angle.Degrees(-62.49902839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4294"},
        {"Hipparcos Number", "HIP 3489"},
        {"Geneva Identification System", "GEN# +1.00004294"},
        {"Smithsonian Astrophysical Observation", "SAO 248243"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.13134786),
        dec: Angle.Degrees(-62.49760602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195145"},
        {"Hipparcos Number", "HIP 101399"},
        {"Geneva Identification System", "GEN# +1.00195145"},
        {"Smithsonian Astrophysical Observation", "SAO 254813"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.25145892),
        dec: Angle.Degrees(-62.49587106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22083"},
        {"Smithsonian Astrophysical Observation", "SAO 249096"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.26133788),
        dec: Angle.Degrees(-62.49326850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37350"},
        {"Hipparcos Number", "HIP 26069"},
        {"Fundamental Katalog 5th Edition", "FK5 212"},
        {"Geneva Identification System", "GEN# +1.00037350"},
        {"Smithsonian Astrophysical Observation", "SAO 249311"},
        {"Wilson Evans Batten Catalogue", "WEB 5075"},
    },
    visualMagnitude: 3.76,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.40631813),
        dec: Angle.Degrees(-62.48985585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191560"},
        {"Hipparcos Number", "HIP 99723"},
        {"Smithsonian Astrophysical Observation", "SAO 254755"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.52753169),
        dec: Angle.Degrees(-62.48954025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101947"},
        {"Hipparcos Number", "HIP 57175"},
        {"Celescope Catalog", "CEL 3962"},
        {"Geneva Identification System", "GEN# +4.31140004"},
        {"Smithsonian Astrophysical Observation", "SAO 251555"},
        {"Wilson Evans Batten Catalogue", "WEB 10286"},
    },
    visualMagnitude: 5.00,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.87999922),
        dec: Angle.Degrees(-62.48939856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91218"},
        {"Hipparcos Number", "HIP 51429"},
        {"Celescope Catalog", "CEL 3555"},
        {"Geneva Identification System", "GEN# +1.00091218"},
        {"Smithsonian Astrophysical Observation", "SAO 250987"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.54880524),
        dec: Angle.Degrees(-62.48938487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121454"},
        {"Hipparcos Number", "HIP 68170"},
        {"Smithsonian Astrophysical Observation", "SAO 252530"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.33948172),
        dec: Angle.Degrees(-62.48879048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69454"},
        {"Hipparcos Number", "HIP 40275"},
        {"Smithsonian Astrophysical Observation", "SAO 250152"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.37397013),
        dec: Angle.Degrees(-62.48666003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101035"},
        {"Hipparcos Number", "HIP 56660"},
        {"Smithsonian Astrophysical Observation", "SAO 251487"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.26677048),
        dec: Angle.Degrees(-62.48536757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177126"},
        {"Hipparcos Number", "HIP 93918"},
        {"Geneva Identification System", "GEN# +1.00177126"},
        {"Smithsonian Astrophysical Observation", "SAO 254467"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.85863393),
        dec: Angle.Degrees(-62.48512697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95393"},
        {"Hipparcos Number", "HIP 53734"},
        {"Geneva Identification System", "GEN# +1.00095393"},
        {"Smithsonian Astrophysical Observation", "SAO 251206"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.90558011),
        dec: Angle.Degrees(-62.48418852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3610"},
        {"Hipparcos Number", "HIP 3007"},
        {"Smithsonian Astrophysical Observation", "SAO 248229"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.56116189),
        dec: Angle.Degrees(-62.48171928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6616"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.23352947),
        dec: Angle.Degrees(-62.48104442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 271.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113015"},
        {"Hipparcos Number", "HIP 63586"},
        {"Smithsonian Astrophysical Observation", "SAO 252133"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.45530241),
        dec: Angle.Degrees(-62.48102177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124488"},
        {"Hipparcos Number", "HIP 69719"},
        {"Geneva Identification System", "GEN# +1.00124488"},
        {"Smithsonian Astrophysical Observation", "SAO 252676"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.06460146),
        dec: Angle.Degrees(-62.47937444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123590"},
        {"Hipparcos Number", "HIP 69261"},
        {"Geneva Identification System", "GEN# +1.00123590"},
        {"Smithsonian Astrophysical Observation", "SAO 252638"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.68322637),
        dec: Angle.Degrees(-62.47900417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101794"},
        {"Hipparcos Number", "HIP 57106"},
        {"Celescope Catalog", "CEL 3956"},
        {"Geneva Identification System", "GEN# +4.31140013"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.60564924),
        dec: Angle.Degrees(-62.47707562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208580"},
        {"Hipparcos Number", "HIP 108538"},
        {"Geneva Identification System", "GEN# +1.00208580"},
        {"Smithsonian Astrophysical Observation", "SAO 255117"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.81907001),
        dec: Angle.Degrees(-62.47693165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9798"},
        {"Hipparcos Number", "HIP 7298"},
        {"Geneva Identification System", "GEN# +1.00009798"},
        {"Smithsonian Astrophysical Observation", "SAO 248401"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.49937640),
        dec: Angle.Degrees(-62.47621309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27256"},
        {"Hipparcos Number", "HIP 19780"},
        {"Fundamental Katalog 5th Edition", "FK5 156"},
        {"Geneva Identification System", "GEN# +1.00027256"},
        {"Smithsonian Astrophysical Observation", "SAO 248969"},
        {"Wilson Evans Batten Catalogue", "WEB 3774"},
    },
    visualMagnitude: 3.33,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.60596306),
        dec: Angle.Degrees(-62.47397888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82851"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.97936008),
        dec: Angle.Degrees(-62.46915237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -316.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101146"},
        {"Hipparcos Number", "HIP 56723"},
        {"Celescope Catalog", "CEL 3932"},
        {"Geneva Identification System", "GEN# +1.00101146"},
        {"Smithsonian Astrophysical Observation", "SAO 251499"},
        {"Wilson Evans Batten Catalogue", "WEB 10202"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.44969176),
        dec: Angle.Degrees(-62.46854742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51685"},
        {"Hipparcos Number", "HIP 33162"},
        {"Smithsonian Astrophysical Observation", "SAO 249674"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.54961627),
        dec: Angle.Degrees(-62.46333607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121752"},
        {"Hipparcos Number", "HIP 68339"},
        {"Smithsonian Astrophysical Observation", "SAO 252540"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.83370979),
        dec: Angle.Degrees(-62.46033723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194419"},
        {"Hipparcos Number", "HIP 101031"},
        {"Geneva Identification System", "GEN# +1.00194419"},
        {"Smithsonian Astrophysical Observation", "SAO 254798"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.22597520),
        dec: Angle.Degrees(-62.45902606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83391"},
        {"Hipparcos Number", "HIP 47063"},
        {"Geneva Identification System", "GEN# +1.00083391"},
        {"Smithsonian Astrophysical Observation", "SAO 250631"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.86872800),
        dec: Angle.Degrees(-62.45899371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18865"},
        {"Hipparcos Number", "HIP 13900"},
        {"Geneva Identification System", "GEN# +1.00018865"},
        {"Smithsonian Astrophysical Observation", "SAO 248702"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.74395337),
        dec: Angle.Degrees(-62.45816984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22610"},
        {"Hipparcos Number", "HIP 16693"},
        {"Geneva Identification System", "GEN# +1.00022610"},
        {"Smithsonian Astrophysical Observation", "SAO 248845"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.68840879),
        dec: Angle.Degrees(-62.45702370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98956"},
        {"Hipparcos Number", "HIP 55534"},
        {"Renson", "Renson 28520"},
        {"Smithsonian Astrophysical Observation", "SAO 251375"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.62161684),
        dec: Angle.Degrees(-62.45545830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186251"},
        {"Hipparcos Number", "HIP 97345"},
        {"Smithsonian Astrophysical Observation", "SAO 254648"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.77418254),
        dec: Angle.Degrees(-62.45356843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32140"},
        {"Hipparcos Number", "HIP 22980"},
        {"Smithsonian Astrophysical Observation", "SAO 249152"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.17961823),
        dec: Angle.Degrees(-62.45247793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63365"},
        {"Hipparcos Number", "HIP 37774"},
        {"Fundamental Katalog 5th Edition", "FK5 4698"},
        {"Smithsonian Astrophysical Observation", "SAO 249942"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.18611421),
        dec: Angle.Degrees(-62.45205210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5826"},
        {"Hipparcos Number", "HIP 4590"},
        {"Smithsonian Astrophysical Observation", "SAO 248295"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.68755155),
        dec: Angle.Degrees(-62.45182375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119646"},
        {"Hipparcos Number", "HIP 67206"},
        {"Geneva Identification System", "GEN# +1.00119646"},
        {"Smithsonian Astrophysical Observation", "SAO 252439"},
        {"Wilson Evans Batten Catalogue", "WEB 11827"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57501747),
        dec: Angle.Degrees(-62.45159252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103884"},
        {"Hipparcos Number", "HIP 58326"},
        {"Celescope Catalog", "CEL 4023"},
        {"Geneva Identification System", "GEN# +1.00103884"},
        {"Smithsonian Astrophysical Observation", "SAO 251659"},
        {"Wilson Evans Batten Catalogue", "WEB 10429"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.41682551),
        dec: Angle.Degrees(-62.44873578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36817"},
        {"Hipparcos Number", "HIP 25759"},
        {"Smithsonian Astrophysical Observation", "SAO 249295"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.51266948),
        dec: Angle.Degrees(-62.44872449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103168"},
        {"Hipparcos Number", "HIP 57899"},
        {"Smithsonian Astrophysical Observation", "SAO 251620"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.13309640),
        dec: Angle.Degrees(-62.44830575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163785"},
        {"Hipparcos Number", "HIP 88311"},
        {"Smithsonian Astrophysical Observation", "SAO 254112"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.53051924),
        dec: Angle.Degrees(-62.44764797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8707"},
        {"Hipparcos Number", "HIP 6557"},
        {"Smithsonian Astrophysical Observation", "SAO 248378"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.06775739),
        dec: Angle.Degrees(-62.44688513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27774"},
        {"Hipparcos Number", "HIP 20149"},
        {"Smithsonian Astrophysical Observation", "SAO 248991"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.78606447),
        dec: Angle.Degrees(-62.44368462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100443"},
        {"Hipparcos Number", "HIP 56335"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.23049199),
        dec: Angle.Degrees(-62.44309452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102475"},
        {"Hipparcos Number", "HIP 57511"},
        {"Celescope Catalog", "CEL 3980"},
        {"Geneva Identification System", "GEN# +1.00102475"},
        {"Smithsonian Astrophysical Observation", "SAO 251590"},
        {"Wilson Evans Batten Catalogue", "WEB 10330"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.82578587),
        dec: Angle.Degrees(-62.43618561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109978"},
        {"Hipparcos Number", "HIP 61772"},
        {"Geneva Identification System", "GEN# +1.00109978"},
        {"Smithsonian Astrophysical Observation", "SAO 251985"},
        {"Wilson Evans Batten Catalogue", "WEB 10988"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.90691516),
        dec: Angle.Degrees(-62.43362879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101498"},
        {"Hipparcos Number", "HIP 56929"},
        {"Smithsonian Astrophysical Observation", "SAO 251528"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.06729908),
        dec: Angle.Degrees(-62.43240706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7503"},
        {"Hipparcos Number", "HIP 5736"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.43140893),
        dec: Angle.Degrees(-62.43135052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102962"},
        {"Geneva Identification System", "GEN# +1.00198160"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.91001311),
        dec: Angle.Degrees(-62.42921513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140248"},
        {"Hipparcos Number", "HIP 77224"},
        {"Smithsonian Astrophysical Observation", "SAO 253284"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.50976160),
        dec: Angle.Degrees(-62.42897451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1985"},
        {"Hipparcos Number", "HIP 1877"},
        {"Geneva Identification System", "GEN# +1.00001985"},
        {"Smithsonian Astrophysical Observation", "SAO 248178"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.92704710),
        dec: Angle.Degrees(-62.42527363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96566"},
        {"Hipparcos Number", "HIP 54301"},
        {"Geneva Identification System", "GEN# +1.00096566"},
        {"Smithsonian Astrophysical Observation", "SAO 251269"},
        {"Wilson Evans Batten Catalogue", "WEB 9808"},
    },
    visualMagnitude: 4.62,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.63530960),
        dec: Angle.Degrees(-62.42413654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45817"},
        {"Hipparcos Number", "HIP 30555"},
        {"Geneva Identification System", "GEN# +1.00045817"},
        {"Smithsonian Astrophysical Observation", "SAO 249544"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.35354772),
        dec: Angle.Degrees(-62.42281233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85826"},
        {"Hipparcos Number", "HIP 48415"},
        {"Smithsonian Astrophysical Observation", "SAO 250732"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.05953711),
        dec: Angle.Degrees(-62.42249689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147463"},
        {"Hipparcos Number", "HIP 80501"},
        {"Smithsonian Astrophysical Observation", "SAO 253544"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.49279487),
        dec: Angle.Degrees(-62.42113570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12490"},
        {"Hipparcos Number", "HIP 9364"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.07756610),
        dec: Angle.Degrees(-62.42060698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62138"},
        {"Hipparcos Number", "HIP 37200"},
        {"Smithsonian Astrophysical Observation", "SAO 249908"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.63271443),
        dec: Angle.Degrees(-62.41691221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36820"},
        {"Smithsonian Astrophysical Observation", "SAO 249882"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.57992957),
        dec: Angle.Degrees(-62.41549509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125515"},
        {"Hipparcos Number", "HIP 70237"},
        {"Geneva Identification System", "GEN# +1.00125515"},
        {"Smithsonian Astrophysical Observation", "SAO 252721"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.56206549),
        dec: Angle.Degrees(-62.41100543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99026"},
        {"Hipparcos Number", "HIP 55572"},
        {"Smithsonian Astrophysical Observation", "SAO 251378"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.74529239),
        dec: Angle.Degrees(-62.40719612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81101"},
        {"Hipparcos Number", "HIP 45856"},
        {"Fundamental Katalog 5th Edition", "FK5 2745"},
        {"Geneva Identification System", "GEN# +1.00081101"},
        {"Smithsonian Astrophysical Observation", "SAO 250544"},
        {"Wilson Evans Batten Catalogue", "WEB 8695"},
    },
    visualMagnitude: 4.79,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.23679302),
        dec: Angle.Degrees(-62.40463293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82725"},
    },
    visualMagnitude: 11.72,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.63394770),
        dec: Angle.Degrees(-62.40374141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 254.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 173.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133307"},
        {"Hipparcos Number", "HIP 73950"},
        {"Smithsonian Astrophysical Observation", "SAO 253019"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.67886287),
        dec: Angle.Degrees(-62.40118066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82724",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82724"},
    },
    visualMagnitude: 11.85,
    bvColour: 1.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.63222815),
        dec: Angle.Degrees(-62.40023361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 294.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 205.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16390"},
        {"Hipparcos Number", "HIP 12027"},
        {"Smithsonian Astrophysical Observation", "SAO 248603"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.77426998),
        dec: Angle.Degrees(-62.39943559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136827"},
        {"Hipparcos Number", "HIP 75544"},
        {"Smithsonian Astrophysical Observation", "SAO 253158"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.50155762),
        dec: Angle.Degrees(-62.39553868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70875"},
        {"Hipparcos Number", "HIP 40908"},
        {"Smithsonian Astrophysical Observation", "SAO 250198"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.22370820),
        dec: Angle.Degrees(-62.39347654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18119"},
        {"Hipparcos Number", "HIP 13335"},
        {"Smithsonian Astrophysical Observation", "SAO 248666"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.91025558),
        dec: Angle.Degrees(-62.39301635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217963"},
        {"Hipparcos Number", "HIP 114015"},
        {"Smithsonian Astrophysical Observation", "SAO 255399"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.35068496),
        dec: Angle.Degrees(-62.39093998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33516"},
        {"Hipparcos Number", "HIP 23775"},
        {"Smithsonian Astrophysical Observation", "SAO 249191"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.64336887),
        dec: Angle.Degrees(-62.38553113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217646"},
        {"Hipparcos Number", "HIP 113837"},
        {"Smithsonian Astrophysical Observation", "SAO 255386"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.79298185),
        dec: Angle.Degrees(-62.38287429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183675"},
        {"Hipparcos Number", "HIP 96272"},
        {"Smithsonian Astrophysical Observation", "SAO 254597"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.63696540),
        dec: Angle.Degrees(-62.38244605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115514"},
        {"Hipparcos Number", "HIP 64969"},
        {"Geneva Identification System", "GEN# +1.00115514"},
        {"Wilson Evans Batten Catalogue", "WEB 11481"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.74287892),
        dec: Angle.Degrees(-62.38232960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135434"},
        {"Hipparcos Number", "HIP 74887"},
        {"Smithsonian Astrophysical Observation", "SAO 253095"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.56749336),
        dec: Angle.Degrees(-62.38214934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65191"},
        {"Hipparcos Number", "HIP 38568"},
        {"Geneva Identification System", "GEN# +1.00065191"},
        {"Smithsonian Astrophysical Observation", "SAO 250001"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.45099020),
        dec: Angle.Degrees(-62.38018064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29920"},
        {"Hipparcos Number", "HIP 21634"},
        {"Smithsonian Astrophysical Observation", "SAO 249072"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.70533399),
        dec: Angle.Degrees(-62.37860852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123506"},
        {"Hipparcos Number", "HIP 69216"},
        {"Geneva Identification System", "GEN# +1.00123506"},
        {"Smithsonian Astrophysical Observation", "SAO 252633"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.55985642),
        dec: Angle.Degrees(-62.37807205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201905"},
        {"Hipparcos Number", "HIP 104940"},
        {"Smithsonian Astrophysical Observation", "SAO 254962"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.85927583),
        dec: Angle.Degrees(-62.37681376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218008"},
        {"Hipparcos Number", "HIP 114038"},
        {"Smithsonian Astrophysical Observation", "SAO 255400"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.41180940),
        dec: Angle.Degrees(-62.37675455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122905"},
        {"Hipparcos Number", "HIP 68945"},
        {"Fundamental Katalog 5th Edition", "FK5 5251"},
        {"Smithsonian Astrophysical Observation", "SAO 252598"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.69724962),
        dec: Angle.Degrees(-62.37426025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98822"},
        {"Hipparcos Number", "HIP 55468"},
        {"Smithsonian Astrophysical Observation", "SAO 251370"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.39712073),
        dec: Angle.Degrees(-62.37420555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165069"},
        {"Hipparcos Number", "HIP 88851"},
        {"Geneva Identification System", "GEN# +1.00165069"},
        {"Smithsonian Astrophysical Observation", "SAO 254145"},
        {"Wilson Evans Batten Catalogue", "WEB 15061"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.07988838),
        dec: Angle.Degrees(-62.37264076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173397"},
        {"Hipparcos Number", "HIP 92342"},
        {"Fundamental Katalog 5th Edition", "FK5 5655"},
        {"Geneva Identification System", "GEN# +1.00173397"},
        {"Smithsonian Astrophysical Observation", "SAO 254378"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.30252649),
        dec: Angle.Degrees(-62.37136650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150096"},
        {"Hipparcos Number", "HIP 81820"},
        {"Smithsonian Astrophysical Observation", "SAO 253671"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.69502045),
        dec: Angle.Degrees(-62.37003889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44026"},
        {"Hipparcos Number", "HIP 29682"},
        {"Smithsonian Astrophysical Observation", "SAO 249492"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.79760375),
        dec: Angle.Degrees(-62.36998458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186785"},
        {"Hipparcos Number", "HIP 97608"},
        {"Geneva Identification System", "GEN# +1.00186785"},
        {"Smithsonian Astrophysical Observation", "SAO 254665"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.57519789),
        dec: Angle.Degrees(-62.36612619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131491"},
        {"Hipparcos Number", "HIP 73118"},
        {"Geneva Identification System", "GEN# +1.00131491J"},
        {"Smithsonian Astrophysical Observation", "SAO 252964"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.15978648),
        dec: Angle.Degrees(-62.36440739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94261"},
        {"Hipparcos Number", "HIP 53063"},
        {"Smithsonian Astrophysical Observation", "SAO 251152"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.84818346),
        dec: Angle.Degrees(-62.36356974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135058"},
        {"Hipparcos Number", "HIP 74729"},
        {"Smithsonian Astrophysical Observation", "SAO 253079"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.08829235),
        dec: Angle.Degrees(-62.36339993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82468"},
        {"Hipparcos Number", "HIP 46546"},
        {"Geneva Identification System", "GEN# +1.00082468"},
        {"Smithsonian Astrophysical Observation", "SAO 250597"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.38826527),
        dec: Angle.Degrees(-62.36094878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81698"},
        {"Hipparcos Number", "HIP 46141"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.14468957),
        dec: Angle.Degrees(-62.36078323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20052"},
        {"Hipparcos Number", "HIP 14720"},
        {"Geneva Identification System", "GEN# +1.00020052"},
        {"Smithsonian Astrophysical Observation", "SAO 248747"},
        {"Wilson Evans Batten Catalogue", "WEB 2853"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.53667698),
        dec: Angle.Degrees(-62.35736245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62715"},
        {"Hipparcos Number", "HIP 37474"},
        {"Smithsonian Astrophysical Observation", "SAO 249922"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.37874858),
        dec: Angle.Degrees(-62.35732544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39799"},
        {"Smithsonian Astrophysical Observation", "SAO 250119"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.99653006),
        dec: Angle.Degrees(-62.35621120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130911"},
        {"Hipparcos Number", "HIP 72864"},
        {"Smithsonian Astrophysical Observation", "SAO 252942"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.39829834),
        dec: Angle.Degrees(-62.35606921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116374"},
        {"Hipparcos Number", "HIP 65444"},
        {"Geneva Identification System", "GEN# +1.00116374"},
        {"Smithsonian Astrophysical Observation", "SAO 252300"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.18781411),
        dec: Angle.Degrees(-62.35605708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44436"},
    },
    visualMagnitude: 11.23,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.80763857),
        dec: Angle.Degrees(-62.35588403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45038"},
        {"Hipparcos Number", "HIP 30173"},
        {"Geneva Identification System", "GEN# +1.00045038"},
        {"Smithsonian Astrophysical Observation", "SAO 249519"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.22994865),
        dec: Angle.Degrees(-62.35406032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90139"},
        {"Hipparcos Number", "HIP 50816"},
        {"Celescope Catalog", "CEL 3521"},
        {"Geneva Identification System", "GEN# +1.00090139"},
        {"Smithsonian Astrophysical Observation", "SAO 250935"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.62418511),
        dec: Angle.Degrees(-62.35306666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78084"},
        {"Hipparcos Number", "HIP 44435"},
        {"Geneva Identification System", "GEN# +1.00078084"},
        {"Smithsonian Astrophysical Observation", "SAO 250425"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.79834675),
        dec: Angle.Degrees(-62.35174849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202795"},
        {"Hipparcos Number", "HIP 105405"},
        {"Smithsonian Astrophysical Observation", "SAO 254980"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.25154889),
        dec: Angle.Degrees(-62.34947962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159992"},
        {"Hipparcos Number", "HIP 86597"},
        {"Renson", "Renson 45070"},
        {"Smithsonian Astrophysical Observation", "SAO 254002"},
    },
    visualMagnitude: 9.40,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.44974064),
        dec: Angle.Degrees(-62.34732171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65623"},
        {"Hipparcos Number", "HIP 38740"},
        {"Smithsonian Astrophysical Observation", "SAO 250016"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.96731628),
        dec: Angle.Degrees(-62.34683718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118137"},
        {"Hipparcos Number", "HIP 66379"},
        {"Smithsonian Astrophysical Observation", "SAO 252382"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.13912936),
        dec: Angle.Degrees(-62.34503060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117540"},
        {"Hipparcos Number", "HIP 66056"},
        {"Smithsonian Astrophysical Observation", "SAO 252356"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.13362078),
        dec: Angle.Degrees(-62.34413316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72843"},
        {"Hipparcos Number", "HIP 41825"},
        {"Celescope Catalog", "CEL 2624"},
        {"Smithsonian Astrophysical Observation", "SAO 250258"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.90957789),
        dec: Angle.Degrees(-62.33903723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11912",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11912"},
        {"Smithsonian Astrophysical Observation", "SAO 248597"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.43459590),
        dec: Angle.Degrees(-62.33761400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 228.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182003"},
        {"Hipparcos Number", "HIP 95595"},
        {"Smithsonian Astrophysical Observation", "SAO 254574"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.65877923),
        dec: Angle.Degrees(-62.33216268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130286"},
        {"Hipparcos Number", "HIP 72556"},
        {"Smithsonian Astrophysical Observation", "SAO 252907"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.50437032),
        dec: Angle.Degrees(-62.33074785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165276"},
        {"Hipparcos Number", "HIP 88939"},
        {"Smithsonian Astrophysical Observation", "SAO 254152"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.32084830),
        dec: Angle.Degrees(-62.32664515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172098"},
        {"Hipparcos Number", "HIP 91741"},
        {"Geneva Identification System", "GEN# +1.00172098"},
        {"Smithsonian Astrophysical Observation", "SAO 254346"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.62091727),
        dec: Angle.Degrees(-62.32542316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41016"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.55770353),
        dec: Angle.Degrees(-62.32337551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163564"},
        {"Hipparcos Number", "HIP 88215"},
        {"Smithsonian Astrophysical Observation", "SAO 254106"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.23788110),
        dec: Angle.Degrees(-62.32327707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189565"},
        {"Hipparcos Number", "HIP 98841"},
        {"Smithsonian Astrophysical Observation", "SAO 254719"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.08055236),
        dec: Angle.Degrees(-62.32222709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90202"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.08398678),
        dec: Angle.Degrees(-62.31908267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -213.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117704"},
        {"Hipparcos Number", "HIP 66153"},
        {"Geneva Identification System", "GEN# +1.00117704"},
        {"Smithsonian Astrophysical Observation", "SAO 252364"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.40419466),
        dec: Angle.Degrees(-62.31765228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79447"},
        {"Hipparcos Number", "HIP 45101"},
        {"Celescope Catalog", "CEL 3214"},
        {"Geneva Identification System", "GEN# +1.00079447"},
        {"Smithsonian Astrophysical Observation", "SAO 250471"},
        {"Wilson Evans Batten Catalogue", "WEB 8606"},
    },
    visualMagnitude: 3.96,
    bvColour: -0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.81986611),
        dec: Angle.Degrees(-62.31701587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117688"},
        {"Hipparcos Number", "HIP 66142"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.37553797),
        dec: Angle.Degrees(-62.31699950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152122"},
        {"Hipparcos Number", "HIP 82813"},
        {"Smithsonian Astrophysical Observation", "SAO 253735"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.86239940),
        dec: Angle.Degrees(-62.31694765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38521"},
        {"Smithsonian Astrophysical Observation", "SAO 249994"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.32986954),
        dec: Angle.Degrees(-62.31598547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 310"},
        {"Hipparcos Number", "HIP 621"},
        {"Smithsonian Astrophysical Observation", "SAO 248120"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.90242019),
        dec: Angle.Degrees(-62.31507712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36689"},
        {"Hipparcos Number", "HIP 25700"},
        {"Geneva Identification System", "GEN# +1.00036689"},
        {"Smithsonian Astrophysical Observation", "SAO 249288"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.32215444),
        dec: Angle.Degrees(-62.31420395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153895"},
        {"Hipparcos Number", "HIP 83681"},
        {"Smithsonian Astrophysical Observation", "SAO 253791"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54625261),
        dec: Angle.Degrees(-62.30693556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89349"},
        {"Hipparcos Number", "HIP 50331"},
        {"Smithsonian Astrophysical Observation", "SAO 250904"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.16717351),
        dec: Angle.Degrees(-62.30590097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55645"},
        {"Hipparcos Number", "HIP 34571"},
        {"Geneva Identification System", "GEN# +1.00055645"},
        {"Renson", "Renson 15130"},
        {"Smithsonian Astrophysical Observation", "SAO 249756"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.40643164),
        dec: Angle.Degrees(-62.30518836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 565"},
        {"Hipparcos Number", "HIP 798"},
        {"Fundamental Katalog 5th Edition", "FK5 2007"},
        {"Geneva Identification System", "GEN# +1.00000565"},
        {"Smithsonian Astrophysical Observation", "SAO 248130"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.46706528),
        dec: Angle.Degrees(-62.29683686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102386"},
        {"Hipparcos Number", "HIP 57455"},
        {"Smithsonian Astrophysical Observation", "SAO 251583"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.66934074),
        dec: Angle.Degrees(-62.29510169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106325"},
        {"Hipparcos Number", "HIP 59663"},
        {"Geneva Identification System", "GEN# +1.00106325"},
        {"Smithsonian Astrophysical Observation", "SAO 251801"},
        {"Wilson Evans Batten Catalogue", "WEB 10600"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.53105392),
        dec: Angle.Degrees(-62.29154256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148431"},
        {"Hipparcos Number", "HIP 80957"},
        {"Smithsonian Astrophysical Observation", "SAO 253588"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.96372749),
        dec: Angle.Degrees(-62.29020989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20264"},
        {"Hipparcos Number", "HIP 14896"},
        {"Smithsonian Astrophysical Observation", "SAO 248755"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.06099944),
        dec: Angle.Degrees(-62.28751676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43957"},
        {"Hipparcos Number", "HIP 29652"},
        {"Geneva Identification System", "GEN# +1.00043957"},
        {"Smithsonian Astrophysical Observation", "SAO 249488"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.71392987),
        dec: Angle.Degrees(-62.28411781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213035"},
        {"Hipparcos Number", "HIP 111087"},
        {"Smithsonian Astrophysical Observation", "SAO 255235"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.57395894),
        dec: Angle.Degrees(-62.28227436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107447"},
        {"Hipparcos Number", "HIP 60259"},
        {"Geneva Identification System", "GEN# +1.00107447"},
        {"Smithsonian Astrophysical Observation", "SAO 251861"},
        {"Wilson Evans Batten Catalogue", "WEB 10717"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.33809471),
        dec: Angle.Degrees(-62.28163140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
