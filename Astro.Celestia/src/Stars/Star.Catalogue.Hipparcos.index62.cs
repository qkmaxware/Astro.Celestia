using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_62() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88290",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10990 AB"},
        {"Henry Draper", "HD 164577"},
        {"Hipparcos Number", "HIP 88290"},
        {"Geneva Identification System", "GEN# +1.00164577"},
        {"Smithsonian Astrophysical Observation", "SAO 123035"},
        {"Wilson Evans Batten Catalogue", "WEB 14923"},
    },
    visualMagnitude: 4.42,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.43828967),
        dec: Angle.Degrees(+01.30510936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105060"},
        {"Hipparcos Number", "HIP 59001"},
        {"Geneva Identification System", "GEN# +1.00105060"},
        {"Smithsonian Astrophysical Observation", "SAO 119217"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.46191239),
        dec: Angle.Degrees(+01.30544034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81691"},
        {"Hipparcos Number", "HIP 46366"},
        {"Smithsonian Astrophysical Observation", "SAO 117705"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.81239560),
        dec: Angle.Degrees(+01.30602091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177441"},
        {"Hipparcos Number", "HIP 93681"},
        {"Geneva Identification System", "GEN# +1.00177441"},
        {"Smithsonian Astrophysical Observation", "SAO 124227"},
        {"Wilson Evans Batten Catalogue", "WEB 16279"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.16423217),
        dec: Angle.Degrees(+01.30616155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154696"},
        {"Hipparcos Number", "HIP 83748"},
        {"Smithsonian Astrophysical Observation", "SAO 122087"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.74049643),
        dec: Angle.Degrees(+01.30630095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218103"},
        {"Hipparcos Number", "HIP 114005"},
        {"Fundamental Katalog 5th Edition", "FK5 6043"},
        {"Geneva Identification System", "GEN# +1.00218103"},
        {"Smithsonian Astrophysical Observation", "SAO 127960"},
        {"Wilson Evans Batten Catalogue", "WEB 20247"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.32338622),
        dec: Angle.Degrees(+01.30717903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219420"},
        {"Hipparcos Number", "HIP 114834"},
        {"Geneva Identification System", "GEN# +1.00219420"},
        {"Smithsonian Astrophysical Observation", "SAO 128069"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.91732352),
        dec: Angle.Degrees(+01.30837737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206282"},
        {"Hipparcos Number", "HIP 107072"},
        {"Smithsonian Astrophysical Observation", "SAO 126989"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.28086560),
        dec: Angle.Degrees(+01.30838813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134134"},
        {"Hipparcos Number", "HIP 74060"},
        {"Smithsonian Astrophysical Observation", "SAO 120856"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.03247544),
        dec: Angle.Degrees(+01.30853666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148912"},
        {"Hipparcos Number", "HIP 80907"},
        {"Geneva Identification System", "GEN# +1.00148912"},
        {"Smithsonian Astrophysical Observation", "SAO 121661"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.83824448),
        dec: Angle.Degrees(+01.30872069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221833"},
        {"Hipparcos Number", "HIP 116422"},
        {"Geneva Identification System", "GEN# +1.00221833"},
        {"Smithsonian Astrophysical Observation", "SAO 128270"},
        {"Wilson Evans Batten Catalogue", "WEB 20568"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.86919175),
        dec: Angle.Degrees(+01.31319815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150511"},
        {"Hipparcos Number", "HIP 81716"},
        {"Smithsonian Astrophysical Observation", "SAO 121787"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.37160152),
        dec: Angle.Degrees(+01.31350262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67717"},
        {"Hipparcos Number", "HIP 39937"},
        {"Smithsonian Astrophysical Observation", "SAO 116407"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.34227755),
        dec: Angle.Degrees(+01.31410934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192896"},
        {"Hipparcos Number", "HIP 100002"},
        {"Smithsonian Astrophysical Observation", "SAO 125650"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.32156443),
        dec: Angle.Degrees(+01.31504478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44977",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44977"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.43228691),
        dec: Angle.Degrees(+01.31558594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173566"},
        {"Hipparcos Number", "HIP 92075"},
        {"Smithsonian Astrophysical Observation", "SAO 123897"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.49342097),
        dec: Angle.Degrees(+01.31704126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103485"},
        {"Hipparcos Number", "HIP 58111"},
        {"Smithsonian Astrophysical Observation", "SAO 119112"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.76612155),
        dec: Angle.Degrees(+01.31720604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37700"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.01483853),
        dec: Angle.Degrees(+01.32250610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288089"},
        {"Hipparcos Number", "HIP 26280"},
        {"Smithsonian Astrophysical Observation", "SAO 112938"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.93964499),
        dec: Angle.Degrees(+01.32304036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33723"},
        {"Hipparcos Number", "HIP 24246"},
        {"Smithsonian Astrophysical Observation", "SAO 112519"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.07597665),
        dec: Angle.Degrees(+01.32646922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108959"},
        {"Hipparcos Number", "HIP 61091"},
        {"Smithsonian Astrophysical Observation", "SAO 119447"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.81097659),
        dec: Angle.Degrees(+01.32698944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34226"},
        {"Hipparcos Number", "HIP 24547"},
        {"Smithsonian Astrophysical Observation", "SAO 112582"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.99014214),
        dec: Angle.Degrees(+01.32757740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110486"},
        {"Hipparcos Number", "HIP 62005"},
        {"Geneva Identification System", "GEN# +1.00110486"},
        {"Smithsonian Astrophysical Observation", "SAO 119545"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.62152492),
        dec: Angle.Degrees(+01.32919268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71972",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71972"},
        {"Smithsonian Astrophysical Observation", "SAO 120621"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.80354673),
        dec: Angle.Degrees(+01.32972070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11088"},
        {"Hipparcos Number", "HIP 8454"},
        {"Fundamental Katalog 5th Edition", "FK5 4165"},
        {"Geneva Identification System", "GEN# +1.00011088"},
        {"Smithsonian Astrophysical Observation", "SAO 110145"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.25135886),
        dec: Angle.Degrees(+01.33154163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102944"},
        {"Smithsonian Astrophysical Observation", "SAO 126294"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.85203065),
        dec: Angle.Degrees(+01.33161246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72097"},
        {"Hipparcos Number", "HIP 41766"},
        {"Geneva Identification System", "GEN# +1.00072097"},
        {"Smithsonian Astrophysical Observation", "SAO 116850"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.76081447),
        dec: Angle.Degrees(+01.33732694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64082",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8789 AB"},
        {"Hipparcos Number", "HIP 64082"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.98427993),
        dec: Angle.Degrees(+01.33812532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40774"},
        {"Smithsonian Astrophysical Observation", "SAO 116619"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.82977973),
        dec: Angle.Degrees(+01.33899253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -164.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100313"},
        {"Hipparcos Number", "HIP 56307"},
        {"Smithsonian Astrophysical Observation", "SAO 118912"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.15184150),
        dec: Angle.Degrees(+01.34031438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215851"},
        {"Hipparcos Number", "HIP 112579"},
        {"Smithsonian Astrophysical Observation", "SAO 127768"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.02611758),
        dec: Angle.Degrees(+01.34042907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9356"},
        {"Hipparcos Number", "HIP 7149"},
        {"Geneva Identification System", "GEN# +1.00009356"},
        {"Wilson Evans Batten Catalogue", "WEB 1544"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.03402769),
        dec: Angle.Degrees(+01.34183818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12404"},
        {"Hipparcos Number", "HIP 9457"},
        {"Smithsonian Astrophysical Observation", "SAO 110285"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.41394925),
        dec: Angle.Degrees(+01.34316149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67462",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67462"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.37346734),
        dec: Angle.Degrees(+01.34449349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26373"},
        {"Hipparcos Number", "HIP 19476"},
        {"Smithsonian Astrophysical Observation", "SAO 111639"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.57442341),
        dec: Angle.Degrees(+01.34642918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167516"},
        {"Hipparcos Number", "HIP 89467"},
        {"Geneva Identification System", "GEN# +1.00167516J"},
        {"Smithsonian Astrophysical Observation", "SAO 123299"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.87608371),
        dec: Angle.Degrees(+01.34822466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152468"},
        {"Hipparcos Number", "HIP 82618"},
        {"Geneva Identification System", "GEN# +1.00152468"},
        {"Smithsonian Astrophysical Observation", "SAO 121923"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.34942010),
        dec: Angle.Degrees(+01.34832051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128886"},
        {"Hipparcos Number", "HIP 71663"},
        {"Smithsonian Astrophysical Observation", "SAO 120588"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.86645718),
        dec: Angle.Degrees(+01.34963948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24002"},
        {"Hipparcos Number", "HIP 17888"},
        {"Cincinnati Publication", "Ci 18 513"},
        {"Cincinnati Publication 2", "Ci 20 264"},
        {"Geneva Identification System", "GEN# +1.00024002"},
        {"Smithsonian Astrophysical Observation", "SAO 111440"},
        {"Wilson Evans Batten Catalogue", "WEB 3445"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.39776783),
        dec: Angle.Degrees(+01.34974167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 263.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -615.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2834"},
    },
    visualMagnitude: 10.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.98861121),
        dec: Angle.Degrees(+01.35187958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178574"},
        {"Hipparcos Number", "HIP 94070"},
        {"Geneva Identification System", "GEN# +1.00178574"},
        {"Smithsonian Astrophysical Observation", "SAO 124317"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.25758422),
        dec: Angle.Degrees(+01.35257903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169670"},
        {"Hipparcos Number", "HIP 90327"},
        {"Smithsonian Astrophysical Observation", "SAO 123463"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.45087558),
        dec: Angle.Degrees(+01.35438896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6649"},
        {"Hipparcos Number", "HIP 5257"},
        {"Smithsonian Astrophysical Observation", "SAO 109684"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.80348386),
        dec: Angle.Degrees(+01.35518930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18204"},
        {"Hipparcos Number", "HIP 13620"},
        {"Smithsonian Astrophysical Observation", "SAO 110841"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.86705236),
        dec: Angle.Degrees(+01.35566837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100894"},
        {"Geneva Identification System", "GEN# +0.00004509"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.86046779),
        dec: Angle.Degrees(+01.35575723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21094"},
        {"Hipparcos Number", "HIP 15858"},
        {"Geneva Identification System", "GEN# +1.00021094"},
        {"Smithsonian Astrophysical Observation", "SAO 111166"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.06454423),
        dec: Angle.Degrees(+01.35672750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45707"},
        {"Hipparcos Number", "HIP 30898"},
        {"Smithsonian Astrophysical Observation", "SAO 113939"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.28826907),
        dec: Angle.Degrees(+01.35783915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9188"},
        {"Hipparcos Number", "HIP 7025"},
        {"Smithsonian Astrophysical Observation", "SAO 109930"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.63095234),
        dec: Angle.Degrees(+01.35902575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36810"},
        {"Hipparcos Number", "HIP 26143"},
        {"Celescope Catalog", "CEL 797"},
        {"Geneva Identification System", "GEN# +1.00036810"},
        {"Smithsonian Astrophysical Observation", "SAO 112908"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.60819098),
        dec: Angle.Degrees(+01.36028961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7647"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.62523301),
        dec: Angle.Degrees(+01.36120442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203405"},
        {"Hipparcos Number", "HIP 105478"},
        {"Geneva Identification System", "GEN# +1.00203405"},
        {"Smithsonian Astrophysical Observation", "SAO 126733"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.45962419),
        dec: Angle.Degrees(+01.36166621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124115"},
        {"Hipparcos Number", "HIP 69340"},
        {"Geneva Identification System", "GEN# +1.00124115"},
        {"Smithsonian Astrophysical Observation", "SAO 120334"},
        {"Wilson Evans Batten Catalogue", "WEB 12091"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.88032541),
        dec: Angle.Degrees(+01.36232319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -128.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5543"},
        {"Hipparcos Number", "HIP 4465"},
        {"Geneva Identification System", "GEN# +1.00005543"},
        {"Smithsonian Astrophysical Observation", "SAO 109553"},
        {"Wilson Evans Batten Catalogue", "WEB 806"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.30926526),
        dec: Angle.Degrees(+01.36417361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4979",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 875 A"},
        {"Henry Draper", "HD 6288"},
        {"Henry Draper 2", "HD 6288A"},
        {"Hipparcos Number", "HIP 4979"},
        {"Fundamental Katalog 5th Edition", "FK5 37"},
        {"Geneva Identification System", "GEN# +1.00006288A"},
        {"Smithsonian Astrophysical Observation", "SAO 109643"},
        {"Wilson Evans Batten Catalogue", "WEB 1001"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.95398626),
        dec: Angle.Degrees(+01.36694516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18974"},
        {"Hipparcos Number", "HIP 14204"},
        {"Smithsonian Astrophysical Observation", "SAO 110933"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.79401906),
        dec: Angle.Degrees(+01.36822299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194263"},
        {"Hipparcos Number", "HIP 100672"},
        {"Smithsonian Astrophysical Observation", "SAO 125772"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.17397508),
        dec: Angle.Degrees(+01.36861212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16581"},
        {"Hipparcos Number", "HIP 12392"},
        {"Geneva Identification System", "GEN# +1.00016581"},
        {"Smithsonian Astrophysical Observation", "SAO 110666"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.89477855),
        dec: Angle.Degrees(+01.36868022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15031"},
        {"Hipparcos Number", "HIP 11283"},
        {"Smithsonian Astrophysical Observation", "SAO 110523"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.34058386),
        dec: Angle.Degrees(+01.37419585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212571"},
        {"Hipparcos Number", "HIP 110672"},
        {"Fundamental Katalog 5th Edition", "FK5 1585"},
        {"Geneva Identification System", "GEN# +1.00212571"},
        {"Smithsonian Astrophysical Observation", "SAO 127520"},
        {"Wilson Evans Batten Catalogue", "WEB 19828"},
    },
    visualMagnitude: 4.80,
    bvColour: -0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.31921857),
        dec: Angle.Degrees(+01.37739245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189322"},
        {"Hipparcos Number", "HIP 98385"},
        {"Fundamental Katalog 5th Edition", "FK5 3596"},
        {"Geneva Identification System", "GEN# +1.00189322"},
        {"Smithsonian Astrophysical Observation", "SAO 125310"},
        {"Wilson Evans Batten Catalogue", "WEB 17365"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.84430859),
        dec: Angle.Degrees(+01.37753175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28375"},
        {"Hipparcos Number", "HIP 20884"},
        {"Fundamental Katalog 5th Edition", "FK5 1123"},
        {"Geneva Identification System", "GEN# +1.00028375"},
        {"Smithsonian Astrophysical Observation", "SAO 111845"},
        {"Wilson Evans Batten Catalogue", "WEB 4007"},
    },
    visualMagnitude: 5.53,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.13378878),
        dec: Angle.Degrees(+01.38087416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149652"},
        {"Hipparcos Number", "HIP 81279"},
        {"Geneva Identification System", "GEN# +1.00149652"},
        {"Smithsonian Astrophysical Observation", "SAO 121722"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.01297103),
        dec: Angle.Degrees(+01.38160403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176567"},
        {"Hipparcos Number", "HIP 93351"},
        {"Smithsonian Astrophysical Observation", "SAO 124150"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.20933880),
        dec: Angle.Degrees(+01.38337245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 940"},
        {"Hipparcos Number", "HIP 1107"},
        {"Smithsonian Astrophysical Observation", "SAO 109078"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.44829323),
        dec: Angle.Degrees(+01.38362257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108026"},
        {"Hipparcos Number", "HIP 60544"},
        {"Smithsonian Astrophysical Observation", "SAO 119381"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.16972716),
        dec: Angle.Degrees(+01.38389072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76633"},
        {"Hipparcos Number", "HIP 43993"},
        {"Smithsonian Astrophysical Observation", "SAO 117297"},
    },
    visualMagnitude: 8.82,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.37653778),
        dec: Angle.Degrees(+01.38443699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70208"},
        {"Hipparcos Number", "HIP 40903"},
        {"Geneva Identification System", "GEN# +1.00070208"},
        {"Smithsonian Astrophysical Observation", "SAO 116651"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.20031461),
        dec: Angle.Degrees(+01.38806415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24466"},
        {"Hipparcos Number", "HIP 18203"},
        {"Geneva Identification System", "GEN# +1.00024466"},
        {"Smithsonian Astrophysical Observation", "SAO 111481"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.39741405),
        dec: Angle.Degrees(+01.38844798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193559"},
        {"Hipparcos Number", "HIP 100320"},
        {"Smithsonian Astrophysical Observation", "SAO 125698"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.18049458),
        dec: Angle.Degrees(+01.38859732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90748",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11410 AB"},
        {"Henry Draper", "HD 170739"},
        {"Hipparcos Number", "HIP 90748"},
        {"Smithsonian Astrophysical Observation", "SAO 123590"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.74354205),
        dec: Angle.Degrees(+01.39188548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130255"},
        {"Hipparcos Number", "HIP 72291"},
        {"Smithsonian Astrophysical Observation", "SAO 120656"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.75829943),
        dec: Angle.Degrees(+01.39323924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20122",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20122"},
    },
    visualMagnitude: 12.26,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.71439183),
        dec: Angle.Degrees(+01.39345631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65211"},
        {"Smithsonian Astrophysical Observation", "SAO 119901"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.46031658),
        dec: Angle.Degrees(+01.39540215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90490"},
    },
    visualMagnitude: 10.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.96974247),
        dec: Angle.Degrees(+01.39746846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53424"},
        {"Hipparcos Number", "HIP 34164"},
        {"Cincinnati Publication", "Ci 18 848"},
        {"Smithsonian Astrophysical Observation", "SAO 114888"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.26714917),
        dec: Angle.Degrees(+01.39793035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2360"},
        {"Hipparcos Number", "HIP 2172"},
        {"Smithsonian Astrophysical Observation", "SAO 109217"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.85775596),
        dec: Angle.Degrees(+01.39875923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65405",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8890 AB"},
        {"Henry Draper", "HD 116542"},
        {"Hipparcos Number", "HIP 65405"},
        {"Smithsonian Astrophysical Observation", "SAO 119913"},
        {"Wilson Evans Batten Catalogue", "WEB 11542"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.07667305),
        dec: Angle.Degrees(+01.39974722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51191"},
        {"Geneva Identification System", "GEN# +9.80053041"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.85147955),
        dec: Angle.Degrees(+01.40076856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -294.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209290"},
        {"Hipparcos Number", "HIP 108782"},
        {"Cincinnati Publication", "Ci 20 1331"},
        {"Geneva Identification System", "GEN# +1.00209290"},
        {"Wilson Evans Batten Catalogue", "WEB 19569"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.54391282),
        dec: Angle.Degrees(+01.40090869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -455.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25162"},
        {"Hipparcos Number", "HIP 18680"},
        {"Smithsonian Astrophysical Observation", "SAO 111550"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.00885763),
        dec: Angle.Degrees(+01.40150462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19450"},
        {"Hipparcos Number", "HIP 14534"},
        {"Smithsonian Astrophysical Observation", "SAO 110988"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.91584706),
        dec: Angle.Degrees(+01.40597241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50528"},
        {"Hipparcos Number", "HIP 33110"},
        {"Smithsonian Astrophysical Observation", "SAO 114575"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.43980280),
        dec: Angle.Degrees(+01.40639797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36741"},
        {"Hipparcos Number", "HIP 26098"},
        {"Celescope Catalog", "CEL 787"},
        {"Geneva Identification System", "GEN# +1.00036741"},
        {"Smithsonian Astrophysical Observation", "SAO 112901"},
        {"Wilson Evans Batten Catalogue", "WEB 5083"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.48993773),
        dec: Angle.Degrees(+01.40764674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99055"},
        {"Hipparcos Number", "HIP 55650"},
        {"Geneva Identification System", "GEN# +1.00099055"},
        {"Smithsonian Astrophysical Observation", "SAO 118831"},
        {"Wilson Evans Batten Catalogue", "WEB 10003"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.00973642),
        dec: Angle.Degrees(+01.40776375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174644"},
        {"Hipparcos Number", "HIP 92542"},
        {"Smithsonian Astrophysical Observation", "SAO 123977"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.87358877),
        dec: Angle.Degrees(+01.40823120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207875"},
        {"Hipparcos Number", "HIP 107951"},
        {"Smithsonian Astrophysical Observation", "SAO 127123"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.05018354),
        dec: Angle.Degrees(+01.40918544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76977"},
        {"Hipparcos Number", "HIP 44157"},
        {"Geneva Identification System", "GEN# +1.00076977"},
        {"Smithsonian Astrophysical Observation", "SAO 117328"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.89796418),
        dec: Angle.Degrees(+01.41195720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110226"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.91870403),
        dec: Angle.Degrees(+01.41263097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14008"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.08448087),
        dec: Angle.Degrees(+01.41722465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136834"},
        {"Hipparcos Number", "HIP 75266"},
        {"Cincinnati Publication", "Ci 20 929"},
        {"Geneva Identification System", "GEN# +1.00136834"},
        {"Smithsonian Astrophysical Observation", "SAO 120966"},
        {"Wilson Evans Batten Catalogue", "WEB 12839"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.67816257),
        dec: Angle.Degrees(+01.41951111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -363.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -363.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152898"},
        {"Hipparcos Number", "HIP 82865"},
        {"Smithsonian Astrophysical Observation", "SAO 121946"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.02330843),
        dec: Angle.Degrees(+01.42071363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139360"},
        {"Hipparcos Number", "HIP 76516"},
        {"Smithsonian Astrophysical Observation", "SAO 121096"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.40747205),
        dec: Angle.Degrees(+01.42159039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157298"},
        {"Hipparcos Number", "HIP 84993"},
        {"Smithsonian Astrophysical Observation", "SAO 122321"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.58521372),
        dec: Angle.Degrees(+01.42357851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198980"},
        {"Hipparcos Number", "HIP 103155"},
        {"Smithsonian Astrophysical Observation", "SAO 126347"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.49565455),
        dec: Angle.Degrees(+01.42446035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81125"},
        {"Hipparcos Number", "HIP 46089"},
        {"Geneva Identification System", "GEN# +1.00081125"},
        {"Smithsonian Astrophysical Observation", "SAO 117654"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.97752607),
        dec: Angle.Degrees(+01.42586871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112542"},
        {"Hipparcos Number", "HIP 63235"},
        {"Geneva Identification System", "GEN# +1.00112542"},
        {"Smithsonian Astrophysical Observation", "SAO 119684"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.35961540),
        dec: Angle.Degrees(+01.42795731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163443"},
        {"Hipparcos Number", "HIP 87796"},
        {"Smithsonian Astrophysical Observation", "SAO 122930"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.02736378),
        dec: Angle.Degrees(+01.43038840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20055"},
        {"Hipparcos Number", "HIP 15008"},
        {"Smithsonian Astrophysical Observation", "SAO 111059"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.36372314),
        dec: Angle.Degrees(+01.43184627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149348"},
        {"Hipparcos Number", "HIP 81115"},
        {"Geneva Identification System", "GEN# +1.00149348"},
        {"Smithsonian Astrophysical Observation", "SAO 121697"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.50654978),
        dec: Angle.Degrees(+01.43201464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288218"},
        {"Hipparcos Number", "HIP 27033"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.00684806),
        dec: Angle.Degrees(+01.43577666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63017",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63017"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.71555237),
        dec: Angle.Degrees(+01.43786357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12942"},
        {"Hipparcos Number", "HIP 9856"},
        {"Smithsonian Astrophysical Observation", "SAO 110345"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.70122225),
        dec: Angle.Degrees(+01.44209572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157089"},
        {"Hipparcos Number", "HIP 84905"},
        {"Geneva Identification System", "GEN# +1.00157089"},
        {"Smithsonian Astrophysical Observation", "SAO 122301"},
        {"Wilson Evans Batten Catalogue", "WEB 14339"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.27980079),
        dec: Angle.Degrees(+01.44239557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 269.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168346"},
        {"Hipparcos Number", "HIP 89768"},
        {"Smithsonian Astrophysical Observation", "SAO 123350"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.77704608),
        dec: Angle.Degrees(+01.44311368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29170"},
        {"Hipparcos Number", "HIP 21411"},
        {"Geneva Identification System", "GEN# +1.00029170"},
        {"Smithsonian Astrophysical Observation", "SAO 111909"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.93333962),
        dec: Angle.Degrees(+01.44506068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25001"},
        {"Hipparcos Number", "HIP 18560"},
        {"Smithsonian Astrophysical Observation", "SAO 111532"},
        {"Wilson Evans Batten Catalogue", "WEB 3580"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.58853639),
        dec: Angle.Degrees(+01.44585997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17177"},
        {"Hipparcos Number", "HIP 12863"},
        {"Smithsonian Astrophysical Observation", "SAO 110731"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.34414385),
        dec: Angle.Degrees(+01.44739744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8077"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.93552342),
        dec: Angle.Degrees(+01.44848992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58810"},
        {"Hipparcos Number", "HIP 36200"},
        {"Smithsonian Astrophysical Observation", "SAO 115466"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.82907258),
        dec: Angle.Degrees(+01.45268767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114960"},
        {"Hipparcos Number", "HIP 64556"},
        {"Geneva Identification System", "GEN# +1.00114960"},
        {"Smithsonian Astrophysical Observation", "SAO 119822"},
        {"Wilson Evans Batten Catalogue", "WEB 11418"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.48998608),
        dec: Angle.Degrees(+01.45655661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151466"},
        {"Hipparcos Number", "HIP 82190"},
        {"Smithsonian Astrophysical Observation", "SAO 121863"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.86794663),
        dec: Angle.Degrees(+01.45663801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38912"},
        {"Hipparcos Number", "HIP 27487"},
        {"Geneva Identification System", "GEN# +1.00038912"},
        {"Renson", "Renson 10450"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.30459019),
        dec: Angle.Degrees(+01.45839524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287493"},
        {"Hipparcos Number", "HIP 23700"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.41085167),
        dec: Angle.Degrees(+01.45859619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8648"},
        {"Hipparcos Number", "HIP 6653"},
        {"Geneva Identification System", "GEN# +1.00008648"},
        {"Smithsonian Astrophysical Observation", "SAO 109878"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.33361136),
        dec: Angle.Degrees(+01.46100409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104817"},
        {"Hipparcos Number", "HIP 58851"},
        {"Geneva Identification System", "GEN# +1.00104817"},
        {"Renson", "Renson 30340"},
        {"Smithsonian Astrophysical Observation", "SAO 119195"},
        {"Wilson Evans Batten Catalogue", "WEB 10481"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.05384960),
        dec: Angle.Degrees(+01.46209834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67152"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.41633693),
        dec: Angle.Degrees(+01.46264162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78196"},
        {"Hipparcos Number", "HIP 44738"},
        {"Fundamental Katalog 5th Edition", "FK5 2718"},
        {"Geneva Identification System", "GEN# +1.00078196"},
        {"Smithsonian Astrophysical Observation", "SAO 117432"},
        {"Wilson Evans Batten Catalogue", "WEB 8555"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.74977358),
        dec: Angle.Degrees(+01.46273239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46732",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7412 AB"},
        {"Henry Draper", "HD 82355"},
        {"Hipparcos Number", "HIP 46732"},
        {"Smithsonian Astrophysical Observation", "SAO 117747"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.88027401),
        dec: Angle.Degrees(+01.46533119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150617"},
        {"Hipparcos Number", "HIP 81778"},
        {"Geneva Identification System", "GEN# +1.00150617"},
        {"Smithsonian Astrophysical Observation", "SAO 121794"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.54714136),
        dec: Angle.Degrees(+01.46760721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101400"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.25285129),
        dec: Angle.Degrees(+01.46789802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89895"},
        {"Hipparcos Number", "HIP 50811"},
        {"Smithsonian Astrophysical Observation", "SAO 118262"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.60772279),
        dec: Angle.Degrees(+01.46797955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30509"},
        {"Hipparcos Number", "HIP 22317"},
        {"Smithsonian Astrophysical Observation", "SAO 112090"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.10204091),
        dec: Angle.Degrees(+01.46823294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80899"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.81476151),
        dec: Angle.Degrees(+01.46905160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139839"},
        {"Hipparcos Number", "HIP 76751"},
        {"Geneva Identification System", "GEN# +1.00139839"},
        {"Smithsonian Astrophysical Observation", "SAO 121118"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.08934242),
        dec: Angle.Degrees(+01.46905595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118702"},
        {"Hipparcos Number", "HIP 66552"},
        {"Smithsonian Astrophysical Observation", "SAO 120050"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.63905260),
        dec: Angle.Degrees(+01.47115489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114018"},
        {"Hipparcos Number", "HIP 64051"},
        {"Geneva Identification System", "GEN# +1.00114018"},
        {"Smithsonian Astrophysical Observation", "SAO 119778"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.90248215),
        dec: Angle.Degrees(+01.47451175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37984"},
        {"Hipparcos Number", "HIP 26885"},
        {"Fundamental Katalog 5th Edition", "FK5 2427"},
        {"Geneva Identification System", "GEN# +1.00037984"},
        {"Smithsonian Astrophysical Observation", "SAO 113056"},
        {"Wilson Evans Batten Catalogue", "WEB 5303"},
    },
    visualMagnitude: 4.90,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.61943491),
        dec: Angle.Degrees(+01.47466498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111486"},
        {"Hipparcos Number", "HIP 62595"},
        {"Geneva Identification System", "GEN# +1.00111486"},
        {"Smithsonian Astrophysical Observation", "SAO 119611"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.38892947),
        dec: Angle.Degrees(+01.47498078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66013"},
        {"Hipparcos Number", "HIP 39253"},
        {"Smithsonian Astrophysical Observation", "SAO 116248"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.41484008),
        dec: Angle.Degrees(+01.47694637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41215"},
        {"Smithsonian Astrophysical Observation", "SAO 116731"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.15387541),
        dec: Angle.Degrees(+01.47828865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157497"},
        {"Hipparcos Number", "HIP 85097"},
        {"Smithsonian Astrophysical Observation", "SAO 122340"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.88023882),
        dec: Angle.Degrees(+01.47846693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15361"},
        {"Hipparcos Number", "HIP 11507"},
        {"Geneva Identification System", "GEN# +1.00015361"},
        {"Smithsonian Astrophysical Observation", "SAO 110545"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.09552941),
        dec: Angle.Degrees(+01.48176720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184474"},
        {"Hipparcos Number", "HIP 96270"},
        {"Smithsonian Astrophysical Observation", "SAO 124803"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.62752797),
        dec: Angle.Degrees(+01.48218205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75357"},
        {"Hipparcos Number", "HIP 43323"},
        {"Smithsonian Astrophysical Observation", "SAO 117170"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.40409879),
        dec: Angle.Degrees(+01.48246016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20699"},
        {"Hipparcos Number", "HIP 15523"},
        {"Smithsonian Astrophysical Observation", "SAO 111131"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.00766801),
        dec: Angle.Degrees(+01.48361665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19649"},
        {"Hipparcos Number", "HIP 14696"},
        {"Geneva Identification System", "GEN# +1.00019649"},
        {"Smithsonian Astrophysical Observation", "SAO 111016"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.46463640),
        dec: Angle.Degrees(+01.48437596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112236"},
        {"Hipparcos Number", "HIP 63052"},
        {"Smithsonian Astrophysical Observation", "SAO 119663"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.78837683),
        dec: Angle.Degrees(+01.48523574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87094"},
        {"Hipparcos Number", "HIP 49225"},
        {"Renson", "Renson 24903"},
        {"Smithsonian Astrophysical Observation", "SAO 118074"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.72191021),
        dec: Angle.Degrees(+01.48586497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72759"},
        {"Hipparcos Number", "HIP 42092"},
        {"Smithsonian Astrophysical Observation", "SAO 116908"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.68809396),
        dec: Angle.Degrees(+01.48706117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53205"},
        {"Hipparcos Number", "HIP 34107"},
        {"Geneva Identification System", "GEN# +1.00053205"},
        {"Smithsonian Astrophysical Observation", "SAO 114867"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.08407219),
        dec: Angle.Degrees(+01.48850326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51507"},
        {"Hipparcos Number", "HIP 33490"},
        {"Geneva Identification System", "GEN# +1.00051507"},
        {"Smithsonian Astrophysical Observation", "SAO 114686"},
        {"Wilson Evans Batten Catalogue", "WEB 6735"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.42111539),
        dec: Angle.Degrees(+01.49130384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90905"},
        {"Hipparcos Number", "HIP 51386"},
        {"Geneva Identification System", "GEN# +1.00090905"},
        {"Smithsonian Astrophysical Observation", "SAO 118333"},
        {"Wilson Evans Batten Catalogue", "WEB 9381"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.42632499),
        dec: Angle.Degrees(+01.49142260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37606"},
        {"Hipparcos Number", "HIP 26648"},
        {"Celescope Catalog", "CEL 904"},
        {"Geneva Identification System", "GEN# +1.00037606"},
        {"Smithsonian Astrophysical Observation", "SAO 113014"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.95451086),
        dec: Angle.Degrees(+01.49173969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38047"},
        {"Hipparcos Number", "HIP 26937"},
        {"Smithsonian Astrophysical Observation", "SAO 113070"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.74768531),
        dec: Angle.Degrees(+01.49191413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106560"},
        {"Hipparcos Number", "HIP 59771"},
        {"Renson", "Renson 30833"},
        {"Smithsonian Astrophysical Observation", "SAO 119288"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.84582775),
        dec: Angle.Degrees(+01.49208405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147116"},
        {"Hipparcos Number", "HIP 80001"},
        {"Smithsonian Astrophysical Observation", "SAO 121505"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.96036156),
        dec: Angle.Degrees(+01.49635436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146740"},
        {"Hipparcos Number", "HIP 79834"},
        {"Smithsonian Astrophysical Observation", "SAO 121478"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.43069384),
        dec: Angle.Degrees(+01.49671673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27735"},
        {"Hipparcos Number", "HIP 20439"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.68152220),
        dec: Angle.Degrees(+01.49745564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7395"},
        {"Hipparcos Number", "HIP 5783"},
        {"Smithsonian Astrophysical Observation", "SAO 109746"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.54368195),
        dec: Angle.Degrees(+01.49790092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117704",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17067 AB"},
        {"Henry Draper", "HD 223743"},
        {"Hipparcos Number", "HIP 117704"},
        {"Smithsonian Astrophysical Observation", "SAO 128429"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.07010225),
        dec: Angle.Degrees(+01.49854564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185198"},
        {"Hipparcos Number", "HIP 96567"},
        {"Smithsonian Astrophysical Observation", "SAO 124868"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.47258002),
        dec: Angle.Degrees(+01.49926622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169309"},
        {"Hipparcos Number", "HIP 90175"},
        {"Geneva Identification System", "GEN# +1.00169309"},
        {"Smithsonian Astrophysical Observation", "SAO 123428"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.01640435),
        dec: Angle.Degrees(+01.49951929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175806"},
        {"Hipparcos Number", "HIP 93028"},
        {"Geneva Identification System", "GEN# +1.00175806"},
        {"Smithsonian Astrophysical Observation", "SAO 124085"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.26863232),
        dec: Angle.Degrees(+01.50045591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45050"},
        {"Hipparcos Number", "HIP 30547"},
        {"Geneva Identification System", "GEN# +1.00045050J"},
        {"Smithsonian Astrophysical Observation", "SAO 113855"},
        {"Wilson Evans Batten Catalogue", "WEB 6090"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.32702656),
        dec: Angle.Degrees(+01.50152430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59229"},
        {"Hipparcos Number", "HIP 36365"},
        {"Geneva Identification System", "GEN# +1.00059229"},
        {"Smithsonian Astrophysical Observation", "SAO 115512"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.27730619),
        dec: Angle.Degrees(+01.50205812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81302"},
        {"Hipparcos Number", "HIP 46164"},
        {"Geneva Identification System", "GEN# +1.00081302"},
        {"Smithsonian Astrophysical Observation", "SAO 117672"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.22114728),
        dec: Angle.Degrees(+01.50290187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288607"},
        {"Hipparcos Number", "HIP 30147"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.15944933),
        dec: Angle.Degrees(+01.50384407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200138"},
        {"Hipparcos Number", "HIP 103760"},
        {"Fundamental Katalog 5th Edition", "FK5 5851"},
        {"Geneva Identification System", "GEN# +1.00200138"},
        {"Smithsonian Astrophysical Observation", "SAO 126472"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.38803163),
        dec: Angle.Degrees(+01.50412438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130707"},
        {"Hipparcos Number", "HIP 72521"},
        {"Smithsonian Astrophysical Observation", "SAO 120679"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.41014372),
        dec: Angle.Degrees(+01.50448644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66872"},
        {"Geneva Identification System", "GEN# +0.00202711"},
    },
    visualMagnitude: 10.37,
    bvColour: -0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.57919679),
        dec: Angle.Degrees(+01.50518730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55632"},
        {"Hipparcos Number", "HIP 34944"},
        {"Smithsonian Astrophysical Observation", "SAO 115105"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.46483764),
        dec: Angle.Degrees(+01.50726026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53204"},
        {"Hipparcos Number", "HIP 34102"},
        {"Geneva Identification System", "GEN# +1.00053204"},
        {"Renson", "Renson 14630"},
        {"Smithsonian Astrophysical Observation", "SAO 114863"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.06761896),
        dec: Angle.Degrees(+01.50745896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41770"},
        {"Hipparcos Number", "HIP 29006"},
        {"Geneva Identification System", "GEN# +1.00041770"},
        {"Renson", "Renson 11143"},
        {"Smithsonian Astrophysical Observation", "SAO 113471"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.80989191),
        dec: Angle.Degrees(+01.50845623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30977"},
        {"Hipparcos Number", "HIP 22636"},
        {"Smithsonian Astrophysical Observation", "SAO 112163"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.05109557),
        dec: Angle.Degrees(+01.50943873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137270"},
        {"Hipparcos Number", "HIP 75468"},
        {"Smithsonian Astrophysical Observation", "SAO 120988"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.25542929),
        dec: Angle.Degrees(+01.50971134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2856"},
        {"Hipparcos Number", "HIP 2519"},
        {"Smithsonian Astrophysical Observation", "SAO 109256"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.98551215),
        dec: Angle.Degrees(+01.51042373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19002"},
        {"Hipparcos Number", "HIP 14231"},
        {"Smithsonian Astrophysical Observation", "SAO 110936"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.87094675),
        dec: Angle.Degrees(+01.51215793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75719"},
        {"Hipparcos Number", "HIP 43505"},
        {"Geneva Identification System", "GEN# +1.00075719"},
        {"Smithsonian Astrophysical Observation", "SAO 117204"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.93098353),
        dec: Angle.Degrees(+01.51249924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65080"},
        {"Hipparcos Number", "HIP 38853"},
        {"Geneva Identification System", "GEN# +1.00065080"},
        {"Smithsonian Astrophysical Observation", "SAO 116161"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.26538159),
        dec: Angle.Degrees(+01.51317574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68864",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9107 AB"},
        {"Henry Draper", "HD 123176"},
        {"Hipparcos Number", "HIP 68864"},
        {"Smithsonian Astrophysical Observation", "SAO 120286"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.52594050),
        dec: Angle.Degrees(+01.51415614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60190"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.14182879),
        dec: Angle.Degrees(+01.51477509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90540"},
        {"Hipparcos Number", "HIP 51183"},
        {"Smithsonian Astrophysical Observation", "SAO 118309"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.81733617),
        dec: Angle.Degrees(+01.51484189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201176"},
        {"Hipparcos Number", "HIP 104315"},
        {"Geneva Identification System", "GEN# +1.00201176"},
        {"Smithsonian Astrophysical Observation", "SAO 126558"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.97693599),
        dec: Angle.Degrees(+01.51484214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156801"},
        {"Hipparcos Number", "HIP 84763"},
        {"Wilson Evans Batten Catalogue", "WEB 14310"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.88380258),
        dec: Angle.Degrees(+01.51504206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11720",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1921 AB"},
        {"Henry Draper", "HD 15675"},
        {"Hipparcos Number", "HIP 11720"},
        {"Smithsonian Astrophysical Observation", "SAO 110585"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.81923725),
        dec: Angle.Degrees(+01.51554591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121513"},
        {"Hipparcos Number", "HIP 68027"},
        {"Smithsonian Astrophysical Observation", "SAO 120177"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.95169360),
        dec: Angle.Degrees(+01.51974025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113126"},
        {"Hipparcos Number", "HIP 63560"},
        {"Fundamental Katalog 5th Edition", "FK5 5149"},
        {"Smithsonian Astrophysical Observation", "SAO 119722"},
        {"Wilson Evans Batten Catalogue", "WEB 11249"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.37678139),
        dec: Angle.Degrees(+01.52032372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17375"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.80108972),
        dec: Angle.Degrees(+01.52055256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31542"},
        {"Hipparcos Number", "HIP 22996"},
        {"Smithsonian Astrophysical Observation", "SAO 112245"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.20667783),
        dec: Angle.Degrees(+01.52086851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177942"},
        {"Hipparcos Number", "HIP 93840"},
        {"Smithsonian Astrophysical Observation", "SAO 124267"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.64928192),
        dec: Angle.Degrees(+01.52229770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107856"},
        {"Hipparcos Number", "HIP 60456"},
        {"Geneva Identification System", "GEN# +1.00107856"},
        {"Smithsonian Astrophysical Observation", "SAO 119369"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.91062417),
        dec: Angle.Degrees(+01.52278791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119749"},
        {"Hipparcos Number", "HIP 67091"},
        {"Smithsonian Astrophysical Observation", "SAO 120094"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.26750044),
        dec: Angle.Degrees(+01.52635460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146048"},
        {"Hipparcos Number", "HIP 79566"},
        {"Smithsonian Astrophysical Observation", "SAO 121439"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.52622516),
        dec: Angle.Degrees(+01.52645774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198202"},
        {"Hipparcos Number", "HIP 102711"},
        {"Smithsonian Astrophysical Observation", "SAO 126237"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.17357247),
        dec: Angle.Degrees(+01.52758356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31140"},
        {"Hipparcos Number", "HIP 22728"},
        {"Geneva Identification System", "GEN# +1.00031140"},
        {"Smithsonian Astrophysical Observation", "SAO 112180"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.34188862),
        dec: Angle.Degrees(+01.52861479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49163"},
        {"Hipparcos Number", "HIP 32520"},
        {"Smithsonian Astrophysical Observation", "SAO 114409"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.79800604),
        dec: Angle.Degrees(+01.52936288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186184"},
        {"Hipparcos Number", "HIP 96993"},
        {"Smithsonian Astrophysical Observation", "SAO 124965"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70897490),
        dec: Angle.Degrees(+01.53126639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84018"},
        {"Smithsonian Astrophysical Observation", "SAO 122148"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.62119940),
        dec: Angle.Degrees(+01.53170197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103892",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14573 AB"},
        {"Henry Draper", "HD 200375"},
        {"Hipparcos Number", "HIP 103892"},
        {"Geneva Identification System", "GEN# +1.00200375"},
        {"Smithsonian Astrophysical Observation", "SAO 126491"},
        {"Wilson Evans Batten Catalogue", "WEB 18921"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.76286878),
        dec: Angle.Degrees(+01.53219038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140776"},
        {"Hipparcos Number", "HIP 77172"},
        {"Smithsonian Astrophysical Observation", "SAO 121169"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.36129208),
        dec: Angle.Degrees(+01.53238721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92273"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.08545456),
        dec: Angle.Degrees(+01.53253229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111719"},
        {"Geneva Identification System", "GEN# +0.00004900"},
        {"Wilson Evans Batten Catalogue", "WEB 19963"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.44928453),
        dec: Angle.Degrees(+01.53455454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225243"},
        {"Hipparcos Number", "HIP 384"},
        {"Geneva Identification System", "GEN# +1.00225243"},
        {"Smithsonian Astrophysical Observation", "SAO 108997"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.19286162),
        dec: Angle.Degrees(+01.53694172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19166"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.64547780),
        dec: Angle.Degrees(+01.53797812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34960"},
        {"Hipparcos Number", "HIP 25016"},
        {"Smithsonian Astrophysical Observation", "SAO 112661"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.34435410),
        dec: Angle.Degrees(+01.53920006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76757"},
        {"Hipparcos Number", "HIP 44042"},
        {"Fundamental Katalog 5th Edition", "FK5 2712"},
        {"Geneva Identification System", "GEN# +1.00076757J"},
        {"Smithsonian Astrophysical Observation", "SAO 117311"},
        {"Wilson Evans Batten Catalogue", "WEB 8464"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.53426769),
        dec: Angle.Degrees(+01.54160610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161869"},
        {"Hipparcos Number", "HIP 87115"},
        {"Smithsonian Astrophysical Observation", "SAO 122755"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.98783812),
        dec: Angle.Degrees(+01.54175171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101077"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.35665970),
        dec: Angle.Degrees(+01.54200007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74059"},
        {"Hipparcos Number", "HIP 42667"},
        {"Geneva Identification System", "GEN# +1.00074059"},
        {"Smithsonian Astrophysical Observation", "SAO 117033"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.44533001),
        dec: Angle.Degrees(+01.54403096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4447"},
        {"Hipparcos Number", "HIP 3655"},
        {"Smithsonian Astrophysical Observation", "SAO 109454"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.69786386),
        dec: Angle.Degrees(+01.54409652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68520",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9085 A"},
        {"Henry Draper", "HD 122408"},
        {"Hipparcos Number", "HIP 68520"},
        {"Fundamental Katalog 5th Edition", "FK5 516"},
        {"Geneva Identification System", "GEN# +1.00122408A"},
        {"Renson", "Renson 35100"},
        {"Smithsonian Astrophysical Observation", "SAO 120238"},
        {"Wilson Evans Batten Catalogue", "WEB 12001"},
    },
    visualMagnitude: 4.23,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.41159648),
        dec: Angle.Degrees(+01.54458338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101291"},
        {"Hipparcos Number", "HIP 56856"},
        {"Smithsonian Astrophysical Observation", "SAO 118975"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.85357101),
        dec: Angle.Degrees(+01.54543108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141144"},
        {"Hipparcos Number", "HIP 77354"},
        {"Smithsonian Astrophysical Observation", "SAO 121191"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.86184157),
        dec: Angle.Degrees(+01.54603913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57562"},
        {"Hipparcos Number", "HIP 35695"},
        {"Fundamental Katalog 5th Edition", "FK5 4664"},
        {"Smithsonian Astrophysical Observation", "SAO 115328"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.47706199),
        dec: Angle.Degrees(+01.54665700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147719"},
        {"Hipparcos Number", "HIP 80293"},
        {"Smithsonian Astrophysical Observation", "SAO 121560"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.85251832),
        dec: Angle.Degrees(+01.54764150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43790"},
        {"Cincinnati Publication", "Ci 20 498"},
        {"Geneva Identification System", "GEN# +0.00202098"},
        {"Wilson Evans Batten Catalogue", "WEB 8422"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.78164853),
        dec: Angle.Degrees(+01.54904637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1044.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287738"},
        {"Hipparcos Number", "HIP 24848"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.90343529),
        dec: Angle.Degrees(+01.55060527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180104"},
        {"Hipparcos Number", "HIP 94608"},
        {"Smithsonian Astrophysical Observation", "SAO 124438"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.79464169),
        dec: Angle.Degrees(+01.55195767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10412"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.54407840),
        dec: Angle.Degrees(+01.55334695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158509"},
        {"Hipparcos Number", "HIP 85606"},
        {"Smithsonian Astrophysical Observation", "SAO 122433"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.40425243),
        dec: Angle.Degrees(+01.55527920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34137"},
        {"Hipparcos Number", "HIP 24482"},
        {"Smithsonian Astrophysical Observation", "SAO 112568"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.79948565),
        dec: Angle.Degrees(+01.55613869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2004"},
        {"Hipparcos Number", "HIP 1924"},
        {"Geneva Identification System", "GEN# +1.00002004"},
        {"Smithsonian Astrophysical Observation", "SAO 109182"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.07215376),
        dec: Angle.Degrees(+01.55640719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157105"},
        {"Hipparcos Number", "HIP 84919"},
        {"Geneva Identification System", "GEN# +1.00157105"},
        {"Smithsonian Astrophysical Observation", "SAO 122303"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.30913085),
        dec: Angle.Degrees(+01.55655440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20421"},
        {"Hipparcos Number", "HIP 15284"},
        {"Geneva Identification System", "GEN# +1.00020421"},
        {"Smithsonian Astrophysical Observation", "SAO 111098"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.29931211),
        dec: Angle.Degrees(+01.55805919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43798"},
        {"Hipparcos Number", "HIP 29945"},
        {"Smithsonian Astrophysical Observation", "SAO 113706"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.56618832),
        dec: Angle.Degrees(+01.56342709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24133"},
        {"Hipparcos Number", "HIP 17988"},
        {"Geneva Identification System", "GEN# +1.00024133"},
        {"Smithsonian Astrophysical Observation", "SAO 111453"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.67477555),
        dec: Angle.Degrees(+01.56394746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53359"},
        {"Hipparcos Number", "HIP 34151"},
        {"Smithsonian Astrophysical Observation", "SAO 114882"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.22259845),
        dec: Angle.Degrees(+01.56450019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287780"},
        {"Hipparcos Number", "HIP 25047"},
        {"Smithsonian Astrophysical Observation", "SAO 112669"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.44898137),
        dec: Angle.Degrees(+01.56671006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60747"},
        {"Cincinnati Publication", "Ci 20 709"},
        {"Geneva Identification System", "GEN# +0.00202541"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.74931617),
        dec: Angle.Degrees(+01.56701987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -327.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201446"},
        {"Hipparcos Number", "HIP 104450"},
        {"Geneva Identification System", "GEN# +1.00201446"},
        {"Smithsonian Astrophysical Observation", "SAO 126585"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.37716577),
        dec: Angle.Degrees(+01.56835137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31209"},
        {"Hipparcos Number", "HIP 22774"},
        {"Geneva Identification System", "GEN# +1.00031209"},
        {"Smithsonian Astrophysical Observation", "SAO 112191"},
        {"Wilson Evans Batten Catalogue", "WEB 4406"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.48251230),
        dec: Angle.Degrees(+01.56938881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89333"},
        {"Hipparcos Number", "HIP 50483"},
        {"Smithsonian Astrophysical Observation", "SAO 118212"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.62821185),
        dec: Angle.Degrees(+01.57030616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64561"},
        {"Hipparcos Number", "HIP 38626"},
        {"Geneva Identification System", "GEN# +1.00064561"},
        {"Renson", "Renson 17713"},
        {"Smithsonian Astrophysical Observation", "SAO 116097"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.64393934),
        dec: Angle.Degrees(+01.57046072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9387"},
        {"Hipparcos Number", "HIP 7160"},
        {"Geneva Identification System", "GEN# +1.00009387"},
        {"Smithsonian Astrophysical Observation", "SAO 109953"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.07723857),
        dec: Angle.Degrees(+01.57205352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141272"},
        {"Hipparcos Number", "HIP 77408"},
        {"Geneva Identification System", "GEN# +1.00141272"},
        {"Smithsonian Astrophysical Observation", "SAO 121196"},
        {"Wilson Evans Batten Catalogue", "WEB 13111"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.03985769),
        dec: Angle.Degrees(+01.57214455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124069"},
        {"Hipparcos Number", "HIP 69324"},
        {"Geneva Identification System", "GEN# +1.00124069"},
        {"Smithsonian Astrophysical Observation", "SAO 120333"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.82724591),
        dec: Angle.Degrees(+01.57242515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71136"},
        {"Hipparcos Number", "HIP 41315"},
        {"Smithsonian Astrophysical Observation", "SAO 116751"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.45156013),
        dec: Angle.Degrees(+01.57444055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106965"},
        {"Hipparcos Number", "HIP 59970"},
        {"Fundamental Katalog 5th Edition", "FK5 5087"},
        {"Smithsonian Astrophysical Observation", "SAO 119313"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.48982398),
        dec: Angle.Degrees(+01.57533526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48016"},
        {"Geneva Identification System", "GEN# +9.80048037"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.81962498),
        dec: Angle.Degrees(+01.57624504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 282.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158736"},
        {"Hipparcos Number", "HIP 85704"},
        {"Geneva Identification System", "GEN# +1.00158736"},
        {"Smithsonian Astrophysical Observation", "SAO 122452"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.70944774),
        dec: Angle.Degrees(+01.57795841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102105"},
        {"Hipparcos Number", "HIP 57315"},
        {"Smithsonian Astrophysical Observation", "SAO 119026"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.27308502),
        dec: Angle.Degrees(+01.57869673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1565"},
        {"Hipparcos Number", "HIP 1596"},
        {"Geneva Identification System", "GEN# +1.00001565"},
        {"Smithsonian Astrophysical Observation", "SAO 109142"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.98795992),
        dec: Angle.Degrees(+01.58254462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213597"},
        {"Hipparcos Number", "HIP 111271"},
        {"Geneva Identification System", "GEN# +1.00213597"},
        {"Smithsonian Astrophysical Observation", "SAO 127584"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.13579749),
        dec: Angle.Degrees(+01.58258999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165511"},
        {"Hipparcos Number", "HIP 88681"},
        {"Smithsonian Astrophysical Observation", "SAO 123121"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.55432239),
        dec: Angle.Degrees(+01.58273273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42017",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6874 AB"},
        {"Henry Draper", "HD 72605"},
        {"Hipparcos Number", "HIP 42017"},
        {"Smithsonian Astrophysical Observation", "SAO 116891"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.47417197),
        dec: Angle.Degrees(+01.58546147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186104"},
        {"Hipparcos Number", "HIP 96948"},
        {"Geneva Identification System", "GEN# +1.00186104"},
        {"Smithsonian Astrophysical Observation", "SAO 124958"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.62361337),
        dec: Angle.Degrees(+01.58667115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148512"},
        {"Hipparcos Number", "HIP 80695"},
        {"Smithsonian Astrophysical Observation", "SAO 121624"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.14284723),
        dec: Angle.Degrees(+01.58688459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15030"},
        {"Hipparcos Number", "HIP 11286"},
        {"Smithsonian Astrophysical Observation", "SAO 110524"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.34663679),
        dec: Angle.Degrees(+01.58756258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5064",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 884 AB"},
        {"Henry Draper", "HD 6387"},
        {"Hipparcos Number", "HIP 5064"},
        {"Smithsonian Astrophysical Observation", "SAO 109655"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20121613),
        dec: Angle.Degrees(+01.58777878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102022"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.11584304),
        dec: Angle.Degrees(+01.58849614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41428"},
        {"Smithsonian Astrophysical Observation", "SAO 116769"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.74543590),
        dec: Angle.Degrees(+01.59255479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36886"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.74967731),
        dec: Angle.Degrees(+01.59387136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54502"},
        {"Smithsonian Astrophysical Observation", "SAO 118689"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.25394972),
        dec: Angle.Degrees(+01.59612547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64191"},
        {"Hipparcos Number", "HIP 38473"},
        {"Geneva Identification System", "GEN# +1.00064191"},
        {"Smithsonian Astrophysical Observation", "SAO 116066"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.19661954),
        dec: Angle.Degrees(+01.59735825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189261"},
        {"Hipparcos Number", "HIP 98363"},
        {"Smithsonian Astrophysical Observation", "SAO 125304"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.77068726),
        dec: Angle.Degrees(+01.59738441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187080"},
        {"Hipparcos Number", "HIP 97418"},
        {"Smithsonian Astrophysical Observation", "SAO 125078"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.00127980),
        dec: Angle.Degrees(+01.59748998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101426"},
        {"Hipparcos Number", "HIP 56938"},
        {"Geneva Identification System", "GEN# +1.00101426"},
        {"Smithsonian Astrophysical Observation", "SAO 118980"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.09279235),
        dec: Angle.Degrees(+01.59910435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145316"},
        {"Hipparcos Number", "HIP 79231"},
        {"Smithsonian Astrophysical Observation", "SAO 121403"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.55121160),
        dec: Angle.Degrees(+01.60122457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59145"},
        {"Geneva Identification System", "GEN# +0.00202516"},
        {"Smithsonian Astrophysical Observation", "SAO 119230"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.91749439),
        dec: Angle.Degrees(+01.60261035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69939"},
        {"Hipparcos Number", "HIP 40783"},
        {"Smithsonian Astrophysical Observation", "SAO 116621"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.85782861),
        dec: Angle.Degrees(+01.60291482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187855"},
        {"Hipparcos Number", "HIP 97762"},
        {"Geneva Identification System", "GEN# +1.00187855"},
        {"Smithsonian Astrophysical Observation", "SAO 125152"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.00224898),
        dec: Angle.Degrees(+01.60334437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30125"},
        {"Hipparcos Number", "HIP 22078"},
        {"Geneva Identification System", "GEN# +1.00030125"},
        {"Smithsonian Astrophysical Observation", "SAO 112038"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.23356309),
        dec: Angle.Degrees(+01.60528357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116384"},
        {"Geneva Identification System", "GEN# +0.00005017"},
        {"Wilson Evans Batten Catalogue", "WEB 20562"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.75032117),
        dec: Angle.Degrees(+01.60533814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 342.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204628"},
        {"Hipparcos Number", "HIP 106131"},
        {"Fundamental Katalog 5th Edition", "FK5 5895"},
        {"Geneva Identification System", "GEN# +1.00204628"},
        {"Smithsonian Astrophysical Observation", "SAO 126838"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.46583013),
        dec: Angle.Degrees(+01.60590814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23419",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3623 A"},
        {"Henry Draper", "HD 32273"},
        {"Hipparcos Number", "HIP 23419"},
        {"Geneva Identification System", "GEN# +1.00032273J"},
        {"Smithsonian Astrophysical Observation", "SAO 112340"},
        {"Wilson Evans Batten Catalogue", "WEB 4549"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.50011262),
        dec: Angle.Degrees(+01.60884108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210946"},
        {"Hipparcos Number", "HIP 109747"},
        {"Geneva Identification System", "GEN# +1.00210946"},
        {"Smithsonian Astrophysical Observation", "SAO 127387"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.45898435),
        dec: Angle.Degrees(+01.60894890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62181"},
        {"Hipparcos Number", "HIP 37593"},
        {"Smithsonian Astrophysical Observation", "SAO 115834"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.70931203),
        dec: Angle.Degrees(+01.60944032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27410",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4396 AB"},
        {"Henry Draper", "HD 38769"},
        {"Hipparcos Number", "HIP 27410"},
        {"Smithsonian Astrophysical Observation", "SAO 113157"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.06105206),
        dec: Angle.Degrees(+01.60975127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216903"},
        {"Hipparcos Number", "HIP 113315"},
        {"Smithsonian Astrophysical Observation", "SAO 127857"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.23232975),
        dec: Angle.Degrees(+01.60977663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115886"},
        {"Hipparcos Number", "HIP 65051"},
        {"Smithsonian Astrophysical Observation", "SAO 119883"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.00906803),
        dec: Angle.Degrees(+01.60991734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12607"},
        {"Hipparcos Number", "HIP 9612"},
        {"Geneva Identification System", "GEN# +1.00012607"},
        {"Smithsonian Astrophysical Observation", "SAO 110311"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.88944071),
        dec: Angle.Degrees(+01.61015111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199973"},
        {"Hipparcos Number", "HIP 103677"},
        {"Geneva Identification System", "GEN# +1.00199973"},
        {"Smithsonian Astrophysical Observation", "SAO 126452"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.12281888),
        dec: Angle.Degrees(+01.61023222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164285"},
        {"Hipparcos Number", "HIP 88159"},
        {"Smithsonian Astrophysical Observation", "SAO 123006"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.08367378),
        dec: Angle.Degrees(+01.61027079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45427"},
        {"Smithsonian Astrophysical Observation", "SAO 117541"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.86462377),
        dec: Angle.Degrees(+01.61097904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36311"},
        {"Hipparcos Number", "HIP 25828"},
        {"Smithsonian Astrophysical Observation", "SAO 112856"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.71897129),
        dec: Angle.Degrees(+01.61136168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23421",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3623 BC"},
        {"Henry Draper", "HD 32273B"},
        {"Hipparcos Number", "HIP 23421"},
        {"Renson", "Renson 8220"},
        {"Smithsonian Astrophysical Observation", "SAO 112341"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.50316339),
        dec: Angle.Degrees(+01.61144084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9274"},
    },
    visualMagnitude: 11.57,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.79692857),
        dec: Angle.Degrees(+01.61236390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47432"},
        {"Hipparcos Number", "HIP 31766"},
        {"Geneva Identification System", "GEN# +1.00047432"},
        {"Smithsonian Astrophysical Observation", "SAO 114191"},
        {"Wilson Evans Batten Catalogue", "WEB 6375"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.65911442),
        dec: Angle.Degrees(+01.61352424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80066"},
        {"Hipparcos Number", "HIP 45598"},
        {"Geneva Identification System", "GEN# +1.00080066"},
        {"Smithsonian Astrophysical Observation", "SAO 117571"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.41389083),
        dec: Angle.Degrees(+01.61590901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105639"},
        {"Smithsonian Astrophysical Observation", "SAO 126767"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.95420838),
        dec: Angle.Degrees(+01.61659506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133145"},
        {"Hipparcos Number", "HIP 73617"},
        {"Smithsonian Astrophysical Observation", "SAO 120807"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.72030506),
        dec: Angle.Degrees(+01.61770700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210291"},
        {"Hipparcos Number", "HIP 109362"},
        {"Smithsonian Astrophysical Observation", "SAO 127329"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.34410528),
        dec: Angle.Degrees(+01.62130203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33448"},
        {"Hipparcos Number", "HIP 24088"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.61758312),
        dec: Angle.Degrees(+01.62154374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10953"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.26698383),
        dec: Angle.Degrees(+01.62387296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31437"},
        {"Hipparcos Number", "HIP 22926"},
        {"Geneva Identification System", "GEN# +1.00031437"},
        {"Smithsonian Astrophysical Observation", "SAO 112223"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.00427494),
        dec: Angle.Degrees(+01.62508434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58250"},
        {"Hipparcos Number", "HIP 35980"},
        {"Smithsonian Astrophysical Observation", "SAO 115406"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.22436166),
        dec: Angle.Degrees(+01.62547068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129338"},
        {"Hipparcos Number", "HIP 71864"},
        {"Smithsonian Astrophysical Observation", "SAO 120605"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.48957985),
        dec: Angle.Degrees(+01.62598533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7842",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1323 AB"},
        {"Henry Draper", "HD 10313"},
        {"Hipparcos Number", "HIP 7842"},
        {"Smithsonian Astrophysical Observation", "SAO 110051"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.21677715),
        dec: Angle.Degrees(+01.62828629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125470"},
        {"Hipparcos Number", "HIP 70015"},
        {"Smithsonian Astrophysical Observation", "SAO 120399"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.89251008),
        dec: Angle.Degrees(+01.62860482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288247"},
        {"Hipparcos Number", "HIP 27242"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.60898655),
        dec: Angle.Degrees(+01.62934720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43063"},
        {"Smithsonian Astrophysical Observation", "SAO 117103"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.58838556),
        dec: Angle.Degrees(+01.63224560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126992"},
        {"Hipparcos Number", "HIP 70811"},
        {"Smithsonian Astrophysical Observation", "SAO 120485"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.22065032),
        dec: Angle.Degrees(+01.63295913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120296"},
        {"Hipparcos Number", "HIP 67378"},
        {"Smithsonian Astrophysical Observation", "SAO 120120"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.14347707),
        dec: Angle.Degrees(+01.63343033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201821"},
        {"Hipparcos Number", "HIP 104668"},
        {"Smithsonian Astrophysical Observation", "SAO 126606"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.01985288),
        dec: Angle.Degrees(+01.63367468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14371"},
    },
    visualMagnitude: 12.48,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.34739365),
        dec: Angle.Degrees(+01.63614671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11872"},
        {"Hipparcos Number", "HIP 9062"},
        {"Smithsonian Astrophysical Observation", "SAO 110242"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.16854475),
        dec: Angle.Degrees(+01.63630043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86296"},
        {"Hipparcos Number", "HIP 48828"},
        {"Smithsonian Astrophysical Observation", "SAO 118017"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.40779672),
        dec: Angle.Degrees(+01.63938085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46538"},
        {"Hipparcos Number", "HIP 31321"},
        {"Smithsonian Astrophysical Observation", "SAO 114064"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.52563320),
        dec: Angle.Degrees(+01.64078744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54807"},
        {"Hipparcos Number", "HIP 34633"},
        {"Smithsonian Astrophysical Observation", "SAO 115030"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.60929677),
        dec: Angle.Degrees(+01.64315605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36013"},
        {"Hipparcos Number", "HIP 25648"},
        {"Celescope Catalog", "CEL 726"},
        {"Geneva Identification System", "GEN# +1.00036013A"},
        {"Smithsonian Astrophysical Observation", "SAO 112813"},
        {"Wilson Evans Batten Catalogue", "WEB 4977"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.18869193),
        dec: Angle.Degrees(+01.64393563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55368"},
        {"Smithsonian Astrophysical Observation", "SAO 118796"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.06139284),
        dec: Angle.Degrees(+01.64700571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191264"},
        {"Hipparcos Number", "HIP 99266"},
        {"Geneva Identification System", "GEN# +1.00191264"},
        {"Smithsonian Astrophysical Observation", "SAO 125497"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.25502308),
        dec: Angle.Degrees(+01.64966124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18570"},
        {"Smithsonian Astrophysical Observation", "SAO 111535"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.63701275),
        dec: Angle.Degrees(+01.65034681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98366"},
        {"Hipparcos Number", "HIP 55249"},
        {"Geneva Identification System", "GEN# +1.00098366"},
        {"Smithsonian Astrophysical Observation", "SAO 118778"},
        {"Wilson Evans Batten Catalogue", "WEB 9951"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.72908955),
        dec: Angle.Degrees(+01.65053072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205763"},
        {"Hipparcos Number", "HIP 106756"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.37810315),
        dec: Angle.Degrees(+01.65115127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18582"},
        {"Hipparcos Number", "HIP 13927"},
        {"Smithsonian Astrophysical Observation", "SAO 110884"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.85781873),
        dec: Angle.Degrees(+01.65127521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22672"},
        {"Hipparcos Number", "HIP 17011"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.70607207),
        dec: Angle.Degrees(+01.65449692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212924"},
        {"Hipparcos Number", "HIP 110876"},
        {"Geneva Identification System", "GEN# +1.00212924"},
        {"Smithsonian Astrophysical Observation", "SAO 127539"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.95657100),
        dec: Angle.Degrees(+01.65731403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26796"},
        {"Hipparcos Number", "HIP 19779"},
        {"Geneva Identification System", "GEN# +1.00026796"},
        {"Smithsonian Astrophysical Observation", "SAO 111678"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.60460806),
        dec: Angle.Degrees(+01.65933021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99492"},
    },
    visualMagnitude: 11.52,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.86676365),
        dec: Angle.Degrees(+01.65943789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153314"},
        {"Hipparcos Number", "HIP 83082"},
        {"Smithsonian Astrophysical Observation", "SAO 121971"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.65748834),
        dec: Angle.Degrees(+01.66197490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110980"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.27432832),
        dec: Angle.Degrees(+01.66385679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15845"},
        {"Hipparcos Number", "HIP 11853"},
        {"Smithsonian Astrophysical Observation", "SAO 110608"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.24662975),
        dec: Angle.Degrees(+01.66415636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253"},
        {"Hipparcos Number", "HIP 604"},
        {"Smithsonian Astrophysical Observation", "SAO 109020"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.83122750),
        dec: Angle.Degrees(+01.66508782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189188"},
        {"Hipparcos Number", "HIP 98336"},
        {"Smithsonian Astrophysical Observation", "SAO 125298"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.68272797),
        dec: Angle.Degrees(+01.66655159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16227"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.26609285),
        dec: Angle.Degrees(+01.66872788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 322.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138936"},
        {"Hipparcos Number", "HIP 76291"},
        {"Geneva Identification System", "GEN# +1.00138936"},
        {"Smithsonian Astrophysical Observation", "SAO 121071"},
        {"Wilson Evans Batten Catalogue", "WEB 12954"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.76929280),
        dec: Angle.Degrees(+01.66927984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206968"},
        {"Hipparcos Number", "HIP 107444"},
        {"Smithsonian Astrophysical Observation", "SAO 127044"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.43370391),
        dec: Angle.Degrees(+01.66939724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193708"},
        {"Hipparcos Number", "HIP 100399"},
        {"Smithsonian Astrophysical Observation", "SAO 125715"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.40159417),
        dec: Angle.Degrees(+01.67090551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223003"},
        {"Hipparcos Number", "HIP 117195"},
        {"Geneva Identification System", "GEN# +1.00223003"},
        {"Smithsonian Astrophysical Observation", "SAO 128368"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.44793923),
        dec: Angle.Degrees(+01.67207590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158855"},
        {"Hipparcos Number", "HIP 85766"},
        {"Geneva Identification System", "GEN# +1.00158855"},
        {"Smithsonian Astrophysical Observation", "SAO 122468"},
        {"Wilson Evans Batten Catalogue", "WEB 14473"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.87848859),
        dec: Angle.Degrees(+01.67233263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185808"},
        {"Hipparcos Number", "HIP 96828"},
        {"Smithsonian Astrophysical Observation", "SAO 124926"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.21298991),
        dec: Angle.Degrees(+01.67298772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76431"},
        {"Hipparcos Number", "HIP 43866"},
        {"Geneva Identification System", "GEN# +1.00076431"},
        {"Smithsonian Astrophysical Observation", "SAO 117279"},
    },
    visualMagnitude: 9.23,
    bvColour: -0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.04663421),
        dec: Angle.Degrees(+01.67717749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13819"},
        {"Hipparcos Number", "HIP 10445"},
        {"Smithsonian Astrophysical Observation", "SAO 110424"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.65413702),
        dec: Angle.Degrees(+01.67762058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127988"},
        {"Hipparcos Number", "HIP 71255"},
        {"Smithsonian Astrophysical Observation", "SAO 120536"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.57832779),
        dec: Angle.Degrees(+01.67814769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13302",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2177 AB"},
        {"Hipparcos Number", "HIP 13302"},
        {"Smithsonian Astrophysical Observation", "SAO 110787"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.79816802),
        dec: Angle.Degrees(+01.68043289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203682"},
        {"Hipparcos Number", "HIP 105636"},
        {"Smithsonian Astrophysical Observation", "SAO 126765"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.94471410),
        dec: Angle.Degrees(+01.68106227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13431"},
        {"Hipparcos Number", "HIP 10217"},
        {"Smithsonian Astrophysical Observation", "SAO 110391"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.84469182),
        dec: Angle.Degrees(+01.68269838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138279"},
        {"Hipparcos Number", "HIP 75982"},
        {"Geneva Identification System", "GEN# +1.00138279"},
        {"Wilson Evans Batten Catalogue", "WEB 12919"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.75828311),
        dec: Angle.Degrees(+01.68384613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25953"},
        {"Hipparcos Number", "HIP 19183"},
        {"Geneva Identification System", "GEN# +1.00025953"},
        {"Smithsonian Astrophysical Observation", "SAO 111606"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.67296582),
        dec: Angle.Degrees(+01.68414058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137609"},
        {"Hipparcos Number", "HIP 75614"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.74465724),
        dec: Angle.Degrees(+01.68422506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1367"},
        {"Hipparcos Number", "HIP 1421"},
        {"Fundamental Katalog 5th Edition", "FK5 2017"},
        {"Geneva Identification System", "GEN# +1.00001367"},
        {"Smithsonian Astrophysical Observation", "SAO 109119"},
        {"Wilson Evans Batten Catalogue", "WEB 260"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.44852220),
        dec: Angle.Degrees(+01.68870485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44797"},
        {"Hipparcos Number", "HIP 30434"},
        {"Geneva Identification System", "GEN# +1.00044797"},
        {"Smithsonian Astrophysical Observation", "SAO 113818"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.97768084),
        dec: Angle.Degrees(+01.68884839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74129",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9517 A"},
        {"Henry Draper", "HD 134285"},
        {"Hipparcos Number", "HIP 74129"},
        {"Smithsonian Astrophysical Observation", "SAO 120863"},
        {"Wilson Evans Batten Catalogue", "WEB 12665"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.23874885),
        dec: Angle.Degrees(+01.68930454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112388"},
    },
    visualMagnitude: 11.98,
    bvColour: 1.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.44229183),
        dec: Angle.Degrees(+01.68984483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36392"},
        {"Hipparcos Number", "HIP 25881"},
        {"Celescope Catalog", "CEL 753"},
        {"Geneva Identification System", "GEN# +1.00036392"},
        {"Smithsonian Astrophysical Observation", "SAO 112867"},
        {"Wilson Evans Batten Catalogue", "WEB 5026"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.87453044),
        dec: Angle.Degrees(+01.69003649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40964"},
        {"Hipparcos Number", "HIP 28609"},
        {"Geneva Identification System", "GEN# +1.00040964"},
        {"Smithsonian Astrophysical Observation", "SAO 113392"},
        {"Wilson Evans Batten Catalogue", "WEB 5588"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.57128462),
        dec: Angle.Degrees(+01.69406431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200374"},
        {"Hipparcos Number", "HIP 103893"},
        {"Smithsonian Astrophysical Observation", "SAO 126492"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.76727683),
        dec: Angle.Degrees(+01.69411075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4007"},
        {"Hipparcos Number", "HIP 3350"},
        {"Smithsonian Astrophysical Observation", "SAO 109394"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.67048141),
        dec: Angle.Degrees(+01.69522806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47237",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7462 AB"},
        {"Henry Draper", "HD 83329"},
        {"Hipparcos Number", "HIP 47237"},
        {"Smithsonian Astrophysical Observation", "SAO 117816"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.41925282),
        dec: Angle.Degrees(+01.69597170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35177"},
        {"Hipparcos Number", "HIP 25163"},
        {"Celescope Catalog", "CEL 661"},
        {"Geneva Identification System", "GEN# +1.00035177"},
        {"Renson", "Renson 8980"},
        {"Smithsonian Astrophysical Observation", "SAO 112701"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.75806140),
        dec: Angle.Degrees(+01.69692936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189511"},
        {"Hipparcos Number", "HIP 98476"},
        {"Geneva Identification System", "GEN# +1.00189511"},
        {"Smithsonian Astrophysical Observation", "SAO 125338"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.09187997),
        dec: Angle.Degrees(+01.69821671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143898"},
        {"Hipparcos Number", "HIP 78610"},
        {"Geneva Identification System", "GEN# +1.00143898"},
        {"Renson", "Renson 40765"},
        {"Smithsonian Astrophysical Observation", "SAO 121335"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.73813029),
        dec: Angle.Degrees(+01.69847893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287487"},
        {"Hipparcos Number", "HIP 23510"},
        {"Smithsonian Astrophysical Observation", "SAO 112365"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.82471495),
        dec: Angle.Degrees(+01.69957751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39142"},
        {"Hipparcos Number", "HIP 27602"},
        {"Smithsonian Astrophysical Observation", "SAO 113200"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.65996616),
        dec: Angle.Degrees(+01.69966955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55260"},
        {"Smithsonian Astrophysical Observation", "SAO 118781"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.77614907),
        dec: Angle.Degrees(+01.70182708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223904"},
        {"Hipparcos Number", "HIP 117805"},
        {"Smithsonian Astrophysical Observation", "SAO 128445"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.38656885),
        dec: Angle.Degrees(+01.70330280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13050",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2133 AB"},
        {"Henry Draper", "HD 17417"},
        {"Hipparcos Number", "HIP 13050"},
        {"Smithsonian Astrophysical Observation", "SAO 110751"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.91615028),
        dec: Angle.Degrees(+01.70543520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6500"},
        {"Hipparcos Number", "HIP 5163"},
        {"Cincinnati Publication", "Ci 18 145"},
        {"Geneva Identification System", "GEN# +1.00006500"},
        {"Smithsonian Astrophysical Observation", "SAO 109670"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.52108288),
        dec: Angle.Degrees(+01.70677008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32138",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5364 C"},
        {"Henry Draper", "HD 288966"},
        {"Henry Draper 2", "HD 48279C"},
        {"Hipparcos Number", "HIP 32138"},
        {"Geneva Identification System", "GEN# +1.00048279C"},
        {"Smithsonian Astrophysical Observation", "SAO 114308"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.67276613),
        dec: Angle.Degrees(+01.70690832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83292"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.776,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.33620397),
        dec: Angle.Degrees(+01.70698484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90035"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.57154721),
        dec: Angle.Degrees(+01.70711743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117331"},
        {"Hipparcos Number", "HIP 65816"},
        {"Smithsonian Astrophysical Observation", "SAO 119957"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.38839489),
        dec: Angle.Degrees(+01.70806838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74568"},
        {"Hipparcos Number", "HIP 42920"},
        {"Smithsonian Astrophysical Observation", "SAO 117086"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.20687869),
        dec: Angle.Degrees(+01.70858413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162754"},
        {"Hipparcos Number", "HIP 87490"},
        {"Geneva Identification System", "GEN# +1.00162754"},
        {"Smithsonian Astrophysical Observation", "SAO 122859"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.14223325),
        dec: Angle.Degrees(+01.70961359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144517"},
        {"Hipparcos Number", "HIP 78888"},
        {"Geneva Identification System", "GEN# +1.00144517"},
        {"Smithsonian Astrophysical Observation", "SAO 121364"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.56075505),
        dec: Angle.Degrees(+01.71106632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59900",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8499 AB"},
        {"Henry Draper", "HD 106832"},
        {"Hipparcos Number", "HIP 59900"},
        {"Renson", "Renson 30926"},
        {"Smithsonian Astrophysical Observation", "SAO 119305"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.28181500),
        dec: Angle.Degrees(+01.71249834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31767"},
        {"Hipparcos Number", "HIP 23123"},
        {"Geneva Identification System", "GEN# +1.00031767"},
        {"Smithsonian Astrophysical Observation", "SAO 112281"},
        {"Wilson Evans Batten Catalogue", "WEB 4484"},
    },
    visualMagnitude: 4.47,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.63709525),
        dec: Angle.Degrees(+01.71403506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21016",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21016"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.59930447),
        dec: Angle.Degrees(+01.71467416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126699"},
        {"Hipparcos Number", "HIP 70652"},
        {"Smithsonian Astrophysical Observation", "SAO 120468"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.75855073),
        dec: Angle.Degrees(+01.71494801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199381"},
        {"Hipparcos Number", "HIP 103391"},
        {"Smithsonian Astrophysical Observation", "SAO 126391"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.19771853),
        dec: Angle.Degrees(+01.71567616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32137",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5364 AB"},
        {"Henry Draper", "HD 48279"},
        {"Hipparcos Number", "HIP 32137"},
        {"Geneva Identification System", "GEN# +1.00048279J"},
        {"Smithsonian Astrophysical Observation", "SAO 114307"},
        {"Wilson Evans Batten Catalogue", "WEB 6486"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.66895094),
        dec: Angle.Degrees(+01.71617609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84616"},
        {"Hipparcos Number", "HIP 47966"},
        {"Geneva Identification System", "GEN# +1.00084616"},
        {"Smithsonian Astrophysical Observation", "SAO 117902"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.63567406),
        dec: Angle.Degrees(+01.71893904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154907"},
        {"Hipparcos Number", "HIP 83852"},
        {"Smithsonian Astrophysical Observation", "SAO 122108"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.04518089),
        dec: Angle.Degrees(+01.71942766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83851"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.04151212),
        dec: Angle.Degrees(+01.71970951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66169",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66169"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.44791740),
        dec: Angle.Degrees(+01.72274422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -170.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198168"},
        {"Hipparcos Number", "HIP 102689"},
        {"Smithsonian Astrophysical Observation", "SAO 126230"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.11590285),
        dec: Angle.Degrees(+01.72279889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86470",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86470"},
        {"Smithsonian Astrophysical Observation", "SAO 122626"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.01052090),
        dec: Angle.Degrees(+01.72362423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135269"},
        {"Hipparcos Number", "HIP 74562"},
        {"Geneva Identification System", "GEN# +1.00135269"},
        {"Smithsonian Astrophysical Observation", "SAO 120907"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.52854350),
        dec: Angle.Degrees(+01.72447815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24181"},
        {"Hipparcos Number", "HIP 18022"},
        {"Geneva Identification System", "GEN# +1.00024181"},
        {"Smithsonian Astrophysical Observation", "SAO 111460"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.76564175),
        dec: Angle.Degrees(+01.72493987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114494"},
        {"Hipparcos Number", "HIP 64311"},
        {"Geneva Identification System", "GEN# +1.00114494"},
        {"Smithsonian Astrophysical Observation", "SAO 119801"},
        {"Wilson Evans Batten Catalogue", "WEB 11365"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.71769707),
        dec: Angle.Degrees(+01.72579971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8334"},
        {"Hipparcos Number", "HIP 6432"},
        {"Fundamental Katalog 5th Edition", "FK5 2091"},
        {"Geneva Identification System", "GEN# +1.00008334"},
        {"Smithsonian Astrophysical Observation", "SAO 109834"},
        {"Wilson Evans Batten Catalogue", "WEB 1422"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.65381169),
        dec: Angle.Degrees(+01.72644123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46643"},
        {"Hipparcos Number", "HIP 31370"},
        {"Smithsonian Astrophysical Observation", "SAO 114086"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.66571967),
        dec: Angle.Degrees(+01.72769488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35281"},
    },
    visualMagnitude: 11.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.32987447),
        dec: Angle.Degrees(+01.72778835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96378"},
        {"Geneva Identification System", "GEN# +0.00104042"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.93184565),
        dec: Angle.Degrees(+01.72883990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95089"},
        {"Hipparcos Number", "HIP 53666"},
        {"Smithsonian Astrophysical Observation", "SAO 118598"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.69898700),
        dec: Angle.Degrees(+01.72933072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287841"},
        {"Hipparcos Number", "HIP 25299"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.17834318),
        dec: Angle.Degrees(+01.73007139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16971"},
        {"Hipparcos Number", "HIP 12707"},
        {"Smithsonian Astrophysical Observation", "SAO 110708"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.82702076),
        dec: Angle.Degrees(+01.73013621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171997"},
        {"Hipparcos Number", "HIP 91323"},
        {"Smithsonian Astrophysical Observation", "SAO 123721"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.40457716),
        dec: Angle.Degrees(+01.73129588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65564"},
        {"Smithsonian Astrophysical Observation", "SAO 119925"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.64092547),
        dec: Angle.Degrees(+01.73340456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126170"},
        {"Hipparcos Number", "HIP 70371"},
        {"Smithsonian Astrophysical Observation", "SAO 120430"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.96504056),
        dec: Angle.Degrees(+01.73416270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173836"},
        {"Hipparcos Number", "HIP 92183"},
        {"Smithsonian Astrophysical Observation", "SAO 123917"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.82254382),
        dec: Angle.Degrees(+01.73544351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161022"},
        {"Hipparcos Number", "HIP 86715"},
        {"Geneva Identification System", "GEN# +1.00161022"},
        {"Smithsonian Astrophysical Observation", "SAO 122668"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.77704954),
        dec: Angle.Degrees(+01.73764296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122425"},
        {"Hipparcos Number", "HIP 68530"},
        {"Smithsonian Astrophysical Observation", "SAO 120240"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.43820932),
        dec: Angle.Degrees(+01.74146572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156458"},
        {"Hipparcos Number", "HIP 84600"},
        {"Geneva Identification System", "GEN# +1.00156458"},
        {"Smithsonian Astrophysical Observation", "SAO 122244"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.40409024),
        dec: Angle.Degrees(+01.74252057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53185",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53185"},
        {"Smithsonian Astrophysical Observation", "SAO 118557"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.18551972),
        dec: Angle.Degrees(+01.74316822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39572"},
        {"Hipparcos Number", "HIP 27854"},
        {"Geneva Identification System", "GEN# +1.00039572"},
        {"Renson", "Renson 10598"},
        {"Smithsonian Astrophysical Observation", "SAO 113246"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.39724389),
        dec: Angle.Degrees(+01.74324721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104876"},
        {"Smithsonian Astrophysical Observation", "SAO 126644"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.66666944),
        dec: Angle.Degrees(+01.74702017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18147",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2831 AB"},
        {"Henry Draper", "HD 24380"},
        {"Hipparcos Number", "HIP 18147"},
        {"Smithsonian Astrophysical Observation", "SAO 111474"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.19859987),
        dec: Angle.Degrees(+01.74792552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3906"},
        {"Hipparcos Number", "HIP 3265"},
        {"Geneva Identification System", "GEN# +1.00003906"},
        {"Smithsonian Astrophysical Observation", "SAO 109373"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.39180299),
        dec: Angle.Degrees(+01.74796387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27339"},
        {"Hipparcos Number", "HIP 20131"},
        {"Geneva Identification System", "GEN# +1.00027339"},
        {"Smithsonian Astrophysical Observation", "SAO 111742"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.74560010),
        dec: Angle.Degrees(+01.75041865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56405"},
        {"Geneva Identification System", "GEN# +0.00202446"},
        {"Wilson Evans Batten Catalogue", "WEB 10134"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.45441153),
        dec: Angle.Degrees(+01.75222783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215476"},
        {"Hipparcos Number", "HIP 112350"},
        {"Smithsonian Astrophysical Observation", "SAO 127737"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.34537112),
        dec: Angle.Degrees(+01.75269315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174966"},
        {"Hipparcos Number", "HIP 92683"},
        {"Smithsonian Astrophysical Observation", "SAO 124004"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.28260596),
        dec: Angle.Degrees(+01.75542454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14214"},
        {"Hipparcos Number", "HIP 10723"},
        {"Cincinnati Publication", "Ci 20 164"},
        {"Fundamental Katalog 5th Edition", "FK5 1061"},
        {"Geneva Identification System", "GEN# +1.00014214"},
        {"Smithsonian Astrophysical Observation", "SAO 110456"},
        {"Wilson Evans Batten Catalogue", "WEB 2261"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.50510951),
        dec: Angle.Degrees(+01.75689975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 365.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 371.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34263"},
        {"Hipparcos Number", "HIP 24563"},
        {"Smithsonian Astrophysical Observation", "SAO 112584"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.04753985),
        dec: Angle.Degrees(+01.75698009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167352"},
        {"Hipparcos Number", "HIP 89412"},
        {"Smithsonian Astrophysical Observation", "SAO 123287"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.68926564),
        dec: Angle.Degrees(+01.75835421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138076"},
        {"Hipparcos Number", "HIP 75852"},
        {"Smithsonian Astrophysical Observation", "SAO 121029"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.40459501),
        dec: Angle.Degrees(+01.75855615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40935"},
        {"Hipparcos Number", "HIP 28590"},
        {"Smithsonian Astrophysical Observation", "SAO 113387"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.52361631),
        dec: Angle.Degrees(+01.76089388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91580"},
        {"Hipparcos Number", "HIP 51762"},
        {"Geneva Identification System", "GEN# +1.00091580"},
        {"Smithsonian Astrophysical Observation", "SAO 118375"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.63699792),
        dec: Angle.Degrees(+01.76124729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218115"},
        {"Hipparcos Number", "HIP 114021"},
        {"Smithsonian Astrophysical Observation", "SAO 127961"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.36470357),
        dec: Angle.Degrees(+01.76284699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185246"},
        {"Hipparcos Number", "HIP 96589"},
        {"Smithsonian Astrophysical Observation", "SAO 124872"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54377091),
        dec: Angle.Degrees(+01.76498454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57757",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Zavijava"},
        {"Henry Draper", "HD 102870"},
        {"Hipparcos Number", "HIP 57757"},
        {"Cincinnati Publication", "Ci 20 665"},
        {"Fundamental Katalog 5th Edition", "FK5 445"},
        {"Geneva Identification System", "GEN# +1.00102870"},
        {"Smithsonian Astrophysical Observation", "SAO 119076"},
        {"Wilson Evans Batten Catalogue", "WEB 10364"},
    },
    visualMagnitude: 3.59,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.67202553),
        dec: Angle.Degrees(+01.76537705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 740.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42601"},
        {"Hipparcos Number", "HIP 29392"},
        {"Smithsonian Astrophysical Observation", "SAO 113573"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.91877572),
        dec: Angle.Degrees(+01.76544203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29395"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.92183006),
        dec: Angle.Degrees(+01.76609062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74975",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9584 A"},
        {"Henry Draper", "HD 136202"},
        {"Hipparcos Number", "HIP 74975"},
        {"Cincinnati Publication", "Ci 20 922"},
        {"Geneva Identification System", "GEN# +1.00136202A"},
        {"Smithsonian Astrophysical Observation", "SAO 120946"},
        {"Wilson Evans Batten Catalogue", "WEB 12790"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.82741626),
        dec: Angle.Degrees(+01.76665611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 373.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -513.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63975"},
        {"Hipparcos Number", "HIP 38373"},
        {"Fundamental Katalog 5th Edition", "FK5 1205"},
        {"Geneva Identification System", "GEN# +1.00063975"},
        {"Renson", "Renson 17640"},
        {"Smithsonian Astrophysical Observation", "SAO 116043"},
        {"Wilson Evans Batten Catalogue", "WEB 7545"},
    },
    visualMagnitude: 5.12,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.92498666),
        dec: Angle.Degrees(+01.76687765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111288"},
        {"Hipparcos Number", "HIP 62473"},
        {"Smithsonian Astrophysical Observation", "SAO 119599"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.04538767),
        dec: Angle.Degrees(+01.76752414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66427"},
        {"Hipparcos Number", "HIP 39430"},
        {"Geneva Identification System", "GEN# +1.00066427"},
        {"Smithsonian Astrophysical Observation", "SAO 116285"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.90195477),
        dec: Angle.Degrees(+01.76829549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74907"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.63044230),
        dec: Angle.Degrees(+01.76976006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187772"},
        {"Hipparcos Number", "HIP 97732"},
        {"Smithsonian Astrophysical Observation", "SAO 125145"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.91863102),
        dec: Angle.Degrees(+01.77032165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15708"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.58772353),
        dec: Angle.Degrees(+01.77274627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27324"},
        {"Hipparcos Number", "HIP 20125"},
        {"Geneva Identification System", "GEN# +1.00027324"},
        {"Smithsonian Astrophysical Observation", "SAO 111741"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.72881456),
        dec: Angle.Degrees(+01.77350646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209624"},
        {"Hipparcos Number", "HIP 108990"},
        {"Smithsonian Astrophysical Observation", "SAO 127269"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.19494398),
        dec: Angle.Degrees(+01.77420187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43685"},
        {"Hipparcos Number", "HIP 29887"},
        {"Smithsonian Astrophysical Observation", "SAO 113688"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.40097899),
        dec: Angle.Degrees(+01.77496430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131478"},
        {"Hipparcos Number", "HIP 72884"},
        {"Smithsonian Astrophysical Observation", "SAO 120720"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.44526547),
        dec: Angle.Degrees(+01.77498031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37872"},
        {"Hipparcos Number", "HIP 26822"},
        {"Smithsonian Astrophysical Observation", "SAO 113044"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.42622353),
        dec: Angle.Degrees(+01.77612060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86161"},
        {"Smithsonian Astrophysical Observation", "SAO 122558"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.10538329),
        dec: Angle.Degrees(+01.77755019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39103"},
        {"Hipparcos Number", "HIP 27574"},
        {"Geneva Identification System", "GEN# +1.00039103"},
        {"Smithsonian Astrophysical Observation", "SAO 113196"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.60054469),
        dec: Angle.Degrees(+01.77868136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216287"},
        {"Hipparcos Number", "HIP 112890"},
        {"Fundamental Katalog 5th Edition", "FK5 6019"},
        {"Smithsonian Astrophysical Observation", "SAO 127805"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.92254375),
        dec: Angle.Degrees(+01.77873930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37221"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.68078975),
        dec: Angle.Degrees(+01.77915600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22271"},
        {"Hipparcos Number", "HIP 16728"},
        {"Smithsonian Astrophysical Observation", "SAO 111276"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.80485994),
        dec: Angle.Degrees(+01.77954373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222603"},
        {"Hipparcos Number", "HIP 116928"},
        {"Fundamental Katalog 5th Edition", "FK5 1620"},
        {"Geneva Identification System", "GEN# +1.00222603"},
        {"Smithsonian Astrophysical Observation", "SAO 128336"},
        {"Wilson Evans Batten Catalogue", "WEB 20626"},
    },
    visualMagnitude: 4.49,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.51200741),
        dec: Angle.Degrees(+01.78041720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190663"},
        {"Hipparcos Number", "HIP 99006"},
        {"Renson", "Renson 53020"},
        {"Smithsonian Astrophysical Observation", "SAO 125439"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.49824872),
        dec: Angle.Degrees(+01.78163093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43214"},
        {"Hipparcos Number", "HIP 29674"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.77536059),
        dec: Angle.Degrees(+01.78182177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109064",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15611 A"},
        {"Henry Draper", "HD 209748"},
        {"Hipparcos Number", "HIP 109064"},
        {"Smithsonian Astrophysical Observation", "SAO 127283"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.41325389),
        dec: Angle.Degrees(+01.78242156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23200",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23200"},
        {"Geneva Identification System", "GEN# +6.20030111"},
        {"Wilson Evans Batten Catalogue", "WEB 4507"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.89504630),
        dec: Angle.Degrees(+01.78375097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178240"},
        {"Hipparcos Number", "HIP 93950"},
        {"Smithsonian Astrophysical Observation", "SAO 124300"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.94301138),
        dec: Angle.Degrees(+01.78498002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5588"},
        {"Hipparcos Number", "HIP 4500"},
        {"Fundamental Katalog 5th Edition", "FK5 4087"},
        {"Geneva Identification System", "GEN# +1.00005588"},
        {"Smithsonian Astrophysical Observation", "SAO 109556"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.41521029),
        dec: Angle.Degrees(+01.78558469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84607"},
        {"Hipparcos Number", "HIP 47960"},
        {"Fundamental Katalog 5th Edition", "FK5 2782"},
        {"Geneva Identification System", "GEN# +1.00084607"},
        {"Smithsonian Astrophysical Observation", "SAO 117901"},
        {"Wilson Evans Batten Catalogue", "WEB 8970"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.59851244),
        dec: Angle.Degrees(+01.78568624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4256"},
        {"Hipparcos Number", "HIP 3535"},
        {"Cincinnati Publication", "Ci 18 98"},
        {"Cincinnati Publication 2", "Ci 20 52"},
        {"Geneva Identification System", "GEN# +1.00004256"},
        {"Smithsonian Astrophysical Observation", "SAO 109432"},
        {"Wilson Evans Batten Catalogue", "WEB 624"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.27051240),
        dec: Angle.Degrees(+01.78691411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -573.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201332"},
        {"Hipparcos Number", "HIP 104389"},
        {"Smithsonian Astrophysical Observation", "SAO 126571"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.21457734),
        dec: Angle.Degrees(+01.78755819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36166"},
        {"Hipparcos Number", "HIP 25751"},
        {"Celescope Catalog", "CEL 737"},
        {"Geneva Identification System", "GEN# +1.00036166"},
        {"Smithsonian Astrophysical Observation", "SAO 112830"},
        {"Wilson Evans Batten Catalogue", "WEB 5000"},
    },
    visualMagnitude: 5.77,
    bvColour: -0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.47822116),
        dec: Angle.Degrees(+01.78926104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20257"},
        {"Hipparcos Number", "HIP 15168"},
        {"Smithsonian Astrophysical Observation", "SAO 111080"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.88029471),
        dec: Angle.Degrees(+01.79115407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114823"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.89450903),
        dec: Angle.Degrees(+01.79133132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 134.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48238",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7535 AB"},
        {"Henry Draper", "HD 85144"},
        {"Hipparcos Number", "HIP 48238"},
        {"Smithsonian Astrophysical Observation", "SAO 117931"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.51196823),
        dec: Angle.Degrees(+01.79361895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214798"},
        {"Hipparcos Number", "HIP 111952"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.16032108),
        dec: Angle.Degrees(+01.79459807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25137"},
        {"Hipparcos Number", "HIP 18660"},
        {"Geneva Identification System", "GEN# +1.00025137"},
        {"Smithsonian Astrophysical Observation", "SAO 111549"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.92320473),
        dec: Angle.Degrees(+01.79482040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84078"},
        {"Hipparcos Number", "HIP 47628"},
        {"Geneva Identification System", "GEN# +1.00084078"},
        {"Smithsonian Astrophysical Observation", "SAO 117866"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.67444802),
        dec: Angle.Degrees(+01.79610309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124628"},
        {"Hipparcos Number", "HIP 69588"},
        {"Geneva Identification System", "GEN# +1.00124628"},
        {"Smithsonian Astrophysical Observation", "SAO 120361"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.66185443),
        dec: Angle.Degrees(+01.79721078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89113"},
        {"Hipparcos Number", "HIP 50348"},
        {"Smithsonian Astrophysical Observation", "SAO 118195"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.21516978),
        dec: Angle.Degrees(+01.79778381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201491"},
        {"Hipparcos Number", "HIP 104489"},
        {"Smithsonian Astrophysical Observation", "SAO 126588"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.50148884),
        dec: Angle.Degrees(+01.79834170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63884"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.38014849),
        dec: Angle.Degrees(+01.79994658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206635"},
        {"Hipparcos Number", "HIP 107252"},
        {"Smithsonian Astrophysical Observation", "SAO 127015"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.85522453),
        dec: Angle.Degrees(+01.80097605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19056",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19056"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.24081590),
        dec: Angle.Degrees(+01.80735546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28956"},
        {"Hipparcos Number", "HIP 21268"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.44703315),
        dec: Angle.Degrees(+01.81027971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47221"},
        {"Hipparcos Number", "HIP 31669"},
        {"Smithsonian Astrophysical Observation", "SAO 114155"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.41649918),
        dec: Angle.Degrees(+01.81150437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199141"},
        {"Hipparcos Number", "HIP 103262"},
        {"Geneva Identification System", "GEN# +1.00199141"},
        {"Smithsonian Astrophysical Observation", "SAO 126364"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.78513091),
        dec: Angle.Degrees(+01.81321691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46712"},
        {"Hipparcos Number", "HIP 31420"},
        {"Smithsonian Astrophysical Observation", "SAO 114092"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.76752610),
        dec: Angle.Degrees(+01.81685056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197534"},
        {"Hipparcos Number", "HIP 102350"},
        {"Geneva Identification System", "GEN# +1.00197534"},
        {"Smithsonian Astrophysical Observation", "SAO 126155"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.06697292),
        dec: Angle.Degrees(+01.81879829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177178"},
        {"Hipparcos Number", "HIP 93580"},
        {"Geneva Identification System", "GEN# +1.00177178"},
        {"Smithsonian Astrophysical Observation", "SAO 124203"},
        {"Wilson Evans Batten Catalogue", "WEB 16252"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.88432906),
        dec: Angle.Degrees(+01.81893472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141715"},
        {"Hipparcos Number", "HIP 77584"},
        {"Smithsonian Astrophysical Observation", "SAO 121216"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.60872790),
        dec: Angle.Degrees(+01.81911433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1823"},
        {"Hipparcos Number", "HIP 1783"},
        {"Smithsonian Astrophysical Observation", "SAO 109166"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.66968661),
        dec: Angle.Degrees(+01.82350699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87035"},
        {"Hipparcos Number", "HIP 49200"},
        {"Geneva Identification System", "GEN# +1.00087035"},
        {"Smithsonian Astrophysical Observation", "SAO 118067"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.63117058),
        dec: Angle.Degrees(+01.82361357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7074 AB"},
        {"Henry Draper", "HD 76050"},
        {"Hipparcos Number", "HIP 43676"},
        {"Smithsonian Astrophysical Observation", "SAO 117242"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.46644075),
        dec: Angle.Degrees(+01.82443342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129584"},
        {"Hipparcos Number", "HIP 71973"},
        {"Smithsonian Astrophysical Observation", "SAO 120622"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.80455681),
        dec: Angle.Degrees(+01.82476239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104101"},
        {"Hipparcos Number", "HIP 58466"},
        {"Smithsonian Astrophysical Observation", "SAO 119150"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.84981533),
        dec: Angle.Degrees(+01.82681899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85218"},
        {"Hipparcos Number", "HIP 48276"},
        {"Geneva Identification System", "GEN# +1.00085218"},
        {"Smithsonian Astrophysical Observation", "SAO 117938"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.62910415),
        dec: Angle.Degrees(+01.82761173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205358"},
        {"Hipparcos Number", "HIP 106544"},
        {"Smithsonian Astrophysical Observation", "SAO 126901"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.67817151),
        dec: Angle.Degrees(+01.82918895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288080"},
        {"Hipparcos Number", "HIP 26305"},
        {"Smithsonian Astrophysical Observation", "SAO 112946"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.02682037),
        dec: Angle.Degrees(+01.82926423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72361"},
        {"Smithsonian Astrophysical Observation", "SAO 120668"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.94453472),
        dec: Angle.Degrees(+01.83118776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198025"},
        {"Hipparcos Number", "HIP 102601"},
        {"Smithsonian Astrophysical Observation", "SAO 126215"},
        {"Wilson Evans Batten Catalogue", "WEB 18589"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.89414578),
        dec: Angle.Degrees(+01.83190078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11064"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.59919582),
        dec: Angle.Degrees(+01.83215816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165045"},
        {"Hipparcos Number", "HIP 88481"},
        {"Fundamental Katalog 5th Edition", "FK5 5590"},
        {"Geneva Identification System", "GEN# +1.00165045"},
        {"Smithsonian Astrophysical Observation", "SAO 123074"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.00758163),
        dec: Angle.Degrees(+01.83248324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182533"},
        {"Hipparcos Number", "HIP 95451"},
        {"Smithsonian Astrophysical Observation", "SAO 124598"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.24973586),
        dec: Angle.Degrees(+01.83262198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54081"},
        {"Smithsonian Astrophysical Observation", "SAO 118639"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.99968911),
        dec: Angle.Degrees(+01.83286996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182519"},
        {"Hipparcos Number", "HIP 95443"},
        {"Smithsonian Astrophysical Observation", "SAO 124596"},
        {"Wilson Evans Batten Catalogue", "WEB 16686"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.22294601),
        dec: Angle.Degrees(+01.83481084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83408"},
        {"Hipparcos Number", "HIP 47292"},
        {"Geneva Identification System", "GEN# +1.00083408"},
        {"Smithsonian Astrophysical Observation", "SAO 117818"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.57108196),
        dec: Angle.Degrees(+01.83527227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -178.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287574"},
        {"Hipparcos Number", "HIP 24248"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.07980483),
        dec: Angle.Degrees(+01.83681854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28271",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4555 A"},
        {"Henry Draper", "HD 40372"},
        {"Hipparcos Number", "HIP 28271"},
        {"Celescope Catalog", "CEL 1049"},
        {"Geneva Identification System", "GEN# +1.00040372A"},
        {"Renson", "Renson 10770"},
        {"Smithsonian Astrophysical Observation", "SAO 113315"},
        {"Wilson Evans Batten Catalogue", "WEB 5528"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.60182982),
        dec: Angle.Degrees(+01.83712742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71041",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9293 AB"},
        {"Henry Draper", "HD 127508"},
        {"Hipparcos Number", "HIP 71041"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.93333486),
        dec: Angle.Degrees(+01.83845110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196160"},
        {"Hipparcos Number", "HIP 101605"},
        {"Smithsonian Astrophysical Observation", "SAO 125994"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.87211986),
        dec: Angle.Degrees(+01.83889290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108657"},
        {"Smithsonian Astrophysical Observation", "SAO 127230"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.17655388),
        dec: Angle.Degrees(+01.84113133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6013",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1042 AB"},
        {"Henry Draper", "HD 7763"},
        {"Hipparcos Number", "HIP 6013"},
        {"Smithsonian Astrophysical Observation", "SAO 109787"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.33123456),
        dec: Angle.Degrees(+01.84127914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93046"},
        {"Hipparcos Number", "HIP 52563"},
        {"Geneva Identification System", "GEN# +1.00093046"},
        {"Smithsonian Astrophysical Observation", "SAO 118468"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.19674348),
        dec: Angle.Degrees(+01.84141115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137898"},
        {"Hipparcos Number", "HIP 75761"},
        {"Fundamental Katalog 5th Edition", "FK5 3221"},
        {"Geneva Identification System", "GEN# +1.00137898"},
        {"Smithsonian Astrophysical Observation", "SAO 121020"},
        {"Wilson Evans Batten Catalogue", "WEB 12898"},
    },
    visualMagnitude: 5.15,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.15952692),
        dec: Angle.Degrees(+01.84216258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216565"},
        {"Hipparcos Number", "HIP 113064"},
        {"Smithsonian Astrophysical Observation", "SAO 127826"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.46728513),
        dec: Angle.Degrees(+01.84318202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138041"},
        {"Hipparcos Number", "HIP 75835"},
        {"Smithsonian Astrophysical Observation", "SAO 121028"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.36148641),
        dec: Angle.Degrees(+01.84364096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31541"},
        {"Hipparcos Number", "HIP 22987"},
        {"Smithsonian Astrophysical Observation", "SAO 112242"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.19232328),
        dec: Angle.Degrees(+01.84578831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49020"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.01533670),
        dec: Angle.Degrees(+01.84597888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35439"},
        {"Hipparcos Number", "HIP 25302"},
        {"Celescope Catalog", "CEL 681"},
        {"Fundamental Katalog 5th Edition", "FK5 2406"},
        {"Geneva Identification System", "GEN# +1.00035439"},
        {"Smithsonian Astrophysical Observation", "SAO 112734"},
        {"Wilson Evans Batten Catalogue", "WEB 4910"},
    },
    visualMagnitude: 4.89,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.18677704),
        dec: Angle.Degrees(+01.84644611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145052"},
        {"Hipparcos Number", "HIP 79106"},
        {"Smithsonian Astrophysical Observation", "SAO 121387"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.20182433),
        dec: Angle.Degrees(+01.84648479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12549"},
        {"Hipparcos Number", "HIP 9579"},
        {"Smithsonian Astrophysical Observation", "SAO 110303"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.76991456),
        dec: Angle.Degrees(+01.84663945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171183"},
        {"Hipparcos Number", "HIP 90956"},
        {"Smithsonian Astrophysical Observation", "SAO 123628"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.31183183),
        dec: Angle.Degrees(+01.84677056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8998",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1538 AB"},
        {"Henry Draper", "HD 11803"},
        {"Hipparcos Number", "HIP 8998"},
        {"Geneva Identification System", "GEN# +1.00011803J"},
        {"Smithsonian Astrophysical Observation", "SAO 110235"},
        {"Wilson Evans Batten Catalogue", "WEB 1889"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.97391411),
        dec: Angle.Degrees(+01.84951901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25465"},
        {"Hipparcos Number", "HIP 18877"},
        {"Smithsonian Astrophysical Observation", "SAO 111575"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.70003507),
        dec: Angle.Degrees(+01.84955111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30976"},
        {"Hipparcos Number", "HIP 22640"},
        {"Geneva Identification System", "GEN# +1.00030976"},
        {"Smithsonian Astrophysical Observation", "SAO 112165"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.06251589),
        dec: Angle.Degrees(+01.84966559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1228"},
        {"Hipparcos Number", "HIP 1325"},
        {"Fundamental Katalog 5th Edition", "FK5 4029"},
        {"Geneva Identification System", "GEN# +1.00001228"},
        {"Smithsonian Astrophysical Observation", "SAO 109101"},
        {"Wilson Evans Batten Catalogue", "WEB 238"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.16425082),
        dec: Angle.Degrees(+01.85057729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140630"},
        {"Hipparcos Number", "HIP 77100"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.14677131),
        dec: Angle.Degrees(+01.85063637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32816"},
        {"Hipparcos Number", "HIP 23714"},
        {"Smithsonian Astrophysical Observation", "SAO 112414"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.47753364),
        dec: Angle.Degrees(+01.85221614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79117"},
        {"Geneva Identification System", "GEN# +9.80016031"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.23131704),
        dec: Angle.Degrees(+01.85295895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -379.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152582"},
        {"Hipparcos Number", "HIP 82689"},
        {"Smithsonian Astrophysical Observation", "SAO 121932"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.53772819),
        dec: Angle.Degrees(+01.85362451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132846"},
        {"Hipparcos Number", "HIP 73491"},
        {"Geneva Identification System", "GEN# +1.00132846"},
        {"Smithsonian Astrophysical Observation", "SAO 120795"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.29858622),
        dec: Angle.Degrees(+01.85388540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109896"},
        {"Hipparcos Number", "HIP 61658"},
        {"Fundamental Katalog 5th Edition", "FK5 3009"},
        {"Geneva Identification System", "GEN# +1.00109896"},
        {"Smithsonian Astrophysical Observation", "SAO 119508"},
        {"Wilson Evans Batten Catalogue", "WEB 10969"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.59355028),
        dec: Angle.Degrees(+01.85470456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4467 A"},
        {"Henry Draper", "HD 39400"},
        {"Hipparcos Number", "HIP 27750"},
        {"Fundamental Katalog 5th Edition", "FK5 2444"},
        {"Geneva Identification System", "GEN# +1.00039400"},
        {"Smithsonian Astrophysical Observation", "SAO 113220"},
        {"Wilson Evans Batten Catalogue", "WEB 5442"},
    },
    visualMagnitude: 4.76,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.11017813),
        dec: Angle.Degrees(+01.85515790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7794",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7794"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.07446659),
        dec: Angle.Degrees(+01.85604841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40335"},
        {"Hipparcos Number", "HIP 28255"},
        {"Smithsonian Astrophysical Observation", "SAO 113311"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.55633289),
        dec: Angle.Degrees(+01.85640691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95207"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.52537619),
        dec: Angle.Degrees(+01.85652810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209875"},
        {"Hipparcos Number", "HIP 109144"},
        {"Geneva Identification System", "GEN# +1.00209875"},
        {"Smithsonian Astrophysical Observation", "SAO 127300"},
        {"Wilson Evans Batten Catalogue", "WEB 19621"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.63738634),
        dec: Angle.Degrees(+01.85667186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 341.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37943",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6361 AB"},
        {"Henry Draper", "HD 62969"},
        {"Hipparcos Number", "HIP 37943"},
        {"Smithsonian Astrophysical Observation", "SAO 115912"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.65501322),
        dec: Angle.Degrees(+01.85775329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28322"},
        {"Hipparcos Number", "HIP 20848"},
        {"Geneva Identification System", "GEN# +1.00028322"},
        {"Smithsonian Astrophysical Observation", "SAO 111840"},
        {"Wilson Evans Batten Catalogue", "WEB 4002"},
    },
    visualMagnitude: 6.14,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.01508838),
        dec: Angle.Degrees(+01.85858198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213763"},
        {"Hipparcos Number", "HIP 111374"},
        {"Geneva Identification System", "GEN# +1.00213763"},
        {"Smithsonian Astrophysical Observation", "SAO 127601"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.44791448),
        dec: Angle.Degrees(+01.85988666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14128"},
        {"Hipparcos Number", "HIP 10664"},
        {"Geneva Identification System", "GEN# +1.00014128"},
        {"Smithsonian Astrophysical Observation", "SAO 110452"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.30617640),
        dec: Angle.Degrees(+01.86043961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199"},
        {"Hipparcos Number", "HIP 565"},
        {"Smithsonian Astrophysical Observation", "SAO 109011"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.71801703),
        dec: Angle.Degrees(+01.86101143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19121"},
        {"Hipparcos Number", "HIP 14315"},
        {"Fundamental Katalog 5th Edition", "FK5 2218"},
        {"Geneva Identification System", "GEN# +1.00019121"},
        {"Smithsonian Astrophysical Observation", "SAO 110945"},
        {"Wilson Evans Batten Catalogue", "WEB 2799"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.15854814),
        dec: Angle.Degrees(+01.86360560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82543"},
        {"Hipparcos Number", "HIP 46840"},
        {"Fundamental Katalog 5th Edition", "FK5 2758"},
        {"Geneva Identification System", "GEN# +1.00082543J"},
        {"Smithsonian Astrophysical Observation", "SAO 117757"},
        {"Wilson Evans Batten Catalogue", "WEB 8833"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.17252720),
        dec: Angle.Degrees(+01.86423899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104138",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104138"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.48598774),
        dec: Angle.Degrees(+01.86451124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44109"},
        {"Wilson Evans Batten Catalogue", "WEB 8473"},
    },
    visualMagnitude: 10.46,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.75947702),
        dec: Angle.Degrees(+01.86486588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138356"},
        {"Hipparcos Number", "HIP 76014"},
        {"Geneva Identification System", "GEN# +1.00138356"},
        {"Smithsonian Astrophysical Observation", "SAO 121041"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.88624000),
        dec: Angle.Degrees(+01.86494378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216179"},
        {"Hipparcos Number", "HIP 112811"},
        {"Cincinnati Publication", "Ci 18 2983"},
        {"Geneva Identification System", "GEN# +1.00216179"},
        {"Smithsonian Astrophysical Observation", "SAO 127795"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.69117392),
        dec: Angle.Degrees(+01.86609512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -385.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16672"},
        {"Hipparcos Number", "HIP 12473"},
        {"Geneva Identification System", "GEN# +1.00016672"},
        {"Smithsonian Astrophysical Observation", "SAO 110675"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.14002765),
        dec: Angle.Degrees(+01.86631868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80795"},
        {"Hipparcos Number", "HIP 45929"},
        {"Smithsonian Astrophysical Observation", "SAO 117621"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.47259172),
        dec: Angle.Degrees(+01.86728264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70582",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70582"},
        {"Smithsonian Astrophysical Observation", "SAO 120459"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.56546371),
        dec: Angle.Degrees(+01.86889090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99762"},
        {"Hipparcos Number", "HIP 56008"},
        {"Smithsonian Astrophysical Observation", "SAO 118882"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.16621721),
        dec: Angle.Degrees(+01.87115857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80903"},
        {"Hipparcos Number", "HIP 45967"},
        {"Geneva Identification System", "GEN# +1.00080903"},
        {"Smithsonian Astrophysical Observation", "SAO 117632"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.62101503),
        dec: Angle.Degrees(+01.87167258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88827"},
        {"Geneva Identification System", "GEN# +9.80020024"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.98628357),
        dec: Angle.Degrees(+01.87631983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195275"},
        {"Hipparcos Number", "HIP 101156"},
        {"Geneva Identification System", "GEN# +1.00195275"},
        {"Smithsonian Astrophysical Observation", "SAO 125873"},
        {"Wilson Evans Batten Catalogue", "WEB 18273"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.56336841),
        dec: Angle.Degrees(+01.87683461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13481",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13481"},
        {"Smithsonian Astrophysical Observation", "SAO 110815"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.40342327),
        dec: Angle.Degrees(+01.87765595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56303"},
        {"Hipparcos Number", "HIP 35209"},
        {"Geneva Identification System", "GEN# +1.00056303"},
        {"Smithsonian Astrophysical Observation", "SAO 115185"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.15163850),
        dec: Angle.Degrees(+01.87904933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135062"},
        {"Hipparcos Number", "HIP 74481"},
        {"Smithsonian Astrophysical Observation", "SAO 120896"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.28892522),
        dec: Angle.Degrees(+01.87996994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96362"},
        {"Hipparcos Number", "HIP 54305"},
        {"Smithsonian Astrophysical Observation", "SAO 118662"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.64662204),
        dec: Angle.Degrees(+01.88032857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83290"},
        {"Hipparcos Number", "HIP 47220"},
        {"Geneva Identification System", "GEN# +1.00083290"},
        {"Smithsonian Astrophysical Observation", "SAO 117812"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.35529700),
        dec: Angle.Degrees(+01.88085576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179125"},
        {"Hipparcos Number", "HIP 94259"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.79409032),
        dec: Angle.Degrees(+01.88455562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89608"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.29394133),
        dec: Angle.Degrees(+01.88471033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118408"},
        {"Hipparcos Number", "HIP 66399"},
        {"Smithsonian Astrophysical Observation", "SAO 120031"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.20157279),
        dec: Angle.Degrees(+01.88516968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220924"},
        {"Hipparcos Number", "HIP 115811"},
        {"Geneva Identification System", "GEN# +1.00220924"},
        {"Smithsonian Astrophysical Observation", "SAO 128194"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.93106147),
        dec: Angle.Degrees(+01.88698790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175294"},
        {"Hipparcos Number", "HIP 92807"},
        {"Geneva Identification System", "GEN# +1.00175294"},
        {"Smithsonian Astrophysical Observation", "SAO 124030"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.65175724),
        dec: Angle.Degrees(+01.88751006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13773",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2236 AB"},
        {"Henry Draper", "HD 18368"},
        {"Hipparcos Number", "HIP 13773"},
        {"Geneva Identification System", "GEN# +1.00018368J"},
        {"Smithsonian Astrophysical Observation", "SAO 110868"},
        {"Wilson Evans Batten Catalogue", "WEB 2724"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.31208922),
        dec: Angle.Degrees(+01.88757198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130109"},
        {"Hipparcos Number", "HIP 72220"},
        {"Fundamental Katalog 5th Edition", "FK5 547"},
        {"Geneva Identification System", "GEN# +1.00130109"},
        {"Renson", "Renson 37075"},
        {"Smithsonian Astrophysical Observation", "SAO 120648"},
        {"Wilson Evans Batten Catalogue", "WEB 12426"},
    },
    visualMagnitude: 3.73,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.56246594),
        dec: Angle.Degrees(+01.89293830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67547"},
        {"Hipparcos Number", "HIP 39868"},
        {"Smithsonian Astrophysical Observation", "SAO 116390"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.15841970),
        dec: Angle.Degrees(+01.89512349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124682"},
        {"Hipparcos Number", "HIP 69621"},
        {"Smithsonian Astrophysical Observation", "SAO 120367"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.74674581),
        dec: Angle.Degrees(+01.89657795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89207",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11148 AB"},
        {"Henry Draper", "HD 166823"},
        {"Hipparcos Number", "HIP 89207"},
        {"Smithsonian Astrophysical Observation", "SAO 123240"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.07568159),
        dec: Angle.Degrees(+01.89753813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175272"},
        {"Hipparcos Number", "HIP 92794"},
        {"Smithsonian Astrophysical Observation", "SAO 124028"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62745394),
        dec: Angle.Degrees(+01.89763437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53133"},
        {"Hipparcos Number", "HIP 34077"},
        {"Geneva Identification System", "GEN# +1.00053133"},
        {"Smithsonian Astrophysical Observation", "SAO 114859"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.00853485),
        dec: Angle.Degrees(+01.89794051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105639"},
        {"Hipparcos Number", "HIP 59285"},
        {"Fundamental Katalog 5th Edition", "FK5 2972"},
        {"Geneva Identification System", "GEN# +1.00105639"},
        {"Smithsonian Astrophysical Observation", "SAO 119245"},
        {"Wilson Evans Batten Catalogue", "WEB 10545"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.42202206),
        dec: Angle.Degrees(+01.89832789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29772"},
        {"Hipparcos Number", "HIP 21826"},
        {"Geneva Identification System", "GEN# +1.00029772"},
        {"Smithsonian Astrophysical Observation", "SAO 111982"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.38407674),
        dec: Angle.Degrees(+01.89961511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6509"},
        {"Smithsonian Astrophysical Observation", "SAO 109852"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.90482411),
        dec: Angle.Degrees(+01.90173771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10443"},
        {"Hipparcos Number", "HIP 7929"},
        {"Geneva Identification System", "GEN# +1.00010443"},
        {"Smithsonian Astrophysical Observation", "SAO 110075"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.48448368),
        dec: Angle.Degrees(+01.90297801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171234"},
        {"Hipparcos Number", "HIP 90985"},
        {"Geneva Identification System", "GEN# +1.00171234"},
        {"Smithsonian Astrophysical Observation", "SAO 123635"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.38224799),
        dec: Angle.Degrees(+01.90355934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207874"},
        {"Hipparcos Number", "HIP 107941"},
        {"Smithsonian Astrophysical Observation", "SAO 127122"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.02740852),
        dec: Angle.Degrees(+01.90688421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140142"},
        {"Hipparcos Number", "HIP 76886"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.49761364),
        dec: Angle.Degrees(+01.90899738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5172"},
        {"Hipparcos Number", "HIP 4203"},
        {"Smithsonian Astrophysical Observation", "SAO 109525"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.41143609),
        dec: Angle.Degrees(+01.90960774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77760"},
        {"Hipparcos Number", "HIP 44551"},
        {"Smithsonian Astrophysical Observation", "SAO 117399"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.16369618),
        dec: Angle.Degrees(+01.91029059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75996"},
        {"Hipparcos Number", "HIP 43654"},
        {"Smithsonian Astrophysical Observation", "SAO 117237"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.39205405),
        dec: Angle.Degrees(+01.91270940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45563"},
        {"Hipparcos Number", "HIP 30798"},
        {"Geneva Identification System", "GEN# +1.00045563"},
        {"Renson", "Renson 12090"},
        {"Smithsonian Astrophysical Observation", "SAO 113929"},
        {"Wilson Evans Batten Catalogue", "WEB 6141"},
    },
    visualMagnitude: 6.48,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.06987797),
        dec: Angle.Degrees(+01.91271649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59881"},
        {"Hipparcos Number", "HIP 36641"},
        {"Fundamental Katalog 5th Edition", "FK5 2587"},
        {"Geneva Identification System", "GEN# +1.00059881"},
        {"Smithsonian Astrophysical Observation", "SAO 115581"},
        {"Wilson Evans Batten Catalogue", "WEB 7286"},
    },
    visualMagnitude: 5.24,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.02479230),
        dec: Angle.Degrees(+01.91448227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13855 A"},
        {"Henry Draper", "HD 194632"},
        {"Hipparcos Number", "HIP 100831"},
        {"Smithsonian Astrophysical Observation", "SAO 125809"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.66930581),
        dec: Angle.Degrees(+01.91613355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40815"},
        {"Hipparcos Number", "HIP 28536"},
        {"Smithsonian Astrophysical Observation", "SAO 113370"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.35567668),
        dec: Angle.Degrees(+01.91627494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224277"},
        {"Hipparcos Number", "HIP 118030"},
        {"Smithsonian Astrophysical Observation", "SAO 128483"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.12772785),
        dec: Angle.Degrees(+01.91861967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165174"},
        {"Hipparcos Number", "HIP 88522"},
        {"Geneva Identification System", "GEN# +1.00165174"},
        {"Geneva Identification System 2", "GEN# +5.13590011"},
        {"Smithsonian Astrophysical Observation", "SAO 123090"},
        {"Wilson Evans Batten Catalogue", "WEB 14981"},
    },
    visualMagnitude: 6.14,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.15565500),
        dec: Angle.Degrees(+01.91900710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92858"},
        {"Hipparcos Number", "HIP 52454"},
        {"Smithsonian Astrophysical Observation", "SAO 118450"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.84472766),
        dec: Angle.Degrees(+01.91914225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54596"},
        {"Hipparcos Number", "HIP 34551"},
        {"Geneva Identification System", "GEN# +1.00054596"},
        {"Smithsonian Astrophysical Observation", "SAO 115006"},
        {"Wilson Evans Batten Catalogue", "WEB 6915"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.37407821),
        dec: Angle.Degrees(+01.92010637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73801"},
        {"Hipparcos Number", "HIP 42537"},
        {"Smithsonian Astrophysical Observation", "SAO 117010"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.07515383),
        dec: Angle.Degrees(+01.92026232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36676"},
        {"Smithsonian Astrophysical Observation", "SAO 115599"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.18425654),
        dec: Angle.Degrees(+01.92108010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25340",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4012 AB"},
        {"Henry Draper", "HD 35501"},
        {"Hipparcos Number", "HIP 25340"},
        {"Celescope Catalog", "CEL 686"},
        {"Geneva Identification System", "GEN# +1.00035501"},
        {"Smithsonian Astrophysical Observation", "SAO 112744"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.29749497),
        dec: Angle.Degrees(+01.92334294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58189"},
        {"Hipparcos Number", "HIP 35950"},
        {"Smithsonian Astrophysical Observation", "SAO 115402"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.16666791),
        dec: Angle.Degrees(+01.92422728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214315"},
        {"Hipparcos Number", "HIP 111667"},
        {"Smithsonian Astrophysical Observation", "SAO 127636"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.31926096),
        dec: Angle.Degrees(+01.92501794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218637"},
        {"Hipparcos Number", "HIP 114354"},
        {"Geneva Identification System", "GEN# +1.00218637"},
        {"Smithsonian Astrophysical Observation", "SAO 128002"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.39590404),
        dec: Angle.Degrees(+01.92632065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101113"},
        {"Hipparcos Number", "HIP 56755"},
        {"Smithsonian Astrophysical Observation", "SAO 118962"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.53919478),
        dec: Angle.Degrees(+01.92640729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61093"},
        {"Hipparcos Number", "HIP 37122"},
        {"Smithsonian Astrophysical Observation", "SAO 115719"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.42333521),
        dec: Angle.Degrees(+01.92839535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17872"},
        {"Hipparcos Number", "HIP 13386"},
        {"Smithsonian Astrophysical Observation", "SAO 110804"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.06309900),
        dec: Angle.Degrees(+01.92893523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79972"},
        {"Hipparcos Number", "HIP 45565"},
        {"Geneva Identification System", "GEN# +1.00079972"},
        {"Smithsonian Astrophysical Observation", "SAO 117564"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.30119785),
        dec: Angle.Degrees(+01.92963864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13154"},
        {"Hipparcos Number", "HIP 9986"},
        {"Smithsonian Astrophysical Observation", "SAO 110362"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.15578946),
        dec: Angle.Degrees(+01.92967978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52206"},
        {"Hipparcos Number", "HIP 33731"},
        {"Smithsonian Astrophysical Observation", "SAO 114762"},
    },
    visualMagnitude: 6.76,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.10411755),
        dec: Angle.Degrees(+01.93152066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222191"},
        {"Hipparcos Number", "HIP 116655"},
        {"Smithsonian Astrophysical Observation", "SAO 128296"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.60689137),
        dec: Angle.Degrees(+01.93592755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56681",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56681"},
        {"Smithsonian Astrophysical Observation", "SAO 118953"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.33343842),
        dec: Angle.Degrees(+01.93741722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12513"},
        {"Hipparcos Number", "HIP 9557"},
        {"Geneva Identification System", "GEN# +1.00012513"},
        {"Smithsonian Astrophysical Observation", "SAO 110299"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.69467261),
        dec: Angle.Degrees(+01.93825108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23362"},
        {"Hipparcos Number", "HIP 17473"},
        {"Smithsonian Astrophysical Observation", "SAO 111388"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.16759836),
        dec: Angle.Degrees(+01.93832547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38123",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6386 AB"},
        {"Henry Draper", "HD 63367"},
        {"Hipparcos Number", "HIP 38123"},
        {"Smithsonian Astrophysical Observation", "SAO 115964"},
    },
    visualMagnitude: 8.95,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.18510073),
        dec: Angle.Degrees(+01.93916627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2114"},
        {"Hipparcos Number", "HIP 2006"},
        {"Fundamental Katalog 5th Edition", "FK5 1010"},
        {"Geneva Identification System", "GEN# +1.00002114"},
        {"Smithsonian Astrophysical Observation", "SAO 109192"},
        {"Wilson Evans Batten Catalogue", "WEB 382"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.855,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.35090309),
        dec: Angle.Degrees(+01.93972374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188311"},
        {"Hipparcos Number", "HIP 97950"},
        {"Cincinnati Publication", "Ci 18 2595"},
        {"Geneva Identification System", "GEN# +1.00188311"},
        {"Smithsonian Astrophysical Observation", "SAO 125214"},
        {"Wilson Evans Batten Catalogue", "WEB 17236"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.60726893),
        dec: Angle.Degrees(+01.94203692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111909"},
        {"Hipparcos Number", "HIP 62835"},
        {"Geneva Identification System", "GEN# +1.00111909"},
        {"Smithsonian Astrophysical Observation", "SAO 119642"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.14188247),
        dec: Angle.Degrees(+01.94363727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188268"},
        {"Hipparcos Number", "HIP 97940"},
        {"Cincinnati Publication", "Ci 18 2594"},
        {"Geneva Identification System", "GEN# +1.00188268"},
        {"Smithsonian Astrophysical Observation", "SAO 125206"},
        {"Wilson Evans Batten Catalogue", "WEB 17231"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.56230842),
        dec: Angle.Degrees(+01.94408544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26081",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Wachmann Variable"},
        {"Common Name 2", "Wachmann's Flare Star"},
        {"Hipparcos Number", "HIP 26081"},
    },
    visualMagnitude: 11.53,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.43723230),
        dec: Angle.Degrees(+01.94577889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -241.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211212"},
        {"Hipparcos Number", "HIP 109900"},
        {"Smithsonian Astrophysical Observation", "SAO 127412"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.89212801),
        dec: Angle.Degrees(+01.94578536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125561"},
        {"Hipparcos Number", "HIP 70056"},
        {"Smithsonian Astrophysical Observation", "SAO 120404"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.04908569),
        dec: Angle.Degrees(+01.94592286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34317"},
        {"Hipparcos Number", "HIP 24607"},
        {"Geneva Identification System", "GEN# +1.00034317"},
        {"Renson", "Renson 8730"},
        {"Smithsonian Astrophysical Observation", "SAO 112588"},
        {"Wilson Evans Batten Catalogue", "WEB 4764"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.17102659),
        dec: Angle.Degrees(+01.94734447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126272"},
        {"Hipparcos Number", "HIP 70425"},
        {"Geneva Identification System", "GEN# +1.00126272"},
        {"Smithsonian Astrophysical Observation", "SAO 120438"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.11308271),
        dec: Angle.Degrees(+01.94757700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122972"},
        {"Hipparcos Number", "HIP 68799"},
        {"Smithsonian Astrophysical Observation", "SAO 120276"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.24503680),
        dec: Angle.Degrees(+01.94970841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2193"},
        {"Hipparcos Number", "HIP 2047"},
        {"Smithsonian Astrophysical Observation", "SAO 109200"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.48842118),
        dec: Angle.Degrees(+01.94986670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183324"},
        {"Hipparcos Number", "HIP 95793"},
        {"Geneva Identification System", "GEN# +1.00183324"},
        {"Smithsonian Astrophysical Observation", "SAO 124675"},
        {"Wilson Evans Batten Catalogue", "WEB 16767"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.25411887),
        dec: Angle.Degrees(+01.95052861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8060 A"},
        {"Henry Draper", "HD 96436"},
        {"Hipparcos Number", "HIP 54336"},
        {"Fundamental Katalog 5th Edition", "FK5 1287"},
        {"Geneva Identification System", "GEN# +1.00096436"},
        {"Smithsonian Astrophysical Observation", "SAO 118668"},
        {"Wilson Evans Batten Catalogue", "WEB 9813"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.72679525),
        dec: Angle.Degrees(+01.95573365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -383.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21092"},
        {"Geneva Identification System", "GEN# +6.20156283"},
    },
    visualMagnitude: 12.38,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.79766871),
        dec: Angle.Degrees(+01.95782806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11999",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11999"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.66901684),
        dec: Angle.Degrees(+01.95793456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107679"},
    },
    visualMagnitude: 10.76,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.18447413),
        dec: Angle.Degrees(+01.95942080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15328"},
        {"Hipparcos Number", "HIP 11474"},
        {"Smithsonian Astrophysical Observation", "SAO 110542"},
        {"Wilson Evans Batten Catalogue", "WEB 2396"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.99970001),
        dec: Angle.Degrees(+01.96088039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162113"},
        {"Hipparcos Number", "HIP 87224"},
        {"Geneva Identification System", "GEN# +1.00162113"},
        {"Smithsonian Astrophysical Observation", "SAO 122787"},
        {"Wilson Evans Batten Catalogue", "WEB 14717"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.32936550),
        dec: Angle.Degrees(+01.96122606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211421"},
        {"Hipparcos Number", "HIP 110008"},
        {"Smithsonian Astrophysical Observation", "SAO 127429"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.21723011),
        dec: Angle.Degrees(+01.96311611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26439"},
        {"Hipparcos Number", "HIP 19527"},
        {"Geneva Identification System", "GEN# +1.00026439"},
        {"Smithsonian Astrophysical Observation", "SAO 111644"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.75216712),
        dec: Angle.Degrees(+01.96438099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2458"},
    },
    visualMagnitude: 12.38,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.81346099),
        dec: Angle.Degrees(+01.96476050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19305"},
        {"Hipparcos Number", "HIP 14445"},
        {"Cincinnati Publication", "Ci 18 404"},
        {"Cincinnati Publication 2", "Ci 20 207"},
        {"Geneva Identification System", "GEN# +1.00019305"},
        {"Smithsonian Astrophysical Observation", "SAO 110970"},
        {"Wilson Evans Batten Catalogue", "WEB 2815"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.61045758),
        dec: Angle.Degrees(+01.96742325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 389.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -925.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24349",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3799 AB"},
        {"Hipparcos Number", "HIP 24349"},
        {"Geneva Identification System", "GEN# +1.00033883"},
        {"Smithsonian Astrophysical Observation", "SAO 112535"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.38147220),
        dec: Angle.Degrees(+01.96768435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84299"},
        {"Hipparcos Number", "HIP 47773"},
        {"Smithsonian Astrophysical Observation", "SAO 117881"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.09857261),
        dec: Angle.Degrees(+01.96803629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212715"},
        {"Hipparcos Number", "HIP 110764"},
        {"Geneva Identification System", "GEN# +1.00212715"},
        {"Smithsonian Astrophysical Observation", "SAO 127528"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.60291179),
        dec: Angle.Degrees(+01.96959608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18012"},
        {"Hipparcos Number", "HIP 13482"},
        {"Geneva Identification System", "GEN# +1.00018012"},
        {"Smithsonian Astrophysical Observation", "SAO 110816"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.40935478),
        dec: Angle.Degrees(+01.96968305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223505"},
        {"Hipparcos Number", "HIP 117529"},
        {"Smithsonian Astrophysical Observation", "SAO 128408"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.53297946),
        dec: Angle.Degrees(+01.97023826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65808"},
        {"Hipparcos Number", "HIP 39166"},
        {"Smithsonian Astrophysical Observation", "SAO 116232"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.16349621),
        dec: Angle.Degrees(+01.97396983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64275"},
        {"Hipparcos Number", "HIP 38515"},
        {"Smithsonian Astrophysical Observation", "SAO 116075"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.31435990),
        dec: Angle.Degrees(+01.97408083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189961"},
        {"Hipparcos Number", "HIP 98683"},
        {"Smithsonian Astrophysical Observation", "SAO 125378"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.65181603),
        dec: Angle.Degrees(+01.97416635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74072"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.05935456),
        dec: Angle.Degrees(+01.97544912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85750"},
        {"Geneva Identification System", "GEN# +0.00203336"},
        {"Smithsonian Astrophysical Observation", "SAO 122466"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.84689311),
        dec: Angle.Degrees(+01.97588776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16240"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.32709457),
        dec: Angle.Degrees(+01.97590323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 250.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21143"},
        {"Hipparcos Number", "HIP 15914"},
        {"Smithsonian Astrophysical Observation", "SAO 111175"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.23257192),
        dec: Angle.Degrees(+01.97629452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109871"},
        {"Hipparcos Number", "HIP 61643"},
        {"Smithsonian Astrophysical Observation", "SAO 119507"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.55427352),
        dec: Angle.Degrees(+01.97989331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166583"},
        {"Hipparcos Number", "HIP 89109"},
        {"Smithsonian Astrophysical Observation", "SAO 123223"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.80056605),
        dec: Angle.Degrees(+01.98192158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80883",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Marfik"},
        {"Aitken", "ADS 10087 AB"},
        {"Henry Draper", "HD 148857"},
        {"Hipparcos Number", "HIP 80883"},
        {"Geneva Identification System", "GEN# +1.00148857J"},
        {"Smithsonian Astrophysical Observation", "SAO 121658"},
        {"Wilson Evans Batten Catalogue", "WEB 13678"},
    },
    visualMagnitude: 3.82,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.72850509),
        dec: Angle.Degrees(+01.98410056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40297",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6671 AB"},
        {"Henry Draper", "HD 68706"},
        {"Hipparcos Number", "HIP 40297"},
        {"Smithsonian Astrophysical Observation", "SAO 116502"},
        {"Wilson Evans Batten Catalogue", "WEB 7859"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.43964997),
        dec: Angle.Degrees(+01.98570792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58052"},
        {"Hipparcos Number", "HIP 35897"},
        {"Smithsonian Astrophysical Observation", "SAO 115387"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.00580452),
        dec: Angle.Degrees(+01.98705921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37369"},
        {"Hipparcos Number", "HIP 26512"},
        {"Geneva Identification System", "GEN# +1.00037369"},
        {"Smithsonian Astrophysical Observation", "SAO 112987"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.56728170),
        dec: Angle.Degrees(+01.98784623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193326"},
        {"Hipparcos Number", "HIP 100228"},
        {"Geneva Identification System", "GEN# +1.00193326"},
        {"Smithsonian Astrophysical Observation", "SAO 125684"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.91489333),
        dec: Angle.Degrees(+01.99345171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116012"},
        {"Smithsonian Astrophysical Observation", "SAO 128212"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.58438928),
        dec: Angle.Degrees(+01.99348613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6734"},
        {"Hipparcos Number", "HIP 5315"},
        {"Cincinnati Publication", "Ci 20 81"},
        {"Geneva Identification System", "GEN# +1.00006734"},
        {"Smithsonian Astrophysical Observation", "SAO 109694"},
        {"Wilson Evans Batten Catalogue", "WEB 1143"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.847,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.99825172),
        dec: Angle.Degrees(+01.99409389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -432.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166073"},
        {"Hipparcos Number", "HIP 88898"},
        {"Geneva Identification System", "GEN# +1.00166073"},
        {"Smithsonian Astrophysical Observation", "SAO 123172"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.21853911),
        dec: Angle.Degrees(+01.99553600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67394"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.18481056),
        dec: Angle.Degrees(+02.00407568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136756"},
        {"Hipparcos Number", "HIP 75222"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.57806536),
        dec: Angle.Degrees(+02.00685436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161150"},
        {"Hipparcos Number", "HIP 86771"},
        {"Smithsonian Astrophysical Observation", "SAO 122673"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.96061467),
        dec: Angle.Degrees(+02.00819631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289173"},
        {"Hipparcos Number", "HIP 32661"},
        {"Smithsonian Astrophysical Observation", "SAO 114456"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.19427875),
        dec: Angle.Degrees(+02.00949588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218967"},
        {"Hipparcos Number", "HIP 114558"},
        {"Smithsonian Astrophysical Observation", "SAO 128029"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.07926009),
        dec: Angle.Degrees(+02.00961094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98118"},
        {"Hipparcos Number", "HIP 55137"},
        {"Fundamental Katalog 5th Edition", "FK5 2902"},
        {"Geneva Identification System", "GEN# +1.00098118"},
        {"Smithsonian Astrophysical Observation", "SAO 118764"},
        {"Wilson Evans Batten Catalogue", "WEB 9940"},
    },
    visualMagnitude: 5.18,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.32236746),
        dec: Angle.Degrees(+02.01090315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183793"},
        {"Hipparcos Number", "HIP 95987"},
        {"Smithsonian Astrophysical Observation", "SAO 124718"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.77171292),
        dec: Angle.Degrees(+02.01175831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39653",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6584 AB"},
        {"Hipparcos Number", "HIP 39653"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.56288434),
        dec: Angle.Degrees(+02.01299109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102431"},
        {"Hipparcos Number", "HIP 57525"},
        {"Smithsonian Astrophysical Observation", "SAO 119054"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.85710820),
        dec: Angle.Degrees(+02.01325781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131179"},
        {"Hipparcos Number", "HIP 72703"},
        {"Geneva Identification System", "GEN# +1.00131179"},
        {"Smithsonian Astrophysical Observation", "SAO 120701"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.97252408),
        dec: Angle.Degrees(+02.01476841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2680"},
    },
    visualMagnitude: 11.25,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.49037289),
        dec: Angle.Degrees(+02.01513254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7736"},
        {"Hipparcos Number", "HIP 6000"},
        {"Geneva Identification System", "GEN# +1.00007736"},
        {"Smithsonian Astrophysical Observation", "SAO 109783"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.29078992),
        dec: Angle.Degrees(+02.01527123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46138"},
        {"Hipparcos Number", "HIP 31115"},
        {"Smithsonian Astrophysical Observation", "SAO 114007"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.93692588),
        dec: Angle.Degrees(+02.01637536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133601"},
        {"Hipparcos Number", "HIP 73821"},
        {"Smithsonian Astrophysical Observation", "SAO 120829"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.32058214),
        dec: Angle.Degrees(+02.01691898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101802"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45815004),
        dec: Angle.Degrees(+02.01755193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18216"},
        {"Hipparcos Number", "HIP 13629"},
        {"Geneva Identification System", "GEN# +1.00018216"},
        {"Smithsonian Astrophysical Observation", "SAO 110843"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.88148759),
        dec: Angle.Degrees(+02.01829998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99872"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.93242704),
        dec: Angle.Degrees(+02.01927620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90331",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90331"},
        {"Geneva Identification System", "GEN# +0.00103669"},
        {"Smithsonian Astrophysical Observation", "SAO 123464"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.45902043),
        dec: Angle.Degrees(+02.02163194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129827"},
        {"Hipparcos Number", "HIP 72083"},
        {"Smithsonian Astrophysical Observation", "SAO 120633"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.18970281),
        dec: Angle.Degrees(+02.02463100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39118"},
        {"Henry Draper 2", "HD 39119"},
        {"Hipparcos Number", "HIP 27588"},
        {"Geneva Identification System", "GEN# +1.00039118"},
        {"Smithsonian Astrophysical Observation", "SAO 113198"},
        {"Wilson Evans Batten Catalogue", "WEB 5416"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.62510583),
        dec: Angle.Degrees(+02.02471682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128681"},
        {"Hipparcos Number", "HIP 71575"},
        {"Smithsonian Astrophysical Observation", "SAO 120580"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.56617268),
        dec: Angle.Degrees(+02.02627182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105472",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14901 A"},
        {"Henry Draper", "HD 203383"},
        {"Hipparcos Number", "HIP 105472"},
        {"Smithsonian Astrophysical Observation", "SAO 126730"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.44829816),
        dec: Angle.Degrees(+02.02735158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160315"},
        {"Hipparcos Number", "HIP 86391"},
        {"Geneva Identification System", "GEN# +1.00160315"},
        {"Smithsonian Astrophysical Observation", "SAO 122607"},
        {"Wilson Evans Batten Catalogue", "WEB 14576"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.78532668),
        dec: Angle.Degrees(+02.02810485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91628"},
        {"Smithsonian Astrophysical Observation", "SAO 123807"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.30324559),
        dec: Angle.Degrees(+02.02963800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22270"},
        {"Hipparcos Number", "HIP 16733"},
        {"Smithsonian Astrophysical Observation", "SAO 111277"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.81931209),
        dec: Angle.Degrees(+02.03007286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74700"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.99247015),
        dec: Angle.Degrees(+02.03009866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180782"},
        {"Hipparcos Number", "HIP 94833"},
        {"Geneva Identification System", "GEN# +1.00180782"},
        {"Smithsonian Astrophysical Observation", "SAO 124478"},
        {"Wilson Evans Batten Catalogue", "WEB 16551"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.45076722),
        dec: Angle.Degrees(+02.03179581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176651"},
        {"Hipparcos Number", "HIP 93385"},
        {"Smithsonian Astrophysical Observation", "SAO 124157"},
        {"Wilson Evans Batten Catalogue", "WEB 16194"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.30535614),
        dec: Angle.Degrees(+02.03318554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149755"},
        {"Hipparcos Number", "HIP 81331"},
        {"Fundamental Katalog 5th Edition", "FK5 5468"},
        {"Smithsonian Astrophysical Observation", "SAO 121724"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.16154432),
        dec: Angle.Degrees(+02.03319691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105475",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14901 B"},
        {"Hipparcos Number", "HIP 105475"},
        {"Smithsonian Astrophysical Observation", "SAO 126732"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.45042850),
        dec: Angle.Degrees(+02.03327933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21244"},
        {"Hipparcos Number", "HIP 15977"},
        {"Smithsonian Astrophysical Observation", "SAO 111182"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.43325300),
        dec: Angle.Degrees(+02.03363657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72330",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9384 AB"},
        {"Henry Draper", "HD 130321"},
        {"Hipparcos Number", "HIP 72330"},
        {"Smithsonian Astrophysical Observation", "SAO 120667"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.85685483),
        dec: Angle.Degrees(+02.03580545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88047",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10945 AB"},
        {"Henry Draper", "HD 164013"},
        {"Hipparcos Number", "HIP 88047"},
        {"Smithsonian Astrophysical Observation", "SAO 122978"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.75680388),
        dec: Angle.Degrees(+02.03783285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213273"},
        {"Hipparcos Number", "HIP 111090"},
        {"Geneva Identification System", "GEN# +1.00213273"},
        {"Smithsonian Astrophysical Observation", "SAO 127558"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.58743725),
        dec: Angle.Degrees(+02.04189512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108228"},
        {"Hipparcos Number", "HIP 60667"},
        {"Smithsonian Astrophysical Observation", "SAO 119392"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.50362214),
        dec: Angle.Degrees(+02.04199681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50819"},
        {"Hipparcos Number", "HIP 33242"},
        {"Smithsonian Astrophysical Observation", "SAO 114610"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.74131338),
        dec: Angle.Degrees(+02.04285782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63316"},
        {"Hipparcos Number", "HIP 38099"},
        {"Smithsonian Astrophysical Observation", "SAO 115959"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.11558337),
        dec: Angle.Degrees(+02.04296187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105792",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14960 AB"},
        {"Aitken 2", "ADS 14960"},
        {"Henry Draper", "HD 203993"},
        {"Hipparcos Number", "HIP 105792"},
        {"Geneva Identification System", "GEN# +1.00203993J"},
        {"Geneva Identification System 2", "GEN# +1.00203993C"},
        {"Renson", "Renson 56800"},
        {"Smithsonian Astrophysical Observation", "SAO 126787"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.37823530),
        dec: Angle.Degrees(+02.04305831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31453"},
        {"Hipparcos Number", "HIP 22941"},
        {"Geneva Identification System", "GEN# +1.00031453"},
        {"Smithsonian Astrophysical Observation", "SAO 112231"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.04551626),
        dec: Angle.Degrees(+02.04353363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32320"},
        {"Hipparcos Number", "HIP 23448"},
        {"Smithsonian Astrophysical Observation", "SAO 112351"},
    },
    visualMagnitude: 8.02,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.60916355),
        dec: Angle.Degrees(+02.04802521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73019"},
        {"Hipparcos Number", "HIP 42186"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.02331540),
        dec: Angle.Degrees(+02.04877249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72546"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.47658038),
        dec: Angle.Degrees(+02.04932079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60936"},
    },
    visualMagnitude: 12.88,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.27791820),
        dec: Angle.Degrees(+02.05238781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4086"},
        {"Hipparcos Number", "HIP 3399"},
        {"Geneva Identification System", "GEN# +1.00004086"},
        {"Smithsonian Astrophysical Observation", "SAO 109406"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.82269972),
        dec: Angle.Degrees(+02.05362855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2412"},
        {"Hipparcos Number", "HIP 2212"},
        {"Smithsonian Astrophysical Observation", "SAO 109222"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.98942616),
        dec: Angle.Degrees(+02.05375139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160314"},
        {"Hipparcos Number", "HIP 86379"},
        {"Geneva Identification System", "GEN# +1.00160314"},
        {"Smithsonian Astrophysical Observation", "SAO 122605"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.76880446),
        dec: Angle.Degrees(+02.05423488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 633"},
        {"Hipparcos Number", "HIP 870"},
        {"Geneva Identification System", "GEN# +1.00000633"},
        {"Smithsonian Astrophysical Observation", "SAO 109048"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.66971240),
        dec: Angle.Degrees(+02.05549803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95672"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)27, 36.3200),
        dec: Angle.DegreesMinutesSeconds((int)+02, (int)03, 21.000)
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
    primaryId: "HIP 44424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77519"},
        {"Hipparcos Number", "HIP 44424"},
        {"Geneva Identification System", "GEN# +1.00077519"},
        {"Smithsonian Astrophysical Observation", "SAO 117373"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.77576132),
        dec: Angle.Degrees(+02.05688403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85675"},
        {"Hipparcos Number", "HIP 48503"},
        {"Geneva Identification System", "GEN# +1.00085675"},
        {"Wilson Evans Batten Catalogue", "WEB 9038"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.36837862),
        dec: Angle.Degrees(+02.05737585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62833"},
        {"Hipparcos Number", "HIP 37897"},
        {"Smithsonian Astrophysical Observation", "SAO 115899"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.50573120),
        dec: Angle.Degrees(+02.05844879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149824"},
        {"Hipparcos Number", "HIP 81372"},
        {"Smithsonian Astrophysical Observation", "SAO 121732"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.27977484),
        dec: Angle.Degrees(+02.05893445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53464"},
        {"Geneva Identification System", "GEN# +0.00202370"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.05372289),
        dec: Angle.Degrees(+02.05960720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17192"},
        {"Smithsonian Astrophysical Observation", "SAO 111346"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.22781011),
        dec: Angle.Degrees(+02.06001536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173370"},
        {"Hipparcos Number", "HIP 91975"},
        {"Geneva Identification System", "GEN# +1.00173370"},
        {"Smithsonian Astrophysical Observation", "SAO 123879"},
        {"Wilson Evans Batten Catalogue", "WEB 15840"},
    },
    visualMagnitude: 5.02,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.20805403),
        dec: Angle.Degrees(+02.06007487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54675"},
        {"Smithsonian Astrophysical Observation", "SAO 118711"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.88070233),
        dec: Angle.Degrees(+02.06157667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150651"},
        {"Hipparcos Number", "HIP 81794"},
        {"Smithsonian Astrophysical Observation", "SAO 121796"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.59321224),
        dec: Angle.Degrees(+02.06333413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97815"},
        {"Hipparcos Number", "HIP 54961"},
        {"Smithsonian Astrophysical Observation", "SAO 118746"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.82455445),
        dec: Angle.Degrees(+02.06372313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143631"},
        {"Hipparcos Number", "HIP 78498"},
        {"Smithsonian Astrophysical Observation", "SAO 121317"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.36931359),
        dec: Angle.Degrees(+02.06429765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32262"},
        {"Hipparcos Number", "HIP 23417"},
        {"Renson", "Renson 8218"},
        {"Smithsonian Astrophysical Observation", "SAO 112339"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.49330034),
        dec: Angle.Degrees(+02.06434257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82162",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10207 A"},
        {"Henry Draper", "HD 151431"},
        {"Hipparcos Number", "HIP 82162"},
        {"Fundamental Katalog 5th Edition", "FK5 1436"},
        {"Geneva Identification System", "GEN# +1.00151431A"},
        {"Smithsonian Astrophysical Observation", "SAO 121859"},
        {"Wilson Evans Batten Catalogue", "WEB 13876"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.79066579),
        dec: Angle.Degrees(+02.06456336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117799"},
        {"Hipparcos Number", "HIP 66071"},
        {"Smithsonian Astrophysical Observation", "SAO 119991"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.17375256),
        dec: Angle.Degrees(+02.06534882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40259"},
        {"Hipparcos Number", "HIP 28224"},
        {"Geneva Identification System", "GEN# +1.00040259"},
        {"Smithsonian Astrophysical Observation", "SAO 113304"},
        {"Wilson Evans Batten Catalogue", "WEB 5523"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.45288107),
        dec: Angle.Degrees(+02.06548738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123157"},
        {"Hipparcos Number", "HIP 68850"},
        {"Smithsonian Astrophysical Observation", "SAO 120283"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.48022782),
        dec: Angle.Degrees(+02.06713561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38634"},
        {"Hipparcos Number", "HIP 27324"},
        {"Geneva Identification System", "GEN# +1.00038634"},
        {"Smithsonian Astrophysical Observation", "SAO 113138"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.82648024),
        dec: Angle.Degrees(+02.06741443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35716"},
        {"Hipparcos Number", "HIP 25469"},
        {"Fundamental Katalog 5th Edition", "FK5 4500"},
        {"Geneva Identification System", "GEN# +1.00035716"},
        {"Smithsonian Astrophysical Observation", "SAO 112774"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.70044328),
        dec: Angle.Degrees(+02.06829350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37022"},
    },
    visualMagnitude: 10.43,
    bvColour: 2.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.13195618),
        dec: Angle.Degrees(+02.07019055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288174"},
        {"Hipparcos Number", "HIP 26695"},
        {"Smithsonian Astrophysical Observation", "SAO 113025"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.10158913),
        dec: Angle.Degrees(+02.07224830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29463"},
        {"Hipparcos Number", "HIP 21623"},
        {"Smithsonian Astrophysical Observation", "SAO 111947"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.63475661),
        dec: Angle.Degrees(+02.07234638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76767"},
        {"Hipparcos Number", "HIP 44057"},
        {"Smithsonian Astrophysical Observation", "SAO 117313"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.58086439),
        dec: Angle.Degrees(+02.07286619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116450"},
        {"Smithsonian Astrophysical Observation", "SAO 128273"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.94268694),
        dec: Angle.Degrees(+02.07455732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55978"},
        {"Hipparcos Number", "HIP 35087"},
        {"Smithsonian Astrophysical Observation", "SAO 115152"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.84455641),
        dec: Angle.Degrees(+02.07461446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163346"},
        {"Hipparcos Number", "HIP 87761"},
        {"Geneva Identification System", "GEN# +1.00163346"},
        {"Smithsonian Astrophysical Observation", "SAO 122922"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.90627929),
        dec: Angle.Degrees(+02.07492314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31723"},
        {"Hipparcos Number", "HIP 23111"},
        {"Smithsonian Astrophysical Observation", "SAO 112279"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.59575451),
        dec: Angle.Degrees(+02.07507323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28191"},
        {"Hipparcos Number", "HIP 20771"},
        {"Geneva Identification System", "GEN# +1.00028191"},
        {"Smithsonian Astrophysical Observation", "SAO 111827"},
        {"Wilson Evans Batten Catalogue", "WEB 3985"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.75273055),
        dec: Angle.Degrees(+02.07955980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21756"},
        {"Hipparcos Number", "HIP 16334"},
        {"Smithsonian Astrophysical Observation", "SAO 111229"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.64316947),
        dec: Angle.Degrees(+02.07979363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162340"},
        {"Hipparcos Number", "HIP 87318"},
        {"Smithsonian Astrophysical Observation", "SAO 122814"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.63119139),
        dec: Angle.Degrees(+02.07982145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35298"},
        {"Hipparcos Number", "HIP 25235"},
        {"Celescope Catalog", "CEL 671"},
        {"Geneva Identification System", "GEN# +1.00035298"},
        {"Renson", "Renson 9020"},
        {"Smithsonian Astrophysical Observation", "SAO 112714"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.95982552),
        dec: Angle.Degrees(+02.08217304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157936"},
        {"Hipparcos Number", "HIP 85325"},
        {"Geneva Identification System", "GEN# +1.00157936"},
        {"Smithsonian Astrophysical Observation", "SAO 122379"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.55194664),
        dec: Angle.Degrees(+02.08271686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79578"},
        {"Hipparcos Number", "HIP 45404"},
        {"Smithsonian Astrophysical Observation", "SAO 117537"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.78835227),
        dec: Angle.Degrees(+02.08363367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81022",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Rosaliadecastro"},
        {"Henry Draper", "HD 149143"},
        {"Hipparcos Number", "HIP 81022"},
        {"Geneva Identification System", "GEN# +1.00149143"},
        {"Smithsonian Astrophysical Observation", "SAO 121678"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.21273185),
        dec: Angle.Degrees(+02.08503855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97916"},
        {"Hipparcos Number", "HIP 55022"},
        {"Geneva Identification System", "GEN# +1.00097916"},
        {"Smithsonian Astrophysical Observation", "SAO 118757"},
        {"Wilson Evans Batten Catalogue", "WEB 9926"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97545099),
        dec: Angle.Degrees(+02.08671111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 208.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116160"},
        {"Hipparcos Number", "HIP 65198"},
        {"Fundamental Katalog 5th Edition", "FK5 3067"},
        {"Geneva Identification System", "GEN# +1.00116160"},
        {"Smithsonian Astrophysical Observation", "SAO 119899"},
        {"Wilson Evans Batten Catalogue", "WEB 11507"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.42366137),
        dec: Angle.Degrees(+02.08737060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202952"},
        {"Hipparcos Number", "HIP 105253"},
        {"Smithsonian Astrophysical Observation", "SAO 126704"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.79051288),
        dec: Angle.Degrees(+02.08763579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112202"},
        {"Smithsonian Astrophysical Observation", "SAO 127713"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.86939305),
        dec: Angle.Degrees(+02.08870599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24585"},
        {"Hipparcos Number", "HIP 18292"},
        {"Geneva Identification System", "GEN# +1.00024585"},
        {"Smithsonian Astrophysical Observation", "SAO 111497"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.67700615),
        dec: Angle.Degrees(+02.08993379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223855"},
        {"Hipparcos Number", "HIP 117774"},
        {"Geneva Identification System", "GEN# +1.00223855"},
        {"Smithsonian Astrophysical Observation", "SAO 128436"},
        {"Wilson Evans Batten Catalogue", "WEB 20725"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.26978730),
        dec: Angle.Degrees(+02.09065153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133165"},
        {"Hipparcos Number", "HIP 73620"},
        {"Fundamental Katalog 5th Edition", "FK5 3190"},
        {"Geneva Identification System", "GEN# +1.00133165"},
        {"Smithsonian Astrophysical Observation", "SAO 120809"},
        {"Wilson Evans Batten Catalogue", "WEB 12588"},
    },
    visualMagnitude: 4.39,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.72529160),
        dec: Angle.Degrees(+02.09127129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34561"},
        {"Hipparcos Number", "HIP 24757"},
        {"Smithsonian Astrophysical Observation", "SAO 112613"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.62468366),
        dec: Angle.Degrees(+02.09137081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222936"},
        {"Hipparcos Number", "HIP 117156"},
        {"Geneva Identification System", "GEN# +1.00222936"},
        {"Smithsonian Astrophysical Observation", "SAO 128361"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.26787708),
        dec: Angle.Degrees(+02.09140298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67086"},
        {"Geneva Identification System", "GEN# +6.20030052"},
        {"Wilson Evans Batten Catalogue", "WEB 11817"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.26001352),
        dec: Angle.Degrees(+02.09210744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36549"},
        {"Hipparcos Number", "HIP 25979"},
        {"Celescope Catalog", "CEL 775"},
        {"Geneva Identification System", "GEN# +1.00036549"},
        {"Renson", "Renson 9490"},
        {"Smithsonian Astrophysical Observation", "SAO 112888"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.16451004),
        dec: Angle.Degrees(+02.09217364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5600"},
        {"Hipparcos Number", "HIP 4504"},
        {"Geneva Identification System", "GEN# +1.00005600"},
        {"Smithsonian Astrophysical Observation", "SAO 109557"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.42576755),
        dec: Angle.Degrees(+02.09380174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87227"},
        {"Hipparcos Number", "HIP 49296"},
        {"Smithsonian Astrophysical Observation", "SAO 118083"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.92464306),
        dec: Angle.Degrees(+02.09445299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99166"},
        {"Hipparcos Number", "HIP 55699"},
        {"Geneva Identification System", "GEN# +1.00099166"},
        {"Smithsonian Astrophysical Observation", "SAO 118833"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.18798904),
        dec: Angle.Degrees(+02.09652830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71990"},
        {"Hipparcos Number", "HIP 41731"},
        {"Fundamental Katalog 5th Edition", "FK5 4765"},
        {"Geneva Identification System", "GEN# +1.00071990"},
        {"Smithsonian Astrophysical Observation", "SAO 116836"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.64518638),
        dec: Angle.Degrees(+02.10026657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61564"},
        {"Hipparcos Number", "HIP 37352"},
        {"Smithsonian Astrophysical Observation", "SAO 115771"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.00439030),
        dec: Angle.Degrees(+02.10029931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47241"},
        {"Hipparcos Number", "HIP 31677"},
        {"Smithsonian Astrophysical Observation", "SAO 114156"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.42439341),
        dec: Angle.Degrees(+02.10083402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221950"},
        {"Hipparcos Number", "HIP 116495"},
        {"Fundamental Katalog 5th Edition", "FK5 3895"},
        {"Geneva Identification System", "GEN# +1.00221950"},
        {"Smithsonian Astrophysical Observation", "SAO 128281"},
        {"Wilson Evans Batten Catalogue", "WEB 20574"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.09727881),
        dec: Angle.Degrees(+02.10207138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71095"},
        {"Hipparcos Number", "HIP 41299"},
        {"Fundamental Katalog 5th Edition", "FK5 2654"},
        {"Geneva Identification System", "GEN# +1.00071095"},
        {"Smithsonian Astrophysical Observation", "SAO 116747"},
        {"Wilson Evans Batten Catalogue", "WEB 7990"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.39812618),
        dec: Angle.Degrees(+02.10224935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194938"},
        {"Hipparcos Number", "HIP 100962"},
        {"Smithsonian Astrophysical Observation", "SAO 125838"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.04773550),
        dec: Angle.Degrees(+02.10256516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55361"},
        {"Hipparcos Number", "HIP 34849"},
        {"Smithsonian Astrophysical Observation", "SAO 115080"},
    },
    visualMagnitude: 9.42,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.17856116),
        dec: Angle.Degrees(+02.10334464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86262"},
        {"Hipparcos Number", "HIP 48815"},
        {"Geneva Identification System", "GEN# +1.00086262"},
        {"Smithsonian Astrophysical Observation", "SAO 118015"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.36049368),
        dec: Angle.Degrees(+02.10694741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41403"},
        {"Hipparcos Number", "HIP 28818"},
        {"Geneva Identification System", "GEN# +1.00041403"},
        {"Renson", "Renson 11080"},
        {"Smithsonian Astrophysical Observation", "SAO 113432"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.25934896),
        dec: Angle.Degrees(+02.11031395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99890"},
        {"Geneva Identification System", "GEN# +6.20156447"},
    },
    visualMagnitude: 12.28,
    bvColour: 1.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.00371722),
        dec: Angle.Degrees(+02.11151848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94252"},
        {"Hipparcos Number", "HIP 53187"},
        {"Smithsonian Astrophysical Observation", "SAO 118558"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.18912329),
        dec: Angle.Degrees(+02.11238719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157881"},
        {"Hipparcos Number", "HIP 85295"},
        {"Cincinnati Publication", "Ci 20 1036"},
        {"Geneva Identification System", "GEN# +1.00157881"},
        {"Smithsonian Astrophysical Observation", "SAO 122374"},
        {"Wilson Evans Batten Catalogue", "WEB 14399"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.43987888),
        dec: Angle.Degrees(+02.11430212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -580.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1184.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111940"},
        {"Hipparcos Number", "HIP 62849"},
        {"Smithsonian Astrophysical Observation", "SAO 119644"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.21740136),
        dec: Angle.Degrees(+02.11697480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190498"},
        {"Hipparcos Number", "HIP 98922"},
        {"Geneva Identification System", "GEN# +1.00190498"},
        {"Smithsonian Astrophysical Observation", "SAO 125423"},
        {"Wilson Evans Batten Catalogue", "WEB 17562"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.29221034),
        dec: Angle.Degrees(+02.11905780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24456"},
        {"Hipparcos Number", "HIP 18190"},
        {"Geneva Identification System", "GEN# +1.00024456"},
        {"Smithsonian Astrophysical Observation", "SAO 111480"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.37588190),
        dec: Angle.Degrees(+02.11919135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184091"},
        {"Hipparcos Number", "HIP 96126"},
        {"Fundamental Katalog 5th Edition", "FK5 5720"},
        {"Smithsonian Astrophysical Observation", "SAO 124760"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.17598512),
        dec: Angle.Degrees(+02.11959189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18509"},
        {"Hipparcos Number", "HIP 13869"},
        {"Smithsonian Astrophysical Observation", "SAO 110878"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.65568752),
        dec: Angle.Degrees(+02.12061924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173328"},
        {"Hipparcos Number", "HIP 91952"},
        {"Smithsonian Astrophysical Observation", "SAO 123875"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.15704770),
        dec: Angle.Degrees(+02.12095842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155563"},
        {"Hipparcos Number", "HIP 84163"},
        {"Smithsonian Astrophysical Observation", "SAO 122171"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09127464),
        dec: Angle.Degrees(+02.12399889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287516"},
        {"Hipparcos Number", "HIP 23948"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.20344743),
        dec: Angle.Degrees(+02.12555153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218527"},
        {"Hipparcos Number", "HIP 114273"},
        {"Fundamental Katalog 5th Edition", "FK5 3854"},
        {"Geneva Identification System", "GEN# +1.00218527"},
        {"Smithsonian Astrophysical Observation", "SAO 127993"},
        {"Wilson Evans Batten Catalogue", "WEB 20292"},
    },
    visualMagnitude: 5.42,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.17017174),
        dec: Angle.Degrees(+02.12761798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29529"},
        {"Hipparcos Number", "HIP 21674"},
        {"Geneva Identification System", "GEN# +1.00029529"},
        {"Smithsonian Astrophysical Observation", "SAO 111956"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.79033335),
        dec: Angle.Degrees(+02.12939845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8827"},
        {"Hipparcos Number", "HIP 6777"},
        {"Smithsonian Astrophysical Observation", "SAO 109897"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.78242604),
        dec: Angle.Degrees(+02.12945260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16608"},
        {"Hipparcos Number", "HIP 12408"},
        {"Geneva Identification System", "GEN# +1.00016608"},
        {"Smithsonian Astrophysical Observation", "SAO 110669"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.94298343),
        dec: Angle.Degrees(+02.13034438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 223",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9 AB"},
        {"Henry Draper", "HD 225028"},
        {"Hipparcos Number", "HIP 223"},
        {"Smithsonian Astrophysical Observation", "SAO 108983"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.69641117),
        dec: Angle.Degrees(+02.13037640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195617"},
        {"Hipparcos Number", "HIP 101339"},
        {"Smithsonian Astrophysical Observation", "SAO 125911"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.08498217),
        dec: Angle.Degrees(+02.13280461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11815"},
        {"Hipparcos Number", "HIP 9008"},
        {"Smithsonian Astrophysical Observation", "SAO 110236"},
    },
    visualMagnitude: 10.14,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.98676631),
        dec: Angle.Degrees(+02.13564229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37798"},
        {"Wilson Evans Batten Catalogue", "WEB 7467"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.25476091),
        dec: Angle.Degrees(+02.13787935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43266"},
        {"Hipparcos Number", "HIP 29709"},
        {"Smithsonian Astrophysical Observation", "SAO 113647"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.87075650),
        dec: Angle.Degrees(+02.13818317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45653"},
        {"Hipparcos Number", "HIP 30872"},
        {"Smithsonian Astrophysical Observation", "SAO 113936"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.21525737),
        dec: Angle.Degrees(+02.13903446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49990"},
        {"Hipparcos Number", "HIP 32898"},
        {"Smithsonian Astrophysical Observation", "SAO 114511"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.81674244),
        dec: Angle.Degrees(+02.13906917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206101"},
        {"Hipparcos Number", "HIP 106958"},
        {"Smithsonian Astrophysical Observation", "SAO 126967"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.94011435),
        dec: Angle.Degrees(+02.13919885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29021",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4713 B"},
        {"Hipparcos Number", "HIP 29021"},
    },
    visualMagnitude: 10.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.85556662),
        dec: Angle.Degrees(+02.13943822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156860"},
        {"Hipparcos Number", "HIP 84780"},
        {"Geneva Identification System", "GEN# +1.00156860"},
        {"Smithsonian Astrophysical Observation", "SAO 122279"},
        {"Wilson Evans Batten Catalogue", "WEB 14313"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.94370698),
        dec: Angle.Degrees(+02.13948284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73557"},
        {"Hipparcos Number", "HIP 42426"},
        {"Smithsonian Astrophysical Observation", "SAO 116991"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.77260110),
        dec: Angle.Degrees(+02.14193209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29020",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4713 A"},
        {"Henry Draper", "HD 41809"},
        {"Hipparcos Number", "HIP 29020"},
        {"Geneva Identification System", "GEN# +1.00041809"},
        {"Smithsonian Astrophysical Observation", "SAO 113477"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.85316391),
        dec: Angle.Degrees(+02.14209898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36165"},
        {"Hipparcos Number", "HIP 25752"},
        {"Celescope Catalog", "CEL 738"},
        {"Geneva Identification System", "GEN# +1.00036165"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.48148247),
        dec: Angle.Degrees(+02.14216598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142421"},
        {"Hipparcos Number", "HIP 77897"},
        {"Smithsonian Astrophysical Observation", "SAO 121247"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.61408448),
        dec: Angle.Degrees(+02.14251150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57631"},
        {"Hipparcos Number", "HIP 35724"},
        {"Smithsonian Astrophysical Observation", "SAO 115338"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.54910270),
        dec: Angle.Degrees(+02.14298208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196757"},
        {"Hipparcos Number", "HIP 101926"},
        {"Smithsonian Astrophysical Observation", "SAO 126061"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.82498113),
        dec: Angle.Degrees(+02.14353904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39715"},
        {"Hipparcos Number", "HIP 27918"},
        {"Geneva Identification System", "GEN# +1.00039715"},
        {"Wilson Evans Batten Catalogue", "WEB 5468"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.61887783),
        dec: Angle.Degrees(+02.14380286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -646.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218612"},
        {"Hipparcos Number", "HIP 114335"},
        {"Smithsonian Astrophysical Observation", "SAO 127999"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.34381075),
        dec: Angle.Degrees(+02.14435199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222845"},
        {"Hipparcos Number", "HIP 117084"},
        {"Smithsonian Astrophysical Observation", "SAO 128353"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.03954116),
        dec: Angle.Degrees(+02.14605074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91011"},
        {"Hipparcos Number", "HIP 51451"},
        {"Geneva Identification System", "GEN# +1.00091011"},
        {"Smithsonian Astrophysical Observation", "SAO 118341"},
        {"Wilson Evans Batten Catalogue", "WEB 9392"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.62900136),
        dec: Angle.Degrees(+02.15029644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70458"},
        {"Hipparcos Number", "HIP 41012"},
        {"Smithsonian Astrophysical Observation", "SAO 116680"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.54796500),
        dec: Angle.Degrees(+02.15145637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118981"},
        {"Hipparcos Number", "HIP 66708"},
        {"Cincinnati Publication", "Ci 18 1773"},
        {"Geneva Identification System", "GEN# +1.00118981"},
        {"Smithsonian Astrophysical Observation", "SAO 120060"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.11232219),
        dec: Angle.Degrees(+02.15216138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -200.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114017"},
        {"Hipparcos Number", "HIP 64045"},
        {"Smithsonian Astrophysical Observation", "SAO 119777"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.89179790),
        dec: Angle.Degrees(+02.15286503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114191"},
        {"Hipparcos Number", "HIP 64159"},
        {"Smithsonian Astrophysical Observation", "SAO 119790"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.24742145),
        dec: Angle.Degrees(+02.15993209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151465"},
        {"Hipparcos Number", "HIP 82186"},
        {"Smithsonian Astrophysical Observation", "SAO 121862"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.85377978),
        dec: Angle.Degrees(+02.16095391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111195"},
        {"Geneva Identification System", "GEN# +9.80018054"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.90078072),
        dec: Angle.Degrees(+02.16297598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -328.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110644"},
        {"Hipparcos Number", "HIP 62100"},
        {"Smithsonian Astrophysical Observation", "SAO 119555"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.90430749),
        dec: Angle.Degrees(+02.16338362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94590"},
        {"Cincinnati Publication", "Ci 20 1140"},
    },
    visualMagnitude: 9.85,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.74481460),
        dec: Angle.Degrees(+02.16423300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 344.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 402.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36012"},
        {"Hipparcos Number", "HIP 25655"},
        {"Celescope Catalog", "CEL 727"},
        {"Geneva Identification System", "GEN# +1.00036012"},
        {"Smithsonian Astrophysical Observation", "SAO 112814"},
        {"Wilson Evans Batten Catalogue", "WEB 4976"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.20190620),
        dec: Angle.Degrees(+02.16471480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67591"},
        {"Hipparcos Number", "HIP 39882"},
        {"Fundamental Katalog 5th Edition", "FK5 4732"},
        {"Smithsonian Astrophysical Observation", "SAO 116397"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.20069306),
        dec: Angle.Degrees(+02.16472776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92868"},
        {"Hipparcos Number", "HIP 52460"},
        {"Smithsonian Astrophysical Observation", "SAO 118452"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.86432226),
        dec: Angle.Degrees(+02.16477684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66925"},
        {"Hipparcos Number", "HIP 39621"},
        {"Smithsonian Astrophysical Observation", "SAO 116336"},
        {"Wilson Evans Batten Catalogue", "WEB 7742"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.44878231),
        dec: Angle.Degrees(+02.16511210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166641"},
        {"Hipparcos Number", "HIP 89137"},
        {"Smithsonian Astrophysical Observation", "SAO 123228"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.87859800),
        dec: Angle.Degrees(+02.16563868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72393"},
        {"Hipparcos Number", "HIP 41915"},
        {"Geneva Identification System", "GEN# +1.00072393"},
        {"Smithsonian Astrophysical Observation", "SAO 116875"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.18294781),
        dec: Angle.Degrees(+02.16726417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74704"},
        {"Wilson Evans Batten Catalogue", "WEB 12745"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.01128122),
        dec: Angle.Degrees(+02.16790800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18806"},
        {"Hipparcos Number", "HIP 14087"},
        {"Geneva Identification System", "GEN# +1.00018806"},
        {"Renson", "Renson 4710"},
        {"Smithsonian Astrophysical Observation", "SAO 110910"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.40820060),
        dec: Angle.Degrees(+02.16829154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21314"},
        {"Hipparcos Number", "HIP 16032"},
        {"Geneva Identification System", "GEN# +1.00021314"},
        {"Smithsonian Astrophysical Observation", "SAO 111189"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.60944873),
        dec: Angle.Degrees(+02.16975602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59688"},
        {"Hipparcos Number", "HIP 36557"},
        {"Geneva Identification System", "GEN# +1.00059688"},
        {"Smithsonian Astrophysical Observation", "SAO 115559"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.80624023),
        dec: Angle.Degrees(+02.17036220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17791"},
        {"Hipparcos Number", "HIP 13313"},
        {"Smithsonian Astrophysical Observation", "SAO 110791"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.83490131),
        dec: Angle.Degrees(+02.17286450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41715"},
        {"Hipparcos Number", "HIP 28976"},
        {"Smithsonian Astrophysical Observation", "SAO 113458"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.72807180),
        dec: Angle.Degrees(+02.17308441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183105"},
        {"Hipparcos Number", "HIP 95697"},
        {"Smithsonian Astrophysical Observation", "SAO 124651"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.96589336),
        dec: Angle.Degrees(+02.17431744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41142"},
        {"Geneva Identification System", "GEN# +0.00201954"},
        {"Smithsonian Astrophysical Observation", "SAO 116707"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.91004126),
        dec: Angle.Degrees(+02.17980364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80522"},
        {"Geneva Identification System", "GEN# +0.00203101"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.57278585),
        dec: Angle.Degrees(+02.18025731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -487.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104980"},
        {"Hipparcos Number", "HIP 58944"},
        {"Smithsonian Astrophysical Observation", "SAO 119212"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.29508173),
        dec: Angle.Degrees(+02.18355613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24520"},
        {"Hipparcos Number", "HIP 18243"},
        {"Geneva Identification System", "GEN# +1.00024520"},
        {"Smithsonian Astrophysical Observation", "SAO 111485"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.52899104),
        dec: Angle.Degrees(+02.18379708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37288",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37288"},
        {"Geneva Identification System", "GEN# +0.00201729"},
        {"Wilson Evans Batten Catalogue", "WEB 7382"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.84635403),
        dec: Angle.Degrees(+02.18426228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156208"},
        {"Hipparcos Number", "HIP 84479"},
        {"Geneva Identification System", "GEN# +1.00156208"},
        {"Smithsonian Astrophysical Observation", "SAO 122224"},
        {"Wilson Evans Batten Catalogue", "WEB 14257"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.05939112),
        dec: Angle.Degrees(+02.18624365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64802",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8842 AB"},
        {"Hipparcos Number", "HIP 64802"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.22126741),
        dec: Angle.Degrees(+02.18718564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119262"},
        {"Hipparcos Number", "HIP 66858"},
        {"Smithsonian Astrophysical Observation", "SAO 120073"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.53584716),
        dec: Angle.Degrees(+02.18916294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95623"},
        {"Hipparcos Number", "HIP 53952"},
        {"Geneva Identification System", "GEN# +1.00095623"},
        {"Smithsonian Astrophysical Observation", "SAO 118625"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.57465353),
        dec: Angle.Degrees(+02.18952289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11597"},
        {"Smithsonian Astrophysical Observation", "SAO 110567"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.37908892),
        dec: Angle.Degrees(+02.18988337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10159"},
        {"Hipparcos Number", "HIP 7722"},
        {"Smithsonian Astrophysical Observation", "SAO 110032"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.84508620),
        dec: Angle.Degrees(+02.19073475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124068"},
        {"Hipparcos Number", "HIP 69310"},
        {"Smithsonian Astrophysical Observation", "SAO 120332"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.80059891),
        dec: Angle.Degrees(+02.19603241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141680"},
        {"Hipparcos Number", "HIP 77578"},
        {"Geneva Identification System", "GEN# +1.00141680"},
        {"Smithsonian Astrophysical Observation", "SAO 121215"},
        {"Wilson Evans Batten Catalogue", "WEB 13131"},
    },
    visualMagnitude: 5.21,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.57303895),
        dec: Angle.Degrees(+02.19662489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220119"},
        {"Hipparcos Number", "HIP 115301"},
        {"Smithsonian Astrophysical Observation", "SAO 128135"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.29698039),
        dec: Angle.Degrees(+02.19735010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136833"},
        {"Hipparcos Number", "HIP 75271"},
        {"Smithsonian Astrophysical Observation", "SAO 120967"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.68363477),
        dec: Angle.Degrees(+02.19781790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172764"},
        {"Hipparcos Number", "HIP 91695"},
        {"Smithsonian Astrophysical Observation", "SAO 123815"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.47362275),
        dec: Angle.Degrees(+02.19800333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82089"},
        {"Hipparcos Number", "HIP 46574"},
        {"Geneva Identification System", "GEN# +1.00082089"},
        {"Smithsonian Astrophysical Observation", "SAO 117736"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.46849305),
        dec: Angle.Degrees(+02.19926548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38453"},
        {"Hipparcos Number", "HIP 27210"},
        {"Renson", "Renson 10336"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.50946394),
        dec: Angle.Degrees(+02.20111526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22428",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3465 AB"},
        {"Henry Draper", "HD 30636"},
        {"Hipparcos Number", "HIP 22428"},
        {"Renson", "Renson 7942"},
        {"Smithsonian Astrophysical Observation", "SAO 112104"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.38829606),
        dec: Angle.Degrees(+02.20176862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114665",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16607 A"},
        {"Henry Draper", "HD 219150"},
        {"Hipparcos Number", "HIP 114665"},
        {"Geneva Identification System", "GEN# +1.00219150"},
        {"Smithsonian Astrophysical Observation", "SAO 128046"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.42098512),
        dec: Angle.Degrees(+02.20348475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85496",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10570 AB"},
        {"Henry Draper", "HD 158283"},
        {"Hipparcos Number", "HIP 85496"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.08158844),
        dec: Angle.Degrees(+02.20395901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14144"},
        {"Smithsonian Astrophysical Observation", "SAO 110922"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.59803754),
        dec: Angle.Degrees(+02.20426437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91657"},
        {"Hipparcos Number", "HIP 51809"},
        {"Fundamental Katalog 5th Edition", "FK5 4940"},
        {"Smithsonian Astrophysical Observation", "SAO 118381"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.77545528),
        dec: Angle.Degrees(+02.20453112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44339",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7148 AB"},
        {"Henry Draper", "HD 77295"},
        {"Hipparcos Number", "HIP 44339"},
        {"Smithsonian Astrophysical Observation", "SAO 117360"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.44162290),
        dec: Angle.Degrees(+02.20562429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44928"},
        {"Fundamental Katalog 5th Edition", "FK5 4815"},
        {"Smithsonian Astrophysical Observation", "SAO 117457"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.27675092),
        dec: Angle.Degrees(+02.20708262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24763"},
        {"Hipparcos Number", "HIP 18422"},
        {"Smithsonian Astrophysical Observation", "SAO 111507"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.07817193),
        dec: Angle.Degrees(+02.20757456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73274",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73274"},
        {"Smithsonian Astrophysical Observation", "SAO 120767"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.63729505),
        dec: Angle.Degrees(+02.20950237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151355"},
        {"Hipparcos Number", "HIP 82133"},
        {"Smithsonian Astrophysical Observation", "SAO 121855"},
    },
    visualMagnitude: 8.87,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.69560613),
        dec: Angle.Degrees(+02.20951608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51485"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.73261150),
        dec: Angle.Degrees(+02.21245316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223346"},
        {"Hipparcos Number", "HIP 117445"},
        {"Geneva Identification System", "GEN# +1.00223346"},
        {"Smithsonian Astrophysical Observation", "SAO 128393"},
        {"Wilson Evans Batten Catalogue", "WEB 20684"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.20566896),
        dec: Angle.Degrees(+02.21449865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147737"},
        {"Hipparcos Number", "HIP 80297"},
        {"Smithsonian Astrophysical Observation", "SAO 121562"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.88117006),
        dec: Angle.Degrees(+02.21457680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35790"},
        {"Hipparcos Number", "HIP 25511"},
        {"Smithsonian Astrophysical Observation", "SAO 112786"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.83578348),
        dec: Angle.Degrees(+02.21586013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28009"},
        {"Hipparcos Number", "HIP 20642"},
        {"Geneva Identification System", "GEN# +1.00028009"},
        {"Smithsonian Astrophysical Observation", "SAO 111805"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.35372615),
        dec: Angle.Degrees(+02.21797203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88841",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11088 AB"},
        {"Henry Draper", "HD 165887"},
        {"Hipparcos Number", "HIP 88841"},
        {"Smithsonian Astrophysical Observation", "SAO 123156"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.03015969),
        dec: Angle.Degrees(+02.21867080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195616"},
        {"Hipparcos Number", "HIP 101335"},
        {"Smithsonian Astrophysical Observation", "SAO 125910"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.07388129),
        dec: Angle.Degrees(+02.22006686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68250",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9073 AB"},
        {"Henry Draper", "HD 121908"},
        {"Hipparcos Number", "HIP 68250"},
        {"Geneva Identification System", "GEN# +1.00121908J"},
        {"Smithsonian Astrophysical Observation", "SAO 120200"},
        {"Wilson Evans Batten Catalogue", "WEB 11972"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.58342806),
        dec: Angle.Degrees(+02.22068485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75664"},
        {"Hipparcos Number", "HIP 43480"},
        {"Geneva Identification System", "GEN# +1.00075664"},
        {"Smithsonian Astrophysical Observation", "SAO 117201"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.84465587),
        dec: Angle.Degrees(+02.22089014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9226"},
        {"Hipparcos Number", "HIP 7054"},
        {"Smithsonian Astrophysical Observation", "SAO 109937"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.72685095),
        dec: Angle.Degrees(+02.22126466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65345"},
        {"Hipparcos Number", "HIP 38962"},
        {"Geneva Identification System", "GEN# +1.00065345"},
        {"Smithsonian Astrophysical Observation", "SAO 116182"},
        {"Wilson Evans Batten Catalogue", "WEB 7640"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.58644862),
        dec: Angle.Degrees(+02.22452544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221822"},
        {"Hipparcos Number", "HIP 116410"},
        {"Cincinnati Publication", "Ci 18 3091"},
        {"Geneva Identification System", "GEN# +1.00221822"},
        {"Smithsonian Astrophysical Observation", "SAO 128268"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.84614531),
        dec: Angle.Degrees(+02.22456087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 317.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201198"},
        {"Hipparcos Number", "HIP 104319"},
        {"Geneva Identification System", "GEN# +1.00201198"},
        {"Smithsonian Astrophysical Observation", "SAO 126559"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.98833971),
        dec: Angle.Degrees(+02.22506003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 864 AB"},
        {"Hipparcos Number", "HIP 4886"},
        {"Geneva Identification System", "GEN# +0.00100194J"},
        {"Smithsonian Astrophysical Observation", "SAO 109624"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.68851855),
        dec: Angle.Degrees(+02.22823592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87284",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10822 AB"},
        {"Henry Draper", "HD 162262"},
        {"Hipparcos Number", "HIP 87284"},
        {"Smithsonian Astrophysical Observation", "SAO 122804"},
        {"Wilson Evans Batten Catalogue", "WEB 14722"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.52478865),
        dec: Angle.Degrees(+02.23057280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102747"},
        {"Hipparcos Number", "HIP 57681"},
        {"Smithsonian Astrophysical Observation", "SAO 119068"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.44480761),
        dec: Angle.Degrees(+02.23188945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181147"},
        {"Hipparcos Number", "HIP 94941"},
        {"Geneva Identification System", "GEN# +1.00181147"},
        {"Smithsonian Astrophysical Observation", "SAO 124498"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.79174498),
        dec: Angle.Degrees(+02.23254628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193225"},
        {"Hipparcos Number", "HIP 100159"},
        {"Geneva Identification System", "GEN# +1.00193225"},
        {"Smithsonian Astrophysical Observation", "SAO 125673"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.75287551),
        dec: Angle.Degrees(+02.23341824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74364"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.95749618),
        dec: Angle.Degrees(+02.23372159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65704",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8913 AB"},
        {"Henry Draper", "HD 117125"},
        {"Hipparcos Number", "HIP 65704"},
        {"Smithsonian Astrophysical Observation", "SAO 119942"},
        {"Wilson Evans Batten Catalogue", "WEB 11627"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.06860455),
        dec: Angle.Degrees(+02.23591937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131477"},
        {"Hipparcos Number", "HIP 72868"},
        {"Smithsonian Astrophysical Observation", "SAO 120717"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.41297966),
        dec: Angle.Degrees(+02.23757947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223617"},
        {"Hipparcos Number", "HIP 117607"},
        {"Geneva Identification System", "GEN# +1.00223617"},
        {"Smithsonian Astrophysical Observation", "SAO 128417"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.77832279),
        dec: Angle.Degrees(+02.23786488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14042"},
        {"Hipparcos Number", "HIP 10600"},
        {"Geneva Identification System", "GEN# +1.00014042"},
        {"Smithsonian Astrophysical Observation", "SAO 110441"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.11810736),
        dec: Angle.Degrees(+02.23815795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38547"},
        {"Hipparcos Number", "HIP 27258"},
        {"Smithsonian Astrophysical Observation", "SAO 113122"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.67226434),
        dec: Angle.Degrees(+02.24085319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151372"},
        {"Hipparcos Number", "HIP 82142"},
        {"Geneva Identification System", "GEN# +1.00151372"},
        {"Smithsonian Astrophysical Observation", "SAO 121857"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.72092970),
        dec: Angle.Degrees(+02.24238834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166072"},
        {"Hipparcos Number", "HIP 88897"},
        {"Smithsonian Astrophysical Observation", "SAO 123173"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.21864046),
        dec: Angle.Degrees(+02.24306155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206067"},
        {"Hipparcos Number", "HIP 106944"},
        {"Fundamental Katalog 5th Edition", "FK5 3729"},
        {"Geneva Identification System", "GEN# +1.00206067"},
        {"Smithsonian Astrophysical Observation", "SAO 126965"},
        {"Wilson Evans Batten Catalogue", "WEB 19327"},
    },
    visualMagnitude: 5.10,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.88868707),
        dec: Angle.Degrees(+02.24376298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128232"},
        {"Hipparcos Number", "HIP 71374"},
        {"Smithsonian Astrophysical Observation", "SAO 120551"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.94456749),
        dec: Angle.Degrees(+02.24377859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121606"},
        {"Hipparcos Number", "HIP 68096"},
        {"Smithsonian Astrophysical Observation", "SAO 120187"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.12081618),
        dec: Angle.Degrees(+02.24449158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45302"},
        {"Smithsonian Astrophysical Observation", "SAO 117521"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.49842173),
        dec: Angle.Degrees(+02.24896231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135150"},
        {"Hipparcos Number", "HIP 74513"},
        {"Smithsonian Astrophysical Observation", "SAO 120903"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.39817902),
        dec: Angle.Degrees(+02.25050236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222190"},
        {"Hipparcos Number", "HIP 116660"},
        {"Smithsonian Astrophysical Observation", "SAO 128298"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.61307210),
        dec: Angle.Degrees(+02.25056273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54489"},
        {"Hipparcos Number", "HIP 34518"},
        {"Smithsonian Astrophysical Observation", "SAO 114995"},
        {"Wilson Evans Batten Catalogue", "WEB 6912"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.28248027),
        dec: Angle.Degrees(+02.25316855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158935"},
        {"Hipparcos Number", "HIP 85798"},
        {"Smithsonian Astrophysical Observation", "SAO 122474"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.97226446),
        dec: Angle.Degrees(+02.25321460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163792"},
        {"Hipparcos Number", "HIP 87939"},
        {"Geneva Identification System", "GEN# +1.00163792"},
        {"Smithsonian Astrophysical Observation", "SAO 122964"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.46250748),
        dec: Angle.Degrees(+02.25355110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171932"},
        {"Hipparcos Number", "HIP 91296"},
        {"Smithsonian Astrophysical Observation", "SAO 123707"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.33233310),
        dec: Angle.Degrees(+02.25482984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205357"},
        {"Hipparcos Number", "HIP 106533"},
        {"Smithsonian Astrophysical Observation", "SAO 126899"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.65164316),
        dec: Angle.Degrees(+02.25755491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 288595"},
        {"Hipparcos Number", "HIP 30112"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.05531930),
        dec: Angle.Degrees(+02.25914233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106314"},
        {"Hipparcos Number", "HIP 59646"},
        {"Geneva Identification System", "GEN# +1.00106314"},
        {"Smithsonian Astrophysical Observation", "SAO 119278"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.48260704),
        dec: Angle.Degrees(+02.26026779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53479"},
        {"Hipparcos Number", "HIP 34188"},
        {"Smithsonian Astrophysical Observation", "SAO 114896"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.34365026),
        dec: Angle.Degrees(+02.26071221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109521"},
        {"Hipparcos Number", "HIP 61428"},
        {"Geneva Identification System", "GEN# +1.00109521"},
        {"Smithsonian Astrophysical Observation", "SAO 119485"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.81674651),
        dec: Angle.Degrees(+02.26085828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59511"},
        {"Hipparcos Number", "HIP 36492"},
        {"Smithsonian Astrophysical Observation", "SAO 115531"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.62118274),
        dec: Angle.Degrees(+02.26226039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109091"},
        {"Smithsonian Astrophysical Observation", "SAO 127291"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.47521329),
        dec: Angle.Degrees(+02.26590083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15694"},
        {"Hipparcos Number", "HIP 11738"},
        {"Fundamental Katalog 5th Edition", "FK5 2173"},
        {"Geneva Identification System", "GEN# +1.00015694"},
        {"Smithsonian Astrophysical Observation", "SAO 110589"},
        {"Wilson Evans Batten Catalogue", "WEB 2437"},
    },
    visualMagnitude: 5.27,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.87534312),
        dec: Angle.Degrees(+02.26720689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186445"},
        {"Hipparcos Number", "HIP 97121"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.07671162),
        dec: Angle.Degrees(+02.26749998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97606"},
        {"Hipparcos Number", "HIP 54857"},
        {"Geneva Identification System", "GEN# +1.00097606"},
        {"Smithsonian Astrophysical Observation", "SAO 118734"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.47111684),
        dec: Angle.Degrees(+02.26858457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30217",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4971 AB"},
        {"Henry Draper", "HD 44333"},
        {"Hipparcos Number", "HIP 30217"},
        {"Geneva Identification System", "GEN# +1.00044333J"},
        {"Smithsonian Astrophysical Observation", "SAO 113758"},
        {"Wilson Evans Batten Catalogue", "WEB 6009"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.35741582),
        dec: Angle.Degrees(+02.26858774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15686"},
        {"Hipparcos Number", "HIP 11724"},
        {"Geneva Identification System", "GEN# +1.00015686"},
        {"Smithsonian Astrophysical Observation", "SAO 110587"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.83554512),
        dec: Angle.Degrees(+02.26870198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47257"},
        {"Hipparcos Number", "HIP 31698"},
        {"Smithsonian Astrophysical Observation", "SAO 114164"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.47103607),
        dec: Angle.Degrees(+02.26944364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200663"},
        {"Hipparcos Number", "HIP 104048"},
        {"Fundamental Katalog 5th Edition", "FK5 3681"},
        {"Geneva Identification System", "GEN# +1.00200663"},
        {"Smithsonian Astrophysical Observation", "SAO 126522"},
        {"Wilson Evans Batten Catalogue", "WEB 18954"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.18883324),
        dec: Angle.Degrees(+02.26993181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178239"},
        {"Hipparcos Number", "HIP 93949"},
        {"Smithsonian Astrophysical Observation", "SAO 124299"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.93882330),
        dec: Angle.Degrees(+02.27034062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45137"},
        {"Hipparcos Number", "HIP 30594"},
        {"Geneva Identification System", "GEN# +1.00045137"},
        {"Smithsonian Astrophysical Observation", "SAO 113868"},
        {"Wilson Evans Batten Catalogue", "WEB 6102"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.44387100),
        dec: Angle.Degrees(+02.27172012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150616"},
        {"Hipparcos Number", "HIP 81770"},
        {"Smithsonian Astrophysical Observation", "SAO 121793"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.53300207),
        dec: Angle.Degrees(+02.27239745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30728"},
        {"Hipparcos Number", "HIP 22483"},
        {"Smithsonian Astrophysical Observation", "SAO 112120"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.55590958),
        dec: Angle.Degrees(+02.27301612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41751"},
        {"Smithsonian Astrophysical Observation", "SAO 116843"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.70556089),
        dec: Angle.Degrees(+02.27402638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125979"},
        {"Hipparcos Number", "HIP 70278"},
        {"Geneva Identification System", "GEN# +1.00125979"},
        {"Smithsonian Astrophysical Observation", "SAO 120420"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.68057414),
        dec: Angle.Degrees(+02.27461715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9323 AB"},
        {"Henry Draper", "HD 128563"},
        {"Hipparcos Number", "HIP 71510"},
        {"Smithsonian Astrophysical Observation", "SAO 120569"},
        {"Wilson Evans Batten Catalogue", "WEB 12336"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.36870503),
        dec: Angle.Degrees(+02.27741561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82333"},
        {"Hipparcos Number", "HIP 46718"},
        {"Geneva Identification System", "GEN# +1.00082333"},
        {"Smithsonian Astrophysical Observation", "SAO 117745"},
        {"Wilson Evans Batten Catalogue", "WEB 8812"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.84863882),
        dec: Angle.Degrees(+02.27867063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103789"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.47816743),
        dec: Angle.Degrees(+02.27874984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154466"},
        {"Hipparcos Number", "HIP 83632"},
        {"Smithsonian Astrophysical Observation", "SAO 122063"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.38157016),
        dec: Angle.Degrees(+02.27908326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205256"},
        {"Hipparcos Number", "HIP 106484"},
        {"Smithsonian Astrophysical Observation", "SAO 126892"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.51091807),
        dec: Angle.Degrees(+02.27972384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21405"},
        {"Hipparcos Number", "HIP 16086"},
        {"Geneva Identification System", "GEN# +1.00021405"},
        {"Smithsonian Astrophysical Observation", "SAO 111197"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.80761816),
        dec: Angle.Degrees(+02.28022496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59110"},
        {"Hipparcos Number", "HIP 36331"},
        {"Smithsonian Astrophysical Observation", "SAO 115499"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.17474011),
        dec: Angle.Degrees(+02.28354683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184179"},
        {"Hipparcos Number", "HIP 96156"},
        {"Smithsonian Astrophysical Observation", "SAO 124771"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.27265190),
        dec: Angle.Degrees(+02.28430426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103547"},
        {"Hipparcos Number", "HIP 58136"},
        {"Geneva Identification System", "GEN# +1.00103547"},
        {"Smithsonian Astrophysical Observation", "SAO 119115"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.85927655),
        dec: Angle.Degrees(+02.28460747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68380"},
        {"Hipparcos Number", "HIP 40169"},
        {"Geneva Identification System", "GEN# +1.00068380"},
        {"Smithsonian Astrophysical Observation", "SAO 116472"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.05655749),
        dec: Angle.Degrees(+02.28925496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89688"},
        {"Hipparcos Number", "HIP 50684"},
        {"Fundamental Katalog 5th Edition", "FK5 1266"},
        {"Geneva Identification System", "GEN# +1.00089688"},
        {"Smithsonian Astrophysical Observation", "SAO 118248"},
        {"Wilson Evans Batten Catalogue", "WEB 9287"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.25837849),
        dec: Angle.Degrees(+02.28972523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43113"},
        {"Hipparcos Number", "HIP 29632"},
        {"Smithsonian Astrophysical Observation", "SAO 113626"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.65553660),
        dec: Angle.Degrees(+02.29000027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33513"},
        {"Geneva Identification System", "GEN# +1.00051565"},
        {"Geneva Identification System 2", "GEN# +1.00051566"},
        {"Renson", "Renson 14200"},
        {"Smithsonian Astrophysical Observation", "SAO 114692"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.49088490),
        dec: Angle.Degrees(+02.29223814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94477",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12182 A"},
        {"Henry Draper", "HD 179761"},
        {"Hipparcos Number", "HIP 94477"},
        {"Fundamental Katalog 5th Edition", "FK5 3537"},
        {"Geneva Identification System", "GEN# +1.00179761"},
        {"Renson", "Renson 49900"},
        {"Smithsonian Astrophysical Observation", "SAO 124408"},
        {"Wilson Evans Batten Catalogue", "WEB 16465"},
    },
    visualMagnitude: 5.14,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.42791464),
        dec: Angle.Degrees(+02.29371370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129449"},
        {"Hipparcos Number", "HIP 71909"},
        {"Geneva Identification System", "GEN# +1.00129449"},
        {"Smithsonian Astrophysical Observation", "SAO 120611"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.63045134),
        dec: Angle.Degrees(+02.29524327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122910"},
        {"Hipparcos Number", "HIP 68776"},
        {"Geneva Identification System", "GEN# +1.00122910"},
        {"Smithsonian Astrophysical Observation", "SAO 120269"},
        {"Wilson Evans Batten Catalogue", "WEB 12031"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.15604081),
        dec: Angle.Degrees(+02.29752929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60492"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.01965103),
        dec: Angle.Degrees(+02.29789751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111775",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16131 AB"},
        {"Henry Draper", "HD 214494"},
        {"Hipparcos Number", "HIP 111775"},
        {"Smithsonian Astrophysical Observation", "SAO 127651"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.62174285),
        dec: Angle.Degrees(+02.29901812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5818"},
        {"Smithsonian Astrophysical Observation", "SAO 109751"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.66784277),
        dec: Angle.Degrees(+02.29952159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 632"},
        {"Hipparcos Number", "HIP 868"},
        {"Smithsonian Astrophysical Observation", "SAO 109047"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.66362432),
        dec: Angle.Degrees(+02.30067277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79712"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.01971076),
        dec: Angle.Degrees(+02.30227940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108978"},
        {"Hipparcos Number", "HIP 61096"},
        {"Smithsonian Astrophysical Observation", "SAO 119450"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.82246464),
        dec: Angle.Degrees(+02.30255338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137203"},
        {"Hipparcos Number", "HIP 75432"},
        {"Smithsonian Astrophysical Observation", "SAO 120985"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.16387264),
        dec: Angle.Degrees(+02.30259991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20591"},
        {"Hipparcos Number", "HIP 15436"},
        {"Smithsonian Astrophysical Observation", "SAO 111117"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.73729841),
        dec: Angle.Degrees(+02.30467120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287671"},
        {"Hipparcos Number", "HIP 24699"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.46048761),
        dec: Angle.Degrees(+02.30661256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191925"},
        {"Hipparcos Number", "HIP 99552"},
        {"Smithsonian Astrophysical Observation", "SAO 125560"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.04674760),
        dec: Angle.Degrees(+02.30722107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4095"},
        {"Hipparcos Number", "HIP 3416"},
        {"Smithsonian Astrophysical Observation", "SAO 109409"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.87011774),
        dec: Angle.Degrees(+02.30778786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10467"},
        {"Hipparcos Number", "HIP 7957"},
        {"Smithsonian Astrophysical Observation", "SAO 110077"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.54320969),
        dec: Angle.Degrees(+02.30798937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148425"},
        {"Hipparcos Number", "HIP 80637"},
        {"Smithsonian Astrophysical Observation", "SAO 121617"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.96804158),
        dec: Angle.Degrees(+02.30961938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47595",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7493 AB"},
        {"Henry Draper", "HD 84021"},
        {"Hipparcos Number", "HIP 47595"},
        {"Smithsonian Astrophysical Observation", "SAO 117863"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.57129378),
        dec: Angle.Degrees(+02.31322700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6375"},
        {"Hipparcos Number", "HIP 5060"},
        {"Smithsonian Astrophysical Observation", "SAO 109653"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.18169264),
        dec: Angle.Degrees(+02.31381166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7253 A"},
        {"Henry Draper", "HD 79469"},
        {"Hipparcos Number", "HIP 45336"},
        {"Fundamental Katalog 5th Edition", "FK5 347"},
        {"Geneva Identification System", "GEN# +1.00079469"},
        {"Renson", "Renson 22550"},
        {"Smithsonian Astrophysical Observation", "SAO 117527"},
        {"Wilson Evans Batten Catalogue", "WEB 8635"},
    },
    visualMagnitude: 3.89,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.59080529),
        dec: Angle.Degrees(+02.31502422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -306.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84749"},
        {"Hipparcos Number", "HIP 48025"},
        {"Geneva Identification System", "GEN# +1.00084749"},
        {"Smithsonian Astrophysical Observation", "SAO 117909"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.84526573),
        dec: Angle.Degrees(+02.31516458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9198"},
        {"Smithsonian Astrophysical Observation", "SAO 110251"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.59949813),
        dec: Angle.Degrees(+02.31550329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19552",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19552"},
        {"Smithsonian Astrophysical Observation", "SAO 111649"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.81996421),
        dec: Angle.Degrees(+02.31563121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19760"},
        {"Hipparcos Number", "HIP 14786"},
        {"Geneva Identification System", "GEN# +1.00019760"},
        {"Smithsonian Astrophysical Observation", "SAO 111030"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.73095987),
        dec: Angle.Degrees(+02.31591174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33351",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5603 AB"},
        {"Henry Draper", "HD 51105"},
        {"Hipparcos Number", "HIP 33351"},
        {"Smithsonian Astrophysical Observation", "SAO 114644"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.04981590),
        dec: Angle.Degrees(+02.31657930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45212"},
        {"Hipparcos Number", "HIP 30638"},
        {"Smithsonian Astrophysical Observation", "SAO 113876"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.58428926),
        dec: Angle.Degrees(+02.31778801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75044"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.02400183),
        dec: Angle.Degrees(+02.31782190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26448"},
        {"Hipparcos Number", "HIP 19545"},
        {"Smithsonian Astrophysical Observation", "SAO 111646"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.78898702),
        dec: Angle.Degrees(+02.31843447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37293"},
        {"Hipparcos Number", "HIP 26450"},
        {"Smithsonian Astrophysical Observation", "SAO 112971"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.41016744),
        dec: Angle.Degrees(+02.32153799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64965"},
        {"Hipparcos Number", "HIP 38805"},
        {"Smithsonian Astrophysical Observation", "SAO 116151"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.12975541),
        dec: Angle.Degrees(+02.32204689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2030"},
    },
    visualMagnitude: 10.71,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.43256505),
        dec: Angle.Degrees(+02.32214120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151331"},
        {"Hipparcos Number", "HIP 82126"},
        {"Geneva Identification System", "GEN# +1.00151331"},
        {"Smithsonian Astrophysical Observation", "SAO 121853"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.65793953),
        dec: Angle.Degrees(+02.32320537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78925",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78925"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.67454809),
        dec: Angle.Degrees(+02.32370494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143630"},
        {"Hipparcos Number", "HIP 78499"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.37571356),
        dec: Angle.Degrees(+02.32614749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111030"},
        {"Hipparcos Number", "HIP 62331"},
        {"Smithsonian Astrophysical Observation", "SAO 119581"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.60053554),
        dec: Angle.Degrees(+02.32786097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112522",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112522"},
    },
    visualMagnitude: 11.93,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.87543061),
        dec: Angle.Degrees(+02.32791907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42481"},
        {"Hipparcos Number", "HIP 29329"},
        {"Smithsonian Astrophysical Observation", "SAO 113557"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.76275733),
        dec: Angle.Degrees(+02.33050763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223854"},
        {"Hipparcos Number", "HIP 117776"},
        {"Geneva Identification System", "GEN# +1.00223854"},
        {"Smithsonian Astrophysical Observation", "SAO 128437"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.27863737),
        dec: Angle.Degrees(+02.33100217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112222"},
        {"Hipparcos Number", "HIP 63037"},
        {"Geneva Identification System", "GEN# +1.00112222"},
        {"Smithsonian Astrophysical Observation", "SAO 119662"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.76116511),
        dec: Angle.Degrees(+02.33221038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185481"},
        {"Hipparcos Number", "HIP 96663"},
        {"Smithsonian Astrophysical Observation", "SAO 124899"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.79429569),
        dec: Angle.Degrees(+02.33224750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199456"},
        {"Hipparcos Number", "HIP 103425"},
        {"Smithsonian Astrophysical Observation", "SAO 126398"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.31226629),
        dec: Angle.Degrees(+02.33273252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81971",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10185 A"},
        {"Henry Draper", "HD 151029"},
        {"Hipparcos Number", "HIP 81971"},
        {"Smithsonian Astrophysical Observation", "SAO 121826"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.17677306),
        dec: Angle.Degrees(+02.33294140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148684"},
        {"Hipparcos Number", "HIP 80783"},
        {"Smithsonian Astrophysical Observation", "SAO 121642"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.42742115),
        dec: Angle.Degrees(+02.33411181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66141"},
        {"Hipparcos Number", "HIP 39311"},
        {"Fundamental Katalog 5th Edition", "FK5 2623"},
        {"Geneva Identification System", "GEN# +1.00066141"},
        {"Smithsonian Astrophysical Observation", "SAO 116260"},
        {"Wilson Evans Batten Catalogue", "WEB 7699"},
    },
    visualMagnitude: 4.39,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.56647202),
        dec: Angle.Degrees(+02.33431429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157311"},
        {"Hipparcos Number", "HIP 84992"},
        {"Cincinnati Publication", "Ci 18 2314"},
        {"Smithsonian Astrophysical Observation", "SAO 122322"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.58105230),
        dec: Angle.Degrees(+02.33573958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94350"},
        {"Hipparcos Number", "HIP 53245"},
        {"Smithsonian Astrophysical Observation", "SAO 118563"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.35902625),
        dec: Angle.Degrees(+02.33928730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20394"},
        {"Hipparcos Number", "HIP 15264"},
        {"Geneva Identification System", "GEN# +1.00020394"},
        {"Smithsonian Astrophysical Observation", "SAO 111092"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.22326195),
        dec: Angle.Degrees(+02.33934713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55034"},
        {"Hipparcos Number", "HIP 34726"},
        {"Smithsonian Astrophysical Observation", "SAO 115056"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.85696370),
        dec: Angle.Degrees(+02.34033005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35775"},
        {"Hipparcos Number", "HIP 25505"},
        {"Smithsonian Astrophysical Observation", "SAO 112784"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.81415869),
        dec: Angle.Degrees(+02.34120488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153227"},
        {"Hipparcos Number", "HIP 83027"},
        {"Smithsonian Astrophysical Observation", "SAO 121963"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.50189563),
        dec: Angle.Degrees(+02.34193186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44418"},
        {"Hipparcos Number", "HIP 30248"},
        {"Fundamental Katalog 5th Edition", "FK5 4576"},
        {"Smithsonian Astrophysical Observation", "SAO 113766"},
        {"Wilson Evans Batten Catalogue", "WEB 6016"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.44600798),
        dec: Angle.Degrees(+02.34245949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158049"},
        {"Hipparcos Number", "HIP 85390"},
        {"Smithsonian Astrophysical Observation", "SAO 122393"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.72945714),
        dec: Angle.Degrees(+02.34494190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137111"},
        {"Hipparcos Number", "HIP 75375"},
        {"Geneva Identification System", "GEN# +1.00137111"},
        {"Smithsonian Astrophysical Observation", "SAO 120978"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.03766633),
        dec: Angle.Degrees(+02.34556049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148287"},
        {"Hipparcos Number", "HIP 80558"},
        {"Geneva Identification System", "GEN# +1.00148287"},
        {"Smithsonian Astrophysical Observation", "SAO 121604"},
        {"Wilson Evans Batten Catalogue", "WEB 13628"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.70859435),
        dec: Angle.Degrees(+02.34798373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89655"},
        {"Hipparcos Number", "HIP 50668"},
        {"Smithsonian Astrophysical Observation", "SAO 118244"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.20287086),
        dec: Angle.Degrees(+02.35088755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14765"},
        {"Hipparcos Number", "HIP 11103"},
        {"Smithsonian Astrophysical Observation", "SAO 110503"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.72946902),
        dec: Angle.Degrees(+02.35110317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88097"},
        {"Hipparcos Number", "HIP 49777"},
        {"Geneva Identification System", "GEN# +1.00088097"},
        {"Smithsonian Astrophysical Observation", "SAO 118139"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.41406385),
        dec: Angle.Degrees(+02.35163906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35407"},
        {"Hipparcos Number", "HIP 25288"},
        {"Celescope Catalog", "CEL 677"},
        {"Geneva Identification System", "GEN# +1.00035407"},
        {"Smithsonian Astrophysical Observation", "SAO 112729"},
        {"Wilson Evans Batten Catalogue", "WEB 4907"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.15042015),
        dec: Angle.Degrees(+02.35316729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102095"},
        {"Hipparcos Number", "HIP 57305"},
        {"Smithsonian Astrophysical Observation", "SAO 119024"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.25560672),
        dec: Angle.Degrees(+02.35359728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201893"},
        {"Hipparcos Number", "HIP 104698"},
        {"Smithsonian Astrophysical Observation", "SAO 126613"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.12196860),
        dec: Angle.Degrees(+02.35428532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19271"},
        {"Hipparcos Number", "HIP 14416"},
        {"Smithsonian Astrophysical Observation", "SAO 110964"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.53146561),
        dec: Angle.Degrees(+02.35580363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4465"},
        {"Hipparcos Number", "HIP 3652"},
        {"Smithsonian Astrophysical Observation", "SAO 109453"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.69285279),
        dec: Angle.Degrees(+02.35688634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178880"},
        {"Hipparcos Number", "HIP 94169"},
        {"Geneva Identification System", "GEN# +1.00178880"},
        {"Renson", "Renson 49735"},
        {"Smithsonian Astrophysical Observation", "SAO 124339"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.54108144),
        dec: Angle.Degrees(+02.35740345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289346"},
        {"Hipparcos Number", "HIP 33337"},
        {"Smithsonian Astrophysical Observation", "SAO 114641"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.00022283),
        dec: Angle.Degrees(+02.35880163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9538"},
        {"Hipparcos Number", "HIP 7270"},
        {"Smithsonian Astrophysical Observation", "SAO 109972"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.40662613),
        dec: Angle.Degrees(+02.35922888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19556"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.83821162),
        dec: Angle.Degrees(+02.36052079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208349"},
        {"Hipparcos Number", "HIP 108237"},
        {"Geneva Identification System", "GEN# +1.00208349"},
        {"Smithsonian Astrophysical Observation", "SAO 127160"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.91049440),
        dec: Angle.Degrees(+02.36082171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37804"},
        {"Hipparcos Number", "HIP 26782"},
        {"Smithsonian Astrophysical Observation", "SAO 113038"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.33827404),
        dec: Angle.Degrees(+02.36133820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101730"},
        {"Hipparcos Number", "HIP 57107"},
        {"Geneva Identification System", "GEN# +1.00101730"},
        {"Smithsonian Astrophysical Observation", "SAO 119003"},
        {"Wilson Evans Batten Catalogue", "WEB 10279"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.60655891),
        dec: Angle.Degrees(+02.36219053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104426"},
        {"Hipparcos Number", "HIP 58643"},
        {"Smithsonian Astrophysical Observation", "SAO 119171"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.37266966),
        dec: Angle.Degrees(+02.36250842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133948"},
        {"Hipparcos Number", "HIP 73977"},
        {"Smithsonian Astrophysical Observation", "SAO 120845"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.77859620),
        dec: Angle.Degrees(+02.36265276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75407"},
        {"Hipparcos Number", "HIP 43357"},
        {"Geneva Identification System", "GEN# +1.00075407"},
        {"Smithsonian Astrophysical Observation", "SAO 117176"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.47639984),
        dec: Angle.Degrees(+02.36291630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221318"},
        {"Hipparcos Number", "HIP 116069"},
        {"Geneva Identification System", "GEN# +1.00221318"},
        {"Smithsonian Astrophysical Observation", "SAO 128223"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.77742942),
        dec: Angle.Degrees(+02.36350544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96200"},
        {"Hipparcos Number", "HIP 54220"},
        {"Geneva Identification System", "GEN# +1.00096200"},
        {"Smithsonian Astrophysical Observation", "SAO 118653"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.40671261),
        dec: Angle.Degrees(+02.36350851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14535",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14535"},
        {"Smithsonian Astrophysical Observation", "SAO 110987"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.91645632),
        dec: Angle.Degrees(+02.36589377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37958"},
        {"Hipparcos Number", "HIP 26870"},
        {"Celescope Catalog", "CEL 936"},
        {"Geneva Identification System", "GEN# +1.00037958"},
        {"Smithsonian Astrophysical Observation", "SAO 113053"},
    },
    visualMagnitude: 6.67,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.57340483),
        dec: Angle.Degrees(+02.36718571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50939",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7755 A"},
        {"Henry Draper", "HD 90125"},
        {"Hipparcos Number", "HIP 50939"},
        {"Geneva Identification System", "GEN# +1.00090125"},
        {"Smithsonian Astrophysical Observation", "SAO 118278"},
        {"Wilson Evans Batten Catalogue", "WEB 9318"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.05479557),
        dec: Angle.Degrees(+02.36807198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12923"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.55619838),
        dec: Angle.Degrees(+02.36920283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88072"},
        {"Hipparcos Number", "HIP 49756"},
        {"Geneva Identification System", "GEN# +1.00088072"},
        {"Smithsonian Astrophysical Observation", "SAO 118136"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.34811603),
        dec: Angle.Degrees(+02.37110094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1284"},
        {"Hipparcos Number", "HIP 1360"},
        {"Smithsonian Astrophysical Observation", "SAO 109106"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.26024490),
        dec: Angle.Degrees(+02.37147708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28395"},
        {"Hipparcos Number", "HIP 20902"},
        {"Geneva Identification System", "GEN# +1.00028395"},
        {"Smithsonian Astrophysical Observation", "SAO 111847"},
        {"Wilson Evans Batten Catalogue", "WEB 4016"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.20918857),
        dec: Angle.Degrees(+02.37176419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38546"},
        {"Hipparcos Number", "HIP 27270"},
        {"Smithsonian Astrophysical Observation", "SAO 113126"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.69389363),
        dec: Angle.Degrees(+02.37464870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87081",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87081"},
        {"Smithsonian Astrophysical Observation", "SAO 122749"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.91038935),
        dec: Angle.Degrees(+02.37581112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25595",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4061 AB"},
        {"Henry Draper", "HD 35911"},
        {"Hipparcos Number", "HIP 25595"},
        {"Smithsonian Astrophysical Observation", "SAO 112797"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.04442476),
        dec: Angle.Degrees(+02.37647358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36645"},
        {"Hipparcos Number", "HIP 26045"},
        {"Geneva Identification System", "GEN# +1.00036645"},
        {"Smithsonian Astrophysical Observation", "SAO 112898"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.34112072),
        dec: Angle.Degrees(+02.37657362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167654"},
        {"Hipparcos Number", "HIP 89527"},
        {"Geneva Identification System", "GEN# +1.00167654"},
        {"Smithsonian Astrophysical Observation", "SAO 123308"},
        {"Wilson Evans Batten Catalogue", "WEB 15245"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.02323196),
        dec: Angle.Degrees(+02.37758611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66476",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8975 A"},
        {"Henry Draper", "HD 118578"},
        {"Hipparcos Number", "HIP 66476"},
        {"Smithsonian Astrophysical Observation", "SAO 120042"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.43335710),
        dec: Angle.Degrees(+02.38234728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170096"},
        {"Hipparcos Number", "HIP 90467"},
        {"Geneva Identification System", "GEN# +1.00170096"},
        {"Smithsonian Astrophysical Observation", "SAO 123507"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.90420349),
        dec: Angle.Degrees(+02.38316342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112931"},
        {"Hipparcos Number", "HIP 63455"},
        {"Smithsonian Astrophysical Observation", "SAO 119707"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.03630177),
        dec: Angle.Degrees(+02.38409513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83980"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.51199945),
        dec: Angle.Degrees(+02.38425001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66477",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8975 B"},
        {"Hipparcos Number", "HIP 66477"},
        {"Smithsonian Astrophysical Observation", "SAO 120043"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.43566305),
        dec: Angle.Degrees(+02.38610632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11338"},
        {"Hipparcos Number", "HIP 8657"},
        {"Smithsonian Astrophysical Observation", "SAO 110177"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.89322173),
        dec: Angle.Degrees(+02.38617737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133315"},
        {"Hipparcos Number", "HIP 73683"},
        {"Smithsonian Astrophysical Observation", "SAO 120817"},
    },
    visualMagnitude: 8.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.91833535),
        dec: Angle.Degrees(+02.38630459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93614"},
        {"Hipparcos Number", "HIP 52856"},
        {"Smithsonian Astrophysical Observation", "SAO 118508"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.13045632),
        dec: Angle.Degrees(+02.38786958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46559"},
        {"Hipparcos Number", "HIP 31337"},
        {"Geneva Identification System", "GEN# +1.00046559"},
        {"Smithsonian Astrophysical Observation", "SAO 114069"},
        {"Wilson Evans Batten Catalogue", "WEB 6267"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.56326276),
        dec: Angle.Degrees(+02.38935494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107968"},
        {"Geneva Identification System", "GEN# +9.80093048"},
    },
    visualMagnitude: 12.74,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.10570848),
        dec: Angle.Degrees(+02.38950195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27642"},
        {"Hipparcos Number", "HIP 20373"},
        {"Geneva Identification System", "GEN# +1.00027642"},
        {"Smithsonian Astrophysical Observation", "SAO 111773"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.44290657),
        dec: Angle.Degrees(+02.39044805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50958",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7755 C"},
        {"Henry Draper", "HD 90155"},
        {"Hipparcos Number", "HIP 50958"},
        {"Smithsonian Astrophysical Observation", "SAO 118281"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.10539238),
        dec: Angle.Degrees(+02.39329947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167162"},
        {"Hipparcos Number", "HIP 89347"},
        {"Smithsonian Astrophysical Observation", "SAO 123271"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.46758969),
        dec: Angle.Degrees(+02.39349229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2970"},
        {"Smithsonian Astrophysical Observation", "SAO 109319"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.46109486),
        dec: Angle.Degrees(+02.39450708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70725",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70725"},
        {"Smithsonian Astrophysical Observation", "SAO 120475"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.96963311),
        dec: Angle.Degrees(+02.39593878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5"},
        {"Hipparcos Number", "HIP 429"},
        {"Smithsonian Astrophysical Observation", "SAO 109001"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.29232665),
        dec: Angle.Degrees(+02.39731072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96310"},
        {"Hipparcos Number", "HIP 54281"},
        {"Smithsonian Astrophysical Observation", "SAO 118659"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.56582806),
        dec: Angle.Degrees(+02.39856382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108526"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.78800170),
        dec: Angle.Degrees(+02.40050217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117473"},
        {"Cincinnati Publication", "Ci 18 3124"},
        {"Cincinnati Publication 2", "Ci 20 1454"},
        {"Geneva Identification System", "GEN# +0.00104774"},
        {"Smithsonian Astrophysical Observation", "SAO 128397"},
        {"Wilson Evans Batten Catalogue", "WEB 20691"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.29977433),
        dec: Angle.Degrees(+02.40357651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 995.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -968.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62437"},
        {"Hipparcos Number", "HIP 37705"},
        {"Geneva Identification System", "GEN# +1.00062437"},
        {"Smithsonian Astrophysical Observation", "SAO 115864"},
        {"Wilson Evans Batten Catalogue", "WEB 7454"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.03185066),
        dec: Angle.Degrees(+02.40544316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217373"},
        {"Hipparcos Number", "HIP 113572"},
        {"Smithsonian Astrophysical Observation", "SAO 127887"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.05803137),
        dec: Angle.Degrees(+02.40697228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69389",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9152 A"},
        {"Henry Draper", "HD 124224"},
        {"Hipparcos Number", "HIP 69389"},
        {"Fundamental Katalog 5th Edition", "FK5 3127"},
        {"Geneva Identification System", "GEN# +1.00124224"},
        {"Renson", "Renson 35560"},
        {"Smithsonian Astrophysical Observation", "SAO 120339"},
        {"Wilson Evans Batten Catalogue", "WEB 12097"},
    },
    visualMagnitude: 4.99,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.06596003),
        dec: Angle.Degrees(+02.40949613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81069"},
        {"Henry Draper 2", "HD 81069A"},
        {"Henry Draper 3", "HD 81069B"},
        {"Hipparcos Number", "HIP 46064"},
        {"Smithsonian Astrophysical Observation", "SAO 117649"},
        {"Wilson Evans Batten Catalogue", "WEB 8726"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.91137153),
        dec: Angle.Degrees(+02.40996536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49293"},
        {"Hipparcos Number", "HIP 32578"},
        {"Fundamental Katalog 5th Edition", "FK5 258"},
        {"Geneva Identification System", "GEN# +1.00049293"},
        {"Smithsonian Astrophysical Observation", "SAO 114428"},
        {"Wilson Evans Batten Catalogue", "WEB 6572"},
    },
    visualMagnitude: 4.48,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.96523679),
        dec: Angle.Degrees(+02.41218914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103752"},
        {"Hipparcos Number", "HIP 58267"},
        {"Smithsonian Astrophysical Observation", "SAO 119126"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.24284172),
        dec: Angle.Degrees(+02.41223701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77874"},
        {"Hipparcos Number", "HIP 44603"},
        {"Smithsonian Astrophysical Observation", "SAO 117411"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.31421851),
        dec: Angle.Degrees(+02.41413084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39067"},
        {"Hipparcos Number", "HIP 27561"},
        {"Smithsonian Astrophysical Observation", "SAO 113189"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.55476930),
        dec: Angle.Degrees(+02.41485250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16314"},
        {"Hipparcos Number", "HIP 12205"},
        {"Geneva Identification System", "GEN# +1.00016314"},
        {"Smithsonian Astrophysical Observation", "SAO 110645"},
        {"Wilson Evans Batten Catalogue", "WEB 2508"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.28977716),
        dec: Angle.Degrees(+02.41550888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86443"},
        {"Geneva Identification System", "GEN# +0.00203375"},
        {"Smithsonian Astrophysical Observation", "SAO 122621"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.94086793),
        dec: Angle.Degrees(+02.41637518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -365.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 74.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39418"},
        {"Hipparcos Number", "HIP 27781"},
        {"Smithsonian Astrophysical Observation", "SAO 113226"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.18050676),
        dec: Angle.Degrees(+02.41743134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29914"},
        {"Hipparcos Number", "HIP 21936"},
        {"Smithsonian Astrophysical Observation", "SAO 112005"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.73895565),
        dec: Angle.Degrees(+02.41845079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131669"},
        {"Hipparcos Number", "HIP 72988"},
        {"Smithsonian Astrophysical Observation", "SAO 120734"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.73386375),
        dec: Angle.Degrees(+02.41868058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86458"},
        {"Geneva Identification System", "GEN# +0.00203377"},
        {"Smithsonian Astrophysical Observation", "SAO 122625"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.98337047),
        dec: Angle.Degrees(+02.41907538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23875"},
        {"Hipparcos Number", "HIP 17799"},
        {"Smithsonian Astrophysical Observation", "SAO 111432"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.14922031),
        dec: Angle.Degrees(+02.41995093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60490"},
        {"Hipparcos Number", "HIP 36867"},
        {"Smithsonian Astrophysical Observation", "SAO 115652"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.68915636),
        dec: Angle.Degrees(+02.42114318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89127"},
        {"Hipparcos Number", "HIP 50351"},
        {"Smithsonian Astrophysical Observation", "SAO 118197"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.22970511),
        dec: Angle.Degrees(+02.42183173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -175.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98632"},
        {"Hipparcos Number", "HIP 55416"},
        {"Geneva Identification System", "GEN# +1.00098632"},
        {"Smithsonian Astrophysical Observation", "SAO 118801"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.23350726),
        dec: Angle.Degrees(+02.42257680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195729"},
        {"Hipparcos Number", "HIP 101396"},
        {"Smithsonian Astrophysical Observation", "SAO 125930"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.23701952),
        dec: Angle.Degrees(+02.42747291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87623"},
        {"Hipparcos Number", "HIP 49479"},
        {"Geneva Identification System", "GEN# +1.00087623"},
        {"Smithsonian Astrophysical Observation", "SAO 118100"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.53296520),
        dec: Angle.Degrees(+02.42949735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18706"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.10936539),
        dec: Angle.Degrees(+02.43212422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198405"},
        {"Hipparcos Number", "HIP 102832"},
        {"Smithsonian Astrophysical Observation", "SAO 126266"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.49470723),
        dec: Angle.Degrees(+02.43382409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53003"},
        {"Hipparcos Number", "HIP 34026"},
        {"Geneva Identification System", "GEN# +1.00053003"},
        {"Smithsonian Astrophysical Observation", "SAO 114844"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.89405177),
        dec: Angle.Degrees(+02.43731749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197942"},
        {"Hipparcos Number", "HIP 102546"},
        {"Smithsonian Astrophysical Observation", "SAO 126200"},
        {"Wilson Evans Batten Catalogue", "WEB 18578"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.70569388),
        dec: Angle.Degrees(+02.43755630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109590",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109590"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.00752171),
        dec: Angle.Degrees(+02.43787313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209905"},
        {"Hipparcos Number", "HIP 109155"},
        {"Geneva Identification System", "GEN# +1.00209905"},
        {"Smithsonian Astrophysical Observation", "SAO 127303"},
    },
    visualMagnitude: 6.51,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.66197410),
        dec: Angle.Degrees(+02.43949394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140489"},
        {"Hipparcos Number", "HIP 77034"},
        {"Smithsonian Astrophysical Observation", "SAO 121150"},
        {"Wilson Evans Batten Catalogue", "WEB 13064"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.94325991),
        dec: Angle.Degrees(+02.43997495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188403"},
        {"Hipparcos Number", "HIP 97995"},
        {"Smithsonian Astrophysical Observation", "SAO 125225"},
        {"Wilson Evans Batten Catalogue", "WEB 17251"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.73146739),
        dec: Angle.Degrees(+02.44025819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31237"},
        {"Hipparcos Number", "HIP 22797"},
        {"Fundamental Katalog 5th Edition", "FK5 180"},
        {"Geneva Identification System", "GEN# +1.00031237"},
        {"Smithsonian Astrophysical Observation", "SAO 112197"},
        {"Wilson Evans Batten Catalogue", "WEB 4416"},
    },
    visualMagnitude: 3.71,
    bvColour: -0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.56289850),
        dec: Angle.Degrees(+02.44067149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185441"},
        {"Hipparcos Number", "HIP 96653"},
        {"Smithsonian Astrophysical Observation", "SAO 124896"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.76414867),
        dec: Angle.Degrees(+02.44152896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190451"},
        {"Hipparcos Number", "HIP 98893"},
        {"Smithsonian Astrophysical Observation", "SAO 125418"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.22871674),
        dec: Angle.Degrees(+02.44188842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108286"},
        {"Hipparcos Number", "HIP 60713"},
        {"Smithsonian Astrophysical Observation", "SAO 119395"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.63868634),
        dec: Angle.Degrees(+02.44234180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191029"},
        {"Hipparcos Number", "HIP 99149"},
        {"Geneva Identification System", "GEN# +1.00191029"},
        {"Smithsonian Astrophysical Observation", "SAO 125475"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.93283828),
        dec: Angle.Degrees(+02.44301012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17677"},
        {"Hipparcos Number", "HIP 13234"},
        {"Smithsonian Astrophysical Observation", "SAO 110780"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.59412495),
        dec: Angle.Degrees(+02.44371922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221889"},
        {"Hipparcos Number", "HIP 116463"},
        {"Smithsonian Astrophysical Observation", "SAO 128275"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.97911158),
        dec: Angle.Degrees(+02.44556015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12294"},
        {"Geneva Identification System", "GEN# +9.80075031"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.58872976),
        dec: Angle.Degrees(+02.44563619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 355.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
