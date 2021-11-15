using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_82() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27923"},
        {"Hipparcos Number", "HIP 20631"},
        {"Smithsonian Astrophysical Observation", "SAO 76600"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.32984554),
        dec: Angle.Degrees(+23.78804781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344012"},
        {"Hipparcos Number", "HIP 94525"},
        {"Smithsonian Astrophysical Observation", "SAO 86968"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.57851886),
        dec: Angle.Degrees(+23.78846759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62179"},
        {"Hipparcos Number", "HIP 37650"},
        {"Smithsonian Astrophysical Observation", "SAO 79646"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.89532347),
        dec: Angle.Degrees(+23.78941117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194911"},
        {"Hipparcos Number", "HIP 100886"},
        {"Smithsonian Astrophysical Observation", "SAO 88696"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.83696107),
        dec: Angle.Degrees(+23.79050654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197562"},
        {"Hipparcos Number", "HIP 102309"},
        {"Smithsonian Astrophysical Observation", "SAO 89058"},
        {"Wilson Evans Batten Catalogue", "WEB 18523"},
    },
    visualMagnitude: 6.93,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.94860298),
        dec: Angle.Degrees(+23.79111784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1047"},
        {"Hipparcos Number", "HIP 1188"},
        {"Geneva Identification System", "GEN# +1.00001047"},
        {"Smithsonian Astrophysical Observation", "SAO 73837"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.70829037),
        dec: Angle.Degrees(+23.79341488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5444",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 955 AB"},
        {"Henry Draper", "HD 6886"},
        {"Hipparcos Number", "HIP 5444"},
        {"Smithsonian Astrophysical Observation", "SAO 74523"},
        {"Wilson Evans Batten Catalogue", "WEB 1193"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.41310182),
        dec: Angle.Degrees(+23.79428895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20632",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20632"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.33025083),
        dec: Angle.Degrees(+23.79613224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214741"},
        {"Hipparcos Number", "HIP 111895"},
        {"Smithsonian Astrophysical Observation", "SAO 90688"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.98962329),
        dec: Angle.Degrees(+23.79675936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223522"},
        {"Hipparcos Number", "HIP 117534"},
        {"Geneva Identification System", "GEN# +1.00223522"},
        {"Smithsonian Astrophysical Observation", "SAO 91528"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.54295752),
        dec: Angle.Degrees(+23.79686246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25669"},
        {"Hipparcos Number", "HIP 19072"},
        {"Geneva Identification System", "GEN# +1.00025669"},
        {"Smithsonian Astrophysical Observation", "SAO 76436"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.31408592),
        dec: Angle.Degrees(+23.79725619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22319"},
        {"Hipparcos Number", "HIP 16824"},
        {"Smithsonian Astrophysical Observation", "SAO 76021"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.11988800),
        dec: Angle.Degrees(+23.79754451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73973"},
        {"Hipparcos Number", "HIP 42681"},
        {"Smithsonian Astrophysical Observation", "SAO 80363"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.49187828),
        dec: Angle.Degrees(+23.79886130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189732"},
        {"Hipparcos Number", "HIP 98504"},
        {"Celescope Catalog", "CEL 4905"},
        {"Geneva Identification System", "GEN# +1.00189732"},
        {"Smithsonian Astrophysical Observation", "SAO 88061"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.18091703),
        dec: Angle.Degrees(+23.79888759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13344"},
        {"Hipparcos Number", "HIP 10181"},
        {"Geneva Identification System", "GEN# +1.00013344"},
        {"Smithsonian Astrophysical Observation", "SAO 75183"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.72669488),
        dec: Angle.Degrees(+23.79912860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37210"},
        {"Smithsonian Astrophysical Observation", "SAO 79574"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.65592376),
        dec: Angle.Degrees(+23.79927165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153453"},
        {"Hipparcos Number", "HIP 83095"},
        {"Smithsonian Astrophysical Observation", "SAO 84735"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.69490696),
        dec: Angle.Degrees(+23.80010926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131347"},
        {"Hipparcos Number", "HIP 72762"},
        {"Smithsonian Astrophysical Observation", "SAO 83562"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.12183100),
        dec: Angle.Degrees(+23.80130651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182717"},
        {"Hipparcos Number", "HIP 95460"},
        {"Geneva Identification System", "GEN# +1.00182717"},
        {"Smithsonian Astrophysical Observation", "SAO 87182"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.28504266),
        dec: Angle.Degrees(+23.80208178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176252"},
        {"Hipparcos Number", "HIP 93150"},
        {"Cincinnati Publication", "Ci 18 2479"},
        {"Smithsonian Astrophysical Observation", "SAO 86645"},
        {"Wilson Evans Batten Catalogue", "WEB 16139"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.61661364),
        dec: Angle.Degrees(+23.80260186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147056"},
        {"Hipparcos Number", "HIP 79914"},
        {"Smithsonian Astrophysical Observation", "SAO 84296"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.67793256),
        dec: Angle.Degrees(+23.80341328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23632"},
        {"Hipparcos Number", "HIP 17692"},
        {"Celescope Catalog", "CEL 337"},
        {"Geneva Identification System", "GEN# +5.20221380"},
        {"Smithsonian Astrophysical Observation", "SAO 76193"},
        {"Wilson Evans Batten Catalogue", "WEB 3376"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.83731884),
        dec: Angle.Degrees(+23.80345386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101208"},
        {"Hipparcos Number", "HIP 56825"},
        {"Geneva Identification System", "GEN# +1.00101208"},
        {"Smithsonian Astrophysical Observation", "SAO 81920"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.73086647),
        dec: Angle.Degrees(+23.80599744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69918"},
        {"Hipparcos Number", "HIP 40833"},
        {"Smithsonian Astrophysical Observation", "SAO 80105"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.00309017),
        dec: Angle.Degrees(+23.80937036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29621"},
        {"Hipparcos Number", "HIP 21788"},
        {"Geneva Identification System", "GEN# +5.20250110"},
        {"Smithsonian Astrophysical Observation", "SAO 76699"},
        {"Wilson Evans Batten Catalogue", "WEB 4192"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.20428399),
        dec: Angle.Degrees(+23.80974203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103418"},
        {"Hipparcos Number", "HIP 58071"},
        {"Smithsonian Astrophysical Observation", "SAO 82046"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.64277350),
        dec: Angle.Degrees(+23.81107124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69410"},
        {"Geneva Identification System", "GEN# +0.02402700"},
        {"Smithsonian Astrophysical Observation", "SAO 83221"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.17327530),
        dec: Angle.Degrees(+23.81430703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50134"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.51854381),
        dec: Angle.Degrees(+23.81470971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138214"},
        {"Hipparcos Number", "HIP 75875"},
        {"Smithsonian Astrophysical Observation", "SAO 83850"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.47562049),
        dec: Angle.Degrees(+23.81716207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 700"},
        {"Hipparcos Number", "HIP 920"},
        {"Geneva Identification System", "GEN# +1.00000700"},
        {"Smithsonian Astrophysical Observation", "SAO 73796"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.85187794),
        dec: Angle.Degrees(+23.81814771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145677"},
        {"Hipparcos Number", "HIP 79331"},
        {"Renson", "Renson 41260"},
        {"Smithsonian Astrophysical Observation", "SAO 84237"},
        {"Wilson Evans Batten Catalogue", "WEB 13410"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.86358958),
        dec: Angle.Degrees(+23.81990832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200687"},
        {"Hipparcos Number", "HIP 104015"},
        {"Smithsonian Astrophysical Observation", "SAO 89429"},
        {"Wilson Evans Batten Catalogue", "WEB 18947"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.09376012),
        dec: Angle.Degrees(+23.82168567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105487"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.48978026),
        dec: Angle.Degrees(+23.82181199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5360"},
        {"Hipparcos Number", "HIP 4351"},
        {"Smithsonian Astrophysical Observation", "SAO 74371"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.94366351),
        dec: Angle.Degrees(+23.82383119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203484"},
        {"Hipparcos Number", "HIP 105489"},
        {"Geneva Identification System", "GEN# +1.00203484"},
        {"Smithsonian Astrophysical Observation", "SAO 89651"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.49121627),
        dec: Angle.Degrees(+23.82520475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219937"},
        {"Hipparcos Number", "HIP 115172"},
        {"Fundamental Katalog 5th Edition", "FK5 6063"},
        {"Smithsonian Astrophysical Observation", "SAO 91173"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.92249631),
        dec: Angle.Degrees(+23.82534619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113406"},
        {"Hipparcos Number", "HIP 63692"},
        {"Geneva Identification System", "GEN# +1.00113406"},
        {"Smithsonian Astrophysical Observation", "SAO 82627"},
        {"Wilson Evans Batten Catalogue", "WEB 11268"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.79348162),
        dec: Angle.Degrees(+23.82656699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164214"},
        {"Hipparcos Number", "HIP 88054"},
        {"Smithsonian Astrophysical Observation", "SAO 85606"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.76340142),
        dec: Angle.Degrees(+23.82859519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241931"},
        {"Hipparcos Number", "HIP 24487"},
        {"Smithsonian Astrophysical Observation", "SAO 77053"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.81270433),
        dec: Angle.Degrees(+23.83051822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62626"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.48533942),
        dec: Angle.Degrees(+23.83068781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50432"},
        {"Smithsonian Astrophysical Observation", "SAO 81275"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.45987059),
        dec: Angle.Degrees(+23.83187703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87533"},
        {"Hipparcos Number", "HIP 49478"},
        {"Smithsonian Astrophysical Observation", "SAO 81180"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.53238209),
        dec: Angle.Degrees(+23.83466374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61289"},
    },
    visualMagnitude: 10.71,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.38367086),
        dec: Angle.Degrees(+23.83511656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -412.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61671"},
        {"Smithsonian Astrophysical Observation", "SAO 82412"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.63303216),
        dec: Angle.Degrees(+23.83542730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60963"},
        {"Hipparcos Number", "HIP 37144"},
        {"Geneva Identification System", "GEN# +1.00060963"},
        {"Smithsonian Astrophysical Observation", "SAO 79561"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.48720390),
        dec: Angle.Degrees(+23.83619686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31692"},
        {"Hipparcos Number", "HIP 23150"},
        {"Smithsonian Astrophysical Observation", "SAO 76869"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.71681254),
        dec: Angle.Degrees(+23.83669689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212959"},
        {"Hipparcos Number", "HIP 110857"},
        {"Geneva Identification System", "GEN# +1.00212959"},
        {"Smithsonian Astrophysical Observation", "SAO 90521"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.90156047),
        dec: Angle.Degrees(+23.83760386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63843"},
        {"Smithsonian Astrophysical Observation", "SAO 82639"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.26520839),
        dec: Angle.Degrees(+23.84012043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70715"},
        {"Cincinnati Publication", "Ci 20 860"},
        {"Geneva Identification System", "GEN# +0.02402735"},
        {"Wilson Evans Batten Catalogue", "WEB 12255"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.93884214),
        dec: Angle.Degrees(+23.84065941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -517.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97602"},
        {"Hipparcos Number", "HIP 54871"},
        {"Geneva Identification System", "GEN# +1.00097602"},
        {"Smithsonian Astrophysical Observation", "SAO 81726"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.52538966),
        dec: Angle.Degrees(+23.84287750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221493"},
        {"Hipparcos Number", "HIP 116187"},
        {"Smithsonian Astrophysical Observation", "SAO 91333"},
    },
    visualMagnitude: 6.41,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.12096374),
        dec: Angle.Degrees(+23.84367517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205011"},
        {"Hipparcos Number", "HIP 106306"},
        {"Geneva Identification System", "GEN# +1.00205011"},
        {"Smithsonian Astrophysical Observation", "SAO 89782"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.95894197),
        dec: Angle.Degrees(+23.84516195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176213"},
        {"Hipparcos Number", "HIP 93127"},
        {"Cincinnati Publication", "Ci 18 2476"},
        {"Smithsonian Astrophysical Observation", "SAO 86638"},
        {"Wilson Evans Batten Catalogue", "WEB 16135"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.57556619),
        dec: Angle.Degrees(+23.84559507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214930"},
        {"Hipparcos Number", "HIP 112022"},
        {"Geneva Identification System", "GEN# +1.00214930"},
        {"Smithsonian Astrophysical Observation", "SAO 90709"},
        {"Wilson Evans Batten Catalogue", "WEB 19997"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.35724611),
        dec: Angle.Degrees(+23.84661147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18029"},
        {"Hipparcos Number", "HIP 13547"},
        {"Smithsonian Astrophysical Observation", "SAO 75628"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.61475258),
        dec: Angle.Degrees(+23.84722176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342763"},
        {"Hipparcos Number", "HIP 91510"},
        {"Smithsonian Astrophysical Observation", "SAO 86296"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.93532654),
        dec: Angle.Degrees(+23.84734546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17923",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2795 A"},
        {"Henry Draper", "HD 23964"},
        {"Henry Draper 2", "HD 23964A"},
        {"Hipparcos Number", "HIP 17923"},
        {"Celescope Catalog", "CEL 367"},
        {"Renson", "Renson 6140"},
        {"Smithsonian Astrophysical Observation", "SAO 76251"},
        {"Wilson Evans Batten Catalogue", "WEB 3451"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.49184638),
        dec: Angle.Degrees(+23.84880339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73495"},
        {"Smithsonian Astrophysical Observation", "SAO 83619"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.32516882),
        dec: Angle.Degrees(+23.85067954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8146"},
        {"Smithsonian Astrophysical Observation", "SAO 74897"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.18782304),
        dec: Angle.Degrees(+23.85135190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179185"},
        {"Hipparcos Number", "HIP 94204"},
        {"Geneva Identification System", "GEN# +1.00179185"},
        {"Smithsonian Astrophysical Observation", "SAO 86894"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.67584452),
        dec: Angle.Degrees(+23.85161151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69197"},
        {"Geneva Identification System", "GEN# +0.02402694"},
        {"Smithsonian Astrophysical Observation", "SAO 83200"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.49380158),
        dec: Angle.Degrees(+23.85285585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84109"},
        {"Smithsonian Astrophysical Observation", "SAO 84903"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.91994294),
        dec: Angle.Degrees(+23.85362558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116706"},
        {"Hipparcos Number", "HIP 65466"},
        {"Fundamental Katalog 5th Edition", "FK5 3072"},
        {"Geneva Identification System", "GEN# +1.00116706"},
        {"Smithsonian Astrophysical Observation", "SAO 82825"},
        {"Wilson Evans Batten Catalogue", "WEB 11552"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.27785348),
        dec: Angle.Degrees(+23.85443816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207265"},
        {"Hipparcos Number", "HIP 107571"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.80001610),
        dec: Angle.Degrees(+23.85446011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82830"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.89756035),
        dec: Angle.Degrees(+23.85477586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82523"},
    },
    visualMagnitude: 12.34,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.99980689),
        dec: Angle.Degrees(+23.85612917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 322.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -336.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203344"},
        {"Hipparcos Number", "HIP 105411"},
        {"Fundamental Katalog 5th Edition", "FK5 3704"},
        {"Geneva Identification System", "GEN# +1.00203344"},
        {"Smithsonian Astrophysical Observation", "SAO 89640"},
        {"Wilson Evans Batten Catalogue", "WEB 19146"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.26766229),
        dec: Angle.Degrees(+23.85625829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181211"},
        {"Hipparcos Number", "HIP 94889"},
        {"Geneva Identification System", "GEN# +1.00181211"},
        {"Smithsonian Astrophysical Observation", "SAO 87056"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.65735576),
        dec: Angle.Degrees(+23.85635947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184943"},
        {"Hipparcos Number", "HIP 96397"},
        {"Geneva Identification System", "GEN# +1.00184943"},
        {"Smithsonian Astrophysical Observation", "SAO 87420"},
        {"Wilson Evans Batten Catalogue", "WEB 16906"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.98387500),
        dec: Angle.Degrees(+23.85642995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55801"},
        {"Hipparcos Number", "HIP 35099"},
        {"Geneva Identification System", "GEN# +1.00055801"},
        {"Smithsonian Astrophysical Observation", "SAO 79214"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.87353356),
        dec: Angle.Degrees(+23.85663232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23822"},
        {"Hipparcos Number", "HIP 17832"},
        {"Celescope Catalog", "CEL 352"},
        {"Geneva Identification System", "GEN# +5.20222087"},
        {"Smithsonian Astrophysical Observation", "SAO 76225"},
        {"Wilson Evans Batten Catalogue", "WEB 3423"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.23712973),
        dec: Angle.Degrees(+23.85727243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74520"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.41543026),
        dec: Angle.Degrees(+23.85781985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67990"},
        {"Smithsonian Astrophysical Observation", "SAO 83075"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.84741703),
        dec: Angle.Degrees(+23.85904767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85241"},
        {"Hipparcos Number", "HIP 48315"},
        {"Smithsonian Astrophysical Observation", "SAO 81045"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.74274114),
        dec: Angle.Degrees(+23.85985305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43053"},
        {"Smithsonian Astrophysical Observation", "SAO 80411"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.57035470),
        dec: Angle.Degrees(+23.86002467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170650"},
        {"Hipparcos Number", "HIP 90637"},
        {"Geneva Identification System", "GEN# +1.00170650"},
        {"Smithsonian Astrophysical Observation", "SAO 86115"},
        {"Wilson Evans Batten Catalogue", "WEB 15519"},
    },
    visualMagnitude: 5.87,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.39879328),
        dec: Angle.Degrees(+23.86620645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219399"},
        {"Hipparcos Number", "HIP 114806"},
        {"Geneva Identification System", "GEN# +1.00219399"},
        {"Smithsonian Astrophysical Observation", "SAO 91124"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.83866269),
        dec: Angle.Degrees(+23.86829101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15360"},
        {"Hipparcos Number", "HIP 11547"},
        {"Smithsonian Astrophysical Observation", "SAO 75392"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.20043105),
        dec: Angle.Degrees(+23.87053234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285105"},
        {"Hipparcos Number", "HIP 23460"},
        {"Smithsonian Astrophysical Observation", "SAO 76913"},
        {"New General Catalogue", "NGC 1750 326"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.63610176),
        dec: Angle.Degrees(+23.87105847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26116"},
        {"Hipparcos Number", "HIP 19361"},
        {"Geneva Identification System", "GEN# +1.00026116"},
        {"Smithsonian Astrophysical Observation", "SAO 76474"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.21549926),
        dec: Angle.Degrees(+23.87116504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56239"},
        {"Geneva Identification System", "GEN# +0.02402364"},
        {"Smithsonian Astrophysical Observation", "SAO 81867"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.93359269),
        dec: Angle.Degrees(+23.87126619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248291"},
        {"Hipparcos Number", "HIP 27649"},
        {"Smithsonian Astrophysical Observation", "SAO 77634"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.79919603),
        dec: Angle.Degrees(+23.87286888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10667",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1749 AB"},
        {"Henry Draper", "HD 14066"},
        {"Hipparcos Number", "HIP 10667"},
        {"Smithsonian Astrophysical Observation", "SAO 75263"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.31553031),
        dec: Angle.Degrees(+23.87356013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223436"},
        {"Hipparcos Number", "HIP 117484"},
        {"Fundamental Katalog 5th Edition", "FK5 6110"},
        {"Geneva Identification System", "GEN# +1.00223436"},
        {"Smithsonian Astrophysical Observation", "SAO 91517"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.33897299),
        dec: Angle.Degrees(+23.87455257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7811"},
        {"Hipparcos Number", "HIP 6091"},
        {"Smithsonian Astrophysical Observation", "SAO 74619"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.55133984),
        dec: Angle.Degrees(+23.87643897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49842",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7669 AB"},
        {"Henry Draper", "HD 88179"},
        {"Hipparcos Number", "HIP 49842"},
        {"Smithsonian Astrophysical Observation", "SAO 81219"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.65301947),
        dec: Angle.Degrees(+23.88158343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163546"},
        {"Hipparcos Number", "HIP 87762"},
        {"Smithsonian Astrophysical Observation", "SAO 85549"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.91838683),
        dec: Angle.Degrees(+23.88482378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107254",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15259 AB"},
        {"Henry Draper", "HD 206719"},
        {"Hipparcos Number", "HIP 107254"},
        {"Smithsonian Astrophysical Observation", "SAO 89926"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.85828502),
        dec: Angle.Degrees(+23.88484028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185838"},
        {"Hipparcos Number", "HIP 96767"},
        {"Geneva Identification System", "GEN# +1.00185838"},
        {"Smithsonian Astrophysical Observation", "SAO 87535"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.04861193),
        dec: Angle.Degrees(+23.88498442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 262696"},
        {"Hipparcos Number", "HIP 32266"},
        {"Smithsonian Astrophysical Observation", "SAO 78687"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.05206825),
        dec: Angle.Degrees(+23.88566953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3428"},
        {"Geneva Identification System", "GEN# +0.02300097"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.92235496),
        dec: Angle.Degrees(+23.88575655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341555"},
        {"Hipparcos Number", "HIP 88537"},
        {"Smithsonian Astrophysical Observation", "SAO 85708"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.18839283),
        dec: Angle.Degrees(+23.88681388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188895"},
        {"Hipparcos Number", "HIP 98131"},
        {"Smithsonian Astrophysical Observation", "SAO 87956"},
        {"Wilson Evans Batten Catalogue", "WEB 17295"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.15739176),
        dec: Angle.Degrees(+23.88854620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114285"},
        {"Hipparcos Number", "HIP 64182"},
        {"Geneva Identification System", "GEN# +1.00114285"},
        {"Smithsonian Astrophysical Observation", "SAO 82679"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.31390339),
        dec: Angle.Degrees(+23.89304510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241511"},
        {"Hipparcos Number", "HIP 24283"},
        {"Geneva Identification System", "GEN# +1.00241511"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.17438551),
        dec: Angle.Degrees(+23.89358436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216046"},
        {"Hipparcos Number", "HIP 112689"},
        {"Smithsonian Astrophysical Observation", "SAO 90808"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.31254026),
        dec: Angle.Degrees(+23.89410397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346992"},
        {"Hipparcos Number", "HIP 101743"},
    },
    visualMagnitude: 11.79,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.32074797),
        dec: Angle.Degrees(+23.89532950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174435"},
        {"Hipparcos Number", "HIP 92379"},
        {"Geneva Identification System", "GEN# +1.00174435"},
        {"Smithsonian Astrophysical Observation", "SAO 86471"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.38547737),
        dec: Angle.Degrees(+23.89716510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87080",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87080"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.91044599),
        dec: Angle.Degrees(+23.89864068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69477"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.35679532),
        dec: Angle.Degrees(+23.90103640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283066"},
        {"Hipparcos Number", "HIP 18018"},
        {"Wilson Evans Batten Catalogue", "WEB 3472"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.76257314),
        dec: Angle.Degrees(+23.90376782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101728"},
        {"Hipparcos Number", "HIP 57112"},
        {"Smithsonian Astrophysical Observation", "SAO 81950"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.62635023),
        dec: Angle.Degrees(+23.90635912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1785"},
        {"Geneva Identification System", "GEN# +0.02300046"},
        {"Smithsonian Astrophysical Observation", "SAO 73935"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.67386399),
        dec: Angle.Degrees(+23.90977628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130948"},
        {"Henry Draper 2", "HD 130948A"},
        {"Hipparcos Number", "HIP 72567"},
        {"Fundamental Katalog 5th Edition", "FK5 3172"},
        {"Geneva Identification System", "GEN# +1.00130948"},
        {"Smithsonian Astrophysical Observation", "SAO 83553"},
        {"Wilson Evans Batten Catalogue", "WEB 12476"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.56549508),
        dec: Angle.Degrees(+23.91176538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39235",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6518 AB"},
        {"Henry Draper", "HD 65823"},
        {"Hipparcos Number", "HIP 39235"},
        {"Smithsonian Astrophysical Observation", "SAO 79868"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.37622385),
        dec: Angle.Degrees(+23.91277163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22281"},
        {"Hipparcos Number", "HIP 16784"},
        {"Smithsonian Astrophysical Observation", "SAO 76015"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.99993843),
        dec: Angle.Degrees(+23.91414195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75621",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9641 AB"},
        {"Hipparcos Number", "HIP 75621"},
        {"Smithsonian Astrophysical Observation", "SAO 83827"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.77488089),
        dec: Angle.Degrees(+23.91541331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192023"},
        {"Hipparcos Number", "HIP 99534"},
        {"Smithsonian Astrophysical Observation", "SAO 88337"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.00924182),
        dec: Angle.Degrees(+23.91912172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159331"},
        {"Hipparcos Number", "HIP 85891"},
        {"Smithsonian Astrophysical Observation", "SAO 85199"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.28743862),
        dec: Angle.Degrees(+23.92065637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204757"},
        {"Hipparcos Number", "HIP 106160"},
        {"Smithsonian Astrophysical Observation", "SAO 89756"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.55259140),
        dec: Angle.Degrees(+23.92490549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108123"},
        {"Hipparcos Number", "HIP 60599"},
        {"Geneva Identification System", "GEN# +5.21110113"},
        {"Smithsonian Astrophysical Observation", "SAO 82297"},
        {"Wilson Evans Batten Catalogue", "WEB 10778"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.31280365),
        dec: Angle.Degrees(+23.92630174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39078"},
        {"Hipparcos Number", "HIP 27652"},
        {"Renson", "Renson 10499"},
        {"Smithsonian Astrophysical Observation", "SAO 77636"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.82111004),
        dec: Angle.Degrees(+23.92636327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58522"},
        {"Hipparcos Number", "HIP 36161"},
        {"Fundamental Katalog 5th Edition", "FK5 4669"},
        {"Smithsonian Astrophysical Observation", "SAO 79389"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74292041),
        dec: Angle.Degrees(+23.92769358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152613"},
        {"Hipparcos Number", "HIP 82628"},
        {"Smithsonian Astrophysical Observation", "SAO 84670"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.37138512),
        dec: Angle.Degrees(+23.92772370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197021"},
        {"Hipparcos Number", "HIP 101995"},
        {"Smithsonian Astrophysical Observation", "SAO 88983"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.04709324),
        dec: Angle.Degrees(+23.92853961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40788"},
        {"Hipparcos Number", "HIP 28597"},
        {"Geneva Identification System", "GEN# +1.00040788"},
        {"Renson", "Renson 10913"},
        {"Smithsonian Astrophysical Observation", "SAO 77868"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.53920118),
        dec: Angle.Degrees(+23.92982204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57539"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.89405602),
        dec: Angle.Degrees(+24.01646775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169030"},
        {"Hipparcos Number", "HIP 89994"},
        {"Smithsonian Astrophysical Observation", "SAO 85968"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.43647692),
        dec: Angle.Degrees(+23.93054090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344456"},
        {"Hipparcos Number", "HIP 95928"},
        {"Geneva Identification System", "GEN# +1.00344456"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.63326852),
        dec: Angle.Degrees(+23.93097901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60353"},
        {"Hipparcos Number", "HIP 36887"},
        {"Geneva Identification System", "GEN# +1.00060353"},
        {"Smithsonian Astrophysical Observation", "SAO 79524"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.75618231),
        dec: Angle.Degrees(+23.93149038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223175"},
        {"Hipparcos Number", "HIP 117312"},
        {"Smithsonian Astrophysical Observation", "SAO 91486"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.80933060),
        dec: Angle.Degrees(+23.93192900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118361"},
        {"Hipparcos Number", "HIP 66357"},
        {"Geneva Identification System", "GEN# +1.00118361"},
        {"Smithsonian Astrophysical Observation", "SAO 82893"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.02549801),
        dec: Angle.Degrees(+23.93399000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111680",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16116 AB"},
        {"Hipparcos Number", "HIP 111680"},
        {"Geneva Identification System", "GEN# +0.02304575J"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.36261193),
        dec: Angle.Degrees(+23.93791904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71603"},
        {"Smithsonian Astrophysical Observation", "SAO 83449"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.65999480),
        dec: Angle.Degrees(+23.93804287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108588",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15525 AB"},
        {"Henry Draper", "HD 209026"},
        {"Hipparcos Number", "HIP 108588"},
        {"Smithsonian Astrophysical Observation", "SAO 90155"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.95665455),
        dec: Angle.Degrees(+23.94093224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165373"},
        {"Hipparcos Number", "HIP 88528"},
        {"Geneva Identification System", "GEN# +1.00165373"},
        {"Smithsonian Astrophysical Observation", "SAO 85706"},
        {"Wilson Evans Batten Catalogue", "WEB 14989"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.16749339),
        dec: Angle.Degrees(+23.94217079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186745"},
        {"Henry Draper 2", "HD 186746"},
        {"Hipparcos Number", "HIP 97209"},
        {"Geneva Identification System", "GEN# +1.00186745"},
        {"Geneva Identification System 2", "GEN# +1.00186746"},
        {"Smithsonian Astrophysical Observation", "SAO 87671"},
        {"Wilson Evans Batten Catalogue", "WEB 17066"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.35146026),
        dec: Angle.Degrees(+23.94289495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104180"},
        {"Hipparcos Number", "HIP 58511"},
        {"Smithsonian Astrophysical Observation", "SAO 82091"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.98830558),
        dec: Angle.Degrees(+23.94482889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70825"},
        {"Hipparcos Number", "HIP 41244"},
        {"Geneva Identification System", "GEN# +1.00070825"},
        {"Smithsonian Astrophysical Observation", "SAO 80165"},
        {"Wilson Evans Batten Catalogue", "WEB 7979"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.23019201),
        dec: Angle.Degrees(+23.94533900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106714"},
        {"Hipparcos Number", "HIP 59847"},
        {"Fundamental Katalog 5th Edition", "FK5 2982"},
        {"Geneva Identification System", "GEN# +5.21110039"},
        {"Smithsonian Astrophysical Observation", "SAO 82211"},
        {"Wilson Evans Batten Catalogue", "WEB 10634"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.08564668),
        dec: Angle.Degrees(+23.94542332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17608",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Merope"},
        {"Henry Draper", "HD 23480"},
        {"Hipparcos Number", "HIP 17608"},
        {"Celescope Catalog", "CEL 331"},
        {"Geneva Identification System", "GEN# +5.20220980"},
        {"Smithsonian Astrophysical Observation", "SAO 76172"},
        {"Wilson Evans Batten Catalogue", "WEB 3354"},
    },
    visualMagnitude: 4.14,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.58150135),
        dec: Angle.Degrees(+23.94846207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121955"},
        {"Hipparcos Number", "HIP 68243"},
        {"Smithsonian Astrophysical Observation", "SAO 83100"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.55911469),
        dec: Angle.Degrees(+23.94853739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23068",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3557 A"},
        {"Henry Draper", "HD 31553"},
        {"Hipparcos Number", "HIP 23068"},
        {"Geneva Identification System", "GEN# +1.00031553J"},
        {"Smithsonian Astrophysical Observation", "SAO 76858"},
        {"Wilson Evans Batten Catalogue", "WEB 4475"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.45268983),
        dec: Angle.Degrees(+23.94858492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345071"},
        {"Hipparcos Number", "HIP 97759"},
        {"Geneva Identification System", "GEN# +1.00345071"},
        {"Smithsonian Astrophysical Observation", "SAO 87838"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.99803039),
        dec: Angle.Degrees(+23.94861612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341554"},
        {"Hipparcos Number", "HIP 88588"},
        {"Smithsonian Astrophysical Observation", "SAO 85716"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.31313562),
        dec: Angle.Degrees(+23.94937027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80292"},
        {"Smithsonian Astrophysical Observation", "SAO 84341"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.85034570),
        dec: Angle.Degrees(+23.95591573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35879"},
        {"Hipparcos Number", "HIP 25652"},
        {"Smithsonian Astrophysical Observation", "SAO 77194"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.19918387),
        dec: Angle.Degrees(+23.95808586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47752"},
        {"Hipparcos Number", "HIP 32010"},
        {"Cincinnati Publication", "Ci 18 821"},
        {"Geneva Identification System", "GEN# +1.00047752"},
        {"Smithsonian Astrophysical Observation", "SAO 78637"},
        {"Wilson Evans Batten Catalogue", "WEB 6448"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.31491611),
        dec: Angle.Degrees(+23.95838794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 206.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -276.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1696 AB"},
        {"Henry Draper", "HD 13482"},
        {"Hipparcos Number", "HIP 10272"},
        {"Smithsonian Astrophysical Observation", "SAO 75199"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.06387454),
        dec: Angle.Degrees(+23.95859535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113007"},
        {"Geneva Identification System", "GEN# +6.10060242"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.29261404),
        dec: Angle.Degrees(+23.95896641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92526"},
        {"Hipparcos Number", "HIP 52313"},
        {"Geneva Identification System", "GEN# +1.00092526"},
        {"Smithsonian Astrophysical Observation", "SAO 81470"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.33711189),
        dec: Angle.Degrees(+23.96050904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24076"},
        {"Hipparcos Number", "HIP 17999"},
        {"Celescope Catalog", "CEL 370"},
        {"Geneva Identification System", "GEN# +5.20222866"},
        {"Smithsonian Astrophysical Observation", "SAO 76264"},
        {"Wilson Evans Batten Catalogue", "WEB 3470"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.71840155),
        dec: Angle.Degrees(+23.96158078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13801"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.42824116),
        dec: Angle.Degrees(+23.96260494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205602"},
        {"Hipparcos Number", "HIP 106630"},
        {"Smithsonian Astrophysical Observation", "SAO 89828"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.96862213),
        dec: Angle.Degrees(+23.96480396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345957"},
        {"Hipparcos Number", "HIP 99423"},
        {"Geneva Identification System", "GEN# +0.02303912"},
        {"Geneva Identification System 2", "GEN# +1.00345957"},
        {"Smithsonian Astrophysical Observation", "SAO 88301"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.70113138),
        dec: Angle.Degrees(+23.96498874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76733"},
        {"Hipparcos Number", "HIP 44078"},
        {"Smithsonian Astrophysical Observation", "SAO 80547"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.68913598),
        dec: Angle.Degrees(+23.96669976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28273",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28273"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.60590772),
        dec: Angle.Degrees(+23.96760937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346111"},
        {"Hipparcos Number", "HIP 99705"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.48362828),
        dec: Angle.Degrees(+23.96878075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34317"},
        {"Geneva Identification System", "GEN# +0.02401529"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.71734431),
        dec: Angle.Degrees(+23.96946106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43261"},
        {"Hipparcos Number", "HIP 29789"},
        {"Geneva Identification System", "GEN# +1.00043261"},
        {"Smithsonian Astrophysical Observation", "SAO 78168"},
        {"Wilson Evans Batten Catalogue", "WEB 5881"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.07939387),
        dec: Angle.Degrees(+23.97004771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86050"},
        {"Smithsonian Astrophysical Observation", "SAO 85225"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.78412981),
        dec: Angle.Degrees(+23.97005309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90822"},
        {"Hipparcos Number", "HIP 51377"},
        {"Geneva Identification System", "GEN# +1.00090822"},
        {"Smithsonian Astrophysical Observation", "SAO 81379"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.39992184),
        dec: Angle.Degrees(+23.97076925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154791"},
        {"Hipparcos Number", "HIP 83714"},
        {"Smithsonian Astrophysical Observation", "SAO 84844"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.64384548),
        dec: Angle.Degrees(+23.97183394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343780"},
        {"Hipparcos Number", "HIP 93980"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.02682129),
        dec: Angle.Degrees(+23.97277668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52773"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.85040791),
        dec: Angle.Degrees(+23.97398772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9472"},
        {"Hipparcos Number", "HIP 7244"},
        {"Geneva Identification System", "GEN# +1.00009472"},
        {"Smithsonian Astrophysical Observation", "SAO 74789"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.32927984),
        dec: Angle.Degrees(+23.97550045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182380"},
        {"Hipparcos Number", "HIP 95312"},
        {"Geneva Identification System", "GEN# +1.00182380"},
        {"Smithsonian Astrophysical Observation", "SAO 87146"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.87336864),
        dec: Angle.Degrees(+23.97587433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213462"},
        {"Hipparcos Number", "HIP 111159"},
        {"Smithsonian Astrophysical Observation", "SAO 90564"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.80411685),
        dec: Angle.Degrees(+23.97602888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72544"},
        {"Hipparcos Number", "HIP 42053"},
        {"Smithsonian Astrophysical Observation", "SAO 80256"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.57893462),
        dec: Angle.Degrees(+23.97657488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205553"},
        {"Hipparcos Number", "HIP 106611"},
        {"Smithsonian Astrophysical Observation", "SAO 89820"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.89248963),
        dec: Angle.Degrees(+23.97758616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53317"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.57424065),
        dec: Angle.Degrees(+23.97877542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86857"},
        {"Hipparcos Number", "HIP 49153"},
        {"Smithsonian Astrophysical Observation", "SAO 81149"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.47099162),
        dec: Angle.Degrees(+23.98124791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107936"},
        {"Hipparcos Number", "HIP 60489"},
        {"Geneva Identification System", "GEN# +5.21110103"},
        {"Smithsonian Astrophysical Observation", "SAO 82287"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.01363544),
        dec: Angle.Degrees(+23.98247963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283970"},
        {"Hipparcos Number", "HIP 22801"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.57058172),
        dec: Angle.Degrees(+23.98290155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2060",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 353 AB"},
        {"Hipparcos Number", "HIP 2060"},
        {"Smithsonian Astrophysical Observation", "SAO 73981"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.52250883),
        dec: Angle.Degrees(+23.98338816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128425"},
        {"Hipparcos Number", "HIP 71415"},
        {"Smithsonian Astrophysical Observation", "SAO 83429"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.06501303),
        dec: Angle.Degrees(+23.98403143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11033"},
        {"Hipparcos Number", "HIP 8443"},
        {"Geneva Identification System", "GEN# +1.00011033"},
        {"Smithsonian Astrophysical Observation", "SAO 74947"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.21476365),
        dec: Angle.Degrees(+23.98517953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215774"},
        {"Hipparcos Number", "HIP 112495"},
        {"Geneva Identification System", "GEN# +1.00215774"},
        {"Smithsonian Astrophysical Observation", "SAO 90787"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.80417042),
        dec: Angle.Degrees(+23.98521329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148997"},
        {"Hipparcos Number", "HIP 80886"},
        {"Geneva Identification System", "GEN# +1.00148997"},
        {"Smithsonian Astrophysical Observation", "SAO 84420"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.74605351),
        dec: Angle.Degrees(+23.98561235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42871"},
        {"Hipparcos Number", "HIP 29589"},
        {"Smithsonian Astrophysical Observation", "SAO 78121"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.53722324),
        dec: Angle.Degrees(+23.98649452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19786"},
        {"Hipparcos Number", "HIP 14847"},
        {"Smithsonian Astrophysical Observation", "SAO 75783"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.93482779),
        dec: Angle.Degrees(+23.98709429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44108"},
        {"Hipparcos Number", "HIP 30178"},
        {"Smithsonian Astrophysical Observation", "SAO 78258"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.24791268),
        dec: Angle.Degrees(+23.98757850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133287"},
        {"Hipparcos Number", "HIP 73629"},
        {"Smithsonian Astrophysical Observation", "SAO 83631"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.75636921),
        dec: Angle.Degrees(+23.98946239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29405"},
    },
    visualMagnitude: 10.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.94760753),
        dec: Angle.Degrees(+23.99158539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49628"},
        {"Geneva Identification System", "GEN# +0.02402183"},
        {"Wilson Evans Batten Catalogue", "WEB 9152"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.93112635),
        dec: Angle.Degrees(+23.99177951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341794"},
        {"Hipparcos Number", "HIP 89493"},
        {"Smithsonian Astrophysical Observation", "SAO 85871"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.94648256),
        dec: Angle.Degrees(+23.99239526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222624"},
        {"Hipparcos Number", "HIP 116933"},
        {"Geneva Identification System", "GEN# +1.00222624"},
        {"Smithsonian Astrophysical Observation", "SAO 91429"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.53830755),
        dec: Angle.Degrees(+23.99299310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42816"},
        {"Smithsonian Astrophysical Observation", "SAO 80381"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.86448650),
        dec: Angle.Degrees(+23.99353768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85099"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.88505925),
        dec: Angle.Degrees(+23.99506890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163840"},
        {"Hipparcos Number", "HIP 87895"},
        {"Geneva Identification System", "GEN# +1.00163840"},
        {"Smithsonian Astrophysical Observation", "SAO 85575"},
        {"Wilson Evans Batten Catalogue", "WEB 14839"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.30973653),
        dec: Angle.Degrees(+23.99571002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167783"},
        {"Hipparcos Number", "HIP 89491"},
        {"Smithsonian Astrophysical Observation", "SAO 85869"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.94125613),
        dec: Angle.Degrees(+23.99601461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103933",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14589 A"},
        {"Henry Draper", "HD 200563"},
        {"Hipparcos Number", "HIP 103933"},
        {"Smithsonian Astrophysical Observation", "SAO 89414"},
        {"Wilson Evans Batten Catalogue", "WEB 18926"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.87408728),
        dec: Angle.Degrees(+23.99628729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31137"},
        {"Hipparcos Number", "HIP 22792"},
        {"Geneva Identification System", "GEN# +1.00031137"},
        {"Smithsonian Astrophysical Observation", "SAO 76820"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.55402608),
        dec: Angle.Degrees(+23.99890453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59600"},
        {"Hipparcos Number", "HIP 36603"},
        {"Smithsonian Astrophysical Observation", "SAO 79470"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.91330469),
        dec: Angle.Degrees(+23.99987877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214398"},
        {"Hipparcos Number", "HIP 111694"},
        {"Fundamental Katalog 5th Edition", "FK5 3813"},
        {"Geneva Identification System", "GEN# +1.00214398"},
        {"Smithsonian Astrophysical Observation", "SAO 90655"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.38902331),
        dec: Angle.Degrees(+24.00136892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165669"},
        {"Hipparcos Number", "HIP 88672"},
        {"Smithsonian Astrophysical Observation", "SAO 85730"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.53523316),
        dec: Angle.Degrees(+24.00144726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185058"},
        {"Hipparcos Number", "HIP 96443"},
        {"Geneva Identification System", "GEN# +1.00185058J"},
        {"Smithsonian Astrophysical Observation", "SAO 87443"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.12262876),
        dec: Angle.Degrees(+24.00304594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91076"},
        {"Hipparcos Number", "HIP 51513"},
        {"Smithsonian Astrophysical Observation", "SAO 81393"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.81005035),
        dec: Angle.Degrees(+24.00528185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50767"},
        {"Hipparcos Number", "HIP 33300"},
        {"Geneva Identification System", "GEN# +1.00050767"},
        {"Smithsonian Astrophysical Observation", "SAO 78870"},
    },
    visualMagnitude: 7.77,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.90499073),
        dec: Angle.Degrees(+24.00803306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114060"},
        {"Hipparcos Number", "HIP 64057"},
        {"Cincinnati Publication", "Ci 18 1684"},
        {"Geneva Identification System", "GEN# +1.00114060A"},
        {"Smithsonian Astrophysical Observation", "SAO 82662"},
        {"Wilson Evans Batten Catalogue", "WEB 11323"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.91614560),
        dec: Angle.Degrees(+24.00945288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -260.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 148.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34303"},
        {"Hipparcos Number", "HIP 24665"},
        {"Smithsonian Astrophysical Observation", "SAO 77082"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.38244981),
        dec: Angle.Degrees(+24.00986204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57198",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8282 A"},
        {"Henry Draper", "HD 101906"},
        {"Hipparcos Number", "HIP 57198"},
        {"Geneva Identification System", "GEN# +1.00101906J"},
        {"Smithsonian Astrophysical Observation", "SAO 81958"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.94607903),
        dec: Angle.Degrees(+24.01034897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29745"},
        {"Hipparcos Number", "HIP 21863"},
        {"Geneva Identification System", "GEN# +1.00029745"},
        {"Smithsonian Astrophysical Observation", "SAO 76717"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.51712453),
        dec: Angle.Degrees(+24.01078117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207956"},
        {"Hipparcos Number", "HIP 107960"},
        {"Smithsonian Astrophysical Observation", "SAO 90061"},
        {"Wilson Evans Batten Catalogue", "WEB 19467"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.08620201),
        dec: Angle.Degrees(+24.01237078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3411"},
        {"Hipparcos Number", "HIP 2926"},
        {"Geneva Identification System", "GEN# +1.00003411"},
        {"Smithsonian Astrophysical Observation", "SAO 74148"},
        {"Wilson Evans Batten Catalogue", "WEB 531"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.28000597),
        dec: Angle.Degrees(+24.01424837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74148",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74148"},
        {"Geneva Identification System", "GEN# +0.02402824"},
        {"Wilson Evans Batten Catalogue", "WEB 12667"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.26880802),
        dec: Angle.Degrees(+24.01564830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -469.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1578"},
        {"Smithsonian Astrophysical Observation", "SAO 73893"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.94050065),
        dec: Angle.Degrees(+24.01602585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86132"},
        {"Hipparcos Number", "HIP 48795"},
        {"Smithsonian Astrophysical Observation", "SAO 81103"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.27937527),
        dec: Angle.Degrees(+24.01795425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67226"},
        {"Hipparcos Number", "HIP 39790"},
        {"Smithsonian Astrophysical Observation", "SAO 79961"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.96339609),
        dec: Angle.Degrees(+24.01817251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108942"},
        {"Smithsonian Astrophysical Observation", "SAO 90204"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.07494357),
        dec: Angle.Degrees(+24.01937837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114060B"},
        {"Hipparcos Number", "HIP 64059"},
        {"Geneva Identification System", "GEN# +0.02402540"},
        {"Geneva Identification System 2", "GEN# +1.00114060B"},
        {"Smithsonian Astrophysical Observation", "SAO 82663"},
        {"Wilson Evans Batten Catalogue", "WEB 11325"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.92043059),
        dec: Angle.Degrees(+24.01957388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 146.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40881",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Piautos"},
        {"Henry Draper", "HD 70011"},
        {"Hipparcos Number", "HIP 40881"},
        {"Geneva Identification System", "GEN# +1.00070011"},
        {"Smithsonian Astrophysical Observation", "SAO 80113"},
        {"Wilson Evans Batten Catalogue", "WEB 7928"},
    },
    visualMagnitude: 5.92,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.13395549),
        dec: Angle.Degrees(+24.02235699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 499 A"},
        {"Henry Draper", "HD 3293"},
        {"Hipparcos Number", "HIP 2856"},
        {"Geneva Identification System", "GEN# +1.00003293"},
        {"Smithsonian Astrophysical Observation", "SAO 74134"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.04080060),
        dec: Angle.Degrees(+24.02543793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210956"},
        {"Hipparcos Number", "HIP 109719"},
        {"Geneva Identification System", "GEN# +1.00210956"},
        {"Smithsonian Astrophysical Observation", "SAO 90334"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.35896847),
        dec: Angle.Degrees(+24.02645905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27248"},
        {"Hipparcos Number", "HIP 20139"},
        {"Geneva Identification System", "GEN# +1.00027248"},
        {"Smithsonian Astrophysical Observation", "SAO 76545"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.76732627),
        dec: Angle.Degrees(+24.02798211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32190"},
        {"Hipparcos Number", "HIP 23436"},
        {"Geneva Identification System", "GEN# +2.17500228"},
        {"Smithsonian Astrophysical Observation", "SAO 76909"},
        {"Wilson Evans Batten Catalogue", "WEB 4556"},
        {"New General Catalogue", "NGC 1750 228"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.56622059),
        dec: Angle.Degrees(+24.02917035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217263"},
        {"Hipparcos Number", "HIP 113507"},
        {"Geneva Identification System", "GEN# +1.00217263"},
        {"Smithsonian Astrophysical Observation", "SAO 90921"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.81215670),
        dec: Angle.Degrees(+24.03259893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113506"},
    },
    visualMagnitude: 11.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.80771959),
        dec: Angle.Degrees(+24.03301955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15278"},
        {"Smithsonian Astrophysical Observation", "SAO 75837"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.27687382),
        dec: Angle.Degrees(+24.03513554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194135"},
        {"Hipparcos Number", "HIP 100543"},
        {"Smithsonian Astrophysical Observation", "SAO 88613"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.80020331),
        dec: Angle.Degrees(+24.03685070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114008"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.33450490),
        dec: Angle.Degrees(+24.03913239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36819"},
        {"Hipparcos Number", "HIP 26248"},
        {"Fundamental Katalog 5th Edition", "FK5 2415"},
        {"Geneva Identification System", "GEN# +1.00036819"},
        {"Smithsonian Astrophysical Observation", "SAO 77285"},
        {"Wilson Evans Batten Catalogue", "WEB 5142"},
    },
    visualMagnitude: 5.37,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.86300222),
        dec: Angle.Degrees(+24.03963793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158872"},
        {"Hipparcos Number", "HIP 85687"},
        {"Smithsonian Astrophysical Observation", "SAO 85161"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.66621077),
        dec: Angle.Degrees(+24.04134337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46252"},
        {"Hipparcos Number", "HIP 31254"},
        {"Smithsonian Astrophysical Observation", "SAO 78489"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.32709900),
        dec: Angle.Degrees(+24.04147806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99582"},
        {"Hipparcos Number", "HIP 55903"},
        {"Cincinnati Publication", "Ci 18 1408"},
        {"Geneva Identification System", "GEN# +1.00099582A"},
        {"Smithsonian Astrophysical Observation", "SAO 81837"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.88309681),
        dec: Angle.Degrees(+24.04166263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66336"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.92630276),
        dec: Angle.Degrees(+24.04251703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9263"},
        {"Smithsonian Astrophysical Observation", "SAO 75068"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.76661086),
        dec: Angle.Degrees(+24.04361987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75384"},
        {"Fundamental Katalog 5th Edition", "FK5 5362"},
        {"Smithsonian Astrophysical Observation", "SAO 83805"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.06730041),
        dec: Angle.Degrees(+24.04389618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344004"},
        {"Hipparcos Number", "HIP 94600"},
        {"Smithsonian Astrophysical Observation", "SAO 86986"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.77307109),
        dec: Angle.Degrees(+24.04770313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3163",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 562 B"},
        {"Henry Draper", "HD 3743B"},
        {"Hipparcos Number", "HIP 3163"},
        {"Geneva Identification System", "GEN# +1.00003743B"},
        {"Smithsonian Astrophysical Observation", "SAO 74184"},
        {"Wilson Evans Batten Catalogue", "WEB 568"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.08024687),
        dec: Angle.Degrees(+24.04974219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61806"},
        {"Hipparcos Number", "HIP 37517"},
        {"Geneva Identification System", "GEN# +1.00061806"},
        {"Smithsonian Astrophysical Observation", "SAO 79620"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.50106669),
        dec: Angle.Degrees(+24.05049896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344873"},
        {"Hipparcos Number", "HIP 97189"},
        {"Geneva Identification System", "GEN# +1.00344873"},
        {"Smithsonian Astrophysical Observation", "SAO 87666"},
        {"Wilson Evans Batten Catalogue", "WEB 17062"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.30264658),
        dec: Angle.Degrees(+24.05114451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72884"},
        {"Hipparcos Number", "HIP 42184"},
        {"Fundamental Katalog 5th Edition", "FK5 2673"},
        {"Geneva Identification System", "GEN# +1.00072884"},
        {"Smithsonian Astrophysical Observation", "SAO 80275"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.01029831),
        dec: Angle.Degrees(+24.05114695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107202"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.70147247),
        dec: Angle.Degrees(+24.05260571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17847",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Atlas"},
        {"Aitken", "ADS 2786 A"},
        {"Henry Draper", "HD 23850"},
        {"Hipparcos Number", "HIP 17847"},
        {"Celescope Catalog", "CEL 354"},
        {"Fundamental Katalog 5th Edition", "FK5 142"},
        {"Geneva Identification System", "GEN# +5.20222168"},
        {"Renson", "Renson 6100"},
        {"Smithsonian Astrophysical Observation", "SAO 76228"},
        {"Wilson Evans Batten Catalogue", "WEB 3427"},
    },
    visualMagnitude: 3.62,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.29054669),
        dec: Angle.Degrees(+24.05352412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3165",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 562 A"},
        {"Henry Draper", "HD 3743"},
        {"Hipparcos Number", "HIP 3165"},
        {"Geneva Identification System", "GEN# +1.00003743A"},
        {"Smithsonian Astrophysical Observation", "SAO 74185"},
        {"Wilson Evans Batten Catalogue", "WEB 566"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.08240760),
        dec: Angle.Degrees(+24.05388170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174298"},
        {"Hipparcos Number", "HIP 92319"},
        {"Geneva Identification System", "GEN# +1.00174298"},
        {"Smithsonian Astrophysical Observation", "SAO 86459"},
        {"Wilson Evans Batten Catalogue", "WEB 15935"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.23178719),
        dec: Angle.Degrees(+24.05588469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148127"},
        {"Hipparcos Number", "HIP 80435"},
        {"Fundamental Katalog 5th Edition", "FK5 5448"},
        {"Smithsonian Astrophysical Observation", "SAO 84364"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.27810742),
        dec: Angle.Degrees(+24.05657967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76825"},
    },
    visualMagnitude: 10.80,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.28046428),
        dec: Angle.Degrees(+24.05865686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95364"},
        {"Hipparcos Number", "HIP 53851"},
        {"Geneva Identification System", "GEN# +1.00095364"},
        {"Smithsonian Astrophysical Observation", "SAO 81624"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.24588267),
        dec: Angle.Degrees(+24.06595102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35774"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.68920418),
        dec: Angle.Degrees(+24.06673738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5223"},
        {"Hipparcos Number", "HIP 4252"},
        {"Geneva Identification System", "GEN# +1.00005223"},
        {"Smithsonian Astrophysical Observation", "SAO 74353"},
        {"Wilson Evans Batten Catalogue", "WEB 759"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.55631591),
        dec: Angle.Degrees(+24.06711805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83288"},
        {"Hipparcos Number", "HIP 47258"},
        {"Smithsonian Astrophysical Observation", "SAO 80936"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.48455078),
        dec: Angle.Degrees(+24.06741768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1099"},
        {"Hipparcos Number", "HIP 1239"},
        {"Smithsonian Astrophysical Observation", "SAO 73847"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.86065892),
        dec: Angle.Degrees(+24.06974141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212108"},
        {"Hipparcos Number", "HIP 110387"},
        {"Renson", "Renson 58850"},
        {"Smithsonian Astrophysical Observation", "SAO 90442"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.38793322),
        dec: Angle.Degrees(+24.07189406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26212"},
        {"Hipparcos Number", "HIP 19436"},
        {"Geneva Identification System", "GEN# +1.00026212"},
        {"Smithsonian Astrophysical Observation", "SAO 76480"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.43199530),
        dec: Angle.Degrees(+24.07299386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16944"},
        {"Hipparcos Number", "HIP 12730"},
        {"Smithsonian Astrophysical Observation", "SAO 75535"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.90829732),
        dec: Angle.Degrees(+24.07299736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56462"},
        {"Hipparcos Number", "HIP 35344"},
        {"Smithsonian Astrophysical Observation", "SAO 79257"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.51651029),
        dec: Angle.Degrees(+24.07749036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26816"},
        {"Hipparcos Number", "HIP 19853"},
        {"Smithsonian Astrophysical Observation", "SAO 76523"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.85051077),
        dec: Angle.Degrees(+24.07848538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156128"},
        {"Hipparcos Number", "HIP 84357"},
        {"Geneva Identification System", "GEN# +1.00156128"},
        {"Smithsonian Astrophysical Observation", "SAO 84950"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.69956208),
        dec: Angle.Degrees(+24.07924056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247157"},
        {"Hipparcos Number", "HIP 27159"},
        {"Renson", "Renson 10303"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.35768766),
        dec: Angle.Degrees(+24.07925419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188260"},
        {"Henry Draper 2", "HD 188260A"},
        {"Hipparcos Number", "HIP 97886"},
        {"Geneva Identification System", "GEN# +1.00188260"},
        {"Smithsonian Astrophysical Observation", "SAO 87883"},
        {"Wilson Evans Batten Catalogue", "WEB 17223"},
    },
    visualMagnitude: 4.57,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.36533677),
        dec: Angle.Degrees(+24.07952568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 342867"},
        {"Hipparcos Number", "HIP 91879"},
        {"Geneva Identification System", "GEN# +1.00342867"},
        {"Renson", "Renson 48560"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.96332764),
        dec: Angle.Degrees(+24.08120955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72041"},
        {"Hipparcos Number", "HIP 41816"},
        {"Fundamental Katalog 5th Edition", "FK5 2666"},
        {"Geneva Identification System", "GEN# +1.00072041"},
        {"Smithsonian Astrophysical Observation", "SAO 80229"},
        {"Wilson Evans Batten Catalogue", "WEB 8051"},
    },
    visualMagnitude: 5.71,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.87738017),
        dec: Angle.Degrees(+24.08121618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24899"},
        {"Hipparcos Number", "HIP 18559"},
        {"Geneva Identification System", "GEN# +5.20223335"},
        {"Smithsonian Astrophysical Observation", "SAO 76358"},
        {"Wilson Evans Batten Catalogue", "WEB 3579"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.58702872),
        dec: Angle.Degrees(+24.08123216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20457"},
        {"Hipparcos Number", "HIP 15380"},
        {"Smithsonian Astrophysical Observation", "SAO 75850"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.58313464),
        dec: Angle.Degrees(+24.08189714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91148"},
        {"Hipparcos Number", "HIP 51550"},
        {"Geneva Identification System", "GEN# +1.00091148"},
        {"Smithsonian Astrophysical Observation", "SAO 81396"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.93993039),
        dec: Angle.Degrees(+24.08230090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186100"},
        {"Hipparcos Number", "HIP 96886"},
        {"Geneva Identification System", "GEN# +1.00186100"},
        {"Smithsonian Astrophysical Observation", "SAO 87580"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.41244936),
        dec: Angle.Degrees(+24.08411352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47774"},
        {"Hipparcos Number", "HIP 32004"},
        {"Smithsonian Astrophysical Observation", "SAO 78635"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.30288092),
        dec: Angle.Degrees(+24.08428912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72324"},
        {"Hipparcos Number", "HIP 41940"},
        {"Geneva Identification System", "GEN# +1.00072324"},
        {"Smithsonian Astrophysical Observation", "SAO 80245"},
        {"Wilson Evans Batten Catalogue", "WEB 8072"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.25060265),
        dec: Angle.Degrees(+24.08490572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41076"},
    },
    visualMagnitude: 12.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.71127256),
        dec: Angle.Degrees(+24.08567266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36513"},
        {"Geneva Identification System", "GEN# +0.02401676"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.67151030),
        dec: Angle.Degrees(+24.08674785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83375"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.60638554),
        dec: Angle.Degrees(+24.08724652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189067"},
        {"Hipparcos Number", "HIP 98206"},
        {"Fundamental Katalog 5th Edition", "FK5 5759"},
        {"Geneva Identification System", "GEN# +1.00189067"},
        {"Smithsonian Astrophysical Observation", "SAO 87974"},
        {"Wilson Evans Batten Catalogue", "WEB 17320"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.33272084),
        dec: Angle.Degrees(+24.08846018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29859"},
        {"Hipparcos Number", "HIP 21961"},
        {"Geneva Identification System", "GEN# +1.00029859"},
        {"Smithsonian Astrophysical Observation", "SAO 76727"},
        {"Wilson Evans Batten Catalogue", "WEB 4221"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.80728108),
        dec: Angle.Degrees(+24.08896447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207625"},
        {"Hipparcos Number", "HIP 107751"},
        {"Smithsonian Astrophysical Observation", "SAO 90034"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.42807282),
        dec: Angle.Degrees(+24.08913954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205352"},
        {"Hipparcos Number", "HIP 106489"},
        {"Fundamental Katalog 5th Edition", "FK5 5906"},
        {"Geneva Identification System", "GEN# +1.00205352"},
        {"Smithsonian Astrophysical Observation", "SAO 89802"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.53539637),
        dec: Angle.Degrees(+24.09090584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283433"},
        {"Hipparcos Number", "HIP 19459"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.50857693),
        dec: Angle.Degrees(+24.09267849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29312"},
    },
    visualMagnitude: 10.87,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.70921352),
        dec: Angle.Degrees(+24.09311408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217102"},
        {"Hipparcos Number", "HIP 113396"},
        {"Geneva Identification System", "GEN# +1.00217102"},
        {"Smithsonian Astrophysical Observation", "SAO 90901"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.47810155),
        dec: Angle.Degrees(+24.09315531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77183",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77183"},
        {"Smithsonian Astrophysical Observation", "SAO 83990"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.40620254),
        dec: Angle.Degrees(+24.09478117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251363"},
        {"Hipparcos Number", "HIP 28871"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.43111832),
        dec: Angle.Degrees(+24.14517268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111285"},
        {"Hipparcos Number", "HIP 62456"},
        {"Geneva Identification System", "GEN# +1.00111285"},
        {"Smithsonian Astrophysical Observation", "SAO 82500"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.99745390),
        dec: Angle.Degrees(+24.09555974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283964"},
        {"Hipparcos Number", "HIP 22829"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.68730078),
        dec: Angle.Degrees(+24.09634060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186841"},
        {"Hipparcos Number", "HIP 97246"},
        {"Geneva Identification System", "GEN# +1.00186841"},
        {"Smithsonian Astrophysical Observation", "SAO 87685"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.47556194),
        dec: Angle.Degrees(+24.09639745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72348",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9386 AB"},
        {"Henry Draper", "HD 130446"},
        {"Hipparcos Number", "HIP 72348"},
        {"Smithsonian Astrophysical Observation", "SAO 83524"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.91355183),
        dec: Angle.Degrees(+24.09748975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347658"},
        {"Hipparcos Number", "HIP 103152"},
        {"Smithsonian Astrophysical Observation", "SAO 89258"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.49042385),
        dec: Angle.Degrees(+24.10019758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212680"},
        {"Hipparcos Number", "HIP 110698"},
        {"Smithsonian Astrophysical Observation", "SAO 90497"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.42407529),
        dec: Angle.Degrees(+24.10039611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5294"},
        {"Hipparcos Number", "HIP 4290"},
        {"Cincinnati Publication", "Ci 18 120"},
        {"Geneva Identification System", "GEN# +1.00005294"},
        {"Smithsonian Astrophysical Observation", "SAO 74361"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.74745006),
        dec: Angle.Degrees(+24.10070725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346725"},
        {"Hipparcos Number", "HIP 101280"},
        {"Smithsonian Astrophysical Observation", "SAO 88804"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.93479350),
        dec: Angle.Degrees(+24.10260772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219310"},
        {"Hipparcos Number", "HIP 114742"},
        {"Smithsonian Astrophysical Observation", "SAO 91113"},
        {"Wilson Evans Batten Catalogue", "WEB 20343"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.65174653),
        dec: Angle.Degrees(+24.10288514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17702",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alcyone"},
        {"Henry Draper", "HD 23630"},
        {"Hipparcos Number", "HIP 17702"},
        {"Celescope Catalog", "CEL 344"},
        {"Fundamental Katalog 5th Edition", "FK5 139"},
        {"Geneva Identification System", "GEN# +5.20221432"},
        {"Smithsonian Astrophysical Observation", "SAO 76199"},
        {"Wilson Evans Batten Catalogue", "WEB 3382"},
    },
    visualMagnitude: 2.85,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.87110065),
        dec: Angle.Degrees(+24.10524193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19009",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2965 A"},
        {"Henry Draper", "HD 25555"},
        {"Henry Draper 2", "HD 25556"},
        {"Hipparcos Number", "HIP 19009"},
        {"Geneva Identification System", "GEN# +1.00025555"},
        {"Smithsonian Astrophysical Observation", "SAO 76425"},
        {"Wilson Evans Batten Catalogue", "WEB 3655"},
    },
    visualMagnitude: 5.46,
    bvColour: 0.813,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.09030699),
        dec: Angle.Degrees(+24.10602640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2668"},
        {"Hipparcos Number", "HIP 2395"},
        {"Smithsonian Astrophysical Observation", "SAO 74046"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.62313292),
        dec: Angle.Degrees(+24.10632987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243331"},
        {"Hipparcos Number", "HIP 25306"},
        {"Smithsonian Astrophysical Observation", "SAO 77151"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.20003118),
        dec: Angle.Degrees(+24.10642567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174623"},
        {"Hipparcos Number", "HIP 92449"},
        {"Smithsonian Astrophysical Observation", "SAO 86487"},
        {"Wilson Evans Batten Catalogue", "WEB 15973"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.60223494),
        dec: Angle.Degrees(+24.10669045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126100"},
        {"Hipparcos Number", "HIP 70296"},
        {"Fundamental Katalog 5th Edition", "FK5 5272"},
        {"Smithsonian Astrophysical Observation", "SAO 83318"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.74608272),
        dec: Angle.Degrees(+24.10669894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54616"},
        {"Hipparcos Number", "HIP 34640"},
        {"Geneva Identification System", "GEN# +1.00054616"},
        {"Smithsonian Astrophysical Observation", "SAO 79133"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.62347420),
        dec: Angle.Degrees(+24.10842782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108722"},
        {"Hipparcos Number", "HIP 60941"},
        {"Geneva Identification System", "GEN# +5.21110149"},
        {"Smithsonian Astrophysical Observation", "SAO 82333"},
        {"Wilson Evans Batten Catalogue", "WEB 10846"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.36272398),
        dec: Angle.Degrees(+24.10892077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221395"},
        {"Hipparcos Number", "HIP 116117"},
        {"Smithsonian Astrophysical Observation", "SAO 91320"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.92319882),
        dec: Angle.Degrees(+24.11113601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17499",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Electra"},
        {"Henry Draper", "HD 23302"},
        {"Hipparcos Number", "HIP 17499"},
        {"Celescope Catalog", "CEL 316"},
        {"Fundamental Katalog 5th Edition", "FK5 136"},
        {"Geneva Identification System", "GEN# +5.20220468"},
        {"Smithsonian Astrophysical Observation", "SAO 76131"},
        {"Wilson Evans Batten Catalogue", "WEB 3317"},
    },
    visualMagnitude: 3.72,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.21884811),
        dec: Angle.Degrees(+24.11344840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19464",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3033 AB"},
        {"Henry Draper", "HD 283432"},
        {"Hipparcos Number", "HIP 19464"},
    },
    visualMagnitude: 9.55,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.52077961),
        dec: Angle.Degrees(+24.11494016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196740"},
        {"Hipparcos Number", "HIP 101868"},
        {"Geneva Identification System", "GEN# +1.00196740"},
        {"Smithsonian Astrophysical Observation", "SAO 88945"},
        {"Wilson Evans Batten Catalogue", "WEB 18405"},
    },
    visualMagnitude: 5.06,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.63295107),
        dec: Angle.Degrees(+24.11597742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177280"},
        {"Hipparcos Number", "HIP 93533"},
        {"Smithsonian Astrophysical Observation", "SAO 86739"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.75605833),
        dec: Angle.Degrees(+24.11679381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11363"},
        {"Hipparcos Number", "HIP 8718"},
        {"Smithsonian Astrophysical Observation", "SAO 74989"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.04316907),
        dec: Angle.Degrees(+24.11731175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283670"},
        {"Hipparcos Number", "HIP 20866"},
        {"Smithsonian Astrophysical Observation", "SAO 76621"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.08407978),
        dec: Angle.Degrees(+24.11786010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56650"},
        {"Hipparcos Number", "HIP 35429"},
        {"Smithsonian Astrophysical Observation", "SAO 79276"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.71453315),
        dec: Angle.Degrees(+24.11841298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201361"},
        {"Hipparcos Number", "HIP 104350"},
        {"Smithsonian Astrophysical Observation", "SAO 89483"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.10215926),
        dec: Angle.Degrees(+24.11925028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58850",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8405 AB"},
        {"Henry Draper", "HD 104815"},
        {"Hipparcos Number", "HIP 58850"},
        {"Smithsonian Astrophysical Observation", "SAO 82122"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.05024445),
        dec: Angle.Degrees(+24.11946388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343353"},
        {"Hipparcos Number", "HIP 93025"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.26388352),
        dec: Angle.Degrees(+24.12039301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283886"},
        {"Hipparcos Number", "HIP 22536"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.75264196),
        dec: Angle.Degrees(+24.12268380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206775"},
        {"Hipparcos Number", "HIP 107284"},
        {"Smithsonian Astrophysical Observation", "SAO 89932"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.96673652),
        dec: Angle.Degrees(+24.12351105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205142"},
        {"Hipparcos Number", "HIP 106394"},
        {"Geneva Identification System", "GEN# +1.00205142"},
        {"Smithsonian Astrophysical Observation", "SAO 89793"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.23852572),
        dec: Angle.Degrees(+24.12727014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 334.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346589"},
        {"Hipparcos Number", "HIP 100955"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.03264219),
        dec: Angle.Degrees(+24.12799628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55052"},
        {"Hipparcos Number", "HIP 34819"},
        {"Geneva Identification System", "GEN# +1.00055052"},
        {"Smithsonian Astrophysical Observation", "SAO 79162"},
        {"Wilson Evans Batten Catalogue", "WEB 6959"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.10994955),
        dec: Angle.Degrees(+24.12870291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75090"},
        {"Hipparcos Number", "HIP 43242"},
        {"Smithsonian Astrophysical Observation", "SAO 80438"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.14696351),
        dec: Angle.Degrees(+24.12874380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 256138"},
        {"Henry Draper 2", "HD 256139"},
        {"Hipparcos Number", "HIP 30379"},
        {"Smithsonian Astrophysical Observation", "SAO 78304"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.81753033),
        dec: Angle.Degrees(+24.12936439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94341"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.03395364),
        dec: Angle.Degrees(+24.13006036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118824"},
        {"Hipparcos Number", "HIP 66585"},
        {"Geneva Identification System", "GEN# +1.00118824"},
        {"Smithsonian Astrophysical Observation", "SAO 82924"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.73784128),
        dec: Angle.Degrees(+24.13177590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125784"},
        {"Hipparcos Number", "HIP 70150"},
        {"Smithsonian Astrophysical Observation", "SAO 83303"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.30214467),
        dec: Angle.Degrees(+24.13339589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13867",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2246"},
        {"Henry Draper", "HD 18442"},
        {"Hipparcos Number", "HIP 13867"},
        {"Smithsonian Astrophysical Observation", "SAO 75666"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.64995763),
        dec: Angle.Degrees(+24.13379805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48176"},
        {"Hipparcos Number", "HIP 32167"},
        {"Smithsonian Astrophysical Observation", "SAO 78667"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.75199065),
        dec: Angle.Degrees(+24.13633000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17851",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Pleione"},
        {"Henry Draper", "HD 23862"},
        {"Hipparcos Number", "HIP 17851"},
        {"Celescope Catalog", "CEL 356"},
        {"Geneva Identification System", "GEN# +5.20222181"},
        {"Smithsonian Astrophysical Observation", "SAO 76229"},
        {"Wilson Evans Batten Catalogue", "WEB 3429"},
    },
    visualMagnitude: 5.05,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.29668368),
        dec: Angle.Degrees(+24.13682565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42783"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.76181074),
        dec: Angle.Degrees(+24.13722757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345408"},
        {"Hipparcos Number", "HIP 98391"},
        {"Geneva Identification System", "GEN# +1.00345408"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.85935678),
        dec: Angle.Degrees(+24.13865521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3943"},
        {"Hipparcos Number", "HIP 3310"},
        {"Geneva Identification System", "GEN# +1.00003943"},
        {"Smithsonian Astrophysical Observation", "SAO 74207"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.53985449),
        dec: Angle.Degrees(+24.13914928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171260"},
        {"Hipparcos Number", "HIP 90920"},
        {"Geneva Identification System", "GEN# +1.00171260"},
        {"Smithsonian Astrophysical Observation", "SAO 86177"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.20124918),
        dec: Angle.Degrees(+24.14179477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94834"},
        {"Hipparcos Number", "HIP 53545"},
        {"Smithsonian Astrophysical Observation", "SAO 81597"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.31316607),
        dec: Angle.Degrees(+24.14269317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207264"},
        {"Hipparcos Number", "HIP 107566"},
        {"Geneva Identification System", "GEN# +1.00207264"},
        {"Smithsonian Astrophysical Observation", "SAO 89993"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.79094618),
        dec: Angle.Degrees(+24.14501754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71496"},
        {"Hipparcos Number", "HIP 41574"},
        {"Geneva Identification System", "GEN# +1.00071496"},
        {"Smithsonian Astrophysical Observation", "SAO 80204"},
        {"Wilson Evans Batten Catalogue", "WEB 8024"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.15335153),
        dec: Angle.Degrees(+24.14505062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111066"},
        {"Hipparcos Number", "HIP 62349"},
        {"Cincinnati Publication", "Ci 18 1624"},
        {"Geneva Identification System", "GEN# +1.00111066"},
        {"Smithsonian Astrophysical Observation", "SAO 82490"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.63654937),
        dec: Angle.Degrees(+24.14557627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66921"},
        {"Hipparcos Number", "HIP 39686"},
        {"Smithsonian Astrophysical Observation", "SAO 79949"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.65393525),
        dec: Angle.Degrees(+24.14689528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259768"},
        {"Hipparcos Number", "HIP 31388"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.69907782),
        dec: Angle.Degrees(+24.14851555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189731"},
        {"Hipparcos Number", "HIP 98498"},
        {"Geneva Identification System", "GEN# +1.00189731"},
        {"Smithsonian Astrophysical Observation", "SAO 88057"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.16125295),
        dec: Angle.Degrees(+24.14920171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36180"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.76831360),
        dec: Angle.Degrees(+24.15650929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210211"},
        {"Hipparcos Number", "HIP 109281"},
        {"Fundamental Katalog 5th Edition", "FK5 5954"},
        {"Geneva Identification System", "GEN# +1.00210211"},
        {"Smithsonian Astrophysical Observation", "SAO 90260"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.07838971),
        dec: Angle.Degrees(+24.15697509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49622"},
        {"Hipparcos Number", "HIP 32800"},
        {"Smithsonian Astrophysical Observation", "SAO 78786"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.56671849),
        dec: Angle.Degrees(+24.15707607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166301"},
        {"Hipparcos Number", "HIP 88913"},
        {"Geneva Identification System", "GEN# +1.00166301"},
        {"Smithsonian Astrophysical Observation", "SAO 85776"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.24421614),
        dec: Angle.Degrees(+24.15807495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59574"},
        {"Geneva Identification System", "GEN# +0.02402438"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.24183870),
        dec: Angle.Degrees(+24.15851777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121184"},
        {"Hipparcos Number", "HIP 67802"},
        {"Geneva Identification System", "GEN# +1.00121184"},
        {"Smithsonian Astrophysical Observation", "SAO 83060"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.34555915),
        dec: Angle.Degrees(+24.15992483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111727"},
        {"Smithsonian Astrophysical Observation", "SAO 90663"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.47977253),
        dec: Angle.Degrees(+24.16019497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63590"},
        {"Hipparcos Number", "HIP 38287"},
        {"Geneva Identification System", "GEN# +1.00063590"},
        {"Smithsonian Astrophysical Observation", "SAO 79739"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.66569017),
        dec: Angle.Degrees(+24.16104216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113393"},
        {"Hipparcos Number", "HIP 63691"},
        {"Smithsonian Astrophysical Observation", "SAO 82626"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.78947621),
        dec: Angle.Degrees(+24.16145424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31880"},
        {"Hipparcos Number", "HIP 23270"},
        {"Geneva Identification System", "GEN# +1.00031880"},
        {"Smithsonian Astrophysical Observation", "SAO 76885"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.10120150),
        dec: Angle.Degrees(+24.16273906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13522"},
        {"Hipparcos Number", "HIP 10296"},
        {"Geneva Identification System", "GEN# +1.00013522"},
        {"Smithsonian Astrophysical Observation", "SAO 75203"},
        {"Wilson Evans Batten Catalogue", "WEB 2146"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.15630080),
        dec: Angle.Degrees(+24.16779356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104660",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14738 AB"},
        {"Henry Draper", "HD 201889"},
        {"Hipparcos Number", "HIP 104660"},
        {"Cincinnati Publication", "Ci 20 1267"},
        {"Geneva Identification System", "GEN# +1.00201889J"},
        {"Smithsonian Astrophysical Observation", "SAO 89522"},
        {"Wilson Evans Batten Catalogue", "WEB 19041"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.99684502),
        dec: Angle.Degrees(+24.16790023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 438.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 109.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166495"},
        {"Hipparcos Number", "HIP 89004"},
        {"Smithsonian Astrophysical Observation", "SAO 85790"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.48059099),
        dec: Angle.Degrees(+24.16842390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53766"},
        {"Hipparcos Number", "HIP 34351"},
        {"Smithsonian Astrophysical Observation", "SAO 79065"},
        {"Wilson Evans Batten Catalogue", "WEB 6881"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.82050534),
        dec: Angle.Degrees(+24.16849121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132504"},
        {"Hipparcos Number", "HIP 73301"},
        {"Geneva Identification System", "GEN# +1.00132504"},
        {"Smithsonian Astrophysical Observation", "SAO 83603"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.70206701),
        dec: Angle.Degrees(+24.16969652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11580"},
        {"Hipparcos Number", "HIP 8871"},
        {"Smithsonian Astrophysical Observation", "SAO 75006"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.54015655),
        dec: Angle.Degrees(+24.17271488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67374"},
    },
    visualMagnitude: 10.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13743328),
        dec: Angle.Degrees(+24.17339441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63323",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63323"},
        {"Smithsonian Astrophysical Observation", "SAO 82588"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.64774018),
        dec: Angle.Degrees(+24.17395615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69734"},
        {"Hipparcos Number", "HIP 40756"},
        {"Geneva Identification System", "GEN# +1.00069734"},
        {"Smithsonian Astrophysical Observation", "SAO 80089"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.78836506),
        dec: Angle.Degrees(+24.17474476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345165"},
        {"Hipparcos Number", "HIP 97973"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.67066512),
        dec: Angle.Degrees(+24.17560087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162280"},
        {"Hipparcos Number", "HIP 87225"},
        {"Smithsonian Astrophysical Observation", "SAO 85444"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.33076513),
        dec: Angle.Degrees(+24.17635469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31018"},
        {"Hipparcos Number", "HIP 22729"},
        {"Geneva Identification System", "GEN# +1.00031018"},
        {"Smithsonian Astrophysical Observation", "SAO 76810"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.34181942),
        dec: Angle.Degrees(+24.17741981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109042"},
        {"Smithsonian Astrophysical Observation", "SAO 90216"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.34392291),
        dec: Angle.Degrees(+24.17802861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178690"},
        {"Hipparcos Number", "HIP 94030"},
        {"Smithsonian Astrophysical Observation", "SAO 86859"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.15706448),
        dec: Angle.Degrees(+24.17930414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183206"},
        {"Hipparcos Number", "HIP 95660"},
        {"Geneva Identification System", "GEN# +1.00183206"},
        {"Smithsonian Astrophysical Observation", "SAO 87233"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.88032824),
        dec: Angle.Degrees(+24.18117527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197245"},
        {"Hipparcos Number", "HIP 102120"},
        {"Smithsonian Astrophysical Observation", "SAO 89016"},
        {"Wilson Evans Batten Catalogue", "WEB 18471"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.42418347),
        dec: Angle.Degrees(+24.18249488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21392"},
        {"Hipparcos Number", "HIP 16132"},
        {"Geneva Identification System", "GEN# +1.00021392"},
        {"Smithsonian Astrophysical Observation", "SAO 75937"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.95664700),
        dec: Angle.Degrees(+24.18279783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10350"},
        {"Hipparcos Number", "HIP 7889"},
        {"Geneva Identification System", "GEN# +1.00010350"},
        {"Smithsonian Astrophysical Observation", "SAO 74871"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.37044633),
        dec: Angle.Degrees(+24.18356193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17035"},
        {"Hipparcos Number", "HIP 12815"},
        {"Geneva Identification System", "GEN# +1.00017035"},
        {"Smithsonian Astrophysical Observation", "SAO 75546"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.18761899),
        dec: Angle.Degrees(+24.18447298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177110"},
        {"Hipparcos Number", "HIP 93487"},
        {"Smithsonian Astrophysical Observation", "SAO 86728"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.58968873),
        dec: Angle.Degrees(+24.18952528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21612"},
        {"Hipparcos Number", "HIP 16295"},
        {"Smithsonian Astrophysical Observation", "SAO 75952"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.52232208),
        dec: Angle.Degrees(+24.19043991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9202 AB"},
        {"Hipparcos Number", "HIP 69782"},
        {"Smithsonian Astrophysical Observation", "SAO 83269"},
    },
    visualMagnitude: 9.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)16, 58.3800),
        dec: Angle.DegreesMinutesSeconds((int)+24, (int)11, 32.700)
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
    primaryId: "HIP 109969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211408"},
        {"Hipparcos Number", "HIP 109969"},
        {"Smithsonian Astrophysical Observation", "SAO 90376"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.10390661),
        dec: Angle.Degrees(+24.19431148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5119"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.39858925),
        dec: Angle.Degrees(+24.19772291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118196"},
    },
    visualMagnitude: 11.66,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.62602348),
        dec: Angle.Degrees(+24.20167505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58262"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.22925907),
        dec: Angle.Degrees(+24.20265457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71836"},
        {"Smithsonian Astrophysical Observation", "SAO 83471"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.42748915),
        dec: Angle.Degrees(+24.20290427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255692"},
        {"Hipparcos Number", "HIP 30254"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.46314679),
        dec: Angle.Degrees(+24.20372140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64767"},
        {"Smithsonian Astrophysical Observation", "SAO 82747"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.09291534),
        dec: Angle.Degrees(+24.20383951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153651"},
        {"Hipparcos Number", "HIP 83158"},
        {"Smithsonian Astrophysical Observation", "SAO 84741"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.91693995),
        dec: Angle.Degrees(+24.20471790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78673",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78673"},
        {"Smithsonian Astrophysical Observation", "SAO 84174"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.91503627),
        dec: Angle.Degrees(+24.20542212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69270"},
        {"Smithsonian Astrophysical Observation", "SAO 83206"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.71593621),
        dec: Angle.Degrees(+24.20636426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40120"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.92075344),
        dec: Angle.Degrees(+24.20767751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119334"},
        {"Hipparcos Number", "HIP 66868"},
        {"Geneva Identification System", "GEN# +1.00119334"},
        {"Smithsonian Astrophysical Observation", "SAO 82953"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.56992744),
        dec: Angle.Degrees(+24.20897660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243713"},
        {"Hipparcos Number", "HIP 25498"},
        {"Smithsonian Astrophysical Observation", "SAO 77181"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.79187569),
        dec: Angle.Degrees(+24.21219441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244050"},
        {"Hipparcos Number", "HIP 25687"},
        {"Geneva Identification System", "GEN# +1.00244050"},
        {"Smithsonian Astrophysical Observation", "SAO 77197"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.28320309),
        dec: Angle.Degrees(+24.21518879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52497"},
        {"Hipparcos Number", "HIP 33927"},
        {"Fundamental Katalog 5th Edition", "FK5 1182"},
        {"Geneva Identification System", "GEN# +1.00052497"},
        {"Smithsonian Astrophysical Observation", "SAO 78999"},
        {"Wilson Evans Batten Catalogue", "WEB 6807"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.60326930),
        dec: Angle.Degrees(+24.21544652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4832"},
        {"Hipparcos Number", "HIP 3943"},
        {"Smithsonian Astrophysical Observation", "SAO 74304"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.65306062),
        dec: Angle.Degrees(+24.21670348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9828"},
        {"Hipparcos Number", "HIP 7487"},
        {"Geneva Identification System", "GEN# +1.00009828"},
        {"Smithsonian Astrophysical Observation", "SAO 74818"},
        {"Wilson Evans Batten Catalogue", "WEB 1601"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.10273115),
        dec: Angle.Degrees(+24.21684907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104392"},
        {"Hipparcos Number", "HIP 58621"},
        {"Geneva Identification System", "GEN# +1.00104392"},
        {"Smithsonian Astrophysical Observation", "SAO 82104"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.32338519),
        dec: Angle.Degrees(+24.21773498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19246"},
        {"Hipparcos Number", "HIP 14451"},
        {"Smithsonian Astrophysical Observation", "SAO 75736"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.63627047),
        dec: Angle.Degrees(+24.22140459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24994"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.28955276),
        dec: Angle.Degrees(+24.22177237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199718"},
        {"Hipparcos Number", "HIP 103515"},
        {"Smithsonian Astrophysical Observation", "SAO 89335"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.57691799),
        dec: Angle.Degrees(+24.22184751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61219"},
        {"Hipparcos Number", "HIP 37269"},
        {"Geneva Identification System", "GEN# +1.00061219"},
        {"Smithsonian Astrophysical Observation", "SAO 79580"},
        {"Wilson Evans Batten Catalogue", "WEB 7380"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.80003143),
        dec: Angle.Degrees(+24.22252771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173214"},
        {"Hipparcos Number", "HIP 91809"},
        {"Smithsonian Astrophysical Observation", "SAO 86360"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.79234457),
        dec: Angle.Degrees(+24.22295008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222572"},
        {"Hipparcos Number", "HIP 116888"},
        {"Geneva Identification System", "GEN# +1.00222572"},
        {"Smithsonian Astrophysical Observation", "SAO 91420"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.39168778),
        dec: Angle.Degrees(+24.22384820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109463"},
        {"Hipparcos Number", "HIP 61387"},
        {"Geneva Identification System", "GEN# +5.21110189"},
        {"Smithsonian Astrophysical Observation", "SAO 82386"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.69043336),
        dec: Angle.Degrees(+24.22419728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38334"},
        {"Hipparcos Number", "HIP 27200"},
        {"Geneva Identification System", "GEN# +1.00038334"},
        {"Smithsonian Astrophysical Observation", "SAO 77524"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.48579501),
        dec: Angle.Degrees(+24.22494414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37466"},
        {"Hipparcos Number", "HIP 26651"},
        {"Fundamental Katalog 5th Edition", "FK5 4514"},
        {"Geneva Identification System", "GEN# +1.00037466"},
        {"Smithsonian Astrophysical Observation", "SAO 77363"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.96456571),
        dec: Angle.Degrees(+24.22536781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97974"},
        {"Hipparcos Number", "HIP 55061"},
        {"Smithsonian Astrophysical Observation", "SAO 81747"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.08036263),
        dec: Angle.Degrees(+24.22709925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96234"},
        {"Hipparcos Number", "HIP 54269"},
        {"Smithsonian Astrophysical Observation", "SAO 81665"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.53143531),
        dec: Angle.Degrees(+24.22717482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108467"},
        {"Hipparcos Number", "HIP 60794"},
        {"Geneva Identification System", "GEN# +5.21110138"},
        {"Smithsonian Astrophysical Observation", "SAO 82320"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.89498788),
        dec: Angle.Degrees(+24.22737220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6970"},
        {"Smithsonian Astrophysical Observation", "SAO 74752"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.42774414),
        dec: Angle.Degrees(+24.22839721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39018"},
        {"Smithsonian Astrophysical Observation", "SAO 79836"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.76875131),
        dec: Angle.Degrees(+24.22922628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74120"},
        {"Smithsonian Astrophysical Observation", "SAO 83687"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.22157120),
        dec: Angle.Degrees(+24.23037597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34073",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5739 A"},
        {"Henry Draper", "HD 268501"},
        {"Hipparcos Number", "HIP 34073"},
        {"Smithsonian Astrophysical Observation", "SAO 79028"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.00081698),
        dec: Angle.Degrees(+24.23107795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163439"},
        {"Hipparcos Number", "HIP 87724"},
        {"Smithsonian Astrophysical Observation", "SAO 85541"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.78477464),
        dec: Angle.Degrees(+24.23182408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65915",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8929 C"},
        {"Henry Draper", "HD 117555"},
        {"Hipparcos Number", "HIP 65915"},
        {"Geneva Identification System", "GEN# +1.00117555"},
        {"Smithsonian Astrophysical Observation", "SAO 82867"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.69515597),
        dec: Angle.Degrees(+24.23275648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134902"},
        {"Hipparcos Number", "HIP 74341"},
        {"Smithsonian Astrophysical Observation", "SAO 83710"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.90461332),
        dec: Angle.Degrees(+24.23304748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114689",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16612 AB"},
        {"Henry Draper", "HD 219212"},
        {"Hipparcos Number", "HIP 114689"},
        {"Geneva Identification System", "GEN# +1.00228592J"},
        {"Smithsonian Astrophysical Observation", "SAO 91107"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.49923940),
        dec: Angle.Degrees(+24.23312153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76149"},
        {"Smithsonian Astrophysical Observation", "SAO 83880"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.30433665),
        dec: Angle.Degrees(+24.23480140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345677"},
        {"Hipparcos Number", "HIP 99099"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.78669097),
        dec: Angle.Degrees(+24.23695911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65921",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8929 A"},
        {"Henry Draper", "HD 117567"},
        {"Hipparcos Number", "HIP 65921"},
        {"Geneva Identification System", "GEN# +1.00117567"},
        {"Smithsonian Astrophysical Observation", "SAO 82868"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.71752831),
        dec: Angle.Degrees(+24.23757292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155514"},
        {"Hipparcos Number", "HIP 84054"},
        {"Geneva Identification System", "GEN# +1.00155514"},
        {"Smithsonian Astrophysical Observation", "SAO 84896"},
        {"Wilson Evans Batten Catalogue", "WEB 14201"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.76321245),
        dec: Angle.Degrees(+24.23762081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13543 AB"},
        {"Henry Draper", "HD 192342"},
        {"Hipparcos Number", "HIP 99679"},
        {"Geneva Identification System", "GEN# +1.00192342"},
        {"Smithsonian Astrophysical Observation", "SAO 88377"},
        {"Wilson Evans Batten Catalogue", "WEB 17873"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.41884345),
        dec: Angle.Degrees(+24.23893104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62230"},
        {"Hipparcos Number", "HIP 37691"},
        {"Geneva Identification System", "GEN# +1.00062230"},
        {"Smithsonian Astrophysical Observation", "SAO 79649"},
        {"Wilson Evans Batten Catalogue", "WEB 7451"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.99189380),
        dec: Angle.Degrees(+24.24404330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28975"},
        {"Hipparcos Number", "HIP 21347"},
        {"Geneva Identification System", "GEN# +1.00028975"},
        {"Smithsonian Astrophysical Observation", "SAO 76660"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.70898426),
        dec: Angle.Degrees(+24.24456993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50554"},
        {"Hipparcos Number", "HIP 33212"},
        {"Geneva Identification System", "GEN# +1.00050554"},
        {"Smithsonian Astrophysical Observation", "SAO 78855"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.67853817),
        dec: Angle.Degrees(+24.24579282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161920"},
        {"Hipparcos Number", "HIP 87058"},
        {"Smithsonian Astrophysical Observation", "SAO 85415"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.85441645),
        dec: Angle.Degrees(+24.24664444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39970"},
        {"Hipparcos Number", "HIP 28154"},
        {"Geneva Identification System", "GEN# +1.00039970"},
        {"Smithsonian Astrophysical Observation", "SAO 77750"},
        {"Wilson Evans Batten Catalogue", "WEB 5507"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.23382284),
        dec: Angle.Degrees(+24.24969579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164730"},
        {"Hipparcos Number", "HIP 88264"},
        {"Smithsonian Astrophysical Observation", "SAO 85649"},
        {"Wilson Evans Batten Catalogue", "WEB 14916"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.37211579),
        dec: Angle.Degrees(+24.24995696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118823"},
        {"Hipparcos Number", "HIP 66579"},
        {"Geneva Identification System", "GEN# +1.00118823"},
        {"Smithsonian Astrophysical Observation", "SAO 82922"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.72147851),
        dec: Angle.Degrees(+24.25056117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178187"},
        {"Hipparcos Number", "HIP 93845"},
        {"Geneva Identification System", "GEN# +1.00178187"},
        {"Smithsonian Astrophysical Observation", "SAO 86817"},
        {"Wilson Evans Batten Catalogue", "WEB 16319"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.65983699),
        dec: Angle.Degrees(+24.25075812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193013"},
        {"Hipparcos Number", "HIP 99998"},
        {"Smithsonian Astrophysical Observation", "SAO 88457"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.30465084),
        dec: Angle.Degrees(+24.25197694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155543"},
        {"Hipparcos Number", "HIP 84070"},
        {"Geneva Identification System", "GEN# +1.00155543"},
        {"Smithsonian Astrophysical Observation", "SAO 84900"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.82053780),
        dec: Angle.Degrees(+24.25234490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199663"},
        {"Hipparcos Number", "HIP 103482"},
        {"Smithsonian Astrophysical Observation", "SAO 89326"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.48950856),
        dec: Angle.Degrees(+24.25244004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224907"},
        {"Hipparcos Number", "HIP 136"},
        {"Smithsonian Astrophysical Observation", "SAO 91660"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.42864226),
        dec: Angle.Degrees(+24.25318080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85304"},
        {"Smithsonian Astrophysical Observation", "SAO 85079"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.47752597),
        dec: Angle.Degrees(+24.25616832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114724"},
        {"Hipparcos Number", "HIP 64417"},
        {"Fundamental Katalog 5th Edition", "FK5 3052"},
        {"Geneva Identification System", "GEN# +1.00114724"},
        {"Smithsonian Astrophysical Observation", "SAO 82708"},
        {"Wilson Evans Batten Catalogue", "WEB 11385"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.03509815),
        dec: Angle.Degrees(+24.25812901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84281"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.43535234),
        dec: Angle.Degrees(+24.25820993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114351",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16535 A"},
        {"Henry Draper", "HD 218661"},
        {"Hipparcos Number", "HIP 114351"},
        {"Smithsonian Astrophysical Observation", "SAO 91048"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.39248310),
        dec: Angle.Degrees(+24.25994998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105698"},
        {"Hipparcos Number", "HIP 59314"},
        {"Fundamental Katalog 5th Edition", "FK5 5078"},
        {"Geneva Identification System", "GEN# +5.21110006"},
        {"Smithsonian Astrophysical Observation", "SAO 82160"},
        {"Wilson Evans Batten Catalogue", "WEB 10550"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.52639800),
        dec: Angle.Degrees(+24.26109706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185334"},
        {"Hipparcos Number", "HIP 96550"},
        {"Geneva Identification System", "GEN# +1.00185334"},
        {"Renson", "Renson 51203"},
        {"Smithsonian Astrophysical Observation", "SAO 87476"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.43122937),
        dec: Angle.Degrees(+24.26115762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46923"},
        {"Smithsonian Astrophysical Observation", "SAO 80904"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.45631680),
        dec: Angle.Degrees(+24.26296455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82295"},
        {"Smithsonian Astrophysical Observation", "SAO 84621"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.22691132),
        dec: Angle.Degrees(+24.26314183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216979"},
        {"Hipparcos Number", "HIP 113336"},
        {"Geneva Identification System", "GEN# +1.00216979"},
        {"Smithsonian Astrophysical Observation", "SAO 90891"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.28678419),
        dec: Angle.Degrees(+24.26388333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23900",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3709 A"},
        {"Henry Draper", "HD 32990"},
        {"Hipparcos Number", "HIP 23900"},
        {"Geneva Identification System", "GEN# +2.17502316"},
        {"Smithsonian Astrophysical Observation", "SAO 76974"},
        {"Wilson Evans Batten Catalogue", "WEB 4662"},
        {"New General Catalogue", "NGC 1750 2316"},
    },
    visualMagnitude: 5.50,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.02759284),
        dec: Angle.Degrees(+24.26518765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15057"},
        {"Smithsonian Astrophysical Observation", "SAO 75805"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.50576276),
        dec: Angle.Degrees(+24.26529122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60336"},
        {"Hipparcos Number", "HIP 36883"},
        {"Smithsonian Astrophysical Observation", "SAO 79523"},
        {"Wilson Evans Batten Catalogue", "WEB 7326"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.74714612),
        dec: Angle.Degrees(+24.26549672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4502"},
        {"Hipparcos Number", "HIP 3693"},
        {"Fundamental Katalog 5th Edition", "FK5 27"},
        {"Geneva Identification System", "GEN# +1.00004502"},
        {"Smithsonian Astrophysical Observation", "SAO 74267"},
        {"Wilson Evans Batten Catalogue", "WEB 656"},
    },
    visualMagnitude: 4.08,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.83495908),
        dec: Angle.Degrees(+24.26737703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63387"},
        {"Hipparcos Number", "HIP 38201"},
        {"Smithsonian Astrophysical Observation", "SAO 79724"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.40036773),
        dec: Angle.Degrees(+24.26924487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163332"},
        {"Hipparcos Number", "HIP 87685"},
        {"Smithsonian Astrophysical Observation", "SAO 85532"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.64305980),
        dec: Angle.Degrees(+24.27070353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13825"},
        {"Hipparcos Number", "HIP 10505"},
        {"Cincinnati Publication", "Ci 20 159"},
        {"Geneva Identification System", "GEN# +1.00013825"},
        {"Smithsonian Astrophysical Observation", "SAO 75231"},
        {"Wilson Evans Batten Catalogue", "WEB 2204"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.85049328),
        dec: Angle.Degrees(+24.27176457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 460.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203803"},
        {"Hipparcos Number", "HIP 105652"},
        {"Geneva Identification System", "GEN# +1.00203803"},
        {"Smithsonian Astrophysical Observation", "SAO 89678"},
        {"Wilson Evans Batten Catalogue", "WEB 19175"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.99475047),
        dec: Angle.Degrees(+24.27409155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194360"},
        {"Henry Draper 2", "HD 194359"},
        {"Hipparcos Number", "HIP 100643"},
        {"Smithsonian Astrophysical Observation", "SAO 88631"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.10741380),
        dec: Angle.Degrees(+24.27760943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175227"},
        {"Hipparcos Number", "HIP 92708"},
        {"Geneva Identification System", "GEN# +1.00175227"},
        {"Smithsonian Astrophysical Observation", "SAO 86544"},
        {"Wilson Evans Batten Catalogue", "WEB 16038"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.35933648),
        dec: Angle.Degrees(+24.27800771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219801"},
        {"Hipparcos Number", "HIP 115079"},
        {"Smithsonian Astrophysical Observation", "SAO 91163"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.62593515),
        dec: Angle.Degrees(+24.27866951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33571"},
        {"Hipparcos Number", "HIP 24234"},
        {"Geneva Identification System", "GEN# +1.00033571"},
        {"Smithsonian Astrophysical Observation", "SAO 77027"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.04832743),
        dec: Angle.Degrees(+24.27922068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28819"},
        {"Hipparcos Number", "HIP 21246"},
        {"Geneva Identification System", "GEN# +1.00028819"},
        {"Smithsonian Astrophysical Observation", "SAO 76651"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.37028401),
        dec: Angle.Degrees(+24.27935600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5459"},
        {"Smithsonian Astrophysical Observation", "SAO 74525"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.46948813),
        dec: Angle.Degrees(+24.27950257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94736",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12257 AB"},
        {"Henry Draper", "HD 180713"},
        {"Hipparcos Number", "HIP 94736"},
        {"Smithsonian Astrophysical Observation", "SAO 87020"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.16299518),
        dec: Angle.Degrees(+24.28054828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109307"},
        {"Hipparcos Number", "HIP 61295"},
        {"Geneva Identification System", "GEN# +5.21110183"},
        {"Renson", "Renson 31720"},
        {"Smithsonian Astrophysical Observation", "SAO 82378"},
        {"Wilson Evans Batten Catalogue", "WEB 10910"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.39261214),
        dec: Angle.Degrees(+24.28300493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68791"},
        {"Geneva Identification System", "GEN# +0.02402684"},
        {"Smithsonian Astrophysical Observation", "SAO 83153"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.21072172),
        dec: Angle.Degrees(+24.28357137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107214"},
        {"Hipparcos Number", "HIP 60097"},
        {"Geneva Identification System", "GEN# +5.21110065"},
        {"Smithsonian Astrophysical Observation", "SAO 82243"},
        {"Wilson Evans Batten Catalogue", "WEB 10684"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.86818910),
        dec: Angle.Degrees(+24.28427613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39436"},
        {"Hipparcos Number", "HIP 27851"},
        {"Geneva Identification System", "GEN# +1.00039436"},
        {"Smithsonian Astrophysical Observation", "SAO 77684"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.39032177),
        dec: Angle.Degrees(+24.28701652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23642"},
        {"Hipparcos Number", "HIP 17704"},
        {"Celescope Catalog", "CEL 345"},
        {"Geneva Identification System", "GEN# +5.20221431"},
        {"Renson", "Renson 6070"},
        {"Smithsonian Astrophysical Observation", "SAO 76200"},
        {"Wilson Evans Batten Catalogue", "WEB 3383"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.87267431),
        dec: Angle.Degrees(+24.28845287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143532"},
        {"Hipparcos Number", "HIP 78370"},
        {"Smithsonian Astrophysical Observation", "SAO 84134"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.99865728),
        dec: Angle.Degrees(+24.28911988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17489",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Celaeno"},
        {"Common Name 2", "Celeno"},
        {"Henry Draper", "HD 23288"},
        {"Hipparcos Number", "HIP 17489"},
        {"Celescope Catalog", "CEL 313"},
        {"Geneva Identification System", "GEN# +5.20220447"},
        {"Smithsonian Astrophysical Observation", "SAO 76126"},
        {"Wilson Evans Batten Catalogue", "WEB 3314"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.20084227),
        dec: Angle.Degrees(+24.28957712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36758"},
        {"Hipparcos Number", "HIP 26201"},
        {"Smithsonian Astrophysical Observation", "SAO 77276"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.76485645),
        dec: Angle.Degrees(+24.29079872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30737"},
        {"Hipparcos Number", "HIP 22557"},
        {"Smithsonian Astrophysical Observation", "SAO 76785"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.81174096),
        dec: Angle.Degrees(+24.29084234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105136"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.47706761),
        dec: Angle.Degrees(+24.29084286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79214"},
        {"Hipparcos Number", "HIP 45268"},
        {"Smithsonian Astrophysical Observation", "SAO 80699"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.38795872),
        dec: Angle.Degrees(+24.29325825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51049"},
        {"Hipparcos Number", "HIP 33397"},
        {"Smithsonian Astrophysical Observation", "SAO 78894"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.19819341),
        dec: Angle.Degrees(+24.29753446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85335"},
        {"Smithsonian Astrophysical Observation", "SAO 85086"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.58071872),
        dec: Angle.Degrees(+24.29783682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218831"},
        {"Hipparcos Number", "HIP 114467"},
        {"Geneva Identification System", "GEN# +1.00218831"},
        {"Smithsonian Astrophysical Observation", "SAO 91063"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.73225184),
        dec: Angle.Degrees(+24.29938363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110582"},
        {"Hipparcos Number", "HIP 62048"},
        {"Geneva Identification System", "GEN# +1.00110582"},
        {"Smithsonian Astrophysical Observation", "SAO 82453"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.76952726),
        dec: Angle.Degrees(+24.29995768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122133"},
        {"Hipparcos Number", "HIP 68346"},
        {"Geneva Identification System", "GEN# +1.00122133J"},
        {"Smithsonian Astrophysical Observation", "SAO 83113"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.85875086),
        dec: Angle.Degrees(+24.30077789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65252"},
        {"Smithsonian Astrophysical Observation", "SAO 82805"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.58746222),
        dec: Angle.Degrees(+24.30091398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3179 A"},
        {"Henry Draper", "HD 27778"},
        {"Hipparcos Number", "HIP 20533"},
        {"Geneva Identification System", "GEN# +1.00027778A"},
        {"Smithsonian Astrophysical Observation", "SAO 76591"},
        {"Wilson Evans Batten Catalogue", "WEB 3927"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.99899568),
        dec: Angle.Degrees(+24.30102325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10042"},
        {"Smithsonian Astrophysical Observation", "SAO 75169"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.31834357),
        dec: Angle.Degrees(+24.30206389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44836"},
        {"Hipparcos Number", "HIP 30528"},
        {"Geneva Identification System", "GEN# +1.00044836"},
        {"Smithsonian Astrophysical Observation", "SAO 78336"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.25376428),
        dec: Angle.Degrees(+24.30212276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341438"},
        {"Hipparcos Number", "HIP 103615"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.89543511),
        dec: Angle.Degrees(+24.30295564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20531",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3179 B"},
        {"Hipparcos Number", "HIP 20531"},
        {"Geneva Identification System", "GEN# +1.20027778"},
        {"Geneva Identification System 2", "GEN# +0.02300683"},
        {"Geneva Identification System 3", "GEN# +1.00027778B"},
        {"Renson", "Renson 7120"},
        {"Smithsonian Astrophysical Observation", "SAO 76590"},
        {"Wilson Evans Batten Catalogue", "WEB 3929"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.99069869),
        dec: Angle.Degrees(+24.30386155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162828"},
        {"Hipparcos Number", "HIP 87440"},
        {"Smithsonian Astrophysical Observation", "SAO 85485"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.01069425),
        dec: Angle.Degrees(+24.30448611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14808"},
        {"Hipparcos Number", "HIP 11172"},
        {"Smithsonian Astrophysical Observation", "SAO 75339"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.96260285),
        dec: Angle.Degrees(+24.30543149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75683"},
        {"Hipparcos Number", "HIP 43548"},
        {"Smithsonian Astrophysical Observation", "SAO 80470"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.03942252),
        dec: Angle.Degrees(+24.30876054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87866"},
        {"Hipparcos Number", "HIP 49677"},
        {"Geneva Identification System", "GEN# +1.00087866"},
        {"Smithsonian Astrophysical Observation", "SAO 81202"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.11644166),
        dec: Angle.Degrees(+24.30880604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160181"},
        {"Hipparcos Number", "HIP 86254"},
        {"Fundamental Katalog 5th Edition", "FK5 3400"},
        {"Geneva Identification System", "GEN# +1.00160181"},
        {"Smithsonian Astrophysical Observation", "SAO 85264"},
        {"Wilson Evans Batten Catalogue", "WEB 14546"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.37957747),
        dec: Angle.Degrees(+24.30996890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344517"},
        {"Hipparcos Number", "HIP 96228"},
        {"Renson", "Renson 50915"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.51961485),
        dec: Angle.Degrees(+24.31017830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26783"},
        {"Hipparcos Number", "HIP 19829"},
        {"Smithsonian Astrophysical Observation", "SAO 76521"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.77622967),
        dec: Angle.Degrees(+24.31018263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165802"},
        {"Hipparcos Number", "HIP 88727"},
        {"Smithsonian Astrophysical Observation", "SAO 85738"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.71116716),
        dec: Angle.Degrees(+24.31126696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100179"},
        {"Hipparcos Number", "HIP 56255"},
        {"Fundamental Katalog 5th Edition", "FK5 5015"},
        {"Geneva Identification System", "GEN# +1.00100179"},
        {"Smithsonian Astrophysical Observation", "SAO 81868"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.96529271),
        dec: Angle.Degrees(+24.31144765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117062"},
        {"Hipparcos Number", "HIP 65643"},
        {"Geneva Identification System", "GEN# +1.00117062"},
        {"Smithsonian Astrophysical Observation", "SAO 82849"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.87495273),
        dec: Angle.Degrees(+24.31198413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251671"},
        {"Hipparcos Number", "HIP 28977"},
        {"Geneva Identification System", "GEN# +1.00251671"},
        {"Smithsonian Astrophysical Observation", "SAO 77972"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.73050954),
        dec: Angle.Degrees(+24.31254264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39022"},
        {"Smithsonian Astrophysical Observation", "SAO 79837"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.77363905),
        dec: Angle.Degrees(+24.31449941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215522"},
        {"Hipparcos Number", "HIP 112359"},
        {"Smithsonian Astrophysical Observation", "SAO 90761"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.37121367),
        dec: Angle.Degrees(+24.31463680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211152"},
        {"Hipparcos Number", "HIP 109842"},
        {"Geneva Identification System", "GEN# +1.00211152"},
        {"Smithsonian Astrophysical Observation", "SAO 90350"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.69990920),
        dec: Angle.Degrees(+24.31491056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123612"},
        {"Hipparcos Number", "HIP 69067"},
        {"Geneva Identification System", "GEN# +1.00123612"},
        {"Smithsonian Astrophysical Observation", "SAO 83190"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.06614933),
        dec: Angle.Degrees(+24.31504100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113094"},
        {"Hipparcos Number", "HIP 63526"},
        {"Geneva Identification System", "GEN# +1.00113094"},
        {"Smithsonian Astrophysical Observation", "SAO 82607"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.26483906),
        dec: Angle.Degrees(+24.31640336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80967"},
        {"Hipparcos Number", "HIP 46062"},
        {"Smithsonian Astrophysical Observation", "SAO 80798"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.89186038),
        dec: Angle.Degrees(+24.31846470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37768"},
        {"Hipparcos Number", "HIP 26839"},
        {"Smithsonian Astrophysical Observation", "SAO 77414"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.48821657),
        dec: Angle.Degrees(+24.31854446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188485"},
        {"Hipparcos Number", "HIP 97961"},
        {"Geneva Identification System", "GEN# +1.00188485"},
        {"Smithsonian Astrophysical Observation", "SAO 87908"},
        {"Wilson Evans Batten Catalogue", "WEB 17238"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.62942212),
        dec: Angle.Degrees(+24.31939041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16479"},
        {"Hipparcos Number", "HIP 12367"},
        {"Smithsonian Astrophysical Observation", "SAO 75497"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.80059346),
        dec: Angle.Degrees(+24.31966994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30755"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.94011353),
        dec: Angle.Degrees(+24.32020697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6328 AB"},
        {"Henry Draper", "HD 62435"},
        {"Hipparcos Number", "HIP 37788"},
        {"Smithsonian Astrophysical Observation", "SAO 79662"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.23401754),
        dec: Angle.Degrees(+24.32048803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 282"},
        {"Hipparcos Number", "HIP 615"},
        {"Smithsonian Astrophysical Observation", "SAO 73758"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.88037933),
        dec: Angle.Degrees(+24.32121026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 345064"},
        {"Hipparcos Number", "HIP 97712"},
        {"Smithsonian Astrophysical Observation", "SAO 87823"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.87025637),
        dec: Angle.Degrees(+24.32147331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64196",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64196"},
        {"Geneva Identification System", "GEN# +0.02502602"},
        {"Smithsonian Astrophysical Observation", "SAO 82681"},
        {"Wilson Evans Batten Catalogue", "WEB 11346"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.35683906),
        dec: Angle.Degrees(+24.32368438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106949"},
        {"Smithsonian Astrophysical Observation", "SAO 89884"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.90691584),
        dec: Angle.Degrees(+24.32391299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60511"},
        {"Geneva Identification System", "GEN# +5.21110214"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.07148135),
        dec: Angle.Degrees(+24.32457371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24007",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24007"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.39428498),
        dec: Angle.Degrees(+24.32574524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16074"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.75615376),
        dec: Angle.Degrees(+24.32715352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149721"},
        {"Hipparcos Number", "HIP 81246"},
        {"Geneva Identification System", "GEN# +1.00149721"},
        {"Smithsonian Astrophysical Observation", "SAO 84470"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.91295004),
        dec: Angle.Degrees(+24.32722287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161239"},
        {"Hipparcos Number", "HIP 86731"},
        {"Geneva Identification System", "GEN# +1.00161239"},
        {"Smithsonian Astrophysical Observation", "SAO 85360"},
        {"Wilson Evans Batten Catalogue", "WEB 14626"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.84016161),
        dec: Angle.Degrees(+24.32764591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -116.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248924"},
        {"Hipparcos Number", "HIP 27906"},
        {"Geneva Identification System", "GEN# +1.00248924"},
        {"Smithsonian Astrophysical Observation", "SAO 77704"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.57823556),
        dec: Angle.Degrees(+24.32868345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66485"},
        {"Hipparcos Number", "HIP 39528"},
        {"Geneva Identification System", "GEN# +1.00066485"},
        {"Smithsonian Astrophysical Observation", "SAO 79916"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.17822656),
        dec: Angle.Degrees(+24.33014727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6342",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6342"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.37150870),
        dec: Angle.Degrees(+24.33054693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 341.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204361"},
        {"Hipparcos Number", "HIP 105952"},
        {"Smithsonian Astrophysical Observation", "SAO 89716"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.86660696),
        dec: Angle.Degrees(+24.33139510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69985",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69985"},
    },
    visualMagnitude: 11.65,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.80937802),
        dec: Angle.Degrees(+24.33146422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -362.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108369"},
        {"Smithsonian Astrophysical Observation", "SAO 90124"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.31255746),
        dec: Angle.Degrees(+24.33170077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243793"},
        {"Hipparcos Number", "HIP 25550"},
        {"Smithsonian Astrophysical Observation", "SAO 77186"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.93280565),
        dec: Angle.Degrees(+24.33256307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12846"},
        {"Hipparcos Number", "HIP 9829"},
        {"Geneva Identification System", "GEN# +1.00012846"},
        {"Smithsonian Astrophysical Observation", "SAO 75144"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.62599843),
        dec: Angle.Degrees(+24.33435081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54154",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54154"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.17245636),
        dec: Angle.Degrees(+24.33669806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343238"},
        {"Hipparcos Number", "HIP 92624"},
        {"Smithsonian Astrophysical Observation", "SAO 86529"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.09192358),
        dec: Angle.Degrees(+24.33778447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108807"},
        {"Hipparcos Number", "HIP 60976"},
        {"Geneva Identification System", "GEN# +5.21110152"},
        {"Smithsonian Astrophysical Observation", "SAO 82337"},
        {"Wilson Evans Batten Catalogue", "WEB 10851"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.48154696),
        dec: Angle.Degrees(+24.33859783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208503"},
        {"Hipparcos Number", "HIP 108270"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.02046691),
        dec: Angle.Degrees(+24.33989572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221605"},
        {"Hipparcos Number", "HIP 116265"},
        {"Geneva Identification System", "GEN# +1.00221605"},
        {"Smithsonian Astrophysical Observation", "SAO 91341"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.36699578),
        dec: Angle.Degrees(+24.34241331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136754"},
        {"Hipparcos Number", "HIP 75163"},
        {"Geneva Identification System", "GEN# +1.00136754"},
        {"Smithsonian Astrophysical Observation", "SAO 83785"},
        {"Wilson Evans Batten Catalogue", "WEB 12822"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.39397991),
        dec: Angle.Degrees(+24.34339118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41276",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6797 B"},
        {"Hipparcos Number", "HIP 41276"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.32079498),
        dec: Angle.Degrees(+24.34340805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16639"},
        {"Geneva Identification System", "GEN# +5.20223301"},
        {"Smithsonian Astrophysical Observation", "SAO 75993"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.53040401),
        dec: Angle.Degrees(+24.34455483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71730"},
        {"Hipparcos Number", "HIP 41660"},
        {"Geneva Identification System", "GEN# +1.00071730"},
        {"Smithsonian Astrophysical Observation", "SAO 80209"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.41698694),
        dec: Angle.Degrees(+24.34476183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34630",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34630"},
        {"Geneva Identification System", "GEN# +9.80088010"},
    },
    visualMagnitude: 11.85,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.59919566),
        dec: Angle.Degrees(+24.34513011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23763"},
        {"Hipparcos Number", "HIP 17791"},
        {"Celescope Catalog", "CEL 349"},
        {"Geneva Identification System", "GEN# +5.20221876"},
        {"Smithsonian Astrophysical Observation", "SAO 76216"},
        {"Wilson Evans Batten Catalogue", "WEB 3409"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.12534946),
        dec: Angle.Degrees(+24.34562875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73285"},
    },
    visualMagnitude: 11.00,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.66480605),
        dec: Angle.Degrees(+24.34698738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -195.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66086",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8937 A"},
        {"Henry Draper", "HD 117876"},
        {"Hipparcos Number", "HIP 66086"},
        {"Geneva Identification System", "GEN# +1.00117876"},
        {"Smithsonian Astrophysical Observation", "SAO 82875"},
        {"Wilson Evans Batten Catalogue", "WEB 11677"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.20071797),
        dec: Angle.Degrees(+24.34720981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 344365"},
        {"Hipparcos Number", "HIP 95702"},
        {"Wilson Evans Batten Catalogue", "WEB 16743"},
    },
    visualMagnitude: 11.00,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.98370482),
        dec: Angle.Degrees(+24.34744018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78068"},
        {"Smithsonian Astrophysical Observation", "SAO 84088"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.10106494),
        dec: Angle.Degrees(+24.34791385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159714"},
        {"Hipparcos Number", "HIP 86054"},
        {"Smithsonian Astrophysical Observation", "SAO 85226"},
        {"Wilson Evans Batten Catalogue", "WEB 14518"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.79472701),
        dec: Angle.Degrees(+24.34942587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41279",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6797 A"},
        {"Henry Draper", "HD 70897"},
        {"Hipparcos Number", "HIP 41279"},
        {"Smithsonian Astrophysical Observation", "SAO 80171"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.32580004),
        dec: Angle.Degrees(+24.35011219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37648"},
        {"Hipparcos Number", "HIP 26761"},
        {"Geneva Identification System", "GEN# +1.00037648"},
        {"Smithsonian Astrophysical Observation", "SAO 77390"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.27276976),
        dec: Angle.Degrees(+24.35021559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47354",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47354"},
        {"Smithsonian Astrophysical Observation", "SAO 80949"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.73146096),
        dec: Angle.Degrees(+24.35046131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10487"},
        {"Hipparcos Number", "HIP 8005"},
        {"Smithsonian Astrophysical Observation", "SAO 74887"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.69449346),
        dec: Angle.Degrees(+24.35457447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42684"},
        {"Smithsonian Astrophysical Observation", "SAO 80364"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.50043829),
        dec: Angle.Degrees(+24.35682482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66949"},
        {"Smithsonian Astrophysical Observation", "SAO 82961"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.81915970),
        dec: Angle.Degrees(+24.35954400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41940"},
        {"Hipparcos Number", "HIP 29148"},
        {"Geneva Identification System", "GEN# +2.21680123"},
        {"Smithsonian Astrophysical Observation", "SAO 78031"},
        {"Wilson Evans Batten Catalogue", "WEB 5715"},
        {"New General Catalogue", "NGC 2168 123"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.23558519),
        dec: Angle.Degrees(+24.35987482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283167"},
        {"Hipparcos Number", "HIP 18263"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.60511727),
        dec: Angle.Degrees(+24.36019636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61035"},
        {"Hipparcos Number", "HIP 37165"},
        {"Geneva Identification System", "GEN# +1.00061035"},
        {"Smithsonian Astrophysical Observation", "SAO 79562"},
        {"Wilson Evans Batten Catalogue", "WEB 7364"},
    },
    visualMagnitude: 6.37,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.55984487),
        dec: Angle.Degrees(+24.36039278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35820"},
        {"Smithsonian Astrophysical Observation", "SAO 79347"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.81128950),
        dec: Angle.Degrees(+24.36218318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346226"},
        {"Hipparcos Number", "HIP 100200"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.85645392),
        dec: Angle.Degrees(+24.36264847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38711",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6459 AB"},
        {"Henry Draper", "HD 64583"},
        {"Hipparcos Number", "HIP 38711"},
        {"Smithsonian Astrophysical Observation", "SAO 79798"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.88082581),
        dec: Angle.Degrees(+24.36318635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89361"},
        {"Hipparcos Number", "HIP 50528"},
        {"Fundamental Katalog 5th Edition", "FK5 4917"},
        {"Smithsonian Astrophysical Observation", "SAO 81287"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.80460570),
        dec: Angle.Degrees(+24.36394170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72412",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9389 AB"},
        {"Henry Draper", "HD 130603"},
        {"Hipparcos Number", "HIP 72412"},
        {"Geneva Identification System", "GEN# +1.00130603"},
        {"Smithsonian Astrophysical Observation", "SAO 83535"},
        {"Wilson Evans Batten Catalogue", "WEB 12445"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.09753868),
        dec: Angle.Degrees(+24.36673685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17573",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Maia"},
        {"Henry Draper", "HD 23408"},
        {"Hipparcos Number", "HIP 17573"},
        {"Celescope Catalog", "CEL 324"},
        {"Geneva Identification System", "GEN# +5.20220785"},
        {"Renson", "Renson 6000"},
        {"Smithsonian Astrophysical Observation", "SAO 76155"},
        {"Wilson Evans Batten Catalogue", "WEB 3336"},
    },
    visualMagnitude: 3.87,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.45663804),
        dec: Angle.Degrees(+24.36785796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90385",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11350 AB"},
        {"Henry Draper", "HD 170076"},
        {"Hipparcos Number", "HIP 90385"},
        {"Smithsonian Astrophysical Observation", "SAO 86057"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.64458802),
        dec: Angle.Degrees(+24.37016085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52335"},
        {"Smithsonian Astrophysical Observation", "SAO 81477"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.42707392),
        dec: Angle.Degrees(+24.37143678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94966"},
        {"Hipparcos Number", "HIP 53615"},
        {"Smithsonian Astrophysical Observation", "SAO 81601"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.53783130),
        dec: Angle.Degrees(+24.37551717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215445"},
        {"Hipparcos Number", "HIP 112303"},
        {"Smithsonian Astrophysical Observation", "SAO 90757"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.21020558),
        dec: Angle.Degrees(+24.37853021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23873"},
        {"Hipparcos Number", "HIP 17862"},
        {"Celescope Catalog", "CEL 359"},
        {"Geneva Identification System", "GEN# +5.20222263"},
        {"Smithsonian Astrophysical Observation", "SAO 76236"},
        {"Wilson Evans Batten Catalogue", "WEB 3433"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.34057511),
        dec: Angle.Degrees(+24.38106408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153312"},
        {"Hipparcos Number", "HIP 83007"},
        {"Fundamental Katalog 5th Edition", "FK5 3347"},
        {"Geneva Identification System", "GEN# +1.00153312"},
        {"Smithsonian Astrophysical Observation", "SAO 84726"},
        {"Wilson Evans Batten Catalogue", "WEB 14034"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.42626311),
        dec: Angle.Degrees(+24.38130868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136864"},
        {"Hipparcos Number", "HIP 75223"},
        {"Smithsonian Astrophysical Observation", "SAO 83793"},
        {"Wilson Evans Batten Catalogue", "WEB 12831"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.58258463),
        dec: Angle.Degrees(+24.38238154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45850"},
        {"Hipparcos Number", "HIP 31046"},
        {"Smithsonian Astrophysical Observation", "SAO 78457"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.71221885),
        dec: Angle.Degrees(+24.38433832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78187"},
        {"Smithsonian Astrophysical Observation", "SAO 84102"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.46361716),
        dec: Angle.Degrees(+24.38497739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131972"},
        {"Hipparcos Number", "HIP 73071"},
        {"Smithsonian Astrophysical Observation", "SAO 83586"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.00157099),
        dec: Angle.Degrees(+24.38607408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216696"},
        {"Hipparcos Number", "HIP 113139"},
        {"Smithsonian Astrophysical Observation", "SAO 90872"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.66817386),
        dec: Angle.Degrees(+24.38711441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44718"},
        {"Smithsonian Astrophysical Observation", "SAO 80633"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.68072577),
        dec: Angle.Degrees(+24.38913983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214784"},
        {"Hipparcos Number", "HIP 111918"},
        {"Smithsonian Astrophysical Observation", "SAO 90690"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.05331508),
        dec: Angle.Degrees(+24.38957571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128078"},
        {"Hipparcos Number", "HIP 71256"},
        {"Geneva Identification System", "GEN# +1.00128078A"},
        {"Smithsonian Astrophysical Observation", "SAO 83411"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.58565350),
        dec: Angle.Degrees(+24.39182091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10882"},
        {"Hipparcos Number", "HIP 8311"},
        {"Smithsonian Astrophysical Observation", "SAO 74929"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.79681538),
        dec: Angle.Degrees(+24.39228805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110560"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.95474292),
        dec: Angle.Degrees(+24.39294044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167081"},
        {"Hipparcos Number", "HIP 89247"},
        {"Geneva Identification System", "GEN# +1.00167081"},
        {"Smithsonian Astrophysical Observation", "SAO 85825"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.18072583),
        dec: Angle.Degrees(+24.39353629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224508"},
        {"Hipparcos Number", "HIP 118193"},
        {"Smithsonian Astrophysical Observation", "SAO 91622"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.61685869),
        dec: Angle.Degrees(+24.39549590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85376"},
        {"Hipparcos Number", "HIP 48390"},
        {"Geneva Identification System", "GEN# +1.00085376"},
        {"Renson", "Renson 24384"},
        {"Smithsonian Astrophysical Observation", "SAO 81054"},
        {"Wilson Evans Batten Catalogue", "WEB 9025"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.97093576),
        dec: Angle.Degrees(+24.39579370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33689"},
        {"Hipparcos Number", "HIP 24315"},
        {"Smithsonian Astrophysical Observation", "SAO 77035"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.26426043),
        dec: Angle.Degrees(+24.39696001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62345"},
        {"Hipparcos Number", "HIP 37740"},
        {"Fundamental Katalog 5th Edition", "FK5 294"},
        {"Geneva Identification System", "GEN# +1.00062345J"},
        {"Smithsonian Astrophysical Observation", "SAO 79653"},
        {"Wilson Evans Batten Catalogue", "WEB 7458"},
    },
    visualMagnitude: 3.57,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.11195237),
        dec: Angle.Degrees(+24.39812929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206028"},
        {"Hipparcos Number", "HIP 106873"},
        {"Renson", "Renson 57370"},
        {"Smithsonian Astrophysical Observation", "SAO 89869"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.69070756),
        dec: Angle.Degrees(+24.39818068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46945"},
        {"Hipparcos Number", "HIP 31631"},
        {"Smithsonian Astrophysical Observation", "SAO 78550"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.28206820),
        dec: Angle.Degrees(+24.39877590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109982"},
        {"Hipparcos Number", "HIP 61705"},
        {"Geneva Identification System", "GEN# +1.00109982"},
        {"Smithsonian Astrophysical Observation", "SAO 82419"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.72036248),
        dec: Angle.Degrees(+24.39881496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55747"},
        {"Smithsonian Astrophysical Observation", "SAO 81815"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.33157197),
        dec: Angle.Degrees(+24.39958246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71261"},
        {"Smithsonian Astrophysical Observation", "SAO 83414"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.60763623),
        dec: Angle.Degrees(+24.39999548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45728"},
        {"Smithsonian Astrophysical Observation", "SAO 80759"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.83460722),
        dec: Angle.Degrees(+24.40241550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7944"},
        {"Hipparcos Number", "HIP 6192"},
        {"Smithsonian Astrophysical Observation", "SAO 74636"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.86024692),
        dec: Angle.Degrees(+24.40347401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74587",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74587"},
        {"Smithsonian Astrophysical Observation", "SAO 83728"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.60785068),
        dec: Angle.Degrees(+24.40411959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117101"},
        {"Hipparcos Number", "HIP 65661"},
        {"Fundamental Katalog 5th Edition", "FK5 5185"},
        {"Geneva Identification System", "GEN# +1.00117101"},
        {"Smithsonian Astrophysical Observation", "SAO 82853"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.93722973),
        dec: Angle.Degrees(+24.40431150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27731"},
        {"Hipparcos Number", "HIP 20491"},
        {"Geneva Identification System", "GEN# +5.20250044"},
        {"Smithsonian Astrophysical Observation", "SAO 76582"},
        {"Wilson Evans Batten Catalogue", "WEB 3920"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.87642041),
        dec: Angle.Degrees(+24.40551168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30067"},
        {"Hipparcos Number", "HIP 22096"},
        {"Geneva Identification System", "GEN# +1.00030067"},
        {"Smithsonian Astrophysical Observation", "SAO 76736"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.32594450),
        dec: Angle.Degrees(+24.41013756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113646",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113646"},
        {"Smithsonian Astrophysical Observation", "SAO 90943"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.24567707),
        dec: Angle.Degrees(+24.41096271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153820"},
        {"Hipparcos Number", "HIP 83238"},
        {"Smithsonian Astrophysical Observation", "SAO 84754"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.16761808),
        dec: Angle.Degrees(+24.41123929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71958"},
        {"Smithsonian Astrophysical Observation", "SAO 83483"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.76510729),
        dec: Angle.Degrees(+24.41351570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165684"},
        {"Hipparcos Number", "HIP 88686"},
        {"Smithsonian Astrophysical Observation", "SAO 85732"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.57103039),
        dec: Angle.Degrees(+24.41371432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160557"},
        {"Hipparcos Number", "HIP 86436"},
        {"Smithsonian Astrophysical Observation", "SAO 85294"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.92003452),
        dec: Angle.Degrees(+24.41400583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82249"},
        {"Hipparcos Number", "HIP 46729"},
        {"Smithsonian Astrophysical Observation", "SAO 80879"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.87479059),
        dec: Angle.Degrees(+24.41419264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79205"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.48928306),
        dec: Angle.Degrees(+24.41444663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181098"},
        {"Hipparcos Number", "HIP 94861"},
        {"Geneva Identification System", "GEN# +1.00181098"},
        {"Smithsonian Astrophysical Observation", "SAO 87047"},
        {"Wilson Evans Batten Catalogue", "WEB 16557"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.54883508),
        dec: Angle.Degrees(+24.41516076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5803"},
        {"Geneva Identification System", "GEN# +0.02300159"},
        {"Wilson Evans Batten Catalogue", "WEB 1323"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.60823738),
        dec: Angle.Degrees(+24.41575741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249388"},
        {"Hipparcos Number", "HIP 28124"},
        {"Geneva Identification System", "GEN# +1.00249388"},
        {"Smithsonian Astrophysical Observation", "SAO 77747"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.16891141),
        dec: Angle.Degrees(+24.41616946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347082"},
        {"Hipparcos Number", "HIP 101912"},
        {"Smithsonian Astrophysical Observation", "SAO 88958"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.77550147),
        dec: Angle.Degrees(+24.41667330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80327"},
        {"Hipparcos Number", "HIP 45756"},
        {"Geneva Identification System", "GEN# +1.00080327"},
        {"Smithsonian Astrophysical Observation", "SAO 80765"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.95624223),
        dec: Angle.Degrees(+24.41668512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38218"},
        {"Hipparcos Number", "HIP 27135"},
        {"Geneva Identification System", "GEN# +1.00038218"},
        {"Smithsonian Astrophysical Observation", "SAO 77502"},
        {"Wilson Evans Batten Catalogue", "WEB 5339"},
    },
    visualMagnitude: 8.22,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.30718352),
        dec: Angle.Degrees(+24.42014141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42398"},
        {"Hipparcos Number", "HIP 29379"},
        {"Geneva Identification System", "GEN# +1.00042398"},
        {"Smithsonian Astrophysical Observation", "SAO 78079"},
        {"Wilson Evans Batten Catalogue", "WEB 5769"},
    },
    visualMagnitude: 5.83,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.88460504),
        dec: Angle.Degrees(+24.42037914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81536"},
        {"Smithsonian Astrophysical Observation", "SAO 84512"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.80577369),
        dec: Angle.Degrees(+24.42059458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219446"},
        {"Hipparcos Number", "HIP 114835"},
        {"Smithsonian Astrophysical Observation", "SAO 91129"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.92106453),
        dec: Angle.Degrees(+24.42244677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242632"},
        {"Hipparcos Number", "HIP 24875"},
        {"Smithsonian Astrophysical Observation", "SAO 77109"},
    },
    visualMagnitude: 9.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.00187207),
        dec: Angle.Degrees(+24.42399434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102404"},
        {"Hipparcos Number", "HIP 57513"},
        {"Geneva Identification System", "GEN# +1.00102404"},
        {"Smithsonian Astrophysical Observation", "SAO 81991"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.83018181),
        dec: Angle.Degrees(+24.42432419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78950"},
        {"Geneva Identification System", "GEN# +0.02402972"},
        {"Smithsonian Astrophysical Observation", "SAO 84200"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.75557028),
        dec: Angle.Degrees(+24.42530855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221786"},
        {"Hipparcos Number", "HIP 116383"},
        {"Smithsonian Astrophysical Observation", "SAO 91358"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.74838451),
        dec: Angle.Degrees(+24.42587378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283511"},
        {"Hipparcos Number", "HIP 19586"},
        {"Smithsonian Astrophysical Observation", "SAO 76491"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.96379906),
        dec: Angle.Degrees(+24.43087694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172085"},
        {"Hipparcos Number", "HIP 91283"},
        {"Geneva Identification System", "GEN# +1.00172085"},
        {"Smithsonian Astrophysical Observation", "SAO 86248"},
        {"Wilson Evans Batten Catalogue", "WEB 15688"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.29367356),
        dec: Angle.Degrees(+24.43361195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168384"},
        {"Hipparcos Number", "HIP 89706"},
        {"Smithsonian Astrophysical Observation", "SAO 85910"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.62101546),
        dec: Angle.Degrees(+24.43911996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283817"},
        {"Hipparcos Number", "HIP 21768"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.13599160),
        dec: Angle.Degrees(+24.44206902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91220"},
        {"Hipparcos Number", "HIP 51591"},
        {"Fundamental Katalog 5th Edition", "FK5 2843"},
        {"Geneva Identification System", "GEN# +1.00091220"},
        {"Smithsonian Astrophysical Observation", "SAO 81403"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.07232053),
        dec: Angle.Degrees(+24.44226318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84949"},
        {"Hipparcos Number", "HIP 48176"},
        {"Fundamental Katalog 5th Edition", "FK5 4873"},
        {"Smithsonian Astrophysical Observation", "SAO 81027"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.29995660),
        dec: Angle.Degrees(+24.44402438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12306"},
        {"Hipparcos Number", "HIP 9435"},
        {"Geneva Identification System", "GEN# +1.00012306"},
        {"Smithsonian Astrophysical Observation", "SAO 75090"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.29299620),
        dec: Angle.Degrees(+24.44440868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20834",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 11"},
        {"Henry Draper", "HD 283668"},
        {"Hipparcos Number", "HIP 20834"},
        {"Geneva Identification System", "GEN# +1.00283668"},
        {"Smithsonian Astrophysical Observation", "SAO 76617"},
        {"Wilson Evans Batten Catalogue", "WEB 3996"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.96955288),
        dec: Angle.Degrees(+24.44451029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 375.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89031"},
        {"Hipparcos Number", "HIP 50342"},
        {"Smithsonian Astrophysical Observation", "SAO 81266"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.19466378),
        dec: Angle.Degrees(+24.44572673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168532"},
        {"Hipparcos Number", "HIP 89773"},
        {"Fundamental Katalog 5th Edition", "FK5 3457"},
        {"Geneva Identification System", "GEN# +1.00168532"},
        {"Smithsonian Astrophysical Observation", "SAO 85921"},
        {"Wilson Evans Batten Catalogue", "WEB 15314"},
    },
    visualMagnitude: 5.30,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.79447741),
        dec: Angle.Degrees(+24.44604619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193911"},
        {"Hipparcos Number", "HIP 100435"},
        {"Geneva Identification System", "GEN# +1.00193911"},
        {"Smithsonian Astrophysical Observation", "SAO 88580"},
        {"Wilson Evans Batten Catalogue", "WEB 18134"},
    },
    visualMagnitude: 5.50,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.51428968),
        dec: Angle.Degrees(+24.44611603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104590"},
        {"Hipparcos Number", "HIP 58724"},
        {"Geneva Identification System", "GEN# +1.00104590"},
        {"Smithsonian Astrophysical Observation", "SAO 82113"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.67570504),
        dec: Angle.Degrees(+24.44678246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76333"},
        {"Hipparcos Number", "HIP 43871"},
        {"Geneva Identification System", "GEN# +1.00076333"},
        {"Smithsonian Astrophysical Observation", "SAO 80519"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.05604143),
        dec: Angle.Degrees(+24.44792674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109282"},
        {"Hipparcos Number", "HIP 61290"},
        {"Fundamental Katalog 5th Edition", "FK5 5108"},
        {"Geneva Identification System", "GEN# +1.00109282"},
        {"Geneva Identification System 2", "GEN# +5.21110182"},
        {"Smithsonian Astrophysical Observation", "SAO 82377"},
        {"Wilson Evans Batten Catalogue", "WEB 10905"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.38406728),
        dec: Angle.Degrees(+24.44873834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87900"},
        {"Hipparcos Number", "HIP 49691"},
        {"Smithsonian Astrophysical Observation", "SAO 81203"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.15749194),
        dec: Angle.Degrees(+24.44961170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73396"},
        {"Hipparcos Number", "HIP 42423"},
        {"Smithsonian Astrophysical Observation", "SAO 80314"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.76131367),
        dec: Angle.Degrees(+24.45049507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31730",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5270 A"},
        {"Henry Draper", "HD 47176"},
        {"Hipparcos Number", "HIP 31730"},
        {"Geneva Identification System", "GEN# +1.00047176"},
        {"Smithsonian Astrophysical Observation", "SAO 78572"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.57876090),
        dec: Angle.Degrees(+24.45051453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143688"},
        {"Hipparcos Number", "HIP 78457"},
        {"Geneva Identification System", "GEN# +1.00143688"},
        {"Smithsonian Astrophysical Observation", "SAO 84142"},
        {"Wilson Evans Batten Catalogue", "WEB 13263"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.25917464),
        dec: Angle.Degrees(+24.45067433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93964"},
        {"Hipparcos Number", "HIP 53034"},
        {"Smithsonian Astrophysical Observation", "SAO 81548"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.76924203),
        dec: Angle.Degrees(+24.45134315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75988"},
        {"Smithsonian Astrophysical Observation", "SAO 83862"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.77169252),
        dec: Angle.Degrees(+24.45139576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167044"},
        {"Hipparcos Number", "HIP 89230"},
        {"Smithsonian Astrophysical Observation", "SAO 85823"},
        {"Wilson Evans Batten Catalogue", "WEB 15166"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.13413784),
        dec: Angle.Degrees(+24.45164293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341338"},
        {"Hipparcos Number", "HIP 103147"},
        {"Geneva Identification System", "GEN# +1.00341338"},
        {"Smithsonian Astrophysical Observation", "SAO 89256"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.48199534),
        dec: Angle.Degrees(+24.45200339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106605",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15115 AB"},
        {"Henry Draper", "HD 205541"},
        {"Hipparcos Number", "HIP 106605"},
        {"Smithsonian Astrophysical Observation", "SAO 89819"},
        {"Wilson Evans Batten Catalogue", "WEB 19286"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.86261965),
        dec: Angle.Degrees(+24.45218695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77350"},
        {"Hipparcos Number", "HIP 44405"},
        {"Fundamental Katalog 5th Edition", "FK5 2714"},
        {"Geneva Identification System", "GEN# +1.00077350"},
        {"Renson", "Renson 21860"},
        {"Smithsonian Astrophysical Observation", "SAO 80595"},
        {"Wilson Evans Batten Catalogue", "WEB 8512"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.68444595),
        dec: Angle.Degrees(+24.45293256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81084"},
        {"Hipparcos Number", "HIP 46112"},
        {"Geneva Identification System", "GEN# +1.00081084"},
        {"Smithsonian Astrophysical Observation", "SAO 80803"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.06055636),
        dec: Angle.Degrees(+24.45633968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53887"},
        {"Smithsonian Astrophysical Observation", "SAO 81629"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.37251950),
        dec: Angle.Degrees(+24.45741683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6836"},
        {"Hipparcos Number", "HIP 5427"},
        {"Smithsonian Astrophysical Observation", "SAO 74520"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.32217079),
        dec: Angle.Degrees(+24.45868681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190816"},
        {"Hipparcos Number", "HIP 98997"},
        {"Smithsonian Astrophysical Observation", "SAO 88185"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.48297983),
        dec: Angle.Degrees(+24.46024184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140664"},
        {"Hipparcos Number", "HIP 77063"},
        {"Smithsonian Astrophysical Observation", "SAO 83971"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.02486962),
        dec: Angle.Degrees(+24.46037466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24802"},
        {"Hipparcos Number", "HIP 18508"},
        {"Geneva Identification System", "GEN# +1.00024802"},
        {"Smithsonian Astrophysical Observation", "SAO 76350"},
        {"Wilson Evans Batten Catalogue", "WEB 3567"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.35993764),
        dec: Angle.Degrees(+24.46195525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198014"},
        {"Hipparcos Number", "HIP 102537"},
        {"Smithsonian Astrophysical Observation", "SAO 89116"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.68557011),
        dec: Angle.Degrees(+24.46250004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128547"},
        {"Hipparcos Number", "HIP 71461"},
        {"Smithsonian Astrophysical Observation", "SAO 83436"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.22452302),
        dec: Angle.Degrees(+24.46307855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207419"},
        {"Hipparcos Number", "HIP 107642"},
        {"Smithsonian Astrophysical Observation", "SAO 90012"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.04545890),
        dec: Angle.Degrees(+24.46422903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16664",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2616 AB"},
        {"Henry Draper", "HD 22091"},
        {"Hipparcos Number", "HIP 16664"},
        {"Geneva Identification System", "GEN# +1.00022091J"},
        {"Smithsonian Astrophysical Observation", "SAO 75999"},
        {"Wilson Evans Batten Catalogue", "WEB 3176"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.61093000),
        dec: Angle.Degrees(+24.46447543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220847"},
        {"Hipparcos Number", "HIP 115745"},
        {"Smithsonian Astrophysical Observation", "SAO 91272"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.74801100),
        dec: Angle.Degrees(+24.46589838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17044"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.80608394),
        dec: Angle.Degrees(+24.46663095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17531",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Taygeta"},
        {"Common Name 2", "Taygete"},
        {"Henry Draper", "HD 23338"},
        {"Hipparcos Number", "HIP 17531"},
        {"Celescope Catalog", "CEL 319"},
        {"Geneva Identification System", "GEN# +5.20220563"},
        {"Smithsonian Astrophysical Observation", "SAO 76140"},
        {"Wilson Evans Batten Catalogue", "WEB 3324"},
    },
    visualMagnitude: 4.30,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.30200876),
        dec: Angle.Degrees(+24.46737879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162428"},
        {"Hipparcos Number", "HIP 87278"},
        {"Geneva Identification System", "GEN# +1.00162428"},
        {"Smithsonian Astrophysical Observation", "SAO 85456"},
        {"Wilson Evans Batten Catalogue", "WEB 14721"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.50513966),
        dec: Angle.Degrees(+24.46808043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247638"},
        {"Hipparcos Number", "HIP 27381"},
        {"Smithsonian Astrophysical Observation", "SAO 77570"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.98480467),
        dec: Angle.Degrees(+24.47038932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44033"},
        {"Geneva Identification System", "GEN# +9.80009036"},
    },
    visualMagnitude: 11.94,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.49635249),
        dec: Angle.Degrees(+24.47350899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79930"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.71463678),
        dec: Angle.Degrees(+24.47371126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28472"},
        {"Wilson Evans Batten Catalogue", "WEB 5564"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.17091342),
        dec: Angle.Degrees(+24.47385316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42248",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42248"},
        {"Smithsonian Astrophysical Observation", "SAO 80286"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.20049166),
        dec: Angle.Degrees(+24.47442547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 127.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101109"},
        {"Hipparcos Number", "HIP 56758"},
        {"Smithsonian Astrophysical Observation", "SAO 81913"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.54212181),
        dec: Angle.Degrees(+24.47479209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201214"},
        {"Hipparcos Number", "HIP 104275"},
        {"Smithsonian Astrophysical Observation", "SAO 89470"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.87233163),
        dec: Angle.Degrees(+24.47487368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52102"},
        {"Hipparcos Number", "HIP 33782"},
        {"Smithsonian Astrophysical Observation", "SAO 78967"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.22032017),
        dec: Angle.Degrees(+24.48076394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73797"},
    },
    visualMagnitude: 10.48,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.24292616),
        dec: Angle.Degrees(+24.48502707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155104"},
        {"Hipparcos Number", "HIP 83876"},
        {"Fundamental Katalog 5th Edition", "FK5 5512"},
        {"Smithsonian Astrophysical Observation", "SAO 84873"},
        {"Wilson Evans Batten Catalogue", "WEB 14177"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.13976178),
        dec: Angle.Degrees(+24.48660718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16305"},
        {"Smithsonian Astrophysical Observation", "SAO 75954"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.55284267),
        dec: Angle.Degrees(+24.48686353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210595"},
        {"Hipparcos Number", "HIP 109501"},
        {"Geneva Identification System", "GEN# +1.00210595"},
        {"Smithsonian Astrophysical Observation", "SAO 90296"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.73947874),
        dec: Angle.Degrees(+24.48854646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63333"},
        {"Hipparcos Number", "HIP 38172"},
        {"Geneva Identification System", "GEN# +1.00063333"},
        {"Smithsonian Astrophysical Observation", "SAO 79718"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.32888195),
        dec: Angle.Degrees(+24.48877624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204039"},
        {"Hipparcos Number", "HIP 105765"},
        {"Smithsonian Astrophysical Observation", "SAO 89695"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.31702357),
        dec: Angle.Degrees(+24.49149570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224218"},
        {"Hipparcos Number", "HIP 117993"},
        {"Smithsonian Astrophysical Observation", "SAO 91587"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.00437407),
        dec: Angle.Degrees(+24.49197534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83134"},
        {"Smithsonian Astrophysical Observation", "SAO 84738"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.83569864),
        dec: Angle.Degrees(+24.49236382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64161"},
        {"Smithsonian Astrophysical Observation", "SAO 82676"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.25308298),
        dec: Angle.Degrees(+24.49360586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206114"},
        {"Hipparcos Number", "HIP 106932"},
        {"Smithsonian Astrophysical Observation", "SAO 89878"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.84359270),
        dec: Angle.Degrees(+24.49456440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31679"},
        {"Hipparcos Number", "HIP 23151"},
        {"Geneva Identification System", "GEN# +1.00031679"},
        {"Smithsonian Astrophysical Observation", "SAO 76868"},
        {"Wilson Evans Batten Catalogue", "WEB 4489"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.71980660),
        dec: Angle.Degrees(+24.49572158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76991"},
        {"Hipparcos Number", "HIP 44222"},
        {"Smithsonian Astrophysical Observation", "SAO 80568"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.10773155),
        dec: Angle.Degrees(+24.49654641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69786"},
        {"Smithsonian Astrophysical Observation", "SAO 83270"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.25696313),
        dec: Angle.Degrees(+24.49723045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200961"},
        {"Hipparcos Number", "HIP 104141"},
        {"Geneva Identification System", "GEN# +1.00200961"},
        {"Smithsonian Astrophysical Observation", "SAO 89453"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.49389609),
        dec: Angle.Degrees(+24.49868665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157198"},
        {"Hipparcos Number", "HIP 84887"},
        {"Geneva Identification System", "GEN# +1.00157198"},
        {"Smithsonian Astrophysical Observation", "SAO 85021"},
        {"Wilson Evans Batten Catalogue", "WEB 14336"},
    },
    visualMagnitude: 5.13,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.22591010),
        dec: Angle.Degrees(+24.49943984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193205"},
        {"Hipparcos Number", "HIP 100080"},
        {"Geneva Identification System", "GEN# +1.00193205"},
        {"Smithsonian Astrophysical Observation", "SAO 88487"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.55761917),
        dec: Angle.Degrees(+24.50143203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28866"},
        {"Hipparcos Number", "HIP 21275"},
        {"Geneva Identification System", "GEN# +1.00028866"},
        {"Smithsonian Astrophysical Observation", "SAO 76653"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.46585331),
        dec: Angle.Degrees(+24.50214605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5965"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.17798182),
        dec: Angle.Degrees(+24.50233629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59643"},
        {"Hipparcos Number", "HIP 36623"},
        {"Geneva Identification System", "GEN# +1.00059643"},
        {"Smithsonian Astrophysical Observation", "SAO 79474"},
        {"Wilson Evans Batten Catalogue", "WEB 7279"},
    },
    visualMagnitude: 8.02,
    bvColour: 2.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.97719480),
        dec: Angle.Degrees(+24.50350014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82859",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82859"},
        {"Smithsonian Astrophysical Observation", "SAO 84699"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.00467719),
        dec: Angle.Degrees(+24.50521912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11500"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.07438867),
        dec: Angle.Degrees(+24.50735945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107531"},
        {"Hipparcos Number", "HIP 60274"},
        {"Geneva Identification System", "GEN# +5.21110083"},
        {"Smithsonian Astrophysical Observation", "SAO 82264"},
        {"Wilson Evans Batten Catalogue", "WEB 10719"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.38491851),
        dec: Angle.Degrees(+24.51196682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10715 A"},
        {"Henry Draper", "HD 160835"},
        {"Hipparcos Number", "HIP 86537"},
        {"Geneva Identification System", "GEN# +1.00160835A"},
        {"Smithsonian Astrophysical Observation", "SAO 85310"},
        {"Wilson Evans Batten Catalogue", "WEB 14593"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.27290643),
        dec: Angle.Degrees(+24.51312096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63264",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63264"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.45815203),
        dec: Angle.Degrees(+24.51369323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109484"},
        {"Hipparcos Number", "HIP 61401"},
        {"Geneva Identification System", "GEN# +5.21110191"},
        {"Smithsonian Astrophysical Observation", "SAO 82391"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.72240008),
        dec: Angle.Degrees(+24.51529665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241955"},
        {"Hipparcos Number", "HIP 24494"},
        {"Smithsonian Astrophysical Observation", "SAO 77055"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.83153128),
        dec: Angle.Degrees(+24.51621479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126991"},
        {"Hipparcos Number", "HIP 70761"},
        {"Cincinnati Publication", "Ci 18 1903"},
        {"Geneva Identification System", "GEN# +1.00126991"},
        {"Smithsonian Astrophysical Observation", "SAO 83371"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.06750086),
        dec: Angle.Degrees(+24.51724863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10715 B"},
        {"Henry Draper", "HD 160835B"},
        {"Hipparcos Number", "HIP 86538"},
        {"Geneva Identification System", "GEN# +1.00160835B"},
        {"Wilson Evans Batten Catalogue", "WEB 14595"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.27351857),
        dec: Angle.Degrees(+24.51760308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2777"},
        {"Smithsonian Astrophysical Observation", "SAO 74122"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.86278227),
        dec: Angle.Degrees(+24.51771653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24132"},
        {"Hipparcos Number", "HIP 18050"},
        {"Geneva Identification System", "GEN# +5.20223031"},
        {"Smithsonian Astrophysical Observation", "SAO 76273"},
        {"Wilson Evans Batten Catalogue", "WEB 3480"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.86334041),
        dec: Angle.Degrees(+24.51876093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8368"},
        {"Hipparcos Number", "HIP 6472"},
        {"Geneva Identification System", "GEN# +1.00008368"},
        {"Smithsonian Astrophysical Observation", "SAO 74678"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.81385396),
        dec: Angle.Degrees(+24.51984651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23568"},
        {"Hipparcos Number", "HIP 17664"},
        {"Celescope Catalog", "CEL 333"},
        {"Geneva Identification System", "GEN# +5.20221234"},
        {"Smithsonian Astrophysical Observation", "SAO 76183"},
        {"Wilson Evans Batten Catalogue", "WEB 3366"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.74743102),
        dec: Angle.Degrees(+24.52023417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218099"},
        {"Hipparcos Number", "HIP 113987"},
        {"Geneva Identification System", "GEN# +1.00218099"},
        {"Smithsonian Astrophysical Observation", "SAO 90993"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.26423407),
        dec: Angle.Degrees(+24.52182970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139608"},
        {"Hipparcos Number", "HIP 76573"},
        {"Geneva Identification System", "GEN# +1.00139608"},
        {"Smithsonian Astrophysical Observation", "SAO 83921"},
        {"Wilson Evans Batten Catalogue", "WEB 12997"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.56931683),
        dec: Angle.Degrees(+24.52190754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5651"},
        {"Hipparcos Number", "HIP 4566"},
        {"Geneva Identification System", "GEN# +1.00005651"},
        {"Smithsonian Astrophysical Observation", "SAO 74404"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.61038571),
        dec: Angle.Degrees(+24.52214763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192341"},
        {"Hipparcos Number", "HIP 99669"},
        {"Smithsonian Astrophysical Observation", "SAO 88374"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.39215602),
        dec: Angle.Degrees(+24.52567496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93905",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12057 AB"},
        {"Henry Draper", "HD 178355"},
        {"Hipparcos Number", "HIP 93905"},
        {"Smithsonian Astrophysical Observation", "SAO 86831"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.82664118),
        dec: Angle.Degrees(+24.52583309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66652"},
        {"Smithsonian Astrophysical Observation", "SAO 82931"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.94204551),
        dec: Angle.Degrees(+24.52633329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146363"},
        {"Hipparcos Number", "HIP 79639"},
        {"Smithsonian Astrophysical Observation", "SAO 84263"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.78025966),
        dec: Angle.Degrees(+24.52683350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56388"},
        {"Hipparcos Number", "HIP 35324"},
        {"Smithsonian Astrophysical Observation", "SAO 79252"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.44525928),
        dec: Angle.Degrees(+24.52793478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23441"},
        {"Hipparcos Number", "HIP 17588"},
        {"Celescope Catalog", "CEL 329"},
        {"Geneva Identification System", "GEN# +5.20220859"},
        {"Smithsonian Astrophysical Observation", "SAO 76164"},
        {"Wilson Evans Batten Catalogue", "WEB 3346"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.51203181),
        dec: Angle.Degrees(+24.52800590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203886"},
        {"Hipparcos Number", "HIP 105689"},
        {"Geneva Identification System", "GEN# +1.00203886"},
        {"Smithsonian Astrophysical Observation", "SAO 89682"},
        {"Wilson Evans Batten Catalogue", "WEB 19183"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.09630045),
        dec: Angle.Degrees(+24.52841724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121604"},
        {"Hipparcos Number", "HIP 68045"},
        {"Geneva Identification System", "GEN# +1.00121604"},
        {"Smithsonian Astrophysical Observation", "SAO 83077"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.98406299),
        dec: Angle.Degrees(+24.53099151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155456"},
        {"Hipparcos Number", "HIP 84028"},
        {"Cincinnati Publication", "Ci 18 2290"},
        {"Geneva Identification System", "GEN# +1.00155456"},
        {"Smithsonian Astrophysical Observation", "SAO 84893"},
        {"Wilson Evans Batten Catalogue", "WEB 14196"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.65724797),
        dec: Angle.Degrees(+24.53186262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 235.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86206"},
        {"Smithsonian Astrophysical Observation", "SAO 85248"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.24356710),
        dec: Angle.Degrees(+24.53274466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41389"},
        {"Geneva Identification System", "GEN# +1.00071152"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.66590971),
        dec: Angle.Degrees(+24.53436429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7052"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.72215689),
        dec: Angle.Degrees(+24.53595181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35224",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5945 A"},
        {"Henry Draper", "HD 56152"},
        {"Hipparcos Number", "HIP 35224"},
        {"Renson", "Renson 15290"},
        {"Smithsonian Astrophysical Observation", "SAO 79238"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.20216091),
        dec: Angle.Degrees(+24.53633985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207002"},
        {"Hipparcos Number", "HIP 107419"},
        {"Geneva Identification System", "GEN# +1.00207002"},
        {"Smithsonian Astrophysical Observation", "SAO 89964"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.36398245),
        dec: Angle.Degrees(+24.53706393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185781"},
        {"Hipparcos Number", "HIP 96733"},
        {"Smithsonian Astrophysical Observation", "SAO 87525"},
        {"Wilson Evans Batten Catalogue", "WEB 16971"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.96391310),
        dec: Angle.Degrees(+24.53708475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37539"},
        {"Hipparcos Number", "HIP 26691"},
        {"Smithsonian Astrophysical Observation", "SAO 77375"},
        {"Wilson Evans Batten Catalogue", "WEB 5260"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.07600111),
        dec: Angle.Degrees(+24.53764681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129412"},
        {"Hipparcos Number", "HIP 71843"},
        {"Fundamental Katalog 5th Edition", "FK5 5305"},
        {"Geneva Identification System", "GEN# +1.00129412"},
        {"Smithsonian Astrophysical Observation", "SAO 83472"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.44110190),
        dec: Angle.Degrees(+24.53835441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109949"},
        {"Smithsonian Astrophysical Observation", "SAO 90370"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.02481313),
        dec: Angle.Degrees(+24.53842302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5945 B"},
        {"Hipparcos Number", "HIP 35222"},
    },
    visualMagnitude: 10.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.19986121),
        dec: Angle.Degrees(+24.53991046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202256"},
        {"Hipparcos Number", "HIP 104803"},
        {"Geneva Identification System", "GEN# +1.00202256"},
        {"Smithsonian Astrophysical Observation", "SAO 89546"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.48415122),
        dec: Angle.Degrees(+24.54058407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110299"},
        {"Smithsonian Astrophysical Observation", "SAO 90430"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.11618635),
        dec: Angle.Degrees(+24.54238488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20664"},
        {"Hipparcos Number", "HIP 15560"},
        {"Smithsonian Astrophysical Observation", "SAO 75876"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.11176313),
        dec: Angle.Degrees(+24.54323096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20211"},
        {"Hipparcos Number", "HIP 15181"},
        {"Geneva Identification System", "GEN# +1.00020211"},
        {"Smithsonian Astrophysical Observation", "SAO 75818"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.91619971),
        dec: Angle.Degrees(+24.54362600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163994"},
        {"Hipparcos Number", "HIP 87955"},
        {"Smithsonian Astrophysical Observation", "SAO 85592"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.51714858),
        dec: Angle.Degrees(+24.54369615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88008"},
        {"Hipparcos Number", "HIP 49749"},
        {"Geneva Identification System", "GEN# +1.00088008"},
        {"Smithsonian Astrophysical Observation", "SAO 81207"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.33422154),
        dec: Angle.Degrees(+24.54443092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84838",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84838"},
    },
    visualMagnitude: 11.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.09545095),
        dec: Angle.Degrees(+24.54521061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69084",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69084"},
    },
    visualMagnitude: 11.68,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.10516751),
        dec: Angle.Degrees(+24.54663593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84872"},
        {"Hipparcos Number", "HIP 48124"},
        {"Smithsonian Astrophysical Observation", "SAO 81022"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.17760367),
        dec: Angle.Degrees(+24.54703346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108806"},
        {"Hipparcos Number", "HIP 60983"},
        {"Geneva Identification System", "GEN# +5.21110154"},
        {"Smithsonian Astrophysical Observation", "SAO 82339"},
        {"Wilson Evans Batten Catalogue", "WEB 10854"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.49943585),
        dec: Angle.Degrees(+24.54803152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48365"},
        {"Hipparcos Number", "HIP 32254"},
        {"Smithsonian Astrophysical Observation", "SAO 78686"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.03329875),
        dec: Angle.Degrees(+24.54850656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183222"},
        {"Hipparcos Number", "HIP 95665"},
        {"Geneva Identification System", "GEN# +1.00183222"},
        {"Smithsonian Astrophysical Observation", "SAO 87234"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.89165976),
        dec: Angle.Degrees(+24.55086838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338337"},
        {"Hipparcos Number", "HIP 95355"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.99293864),
        dec: Angle.Degrees(+24.55255954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86590"},
        {"Hipparcos Number", "HIP 49018"},
        {"Geneva Identification System", "GEN# +1.00086590"},
        {"Smithsonian Astrophysical Observation", "SAO 81134"},
        {"Wilson Evans Batten Catalogue", "WEB 9094"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.00773226),
        dec: Angle.Degrees(+24.55282921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29334"},
        {"Hipparcos Number", "HIP 21591"},
        {"Geneva Identification System", "GEN# +1.00029334"},
        {"Smithsonian Astrophysical Observation", "SAO 76678"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.54081599),
        dec: Angle.Degrees(+24.55371727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339530"},
        {"Hipparcos Number", "HIP 98887"},
        {"Smithsonian Astrophysical Observation", "SAO 88159"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.21086093),
        dec: Angle.Degrees(+24.55404336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17579",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Asterope"},
        {"Henry Draper", "HD 23432"},
        {"Hipparcos Number", "HIP 17579"},
        {"Celescope Catalog", "CEL 326"},
        {"Geneva Identification System", "GEN# +5.20220817"},
        {"Smithsonian Astrophysical Observation", "SAO 76159"},
        {"Wilson Evans Batten Catalogue", "WEB 3340"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.47693278),
        dec: Angle.Degrees(+24.55462128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76561"},
        {"Smithsonian Astrophysical Observation", "SAO 83920"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.54374976),
        dec: Angle.Degrees(+24.55642834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5316"},
        {"Hipparcos Number", "HIP 4317"},
        {"Geneva Identification System", "GEN# +1.00005316"},
        {"Smithsonian Astrophysical Observation", "SAO 74365"},
        {"Wilson Evans Batten Catalogue", "WEB 776"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.81107289),
        dec: Angle.Degrees(+24.55709613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148227"},
        {"Hipparcos Number", "HIP 80476"},
        {"Smithsonian Astrophysical Observation", "SAO 84369"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.40804265),
        dec: Angle.Degrees(+24.55732639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221905"},
        {"Hipparcos Number", "HIP 116465"},
        {"Fundamental Katalog 5th Edition", "FK5 3894"},
        {"Geneva Identification System", "GEN# +1.00221905"},
        {"Smithsonian Astrophysical Observation", "SAO 91367"},
        {"Wilson Evans Batten Catalogue", "WEB 20572"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.98308975),
        dec: Angle.Degrees(+24.56098741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122693"},
        {"Hipparcos Number", "HIP 68628"},
        {"Geneva Identification System", "GEN# +1.00122693"},
        {"Smithsonian Astrophysical Observation", "SAO 83138"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.71702354),
        dec: Angle.Degrees(+24.56183237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85087"},
        {"Hipparcos Number", "HIP 48248"},
        {"Geneva Identification System", "GEN# +1.00085087"},
        {"Smithsonian Astrophysical Observation", "SAO 81040"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.54322739),
        dec: Angle.Degrees(+24.56194265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77586"},
        {"Smithsonian Astrophysical Observation", "SAO 84029"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.61217776),
        dec: Angle.Degrees(+24.56383571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161074"},
        {"Hipparcos Number", "HIP 86667"},
        {"Geneva Identification System", "GEN# +1.00161074"},
        {"Smithsonian Astrophysical Observation", "SAO 85344"},
        {"Wilson Evans Batten Catalogue", "WEB 14614"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.61832228),
        dec: Angle.Degrees(+24.56431006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213837"},
        {"Hipparcos Number", "HIP 111385"},
        {"Wilson Evans Batten Catalogue", "WEB 19921"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.49305387),
        dec: Angle.Degrees(+24.56499238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43965"},
        {"Hipparcos Number", "HIP 30102"},
        {"Geneva Identification System", "GEN# +1.00043965"},
        {"Smithsonian Astrophysical Observation", "SAO 78236"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.02108666),
        dec: Angle.Degrees(+24.56674706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75556"},
        {"Smithsonian Astrophysical Observation", "SAO 83819"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.52590839),
        dec: Angle.Degrees(+24.75513728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108945"},
        {"Hipparcos Number", "HIP 61071"},
        {"Geneva Identification System", "GEN# +5.21110160"},
        {"Renson", "Renson 31610"},
        {"Smithsonian Astrophysical Observation", "SAO 82346"},
        {"Wilson Evans Batten Catalogue", "WEB 10871"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.75236725),
        dec: Angle.Degrees(+24.56718941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38751"},
        {"Hipparcos Number", "HIP 27468"},
        {"Fundamental Katalog 5th Edition", "FK5 2435"},
        {"Geneva Identification System", "GEN# +1.00038751"},
        {"Smithsonian Astrophysical Observation", "SAO 77592"},
        {"Wilson Evans Batten Catalogue", "WEB 5394"},
    },
    visualMagnitude: 4.88,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.25399777),
        dec: Angle.Degrees(+24.56755473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283509"},
        {"Hipparcos Number", "HIP 19604"},
        {"Smithsonian Astrophysical Observation", "SAO 76493"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.00731158),
        dec: Angle.Degrees(+24.56825772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100"},
        {"Hipparcos Number", "HIP 496"},
        {"Smithsonian Astrophysical Observation", "SAO 73737"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.48628758),
        dec: Angle.Degrees(+24.56904604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17020"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.73688327),
        dec: Angle.Degrees(+24.56991566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160923"},
        {"Hipparcos Number", "HIP 86586"},
        {"Smithsonian Astrophysical Observation", "SAO 85323"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.43009179),
        dec: Angle.Degrees(+24.57283411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185957"},
        {"Hipparcos Number", "HIP 96820"},
        {"Geneva Identification System", "GEN# +1.00185957"},
        {"Smithsonian Astrophysical Observation", "SAO 87556"},
        {"Wilson Evans Batten Catalogue", "WEB 16991"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.19758546),
        dec: Angle.Degrees(+24.57419339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2076"},
        {"Hipparcos Number", "HIP 1983"},
        {"Geneva Identification System", "GEN# +1.00002076"},
        {"Smithsonian Astrophysical Observation", "SAO 73963"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.27674358),
        dec: Angle.Degrees(+24.57523759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166281"},
        {"Hipparcos Number", "HIP 88910"},
        {"Geneva Identification System", "GEN# +1.00166281"},
        {"Smithsonian Astrophysical Observation", "SAO 85775"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.23694135),
        dec: Angle.Degrees(+24.57640448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93256"},
        {"Hipparcos Number", "HIP 52695"},
        {"Smithsonian Astrophysical Observation", "SAO 81510"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.61394887),
        dec: Angle.Degrees(+24.57648651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94387",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12166 AB"},
        {"Henry Draper", "HD 179736"},
        {"Hipparcos Number", "HIP 94387"},
        {"Smithsonian Astrophysical Observation", "SAO 86934"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.17668696),
        dec: Angle.Degrees(+24.57678206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55367"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.05556981),
        dec: Angle.Degrees(+24.57785140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283553"},
        {"Hipparcos Number", "HIP 20047"},
        {"Geneva Identification System", "GEN# +1.00283553"},
        {"Smithsonian Astrophysical Observation", "SAO 76537"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.48802025),
        dec: Angle.Degrees(+24.57795739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43384"},
        {"Smithsonian Astrophysical Observation", "SAO 80451"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.55974663),
        dec: Angle.Degrees(+24.58136835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151256"},
        {"Hipparcos Number", "HIP 82024"},
        {"Smithsonian Astrophysical Observation", "SAO 84579"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.33034343),
        dec: Angle.Degrees(+24.58324937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154973"},
        {"Hipparcos Number", "HIP 83814"},
        {"Smithsonian Astrophysical Observation", "SAO 84860"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.93987617),
        dec: Angle.Degrees(+24.58330290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5742",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 995 A"},
        {"Henry Draper", "HD 7318"},
        {"Hipparcos Number", "HIP 5742"},
        {"Fundamental Katalog 5th Edition", "FK5 2082"},
        {"Geneva Identification System", "GEN# +1.00007318"},
        {"Smithsonian Astrophysical Observation", "SAO 74571"},
        {"Wilson Evans Batten Catalogue", "WEB 1304"},
    },
    visualMagnitude: 4.67,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.43723014),
        dec: Angle.Degrees(+24.58376482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80665",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80665"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.03647335),
        dec: Angle.Degrees(+24.58620707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184539"},
        {"Hipparcos Number", "HIP 96227"},
        {"Renson", "Renson 50910"},
        {"Smithsonian Astrophysical Observation", "SAO 87366"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.51888024),
        dec: Angle.Degrees(+24.58791658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66140"},
        {"Hipparcos Number", "HIP 39387"},
        {"Geneva Identification System", "GEN# +1.00066140"},
        {"Smithsonian Astrophysical Observation", "SAO 79892"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.78602367),
        dec: Angle.Degrees(+24.58969455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61730"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.79565580),
        dec: Angle.Degrees(+24.59041721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47020"},
        {"Hipparcos Number", "HIP 31650"},
        {"Geneva Identification System", "GEN# +1.00047020"},
        {"Smithsonian Astrophysical Observation", "SAO 78557"},
        {"Wilson Evans Batten Catalogue", "WEB 6339"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.36371266),
        dec: Angle.Degrees(+24.59084471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31362"},
        {"Hipparcos Number", "HIP 22949"},
        {"Geneva Identification System", "GEN# +1.00031362"},
        {"Smithsonian Astrophysical Observation", "SAO 76848"},
        {"Wilson Evans Batten Catalogue", "WEB 4457"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.06496636),
        dec: Angle.Degrees(+24.59225291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107854"},
        {"Hipparcos Number", "HIP 60439"},
        {"Geneva Identification System", "GEN# +5.21110098"},
        {"Smithsonian Astrophysical Observation", "SAO 82282"},
        {"Wilson Evans Batten Catalogue", "WEB 10748"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.87482752),
        dec: Angle.Degrees(+24.59329173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72525"},
        {"Hipparcos Number", "HIP 42039"},
        {"Smithsonian Astrophysical Observation", "SAO 80254"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.54279244),
        dec: Angle.Degrees(+24.59335488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89865"},
        {"Hipparcos Number", "HIP 50823"},
        {"Geneva Identification System", "GEN# +1.00089865"},
        {"Smithsonian Astrophysical Observation", "SAO 81318"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.66049078),
        dec: Angle.Degrees(+24.59632363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122767"},
        {"Hipparcos Number", "HIP 68660"},
        {"Geneva Identification System", "GEN# +1.00122767"},
        {"Smithsonian Astrophysical Observation", "SAO 83143"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.81549510),
        dec: Angle.Degrees(+24.59750153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186379"},
        {"Hipparcos Number", "HIP 97023"},
        {"Geneva Identification System", "GEN# +1.00186379"},
        {"Smithsonian Astrophysical Observation", "SAO 87619"},
        {"Wilson Evans Batten Catalogue", "WEB 17024"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.77905778),
        dec: Angle.Degrees(+24.59859981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -271.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47415"},
        {"Hipparcos Number", "HIP 31850"},
        {"Geneva Identification System", "GEN# +1.00047415"},
        {"Smithsonian Astrophysical Observation", "SAO 78596"},
        {"Wilson Evans Batten Catalogue", "WEB 6401"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.88112691),
        dec: Angle.Degrees(+24.59994297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112748",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sadalbari"},
        {"Henry Draper", "HD 216131"},
        {"Hipparcos Number", "HIP 112748"},
        {"Fundamental Katalog 5th Edition", "FK5 862"},
        {"Geneva Identification System", "GEN# +1.00216131"},
        {"Smithsonian Astrophysical Observation", "SAO 90816"},
        {"Wilson Evans Batten Catalogue", "WEB 20089"},
    },
    visualMagnitude: 3.51,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.50041810),
        dec: Angle.Degrees(+24.60168486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22569"},
        {"Hipparcos Number", "HIP 16996"},
        {"Geneva Identification System", "GEN# +1.00022569"},
        {"Smithsonian Astrophysical Observation", "SAO 76041"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.64956987),
        dec: Angle.Degrees(+24.60168683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77935"},
        {"Smithsonian Astrophysical Observation", "SAO 84073"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.73897221),
        dec: Angle.Degrees(+24.60234889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84108"},
        {"Hipparcos Number", "HIP 47685"},
        {"Smithsonian Astrophysical Observation", "SAO 80986"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.84503922),
        dec: Angle.Degrees(+24.60492043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77694"},
        {"Hipparcos Number", "HIP 44571"},
        {"Smithsonian Astrophysical Observation", "SAO 80614"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.21453083),
        dec: Angle.Degrees(+24.60521977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13975"},
        {"Hipparcos Number", "HIP 10607"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.14177439),
        dec: Angle.Degrees(+24.60606234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7904"},
        {"Hipparcos Number", "HIP 6163"},
        {"Smithsonian Astrophysical Observation", "SAO 74633"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.76665894),
        dec: Angle.Degrees(+24.60619001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346569"},
        {"Hipparcos Number", "HIP 100848"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.70932033),
        dec: Angle.Degrees(+24.60706936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2360"},
        {"Smithsonian Astrophysical Observation", "SAO 74042"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.53866239),
        dec: Angle.Degrees(+24.60731568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64416"},
        {"Geneva Identification System", "GEN# +0.02502611"},
        {"Smithsonian Astrophysical Observation", "SAO 82707"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.03430758),
        dec: Angle.Degrees(+24.60897021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59861"},
        {"Geneva Identification System", "GEN# +5.21110040"},
        {"Smithsonian Astrophysical Observation", "SAO 82213"},
        {"Wilson Evans Batten Catalogue", "WEB 10637"},
    },
    visualMagnitude: 10.64,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.14119272),
        dec: Angle.Degrees(+24.60941076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110600"},
        {"Hipparcos Number", "HIP 62066"},
        {"Geneva Identification System", "GEN# +1.00110600"},
        {"Smithsonian Astrophysical Observation", "SAO 82455"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.80628496),
        dec: Angle.Degrees(+24.60967007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115762"},
        {"Hipparcos Number", "HIP 64955"},
        {"Cincinnati Publication", "Ci 18 1716"},
        {"Geneva Identification System", "GEN# +1.00115762"},
        {"Smithsonian Astrophysical Observation", "SAO 82775"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.71375921),
        dec: Angle.Degrees(+24.61148749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -293.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56570"},
        {"Geneva Identification System", "GEN# +0.02502393"},
        {"Smithsonian Astrophysical Observation", "SAO 81891"},
        {"Wilson Evans Batten Catalogue", "WEB 10168"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.95563508),
        dec: Angle.Degrees(+24.61167542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50998",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7758 AB"},
        {"Henry Draper", "HD 90183"},
        {"Hipparcos Number", "HIP 50998"},
        {"Geneva Identification System", "GEN# +1.00090183"},
        {"Smithsonian Astrophysical Observation", "SAO 81332"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.25742104),
        dec: Angle.Degrees(+24.61274671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118508"},
        {"Hipparcos Number", "HIP 66417"},
        {"Fundamental Katalog 5th Edition", "FK5 3085"},
        {"Geneva Identification System", "GEN# +1.00118508"},
        {"Smithsonian Astrophysical Observation", "SAO 82905"},
        {"Wilson Evans Batten Catalogue", "WEB 11726"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.24624858),
        dec: Angle.Degrees(+24.61330297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57420",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57420"},
        {"Smithsonian Astrophysical Observation", "SAO 81979"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.58191629),
        dec: Angle.Degrees(+24.61576597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40132"},
        {"Hipparcos Number", "HIP 28238"},
        {"Smithsonian Astrophysical Observation", "SAO 77776"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.50118979),
        dec: Angle.Degrees(+24.61714030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65430"},
        {"Smithsonian Astrophysical Observation", "SAO 82823"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.16044731),
        dec: Angle.Degrees(+24.61981888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73510"},
        {"Hipparcos Number", "HIP 42479"},
        {"Smithsonian Astrophysical Observation", "SAO 80324"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.90473558),
        dec: Angle.Degrees(+24.62041104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62294",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62294"},
        {"Smithsonian Astrophysical Observation", "SAO 82481"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.47698905),
        dec: Angle.Degrees(+24.62072986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78278"},
        {"Fundamental Katalog 5th Edition", "FK5 5409"},
        {"Smithsonian Astrophysical Observation", "SAO 84120"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.74198826),
        dec: Angle.Degrees(+24.62139880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39893"},
        {"Cincinnati Publication", "Ci 20 458"},
        {"Geneva Identification System", "GEN# +0.02501858"},
        {"Smithsonian Astrophysical Observation", "SAO 79975"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.22686766),
        dec: Angle.Degrees(+24.62489639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -384.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106842"},
        {"Hipparcos Number", "HIP 59902"},
        {"Geneva Identification System", "GEN# +5.21110044"},
        {"Smithsonian Astrophysical Observation", "SAO 82216"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.29575233),
        dec: Angle.Degrees(+24.62506435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187797"},
        {"Hipparcos Number", "HIP 97663"},
        {"Smithsonian Astrophysical Observation", "SAO 87810"},
    },
    visualMagnitude: 7.45,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.72875073),
        dec: Angle.Degrees(+24.62700655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 340767"},
        {"Hipparcos Number", "HIP 101822"},
        {"Geneva Identification System", "GEN# +1.00340767"},
        {"Smithsonian Astrophysical Observation", "SAO 88928"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.51899903),
        dec: Angle.Degrees(+24.62705843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104076"},
        {"Hipparcos Number", "HIP 58454"},
        {"Geneva Identification System", "GEN# +1.00104076"},
        {"Smithsonian Astrophysical Observation", "SAO 82086"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.80664732),
        dec: Angle.Degrees(+24.62797585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36546"},
        {"Hipparcos Number", "HIP 26062"},
        {"Geneva Identification System", "GEN# +1.00036546"},
        {"Smithsonian Astrophysical Observation", "SAO 77252"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.37814261),
        dec: Angle.Degrees(+24.62891325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3883"},
        {"Hipparcos Number", "HIP 3269"},
        {"Fundamental Katalog 5th Edition", "FK5 2044"},
        {"Geneva Identification System", "GEN# +1.00003883"},
        {"Renson", "Renson 1040"},
        {"Smithsonian Astrophysical Observation", "SAO 74200"},
        {"Wilson Evans Batten Catalogue", "WEB 583"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.39989696),
        dec: Angle.Degrees(+24.62906534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63830"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.23151990),
        dec: Angle.Degrees(+24.63001666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2284"},
        {"Hipparcos Number", "HIP 2116"},
        {"Geneva Identification System", "GEN# +1.00002284"},
        {"Smithsonian Astrophysical Observation", "SAO 73994"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.71695592),
        dec: Angle.Degrees(+24.63032362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15283"},
        {"Hipparcos Number", "HIP 11499"},
        {"Geneva Identification System", "GEN# +1.00015283"},
        {"Smithsonian Astrophysical Observation", "SAO 75386"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.07370464),
        dec: Angle.Degrees(+24.63169722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18028"},
        {"Hipparcos Number", "HIP 13549"},
        {"Smithsonian Astrophysical Observation", "SAO 75630"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.62541191),
        dec: Angle.Degrees(+24.63252388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336196"},
        {"Hipparcos Number", "HIP 90265"},
        {"Cincinnati Publication", "Ci 20 1086"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.27008362),
        dec: Angle.Degrees(+24.63566838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -447.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112115"},
        {"Hipparcos Number", "HIP 62943"},
        {"Geneva Identification System", "GEN# +1.00112115"},
        {"Smithsonian Astrophysical Observation", "SAO 82553"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.48102333),
        dec: Angle.Degrees(+24.63592874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 811"},
        {"Hipparcos Number", "HIP 1004"},
        {"Geneva Identification System", "GEN# +1.00000811"},
        {"Smithsonian Astrophysical Observation", "SAO 73814"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.13729126),
        dec: Angle.Degrees(+24.63640583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32070"},
        {"Hipparcos Number", "HIP 23384"},
        {"Cincinnati Publication", "Ci 18 646"},
        {"Geneva Identification System", "GEN# +1.00032070"},
        {"Smithsonian Astrophysical Observation", "SAO 76901"},
        {"Wilson Evans Batten Catalogue", "WEB 4542"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.40603215),
        dec: Angle.Degrees(+24.63722349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85843"},
        {"Hipparcos Number", "HIP 48642"},
        {"Geneva Identification System", "GEN# +1.00085843"},
        {"Smithsonian Astrophysical Observation", "SAO 81082"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.77472979),
        dec: Angle.Degrees(+24.63749301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67077"},
        {"Smithsonian Astrophysical Observation", "SAO 82981"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.21664505),
        dec: Angle.Degrees(+24.63964736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341196"},
        {"Hipparcos Number", "HIP 102654"},
        {"Fundamental Katalog 5th Edition", "FK5 5835"},
        {"Smithsonian Astrophysical Observation", "SAO 89137"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.04283384),
        dec: Angle.Degrees(+24.63987429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51101"},
        {"Hipparcos Number", "HIP 33419"},
        {"Geneva Identification System", "GEN# +1.00051101"},
        {"Smithsonian Astrophysical Observation", "SAO 78897"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.24914413),
        dec: Angle.Degrees(+24.64285883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76359"},
        {"Smithsonian Astrophysical Observation", "SAO 83901"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.92880990),
        dec: Angle.Degrees(+24.64324380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174000"},
        {"Hipparcos Number", "HIP 92195"},
        {"Geneva Identification System", "GEN# +1.00174000"},
        {"Smithsonian Astrophysical Observation", "SAO 86438"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.83802738),
        dec: Angle.Degrees(+24.64352187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12189",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1982 A"},
        {"Henry Draper", "HD 16246"},
        {"Hipparcos Number", "HIP 12189"},
        {"Geneva Identification System", "GEN# +1.00016246"},
        {"Smithsonian Astrophysical Observation", "SAO 75471"},
        {"Wilson Evans Batten Catalogue", "WEB 2503"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.25181558),
        dec: Angle.Degrees(+24.64725663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172342"},
        {"Hipparcos Number", "HIP 91421"},
        {"Geneva Identification System", "GEN# +1.00172342"},
        {"Smithsonian Astrophysical Observation", "SAO 86275"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.67289049),
        dec: Angle.Degrees(+24.64778695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12184",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1982 B"},
        {"Henry Draper", "HD 16232"},
        {"Hipparcos Number", "HIP 12184"},
        {"Geneva Identification System", "GEN# +1.00016232"},
        {"Smithsonian Astrophysical Observation", "SAO 75470"},
        {"Wilson Evans Batten Catalogue", "WEB 2502"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.24018291),
        dec: Angle.Degrees(+24.64809351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61813"},
        {"Smithsonian Astrophysical Observation", "SAO 82429"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.02464273),
        dec: Angle.Degrees(+24.64861015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58919"},
        {"Hipparcos Number", "HIP 36326"},
        {"Geneva Identification System", "GEN# +1.00058919"},
        {"Smithsonian Astrophysical Observation", "SAO 79416"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.16923097),
        dec: Angle.Degrees(+24.64877812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116029"},
        {"Hipparcos Number", "HIP 65117"},
        {"Geneva Identification System", "GEN# +1.00116029"},
        {"Smithsonian Astrophysical Observation", "SAO 82792"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.16479671),
        dec: Angle.Degrees(+24.64882435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191358"},
        {"Hipparcos Number", "HIP 99239"},
        {"Geneva Identification System", "GEN# +1.00191358"},
        {"Smithsonian Astrophysical Observation", "SAO 88245"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.17139180),
        dec: Angle.Degrees(+24.65118389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97336"},
        {"Henry Draper 2", "HD 97337"},
        {"Hipparcos Number", "HIP 54741"},
        {"Geneva Identification System", "GEN# +1.00097337"},
        {"Smithsonian Astrophysical Observation", "SAO 81717"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.12607775),
        dec: Angle.Degrees(+24.65183958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8622",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1473 AB"},
        {"Henry Draper", "HD 11284"},
        {"Hipparcos Number", "HIP 8622"},
        {"Smithsonian Astrophysical Observation", "SAO 74984"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.80557179),
        dec: Angle.Degrees(+24.65221539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218154"},
        {"Hipparcos Number", "HIP 114024"},
        {"Geneva Identification System", "GEN# +1.00218154"},
        {"Smithsonian Astrophysical Observation", "SAO 90999"},
        {"Wilson Evans Batten Catalogue", "WEB 20250"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.37089657),
        dec: Angle.Degrees(+24.65304335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85605",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85605"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.40078667),
        dec: Angle.Degrees(+24.65322144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 348.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337644"},
        {"Hipparcos Number", "HIP 93818"},
        {"Smithsonian Astrophysical Observation", "SAO 86810"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.59028021),
        dec: Angle.Degrees(+24.65433502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80967"},
        {"Smithsonian Astrophysical Observation", "SAO 84434"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.99912923),
        dec: Angle.Degrees(+24.65501135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108449"},
        {"Hipparcos Number", "HIP 60776"},
        {"Geneva Identification System", "GEN# +5.21110136"},
        {"Renson", "Renson 31497"},
        {"Smithsonian Astrophysical Observation", "SAO 82318"},
        {"Wilson Evans Batten Catalogue", "WEB 10813"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.86353058),
        dec: Angle.Degrees(+24.65552250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47751"},
        {"Hipparcos Number", "HIP 32003"},
        {"Smithsonian Astrophysical Observation", "SAO 78634"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.29853669),
        dec: Angle.Degrees(+24.65604972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152326"},
        {"Hipparcos Number", "HIP 82504"},
        {"Fundamental Katalog 5th Edition", "FK5 1440"},
        {"Geneva Identification System", "GEN# +1.00152326"},
        {"Smithsonian Astrophysical Observation", "SAO 84651"},
        {"Wilson Evans Batten Catalogue", "WEB 13928"},
    },
    visualMagnitude: 5.03,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.93856397),
        dec: Angle.Degrees(+24.65641963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85607"},
        {"Smithsonian Astrophysical Observation", "SAO 85144"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.40617622),
        dec: Angle.Degrees(+24.65681939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54487",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8071 A"},
        {"Henry Draper", "HD 96738"},
        {"Hipparcos Number", "HIP 54487"},
        {"Fundamental Katalog 5th Edition", "FK5 2889"},
        {"Geneva Identification System", "GEN# +1.00096738"},
        {"Smithsonian Astrophysical Observation", "SAO 81692"},
        {"Wilson Evans Batten Catalogue", "WEB 9836"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.20451678),
        dec: Angle.Degrees(+24.65844980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202975"},
        {"Hipparcos Number", "HIP 105205"},
        {"Smithsonian Astrophysical Observation", "SAO 89604"},
        {"Wilson Evans Batten Catalogue", "WEB 19108"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.66469995),
        dec: Angle.Degrees(+24.65949823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38753"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.00827082),
        dec: Angle.Degrees(+24.66077519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1289"},
        {"Hipparcos Number", "HIP 1379"},
        {"Smithsonian Astrophysical Observation", "SAO 73873"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.31575939),
        dec: Angle.Degrees(+24.66132298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38605"},
        {"Hipparcos Number", "HIP 27382"},
        {"Smithsonian Astrophysical Observation", "SAO 77571"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.99075282),
        dec: Angle.Degrees(+24.66154203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19608"},
        {"Hipparcos Number", "HIP 14718"},
        {"Smithsonian Astrophysical Observation", "SAO 75763"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.53349776),
        dec: Angle.Degrees(+24.66342291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54802"},
        {"Hipparcos Number", "HIP 34704"},
        {"Fundamental Katalog 5th Edition", "FK5 4649"},
        {"Smithsonian Astrophysical Observation", "SAO 79140"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.81408373),
        dec: Angle.Degrees(+24.66377500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95771",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Anser"},
        {"Henry Draper", "HD 183439"},
        {"Hipparcos Number", "HIP 95771"},
        {"Fundamental Katalog 5th Edition", "FK5 1508"},
        {"Geneva Identification System", "GEN# +1.00183439"},
        {"Smithsonian Astrophysical Observation", "SAO 87261"},
        {"Wilson Evans Batten Catalogue", "WEB 16759"},
    },
    visualMagnitude: 4.44,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.17671261),
        dec: Angle.Degrees(+24.66516482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64682"},
        {"Hipparcos Number", "HIP 38752"},
        {"Smithsonian Astrophysical Observation", "SAO 79803"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.00625895),
        dec: Angle.Degrees(+24.66570373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217424"},
        {"Hipparcos Number", "HIP 113582"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.08272568),
        dec: Angle.Degrees(+24.66580420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1583"},
        {"Hipparcos Number", "HIP 1619"},
        {"Geneva Identification System", "GEN# +1.00001583"},
        {"Smithsonian Astrophysical Observation", "SAO 73898"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.06030899),
        dec: Angle.Degrees(+24.66589133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1406",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1406"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.38716495),
        dec: Angle.Degrees(+24.66785674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204541"},
        {"Hipparcos Number", "HIP 106037"},
        {"Geneva Identification System", "GEN# +1.00204541"},
        {"Renson", "Renson 56970"},
        {"Smithsonian Astrophysical Observation", "SAO 89733"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.17635194),
        dec: Angle.Degrees(+24.67008380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83273"},
        {"Hipparcos Number", "HIP 47247"},
        {"Geneva Identification System", "GEN# +1.00083273"},
        {"Smithsonian Astrophysical Observation", "SAO 80935"},
        {"Wilson Evans Batten Catalogue", "WEB 8883"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.45815035),
        dec: Angle.Degrees(+24.67031743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192944"},
        {"Hipparcos Number", "HIP 99951"},
        {"Fundamental Katalog 5th Edition", "FK5 760"},
        {"Geneva Identification System", "GEN# +1.00192944"},
        {"Smithsonian Astrophysical Observation", "SAO 88451"},
        {"Wilson Evans Batten Catalogue", "WEB 17985"},
    },
    visualMagnitude: 5.30,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.19615246),
        dec: Angle.Degrees(+24.67114227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69629"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.75889847),
        dec: Angle.Degrees(+24.67220507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203483"},
        {"Hipparcos Number", "HIP 105482"},
        {"Smithsonian Astrophysical Observation", "SAO 89649"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.46784346),
        dec: Angle.Degrees(+24.67241639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32369",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5409 A"},
        {"Henry Draper", "HD 48640"},
        {"Hipparcos Number", "HIP 32369"},
        {"Smithsonian Astrophysical Observation", "SAO 78706"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.34794230),
        dec: Angle.Degrees(+24.67247808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132304"},
        {"Hipparcos Number", "HIP 73203"},
        {"Geneva Identification System", "GEN# +1.00132304"},
        {"Smithsonian Astrophysical Observation", "SAO 83599"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.42341531),
        dec: Angle.Degrees(+24.67406450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 253516"},
        {"Hipparcos Number", "HIP 29558"},
        {"Smithsonian Astrophysical Observation", "SAO 78118"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.41926331),
        dec: Angle.Degrees(+24.67489441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134495"},
        {"Hipparcos Number", "HIP 74183"},
        {"Geneva Identification System", "GEN# +1.00134495"},
        {"Smithsonian Astrophysical Observation", "SAO 83692"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.37282994),
        dec: Angle.Degrees(+24.67595019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69313"},
        {"Hipparcos Number", "HIP 40595"},
        {"Geneva Identification System", "GEN# +1.00069313"},
        {"Smithsonian Astrophysical Observation", "SAO 80066"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.32041547),
        dec: Angle.Degrees(+24.67800045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171244"},
        {"Hipparcos Number", "HIP 90919"},
        {"Geneva Identification System", "GEN# +1.00171244"},
        {"Smithsonian Astrophysical Observation", "SAO 86178"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.19936867),
        dec: Angle.Degrees(+24.67921845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1786"},
        {"Hipparcos Number", "HIP 1759"},
        {"Geneva Identification System", "GEN# +1.00001786"},
        {"Smithsonian Astrophysical Observation", "SAO 73929"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.57102628),
        dec: Angle.Degrees(+24.67944161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11085"},
        {"Hipparcos Number", "HIP 8491"},
        {"Smithsonian Astrophysical Observation", "SAO 74954"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.36749521),
        dec: Angle.Degrees(+24.68020798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82028"},
        {"Hipparcos Number", "HIP 46595"},
        {"Smithsonian Astrophysical Observation", "SAO 80861"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.52444623),
        dec: Angle.Degrees(+24.68056746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45428"},
        {"Hipparcos Number", "HIP 30799"},
        {"Smithsonian Astrophysical Observation", "SAO 78407"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.07150769),
        dec: Angle.Degrees(+24.68147959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216963"},
        {"Hipparcos Number", "HIP 113323"},
        {"Smithsonian Astrophysical Observation", "SAO 90889"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.26029784),
        dec: Angle.Degrees(+24.68220353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207901"},
        {"Hipparcos Number", "HIP 107916"},
        {"Geneva Identification System", "GEN# +1.00207901"},
        {"Smithsonian Astrophysical Observation", "SAO 90055"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.95824800),
        dec: Angle.Degrees(+24.68326634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58036"},
        {"Smithsonian Astrophysical Observation", "SAO 82045"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.53479890),
        dec: Angle.Degrees(+24.68410965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38584"},
        {"Hipparcos Number", "HIP 27378"},
        {"Geneva Identification System", "GEN# +1.00038584"},
        {"Smithsonian Astrophysical Observation", "SAO 77569"},
        {"Wilson Evans Batten Catalogue", "WEB 5379"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.98389265),
        dec: Angle.Degrees(+24.68684846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37180"},
        {"Smithsonian Astrophysical Observation", "SAO 79564"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.58996488),
        dec: Angle.Degrees(+24.68778172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120895"},
        {"Hipparcos Number", "HIP 67668"},
        {"Geneva Identification System", "GEN# +1.00120895"},
        {"Smithsonian Astrophysical Observation", "SAO 83039"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.95576242),
        dec: Angle.Degrees(+24.68819196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58033",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58033"},
        {"Smithsonian Astrophysical Observation", "SAO 82044"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.53183285),
        dec: Angle.Degrees(+24.69026266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122052"},
        {"Hipparcos Number", "HIP 68302"},
        {"Geneva Identification System", "GEN# +1.00122052"},
        {"Smithsonian Astrophysical Observation", "SAO 83105"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.72593348),
        dec: Angle.Degrees(+24.69231577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 261669"},
        {"Hipparcos Number", "HIP 31963"},
        {"Smithsonian Astrophysical Observation", "SAO 78625"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.19806979),
        dec: Angle.Degrees(+24.69242737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222440"},
        {"Hipparcos Number", "HIP 116815"},
        {"Smithsonian Astrophysical Observation", "SAO 91415"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.12953443),
        dec: Angle.Degrees(+24.69484823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336859"},
        {"Hipparcos Number", "HIP 91856"},
        {"Smithsonian Astrophysical Observation", "SAO 86374"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.90882502),
        dec: Angle.Degrees(+24.69552967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120803"},
        {"Hipparcos Number", "HIP 67615"},
        {"Geneva Identification System", "GEN# +1.00120803"},
        {"Smithsonian Astrophysical Observation", "SAO 83035"},
        {"Wilson Evans Batten Catalogue", "WEB 11889"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.81802528),
        dec: Angle.Degrees(+24.69575037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150295"},
        {"Hipparcos Number", "HIP 81524"},
        {"Fundamental Katalog 5th Edition", "FK5 5473"},
        {"Geneva Identification System", "GEN# +1.00150295"},
        {"Smithsonian Astrophysical Observation", "SAO 84509"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.77481023),
        dec: Angle.Degrees(+24.69642682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11373 AB"},
        {"Henry Draper", "HD 170314"},
        {"Hipparcos Number", "HIP 90483"},
        {"Smithsonian Astrophysical Observation", "SAO 86083"},
        {"Wilson Evans Batten Catalogue", "WEB 15497"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.94120566),
        dec: Angle.Degrees(+24.69737786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22614"},
        {"Hipparcos Number", "HIP 17034"},
        {"Geneva Identification System", "GEN# +5.20223305"},
        {"Smithsonian Astrophysical Observation", "SAO 76046"},
        {"Wilson Evans Batten Catalogue", "WEB 3238"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.77795749),
        dec: Angle.Degrees(+24.70298281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11560 A"},
        {"Henry Draper", "HD 172586"},
        {"Hipparcos Number", "HIP 91539"},
        {"Smithsonian Astrophysical Observation", "SAO 86302"},
        {"Wilson Evans Batten Catalogue", "WEB 15738"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.02137561),
        dec: Angle.Degrees(+24.70340136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240661"},
        {"Hipparcos Number", "HIP 23796"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.69308696),
        dec: Angle.Degrees(+24.70542607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10833"},
    },
    visualMagnitude: 11.66,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.85421640),
        dec: Angle.Degrees(+24.70769137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140833"},
        {"Hipparcos Number", "HIP 77134"},
        {"Smithsonian Astrophysical Observation", "SAO 83981"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.23880575),
        dec: Angle.Degrees(+24.70864026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176212"},
        {"Hipparcos Number", "HIP 93121"},
        {"Smithsonian Astrophysical Observation", "SAO 86634"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.55241563),
        dec: Angle.Degrees(+24.70884124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55579"},
        {"Hipparcos Number", "HIP 34995"},
        {"Geneva Identification System", "GEN# +1.00055579"},
        {"Renson", "Renson 15120"},
        {"Smithsonian Astrophysical Observation", "SAO 79191"},
        {"Wilson Evans Batten Catalogue", "WEB 6997"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.61061674),
        dec: Angle.Degrees(+24.71116439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89344"},
        {"Hipparcos Number", "HIP 50516"},
        {"Smithsonian Astrophysical Observation", "SAO 81285"},
        {"Wilson Evans Batten Catalogue", "WEB 9266"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.75309046),
        dec: Angle.Degrees(+24.71212042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185375"},
        {"Hipparcos Number", "HIP 96568"},
        {"Geneva Identification System", "GEN# +1.00185375"},
        {"Smithsonian Astrophysical Observation", "SAO 87486"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.47480482),
        dec: Angle.Degrees(+24.71288105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39811"},
        {"Fundamental Katalog 5th Edition", "FK5 4730"},
        {"Smithsonian Astrophysical Observation", "SAO 79965"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.02535430),
        dec: Angle.Degrees(+24.71518348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90346"},
        {"Hipparcos Number", "HIP 51086"},
        {"Smithsonian Astrophysical Observation", "SAO 81339"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.56443343),
        dec: Angle.Degrees(+24.71534681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24302"},
        {"Hipparcos Number", "HIP 18154"},
        {"Geneva Identification System", "GEN# +5.20223329"},
        {"Smithsonian Astrophysical Observation", "SAO 76292"},
        {"Wilson Evans Batten Catalogue", "WEB 3498"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.22277909),
        dec: Angle.Degrees(+24.71584089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84153"},
        {"Smithsonian Astrophysical Observation", "SAO 84915"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.07417718),
        dec: Angle.Degrees(+24.71624028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174714"},
        {"Hipparcos Number", "HIP 92478"},
        {"Fundamental Katalog 5th Edition", "FK5 5656"},
        {"Smithsonian Astrophysical Observation", "SAO 86497"},
        {"Wilson Evans Batten Catalogue", "WEB 15981"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.70737144),
        dec: Angle.Degrees(+24.71999590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130870"},
        {"Hipparcos Number", "HIP 72550"},
        {"Geneva Identification System", "GEN# +1.00130870"},
        {"Smithsonian Astrophysical Observation", "SAO 83550"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.48448949),
        dec: Angle.Degrees(+24.72047221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91164"},
        {"Hipparcos Number", "HIP 51562"},
        {"Smithsonian Astrophysical Observation", "SAO 81398"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.99036366),
        dec: Angle.Degrees(+24.72310440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13214 A"},
        {"Henry Draper", "HD 189505"},
        {"Hipparcos Number", "HIP 98397"},
        {"Geneva Identification System", "GEN# +1.00189505"},
        {"Smithsonian Astrophysical Observation", "SAO 88030"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.88705866),
        dec: Angle.Degrees(+24.72332512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16684"},
        {"Hipparcos Number", "HIP 12532"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.31045066),
        dec: Angle.Degrees(+24.72341502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11060"},
        {"Hipparcos Number", "HIP 8466"},
        {"Smithsonian Astrophysical Observation", "SAO 74951"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.29393963),
        dec: Angle.Degrees(+24.72397971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112610"},
        {"Wilson Evans Batten Catalogue", "WEB 20078"},
    },
    visualMagnitude: 10.95,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.14766215),
        dec: Angle.Degrees(+24.72400707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21017"},
        {"Hipparcos Number", "HIP 15861"},
        {"Fundamental Katalog 5th Edition", "FK5 2240"},
        {"Geneva Identification System", "GEN# +1.00021017"},
        {"Smithsonian Astrophysical Observation", "SAO 75912"},
        {"Wilson Evans Batten Catalogue", "WEB 3028"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.07693671),
        dec: Angle.Degrees(+24.72418789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62298"},
        {"Smithsonian Astrophysical Observation", "SAO 82482"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.48421986),
        dec: Angle.Degrees(+24.72469663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178540"},
        {"Hipparcos Number", "HIP 93974"},
        {"Geneva Identification System", "GEN# +1.00178540"},
        {"Smithsonian Astrophysical Observation", "SAO 86847"},
        {"Wilson Evans Batten Catalogue", "WEB 16353"},
    },
    visualMagnitude: 6.59,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.00820985),
        dec: Angle.Degrees(+24.72603018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338155"},
        {"Hipparcos Number", "HIP 94756"},
        {"Smithsonian Astrophysical Observation", "SAO 87023"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.21619574),
        dec: Angle.Degrees(+24.72907270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184979"},
        {"Hipparcos Number", "HIP 96412"},
        {"Geneva Identification System", "GEN# +1.00184979"},
        {"Smithsonian Astrophysical Observation", "SAO 87425"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.02284664),
        dec: Angle.Degrees(+24.73019993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283350"},
        {"Hipparcos Number", "HIP 19137"},
        {"Fundamental Katalog 5th Edition", "FK5 4370"},
        {"Smithsonian Astrophysical Observation", "SAO 76450"},
        {"Wilson Evans Batten Catalogue", "WEB 3677"},
    },
    visualMagnitude: 8.75,
    bvColour: 2.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51954514),
        dec: Angle.Degrees(+24.73214904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98842"},
        {"Hipparcos Number", "HIP 55547"},
        {"Smithsonian Astrophysical Observation", "SAO 81796"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.67222045),
        dec: Angle.Degrees(+24.73357323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2577"},
        {"Smithsonian Astrophysical Observation", "SAO 74089"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.18166470),
        dec: Angle.Degrees(+24.73376158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81247"},
        {"Hipparcos Number", "HIP 46202"},
        {"Smithsonian Astrophysical Observation", "SAO 80817"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.30790519),
        dec: Angle.Degrees(+24.73420301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68775"},
        {"Hipparcos Number", "HIP 40388"},
        {"Smithsonian Astrophysical Observation", "SAO 80035"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.68140713),
        dec: Angle.Degrees(+24.73484216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2234"},
        {"Hipparcos Number", "HIP 2088"},
        {"Geneva Identification System", "GEN# +1.00002234"},
        {"Smithsonian Astrophysical Observation", "SAO 73985"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.59172317),
        dec: Angle.Degrees(+24.73499063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9090"},
        {"Fundamental Katalog 5th Edition", "FK5 4176"},
        {"Smithsonian Astrophysical Observation", "SAO 75042"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.27380319),
        dec: Angle.Degrees(+24.73602583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13607"},
        {"Smithsonian Astrophysical Observation", "SAO 75639"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.83584523),
        dec: Angle.Degrees(+24.73689223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70431"},
        {"Smithsonian Astrophysical Observation", "SAO 83334"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.12047579),
        dec: Angle.Degrees(+24.74208147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147665"},
        {"Hipparcos Number", "HIP 80189"},
        {"Geneva Identification System", "GEN# +1.00147665A"},
        {"Smithsonian Astrophysical Observation", "SAO 84331"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.57142707),
        dec: Angle.Degrees(+24.74210755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30418"},
        {"Hipparcos Number", "HIP 22334"},
        {"Fundamental Katalog 5th Edition", "FK5 4438"},
        {"Geneva Identification System", "GEN# +1.00030418"},
        {"Smithsonian Astrophysical Observation", "SAO 76765"},
        {"Wilson Evans Batten Catalogue", "WEB 4303"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.14856097),
        dec: Angle.Degrees(+24.74318954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125691"},
        {"Hipparcos Number", "HIP 70084"},
        {"Geneva Identification System", "GEN# +1.00125691"},
        {"Smithsonian Astrophysical Observation", "SAO 83296"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.13005123),
        dec: Angle.Degrees(+24.74504319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40934"},
        {"Smithsonian Astrophysical Observation", "SAO 80121"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.30331648),
        dec: Angle.Degrees(+24.74579166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135163"},
        {"Hipparcos Number", "HIP 74460"},
        {"Smithsonian Astrophysical Observation", "SAO 83719"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.24280251),
        dec: Angle.Degrees(+24.74629886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208764"},
        {"Hipparcos Number", "HIP 108430"},
        {"Smithsonian Astrophysical Observation", "SAO 90138"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.47604972),
        dec: Angle.Degrees(+24.74812016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36910"},
        {"Hipparcos Number", "HIP 26295"},
        {"Smithsonian Astrophysical Observation", "SAO 77299"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.99360522),
        dec: Angle.Degrees(+24.74842254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53417",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7979 AB"},
        {"Hipparcos Number", "HIP 53417"},
        {"Geneva Identification System", "GEN# +1.00094601J"},
    },
    visualMagnitude: 4.30,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.90353339),
        dec: Angle.Degrees(+24.74975451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130617"},
        {"Hipparcos Number", "HIP 72426"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.13421834),
        dec: Angle.Degrees(+24.75103441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31464"},
        {"Hipparcos Number", "HIP 23027"},
        {"Smithsonian Astrophysical Observation", "SAO 76855"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.27684030),
        dec: Angle.Degrees(+24.75221241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105898"},
        {"Hipparcos Number", "HIP 59414"},
        {"Geneva Identification System", "GEN# +5.21110013"},
        {"Smithsonian Astrophysical Observation", "SAO 82172"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.81359377),
        dec: Angle.Degrees(+24.75361437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337512"},
        {"Hipparcos Number", "HIP 93569"},
        {"Smithsonian Astrophysical Observation", "SAO 86749"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.86543371),
        dec: Angle.Degrees(+24.75478833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62075"},
        {"Smithsonian Astrophysical Observation", "SAO 82458"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.83502321),
        dec: Angle.Degrees(+24.75573985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72698"},
        {"Smithsonian Astrophysical Observation", "SAO 83558"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.94893894),
        dec: Angle.Degrees(+24.75594420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191357"},
        {"Hipparcos Number", "HIP 99236"},
        {"Geneva Identification System", "GEN# +1.00191357"},
        {"Smithsonian Astrophysical Observation", "SAO 88243"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.16639717),
        dec: Angle.Degrees(+24.75842184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104512"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.55016859),
        dec: Angle.Degrees(+24.76362224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62950"},
        {"Geneva Identification System", "GEN# +0.02502572"},
        {"Smithsonian Astrophysical Observation", "SAO 82555"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.49380505),
        dec: Angle.Degrees(+24.76730738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183491"},
        {"Hipparcos Number", "HIP 95785"},
        {"Geneva Identification System", "GEN# +1.00183491"},
        {"Smithsonian Astrophysical Observation", "SAO 87267"},
        {"Wilson Evans Batten Catalogue", "WEB 16766"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.23782315),
        dec: Angle.Degrees(+24.76868131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219487"},
        {"Hipparcos Number", "HIP 114863"},
        {"Geneva Identification System", "GEN# +1.00219487"},
        {"Smithsonian Astrophysical Observation", "SAO 91133"},
        {"Wilson Evans Batten Catalogue", "WEB 20359"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.99094364),
        dec: Angle.Degrees(+24.77094006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221204"},
        {"Hipparcos Number", "HIP 115982"},
        {"Smithsonian Astrophysical Observation", "SAO 91306"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.47630852),
        dec: Angle.Degrees(+24.77237555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107078"},
        {"Wilson Evans Batten Catalogue", "WEB 19341"},
    },
    visualMagnitude: 11.24,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.31996095),
        dec: Angle.Degrees(+24.77347308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107655"},
        {"Hipparcos Number", "HIP 60327"},
        {"Geneva Identification System", "GEN# +5.21110089"},
        {"Renson", "Renson 31210"},
        {"Smithsonian Astrophysical Observation", "SAO 82271"},
        {"Wilson Evans Batten Catalogue", "WEB 10729"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.54526433),
        dec: Angle.Degrees(+24.77387685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163130"},
        {"Hipparcos Number", "HIP 87593"},
        {"Geneva Identification System", "GEN# +1.00163130"},
        {"Smithsonian Astrophysical Observation", "SAO 85520"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.40071480),
        dec: Angle.Degrees(+24.77718193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196773"},
        {"Hipparcos Number", "HIP 101881"},
        {"Smithsonian Astrophysical Observation", "SAO 88951"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.68161217),
        dec: Angle.Degrees(+24.77801123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124548"},
        {"Hipparcos Number", "HIP 69490"},
        {"Geneva Identification System", "GEN# +1.00124548"},
        {"Smithsonian Astrophysical Observation", "SAO 83231"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.41422888),
        dec: Angle.Degrees(+24.77819624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180584"},
        {"Hipparcos Number", "HIP 94695"},
        {"Geneva Identification System", "GEN# +1.00180584"},
        {"Smithsonian Astrophysical Observation", "SAO 87009"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.03418106),
        dec: Angle.Degrees(+24.77956135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204879"},
        {"Hipparcos Number", "HIP 106219"},
        {"Geneva Identification System", "GEN# +1.00204879"},
        {"Smithsonian Astrophysical Observation", "SAO 89763"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.72191428),
        dec: Angle.Degrees(+24.78103559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109545"},
        {"Smithsonian Astrophysical Observation", "SAO 90304"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.84432779),
        dec: Angle.Degrees(+24.78281232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69600"},
        {"Geneva Identification System", "GEN# +0.02502746"},
        {"Smithsonian Astrophysical Observation", "SAO 83243"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.68056257),
        dec: Angle.Degrees(+24.78497714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86721",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10737 AB"},
        {"Henry Draper", "HD 161197"},
        {"Hipparcos Number", "HIP 86721"},
        {"Geneva Identification System", "GEN# +1.00161197J"},
        {"Smithsonian Astrophysical Observation", "SAO 85356"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.79440455),
        dec: Angle.Degrees(+24.78640739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122151"},
        {"Hipparcos Number", "HIP 68347"},
        {"Smithsonian Astrophysical Observation", "SAO 83114"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.86150429),
        dec: Angle.Degrees(+24.78643673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8875",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8875"},
        {"Smithsonian Astrophysical Observation", "SAO 75007"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.56409633),
        dec: Angle.Degrees(+24.78880164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7761"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.97840151),
        dec: Angle.Degrees(+24.79065283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341330"},
        {"Hipparcos Number", "HIP 103175"},
        {"Geneva Identification System", "GEN# +1.00341330"},
        {"Smithsonian Astrophysical Observation", "SAO 89260"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.56314752),
        dec: Angle.Degrees(+24.79230542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213027"},
        {"Hipparcos Number", "HIP 110913"},
        {"Smithsonian Astrophysical Observation", "SAO 90529"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.05797360),
        dec: Angle.Degrees(+24.79260374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222601"},
        {"Hipparcos Number", "HIP 116916"},
        {"Smithsonian Astrophysical Observation", "SAO 91423"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.48220608),
        dec: Angle.Degrees(+24.79268297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86168"},
        {"Hipparcos Number", "HIP 48810"},
        {"Smithsonian Astrophysical Observation", "SAO 81106"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.33469672),
        dec: Angle.Degrees(+24.79517175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336956"},
        {"Hipparcos Number", "HIP 92237"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.97430811),
        dec: Angle.Degrees(+24.79541063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63596"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.48528790),
        dec: Angle.Degrees(+24.79578704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42887"},
        {"Geneva Identification System", "GEN# +0.02501981"},
        {"Smithsonian Astrophysical Observation", "SAO 80390"},
        {"Wilson Evans Batten Catalogue", "WEB 8287"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.10317912),
        dec: Angle.Degrees(+24.79744149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -347.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189944"},
        {"Hipparcos Number", "HIP 98609"},
        {"Celescope Catalog", "CEL 4915"},
        {"Geneva Identification System", "GEN# +1.00189944"},
        {"Smithsonian Astrophysical Observation", "SAO 88088"},
        {"Wilson Evans Batten Catalogue", "WEB 17436"},
    },
    visualMagnitude: 5.88,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.43627799),
        dec: Angle.Degrees(+24.80042535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22394",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 12"},
        {"Henry Draper", "HD 283882"},
        {"Hipparcos Number", "HIP 22394"},
        {"Geneva Identification System", "GEN# +5.20250117"},
        {"Smithsonian Astrophysical Observation", "SAO 76773"},
        {"Wilson Evans Batten Catalogue", "WEB 4317"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.30388144),
        dec: Angle.Degrees(+24.80296868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 339230"},
        {"Hipparcos Number", "HIP 98142"},
        {"Smithsonian Astrophysical Observation", "SAO 87958"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.18271479),
        dec: Angle.Degrees(+24.80434350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101558"},
        {"Hipparcos Number", "HIP 57008"},
        {"Geneva Identification System", "GEN# +1.00101558"},
        {"Smithsonian Astrophysical Observation", "SAO 81942"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.30851103),
        dec: Angle.Degrees(+24.80597673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66287"},
        {"Geneva Identification System", "GEN# +0.02502649"},
        {"Smithsonian Astrophysical Observation", "SAO 82887"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.78838019),
        dec: Angle.Degrees(+24.80656095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84783"},
        {"Smithsonian Astrophysical Observation", "SAO 85012"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.94852816),
        dec: Angle.Degrees(+24.81122517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110041"},
        {"Smithsonian Astrophysical Observation", "SAO 90393"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.33388914),
        dec: Angle.Degrees(+24.81131738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44795",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44795"},
        {"Smithsonian Astrophysical Observation", "SAO 80647"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.93481254),
        dec: Angle.Degrees(+24.81261616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335580"},
        {"Hipparcos Number", "HIP 88535"},
        {"Smithsonian Astrophysical Observation", "SAO 85709"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.18317692),
        dec: Angle.Degrees(+24.81449728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338847"},
        {"Hipparcos Number", "HIP 96951"},
        {"Smithsonian Astrophysical Observation", "SAO 87601"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.62990841),
        dec: Angle.Degrees(+24.81649382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3937"},
    },
    visualMagnitude: 12.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.63797991),
        dec: Angle.Degrees(+24.81682158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 198.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137425"},
        {"Hipparcos Number", "HIP 75488"},
        {"Geneva Identification System", "GEN# +1.00137425"},
        {"Smithsonian Astrophysical Observation", "SAO 83811"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.30660098),
        dec: Angle.Degrees(+24.81712425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13055"},
        {"Hipparcos Number", "HIP 9963"},
        {"Smithsonian Astrophysical Observation", "SAO 75159"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.07091061),
        dec: Angle.Degrees(+24.81920942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63816"},
        {"Hipparcos Number", "HIP 38385"},
        {"Geneva Identification System", "GEN# +1.00063816"},
        {"Smithsonian Astrophysical Observation", "SAO 79753"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.94974509),
        dec: Angle.Degrees(+24.82081298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49430"},
        {"Smithsonian Astrophysical Observation", "SAO 81175"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.36153933),
        dec: Angle.Degrees(+24.82263390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196054"},
        {"Hipparcos Number", "HIP 101509"},
        {"Smithsonian Astrophysical Observation", "SAO 88850"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.55241983),
        dec: Angle.Degrees(+24.82278791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8185"},
        {"Hipparcos Number", "HIP 6354"},
        {"Smithsonian Astrophysical Observation", "SAO 74654"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.39940265),
        dec: Angle.Degrees(+24.82304931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 250757"},
        {"Hipparcos Number", "HIP 28684"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.84196287),
        dec: Angle.Degrees(+24.82336126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21293"},
        {"Hipparcos Number", "HIP 16071"},
        {"Smithsonian Astrophysical Observation", "SAO 75934"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.74742452),
        dec: Angle.Degrees(+24.82374896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91609",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11574 AB"},
        {"Henry Draper", "HD 172743"},
        {"Hipparcos Number", "HIP 91609"},
        {"Renson", "Renson 48440"},
        {"Smithsonian Astrophysical Observation", "SAO 86316"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.24846441),
        dec: Angle.Degrees(+24.82508775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32922"},
        {"Hipparcos Number", "HIP 23860"},
        {"Smithsonian Astrophysical Observation", "SAO 76967"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.91940013),
        dec: Angle.Degrees(+24.82571053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67544"},
        {"Hipparcos Number", "HIP 39941"},
        {"Geneva Identification System", "GEN# +1.00067544"},
        {"Smithsonian Astrophysical Observation", "SAO 79980"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.35365490),
        dec: Angle.Degrees(+24.82615468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82055"},
        {"Smithsonian Astrophysical Observation", "SAO 84583"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.41687256),
        dec: Angle.Degrees(+24.82729411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111811"},
        {"Smithsonian Astrophysical Observation", "SAO 90673"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.72356615),
        dec: Angle.Degrees(+24.82775563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1579 AB"},
        {"Henry Draper", "HD 12101"},
        {"Hipparcos Number", "HIP 9283"},
        {"Smithsonian Astrophysical Observation", "SAO 75071"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.82901151),
        dec: Angle.Degrees(+24.82907064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131552"},
        {"Hipparcos Number", "HIP 72866"},
        {"Fundamental Katalog 5th Edition", "FK5 5320"},
        {"Smithsonian Astrophysical Observation", "SAO 83570"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.41004790),
        dec: Angle.Degrees(+24.82982313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114093"},
        {"Hipparcos Number", "HIP 64089"},
        {"Geneva Identification System", "GEN# +1.00114093"},
        {"Smithsonian Astrophysical Observation", "SAO 82666"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.01017513),
        dec: Angle.Degrees(+24.83106073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47102"},
        {"Hipparcos Number", "HIP 31715"},
        {"Smithsonian Astrophysical Observation", "SAO 78569"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.50999932),
        dec: Angle.Degrees(+24.83452675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104603"},
        {"Hipparcos Number", "HIP 58731"},
        {"Geneva Identification System", "GEN# +1.00104603"},
        {"Smithsonian Astrophysical Observation", "SAO 82115"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.69450119),
        dec: Angle.Degrees(+24.83619862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13175"},
        {"Hipparcos Number", "HIP 10048"},
        {"Geneva Identification System", "GEN# +1.00013175"},
        {"Smithsonian Astrophysical Observation", "SAO 75170"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.34428073),
        dec: Angle.Degrees(+24.83650427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263660"},
        {"Hipparcos Number", "HIP 32527"},
        {"Smithsonian Astrophysical Observation", "SAO 78741"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.81356973),
        dec: Angle.Degrees(+24.83650557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69364"},
        {"Hipparcos Number", "HIP 40625"},
        {"Smithsonian Astrophysical Observation", "SAO 80070"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.40115650),
        dec: Angle.Degrees(+24.83715071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12820"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.20648892),
        dec: Angle.Degrees(+24.83860143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 281.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23324"},
        {"Hipparcos Number", "HIP 17527"},
        {"Celescope Catalog", "CEL 318"},
        {"Geneva Identification System", "GEN# +5.20220541"},
        {"Smithsonian Astrophysical Observation", "SAO 76137"},
        {"Wilson Evans Batten Catalogue", "WEB 3323"},
    },
    visualMagnitude: 5.66,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.29052841),
        dec: Angle.Degrees(+24.83937337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84379",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sarin"},
        {"Aitken", "ADS 10424 A"},
        {"Henry Draper", "HD 156164"},
        {"Henry Draper 2", "HD 156164A"},
        {"Hipparcos Number", "HIP 84379"},
        {"Fundamental Katalog 5th Edition", "FK5 641"},
        {"Geneva Identification System", "GEN# +1.00156164"},
        {"Smithsonian Astrophysical Observation", "SAO 84951"},
        {"Wilson Evans Batten Catalogue", "WEB 14243"},
    },
    visualMagnitude: 3.12,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.75801735),
        dec: Angle.Degrees(+24.83958739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76956"},
        {"Smithsonian Astrophysical Observation", "SAO 83959"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.70767271),
        dec: Angle.Degrees(+24.84024668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111395"},
        {"Hipparcos Number", "HIP 62523"},
        {"Fundamental Katalog 5th Edition", "FK5 3021"},
        {"Geneva Identification System", "GEN# +1.00111395"},
        {"Smithsonian Astrophysical Observation", "SAO 82511"},
        {"Wilson Evans Batten Catalogue", "WEB 11098"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.19693108),
        dec: Angle.Degrees(+24.84048369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -334.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6600"},
        {"Hipparcos Number", "HIP 5246"},
        {"Smithsonian Astrophysical Observation", "SAO 74497"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.77428621),
        dec: Angle.Degrees(+24.84146901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99767",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13566 A"},
        {"Henry Draper", "HD 192519"},
        {"Hipparcos Number", "HIP 99767"},
        {"Smithsonian Astrophysical Observation", "SAO 88394"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.62715556),
        dec: Angle.Degrees(+24.84478203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107132"},
        {"Hipparcos Number", "HIP 60063"},
        {"Geneva Identification System", "GEN# +5.21110058"},
        {"Smithsonian Astrophysical Observation", "SAO 82235"},
        {"Wilson Evans Batten Catalogue", "WEB 10675"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.75617171),
        dec: Angle.Degrees(+24.84618988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108719"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.35364484),
        dec: Angle.Degrees(+24.84649980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83433"},
        {"Smithsonian Astrophysical Observation", "SAO 84795"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.78933080),
        dec: Angle.Degrees(+24.84897768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149213"},
        {"Hipparcos Number", "HIP 80985"},
        {"Smithsonian Astrophysical Observation", "SAO 84437"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.08307988),
        dec: Angle.Degrees(+24.84911088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116585"},
        {"Smithsonian Astrophysical Observation", "SAO 91387"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.39235290),
        dec: Angle.Degrees(+24.84974751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117239"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.57896089),
        dec: Angle.Degrees(+24.85591712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113072"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.50324735),
        dec: Angle.Degrees(+24.85625063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223531"},
        {"Hipparcos Number", "HIP 117535"},
        {"Renson", "Renson 61250"},
        {"Smithsonian Astrophysical Observation", "SAO 91529"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.54472422),
        dec: Angle.Degrees(+24.85797357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150580"},
        {"Hipparcos Number", "HIP 81670"},
        {"Fundamental Katalog 5th Edition", "FK5 3323"},
        {"Geneva Identification System", "GEN# +1.00150580"},
        {"Smithsonian Astrophysical Observation", "SAO 84536"},
        {"Wilson Evans Batten Catalogue", "WEB 13793"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.25251666),
        dec: Angle.Degrees(+24.85869984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34266",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5775 A"},
        {"Henry Draper", "HD 53472"},
        {"Hipparcos Number", "HIP 34266"},
        {"Smithsonian Astrophysical Observation", "SAO 79054"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.54829772),
        dec: Angle.Degrees(+24.86017808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206915"},
        {"Hipparcos Number", "HIP 107371"},
        {"Geneva Identification System", "GEN# +1.00206915"},
        {"Smithsonian Astrophysical Observation", "SAO 89950"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.21231073),
        dec: Angle.Degrees(+24.86335583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 341427"},
        {"Hipparcos Number", "HIP 103708"},
        {"Smithsonian Astrophysical Observation", "SAO 89369"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.22385997),
        dec: Angle.Degrees(+24.86484547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198457"},
        {"Hipparcos Number", "HIP 102811"},
        {"Smithsonian Astrophysical Observation", "SAO 89174"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.42158278),
        dec: Angle.Degrees(+24.86610311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37989"},
        {"Smithsonian Astrophysical Observation", "SAO 79687"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.79008439),
        dec: Angle.Degrees(+24.86889866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134083"},
        {"Hipparcos Number", "HIP 73996"},
        {"Fundamental Katalog 5th Edition", "FK5 1396"},
        {"Geneva Identification System", "GEN# +1.00134083"},
        {"Smithsonian Astrophysical Observation", "SAO 83671"},
        {"Wilson Evans Batten Catalogue", "WEB 12638"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.82477948),
        dec: Angle.Degrees(+24.86959294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 184.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213026"},
        {"Hipparcos Number", "HIP 110910"},
        {"Smithsonian Astrophysical Observation", "SAO 90528"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.05260976),
        dec: Angle.Degrees(+24.86997384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3806",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3806"},
        {"Smithsonian Astrophysical Observation", "SAO 74285"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.23095382),
        dec: Angle.Degrees(+24.87097903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52593"},
        {"Geneva Identification System", "GEN# +6.20001035"},
    },
    visualMagnitude: 12.14,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.31045562),
        dec: Angle.Degrees(+24.87159530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82651"},
        {"Hipparcos Number", "HIP 46935"},
        {"Smithsonian Astrophysical Observation", "SAO 80907"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.49138900),
        dec: Angle.Degrees(+24.87340101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20429"},
        {"Hipparcos Number", "HIP 15361"},
        {"Geneva Identification System", "GEN# +1.00020429"},
        {"Smithsonian Astrophysical Observation", "SAO 75847"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.51744562),
        dec: Angle.Degrees(+24.87737660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157466"},
        {"Hipparcos Number", "HIP 85007"},
        {"Geneva Identification System", "GEN# +1.00157466"},
        {"Smithsonian Astrophysical Observation", "SAO 85045"},
        {"Wilson Evans Batten Catalogue", "WEB 14356"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.61504545),
        dec: Angle.Degrees(+24.87983674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16635"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.50747380),
        dec: Angle.Degrees(+24.88101310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2564"},
        {"Hipparcos Number", "HIP 2314"},
        {"Geneva Identification System", "GEN# +1.00002564"},
        {"Smithsonian Astrophysical Observation", "SAO 74038"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.37978967),
        dec: Angle.Degrees(+24.88118418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42332"},
        {"Hipparcos Number", "HIP 29334"},
        {"Smithsonian Astrophysical Observation", "SAO 78069"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.77028920),
        dec: Angle.Degrees(+24.88232121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116233"},
        {"Hipparcos Number", "HIP 65224"},
        {"Geneva Identification System", "GEN# +1.00116233"},
        {"Smithsonian Astrophysical Observation", "SAO 82800"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.49940481),
        dec: Angle.Degrees(+24.88235319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149403"},
        {"Hipparcos Number", "HIP 81075"},
        {"Smithsonian Astrophysical Observation", "SAO 84453"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.39344733),
        dec: Angle.Degrees(+24.88307053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99947"},
        {"Hipparcos Number", "HIP 56106"},
        {"Geneva Identification System", "GEN# +1.00099947"},
        {"Smithsonian Astrophysical Observation", "SAO 81854"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.50758244),
        dec: Angle.Degrees(+24.88447425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35025",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5909 A"},
        {"Henry Draper", "HD 55621"},
        {"Hipparcos Number", "HIP 35025"},
        {"Geneva Identification System", "GEN# +1.00055621"},
        {"Smithsonian Astrophysical Observation", "SAO 79199"},
        {"Wilson Evans Batten Catalogue", "WEB 7006"},
    },
    visualMagnitude: 5.84,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.67476926),
        dec: Angle.Degrees(+24.88520186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51267"},
        {"Smithsonian Astrophysical Observation", "SAO 81367"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.08312002),
        dec: Angle.Degrees(+24.88756057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188542"},
        {"Hipparcos Number", "HIP 97990"},
        {"Smithsonian Astrophysical Observation", "SAO 87915"},
        {"Wilson Evans Batten Catalogue", "WEB 17246"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.71293682),
        dec: Angle.Degrees(+24.88848041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65451"},
        {"Smithsonian Astrophysical Observation", "SAO 82824"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.21333918),
        dec: Angle.Degrees(+24.88885325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7371"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.74657446),
        dec: Angle.Degrees(+24.88948633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4105"},
        {"Hipparcos Number", "HIP 3427"},
        {"Geneva Identification System", "GEN# +1.00004105"},
        {"Smithsonian Astrophysical Observation", "SAO 74225"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.92009234),
        dec: Angle.Degrees(+24.89019331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241708"},
        {"Hipparcos Number", "HIP 24385"},
        {"Smithsonian Astrophysical Observation", "SAO 77042"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.47248459),
        dec: Angle.Degrees(+24.89137485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15952"},
        {"Hipparcos Number", "HIP 11993"},
        {"Fundamental Katalog 5th Edition", "FK5 4235"},
        {"Geneva Identification System", "GEN# +1.00015952"},
        {"Smithsonian Astrophysical Observation", "SAO 75452"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.66111633),
        dec: Angle.Degrees(+24.89281778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50003",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50003"},
        {"Smithsonian Astrophysical Observation", "SAO 81231"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.11961605),
        dec: Angle.Degrees(+24.89423430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 338030"},
        {"Hipparcos Number", "HIP 94622"},
        {"Wilson Evans Batten Catalogue", "WEB 16493"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.82787160),
        dec: Angle.Degrees(+24.89653555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 219.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31001"},
        {"Hipparcos Number", "HIP 22725"},
        {"Smithsonian Astrophysical Observation", "SAO 76809"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.32675250),
        dec: Angle.Degrees(+24.90275503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47026"},
        {"Smithsonian Astrophysical Observation", "SAO 80910"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.75827823),
        dec: Angle.Degrees(+24.90426223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 336534"},
        {"Hipparcos Number", "HIP 91101"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.74301042),
        dec: Angle.Degrees(+24.90516862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144921"},
        {"Hipparcos Number", "HIP 78994"},
        {"Geneva Identification System", "GEN# +1.00144921"},
        {"Smithsonian Astrophysical Observation", "SAO 84204"},
        {"Wilson Evans Batten Catalogue", "WEB 13353"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.86359063),
        dec: Angle.Degrees(+24.90840472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 335523"},
        {"Hipparcos Number", "HIP 88196"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.17127559),
        dec: Angle.Degrees(+24.90917285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 283549"},
        {"Hipparcos Number", "HIP 20065"},
        {"Smithsonian Astrophysical Observation", "SAO 76538"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.54254171),
        dec: Angle.Degrees(+24.91106437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182807"},
        {"Hipparcos Number", "HIP 95492"},
        {"Geneva Identification System", "GEN# +1.00182807"},
        {"Smithsonian Astrophysical Observation", "SAO 87190"},
        {"Wilson Evans Batten Catalogue", "WEB 16695"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.35779819),
        dec: Angle.Degrees(+24.91430832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -631.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198933"},
        {"Hipparcos Number", "HIP 103062"},
        {"Smithsonian Astrophysical Observation", "SAO 89236"},
    },
    visualMagnitude: 6.63,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.22326874),
        dec: Angle.Degrees(+24.91460199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112"},
        {"Hipparcos Number", "HIP 504"},
        {"Smithsonian Astrophysical Observation", "SAO 73739"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.51336417),
        dec: Angle.Degrees(+24.91664125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68139"},
        {"Smithsonian Astrophysical Observation", "SAO 83088"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.26215708),
        dec: Angle.Degrees(+24.91720812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52005"},
        {"Smithsonian Astrophysical Observation", "SAO 81443"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.36473029),
        dec: Angle.Degrees(+24.91721939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66237"},
        {"Geneva Identification System", "GEN# +0.02502648"},
        {"Smithsonian Astrophysical Observation", "SAO 82884"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.62360722),
        dec: Angle.Degrees(+24.91764146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51471"},
        {"Hipparcos Number", "HIP 33566"},
        {"Geneva Identification System", "GEN# +1.00051471"},
        {"Smithsonian Astrophysical Observation", "SAO 78924"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.61606333),
        dec: Angle.Degrees(+24.92036760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46532"},
        {"Hipparcos Number", "HIP 31412"},
        {"Smithsonian Astrophysical Observation", "SAO 78521"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.75571894),
        dec: Angle.Degrees(+24.92092033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245180"},
        {"Hipparcos Number", "HIP 26286"},
        {"Smithsonian Astrophysical Observation", "SAO 77294"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.95709492),
        dec: Angle.Degrees(+24.92299458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 337266"},
        {"Hipparcos Number", "HIP 93030"},
    },
    visualMagnitude: 9.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.27079398),
        dec: Angle.Degrees(+24.92534714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182238"},
        {"Hipparcos Number", "HIP 95247"},
        {"Smithsonian Astrophysical Observation", "SAO 87133"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.68122631),
        dec: Angle.Degrees(+24.92615593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136292"},
        {"Hipparcos Number", "HIP 74958"},
        {"Geneva Identification System", "GEN# +1.00136292"},
        {"Smithsonian Astrophysical Observation", "SAO 83762"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.76162097),
        dec: Angle.Degrees(+24.92623878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109931"},
        {"Cincinnati Publication", "Ci 18 2899"},
        {"Smithsonian Astrophysical Observation", "SAO 90368"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.97821620),
        dec: Angle.Degrees(+24.92818135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44208"},
        {"Geneva Identification System", "GEN# +9.80047020"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.07453480),
        dec: Angle.Degrees(+24.92977994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 121.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79115",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9937 A"},
        {"Henry Draper", "HD 145226"},
        {"Hipparcos Number", "HIP 79115"},
        {"Geneva Identification System", "GEN# +1.00145226"},
        {"Smithsonian Astrophysical Observation", "SAO 84212"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.22147152),
        dec: Angle.Degrees(+24.93059097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71604",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71604"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.66432478),
        dec: Angle.Degrees(+24.93225950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190538"},
        {"Hipparcos Number", "HIP 98861"},
        {"Smithsonian Astrophysical Observation", "SAO 88151"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.12803276),
        dec: Angle.Degrees(+24.93253112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
