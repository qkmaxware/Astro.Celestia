using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_35() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57394"},
    },
    visualMagnitude: 11.74,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.49835130),
        dec: Angle.Degrees(-30.91281044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216544"},
        {"Hipparcos Number", "HIP 113088"},
        {"Geneva Identification System", "GEN# +1.00216544"},
        {"Smithsonian Astrophysical Observation", "SAO 214174"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.53482534),
        dec: Angle.Degrees(-30.91252708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88553"},
        {"Hipparcos Number", "HIP 49974"},
        {"Smithsonian Astrophysical Observation", "SAO 201159"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.03974105),
        dec: Angle.Degrees(-30.91147656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218620"},
        {"Hipparcos Number", "HIP 114360"},
        {"Smithsonian Astrophysical Observation", "SAO 214348"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.41737395),
        dec: Angle.Degrees(-30.91022148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11439"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.87524010),
        dec: Angle.Degrees(-30.90970391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 448.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159784"},
        {"Hipparcos Number", "HIP 86285"},
        {"Geneva Identification System", "GEN# +1.00159784"},
        {"Smithsonian Astrophysical Observation", "SAO 209051"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.46252240),
        dec: Angle.Degrees(-30.90944027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53753"},
        {"Smithsonian Astrophysical Observation", "SAO 201992"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.96109746),
        dec: Angle.Degrees(-30.90940758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42570"},
        {"Hipparcos Number", "HIP 29255"},
        {"Smithsonian Astrophysical Observation", "SAO 196546"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.53095522),
        dec: Angle.Degrees(-30.90915829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170605"},
        {"Hipparcos Number", "HIP 90825"},
        {"Smithsonian Astrophysical Observation", "SAO 210271"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.92631158),
        dec: Angle.Degrees(-30.90864006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68295"},
        {"Hipparcos Number", "HIP 40028"},
        {"Smithsonian Astrophysical Observation", "SAO 198883"},
    },
    visualMagnitude: 8.67,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.63888072),
        dec: Angle.Degrees(-30.90789202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35242"},
        {"Geneva Identification System", "GEN# +5.11320014"},
        {"Smithsonian Astrophysical Observation", "SAO 197788"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.23782585),
        dec: Angle.Degrees(-30.90744801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103391"},
        {"Hipparcos Number", "HIP 58040"},
        {"Fundamental Katalog 5th Edition", "FK5 5048"},
        {"Geneva Identification System", "GEN# +1.00103391"},
        {"Smithsonian Astrophysical Observation", "SAO 202922"},
        {"Wilson Evans Batten Catalogue", "WEB 10395"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.54718516),
        dec: Angle.Degrees(-30.90710060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146836"},
        {"Hipparcos Number", "HIP 79980"},
        {"Fundamental Katalog 5th Edition", "FK5 1426"},
        {"Geneva Identification System", "GEN# +1.00146836A"},
        {"Smithsonian Astrophysical Observation", "SAO 207558"},
        {"Wilson Evans Batten Catalogue", "WEB 13538"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.88617634),
        dec: Angle.Degrees(-30.90676896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203085"},
        {"Hipparcos Number", "HIP 105400"},
        {"Smithsonian Astrophysical Observation", "SAO 212932"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.23696041),
        dec: Angle.Degrees(-30.90602767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98866"},
        {"Hipparcos Number", "HIP 55535"},
        {"Geneva Identification System", "GEN# +1.00098866A"},
        {"Smithsonian Astrophysical Observation", "SAO 202374"},
        {"Wilson Evans Batten Catalogue", "WEB 9985"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.62899654),
        dec: Angle.Degrees(-30.90309694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186417"},
        {"Hipparcos Number", "HIP 97210"},
        {"Smithsonian Astrophysical Observation", "SAO 211537"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.35138254),
        dec: Angle.Degrees(-30.90296405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11379"},
        {"Hipparcos Number", "HIP 8625"},
        {"Geneva Identification System", "GEN# +1.00011379"},
        {"Smithsonian Astrophysical Observation", "SAO 193335"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.81043397),
        dec: Angle.Degrees(-30.90294791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146835"},
        {"Hipparcos Number", "HIP 79979"},
        {"Geneva Identification System", "GEN# +1.00146835"},
        {"Smithsonian Astrophysical Observation", "SAO 207557"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.88117762),
        dec: Angle.Degrees(-30.90191660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45227"},
        {"Smithsonian Astrophysical Observation", "SAO 200108"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.25870486),
        dec: Angle.Degrees(-30.90153859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88287"},
        {"Hipparcos Number", "HIP 49819"},
        {"Smithsonian Astrophysical Observation", "SAO 201122"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.55291355),
        dec: Angle.Degrees(-30.89842510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207155"},
        {"Hipparcos Number", "HIP 107608"},
        {"Fundamental Katalog 5th Edition", "FK5 3741"},
        {"Geneva Identification System", "GEN# +1.00207155"},
        {"Smithsonian Astrophysical Observation", "SAO 213292"},
        {"Wilson Evans Batten Catalogue", "WEB 19417"},
    },
    visualMagnitude: 5.02,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.93405546),
        dec: Angle.Degrees(-30.89830582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56731"},
        {"Hipparcos Number", "HIP 35241"},
        {"Geneva Identification System", "GEN# +5.11320003"},
        {"Renson", "Renson 15460"},
        {"Smithsonian Astrophysical Observation", "SAO 197789"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.23839680),
        dec: Angle.Degrees(-30.89694595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113030"},
        {"Smithsonian Astrophysical Observation", "SAO 214163"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.37065392),
        dec: Angle.Degrees(-30.89587694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199062"},
        {"Hipparcos Number", "HIP 103297"},
        {"Smithsonian Astrophysical Observation", "SAO 212543"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.90873368),
        dec: Angle.Degrees(-30.89571481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175417"},
        {"Hipparcos Number", "HIP 92976"},
        {"Smithsonian Astrophysical Observation", "SAO 210735"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.12729183),
        dec: Angle.Degrees(-30.89510426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127645"},
        {"Hipparcos Number", "HIP 71162"},
        {"Smithsonian Astrophysical Observation", "SAO 205687"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.32406059),
        dec: Angle.Degrees(-30.89501354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87660"},
        {"Hipparcos Number", "HIP 49450"},
        {"Smithsonian Astrophysical Observation", "SAO 201045"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.43874244),
        dec: Angle.Degrees(-30.89162665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140782"},
        {"Hipparcos Number", "HIP 77281"},
        {"Smithsonian Astrophysical Observation", "SAO 206963"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.67937851),
        dec: Angle.Degrees(-30.89137186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18227"},
        {"Hipparcos Number", "HIP 13554"},
        {"Geneva Identification System", "GEN# +1.00018227"},
        {"Smithsonian Astrophysical Observation", "SAO 193975"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.65325113),
        dec: Angle.Degrees(-30.89080862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37101"},
    },
    visualMagnitude: 9.96,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.35742822),
        dec: Angle.Degrees(-30.88853729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95900"},
        {"Smithsonian Astrophysical Observation", "SAO 211314"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.55154352),
        dec: Angle.Degrees(-30.88835092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134664"},
        {"Hipparcos Number", "HIP 74389"},
        {"Geneva Identification System", "GEN# +1.00134664"},
        {"Smithsonian Astrophysical Observation", "SAO 206400"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.04286252),
        dec: Angle.Degrees(-30.88603650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118748"},
        {"Hipparcos Number", "HIP 66624"},
        {"Smithsonian Astrophysical Observation", "SAO 204704"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.85050803),
        dec: Angle.Degrees(-30.88567300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72685"},
        {"Smithsonian Astrophysical Observation", "SAO 206017"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.91811241),
        dec: Angle.Degrees(-30.88477493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125667"},
        {"Hipparcos Number", "HIP 70189"},
        {"Smithsonian Astrophysical Observation", "SAO 205474"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.39629962),
        dec: Angle.Degrees(-30.88445457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209549"},
        {"Hipparcos Number", "HIP 108995"},
        {"Smithsonian Astrophysical Observation", "SAO 213527"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.20651542),
        dec: Angle.Degrees(-30.87839143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130922"},
        {"Hipparcos Number", "HIP 72684"},
        {"Renson", "Renson 37220"},
        {"Smithsonian Astrophysical Observation", "SAO 206016"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.91803198),
        dec: Angle.Degrees(-30.87810692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131750"},
        {"Hipparcos Number", "HIP 73098"},
        {"Renson", "Renson 37380"},
        {"Smithsonian Astrophysical Observation", "SAO 206108"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.08654761),
        dec: Angle.Degrees(-30.87717860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129589"},
        {"Hipparcos Number", "HIP 72037"},
        {"Smithsonian Astrophysical Observation", "SAO 205886"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.03497372),
        dec: Angle.Degrees(-30.87674112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78221"},
        {"Hipparcos Number", "HIP 44661"},
        {"Smithsonian Astrophysical Observation", "SAO 199971"},
    },
    visualMagnitude: 9.07,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.50956163),
        dec: Angle.Degrees(-30.87644782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32576",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32576"},
    },
    visualMagnitude: 11.99,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.96091731),
        dec: Angle.Degrees(-30.87557499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -253.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86228"},
        {"Hipparcos Number", "HIP 48738"},
        {"Smithsonian Astrophysical Observation", "SAO 200886"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.11697483),
        dec: Angle.Degrees(-30.87534732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115480"},
        {"Hipparcos Number", "HIP 64870"},
        {"Smithsonian Astrophysical Observation", "SAO 204330"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.44539465),
        dec: Angle.Degrees(-30.87490786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24361"},
        {"Hipparcos Number", "HIP 18040"},
        {"Smithsonian Astrophysical Observation", "SAO 194579"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.84118913),
        dec: Angle.Degrees(-30.87209764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183799"},
        {"Hipparcos Number", "HIP 96111"},
        {"Smithsonian Astrophysical Observation", "SAO 211345"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.11874718),
        dec: Angle.Degrees(-30.86938791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167362"},
        {"Hipparcos Number", "HIP 89535"},
    },
    visualMagnitude: 10.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.05119041),
        dec: Angle.Degrees(-30.86885976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194640"},
        {"Hipparcos Number", "HIP 100925"},
        {"Cincinnati Publication", "Ci 20 1207"},
        {"Geneva Identification System", "GEN# +1.00194640"},
        {"Smithsonian Astrophysical Observation", "SAO 212140"},
        {"Wilson Evans Batten Catalogue", "WEB 18233"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.93438673),
        dec: Angle.Degrees(-30.86657793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -521.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27168"},
        {"Hipparcos Number", "HIP 19905"},
        {"Geneva Identification System", "GEN# +1.00027168"},
        {"Smithsonian Astrophysical Observation", "SAO 194882"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.05521610),
        dec: Angle.Degrees(-30.86538628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211612"},
        {"Hipparcos Number", "HIP 110172"},
        {"Smithsonian Astrophysical Observation", "SAO 213729"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.74030799),
        dec: Angle.Degrees(-30.86525437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40852"},
        {"Hipparcos Number", "HIP 28427"},
        {"Geneva Identification System", "GEN# +1.00040852"},
        {"Smithsonian Astrophysical Observation", "SAO 196396"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.04644274),
        dec: Angle.Degrees(-30.86423205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126351"},
        {"Hipparcos Number", "HIP 70525"},
        {"Geneva Identification System", "GEN# +1.00126351"},
        {"Smithsonian Astrophysical Observation", "SAO 205543"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.39735016),
        dec: Angle.Degrees(-30.86374382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201227"},
        {"Hipparcos Number", "HIP 104412"},
        {"Geneva Identification System", "GEN# +1.00201227"},
        {"Smithsonian Astrophysical Observation", "SAO 212750"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.27599461),
        dec: Angle.Degrees(-30.86336099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46603"},
        {"Hipparcos Number", "HIP 31225"},
        {"Smithsonian Astrophysical Observation", "SAO 196923"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.24367869),
        dec: Angle.Degrees(-30.86315005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5270"},
        {"Hipparcos Number", "HIP 4248"},
        {"Geneva Identification System", "GEN# +1.00005270"},
        {"Smithsonian Astrophysical Observation", "SAO 192806"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.54529349),
        dec: Angle.Degrees(-30.86246609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173572"},
        {"Hipparcos Number", "HIP 92184"},
        {"Geneva Identification System", "GEN# +1.00173572"},
        {"Smithsonian Astrophysical Observation", "SAO 210573"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.82389417),
        dec: Angle.Degrees(-30.86165468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215919"},
        {"Hipparcos Number", "HIP 112668"},
        {"Smithsonian Astrophysical Observation", "SAO 214105"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.25293166),
        dec: Angle.Degrees(-30.86004250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3845"},
        {"Hipparcos Number", "HIP 3202"},
        {"Geneva Identification System", "GEN# +1.00003845"},
        {"Smithsonian Astrophysical Observation", "SAO 192674"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.19600646),
        dec: Angle.Degrees(-30.85936865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 823"},
        {"Hipparcos Number", "HIP 1003"},
        {"Geneva Identification System", "GEN# +1.00000823"},
        {"Smithsonian Astrophysical Observation", "SAO 192399"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.13675616),
        dec: Angle.Degrees(-30.85929019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22921"},
        {"Smithsonian Astrophysical Observation", "SAO 195410"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.98605524),
        dec: Angle.Degrees(-30.85813101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28396"},
        {"Smithsonian Astrophysical Observation", "SAO 196391"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.96915344),
        dec: Angle.Degrees(-30.85785385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69250"},
        {"Hipparcos Number", "HIP 40413"},
        {"Smithsonian Astrophysical Observation", "SAO 198989"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.75289372),
        dec: Angle.Degrees(-30.85712788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210835"},
        {"Hipparcos Number", "HIP 109739"},
        {"Geneva Identification System", "GEN# +1.00210835"},
        {"Smithsonian Astrophysical Observation", "SAO 213650"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.43825681),
        dec: Angle.Degrees(-30.85628736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32159"},
    },
    visualMagnitude: 12.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.73504328),
        dec: Angle.Degrees(-30.85617536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93296"},
        {"Hipparcos Number", "HIP 52646"},
        {"Smithsonian Astrophysical Observation", "SAO 201721"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.47617380),
        dec: Angle.Degrees(-30.85553280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23798"},
        {"Hipparcos Number", "HIP 17639"},
        {"Geneva Identification System", "GEN# +1.00023798"},
        {"Smithsonian Astrophysical Observation", "SAO 194522"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.69045353),
        dec: Angle.Degrees(-30.85369896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43450"},
        {"Hipparcos Number", "HIP 29658"},
        {"Renson", "Renson 11530"},
        {"Smithsonian Astrophysical Observation", "SAO 196623"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.72777286),
        dec: Angle.Degrees(-30.85338148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89526",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89526"},
    },
    visualMagnitude: 11.50,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.02325242),
        dec: Angle.Degrees(-30.85310961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190776"},
        {"Hipparcos Number", "HIP 99154"},
        {"Geneva Identification System", "GEN# +1.00190776"},
        {"Smithsonian Astrophysical Observation", "SAO 211834"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.94172954),
        dec: Angle.Degrees(-30.85193370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71930"},
        {"Hipparcos Number", "HIP 41611"},
        {"Smithsonian Astrophysical Observation", "SAO 199279"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.23990770),
        dec: Angle.Degrees(-30.84936708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97979"},
        {"Hipparcos Number", "HIP 55017"},
        {"Geneva Identification System", "GEN# +1.00097979"},
        {"Smithsonian Astrophysical Observation", "SAO 202255"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.97038717),
        dec: Angle.Degrees(-30.84842780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28011"},
        {"Hipparcos Number", "HIP 20544"},
        {"Smithsonian Astrophysical Observation", "SAO 194985"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.02951331),
        dec: Angle.Degrees(-30.84733070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82894"},
        {"Hipparcos Number", "HIP 46937"},
        {"Smithsonian Astrophysical Observation", "SAO 200502"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.49338666),
        dec: Angle.Degrees(-30.84704108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204140"},
        {"Hipparcos Number", "HIP 105954"},
        {"Smithsonian Astrophysical Observation", "SAO 213015"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.87251505),
        dec: Angle.Degrees(-30.84590665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153085"},
        {"Hipparcos Number", "HIP 83079"},
        {"Geneva Identification System", "GEN# +1.00153085"},
        {"Smithsonian Astrophysical Observation", "SAO 208255"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.64708027),
        dec: Angle.Degrees(-30.84410142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96081"},
        {"Hipparcos Number", "HIP 54139"},
        {"Smithsonian Astrophysical Observation", "SAO 202058"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.13711280),
        dec: Angle.Degrees(-30.84240751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58586"},
        {"Hipparcos Number", "HIP 35981"},
        {"Smithsonian Astrophysical Observation", "SAO 197973"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.23084402),
        dec: Angle.Degrees(-30.83986504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108682"},
        {"Hipparcos Number", "HIP 60930"},
        {"Geneva Identification System", "GEN# +1.00108682"},
        {"Smithsonian Astrophysical Observation", "SAO 203521"},
        {"Wilson Evans Batten Catalogue", "WEB 10843"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.32884155),
        dec: Angle.Degrees(-30.83982927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 270.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -337.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116896"},
        {"Smithsonian Astrophysical Observation", "SAO 214714"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.41947429),
        dec: Angle.Degrees(-30.83913928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179696"},
        {"Hipparcos Number", "HIP 94575"},
        {"Geneva Identification System", "GEN# +1.00179696"},
        {"Smithsonian Astrophysical Observation", "SAO 211087"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.70824512),
        dec: Angle.Degrees(-30.83742747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136181"},
        {"Hipparcos Number", "HIP 75053"},
        {"Smithsonian Astrophysical Observation", "SAO 206533"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.05078417),
        dec: Angle.Degrees(-30.83678194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220938"},
        {"Hipparcos Number", "HIP 115843"},
        {"Smithsonian Astrophysical Observation", "SAO 214562"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.02859031),
        dec: Angle.Degrees(-30.83664787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32569"},
        {"Hipparcos Number", "HIP 23476"},
        {"Smithsonian Astrophysical Observation", "SAO 195515"},
    },
    visualMagnitude: 9.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.69414953),
        dec: Angle.Degrees(-30.83636830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39267"},
        {"Hipparcos Number", "HIP 27557"},
        {"Smithsonian Astrophysical Observation", "SAO 196224"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.54635877),
        dec: Angle.Degrees(-30.83555769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216665"},
        {"Hipparcos Number", "HIP 113179"},
        {"Smithsonian Astrophysical Observation", "SAO 214180"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.77915677),
        dec: Angle.Degrees(-30.83493296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64362"},
        {"Hipparcos Number", "HIP 38424"},
        {"Smithsonian Astrophysical Observation", "SAO 198538"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.07458453),
        dec: Angle.Degrees(-30.83448034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103026"},
        {"Hipparcos Number", "HIP 57841"},
        {"Fundamental Katalog 5th Edition", "FK5 2948"},
        {"Geneva Identification System", "GEN# +1.00103026"},
        {"Smithsonian Astrophysical Observation", "SAO 202883"},
        {"Wilson Evans Batten Catalogue", "WEB 10375"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.92340338),
        dec: Angle.Degrees(-30.83409571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -293.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113129"},
        {"Hipparcos Number", "HIP 63585"},
        {"Smithsonian Astrophysical Observation", "SAO 204050"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.44984852),
        dec: Angle.Degrees(-30.83265421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29378"},
        {"Hipparcos Number", "HIP 21449"},
        {"Geneva Identification System", "GEN# +1.00029378"},
        {"Smithsonian Astrophysical Observation", "SAO 195153"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.09592613),
        dec: Angle.Degrees(-30.83238393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20423"},
        {"Hipparcos Number", "HIP 15218"},
        {"Geneva Identification System", "GEN# +1.00020423"},
        {"Smithsonian Astrophysical Observation", "SAO 194197"},
        {"Wilson Evans Batten Catalogue", "WEB 2935"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.04704665),
        dec: Angle.Degrees(-30.82749268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74414"},
        {"Smithsonian Astrophysical Observation", "SAO 206409"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.12218873),
        dec: Angle.Degrees(-30.82657912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175758"},
        {"Hipparcos Number", "HIP 93114"},
        {"Geneva Identification System", "GEN# +1.00175758"},
        {"Renson", "Renson 49080"},
        {"Smithsonian Astrophysical Observation", "SAO 210768"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.52721922),
        dec: Angle.Degrees(-30.82498886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199369"},
        {"Hipparcos Number", "HIP 103464"},
        {"Smithsonian Astrophysical Observation", "SAO 212578"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.42849605),
        dec: Angle.Degrees(-30.82368751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55568"},
        {"Hipparcos Number", "HIP 34782"},
        {"Geneva Identification System", "GEN# +5.11320002"},
        {"Renson", "Renson 15110"},
        {"Smithsonian Astrophysical Observation", "SAO 197686"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.01716282),
        dec: Angle.Degrees(-30.82142072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54362"},
        {"Geneva Identification System", "GEN# -0.03008970"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.82997866),
        dec: Angle.Degrees(-30.82059223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 324.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -383.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160091"},
        {"Hipparcos Number", "HIP 86408"},
        {"Geneva Identification System", "GEN# +1.00160091"},
        {"Smithsonian Astrophysical Observation", "SAO 209083"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.84429287),
        dec: Angle.Degrees(-30.81957622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88916"},
        {"Hipparcos Number", "HIP 50188"},
        {"Smithsonian Astrophysical Observation", "SAO 201203"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.67753858),
        dec: Angle.Degrees(-30.81748575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91937"},
        {"Hipparcos Number", "HIP 51920"},
        {"Smithsonian Astrophysical Observation", "SAO 201553"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.09519987),
        dec: Angle.Degrees(-30.81668001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93670"},
        {"Smithsonian Astrophysical Observation", "SAO 210885"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.12884672),
        dec: Angle.Degrees(-30.81522335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17926"},
        {"Hipparcos Number", "HIP 13363"},
        {"Geneva Identification System", "GEN# +1.00017926"},
        {"Smithsonian Astrophysical Observation", "SAO 193951"},
        {"Wilson Evans Batten Catalogue", "WEB 2676"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.98401010),
        dec: Angle.Degrees(-30.81477504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17693"},
        {"Hipparcos Number", "HIP 13174"},
        {"Smithsonian Astrophysical Observation", "SAO 193933"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.35692397),
        dec: Angle.Degrees(-30.81296624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196167"},
        {"Hipparcos Number", "HIP 101685"},
        {"Smithsonian Astrophysical Observation", "SAO 212278"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.16274812),
        dec: Angle.Degrees(-30.81265833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203448"},
        {"Hipparcos Number", "HIP 105580"},
        {"Geneva Identification System", "GEN# +1.00203448"},
        {"Smithsonian Astrophysical Observation", "SAO 212961"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.77599465),
        dec: Angle.Degrees(-30.81218356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 343.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 99.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 318786"},
        {"Hipparcos Number", "HIP 88276"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.39655417),
        dec: Angle.Degrees(-30.81198196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218084"},
        {"Hipparcos Number", "HIP 114022"},
        {"Smithsonian Astrophysical Observation", "SAO 214302"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.36756649),
        dec: Angle.Degrees(-30.81111632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110921"},
        {"Hipparcos Number", "HIP 62282"},
        {"Smithsonian Astrophysical Observation", "SAO 203783"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.45913393),
        dec: Angle.Degrees(-30.81066267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67380"},
        {"Hipparcos Number", "HIP 39678"},
        {"Smithsonian Astrophysical Observation", "SAO 198807"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.63304926),
        dec: Angle.Degrees(-30.81045914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202636"},
        {"Hipparcos Number", "HIP 105151"},
        {"Smithsonian Astrophysical Observation", "SAO 212877"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.50955681),
        dec: Angle.Degrees(-30.80980721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116195"},
        {"Hipparcos Number", "HIP 65256"},
        {"Smithsonian Astrophysical Observation", "SAO 204405"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.61426736),
        dec: Angle.Degrees(-30.80724524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3998"},
        {"Hipparcos Number", "HIP 3321"},
        {"Geneva Identification System", "GEN# +1.00003998"},
        {"Smithsonian Astrophysical Observation", "SAO 192687"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.58711607),
        dec: Angle.Degrees(-30.80678531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150924"},
        {"Hipparcos Number", "HIP 82022"},
        {"Smithsonian Astrophysical Observation", "SAO 207995"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.32923635),
        dec: Angle.Degrees(-30.80676278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80894"},
        {"Hipparcos Number", "HIP 45895"},
        {"Smithsonian Astrophysical Observation", "SAO 200272"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.35856000),
        dec: Angle.Degrees(-30.80619278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87020"},
        {"Hipparcos Number", "HIP 49128"},
        {"Geneva Identification System", "GEN# +1.00087020"},
        {"Smithsonian Astrophysical Observation", "SAO 200973"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.40670497),
        dec: Angle.Degrees(-30.80282667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182156"},
        {"Hipparcos Number", "HIP 95416"},
        {"Geneva Identification System", "GEN# +1.00182156"},
        {"Smithsonian Astrophysical Observation", "SAO 211241"},
        {"Wilson Evans Batten Catalogue", "WEB 16680"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.14286739),
        dec: Angle.Degrees(-30.80228442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7259"},
        {"Hipparcos Number", "HIP 5636"},
        {"Geneva Identification System", "GEN# +1.00007259"},
        {"Smithsonian Astrophysical Observation", "SAO 192977"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.09703339),
        dec: Angle.Degrees(-30.80196356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37100"},
    },
    visualMagnitude: 9.38,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.35552967),
        dec: Angle.Degrees(-30.80190789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210019"},
        {"Hipparcos Number", "HIP 109259"},
        {"Smithsonian Astrophysical Observation", "SAO 213572"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.03334839),
        dec: Angle.Degrees(-30.80150418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70928"},
        {"Hipparcos Number", "HIP 41131"},
        {"Smithsonian Astrophysical Observation", "SAO 199168"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.87798563),
        dec: Angle.Degrees(-30.80133476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67146"},
        {"Hipparcos Number", "HIP 39599"},
        {"Geneva Identification System", "GEN# +1.00067146"},
        {"Smithsonian Astrophysical Observation", "SAO 198782"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.38239363),
        dec: Angle.Degrees(-30.80129798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145574"},
        {"Hipparcos Number", "HIP 79454"},
        {"Smithsonian Astrophysical Observation", "SAO 207458"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.21706070),
        dec: Angle.Degrees(-30.79996784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126233"},
        {"Hipparcos Number", "HIP 70484"},
        {"Smithsonian Astrophysical Observation", "SAO 205533"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.25891434),
        dec: Angle.Degrees(-30.79960525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57120"},
        {"Hipparcos Number", "HIP 35391"},
        {"Geneva Identification System", "GEN# +5.11320007J"},
        {"Smithsonian Astrophysical Observation", "SAO 197827"},
        {"Wilson Evans Batten Catalogue", "WEB 7061"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63920012),
        dec: Angle.Degrees(-30.79879833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129571"},
        {"Hipparcos Number", "HIP 72030"},
        {"Geneva Identification System", "GEN# +1.00129571"},
        {"Smithsonian Astrophysical Observation", "SAO 205881"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.01531497),
        dec: Angle.Degrees(-30.79879728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -186.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183216"},
        {"Hipparcos Number", "HIP 95849"},
        {"Geneva Identification System", "GEN# +1.00183216"},
        {"Smithsonian Astrophysical Observation", "SAO 211305"},
        {"Wilson Evans Batten Catalogue", "WEB 16782"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.41903219),
        dec: Angle.Degrees(-30.79712295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -262.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13422"},
        {"Hipparcos Number", "HIP 10146"},
        {"Smithsonian Astrophysical Observation", "SAO 193551"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.62802800),
        dec: Angle.Degrees(-30.79420683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67733"},
        {"Hipparcos Number", "HIP 39819"},
        {"Geneva Identification System", "GEN# +1.00067733"},
        {"Smithsonian Astrophysical Observation", "SAO 198835"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.04107033),
        dec: Angle.Degrees(-30.79323777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61308"},
        {"Hipparcos Number", "HIP 37094"},
        {"Smithsonian Astrophysical Observation", "SAO 198193"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.33347882),
        dec: Angle.Degrees(-30.79221291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175853"},
        {"Hipparcos Number", "HIP 93168"},
        {"Smithsonian Astrophysical Observation", "SAO 210783"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.66458790),
        dec: Angle.Degrees(-30.79183045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14340"},
        {"Hipparcos Number", "HIP 10745"},
        {"Smithsonian Astrophysical Observation", "SAO 193631"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.56157737),
        dec: Angle.Degrees(-30.78955471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177823"},
        {"Hipparcos Number", "HIP 93923"},
        {"Smithsonian Astrophysical Observation", "SAO 210950"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.86822526),
        dec: Angle.Degrees(-30.78614255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52297",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52297"},
        {"Geneva Identification System", "GEN# -0.03008626"},
        {"Smithsonian Astrophysical Observation", "SAO 201636"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.28832855),
        dec: Angle.Degrees(-30.78453646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116987"},
        {"Hipparcos Number", "HIP 65662"},
        {"Geneva Identification System", "GEN# +1.00116987"},
        {"Smithsonian Astrophysical Observation", "SAO 204493"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.93772167),
        dec: Angle.Degrees(-30.78426291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75362"},
        {"Hipparcos Number", "HIP 43243"},
        {"Smithsonian Astrophysical Observation", "SAO 199646"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.14683624),
        dec: Angle.Degrees(-30.78357772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200141"},
        {"Hipparcos Number", "HIP 103853"},
        {"Geneva Identification System", "GEN# +1.00200141"},
        {"Smithsonian Astrophysical Observation", "SAO 212659"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.65847840),
        dec: Angle.Degrees(-30.78139842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25502"},
        {"Hipparcos Number", "HIP 18811"},
        {"Smithsonian Astrophysical Observation", "SAO 194704"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.46132251),
        dec: Angle.Degrees(-30.78120104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138616"},
        {"Hipparcos Number", "HIP 76232"},
        {"Smithsonian Astrophysical Observation", "SAO 206778"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.58495589),
        dec: Angle.Degrees(-30.78097038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151533"},
        {"Hipparcos Number", "HIP 82317"},
        {"Renson", "Renson 42860"},
        {"Smithsonian Astrophysical Observation", "SAO 208064"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.29641344),
        dec: Angle.Degrees(-30.78087560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215655"},
        {"Hipparcos Number", "HIP 112488"},
        {"Smithsonian Astrophysical Observation", "SAO 214076"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.77434427),
        dec: Angle.Degrees(-30.78069728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153612"},
        {"Hipparcos Number", "HIP 83325"},
        {"Smithsonian Astrophysical Observation", "SAO 208322"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.45432447),
        dec: Angle.Degrees(-30.77897829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39668"},
        {"Hipparcos Number", "HIP 27779"},
        {"Smithsonian Astrophysical Observation", "SAO 196265"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.17693682),
        dec: Angle.Degrees(-30.77896961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107859"},
        {"Hipparcos Number", "HIP 60462"},
        {"Geneva Identification System", "GEN# +1.00107859"},
        {"Smithsonian Astrophysical Observation", "SAO 203423"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.92825146),
        dec: Angle.Degrees(-30.77653384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -259.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 202.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53602"},
        {"Hipparcos Number", "HIP 34108"},
        {"Celescope Catalog", "CEL 1555"},
        {"Geneva Identification System", "GEN# +1.00053602"},
        {"Smithsonian Astrophysical Observation", "SAO 197537"},
    },
    visualMagnitude: 7.92,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.08541292),
        dec: Angle.Degrees(-30.77491355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110312"},
        {"Smithsonian Astrophysical Observation", "SAO 213750"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.15662862),
        dec: Angle.Degrees(-30.77419840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155319"},
        {"Hipparcos Number", "HIP 84142"},
        {"Smithsonian Astrophysical Observation", "SAO 208525"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.03765347),
        dec: Angle.Degrees(-30.77281708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59051"},
        {"Hipparcos Number", "HIP 36164"},
        {"Smithsonian Astrophysical Observation", "SAO 198002"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.74489470),
        dec: Angle.Degrees(-30.77169827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156229"},
        {"Hipparcos Number", "HIP 84611"},
        {"Geneva Identification System", "GEN# +1.00156229"},
        {"Smithsonian Astrophysical Observation", "SAO 208645"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.42986627),
        dec: Angle.Degrees(-30.77047894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36873"},
        {"Hipparcos Number", "HIP 26046"},
        {"Smithsonian Astrophysical Observation", "SAO 195957"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.34889390),
        dec: Angle.Degrees(-30.76848398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113721"},
        {"Hipparcos Number", "HIP 63917"},
        {"Smithsonian Astrophysical Observation", "SAO 204121"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.47022222),
        dec: Angle.Degrees(-30.76811290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83133"},
        {"Hipparcos Number", "HIP 47067"},
        {"Smithsonian Astrophysical Observation", "SAO 200533"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.87792293),
        dec: Angle.Degrees(-30.76577582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30080"},
        {"Hipparcos Number", "HIP 21958"},
        {"Geneva Identification System", "GEN# +1.00030080"},
        {"Smithsonian Astrophysical Observation", "SAO 195250"},
        {"Wilson Evans Batten Catalogue", "WEB 4222"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.78880760),
        dec: Angle.Degrees(-30.76539538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147385"},
        {"Hipparcos Number", "HIP 80237"},
        {"Geneva Identification System", "GEN# +1.00147385"},
        {"Smithsonian Astrophysical Observation", "SAO 207608"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.71561997),
        dec: Angle.Degrees(-30.76276509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205639"},
        {"Hipparcos Number", "HIP 106747"},
        {"Smithsonian Astrophysical Observation", "SAO 213145"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.35389412),
        dec: Angle.Degrees(-30.76161006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109849"},
        {"Hipparcos Number", "HIP 61652"},
        {"Smithsonian Astrophysical Observation", "SAO 203653"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.57420488),
        dec: Angle.Degrees(-30.75769843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202077"},
        {"Hipparcos Number", "HIP 104861"},
        {"Geneva Identification System", "GEN# +1.00202077"},
        {"Smithsonian Astrophysical Observation", "SAO 212821"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.62981842),
        dec: Angle.Degrees(-30.75737385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4732",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4732"},
        {"Geneva Identification System", "GEN# -0.03100400"},
        {"Smithsonian Astrophysical Observation", "SAO 192865"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.19962744),
        dec: Angle.Degrees(-30.75704029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169233"},
        {"Hipparcos Number", "HIP 90260"},
        {"Geneva Identification System", "GEN# +1.00169233"},
        {"Smithsonian Astrophysical Observation", "SAO 210116"},
        {"Wilson Evans Batten Catalogue", "WEB 15439"},
    },
    visualMagnitude: 5.58,
    bvColour: 1.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.25630334),
        dec: Angle.Degrees(-30.75640093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63625"},
        {"Hipparcos Number", "HIP 38110"},
        {"Geneva Identification System", "GEN# +1.00063625"},
        {"Smithsonian Astrophysical Observation", "SAO 198463"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.15205331),
        dec: Angle.Degrees(-30.75600051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93770"},
        {"Hipparcos Number", "HIP 52894"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.27029492),
        dec: Angle.Degrees(-30.75059939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92699"},
        {"Hipparcos Number", "HIP 52336"},
        {"Smithsonian Astrophysical Observation", "SAO 201643"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.43052243),
        dec: Angle.Degrees(-30.75042294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183745"},
        {"Hipparcos Number", "HIP 96089"},
        {"Smithsonian Astrophysical Observation", "SAO 211338"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.04606683),
        dec: Angle.Degrees(-30.74826175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134835"},
        {"Hipparcos Number", "HIP 74469"},
        {"Smithsonian Astrophysical Observation", "SAO 206417"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.25271031),
        dec: Angle.Degrees(-30.74812376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2224"},
        {"Hipparcos Number", "HIP 2045"},
        {"Geneva Identification System", "GEN# +1.00002224"},
        {"Smithsonian Astrophysical Observation", "SAO 192520"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.48425652),
        dec: Angle.Degrees(-30.74804869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51964"},
        {"Hipparcos Number", "HIP 33533"},
        {"Geneva Identification System", "GEN# +1.00051964"},
        {"Smithsonian Astrophysical Observation", "SAO 197415"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.53472141),
        dec: Angle.Degrees(-30.74641637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13350"},
        {"Hipparcos Number", "HIP 10090"},
        {"Geneva Identification System", "GEN# +1.00013350"},
        {"Smithsonian Astrophysical Observation", "SAO 193545"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.43535566),
        dec: Angle.Degrees(-30.74577045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202540"},
        {"Hipparcos Number", "HIP 105106"},
        {"Geneva Identification System", "GEN# +1.00202540"},
        {"Smithsonian Astrophysical Observation", "SAO 212867"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.35676283),
        dec: Angle.Degrees(-30.74568149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49301"},
        {"Hipparcos Number", "HIP 32452"},
        {"Geneva Identification System", "GEN# +1.00049301"},
        {"Smithsonian Astrophysical Observation", "SAO 197194"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.58836758),
        dec: Angle.Degrees(-30.74406652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22476"},
        {"Hipparcos Number", "HIP 16769"},
        {"Geneva Identification System", "GEN# +1.00022476"},
        {"Smithsonian Astrophysical Observation", "SAO 194393"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.94245656),
        dec: Angle.Degrees(-30.73853015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15107"},
        {"Smithsonian Astrophysical Observation", "SAO 194179"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.71897073),
        dec: Angle.Degrees(-30.73550103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76735"},
        {"Smithsonian Astrophysical Observation", "SAO 206856"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.04789282),
        dec: Angle.Degrees(-30.73523150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83703"},
        {"Smithsonian Astrophysical Observation", "SAO 208411"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.60463044),
        dec: Angle.Degrees(-30.73401976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174632"},
        {"Hipparcos Number", "HIP 92649"},
        {"Fundamental Katalog 5th Edition", "FK5 3502"},
        {"Geneva Identification System", "GEN# +1.00174632"},
        {"Smithsonian Astrophysical Observation", "SAO 210663"},
        {"Wilson Evans Batten Catalogue", "WEB 16028"},
    },
    visualMagnitude: 6.64,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.17369971),
        dec: Angle.Degrees(-30.73401898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66648"},
        {"Hipparcos Number", "HIP 39411"},
        {"Smithsonian Astrophysical Observation", "SAO 198746"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.827,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.85222497),
        dec: Angle.Degrees(-30.73217996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135446"},
        {"Hipparcos Number", "HIP 74705"},
        {"Geneva Identification System", "GEN# +1.00135446"},
        {"Smithsonian Astrophysical Observation", "SAO 206468"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.01407486),
        dec: Angle.Degrees(-30.73024540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39413"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.85504807),
        dec: Angle.Degrees(-30.72986420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171239"},
        {"Hipparcos Number", "HIP 91095"},
        {"Geneva Identification System", "GEN# +1.00171239"},
        {"Smithsonian Astrophysical Observation", "SAO 210337"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.72901611),
        dec: Angle.Degrees(-30.72984237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166023"},
        {"Hipparcos Number", "HIP 89020"},
        {"Geneva Identification System", "GEN# +1.00166023"},
        {"Smithsonian Astrophysical Observation", "SAO 209803"},
        {"Wilson Evans Batten Catalogue", "WEB 15108"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.52418933),
        dec: Angle.Degrees(-30.72859747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7817"},
    },
    visualMagnitude: 11.60,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.14278843),
        dec: Angle.Degrees(-30.72760404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 495.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -353.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10691"},
        {"Hipparcos Number", "HIP 8097"},
        {"Geneva Identification System", "GEN# +1.00010691"},
        {"Smithsonian Astrophysical Observation", "SAO 193273"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.98694985),
        dec: Angle.Degrees(-30.72728053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205545"},
        {"Hipparcos Number", "HIP 106701"},
        {"Smithsonian Astrophysical Observation", "SAO 213137"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.19816771),
        dec: Angle.Degrees(-30.72462545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100686"},
        {"Hipparcos Number", "HIP 56505"},
        {"Geneva Identification System", "GEN# +1.00100686"},
        {"Smithsonian Astrophysical Observation", "SAO 202595"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.76219650),
        dec: Angle.Degrees(-30.72453992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37907"},
        {"Hipparcos Number", "HIP 26703"},
        {"Smithsonian Astrophysical Observation", "SAO 196070"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.12619051),
        dec: Angle.Degrees(-30.72390292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 142.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13709"},
        {"Hipparcos Number", "HIP 10320"},
        {"Fundamental Katalog 5th Edition", "FK5 78"},
        {"Geneva Identification System", "GEN# +1.00013709"},
        {"Smithsonian Astrophysical Observation", "SAO 193573"},
        {"Wilson Evans Batten Catalogue", "WEB 2153"},
    },
    visualMagnitude: 5.27,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.22691696),
        dec: Angle.Degrees(-30.72384252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14246"},
        {"Hipparcos Number", "HIP 10683"},
        {"Smithsonian Astrophysical Observation", "SAO 193623"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.36045617),
        dec: Angle.Degrees(-30.72201808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212463"},
        {"Hipparcos Number", "HIP 110652"},
        {"Smithsonian Astrophysical Observation", "SAO 213802"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.25203229),
        dec: Angle.Degrees(-30.72072429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222270"},
        {"Hipparcos Number", "HIP 116722"},
        {"Smithsonian Astrophysical Observation", "SAO 214688"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.82825215),
        dec: Angle.Degrees(-30.72068124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152422"},
        {"Hipparcos Number", "HIP 82717"},
        {"Smithsonian Astrophysical Observation", "SAO 208170"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.61265305),
        dec: Angle.Degrees(-30.71964331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198751"},
        {"Hipparcos Number", "HIP 103103"},
        {"Geneva Identification System", "GEN# +1.00198751"},
        {"Smithsonian Astrophysical Observation", "SAO 212521"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.35390569),
        dec: Angle.Degrees(-30.71890920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29435"},
        {"Hipparcos Number", "HIP 21486"},
        {"Geneva Identification System", "GEN# +1.00029435"},
        {"Renson", "Renson 7530"},
        {"Smithsonian Astrophysical Observation", "SAO 195163"},
        {"Wilson Evans Batten Catalogue", "WEB 4123"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.21225109),
        dec: Angle.Degrees(-30.71679507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127624"},
        {"Hipparcos Number", "HIP 71154"},
        {"Geneva Identification System", "GEN# +1.00127624"},
        {"Smithsonian Astrophysical Observation", "SAO 205681"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.29009826),
        dec: Angle.Degrees(-30.71497213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209281"},
        {"Hipparcos Number", "HIP 108818"},
        {"Smithsonian Astrophysical Observation", "SAO 213498"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.67568626),
        dec: Angle.Degrees(-30.71238362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114747"},
        {"Hipparcos Number", "HIP 64475"},
        {"Geneva Identification System", "GEN# +1.00114747"},
        {"Smithsonian Astrophysical Observation", "SAO 204241"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.22684745),
        dec: Angle.Degrees(-30.71212756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -205.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132347"},
        {"Hipparcos Number", "HIP 73357"},
        {"Smithsonian Astrophysical Observation", "SAO 206173"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.87184964),
        dec: Angle.Degrees(-30.71144210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140328"},
        {"Hipparcos Number", "HIP 77064"},
        {"Smithsonian Astrophysical Observation", "SAO 206920"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.02975711),
        dec: Angle.Degrees(-30.71140126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220069"},
        {"Hipparcos Number", "HIP 115300"},
        {"Smithsonian Astrophysical Observation", "SAO 214481"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.28574289),
        dec: Angle.Degrees(-30.71103303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208165"},
        {"Hipparcos Number", "HIP 108181"},
        {"Smithsonian Astrophysical Observation", "SAO 213389"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.76601315),
        dec: Angle.Degrees(-30.70973348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4390"},
        {"Hipparcos Number", "HIP 3592"},
        {"Geneva Identification System", "GEN# +1.00004390"},
        {"Smithsonian Astrophysical Observation", "SAO 192721"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.48873310),
        dec: Angle.Degrees(-30.70927907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195248"},
        {"Hipparcos Number", "HIP 101225"},
        {"Smithsonian Astrophysical Observation", "SAO 212194"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.77763040),
        dec: Angle.Degrees(-30.70880318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209659"},
        {"Hipparcos Number", "HIP 109059"},
        {"Fundamental Katalog 5th Edition", "FK5 5952"},
        {"Geneva Identification System", "GEN# +1.00209659"},
        {"Smithsonian Astrophysical Observation", "SAO 213537"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.39766543),
        dec: Angle.Degrees(-30.70785157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77415"},
        {"Hipparcos Number", "HIP 44308"},
        {"Smithsonian Astrophysical Observation", "SAO 199889"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.35209087),
        dec: Angle.Degrees(-30.70666966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141697"},
        {"Hipparcos Number", "HIP 77683"},
        {"Geneva Identification System", "GEN# +1.00141697"},
        {"Smithsonian Astrophysical Observation", "SAO 207052"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.88790508),
        dec: Angle.Degrees(-30.70312767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146238"},
        {"Hipparcos Number", "HIP 79731"},
        {"Smithsonian Astrophysical Observation", "SAO 207501"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.08492605),
        dec: Angle.Degrees(-30.70072791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217205"},
        {"Hipparcos Number", "HIP 113515"},
        {"Smithsonian Astrophysical Observation", "SAO 214220"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.83734313),
        dec: Angle.Degrees(-30.70042611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16102"},
        {"Hipparcos Number", "HIP 11967"},
        {"Smithsonian Astrophysical Observation", "SAO 193777"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.59712697),
        dec: Angle.Degrees(-30.69839894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198579"},
        {"Hipparcos Number", "HIP 103011"},
        {"Smithsonian Astrophysical Observation", "SAO 212502"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.05875464),
        dec: Angle.Degrees(-30.69704878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2098"},
        {"Hipparcos Number", "HIP 1976"},
        {"Cincinnati Publication", "Ci 18 44"},
        {"Geneva Identification System", "GEN# +1.00002098"},
        {"Smithsonian Astrophysical Observation", "SAO 192509"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.25639070),
        dec: Angle.Degrees(-30.69702511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -277.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180984"},
        {"Hipparcos Number", "HIP 95004"},
        {"Smithsonian Astrophysical Observation", "SAO 211177"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.97881413),
        dec: Angle.Degrees(-30.69535948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152131"},
        {"Hipparcos Number", "HIP 82570"},
        {"Smithsonian Astrophysical Observation", "SAO 208132"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.18221412),
        dec: Angle.Degrees(-30.69511660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224913"},
        {"Hipparcos Number", "HIP 130"},
        {"Smithsonian Astrophysical Observation", "SAO 214928"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.41825279),
        dec: Angle.Degrees(-30.69250699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24267"},
        {"Hipparcos Number", "HIP 17976"},
        {"Smithsonian Astrophysical Observation", "SAO 194569"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.64463042),
        dec: Angle.Degrees(-30.68989940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169119"},
        {"Hipparcos Number", "HIP 90208"},
        {"Smithsonian Astrophysical Observation", "SAO 210101"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.10152215),
        dec: Angle.Degrees(-30.68932835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192434"},
        {"Hipparcos Number", "HIP 99881"},
        {"Smithsonian Astrophysical Observation", "SAO 211941"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.97075650),
        dec: Angle.Degrees(-30.68751718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81740"},
    },
    visualMagnitude: 11.04,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.43541531),
        dec: Angle.Degrees(-30.68676327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56342"},
        {"Hipparcos Number", "HIP 35083"},
        {"Celescope Catalog", "CEL 1720"},
        {"Geneva Identification System", "GEN# +5.11320001"},
        {"Smithsonian Astrophysical Observation", "SAO 197756"},
        {"Wilson Evans Batten Catalogue", "WEB 7014"},
    },
    visualMagnitude: 5.36,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.83783435),
        dec: Angle.Degrees(-30.68647453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214968"},
        {"Hipparcos Number", "HIP 112101"},
        {"Smithsonian Astrophysical Observation", "SAO 214025"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.59164481),
        dec: Angle.Degrees(-30.68633523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224964"},
        {"Hipparcos Number", "HIP 163"},
        {"Geneva Identification System", "GEN# +4.09010036"},
        {"Smithsonian Astrophysical Observation", "SAO 214935"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.51714313),
        dec: Angle.Degrees(-30.68523468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4415"},
        {"Hipparcos Number", "HIP 3608"},
        {"Smithsonian Astrophysical Observation", "SAO 192726"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.55434570),
        dec: Angle.Degrees(-30.68458671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210973"},
        {"Hipparcos Number", "HIP 109826"},
        {"Smithsonian Astrophysical Observation", "SAO 213662"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.66543464),
        dec: Angle.Degrees(-30.68418327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163066"},
        {"Hipparcos Number", "HIP 87756"},
        {"Geneva Identification System", "GEN# +1.00163066"},
        {"Smithsonian Astrophysical Observation", "SAO 209475"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.88927912),
        dec: Angle.Degrees(-30.68331041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7162",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7162"},
        {"Geneva Identification System", "GEN# -0.03100622"},
        {"Smithsonian Astrophysical Observation", "SAO 193170"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.08249811),
        dec: Angle.Degrees(-30.68076191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134115"},
        {"Hipparcos Number", "HIP 74154"},
        {"Smithsonian Astrophysical Observation", "SAO 206341"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.27628904),
        dec: Angle.Degrees(-30.68035890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52547"},
        {"Hipparcos Number", "HIP 33716"},
        {"Smithsonian Astrophysical Observation", "SAO 197459"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.06743171),
        dec: Angle.Degrees(-30.67864614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108896"},
        {"Hipparcos Number", "HIP 61064"},
        {"Smithsonian Astrophysical Observation", "SAO 203548"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.73080951),
        dec: Angle.Degrees(-30.67751518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189267"},
        {"Hipparcos Number", "HIP 98454"},
        {"Geneva Identification System", "GEN# +1.00189267"},
        {"Smithsonian Astrophysical Observation", "SAO 211721"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.05508943),
        dec: Angle.Degrees(-30.67746297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194461"},
        {"Hipparcos Number", "HIP 100829"},
        {"Geneva Identification System", "GEN# +1.00194461"},
        {"Smithsonian Astrophysical Observation", "SAO 212125"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.66494630),
        dec: Angle.Degrees(-30.67577748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90391"},
        {"Hipparcos Number", "HIP 51038"},
        {"Smithsonian Astrophysical Observation", "SAO 201381"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.40254187),
        dec: Angle.Degrees(-30.67435581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38076"},
        {"Hipparcos Number", "HIP 26815"},
        {"Smithsonian Astrophysical Observation", "SAO 196091"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.40940620),
        dec: Angle.Degrees(-30.67401437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35823"},
        {"Hipparcos Number", "HIP 25408"},
        {"Geneva Identification System", "GEN# +1.00035823"},
        {"Smithsonian Astrophysical Observation", "SAO 195849"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.52183514),
        dec: Angle.Degrees(-30.67309696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151843"},
        {"Hipparcos Number", "HIP 82467"},
        {"Smithsonian Astrophysical Observation", "SAO 208093"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.79788684),
        dec: Angle.Degrees(-30.67240671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211571"},
        {"Hipparcos Number", "HIP 110143"},
        {"Smithsonian Astrophysical Observation", "SAO 213721"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.66091532),
        dec: Angle.Degrees(-30.67036891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29100"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.07236992),
        dec: Angle.Degrees(-30.66759147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143637"},
        {"Hipparcos Number", "HIP 78581"},
        {"Smithsonian Astrophysical Observation", "SAO 207263"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.68402739),
        dec: Angle.Degrees(-30.66701909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82783"},
        {"Hipparcos Number", "HIP 46901"},
        {"Smithsonian Astrophysical Observation", "SAO 200496"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.36230135),
        dec: Angle.Degrees(-30.66696138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119205"},
        {"Hipparcos Number", "HIP 66885"},
        {"Smithsonian Astrophysical Observation", "SAO 204752"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.60492156),
        dec: Angle.Degrees(-30.66581005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108365"},
        {"Hipparcos Number", "HIP 60756"},
        {"Smithsonian Astrophysical Observation", "SAO 203484"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.77922993),
        dec: Angle.Degrees(-30.66560722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52782"},
        {"Hipparcos Number", "HIP 33812"},
        {"Geneva Identification System", "GEN# +1.00052782"},
        {"Smithsonian Astrophysical Observation", "SAO 197481"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.29450154),
        dec: Angle.Degrees(-30.66484931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4367"},
        {"Hipparcos Number", "HIP 3586"},
        {"Geneva Identification System", "GEN# +1.00004367"},
        {"Smithsonian Astrophysical Observation", "SAO 192719"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.44801857),
        dec: Angle.Degrees(-30.66389145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30359"},
        {"Hipparcos Number", "HIP 22120"},
        {"Smithsonian Astrophysical Observation", "SAO 195270"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.40631718),
        dec: Angle.Degrees(-30.66264687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55173"},
        {"Hipparcos Number", "HIP 34646"},
        {"Celescope Catalog", "CEL 1645"},
        {"Geneva Identification System", "GEN# +5.11320009"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.62762697),
        dec: Angle.Degrees(-30.66251171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31215"},
        {"Hipparcos Number", "HIP 22680"},
        {"Smithsonian Astrophysical Observation", "SAO 195372"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.15903114),
        dec: Angle.Degrees(-30.66049599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165136"},
        {"Hipparcos Number", "HIP 88645"},
        {"Smithsonian Astrophysical Observation", "SAO 209700"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.47816453),
        dec: Angle.Degrees(-30.66036335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154022"},
        {"Hipparcos Number", "HIP 83522"},
        {"Smithsonian Astrophysical Observation", "SAO 208367"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.04048963),
        dec: Angle.Degrees(-30.65926728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1557"},
        {"Hipparcos Number", "HIP 1576"},
        {"Geneva Identification System", "GEN# +1.00001557"},
        {"Smithsonian Astrophysical Observation", "SAO 192462"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.92339505),
        dec: Angle.Degrees(-30.65862054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214690"},
        {"Hipparcos Number", "HIP 111934"},
        {"Geneva Identification System", "GEN# +1.00214690"},
        {"Smithsonian Astrophysical Observation", "SAO 214000"},
        {"Wilson Evans Batten Catalogue", "WEB 19987"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.09324845),
        dec: Angle.Degrees(-30.65836159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117485"},
        {"Smithsonian Astrophysical Observation", "SAO 214796"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.33953078),
        dec: Angle.Degrees(-30.65806992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185906"},
        {"Hipparcos Number", "HIP 96972"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.66633473),
        dec: Angle.Degrees(-30.65687459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54031"},
        {"Hipparcos Number", "HIP 34248"},
        {"Celescope Catalog", "CEL 1582"},
        {"Geneva Identification System", "GEN# +1.00054031"},
        {"Smithsonian Astrophysical Observation", "SAO 197566"},
        {"Wilson Evans Batten Catalogue", "WEB 6860"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.50205197),
        dec: Angle.Degrees(-30.65572890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40721",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40721"},
        {"Geneva Identification System", "GEN# +2.25670042"},
        {"New General Catalogue", "NGC 2567 42"},
    },
    visualMagnitude: 11.71,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.68098896),
        dec: Angle.Degrees(-30.65530630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56161"},
        {"Hipparcos Number", "HIP 35017"},
        {"Smithsonian Astrophysical Observation", "SAO 197738"},
        {"Wilson Evans Batten Catalogue", "WEB 7003"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.65317046),
        dec: Angle.Degrees(-30.65503449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40679"},
        {"Geneva Identification System", "GEN# +2.25670061"},
        {"New General Catalogue", "NGC 2567 61"},
    },
    visualMagnitude: 10.09,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.57772763),
        dec: Angle.Degrees(-30.65483534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100502"},
        {"Hipparcos Number", "HIP 56402"},
        {"Smithsonian Astrophysical Observation", "SAO 202568"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.44254613),
        dec: Angle.Degrees(-30.65409484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61085"},
        {"Hipparcos Number", "HIP 37003"},
        {"Smithsonian Astrophysical Observation", "SAO 198178"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.07106885),
        dec: Angle.Degrees(-30.65336688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153673"},
        {"Hipparcos Number", "HIP 83355"},
        {"Smithsonian Astrophysical Observation", "SAO 208328"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.53460444),
        dec: Angle.Degrees(-30.65186066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214967"},
        {"Hipparcos Number", "HIP 112106"},
        {"Smithsonian Astrophysical Observation", "SAO 214027"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.60423444),
        dec: Angle.Degrees(-30.65004228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221881"},
        {"Hipparcos Number", "HIP 116472"},
        {"Geneva Identification System", "GEN# +1.00221881"},
        {"Smithsonian Astrophysical Observation", "SAO 214645"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.00374332),
        dec: Angle.Degrees(-30.64673514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48261"},
        {"Hipparcos Number", "HIP 31993"},
        {"Celescope Catalog", "CEL 1353"},
        {"Geneva Identification System", "GEN# +1.00048261"},
        {"Smithsonian Astrophysical Observation", "SAO 197084"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.28254721),
        dec: Angle.Degrees(-30.64562465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178321"},
        {"Hipparcos Number", "HIP 94108"},
        {"Smithsonian Astrophysical Observation", "SAO 210995"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.35128781),
        dec: Angle.Degrees(-30.64486088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59573"},
        {"Hipparcos Number", "HIP 36379"},
        {"Smithsonian Astrophysical Observation", "SAO 198043"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.31101957),
        dec: Angle.Degrees(-30.64384895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171016"},
        {"Hipparcos Number", "HIP 90994"},
        {"Smithsonian Astrophysical Observation", "SAO 210307"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.42594233),
        dec: Angle.Degrees(-30.64363974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93787"},
        {"Hipparcos Number", "HIP 52905"},
        {"Geneva Identification System", "GEN# +1.00093787"},
        {"Smithsonian Astrophysical Observation", "SAO 201787"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.30115142),
        dec: Angle.Degrees(-30.64057565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40717"},
        {"Geneva Identification System", "GEN# +2.25670023"},
        {"New General Catalogue", "NGC 2567 23"},
    },
    visualMagnitude: 11.85,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.67517677),
        dec: Angle.Degrees(-30.63972746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165119"},
        {"Hipparcos Number", "HIP 88634"},
        {"Geneva Identification System", "GEN# +1.00165119"},
        {"Smithsonian Astrophysical Observation", "SAO 209695"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.45132028),
        dec: Angle.Degrees(-30.63938757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71669"},
        {"Hipparcos Number", "HIP 41477"},
        {"Geneva Identification System", "GEN# +1.00071669"},
        {"Smithsonian Astrophysical Observation", "SAO 199249"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88980672),
        dec: Angle.Degrees(-30.63930757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37832"},
        {"Hipparcos Number", "HIP 26660"},
        {"Smithsonian Astrophysical Observation", "SAO 196062"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.98816522),
        dec: Angle.Degrees(-30.63616562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16733"},
        {"Hipparcos Number", "HIP 12435"},
        {"Geneva Identification System", "GEN# +1.00016733"},
        {"Smithsonian Astrophysical Observation", "SAO 193846"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.01033431),
        dec: Angle.Degrees(-30.63353201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82132"},
        {"Cincinnati Publication", "Ci 20 1008"},
        {"Geneva Identification System", "GEN# -0.03013458"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.68831532),
        dec: Angle.Degrees(-30.63267168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117865"},
        {"Hipparcos Number", "HIP 66157"},
        {"Smithsonian Astrophysical Observation", "SAO 204594"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.41223325),
        dec: Angle.Degrees(-30.63195185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33259"},
        {"Hipparcos Number", "HIP 23839"},
        {"Smithsonian Astrophysical Observation", "SAO 195571"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.89019466),
        dec: Angle.Degrees(-30.62846157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8415"},
        {"Hipparcos Number", "HIP 6445"},
        {"Smithsonian Astrophysical Observation", "SAO 193080"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.69519581),
        dec: Angle.Degrees(-30.62814139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22248"},
        {"Hipparcos Number", "HIP 16624"},
        {"Geneva Identification System", "GEN# +1.00022248"},
        {"Smithsonian Astrophysical Observation", "SAO 194373"},
        {"Wilson Evans Batten Catalogue", "WEB 3170"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.47614154),
        dec: Angle.Degrees(-30.62800183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42099"},
        {"Hipparcos Number", "HIP 29023"},
        {"Smithsonian Astrophysical Observation", "SAO 196508"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.85738841),
        dec: Angle.Degrees(-30.62717410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213925"},
        {"Hipparcos Number", "HIP 111490"},
        {"Smithsonian Astrophysical Observation", "SAO 213930"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.82358129),
        dec: Angle.Degrees(-30.62696350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146776"},
        {"Hipparcos Number", "HIP 79954"},
        {"Smithsonian Astrophysical Observation", "SAO 207552"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.79989903),
        dec: Angle.Degrees(-30.62545489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104791"},
        {"Hipparcos Number", "HIP 58827"},
        {"Smithsonian Astrophysical Observation", "SAO 203093"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.99356070),
        dec: Angle.Degrees(-30.62504259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57438"},
        {"Hipparcos Number", "HIP 35522"},
        {"Smithsonian Astrophysical Observation", "SAO 197855"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.97922307),
        dec: Angle.Degrees(-30.62462718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146177"},
        {"Hipparcos Number", "HIP 79706"},
        {"Smithsonian Astrophysical Observation", "SAO 207494"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.01547790),
        dec: Angle.Degrees(-30.62175705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39241"},
        {"Hipparcos Number", "HIP 27537"},
        {"Geneva Identification System", "GEN# +1.00039241"},
        {"Smithsonian Astrophysical Observation", "SAO 196219"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.47580539),
        dec: Angle.Degrees(-30.62112998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123746"},
        {"Hipparcos Number", "HIP 69213"},
        {"Geneva Identification System", "GEN# +1.00123746"},
        {"Smithsonian Astrophysical Observation", "SAO 205253"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.55444082),
        dec: Angle.Degrees(-30.62088787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94675"},
        {"Hipparcos Number", "HIP 53396"},
        {"Smithsonian Astrophysical Observation", "SAO 201896"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.82633456),
        dec: Angle.Degrees(-30.61919725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21411"},
        {"Hipparcos Number", "HIP 16012"},
        {"Geneva Identification System", "GEN# +1.00021411"},
        {"Smithsonian Astrophysical Observation", "SAO 194293"},
        {"Wilson Evans Batten Catalogue", "WEB 3058"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.54570775),
        dec: Angle.Degrees(-30.61836290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 217.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 227.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2830"},
        {"Smithsonian Astrophysical Observation", "SAO 192626"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.97496679),
        dec: Angle.Degrees(-30.61765154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127772"},
        {"Hipparcos Number", "HIP 71229"},
        {"Smithsonian Astrophysical Observation", "SAO 205700"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.48978286),
        dec: Angle.Degrees(-30.61715606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218241"},
        {"Hipparcos Number", "HIP 114115"},
        {"Smithsonian Astrophysical Observation", "SAO 214311"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.66654720),
        dec: Angle.Degrees(-30.61507795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110877"},
        {"Smithsonian Astrophysical Observation", "SAO 213839"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.95728349),
        dec: Angle.Degrees(-30.61498718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35723"},
        {"Hipparcos Number", "HIP 25355"},
        {"Smithsonian Astrophysical Observation", "SAO 195833"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.33675799),
        dec: Angle.Degrees(-30.61435359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23263"},
        {"Smithsonian Astrophysical Observation", "SAO 195475"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.08202102),
        dec: Angle.Degrees(-30.61332358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50990"},
        {"Hipparcos Number", "HIP 33157"},
        {"Smithsonian Astrophysical Observation", "SAO 197333"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.54646934),
        dec: Angle.Degrees(-30.61313006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38395"},
        {"Hipparcos Number", "HIP 27037"},
        {"Geneva Identification System", "GEN# +1.00038395"},
        {"Smithsonian Astrophysical Observation", "SAO 196121"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.01462675),
        dec: Angle.Degrees(-30.61090352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144612"},
        {"Hipparcos Number", "HIP 79029"},
        {"Renson", "Renson 40990"},
        {"Smithsonian Astrophysical Observation", "SAO 207360"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.95571378),
        dec: Angle.Degrees(-30.61000361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 570"},
    },
    visualMagnitude: 12.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.73076217),
        dec: Angle.Degrees(-30.60851144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90972"},
        {"Hipparcos Number", "HIP 51376"},
        {"Geneva Identification System", "GEN# +1.00090972J"},
        {"Renson", "Renson 26150"},
        {"Smithsonian Astrophysical Observation", "SAO 201442"},
        {"Wilson Evans Batten Catalogue", "WEB 9380"},
    },
    visualMagnitude: 5.57,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.39749325),
        dec: Angle.Degrees(-30.60707101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84957"},
        {"Hipparcos Number", "HIP 48075"},
        {"Smithsonian Astrophysical Observation", "SAO 200748"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.01138254),
        dec: Angle.Degrees(-30.60658191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208285"},
        {"Hipparcos Number", "HIP 108259"},
        {"Geneva Identification System", "GEN# +1.00208285"},
        {"Smithsonian Astrophysical Observation", "SAO 213406"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.98168177),
        dec: Angle.Degrees(-30.60587153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105953"},
        {"Hipparcos Number", "HIP 59456"},
        {"Smithsonian Astrophysical Observation", "SAO 203219"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.92471665),
        dec: Angle.Degrees(-30.60376904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212"},
        {"Hipparcos Number", "HIP 571"},
        {"Geneva Identification System", "GEN# +4.09010121"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.73226563),
        dec: Angle.Degrees(-30.60308180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112891"},
        {"Hipparcos Number", "HIP 63457"},
        {"Smithsonian Astrophysical Observation", "SAO 204020"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.04129054),
        dec: Angle.Degrees(-30.60270568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212866"},
        {"Hipparcos Number", "HIP 110879"},
        {"Smithsonian Astrophysical Observation", "SAO 213840"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.96008267),
        dec: Angle.Degrees(-30.60239587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141640"},
        {"Hipparcos Number", "HIP 77665"},
        {"Smithsonian Astrophysical Observation", "SAO 207046"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.83031908),
        dec: Angle.Degrees(-30.60158218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162999"},
        {"Hipparcos Number", "HIP 87733"},
        {"Smithsonian Astrophysical Observation", "SAO 209463"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.81626587),
        dec: Angle.Degrees(-30.60102475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104268"},
        {"Hipparcos Number", "HIP 58550"},
        {"Geneva Identification System", "GEN# +1.00104268"},
        {"Smithsonian Astrophysical Observation", "SAO 203030"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.09721388),
        dec: Angle.Degrees(-30.60060956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16602"},
        {"Hipparcos Number", "HIP 12329"},
        {"Smithsonian Astrophysical Observation", "SAO 193836"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.69263064),
        dec: Angle.Degrees(-30.59930419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125843"},
        {"Hipparcos Number", "HIP 70276"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.68026941),
        dec: Angle.Degrees(-30.59885597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122587"},
        {"Hipparcos Number", "HIP 68681"},
        {"Smithsonian Astrophysical Observation", "SAO 205131"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.88132060),
        dec: Angle.Degrees(-30.59790378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104167"},
        {"Hipparcos Number", "HIP 58493"},
        {"Smithsonian Astrophysical Observation", "SAO 203017"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.93980688),
        dec: Angle.Degrees(-30.59755371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161852"},
        {"Hipparcos Number", "HIP 87223"},
        {"Smithsonian Astrophysical Observation", "SAO 209307"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.32211105),
        dec: Angle.Degrees(-30.59734291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107133"},
        {"Geneva Identification System", "GEN# -0.03118409"},
        {"Smithsonian Astrophysical Observation", "SAO 213214"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.51698160),
        dec: Angle.Degrees(-30.59409703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154587"},
        {"Hipparcos Number", "HIP 83798"},
        {"Smithsonian Astrophysical Observation", "SAO 208442"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.89125586),
        dec: Angle.Degrees(-30.59378000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29685"},
        {"Hipparcos Number", "HIP 21681"},
        {"Geneva Identification System", "GEN# +1.00029685"},
        {"Smithsonian Astrophysical Observation", "SAO 195201"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.81230954),
        dec: Angle.Degrees(-30.59362210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73867"},
        {"Hipparcos Number", "HIP 42474"},
        {"Smithsonian Astrophysical Observation", "SAO 199475"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.88957727),
        dec: Angle.Degrees(-30.59348734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195756"},
        {"Hipparcos Number", "HIP 101510"},
        {"Geneva Identification System", "GEN# +1.00195756"},
        {"Smithsonian Astrophysical Observation", "SAO 212238"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.56320511),
        dec: Angle.Degrees(-30.59329159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122978"},
        {"Hipparcos Number", "HIP 68840"},
        {"Smithsonian Astrophysical Observation", "SAO 205168"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.43762433),
        dec: Angle.Degrees(-30.59237671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12874"},
        {"Hipparcos Number", "HIP 9760"},
        {"Smithsonian Astrophysical Observation", "SAO 193500"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.37479712),
        dec: Angle.Degrees(-30.59229924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2492"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.90643248),
        dec: Angle.Degrees(+00.61406633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115324"},
        {"Hipparcos Number", "HIP 64801"},
        {"Geneva Identification System", "GEN# +1.00115324"},
        {"Smithsonian Astrophysical Observation", "SAO 204313"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.21952298),
        dec: Angle.Degrees(-30.59201081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201695"},
        {"Hipparcos Number", "HIP 104673"},
        {"Geneva Identification System", "GEN# +1.00201695J"},
        {"Smithsonian Astrophysical Observation", "SAO 212786"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.03079917),
        dec: Angle.Degrees(-30.58923682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152431"},
        {"Hipparcos Number", "HIP 82731"},
        {"Geneva Identification System", "GEN# +1.00152431"},
        {"Renson", "Renson 43150"},
        {"Smithsonian Astrophysical Observation", "SAO 208176"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.64974943),
        dec: Angle.Degrees(-30.58733700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49028"},
        {"Hipparcos Number", "HIP 32339"},
        {"Celescope Catalog", "CEL 1369"},
        {"Geneva Identification System", "GEN# +5.11210036J"},
        {"Smithsonian Astrophysical Observation", "SAO 197163"},
        {"Wilson Evans Batten Catalogue", "WEB 6524"},
    },
    visualMagnitude: 6.53,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.26067592),
        dec: Angle.Degrees(-30.58641496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183901"},
        {"Hipparcos Number", "HIP 96151"},
        {"Geneva Identification System", "GEN# +1.00183901"},
        {"Smithsonian Astrophysical Observation", "SAO 211354"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.24813024),
        dec: Angle.Degrees(-30.58549425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70462"},
        {"Hipparcos Number", "HIP 40923"},
        {"Geneva Identification System", "GEN# +1.00070462"},
        {"Smithsonian Astrophysical Observation", "SAO 199111"},
        {"Wilson Evans Batten Catalogue", "WEB 7934"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.27683202),
        dec: Angle.Degrees(-30.58371648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149528"},
        {"Hipparcos Number", "HIP 81327"},
        {"Geneva Identification System", "GEN# +1.00149528"},
        {"Smithsonian Astrophysical Observation", "SAO 207822"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.15415709),
        dec: Angle.Degrees(-30.58368336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199753"},
        {"Hipparcos Number", "HIP 103653"},
        {"Smithsonian Astrophysical Observation", "SAO 212613"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.01893193),
        dec: Angle.Degrees(-30.58338531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46753"},
        {"Hipparcos Number", "HIP 31296"},
        {"Smithsonian Astrophysical Observation", "SAO 196941"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.44244812),
        dec: Angle.Degrees(-30.58290376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137132"},
        {"Hipparcos Number", "HIP 75503"},
        {"Smithsonian Astrophysical Observation", "SAO 206623"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.33729879),
        dec: Angle.Degrees(-30.58246055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152783"},
        {"Hipparcos Number", "HIP 82912"},
        {"Smithsonian Astrophysical Observation", "SAO 208221"},
        {"Wilson Evans Batten Catalogue", "WEB 14018"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.15768984),
        dec: Angle.Degrees(-30.58003813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138939"},
        {"Hipparcos Number", "HIP 76406"},
        {"Smithsonian Astrophysical Observation", "SAO 206796"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.07225925),
        dec: Angle.Degrees(-30.57944939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220099"},
        {"Hipparcos Number", "HIP 115314"},
        {"Geneva Identification System", "GEN# +1.00220099"},
        {"Smithsonian Astrophysical Observation", "SAO 214483"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.32987162),
        dec: Angle.Degrees(-30.57932130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69400"},
        {"Hipparcos Number", "HIP 40466"},
        {"Geneva Identification System", "GEN# +1.00069400"},
        {"Smithsonian Astrophysical Observation", "SAO 199003"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.94065059),
        dec: Angle.Degrees(-30.57902164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121414"},
        {"Hipparcos Number", "HIP 68043"},
        {"Geneva Identification System", "GEN# +1.00121414"},
        {"Smithsonian Astrophysical Observation", "SAO 205000"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.97673004),
        dec: Angle.Degrees(-30.57821138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87199"},
        {"Hipparcos Number", "HIP 49222"},
        {"Fundamental Katalog 5th Edition", "FK5 2808"},
        {"Geneva Identification System", "GEN# +1.00087199"},
        {"Smithsonian Astrophysical Observation", "SAO 200994"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.70546632),
        dec: Angle.Degrees(-30.57758605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50195"},
        {"Hipparcos Number", "HIP 32847"},
        {"Smithsonian Astrophysical Observation", "SAO 197272"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.69446295),
        dec: Angle.Degrees(-30.57742321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111564"},
        {"Hipparcos Number", "HIP 62661"},
        {"Cincinnati Publication", "Ci 20 744"},
        {"Geneva Identification System", "GEN# +1.00111564"},
        {"Smithsonian Astrophysical Observation", "SAO 203856"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.58534645),
        dec: Angle.Degrees(-30.57716080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -430.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131117"},
        {"Hipparcos Number", "HIP 72772"},
        {"Geneva Identification System", "GEN# +1.00131117"},
        {"Smithsonian Astrophysical Observation", "SAO 206035"},
        {"Wilson Evans Batten Catalogue", "WEB 12505"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.13886782),
        dec: Angle.Degrees(-30.57715291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -336.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63682"},
        {"Hipparcos Number", "HIP 38139"},
        {"Smithsonian Astrophysical Observation", "SAO 198474"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.24308159),
        dec: Angle.Degrees(-30.57595324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29143"},
        {"Hipparcos Number", "HIP 21294"},
        {"Geneva Identification System", "GEN# +1.00029143"},
        {"Smithsonian Astrophysical Observation", "SAO 195129"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.52980244),
        dec: Angle.Degrees(-30.57439970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26009"},
    },
    visualMagnitude: 11.49,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.26231481),
        dec: Angle.Degrees(-30.57239762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39735"},
        {"Hipparcos Number", "HIP 27804"},
        {"Smithsonian Astrophysical Observation", "SAO 196273"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.25514785),
        dec: Angle.Degrees(-30.57151246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43105"},
        {"Hipparcos Number", "HIP 29518"},
        {"Smithsonian Astrophysical Observation", "SAO 196592"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.27008828),
        dec: Angle.Degrees(-30.57068126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90711",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90711"},
    },
    visualMagnitude: 11.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.61260232),
        dec: Angle.Degrees(-30.57032924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188548"},
        {"Hipparcos Number", "HIP 98152"},
        {"Geneva Identification System", "GEN# +1.00188548"},
        {"Smithsonian Astrophysical Observation", "SAO 211677"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.20456453),
        dec: Angle.Degrees(-30.57016459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117464"},
        {"Smithsonian Astrophysical Observation", "SAO 214793"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.25850685),
        dec: Angle.Degrees(-30.56996936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14302"},
        {"Smithsonian Astrophysical Observation", "SAO 194067"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.11473093),
        dec: Angle.Degrees(-30.56854595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16192"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.15001829),
        dec: Angle.Degrees(-30.56752120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7165"},
        {"Hipparcos Number", "HIP 5580"},
        {"Geneva Identification System", "GEN# +1.00007165"},
        {"Smithsonian Astrophysical Observation", "SAO 192970"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.89204812),
        dec: Angle.Degrees(-30.56697030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120607"},
        {"Hipparcos Number", "HIP 67604"},
        {"Smithsonian Astrophysical Observation", "SAO 204905"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.78730700),
        dec: Angle.Degrees(-30.56599214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144570"},
        {"Hipparcos Number", "HIP 79012"},
        {"Smithsonian Astrophysical Observation", "SAO 207356"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.91247855),
        dec: Angle.Degrees(-30.56295408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21393",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Theemin"},
        {"Henry Draper", "HD 29291"},
        {"Hipparcos Number", "HIP 21393"},
        {"Fundamental Katalog 5th Edition", "FK5 170"},
        {"Geneva Identification System", "GEN# +1.00029291"},
        {"Smithsonian Astrophysical Observation", "SAO 195148"},
        {"Wilson Evans Batten Catalogue", "WEB 4105"},
    },
    visualMagnitude: 3.81,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.88779874),
        dec: Angle.Degrees(-30.56231049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 235"},
        {"Hipparcos Number", "HIP 585"},
        {"Geneva Identification System", "GEN# +4.09010124"},
        {"Wilson Evans Batten Catalogue", "WEB 102"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.78247366),
        dec: Angle.Degrees(-30.56157424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197064"},
        {"Hipparcos Number", "HIP 102182"},
        {"Geneva Identification System", "GEN# +1.00197064"},
        {"Smithsonian Astrophysical Observation", "SAO 212362"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.56927996),
        dec: Angle.Degrees(-30.56007702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162220B"},
        {"Hipparcos Number", "HIP 87380"},
        {"Geneva Identification System", "GEN# +1.00162220B"},
        {"Smithsonian Astrophysical Observation", "SAO 209356"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.80174964),
        dec: Angle.Degrees(-30.55962974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196386"},
        {"Hipparcos Number", "HIP 101829"},
        {"Geneva Identification System", "GEN# +1.00196386"},
        {"Smithsonian Astrophysical Observation", "SAO 212302"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.53818700),
        dec: Angle.Degrees(-30.55860536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205589"},
        {"Hipparcos Number", "HIP 106728"},
        {"Smithsonian Astrophysical Observation", "SAO 213141"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.28127114),
        dec: Angle.Degrees(-30.55856817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222117"},
        {"Hipparcos Number", "HIP 116619"},
        {"Geneva Identification System", "GEN# +1.00222117"},
        {"Smithsonian Astrophysical Observation", "SAO 214673"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.50296137),
        dec: Angle.Degrees(-30.55836297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63785"},
        {"Hipparcos Number", "HIP 38177"},
        {"Smithsonian Astrophysical Observation", "SAO 198483"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.35061108),
        dec: Angle.Degrees(-30.55797363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162220"},
        {"Hipparcos Number", "HIP 87381"},
        {"Geneva Identification System", "GEN# +1.00162220A"},
        {"Smithsonian Astrophysical Observation", "SAO 209357"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.80229180),
        dec: Angle.Degrees(-30.55686259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27095"},
        {"Hipparcos Number", "HIP 19868"},
        {"Smithsonian Astrophysical Observation", "SAO 194875"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.91816286),
        dec: Angle.Degrees(-30.55646626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24257"},
        {"Hipparcos Number", "HIP 17973"},
        {"Smithsonian Astrophysical Observation", "SAO 194567"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.64059538),
        dec: Angle.Degrees(-30.55588858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107456"},
        {"Hipparcos Number", "HIP 60252"},
        {"Smithsonian Astrophysical Observation", "SAO 203375"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.31474229),
        dec: Angle.Degrees(-30.55554525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1638"},
        {"Hipparcos Number", "HIP 1631"},
        {"Smithsonian Astrophysical Observation", "SAO 192469"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.11792393),
        dec: Angle.Degrees(-30.55548769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96504"},
        {"Hipparcos Number", "HIP 54332"},
        {"Smithsonian Astrophysical Observation", "SAO 202096"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.71813180),
        dec: Angle.Degrees(-30.55482337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108496"},
        {"Geneva Identification System", "GEN# +0.00004801"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.68816861),
        dec: Angle.Degrees(+00.81031884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -240.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36733"},
        {"Hipparcos Number", "HIP 25970"},
        {"Smithsonian Astrophysical Observation", "SAO 195939"},
    },
    visualMagnitude: 9.44,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.11595032),
        dec: Angle.Degrees(-30.55444658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191846"},
        {"Hipparcos Number", "HIP 99621"},
        {"Smithsonian Astrophysical Observation", "SAO 211907"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.25512228),
        dec: Angle.Degrees(-30.55443707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219804"},
        {"Hipparcos Number", "HIP 115113"},
        {"Geneva Identification System", "GEN# +1.00219804"},
        {"Smithsonian Astrophysical Observation", "SAO 214445"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.72840466),
        dec: Angle.Degrees(-30.55275923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48224"},
        {"Hipparcos Number", "HIP 31981"},
        {"Smithsonian Astrophysical Observation", "SAO 197080"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.24925660),
        dec: Angle.Degrees(-30.55267783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93816"},
        {"Hipparcos Number", "HIP 52920"},
        {"Smithsonian Astrophysical Observation", "SAO 201792"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.34783290),
        dec: Angle.Degrees(-30.55247191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108801"},
        {"Hipparcos Number", "HIP 61003"},
        {"Smithsonian Astrophysical Observation", "SAO 203539"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.54367344),
        dec: Angle.Degrees(-30.55235907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21350"},
        {"Hipparcos Number", "HIP 15965"},
        {"Smithsonian Astrophysical Observation", "SAO 194284"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.39629770),
        dec: Angle.Degrees(-30.55122270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133469"},
        {"Hipparcos Number", "HIP 73850"},
        {"Geneva Identification System", "GEN# +1.00133469"},
        {"Smithsonian Astrophysical Observation", "SAO 206284"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.39124303),
        dec: Angle.Degrees(-30.55106819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63423"},
        {"Hipparcos Number", "HIP 38029"},
        {"Geneva Identification System", "GEN# +1.00063423"},
        {"Smithsonian Astrophysical Observation", "SAO 198440"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.89749775),
        dec: Angle.Degrees(-30.54863688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14679"},
        {"Hipparcos Number", "HIP 10973"},
        {"Cincinnati Publication", "Ci 18 302"},
        {"Geneva Identification System", "GEN# +1.00014679"},
        {"Smithsonian Astrophysical Observation", "SAO 193657"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.33753019),
        dec: Angle.Degrees(-30.54708116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -303.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125170"},
        {"Hipparcos Number", "HIP 69905"},
        {"Geneva Identification System", "GEN# +1.00125170"},
        {"Smithsonian Astrophysical Observation", "SAO 205414"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.60029056),
        dec: Angle.Degrees(-30.54665307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78678"},
        {"Hipparcos Number", "HIP 44875"},
        {"Smithsonian Astrophysical Observation", "SAO 200019"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.15366650),
        dec: Angle.Degrees(-30.54621094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21164"},
        {"Hipparcos Number", "HIP 15835"},
        {"Smithsonian Astrophysical Observation", "SAO 194270"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.99671379),
        dec: Angle.Degrees(-30.54286866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159472"},
        {"Hipparcos Number", "HIP 86140"},
        {"Geneva Identification System", "GEN# +1.00159472"},
        {"Smithsonian Astrophysical Observation", "SAO 209016"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.05354313),
        dec: Angle.Degrees(-30.54179188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102848"},
        {"Hipparcos Number", "HIP 57723"},
        {"Smithsonian Astrophysical Observation", "SAO 202858"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.56801190),
        dec: Angle.Degrees(-30.54149681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90916"},
        {"Hipparcos Number", "HIP 51350"},
        {"Smithsonian Astrophysical Observation", "SAO 201437"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.33304277),
        dec: Angle.Degrees(-30.53979517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93951"},
        {"Hipparcos Number", "HIP 52983"},
        {"Smithsonian Astrophysical Observation", "SAO 201809"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.57759988),
        dec: Angle.Degrees(-30.53838819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188981"},
        {"Hipparcos Number", "HIP 98351"},
        {"Geneva Identification System", "GEN# +1.00188981"},
        {"Smithsonian Astrophysical Observation", "SAO 211708"},
        {"Wilson Evans Batten Catalogue", "WEB 17350"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.73486767),
        dec: Angle.Degrees(-30.53823810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155518"},
        {"Hipparcos Number", "HIP 84252"},
        {"Smithsonian Astrophysical Observation", "SAO 208552"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.34012434),
        dec: Angle.Degrees(-30.53716615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128907"},
        {"Hipparcos Number", "HIP 71732"},
        {"Smithsonian Astrophysical Observation", "SAO 205818"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.10377043),
        dec: Angle.Degrees(-30.53652169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37276"},
        {"Hipparcos Number", "HIP 26292"},
        {"Fundamental Katalog 5th Edition", "FK5 4507"},
        {"Geneva Identification System", "GEN# +1.00037276"},
        {"Smithsonian Astrophysical Observation", "SAO 195999"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.98417843),
        dec: Angle.Degrees(-30.53628921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38138"},
        {"Hipparcos Number", "HIP 26862"},
        {"Fundamental Katalog 5th Edition", "FK5 2428"},
        {"Geneva Identification System", "GEN# +1.00038138"},
        {"Smithsonian Astrophysical Observation", "SAO 196096"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.54826244),
        dec: Angle.Degrees(-30.53546199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140194"},
        {"Hipparcos Number", "HIP 77010"},
        {"Geneva Identification System", "GEN# +1.00140194"},
        {"Smithsonian Astrophysical Observation", "SAO 206906"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.85983066),
        dec: Angle.Degrees(-30.53497193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92656"},
        {"Hipparcos Number", "HIP 52318"},
        {"Smithsonian Astrophysical Observation", "SAO 201639"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.35809437),
        dec: Angle.Degrees(-30.53420417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44746"},
        {"Hipparcos Number", "HIP 30271"},
        {"Smithsonian Astrophysical Observation", "SAO 196733"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.51295767),
        dec: Angle.Degrees(-30.53353524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222943"},
        {"Hipparcos Number", "HIP 117170"},
        {"Smithsonian Astrophysical Observation", "SAO 214754"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.33576997),
        dec: Angle.Degrees(-30.53298033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145131"},
        {"Hipparcos Number", "HIP 79249"},
        {"Smithsonian Astrophysical Observation", "SAO 207414"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.60079245),
        dec: Angle.Degrees(-30.53075653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150417"},
        {"Hipparcos Number", "HIP 81764"},
        {"Smithsonian Astrophysical Observation", "SAO 207939"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.52283101),
        dec: Angle.Degrees(-30.52913926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172356"},
        {"Hipparcos Number", "HIP 91612"},
        {"Fundamental Katalog 5th Edition", "FK5 5641"},
        {"Smithsonian Astrophysical Observation", "SAO 210453"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.25179890),
        dec: Angle.Degrees(-30.52898920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81091"},
        {"Hipparcos Number", "HIP 45991"},
        {"Fundamental Katalog 5th Edition", "FK5 4832"},
        {"Smithsonian Astrophysical Observation", "SAO 200300"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.69686835),
        dec: Angle.Degrees(-30.52532786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115318",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115318"},
        {"Smithsonian Astrophysical Observation", "SAO 214486"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.34788161),
        dec: Angle.Degrees(-30.52474706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12914"},
        {"Smithsonian Astrophysical Observation", "SAO 193902"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.51241261),
        dec: Angle.Degrees(-30.52447333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133296"},
        {"Hipparcos Number", "HIP 73761"},
        {"Smithsonian Astrophysical Observation", "SAO 206266"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.16707118),
        dec: Angle.Degrees(-30.52208446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53890"},
        {"Hipparcos Number", "HIP 34187"},
        {"Geneva Identification System", "GEN# +1.00053890"},
        {"Smithsonian Astrophysical Observation", "SAO 197548"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.34195039),
        dec: Angle.Degrees(-30.51982437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100090"},
        {"Hipparcos Number", "HIP 56172"},
        {"Smithsonian Astrophysical Observation", "SAO 202522"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72227097),
        dec: Angle.Degrees(-30.51658569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21955"},
        {"Hipparcos Number", "HIP 16413"},
        {"Smithsonian Astrophysical Observation", "SAO 194352"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.83657071),
        dec: Angle.Degrees(-30.51629269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153423"},
        {"Hipparcos Number", "HIP 83241"},
        {"Smithsonian Astrophysical Observation", "SAO 208296"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.19123236),
        dec: Angle.Degrees(-30.51617442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49650"},
    },
    visualMagnitude: 11.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.02926721),
        dec: Angle.Degrees(-30.51581360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171154"},
        {"Hipparcos Number", "HIP 91053"},
        {"Geneva Identification System", "GEN# +1.00171154"},
        {"Smithsonian Astrophysical Observation", "SAO 210326"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.61100888),
        dec: Angle.Degrees(-30.51305403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72175"},
        {"Hipparcos Number", "HIP 41714"},
        {"Renson", "Renson 19940"},
        {"Smithsonian Astrophysical Observation", "SAO 199305"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.59850774),
        dec: Angle.Degrees(-30.51233716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89696"},
        {"Hipparcos Number", "HIP 50633"},
        {"Smithsonian Astrophysical Observation", "SAO 201295"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.12765811),
        dec: Angle.Degrees(-30.51129938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199618"},
        {"Hipparcos Number", "HIP 103597"},
        {"Geneva Identification System", "GEN# +1.00199618"},
        {"Smithsonian Astrophysical Observation", "SAO 212598"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.85524795),
        dec: Angle.Degrees(-30.51089127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98546",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98546"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.28328988),
        dec: Angle.Degrees(-30.51079602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98101"},
        {"Smithsonian Astrophysical Observation", "SAO 211666"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.05150723),
        dec: Angle.Degrees(-30.51029132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22997"},
        {"Hipparcos Number", "HIP 17150"},
        {"Smithsonian Astrophysical Observation", "SAO 194442"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.09261202),
        dec: Angle.Degrees(-30.50833726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102396"},
        {"Hipparcos Number", "HIP 57489"},
        {"Smithsonian Astrophysical Observation", "SAO 202800"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.75711397),
        dec: Angle.Degrees(-30.50172436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54497"},
        {"Hipparcos Number", "HIP 34383"},
        {"Smithsonian Astrophysical Observation", "SAO 197604"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.94239580),
        dec: Angle.Degrees(-30.50169621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19913"},
        {"Hipparcos Number", "HIP 14806"},
        {"Smithsonian Astrophysical Observation", "SAO 194139"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.79993399),
        dec: Angle.Degrees(-30.50135859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157016"},
        {"Hipparcos Number", "HIP 84982"},
        {"Geneva Identification System", "GEN# +1.00157016"},
        {"Smithsonian Astrophysical Observation", "SAO 208730"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.53802128),
        dec: Angle.Degrees(-30.50132828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83794"},
        {"Hipparcos Number", "HIP 47439"},
        {"Renson", "Renson 23880"},
        {"Smithsonian Astrophysical Observation", "SAO 200610"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.00874292),
        dec: Angle.Degrees(-30.49982028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73457"},
        {"Hipparcos Number", "HIP 42307"},
        {"Smithsonian Astrophysical Observation", "SAO 199435"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.38376615),
        dec: Angle.Degrees(-30.49886136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51738"},
        {"Hipparcos Number", "HIP 33443"},
        {"Geneva Identification System", "GEN# +1.00051738"},
        {"Smithsonian Astrophysical Observation", "SAO 197396"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.30196841),
        dec: Angle.Degrees(-30.49344100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160573"},
        {"Hipparcos Number", "HIP 86629"},
        {"Geneva Identification System", "GEN# +1.00160573"},
        {"Smithsonian Astrophysical Observation", "SAO 209155"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.51508400),
        dec: Angle.Degrees(-30.49221524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143070"},
        {"Hipparcos Number", "HIP 78303"},
        {"Smithsonian Astrophysical Observation", "SAO 207196"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.82976628),
        dec: Angle.Degrees(-30.49112248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214519"},
        {"Hipparcos Number", "HIP 111838"},
        {"Geneva Identification System", "GEN# +1.00214519"},
        {"Smithsonian Astrophysical Observation", "SAO 213987"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.80397450),
        dec: Angle.Degrees(-30.49111551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25371"},
        {"Hipparcos Number", "HIP 18723"},
        {"Fundamental Katalog 5th Edition", "FK5 2289"},
        {"Geneva Identification System", "GEN# +1.00025371"},
        {"Smithsonian Astrophysical Observation", "SAO 194689"},
        {"Wilson Evans Batten Catalogue", "WEB 3605"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.16926440),
        dec: Angle.Degrees(-30.49070974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99033"},
        {"Hipparcos Number", "HIP 55615"},
        {"Smithsonian Astrophysical Observation", "SAO 202395"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.91124616),
        dec: Angle.Degrees(-30.49020959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193980"},
        {"Hipparcos Number", "HIP 100621"},
        {"Geneva Identification System", "GEN# +1.00193980"},
        {"Smithsonian Astrophysical Observation", "SAO 212082"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.04498037),
        dec: Angle.Degrees(-30.48962289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204030"},
        {"Hipparcos Number", "HIP 105884"},
        {"Smithsonian Astrophysical Observation", "SAO 213002"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.67301094),
        dec: Angle.Degrees(-30.48887774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211294"},
        {"Hipparcos Number", "HIP 109999"},
        {"Geneva Identification System", "GEN# +1.00211294"},
        {"Smithsonian Astrophysical Observation", "SAO 213691"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.19465478),
        dec: Angle.Degrees(-30.48862192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6402"},
        {"Hipparcos Number", "HIP 5046"},
        {"Geneva Identification System", "GEN# +1.00006402"},
        {"Smithsonian Astrophysical Observation", "SAO 192908"},
        {"Wilson Evans Batten Catalogue", "WEB 1033"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.15529202),
        dec: Angle.Degrees(-30.48839683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5631"},
        {"Hipparcos Number", "HIP 4502"},
        {"Geneva Identification System", "GEN# +1.00005631"},
        {"Smithsonian Astrophysical Observation", "SAO 192840"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.41814873),
        dec: Angle.Degrees(-30.48790488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107502"},
        {"Hipparcos Number", "HIP 60273"},
        {"Smithsonian Astrophysical Observation", "SAO 203381"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.37445891),
        dec: Angle.Degrees(-30.48505378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101326"},
        {"Hipparcos Number", "HIP 56869"},
        {"Smithsonian Astrophysical Observation", "SAO 202676"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.88937371),
        dec: Angle.Degrees(-30.48380361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147682"},
        {"Hipparcos Number", "HIP 80385"},
        {"Smithsonian Astrophysical Observation", "SAO 207640"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.12489700),
        dec: Angle.Degrees(-30.48180927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42968"},
        {"Hipparcos Number", "HIP 29455"},
        {"Renson", "Renson 11470"},
        {"Smithsonian Astrophysical Observation", "SAO 196580"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.09356179),
        dec: Angle.Degrees(-30.48153953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17321"},
        {"Hipparcos Number", "HIP 12907"},
        {"Geneva Identification System", "GEN# +1.00017321"},
        {"Smithsonian Astrophysical Observation", "SAO 193897"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.48020936),
        dec: Angle.Degrees(-30.48097352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101404"},
        {"Hipparcos Number", "HIP 56912"},
        {"Smithsonian Astrophysical Observation", "SAO 202690"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.00399950),
        dec: Angle.Degrees(-30.47998356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 619"},
        {"Hipparcos Number", "HIP 850"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.60694761),
        dec: Angle.Degrees(-30.47906079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197541"},
        {"Hipparcos Number", "HIP 102435"},
        {"Geneva Identification System", "GEN# +1.00197541"},
        {"Smithsonian Astrophysical Observation", "SAO 212410"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.34940626),
        dec: Angle.Degrees(-30.47815034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135778"},
        {"Hipparcos Number", "HIP 74865"},
        {"Smithsonian Astrophysical Observation", "SAO 206499"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.48385820),
        dec: Angle.Degrees(-30.47810422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316354"},
        {"Hipparcos Number", "HIP 87173"},
        {"Geneva Identification System", "GEN# +1.00316354"},
        {"Smithsonian Astrophysical Observation", "SAO 209288"},
        {"Wilson Evans Batten Catalogue", "WEB 14708"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.15624841),
        dec: Angle.Degrees(-30.47595644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75122"},
        {"Hipparcos Number", "HIP 43139"},
        {"Smithsonian Astrophysical Observation", "SAO 199616"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.80450977),
        dec: Angle.Degrees(-30.47504469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119856"},
        {"Hipparcos Number", "HIP 67203"},
        {"Geneva Identification System", "GEN# +1.00119856"},
        {"Smithsonian Astrophysical Observation", "SAO 204825"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.57340213),
        dec: Angle.Degrees(-30.47444307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111680"},
        {"Hipparcos Number", "HIP 62731"},
        {"Smithsonian Astrophysical Observation", "SAO 203868"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.82085526),
        dec: Angle.Degrees(-30.47378807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195843"},
        {"Hipparcos Number", "HIP 101552"},
        {"Geneva Identification System", "GEN# +1.00195843"},
        {"Smithsonian Astrophysical Observation", "SAO 212249"},
        {"Wilson Evans Batten Catalogue", "WEB 18350"},
    },
    visualMagnitude: 6.42,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.69742531),
        dec: Angle.Degrees(-30.47341857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47946"},
        {"Hipparcos Number", "HIP 31870"},
        {"Geneva Identification System", "GEN# +1.00047946"},
        {"Smithsonian Astrophysical Observation", "SAO 197057"},
    },
    visualMagnitude: 5.70,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.92777365),
        dec: Angle.Degrees(-30.47002424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190980"},
        {"Hipparcos Number", "HIP 99230"},
        {"Smithsonian Astrophysical Observation", "SAO 211850"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.14979270),
        dec: Angle.Degrees(-30.46959276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25524"},
        {"Hipparcos Number", "HIP 18821"},
        {"Smithsonian Astrophysical Observation", "SAO 194707"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.50781564),
        dec: Angle.Degrees(-30.46870103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181010"},
        {"Hipparcos Number", "HIP 95006"},
        {"Geneva Identification System", "GEN# +1.00181010"},
        {"Smithsonian Astrophysical Observation", "SAO 211178"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.98382840),
        dec: Angle.Degrees(-30.46869843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14296"},
        {"Hipparcos Number", "HIP 10709"},
        {"Smithsonian Astrophysical Observation", "SAO 193626"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.48014940),
        dec: Angle.Degrees(-30.46831065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33871"},
        {"Hipparcos Number", "HIP 24214"},
        {"Smithsonian Astrophysical Observation", "SAO 195644"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.99355433),
        dec: Angle.Degrees(-30.46828934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39503"},
        {"Hipparcos Number", "HIP 27688"},
        {"Geneva Identification System", "GEN# +1.00039503"},
        {"Smithsonian Astrophysical Observation", "SAO 196250"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.93243843),
        dec: Angle.Degrees(-30.46563246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 150.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149981"},
        {"Hipparcos Number", "HIP 81552"},
        {"Geneva Identification System", "GEN# +1.00149981"},
        {"Smithsonian Astrophysical Observation", "SAO 207889"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.83638727),
        dec: Angle.Degrees(-30.46474846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21501"},
        {"Hipparcos Number", "HIP 16073"},
        {"Smithsonian Astrophysical Observation", "SAO 194304"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.75477415),
        dec: Angle.Degrees(-30.46386120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217151"},
        {"Hipparcos Number", "HIP 113483"},
        {"Smithsonian Astrophysical Observation", "SAO 214218"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.73033546),
        dec: Angle.Degrees(-30.46173065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204017"},
        {"Hipparcos Number", "HIP 105873"},
        {"Smithsonian Astrophysical Observation", "SAO 213001"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.62834711),
        dec: Angle.Degrees(-30.46102783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38569",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38569"},
    },
    visualMagnitude: 11.05,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.45326348),
        dec: Angle.Degrees(-30.46033195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180068"},
        {"Hipparcos Number", "HIP 94705"},
        {"Fundamental Katalog 5th Edition", "FK5 3539"},
        {"Smithsonian Astrophysical Observation", "SAO 211111"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.05621988),
        dec: Angle.Degrees(-30.45956781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29704"},
        {"Hipparcos Number", "HIP 21688"},
        {"Smithsonian Astrophysical Observation", "SAO 195203"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.84505478),
        dec: Angle.Degrees(-30.45663535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97131"},
        {"Hipparcos Number", "HIP 54610"},
        {"Geneva Identification System", "GEN# +1.00097131"},
        {"Smithsonian Astrophysical Observation", "SAO 202164"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.64275794),
        dec: Angle.Degrees(-30.45513434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195931"},
        {"Hipparcos Number", "HIP 101586"},
        {"Smithsonian Astrophysical Observation", "SAO 212260"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.82219886),
        dec: Angle.Degrees(-30.45453315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44343"},
        {"Hipparcos Number", "HIP 30095"},
        {"Smithsonian Astrophysical Observation", "SAO 196692"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.00187317),
        dec: Angle.Degrees(-30.45448433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27287"},
        {"Hipparcos Number", "HIP 20001"},
        {"Smithsonian Astrophysical Observation", "SAO 194892"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33348842),
        dec: Angle.Degrees(-30.45432259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56997"},
        {"Hipparcos Number", "HIP 35348"},
        {"Geneva Identification System", "GEN# +5.11320017"},
        {"Smithsonian Astrophysical Observation", "SAO 197817"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.51848277),
        dec: Angle.Degrees(-30.45325533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219057"},
        {"Hipparcos Number", "HIP 114615"},
        {"Geneva Identification System", "GEN# +1.00219057"},
        {"Smithsonian Astrophysical Observation", "SAO 214387"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.29087454),
        dec: Angle.Degrees(-30.44977184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58283"},
        {"Hipparcos Number", "HIP 35866"},
        {"Smithsonian Astrophysical Observation", "SAO 197941"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.91837852),
        dec: Angle.Degrees(-30.44925737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47117"},
        {"Hipparcos Number", "HIP 31489"},
        {"Smithsonian Astrophysical Observation", "SAO 196981"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.92330206),
        dec: Angle.Degrees(-30.44892105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224433"},
        {"Hipparcos Number", "HIP 118143"},
        {"Geneva Identification System", "GEN# +1.00224433"},
        {"Smithsonian Astrophysical Observation", "SAO 214880"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.45916490),
        dec: Angle.Degrees(-30.44746094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14306"},
        {"Smithsonian Astrophysical Observation", "SAO 194068"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.13687700),
        dec: Angle.Degrees(-30.44642916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98531"},
        {"Hipparcos Number", "HIP 55338"},
        {"Smithsonian Astrophysical Observation", "SAO 202328"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.98597768),
        dec: Angle.Degrees(-30.44634237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78242"},
        {"Smithsonian Astrophysical Observation", "SAO 207183"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.63681709),
        dec: Angle.Degrees(-30.44625040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -282.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217826"},
        {"Hipparcos Number", "HIP 113878"},
        {"Geneva Identification System", "GEN# +1.00217826"},
        {"Smithsonian Astrophysical Observation", "SAO 214278"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.93423339),
        dec: Angle.Degrees(-30.44489355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28720"},
        {"Hipparcos Number", "HIP 21012"},
        {"Smithsonian Astrophysical Observation", "SAO 195076"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.59333554),
        dec: Angle.Degrees(-30.44411076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147937"},
        {"Hipparcos Number", "HIP 80497"},
        {"Geneva Identification System", "GEN# +1.00147937"},
        {"Smithsonian Astrophysical Observation", "SAO 207659"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.47517016),
        dec: Angle.Degrees(-30.44401972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15412"},
        {"Hipparcos Number", "HIP 11471"},
        {"Smithsonian Astrophysical Observation", "SAO 193722"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.99693482),
        dec: Angle.Degrees(-30.44112239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107352"},
        {"Hipparcos Number", "HIP 60187"},
        {"Smithsonian Astrophysical Observation", "SAO 203361"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.13994937),
        dec: Angle.Degrees(-30.43889711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17884"},
        {"Hipparcos Number", "HIP 13317"},
        {"Fundamental Katalog 5th Edition", "FK5 4262"},
        {"Geneva Identification System", "GEN# +1.00017884"},
        {"Smithsonian Astrophysical Observation", "SAO 193948"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.84394329),
        dec: Angle.Degrees(-30.43734792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26697"},
        {"Hipparcos Number", "HIP 19613"},
        {"Smithsonian Astrophysical Observation", "SAO 194822"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.04317750),
        dec: Angle.Degrees(-30.43656689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96187"},
        {"Hipparcos Number", "HIP 54192"},
        {"Fundamental Katalog 5th Edition", "FK5 4978"},
        {"Smithsonian Astrophysical Observation", "SAO 202073"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.30150158),
        dec: Angle.Degrees(-30.43567002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56554"},
        {"Hipparcos Number", "HIP 35168"},
        {"Celescope Catalog", "CEL 1732"},
        {"Geneva Identification System", "GEN# +5.11320008"},
        {"Smithsonian Astrophysical Observation", "SAO 197770"},
    },
    visualMagnitude: 7.15,
    bvColour: -0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.02875984),
        dec: Angle.Degrees(-30.43536779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113971"},
        {"Hipparcos Number", "HIP 64055"},
        {"Fundamental Katalog 5th Edition", "FK5 5161"},
        {"Renson", "Renson 33010"},
        {"Smithsonian Astrophysical Observation", "SAO 204145"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.91252921),
        dec: Angle.Degrees(-30.43489928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1258"},
        {"Hipparcos Number", "HIP 1328"},
        {"Smithsonian Astrophysical Observation", "SAO 192440"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.17025731),
        dec: Angle.Degrees(-30.43457026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155293"},
        {"Hipparcos Number", "HIP 84126"},
        {"Geneva Identification System", "GEN# +1.00155293"},
        {"Smithsonian Astrophysical Observation", "SAO 208518"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.97579237),
        dec: Angle.Degrees(-30.43288609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88729"},
        {"Hipparcos Number", "HIP 50076"},
        {"Fundamental Katalog 5th Edition", "FK5 4909"},
        {"Smithsonian Astrophysical Observation", "SAO 201185"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.36498893),
        dec: Angle.Degrees(-30.43048533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152192"},
        {"Hipparcos Number", "HIP 82598"},
        {"Geneva Identification System", "GEN# +1.00152192"},
        {"Renson", "Renson 43080"},
        {"Smithsonian Astrophysical Observation", "SAO 208138"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.27946158),
        dec: Angle.Degrees(-30.42959613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29453"},
        {"Hipparcos Number", "HIP 21502"},
        {"Smithsonian Astrophysical Observation", "SAO 195164"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.27348853),
        dec: Angle.Degrees(-30.42931279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209913"},
        {"Hipparcos Number", "HIP 109207"},
        {"Geneva Identification System", "GEN# +1.00209913"},
        {"Smithsonian Astrophysical Observation", "SAO 213563"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.86315499),
        dec: Angle.Degrees(-30.42929276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 373.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5886"},
        {"Hipparcos Number", "HIP 4667"},
        {"Smithsonian Astrophysical Observation", "SAO 192856"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.98691942),
        dec: Angle.Degrees(-30.42928418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156639"},
        {"Hipparcos Number", "HIP 84806"},
        {"Geneva Identification System", "GEN# +1.00156639"},
        {"Smithsonian Astrophysical Observation", "SAO 208694"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.00170421),
        dec: Angle.Degrees(-30.42914031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50498"},
        {"Hipparcos Number", "HIP 32976"},
        {"Geneva Identification System", "GEN# +1.00050498"},
        {"Smithsonian Astrophysical Observation", "SAO 197295"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.04017839),
        dec: Angle.Degrees(-30.42703517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142217"},
        {"Hipparcos Number", "HIP 77896"},
        {"Geneva Identification System", "GEN# +1.00142217"},
        {"Smithsonian Astrophysical Observation", "SAO 207103"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.61272881),
        dec: Angle.Degrees(-30.42529265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65880"},
    },
    visualMagnitude: 12.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.56349616),
        dec: Angle.Degrees(-30.42518668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72345"},
        {"Smithsonian Astrophysical Observation", "SAO 205949"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.90438181),
        dec: Angle.Degrees(-30.42446564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12371"},
        {"Hipparcos Number", "HIP 9382"},
        {"Geneva Identification System", "GEN# +1.00012371"},
        {"Smithsonian Astrophysical Observation", "SAO 193449"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.13987388),
        dec: Angle.Degrees(-30.42416672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88635",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alnasl"},
        {"Henry Draper", "HD 165135"},
        {"Hipparcos Number", "HIP 88635"},
        {"Fundamental Katalog 5th Edition", "FK5 679"},
        {"Geneva Identification System", "GEN# +1.00165135"},
        {"Smithsonian Astrophysical Observation", "SAO 209696"},
        {"Wilson Evans Batten Catalogue", "WEB 15012"},
    },
    visualMagnitude: 2.98,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.45218586),
        dec: Angle.Degrees(-30.42365007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198280"},
        {"Hipparcos Number", "HIP 102856"},
        {"Geneva Identification System", "GEN# +1.00198280"},
        {"Smithsonian Astrophysical Observation", "SAO 212480"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.57147099),
        dec: Angle.Degrees(-30.42337481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109960"},
        {"Hipparcos Number", "HIP 61720"},
        {"Fundamental Katalog 5th Edition", "FK5 3011"},
        {"Geneva Identification System", "GEN# +1.00109960"},
        {"Smithsonian Astrophysical Observation", "SAO 203666"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.76451917),
        dec: Angle.Degrees(-30.42234930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92735"},
    },
    visualMagnitude: 12.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.45828061),
        dec: Angle.Degrees(-30.42133231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69249"},
        {"Hipparcos Number", "HIP 40412"},
        {"Celescope Catalog", "CEL 2275"},
        {"Geneva Identification System", "GEN# +1.00069249"},
        {"Smithsonian Astrophysical Observation", "SAO 198988"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.75287296),
        dec: Angle.Degrees(-30.41930509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133571"},
        {"Hipparcos Number", "HIP 73898"},
        {"Smithsonian Astrophysical Observation", "SAO 206293"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.54614296),
        dec: Angle.Degrees(-30.41840540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66434"},
        {"Hipparcos Number", "HIP 39327"},
        {"Smithsonian Astrophysical Observation", "SAO 198727"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61044383),
        dec: Angle.Degrees(-30.41801037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4189"},
        {"Hipparcos Number", "HIP 3453"},
        {"Geneva Identification System", "GEN# +1.00004189A"},
        {"Smithsonian Astrophysical Observation", "SAO 192702"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.03344736),
        dec: Angle.Degrees(-30.41717180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75650"},
        {"Hipparcos Number", "HIP 43385"},
        {"Smithsonian Astrophysical Observation", "SAO 199685"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.56323333),
        dec: Angle.Degrees(-30.41675431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144500"},
        {"Hipparcos Number", "HIP 78979"},
        {"Geneva Identification System", "GEN# +1.00144500"},
        {"Smithsonian Astrophysical Observation", "SAO 207345"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.83241418),
        dec: Angle.Degrees(-30.41551811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130295"},
        {"Hipparcos Number", "HIP 72401"},
        {"Geneva Identification System", "GEN# +1.00130295"},
        {"Smithsonian Astrophysical Observation", "SAO 205958"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.04531984),
        dec: Angle.Degrees(-30.41443586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65887"},
        {"Hipparcos Number", "HIP 39091"},
        {"Geneva Identification System", "GEN# +1.00065887"},
        {"Smithsonian Astrophysical Observation", "SAO 198670"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.95454033),
        dec: Angle.Degrees(-30.41237363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15164"},
        {"Smithsonian Astrophysical Observation", "SAO 194185"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.86795954),
        dec: Angle.Degrees(-30.41112078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2862"},
        {"Hipparcos Number", "HIP 2506"},
        {"Geneva Identification System", "GEN# +1.00002862"},
        {"Smithsonian Astrophysical Observation", "SAO 192589"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.94536783),
        dec: Angle.Degrees(-30.41094105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13749"},
        {"Geneva Identification System", "GEN# -0.03001121"},
        {"Smithsonian Astrophysical Observation", "SAO 194000"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.25111023),
        dec: Angle.Degrees(-30.41032194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9076"},
        {"Hipparcos Number", "HIP 6892"},
        {"Smithsonian Astrophysical Observation", "SAO 193135"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.18754829),
        dec: Angle.Degrees(-30.40851581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41291"},
        {"Hipparcos Number", "HIP 28641"},
        {"Smithsonian Astrophysical Observation", "SAO 196437"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.71934891),
        dec: Angle.Degrees(-30.40765119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187064"},
        {"Hipparcos Number", "HIP 97502"},
        {"Geneva Identification System", "GEN# +1.00187064"},
        {"Smithsonian Astrophysical Observation", "SAO 211573"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.26630697),
        dec: Angle.Degrees(-30.40647166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16916"},
        {"Hipparcos Number", "HIP 12586"},
        {"Geneva Identification System", "GEN# +1.00016916"},
        {"Smithsonian Astrophysical Observation", "SAO 193867"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.46684804),
        dec: Angle.Degrees(-30.40455183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316766"},
        {"Hipparcos Number", "HIP 87956"},
    },
    visualMagnitude: 9.50,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52072044),
        dec: Angle.Degrees(-30.40379299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136624"},
        {"Hipparcos Number", "HIP 75276"},
        {"Smithsonian Astrophysical Observation", "SAO 206575"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.69311133),
        dec: Angle.Degrees(-30.40376433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154783"},
        {"Hipparcos Number", "HIP 83896"},
        {"Fundamental Katalog 5th Edition", "FK5 3363"},
        {"Geneva Identification System", "GEN# +1.00154783"},
        {"Renson", "Renson 43720"},
        {"Smithsonian Astrophysical Observation", "SAO 208467"},
        {"Wilson Evans Batten Catalogue", "WEB 14178"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.19810689),
        dec: Angle.Degrees(-30.40356872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15360"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.51707787),
        dec: Angle.Degrees(-30.40248055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -327.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158681"},
        {"Hipparcos Number", "HIP 85803"},
        {"Geneva Identification System", "GEN# +1.00158681"},
        {"Smithsonian Astrophysical Observation", "SAO 208925"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.98561497),
        dec: Angle.Degrees(-30.40119663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111290",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111290"},
        {"Smithsonian Astrophysical Observation", "SAO 213895"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.17848990),
        dec: Angle.Degrees(-30.40108441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106317"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.00307441),
        dec: Angle.Degrees(-30.39945058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6307"},
        {"Hipparcos Number", "HIP 4974"},
        {"Smithsonian Astrophysical Observation", "SAO 192896"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.93255194),
        dec: Angle.Degrees(-30.39861517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48864"},
        {"Geneva Identification System", "GEN# -0.02907960J"},
        {"Smithsonian Astrophysical Observation", "SAO 200912"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.49694046),
        dec: Angle.Degrees(-30.39793478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150847"},
        {"Hipparcos Number", "HIP 81985"},
        {"Smithsonian Astrophysical Observation", "SAO 207987"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.22088488),
        dec: Angle.Degrees(-30.39510678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169586"},
        {"Hipparcos Number", "HIP 90397"},
        {"Geneva Identification System", "GEN# +1.00169586"},
        {"Smithsonian Astrophysical Observation", "SAO 210159"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.67001005),
        dec: Angle.Degrees(-30.39318111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70945"},
        {"Hipparcos Number", "HIP 41145"},
        {"Renson", "Renson 19580"},
        {"Smithsonian Astrophysical Observation", "SAO 199171"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.92489020),
        dec: Angle.Degrees(-30.39209817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49091"},
        {"Geneva Identification System", "GEN# +9.86535003"},
        {"Geneva Identification System 2", "GEN# -0.02908019"},
    },
    visualMagnitude: 11.43,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.29784725),
        dec: Angle.Degrees(-30.39171436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1098.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 646.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60556"},
        {"Hipparcos Number", "HIP 36770"},
        {"Geneva Identification System", "GEN# +1.00060556"},
        {"Smithsonian Astrophysical Observation", "SAO 198124"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.43981255),
        dec: Angle.Degrees(-30.38947677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73737"},
        {"Hipparcos Number", "HIP 42410"},
        {"Geneva Identification System", "GEN# +1.00073737"},
        {"Renson", "Renson 20560"},
        {"Smithsonian Astrophysical Observation", "SAO 199462"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.71694073),
        dec: Angle.Degrees(-30.38757800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62249"},
        {"Hipparcos Number", "HIP 37505"},
        {"Smithsonian Astrophysical Observation", "SAO 198308"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.45710006),
        dec: Angle.Degrees(-30.38610522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82364"},
        {"Hipparcos Number", "HIP 46638"},
        {"Smithsonian Astrophysical Observation", "SAO 200441"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.64987962),
        dec: Angle.Degrees(-30.38197411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113221"},
    },
    visualMagnitude: 11.71,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.93184544),
        dec: Angle.Degrees(-30.37791237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 353.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116623"},
        {"Hipparcos Number", "HIP 65476"},
        {"Smithsonian Astrophysical Observation", "SAO 204452"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.30353460),
        dec: Angle.Degrees(-30.37687052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65923"},
        {"Hipparcos Number", "HIP 39101"},
        {"Geneva Identification System", "GEN# +1.00065923J"},
        {"Smithsonian Astrophysical Observation", "SAO 198673"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.98797404),
        dec: Angle.Degrees(-30.37563961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74779",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74779"},
        {"Smithsonian Astrophysical Observation", "SAO 206482"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.24155719),
        dec: Angle.Degrees(-30.36737455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79768"},
        {"Hipparcos Number", "HIP 45394"},
        {"Smithsonian Astrophysical Observation", "SAO 200151"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.76562628),
        dec: Angle.Degrees(-30.36711687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34504"},
        {"Hipparcos Number", "HIP 24601"},
        {"Geneva Identification System", "GEN# +1.00034504"},
        {"Smithsonian Astrophysical Observation", "SAO 195706"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.15527189),
        dec: Angle.Degrees(-30.36701162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3967"},
        {"Smithsonian Astrophysical Observation", "SAO 192774"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.74703157),
        dec: Angle.Degrees(-30.36573699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7440"},
        {"Hipparcos Number", "HIP 5773"},
        {"Smithsonian Astrophysical Observation", "SAO 192998"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.52261139),
        dec: Angle.Degrees(-30.36566610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78922"},
        {"Hipparcos Number", "HIP 45001"},
        {"Fundamental Katalog 5th Edition", "FK5 1241"},
        {"Geneva Identification System", "GEN# +1.00078922A"},
        {"Renson", "Renson 22360"},
        {"Smithsonian Astrophysical Observation", "SAO 200047"},
        {"Wilson Evans Batten Catalogue", "WEB 8595"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.48504809),
        dec: Angle.Degrees(-30.36528248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183925"},
        {"Hipparcos Number", "HIP 96154"},
        {"Smithsonian Astrophysical Observation", "SAO 211355"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.26315610),
        dec: Angle.Degrees(-30.36274081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18837"},
        {"Hipparcos Number", "HIP 14053"},
        {"Smithsonian Astrophysical Observation", "SAO 194033"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.23920412),
        dec: Angle.Degrees(-30.36227399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129399"},
        {"Hipparcos Number", "HIP 71967"},
        {"Smithsonian Astrophysical Observation", "SAO 205863"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.78697103),
        dec: Angle.Degrees(-30.35919111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317269"},
        {"Hipparcos Number", "HIP 89124"},
        {"Smithsonian Astrophysical Observation", "SAO 209830"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.84369673),
        dec: Angle.Degrees(-30.35788141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132413"},
        {"Hipparcos Number", "HIP 73389"},
        {"Smithsonian Astrophysical Observation", "SAO 206182"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.97002205),
        dec: Angle.Degrees(-30.35763299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5133"},
        {"Hipparcos Number", "HIP 4148"},
        {"Cincinnati Publication", "Ci 20 62"},
        {"Cincinnati Publication 2", "Ci 18 119"},
        {"Geneva Identification System", "GEN# +1.00005133"},
        {"Smithsonian Astrophysical Observation", "SAO 192793"},
        {"Wilson Evans Batten Catalogue", "WEB 739"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.25298157),
        dec: Angle.Degrees(-30.35699137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 620.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223957"},
        {"Hipparcos Number", "HIP 117840"},
        {"Geneva Identification System", "GEN# +1.00223957"},
        {"Smithsonian Astrophysical Observation", "SAO 214844"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.48828012),
        dec: Angle.Degrees(-30.35695063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220323"},
        {"Hipparcos Number", "HIP 115442"},
        {"Smithsonian Astrophysical Observation", "SAO 214500"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.76359865),
        dec: Angle.Degrees(-30.35552841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147120"},
        {"Hipparcos Number", "HIP 80098"},
        {"Geneva Identification System", "GEN# +1.00147120"},
        {"Smithsonian Astrophysical Observation", "SAO 207582"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.25978320),
        dec: Angle.Degrees(-30.35244888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130160"},
        {"Hipparcos Number", "HIP 72329"},
        {"Smithsonian Astrophysical Observation", "SAO 205945"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.85340418),
        dec: Angle.Degrees(-30.35236854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15678"},
        {"Henry Draper 2", "HD 15678A"},
        {"Hipparcos Number", "HIP 11660"},
        {"Smithsonian Astrophysical Observation", "SAO 193744"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.59263502),
        dec: Angle.Degrees(-30.35205859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156096"},
        {"Hipparcos Number", "HIP 84533"},
        {"Geneva Identification System", "GEN# +1.00156096"},
        {"Smithsonian Astrophysical Observation", "SAO 208621"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.22631407),
        dec: Angle.Degrees(-30.35139562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1060"},
        {"Smithsonian Astrophysical Observation", "SAO 192405"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.29977405),
        dec: Angle.Degrees(-30.34983205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101285"},
        {"Hipparcos Number", "HIP 56845"},
        {"Geneva Identification System", "GEN# +1.00101285"},
        {"Smithsonian Astrophysical Observation", "SAO 202670"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.82014086),
        dec: Angle.Degrees(-30.34885363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140637"},
        {"Hipparcos Number", "HIP 77199"},
        {"Smithsonian Astrophysical Observation", "SAO 206946"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.44852974),
        dec: Angle.Degrees(-30.34857563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316901"},
        {"Hipparcos Number", "HIP 88042"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.74194673),
        dec: Angle.Degrees(-30.34524418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214535"},
        {"Hipparcos Number", "HIP 111846"},
        {"Smithsonian Astrophysical Observation", "SAO 213988"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.82555266),
        dec: Angle.Degrees(-30.34518666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179998"},
        {"Hipparcos Number", "HIP 94678"},
        {"Geneva Identification System", "GEN# +1.00179998"},
        {"Smithsonian Astrophysical Observation", "SAO 211104"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.98653962),
        dec: Angle.Degrees(-30.34283130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65743"},
        {"Hipparcos Number", "HIP 39011"},
        {"Renson", "Renson 18000"},
        {"Smithsonian Astrophysical Observation", "SAO 198659"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.75053595),
        dec: Angle.Degrees(-30.34030204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156117"},
        {"Hipparcos Number", "HIP 84542"},
        {"Geneva Identification System", "GEN# +1.00156117"},
        {"Smithsonian Astrophysical Observation", "SAO 208624"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.24944967),
        dec: Angle.Degrees(-30.33999963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55985"},
        {"Hipparcos Number", "HIP 34954"},
        {"Celescope Catalog", "CEL 1693"},
        {"Geneva Identification System", "GEN# +5.11210043"},
        {"Geneva Identification System 2", "GEN# +5.11320004"},
        {"Smithsonian Astrophysical Observation", "SAO 197722"},
        {"Wilson Evans Batten Catalogue", "WEB 6991"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.48891963),
        dec: Angle.Degrees(-30.33980156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113256"},
        {"Hipparcos Number", "HIP 63657"},
        {"Smithsonian Astrophysical Observation", "SAO 204070"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.69746188),
        dec: Angle.Degrees(-30.33876640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91755"},
        {"Hipparcos Number", "HIP 51818"},
        {"Smithsonian Astrophysical Observation", "SAO 201532"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.79392430),
        dec: Angle.Degrees(-30.33745936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46814"},
        {"Hipparcos Number", "HIP 31317"},
        {"Geneva Identification System", "GEN# +1.00046814"},
        {"Smithsonian Astrophysical Observation", "SAO 196946"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.51542038),
        dec: Angle.Degrees(-30.33710001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104267"},
        {"Hipparcos Number", "HIP 58551"},
        {"Smithsonian Astrophysical Observation", "SAO 203031"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.10114271),
        dec: Angle.Degrees(-30.33656163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29834"},
        {"Smithsonian Astrophysical Observation", "SAO 196648"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.22956782),
        dec: Angle.Degrees(-30.33639003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214003"},
        {"Hipparcos Number", "HIP 111537"},
        {"Smithsonian Astrophysical Observation", "SAO 213940"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.94887427),
        dec: Angle.Degrees(-30.33582686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107869"},
        {"Hipparcos Number", "HIP 60468"},
        {"Geneva Identification System", "GEN# +1.00107869"},
        {"Smithsonian Astrophysical Observation", "SAO 203427"},
        {"Wilson Evans Batten Catalogue", "WEB 10754"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.94925486),
        dec: Angle.Degrees(-30.33538535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21881"},
        {"Hipparcos Number", "HIP 16337"},
        {"Geneva Identification System", "GEN# +1.00021881"},
        {"Smithsonian Astrophysical Observation", "SAO 194341"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.64780309),
        dec: Angle.Degrees(-30.33492214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94589"},
        {"Hipparcos Number", "HIP 53372"},
        {"Smithsonian Astrophysical Observation", "SAO 201890"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.71041049),
        dec: Angle.Degrees(-30.33490020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65456"},
        {"Hipparcos Number", "HIP 38901"},
        {"Fundamental Katalog 5th Edition", "FK5 1210"},
        {"Geneva Identification System", "GEN# +1.00065456"},
        {"Smithsonian Astrophysical Observation", "SAO 198636"},
        {"Wilson Evans Batten Catalogue", "WEB 7622"},
    },
    visualMagnitude: 4.76,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.41713237),
        dec: Angle.Degrees(-30.33458703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3373"},
        {"Hipparcos Number", "HIP 2880"},
        {"Smithsonian Astrophysical Observation", "SAO 192633"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.12058276),
        dec: Angle.Degrees(-30.33364262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115770"},
        {"Hipparcos Number", "HIP 65020"},
        {"Smithsonian Astrophysical Observation", "SAO 204359"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.92890571),
        dec: Angle.Degrees(-30.33235404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143096"},
        {"Hipparcos Number", "HIP 78313"},
        {"Geneva Identification System", "GEN# +1.00143096"},
        {"Smithsonian Astrophysical Observation", "SAO 207197"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.85797956),
        dec: Angle.Degrees(-30.33214871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9554"},
        {"Smithsonian Astrophysical Observation", "SAO 193472"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.69198615),
        dec: Angle.Degrees(-30.33207827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28251"},
        {"Hipparcos Number", "HIP 20706"},
        {"Smithsonian Astrophysical Observation", "SAO 195010"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.54905839),
        dec: Angle.Degrees(-30.33126598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212400"},
        {"Hipparcos Number", "HIP 110608"},
        {"Smithsonian Astrophysical Observation", "SAO 213796"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.12752613),
        dec: Angle.Degrees(-30.32766196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120504"},
        {"Hipparcos Number", "HIP 67550"},
        {"Smithsonian Astrophysical Observation", "SAO 204896"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.62040082),
        dec: Angle.Degrees(-30.32753714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185791"},
        {"Hipparcos Number", "HIP 96915"},
        {"Smithsonian Astrophysical Observation", "SAO 211486"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.50847712),
        dec: Angle.Degrees(-30.32598370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98457"},
        {"Hipparcos Number", "HIP 55292"},
        {"Geneva Identification System", "GEN# +1.00098457"},
        {"Renson", "Renson 28360"},
        {"Smithsonian Astrophysical Observation", "SAO 202320"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.85806406),
        dec: Angle.Degrees(-30.32294494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67921"},
        {"Hipparcos Number", "HIP 39914"},
        {"Geneva Identification System", "GEN# +1.00067921J"},
        {"Smithsonian Astrophysical Observation", "SAO 198854"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.27770613),
        dec: Angle.Degrees(-30.32281551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68551"},
        {"Hipparcos Number", "HIP 40138"},
        {"Smithsonian Astrophysical Observation", "SAO 198914"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.95980156),
        dec: Angle.Degrees(-30.32272029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3091"},
        {"Hipparcos Number", "HIP 2683"},
        {"Geneva Identification System", "GEN# +1.00003091"},
        {"Smithsonian Astrophysical Observation", "SAO 192613"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.50085390),
        dec: Angle.Degrees(-30.32263417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12599"},
        {"Hipparcos Number", "HIP 9552"},
        {"Geneva Identification System", "GEN# +1.00012599"},
        {"Smithsonian Astrophysical Observation", "SAO 193470"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.68488736),
        dec: Angle.Degrees(-30.32189137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119642"},
        {"Hipparcos Number", "HIP 67084"},
        {"Smithsonian Astrophysical Observation", "SAO 204798"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.24801908),
        dec: Angle.Degrees(-30.32143576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315956"},
        {"Hipparcos Number", "HIP 85739"},
        {"Geneva Identification System", "GEN# +1.00315956"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.82063199),
        dec: Angle.Degrees(-30.32134545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31602"},
        {"Hipparcos Number", "HIP 22911"},
        {"Smithsonian Astrophysical Observation", "SAO 195408"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.95789346),
        dec: Angle.Degrees(-30.32105799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169019"},
        {"Hipparcos Number", "HIP 90158"},
        {"Smithsonian Astrophysical Observation", "SAO 210086"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.98174047),
        dec: Angle.Degrees(-30.31721501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207763"},
        {"Hipparcos Number", "HIP 107927"},
        {"Geneva Identification System", "GEN# +1.00207763"},
        {"Smithsonian Astrophysical Observation", "SAO 213350"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.99373907),
        dec: Angle.Degrees(-30.31665748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91478"},
        {"Smithsonian Astrophysical Observation", "SAO 210413"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.85933295),
        dec: Angle.Degrees(-30.31623546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84353"},
        {"Hipparcos Number", "HIP 47746"},
        {"Geneva Identification System", "GEN# +1.00084353"},
        {"Smithsonian Astrophysical Observation", "SAO 200670"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.00545410),
        dec: Angle.Degrees(-30.31544000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219555"},
        {"Hipparcos Number", "HIP 114935"},
        {"Smithsonian Astrophysical Observation", "SAO 214427"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.20741863),
        dec: Angle.Degrees(-30.31418813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26771"},
        {"Hipparcos Number", "HIP 19670"},
        {"Smithsonian Astrophysical Observation", "SAO 194834"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.21038407),
        dec: Angle.Degrees(-30.31417850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19563"},
        {"Hipparcos Number", "HIP 14557"},
        {"Smithsonian Astrophysical Observation", "SAO 194103"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.98799887),
        dec: Angle.Degrees(-30.31375333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7401"},
        {"Hipparcos Number", "HIP 5740"},
        {"Smithsonian Astrophysical Observation", "SAO 192993"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.43552477),
        dec: Angle.Degrees(-30.31029092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200622"},
        {"Hipparcos Number", "HIP 104103"},
        {"Smithsonian Astrophysical Observation", "SAO 212695"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.36391713),
        dec: Angle.Degrees(-30.30740241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40028"},
        {"Hipparcos Number", "HIP 27976"},
        {"Smithsonian Astrophysical Observation", "SAO 196305"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.74810093),
        dec: Angle.Degrees(-30.30581432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205929"},
        {"Hipparcos Number", "HIP 106929"},
        {"Smithsonian Astrophysical Observation", "SAO 213175"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.83316546),
        dec: Angle.Degrees(-30.30441665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84085"},
        {"Hipparcos Number", "HIP 47564"},
        {"Smithsonian Astrophysical Observation", "SAO 200644"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.46796851),
        dec: Angle.Degrees(-30.30340375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202789"},
        {"Hipparcos Number", "HIP 105252"},
        {"Smithsonian Astrophysical Observation", "SAO 212899"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.79006593),
        dec: Angle.Degrees(-30.30279487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 296.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11664"},
        {"Hipparcos Number", "HIP 8850"},
        {"Geneva Identification System", "GEN# +1.00011664"},
        {"Smithsonian Astrophysical Observation", "SAO 193372"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.46139509),
        dec: Angle.Degrees(-30.30219257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154603"},
        {"Hipparcos Number", "HIP 83806"},
        {"Smithsonian Astrophysical Observation", "SAO 208444"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.91289069),
        dec: Angle.Degrees(-30.30049076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161718"},
        {"Hipparcos Number", "HIP 87162"},
        {"Geneva Identification System", "GEN# +1.00161718"},
        {"Smithsonian Astrophysical Observation", "SAO 209283"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.10950386),
        dec: Angle.Degrees(-30.29944681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41390"},
        {"Smithsonian Astrophysical Observation", "SAO 199228"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.66612966),
        dec: Angle.Degrees(-30.29725277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182370"},
        {"Hipparcos Number", "HIP 95509"},
        {"Geneva Identification System", "GEN# +1.00182370"},
        {"Smithsonian Astrophysical Observation", "SAO 211251"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.38384956),
        dec: Angle.Degrees(-30.29566779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184932"},
        {"Hipparcos Number", "HIP 96562"},
        {"Geneva Identification System", "GEN# +1.00184932"},
        {"Smithsonian Astrophysical Observation", "SAO 211427"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.46562412),
        dec: Angle.Degrees(-30.29530807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77828"},
        {"Hipparcos Number", "HIP 44486"},
        {"Smithsonian Astrophysical Observation", "SAO 199937"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.96128717),
        dec: Angle.Degrees(-30.29460025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315957"},
        {"Hipparcos Number", "HIP 85775"},
        {"Geneva Identification System", "GEN# +1.00315957J"},
        {"Smithsonian Astrophysical Observation", "SAO 208918"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.89917539),
        dec: Angle.Degrees(-30.29280923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187844"},
        {"Hipparcos Number", "HIP 97853"},
        {"Smithsonian Astrophysical Observation", "SAO 211629"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.28697028),
        dec: Angle.Degrees(-30.29271372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106437"},
        {"Hipparcos Number", "HIP 59706"},
        {"Smithsonian Astrophysical Observation", "SAO 203268"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.66901094),
        dec: Angle.Degrees(-30.28932666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11508"},
        {"Hipparcos Number", "HIP 8746"},
        {"Geneva Identification System", "GEN# +1.00011508"},
        {"Smithsonian Astrophysical Observation", "SAO 193352"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.13756807),
        dec: Angle.Degrees(-30.28832004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162271"},
        {"Hipparcos Number", "HIP 87391"},
        {"Geneva Identification System", "GEN# +1.00162271"},
        {"Smithsonian Astrophysical Observation", "SAO 209367"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.89062019),
        dec: Angle.Degrees(-30.28709374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31506"},
        {"Hipparcos Number", "HIP 22865"},
        {"Smithsonian Astrophysical Observation", "SAO 195399"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.78446003),
        dec: Angle.Degrees(-30.28617153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217914"},
        {"Hipparcos Number", "HIP 113935"},
        {"Smithsonian Astrophysical Observation", "SAO 214288"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.08496750),
        dec: Angle.Degrees(-30.28609753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126415"},
        {"Hipparcos Number", "HIP 70561"},
        {"Geneva Identification System", "GEN# +1.00126415"},
        {"Smithsonian Astrophysical Observation", "SAO 205549"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.50076708),
        dec: Angle.Degrees(-30.28608230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102438"},
        {"Hipparcos Number", "HIP 57507"},
        {"Geneva Identification System", "GEN# +1.00102438"},
        {"Smithsonian Astrophysical Observation", "SAO 202811"},
        {"Wilson Evans Batten Catalogue", "WEB 10328"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.81661416),
        dec: Angle.Degrees(-30.28595727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -265.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41352"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.54982860),
        dec: Angle.Degrees(-30.28566203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179749"},
        {"Hipparcos Number", "HIP 94583"},
        {"Smithsonian Astrophysical Observation", "SAO 211088"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.73169165),
        dec: Angle.Degrees(-30.28538743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65183"},
        {"Hipparcos Number", "HIP 38792"},
        {"Geneva Identification System", "GEN# +1.00065183"},
        {"Smithsonian Astrophysical Observation", "SAO 198609"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.09468059),
        dec: Angle.Degrees(-30.28453466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105026"},
        {"Geneva Identification System", "GEN# -0.03018489"},
    },
    visualMagnitude: 11.72,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.09456287),
        dec: Angle.Degrees(-30.28416771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121054"},
        {"Hipparcos Number", "HIP 67846"},
        {"Smithsonian Astrophysical Observation", "SAO 204964"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.45909957),
        dec: Angle.Degrees(-30.28351541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9377"},
        {"Hipparcos Number", "HIP 7118"},
        {"Geneva Identification System", "GEN# +1.00009377"},
        {"Smithsonian Astrophysical Observation", "SAO 193163"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.93021487),
        dec: Angle.Degrees(-30.28292502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160334"},
        {"Hipparcos Number", "HIP 86504"},
        {"Smithsonian Astrophysical Observation", "SAO 209124"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.16814535),
        dec: Angle.Degrees(-30.28258541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26520"},
        {"Hipparcos Number", "HIP 19486"},
        {"Renson", "Renson 6750"},
        {"Smithsonian Astrophysical Observation", "SAO 194808"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.60392696),
        dec: Angle.Degrees(-30.28228162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215062"},
        {"Hipparcos Number", "HIP 112154"},
        {"Smithsonian Astrophysical Observation", "SAO 214038"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.74472647),
        dec: Angle.Degrees(-30.28216532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131866"},
        {"Hipparcos Number", "HIP 73142"},
        {"Smithsonian Astrophysical Observation", "SAO 206119"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.21630035),
        dec: Angle.Degrees(-30.28173268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55567"},
        {"Hipparcos Number", "HIP 34791"},
        {"Fundamental Katalog 5th Edition", "FK5 4651"},
        {"Smithsonian Astrophysical Observation", "SAO 197687"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.04204561),
        dec: Angle.Degrees(-30.28172763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185163"},
        {"Hipparcos Number", "HIP 96638"},
        {"Smithsonian Astrophysical Observation", "SAO 211438"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.71733029),
        dec: Angle.Degrees(-30.28107848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20002"},
        {"Hipparcos Number", "HIP 14855"},
        {"Smithsonian Astrophysical Observation", "SAO 194145"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.96640563),
        dec: Angle.Degrees(-30.27673486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58867"},
        {"Hipparcos Number", "HIP 36092"},
        {"Smithsonian Astrophysical Observation", "SAO 197991"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.53864027),
        dec: Angle.Degrees(-30.27583991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8832"},
        {"Hipparcos Number", "HIP 6721"},
        {"Smithsonian Astrophysical Observation", "SAO 193116"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.62053391),
        dec: Angle.Degrees(-30.27560414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187173"},
        {"Hipparcos Number", "HIP 97554"},
        {"Fundamental Katalog 5th Edition", "FK5 5751"},
        {"Geneva Identification System", "GEN# +1.00187173"},
        {"Smithsonian Astrophysical Observation", "SAO 211585"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.42552269),
        dec: Angle.Degrees(-30.27418534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94329"},
    },
    visualMagnitude: 10.43,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.00199290),
        dec: Angle.Degrees(-30.27031050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28685"},
        {"Hipparcos Number", "HIP 20987"},
        {"Smithsonian Astrophysical Observation", "SAO 195070"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.51409270),
        dec: Angle.Degrees(-30.26849697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149387"},
        {"Hipparcos Number", "HIP 81236"},
        {"Geneva Identification System", "GEN# +1.00149387"},
        {"Smithsonian Astrophysical Observation", "SAO 207803"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.87178685),
        dec: Angle.Degrees(-30.26764174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68931"},
        {"Smithsonian Astrophysical Observation", "SAO 205190"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.67185837),
        dec: Angle.Degrees(-30.26679219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86752"},
        {"Hipparcos Number", "HIP 49008"},
        {"Geneva Identification System", "GEN# +1.00086752"},
        {"Smithsonian Astrophysical Observation", "SAO 200941"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.97302176),
        dec: Angle.Degrees(-30.26596710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120533"},
        {"Hipparcos Number", "HIP 67561"},
        {"Geneva Identification System", "GEN# +1.00120533"},
        {"Smithsonian Astrophysical Observation", "SAO 204899"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.66341856),
        dec: Angle.Degrees(-30.26157352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203478"},
        {"Hipparcos Number", "HIP 105598"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.83250141),
        dec: Angle.Degrees(-30.26042768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30891"},
        {"Hipparcos Number", "HIP 22472"},
        {"Smithsonian Astrophysical Observation", "SAO 195335"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.53530641),
        dec: Angle.Degrees(-30.26030563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94993"},
        {"Hipparcos Number", "HIP 53579"},
        {"Smithsonian Astrophysical Observation", "SAO 179381"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.41321093),
        dec: Angle.Degrees(-30.25991894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144846"},
        {"Hipparcos Number", "HIP 79127"},
        {"Smithsonian Astrophysical Observation", "SAO 207385"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.26750340),
        dec: Angle.Degrees(-30.25870647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23187"},
        {"Hipparcos Number", "HIP 17292"},
        {"Geneva Identification System", "GEN# +1.00023187"},
        {"Smithsonian Astrophysical Observation", "SAO 194460"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.52765212),
        dec: Angle.Degrees(-30.25827625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225282"},
        {"Hipparcos Number", "HIP 395"},
        {"Geneva Identification System", "GEN# +4.09010088"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.22216274),
        dec: Angle.Degrees(-30.25661295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208069"},
        {"Hipparcos Number", "HIP 108132"},
        {"Geneva Identification System", "GEN# +1.00208069"},
        {"Smithsonian Astrophysical Observation", "SAO 213379"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.60799381),
        dec: Angle.Degrees(-30.25653140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63637"},
        {"Hipparcos Number", "HIP 38120"},
        {"Geneva Identification System", "GEN# +1.00063637"},
        {"Smithsonian Astrophysical Observation", "SAO 198468"},
        {"Wilson Evans Batten Catalogue", "WEB 7512"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.17923051),
        dec: Angle.Degrees(-30.25513292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 186.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87498",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87498"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.16595512),
        dec: Angle.Degrees(-30.25417406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169337"},
        {"Hipparcos Number", "HIP 90300"},
        {"Smithsonian Astrophysical Observation", "SAO 210128"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.37527257),
        dec: Angle.Degrees(-30.25342607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88060"},
        {"Geneva Identification System", "GEN# +1.00163755"},
    },
    visualMagnitude: 5.00,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.77199900),
        dec: Angle.Degrees(-30.25300479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73217"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.45577860),
        dec: Angle.Degrees(-30.25298462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51317",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 28"},
        {"Hipparcos Number", "HIP 51317"},
        {"Cincinnati Publication", "Ci 20 580"},
        {"Geneva Identification System", "GEN# +0.00102447"},
        {"Wilson Evans Batten Catalogue", "WEB 9373"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.23292924),
        dec: Angle.Degrees(+00.84277841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -602.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -731.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97923"},
        {"Smithsonian Astrophysical Observation", "SAO 211637"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.50790825),
        dec: Angle.Degrees(-30.25288859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215334"},
        {"Hipparcos Number", "HIP 112298"},
        {"Smithsonian Astrophysical Observation", "SAO 214054"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.19097318),
        dec: Angle.Degrees(-30.25041884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87302"},
        {"Hipparcos Number", "HIP 49275"},
        {"Smithsonian Astrophysical Observation", "SAO 201006"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.87541723),
        dec: Angle.Degrees(-30.24991651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5793"},
    },
    visualMagnitude: 11.77,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.58644113),
        dec: Angle.Degrees(-30.24940451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110529"},
        {"Hipparcos Number", "HIP 62051"},
        {"Smithsonian Astrophysical Observation", "SAO 181042"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.77196954),
        dec: Angle.Degrees(-30.24877174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141326"},
        {"Hipparcos Number", "HIP 77513"},
        {"Smithsonian Astrophysical Observation", "SAO 207018"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.40080401),
        dec: Angle.Degrees(-30.24694853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36349"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.21441365),
        dec: Angle.Degrees(-30.24649813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110542"},
        {"Hipparcos Number", "HIP 62061"},
        {"Renson", "Renson 32130"},
        {"Smithsonian Astrophysical Observation", "SAO 181045"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.80248452),
        dec: Angle.Degrees(-30.24638732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73533"},
    },
    visualMagnitude: 12.39,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)15, (int)01, 46.2300),
        dec: Angle.DegreesMinutesSeconds((int)-30, (int)14, 40.300)
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
    primaryId: "HIP 49401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87558"},
        {"Hipparcos Number", "HIP 49401"},
        {"Smithsonian Astrophysical Observation", "SAO 178383"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.27852353),
        dec: Angle.Degrees(-30.24165115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197947"},
        {"Hipparcos Number", "HIP 102643"},
        {"Geneva Identification System", "GEN# +1.00197947"},
        {"Smithsonian Astrophysical Observation", "SAO 212444"},
        {"Wilson Evans Batten Catalogue", "WEB 18603"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.98189583),
        dec: Angle.Degrees(-30.24137616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317466"},
        {"Hipparcos Number", "HIP 90011"},
        {"Smithsonian Astrophysical Observation", "SAO 210045"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.50011773),
        dec: Angle.Degrees(-30.24129270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74632"},
        {"Hipparcos Number", "HIP 42860"},
        {"Geneva Identification System", "GEN# +1.00074632"},
        {"Smithsonian Astrophysical Observation", "SAO 199557"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.01034811),
        dec: Angle.Degrees(-30.23982188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66119",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66119"},
    },
    visualMagnitude: 12.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.30817174),
        dec: Angle.Degrees(-30.23587860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8887"},
        {"Hipparcos Number", "HIP 6771"},
        {"Smithsonian Astrophysical Observation", "SAO 193123"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.77026692),
        dec: Angle.Degrees(-30.23582084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62750"},
        {"Hipparcos Number", "HIP 37736"},
        {"Smithsonian Astrophysical Observation", "SAO 198367"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.08864430),
        dec: Angle.Degrees(-30.23491388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105508"},
        {"Hipparcos Number", "HIP 59225"},
        {"Smithsonian Astrophysical Observation", "SAO 180513"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.20521777),
        dec: Angle.Degrees(-30.23454447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32369"},
        {"Hipparcos Number", "HIP 23368"},
        {"Smithsonian Astrophysical Observation", "SAO 195494"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.36710882),
        dec: Angle.Degrees(-30.23422611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218369"},
        {"Hipparcos Number", "HIP 114206"},
        {"Smithsonian Astrophysical Observation", "SAO 214330"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.92813690),
        dec: Angle.Degrees(-30.23326294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68238"},
        {"Hipparcos Number", "HIP 40018"},
        {"Smithsonian Astrophysical Observation", "SAO 198877"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.59803863),
        dec: Angle.Degrees(-30.23324754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69139"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.29181155),
        dec: Angle.Degrees(-30.23252008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186370"},
        {"Hipparcos Number", "HIP 97180"},
        {"Smithsonian Astrophysical Observation", "SAO 211534"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.27555916),
        dec: Angle.Degrees(-30.23064984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197268"},
        {"Hipparcos Number", "HIP 102294"},
        {"Smithsonian Astrophysical Observation", "SAO 212387"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.90478498),
        dec: Angle.Degrees(-30.22902241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20775"},
        {"Hipparcos Number", "HIP 15511"},
        {"Smithsonian Astrophysical Observation", "SAO 194234"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.97487872),
        dec: Angle.Degrees(-30.22595623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33807"},
        {"Hipparcos Number", "HIP 24178"},
        {"Fundamental Katalog 5th Edition", "FK5 2392"},
        {"Geneva Identification System", "GEN# +1.00033807"},
        {"Smithsonian Astrophysical Observation", "SAO 195631"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.87521797),
        dec: Angle.Degrees(-30.22552671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216392"},
        {"Hipparcos Number", "HIP 112989"},
        {"Smithsonian Astrophysical Observation", "SAO 214159"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.23527821),
        dec: Angle.Degrees(-30.22371837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25883"},
        {"Hipparcos Number", "HIP 19047"},
        {"Geneva Identification System", "GEN# +1.00025883"},
        {"Smithsonian Astrophysical Observation", "SAO 194739"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.21817768),
        dec: Angle.Degrees(-30.22203255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174150"},
        {"Hipparcos Number", "HIP 92448"},
        {"Smithsonian Astrophysical Observation", "SAO 210621"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.59694791),
        dec: Angle.Degrees(-30.22043696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75440"},
        {"Hipparcos Number", "HIP 43287"},
        {"Smithsonian Astrophysical Observation", "SAO 199657"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.26564386),
        dec: Angle.Degrees(-30.21967197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99438"},
    },
    visualMagnitude: 12.18,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.73782769),
        dec: Angle.Degrees(-30.21790202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -345.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71464"},
    },
    visualMagnitude: 12.17,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.22831719),
        dec: Angle.Degrees(-30.21779815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58325"},
        {"Hipparcos Number", "HIP 35887"},
        {"Celescope Catalog", "CEL 1825"},
        {"Geneva Identification System", "GEN# +5.11210045"},
        {"Smithsonian Astrophysical Observation", "SAO 197944"},
        {"Wilson Evans Batten Catalogue", "WEB 7147"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.97682120),
        dec: Angle.Degrees(-30.21702088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153002"},
        {"Hipparcos Number", "HIP 83038"},
        {"Smithsonian Astrophysical Observation", "SAO 208244"},
    },
    visualMagnitude: 8.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.52896034),
        dec: Angle.Degrees(-30.21614635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316895"},
        {"Hipparcos Number", "HIP 88198"},
        {"Smithsonian Astrophysical Observation", "SAO 209589"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.17146514),
        dec: Angle.Degrees(-30.21477975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111117"},
        {"Hipparcos Number", "HIP 62407"},
        {"Smithsonian Astrophysical Observation", "SAO 181099"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.83715545),
        dec: Angle.Degrees(-30.21254937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145779"},
        {"Hipparcos Number", "HIP 79541"},
        {"Fundamental Katalog 5th Edition", "FK5 5429"},
        {"Geneva Identification System", "GEN# +1.00145779"},
        {"Smithsonian Astrophysical Observation", "SAO 207476"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.46250219),
        dec: Angle.Degrees(-30.21209345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68570"},
        {"Hipparcos Number", "HIP 40148"},
        {"Smithsonian Astrophysical Observation", "SAO 198916"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.97842032),
        dec: Angle.Degrees(-30.21190202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83379"},
        {"Hipparcos Number", "HIP 47208"},
        {"Smithsonian Astrophysical Observation", "SAO 177754"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.30905578),
        dec: Angle.Degrees(-30.21102616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155940"},
        {"Hipparcos Number", "HIP 84445"},
        {"Geneva Identification System", "GEN# +1.00155940"},
        {"Smithsonian Astrophysical Observation", "SAO 208606"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.96400223),
        dec: Angle.Degrees(-30.21062099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214463"},
        {"Hipparcos Number", "HIP 111806"},
        {"Smithsonian Astrophysical Observation", "SAO 213980"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.69958201),
        dec: Angle.Degrees(-30.20995019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193070"},
        {"Hipparcos Number", "HIP 100186"},
        {"Smithsonian Astrophysical Observation", "SAO 212000"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.82969792),
        dec: Angle.Degrees(-30.20948524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27767"},
        {"Hipparcos Number", "HIP 20368"},
        {"Smithsonian Astrophysical Observation", "SAO 194954"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.42686921),
        dec: Angle.Degrees(-30.20863178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129454"},
        {"Hipparcos Number", "HIP 71999"},
        {"Geneva Identification System", "GEN# +1.00129454"},
        {"Smithsonian Astrophysical Observation", "SAO 182799"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.86475102),
        dec: Angle.Degrees(-30.20807867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91753",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91753"},
        {"Smithsonian Astrophysical Observation", "SAO 210487"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.65524436),
        dec: Angle.Degrees(-30.20650531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157075"},
        {"Hipparcos Number", "HIP 84999"},
        {"Geneva Identification System", "GEN# +1.00157075"},
        {"Smithsonian Astrophysical Observation", "SAO 208738"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.60221835),
        dec: Angle.Degrees(-30.20393634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84567"},
        {"Hipparcos Number", "HIP 47868"},
        {"Geneva Identification System", "GEN# +1.00084567"},
        {"Smithsonian Astrophysical Observation", "SAO 177939"},
        {"Wilson Evans Batten Catalogue", "WEB 8956"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.34172832),
        dec: Angle.Degrees(-30.20276206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188640"},
        {"Hipparcos Number", "HIP 98195"},
        {"Geneva Identification System", "GEN# +1.00188640"},
        {"Smithsonian Astrophysical Observation", "SAO 211684"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.30898706),
        dec: Angle.Degrees(-30.19983955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113596"},
        {"Hipparcos Number", "HIP 63846"},
        {"Smithsonian Astrophysical Observation", "SAO 181374"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.27180514),
        dec: Angle.Degrees(-30.19717788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148915"},
        {"Hipparcos Number", "HIP 81009"},
        {"Fundamental Katalog 5th Edition", "FK5 5464"},
        {"Geneva Identification System", "GEN# +1.00148915"},
        {"Smithsonian Astrophysical Observation", "SAO 207753"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.15207195),
        dec: Angle.Degrees(-30.19539460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16538"},
        {"Hipparcos Number", "HIP 12288"},
        {"Fundamental Katalog 5th Edition", "FK5 2183"},
        {"Geneva Identification System", "GEN# +1.00016538"},
        {"Smithsonian Astrophysical Observation", "SAO 193829"},
        {"Wilson Evans Batten Catalogue", "WEB 2520"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.57748196),
        dec: Angle.Degrees(-30.19388274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10932"},
        {"Hipparcos Number", "HIP 8289"},
        {"Smithsonian Astrophysical Observation", "SAO 193297"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.69857312),
        dec: Angle.Degrees(-30.19379019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198142"},
        {"Hipparcos Number", "HIP 102769"},
        {"Geneva Identification System", "GEN# +1.00198142"},
        {"Smithsonian Astrophysical Observation", "SAO 212463"},
        {"Wilson Evans Batten Catalogue", "WEB 18634"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.32057891),
        dec: Angle.Degrees(-30.19207457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124431"},
        {"Hipparcos Number", "HIP 69560"},
        {"Smithsonian Astrophysical Observation", "SAO 182360"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.58377631),
        dec: Angle.Degrees(-30.19147156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4471"},
        {"Hipparcos Number", "HIP 3637"},
        {"Geneva Identification System", "GEN# +1.00004471"},
        {"Smithsonian Astrophysical Observation", "SAO 192731"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.65537200),
        dec: Angle.Degrees(-30.19092869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105112"},
        {"Hipparcos Number", "HIP 59029"},
        {"Geneva Identification System", "GEN# +1.00105112"},
        {"Smithsonian Astrophysical Observation", "SAO 180458"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.53593132),
        dec: Angle.Degrees(-30.19038894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21021"},
        {"Hipparcos Number", "HIP 15725"},
        {"Geneva Identification System", "GEN# +1.00021021"},
        {"Smithsonian Astrophysical Observation", "SAO 194264"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.64719213),
        dec: Angle.Degrees(-30.18914490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 235.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62315"},
        {"Hipparcos Number", "HIP 37524"},
        {"Fundamental Katalog 5th Edition", "FK5 4695"},
        {"Geneva Identification System", "GEN# +1.00062315"},
        {"Smithsonian Astrophysical Observation", "SAO 198312"},
        {"Wilson Evans Batten Catalogue", "WEB 7424"},
    },
    visualMagnitude: 6.95,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.52778322),
        dec: Angle.Degrees(-30.18632425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69444"},
        {"Hipparcos Number", "HIP 40486"},
        {"Fundamental Katalog 5th Edition", "FK5 4743"},
        {"Geneva Identification System", "GEN# +1.00069444"},
        {"Smithsonian Astrophysical Observation", "SAO 199014"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.99601767),
        dec: Angle.Degrees(-30.18454344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43918"},
        {"Smithsonian Astrophysical Observation", "SAO 176737"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.20102568),
        dec: Angle.Degrees(-30.18386432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7953"},
        {"Hipparcos Number", "HIP 6119"},
        {"Geneva Identification System", "GEN# +1.00007953"},
        {"Smithsonian Astrophysical Observation", "SAO 193041"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.63838197),
        dec: Angle.Degrees(-30.18332605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161137"},
        {"Hipparcos Number", "HIP 86883"},
        {"Smithsonian Astrophysical Observation", "SAO 209217"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.27886578),
        dec: Angle.Degrees(-30.18314887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22620"},
        {"Hipparcos Number", "HIP 16889"},
        {"Smithsonian Astrophysical Observation", "SAO 194405"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.33264923),
        dec: Angle.Degrees(-30.18311623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94282"},
        {"Hipparcos Number", "HIP 53153"},
        {"Smithsonian Astrophysical Observation", "SAO 179294"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.12524662),
        dec: Angle.Degrees(-30.18279194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119307"},
        {"Hipparcos Number", "HIP 66932"},
        {"Renson", "Renson 34450"},
        {"Smithsonian Astrophysical Observation", "SAO 181891"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.75372321),
        dec: Angle.Degrees(-30.18268167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95835"},
        {"Hipparcos Number", "HIP 54022"},
        {"Smithsonian Astrophysical Observation", "SAO 179471"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.78435625),
        dec: Angle.Degrees(-30.18218923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115066"},
        {"Hipparcos Number", "HIP 64647"},
        {"Smithsonian Astrophysical Observation", "SAO 181483"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.76810886),
        dec: Angle.Degrees(-30.18137783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147579"},
        {"Hipparcos Number", "HIP 80316"},
        {"Smithsonian Astrophysical Observation", "SAO 207623"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.96385808),
        dec: Angle.Degrees(-30.18135396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25899"},
        {"Hipparcos Number", "HIP 19058"},
        {"Smithsonian Astrophysical Observation", "SAO 194742"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.25008658),
        dec: Angle.Degrees(-30.17943468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199272"},
        {"Hipparcos Number", "HIP 103411"},
        {"Smithsonian Astrophysical Observation", "SAO 212573"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.27618176),
        dec: Angle.Degrees(-30.17848656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55052",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55052"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.02915001),
        dec: Angle.Degrees(-30.17838603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -306.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5228"},
        {"Hipparcos Number", "HIP 4217"},
        {"Geneva Identification System", "GEN# +1.00005228"},
        {"Smithsonian Astrophysical Observation", "SAO 192801"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.45279884),
        dec: Angle.Degrees(-30.17805750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160852"},
        {"Hipparcos Number", "HIP 86744"},
        {"Geneva Identification System", "GEN# +1.00160852"},
        {"Smithsonian Astrophysical Observation", "SAO 209187"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.87539266),
        dec: Angle.Degrees(-30.17692366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9786",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9786"},
    },
    visualMagnitude: 12.15,
    bvColour: 1.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.45378802),
        dec: Angle.Degrees(-30.17689282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -527.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128358"},
        {"Hipparcos Number", "HIP 71495"},
        {"Smithsonian Astrophysical Observation", "SAO 182709"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.30369721),
        dec: Angle.Degrees(-30.17657193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96700"},
        {"Hipparcos Number", "HIP 54400"},
        {"Cincinnati Publication", "Ci 20 609"},
        {"Geneva Identification System", "GEN# +1.00096700"},
        {"Smithsonian Astrophysical Observation", "SAO 179558"},
        {"Wilson Evans Batten Catalogue", "WEB 9824"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.97819949),
        dec: Angle.Degrees(-30.17424695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -505.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -131.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18743"},
        {"Hipparcos Number", "HIP 13960"},
        {"Geneva Identification System", "GEN# +1.00018743"},
        {"Smithsonian Astrophysical Observation", "SAO 194024"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.94856630),
        dec: Angle.Degrees(-30.17253476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48903"},
        {"Hipparcos Number", "HIP 32281"},
        {"Geneva Identification System", "GEN# +1.00048903"},
        {"Smithsonian Astrophysical Observation", "SAO 197147"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.09081570),
        dec: Angle.Degrees(-30.17180761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73232"},
        {"Smithsonian Astrophysical Observation", "SAO 183051"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.50928953),
        dec: Angle.Degrees(-30.17072115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316899"},
        {"Hipparcos Number", "HIP 88033"},
        {"Geneva Identification System", "GEN# +1.00316899"},
        {"Smithsonian Astrophysical Observation", "SAO 209548"},
        {"Wilson Evans Batten Catalogue", "WEB 14871"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.72152123),
        dec: Angle.Degrees(-30.17037738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 173.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -657.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43430"},
        {"Hipparcos Number", "HIP 29642"},
        {"Smithsonian Astrophysical Observation", "SAO 196620"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.70135500),
        dec: Angle.Degrees(-30.17019559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14566"},
        {"Hipparcos Number", "HIP 10913"},
        {"Smithsonian Astrophysical Observation", "SAO 193649"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.12222564),
        dec: Angle.Degrees(-30.17018387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82549"},
        {"Smithsonian Astrophysical Observation", "SAO 208124"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.09071952),
        dec: Angle.Degrees(-30.16979922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117728"},
        {"Renson", "Renson 61340"},
    },
    visualMagnitude: 12.09,
    bvColour: -0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.15030016),
        dec: Angle.Degrees(-30.16916756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1125"},
        {"Hipparcos Number", "HIP 1238"},
        {"Geneva Identification System", "GEN# +1.00001125"},
        {"Smithsonian Astrophysical Observation", "SAO 192425"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.85777964),
        dec: Angle.Degrees(-30.16913379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61850"},
        {"Hipparcos Number", "HIP 37357"},
        {"Geneva Identification System", "GEN# +1.00061850"},
        {"Smithsonian Astrophysical Observation", "SAO 198271"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.01830336),
        dec: Angle.Degrees(-30.16907548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96690"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.85782408),
        dec: Angle.Degrees(-30.16857819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23940"},
        {"Hipparcos Number", "HIP 17738"},
        {"Fundamental Katalog 5th Edition", "FK5 2272"},
        {"Geneva Identification System", "GEN# +1.00023940"},
        {"Smithsonian Astrophysical Observation", "SAO 194535"},
        {"Wilson Evans Batten Catalogue", "WEB 3393"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.98342907),
        dec: Angle.Degrees(-30.16732063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12430"},
        {"Hipparcos Number", "HIP 9433"},
        {"Smithsonian Astrophysical Observation", "SAO 193454"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.29034197),
        dec: Angle.Degrees(-30.16722102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190104"},
        {"Hipparcos Number", "HIP 98847"},
        {"Smithsonian Astrophysical Observation", "SAO 211784"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.10136747),
        dec: Angle.Degrees(-30.16604859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156184"},
        {"Hipparcos Number", "HIP 84576"},
        {"Geneva Identification System", "GEN# +1.00156184J"},
        {"Smithsonian Astrophysical Observation", "SAO 208636"},
        {"Wilson Evans Batten Catalogue", "WEB 14279"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.33566014),
        dec: Angle.Degrees(-30.16443100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90071"},
        {"Hipparcos Number", "HIP 50868"},
        {"Geneva Identification System", "GEN# +1.00090071"},
        {"Smithsonian Astrophysical Observation", "SAO 178759"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.80474516),
        dec: Angle.Degrees(-30.16223451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97720"},
        {"Hipparcos Number", "HIP 54890"},
        {"Smithsonian Astrophysical Observation", "SAO 179673"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.58517558),
        dec: Angle.Degrees(-30.16205698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9402"},
        {"Hipparcos Number", "HIP 7130"},
        {"Smithsonian Astrophysical Observation", "SAO 193164"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.97052729),
        dec: Angle.Degrees(-30.16079088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117191"},
        {"Hipparcos Number", "HIP 65788"},
        {"Smithsonian Astrophysical Observation", "SAO 181687"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.30033081),
        dec: Angle.Degrees(-30.16040841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9074 AB"},
        {"Henry Draper", "HD 121895"},
        {"Hipparcos Number", "HIP 68310"},
        {"Smithsonian Astrophysical Observation", "SAO 182139"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.75120850),
        dec: Angle.Degrees(-30.15976884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37335"},
        {"Hipparcos Number", "HIP 26339"},
        {"Smithsonian Astrophysical Observation", "SAO 196006"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.13715066),
        dec: Angle.Degrees(-30.15882386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20070"},
        {"Hipparcos Number", "HIP 14939"},
        {"Smithsonian Astrophysical Observation", "SAO 194154"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.15164029),
        dec: Angle.Degrees(-30.15548780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211366"},
        {"Hipparcos Number", "HIP 110028"},
        {"Geneva Identification System", "GEN# +1.00211366"},
        {"Smithsonian Astrophysical Observation", "SAO 213697"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.28500116),
        dec: Angle.Degrees(-30.15334602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 167.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145557"},
        {"Hipparcos Number", "HIP 79430"},
        {"Geneva Identification System", "GEN# +1.00145557"},
        {"Smithsonian Astrophysical Observation", "SAO 207451"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.16563387),
        dec: Angle.Degrees(-30.15196394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 316600"},
        {"Hipparcos Number", "HIP 87456"},
        {"Smithsonian Astrophysical Observation", "SAO 209388"},
    },
    visualMagnitude: 8.71,
    bvColour: 2.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.04875044),
        dec: Angle.Degrees(-30.15165665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225047"},
        {"Hipparcos Number", "HIP 232"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.73006132),
        dec: Angle.Degrees(-30.14977973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203226"},
        {"Hipparcos Number", "HIP 105464"},
        {"Smithsonian Astrophysical Observation", "SAO 212943"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.43281047),
        dec: Angle.Degrees(-30.14867609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135758"},
        {"Hipparcos Number", "HIP 74857"},
        {"Fundamental Katalog 5th Edition", "FK5 3207"},
        {"Geneva Identification System", "GEN# +1.00135758"},
        {"Smithsonian Astrophysical Observation", "SAO 183346"},
        {"Wilson Evans Batten Catalogue", "WEB 12767"},
    },
    visualMagnitude: 4.35,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.45768699),
        dec: Angle.Degrees(-30.14866233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82275"},
        {"Hipparcos Number", "HIP 46601"},
        {"Smithsonian Astrophysical Observation", "SAO 177562"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.54098886),
        dec: Angle.Degrees(-30.14428272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117894"},
    },
    visualMagnitude: 11.84,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.70562807),
        dec: Angle.Degrees(-30.14364304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -263.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199017"},
        {"Hipparcos Number", "HIP 103264"},
        {"Geneva Identification System", "GEN# +1.00199017"},
        {"Smithsonian Astrophysical Observation", "SAO 212541"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.80699506),
        dec: Angle.Degrees(-30.14024378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101492"},
        {"Hipparcos Number", "HIP 56965"},
        {"Smithsonian Astrophysical Observation", "SAO 180088"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.16206936),
        dec: Angle.Degrees(-30.13833432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143811"},
        {"Hipparcos Number", "HIP 78663"},
        {"Smithsonian Astrophysical Observation", "SAO 184070"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.88931324),
        dec: Angle.Degrees(-30.13698828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210270"},
        {"Hipparcos Number", "HIP 109401"},
        {"Smithsonian Astrophysical Observation", "SAO 213598"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.46316050),
        dec: Angle.Degrees(-30.13637909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16784"},
        {"Hipparcos Number", "HIP 12483"},
        {"Cincinnati Publication", "Ci 20 178"},
        {"Cincinnati Publication 2", "Ci 18 345"},
        {"Geneva Identification System", "GEN# +1.00016784"},
        {"Smithsonian Astrophysical Observation", "SAO 193849"},
        {"Wilson Evans Batten Catalogue", "WEB 2550"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.15997632),
        dec: Angle.Degrees(-30.13558852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 569.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225187"},
        {"Hipparcos Number", "HIP 328"},
        {"Geneva Identification System", "GEN# +4.09010071"},
        {"Smithsonian Astrophysical Observation", "SAO 192345"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.04953066),
        dec: Angle.Degrees(-30.13491782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218541"},
        {"Hipparcos Number", "HIP 114318"},
        {"Smithsonian Astrophysical Observation", "SAO 214344"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.27317937),
        dec: Angle.Degrees(-30.13391512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56553"},
        {"Hipparcos Number", "HIP 35171"},
        {"Smithsonian Astrophysical Observation", "SAO 197771"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.03530765),
        dec: Angle.Degrees(-30.13268305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159979"},
        {"Hipparcos Number", "HIP 86360"},
        {"Geneva Identification System", "GEN# +1.00159979"},
        {"Smithsonian Astrophysical Observation", "SAO 209068"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.69765544),
        dec: Angle.Degrees(-30.13133620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213253"},
        {"Hipparcos Number", "HIP 111118"},
        {"Smithsonian Astrophysical Observation", "SAO 213873"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.65349581),
        dec: Angle.Degrees(-30.13105424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80033"},
        {"Hipparcos Number", "HIP 45514"},
        {"Geneva Identification System", "GEN# +1.00080033"},
        {"Smithsonian Astrophysical Observation", "SAO 177199"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.13109046),
        dec: Angle.Degrees(-30.13090727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15379",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15379"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.58259098),
        dec: Angle.Degrees(-30.13070685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32155"},
        {"Smithsonian Astrophysical Observation", "SAO 197122"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.72274506),
        dec: Angle.Degrees(-30.12767053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185708"},
        {"Hipparcos Number", "HIP 96877"},
        {"Geneva Identification System", "GEN# +1.00185708"},
        {"Smithsonian Astrophysical Observation", "SAO 211480"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.39554156),
        dec: Angle.Degrees(-30.12766225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200718"},
        {"Hipparcos Number", "HIP 104148"},
        {"Fundamental Katalog 5th Edition", "FK5 3683"},
        {"Geneva Identification System", "GEN# +1.00200718"},
        {"Smithsonian Astrophysical Observation", "SAO 212709"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.50468134),
        dec: Angle.Degrees(-30.12495361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169734"},
        {"Hipparcos Number", "HIP 90450"},
        {"Smithsonian Astrophysical Observation", "SAO 210174"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.84080620),
        dec: Angle.Degrees(-30.12426838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86247"},
        {"Hipparcos Number", "HIP 48749"},
        {"Smithsonian Astrophysical Observation", "SAO 178211"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.15053973),
        dec: Angle.Degrees(-30.12314454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152347"},
        {"Hipparcos Number", "HIP 82682"},
        {"Smithsonian Astrophysical Observation", "SAO 208160"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.51744357),
        dec: Angle.Degrees(-30.12303426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207449"},
        {"Hipparcos Number", "HIP 107756"},
        {"Smithsonian Astrophysical Observation", "SAO 213324"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.43849418),
        dec: Angle.Degrees(-30.12241466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168399"},
        {"Hipparcos Number", "HIP 89904"},
        {"Smithsonian Astrophysical Observation", "SAO 210016"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.17736319),
        dec: Angle.Degrees(-30.12233325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153101"},
        {"Hipparcos Number", "HIP 83080"},
        {"Smithsonian Astrophysical Observation", "SAO 208257"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.64929794),
        dec: Angle.Degrees(-30.12062774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87745"},
        {"Hipparcos Number", "HIP 49502"},
        {"Smithsonian Astrophysical Observation", "SAO 178419"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.61195190),
        dec: Angle.Degrees(-30.12024944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73562"},
        {"Smithsonian Astrophysical Observation", "SAO 183097"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.50718381),
        dec: Angle.Degrees(-30.12019664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204529"},
        {"Hipparcos Number", "HIP 106149"},
        {"Smithsonian Astrophysical Observation", "SAO 213046"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.51842458),
        dec: Angle.Degrees(-30.11984773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174360"},
        {"Hipparcos Number", "HIP 92527"},
        {"Geneva Identification System", "GEN# +1.00174360"},
        {"Smithsonian Astrophysical Observation", "SAO 210640"},
        {"Wilson Evans Batten Catalogue", "WEB 16002"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.84773138),
        dec: Angle.Degrees(-30.11818430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36255"},
        {"Hipparcos Number", "HIP 25685"},
        {"Geneva Identification System", "GEN# +1.00036255"},
        {"Smithsonian Astrophysical Observation", "SAO 195898"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.27788536),
        dec: Angle.Degrees(-30.11674785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149664"},
        {"Hipparcos Number", "HIP 81392"},
        {"Smithsonian Astrophysical Observation", "SAO 207848"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.34032694),
        dec: Angle.Degrees(-30.11442654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26920"},
        {"Hipparcos Number", "HIP 19751"},
        {"Fundamental Katalog 5th Edition", "FK5 2308"},
        {"Smithsonian Astrophysical Observation", "SAO 194849"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.51398522),
        dec: Angle.Degrees(-30.11275667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4209"},
        {"Hipparcos Number", "HIP 3468"},
        {"Geneva Identification System", "GEN# +1.00004209"},
        {"Smithsonian Astrophysical Observation", "SAO 192705"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.08797982),
        dec: Angle.Degrees(-30.11139934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28937"},
        {"Hipparcos Number", "HIP 21170"},
        {"Smithsonian Astrophysical Observation", "SAO 195111"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.07856086),
        dec: Angle.Degrees(-30.10748028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136123"},
        {"Hipparcos Number", "HIP 75035"},
        {"Smithsonian Astrophysical Observation", "SAO 183379"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.98564887),
        dec: Angle.Degrees(-30.10684430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45414"},
        {"Smithsonian Astrophysical Observation", "SAO 177171"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.81394011),
        dec: Angle.Degrees(-30.10605168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 195.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221207"},
        {"Hipparcos Number", "HIP 116002"},
        {"Fundamental Katalog 5th Edition", "FK5 6078"},
        {"Geneva Identification System", "GEN# +1.00221207"},
        {"Smithsonian Astrophysical Observation", "SAO 214586"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.55415197),
        dec: Angle.Degrees(-30.10416011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75547"},
        {"Smithsonian Astrophysical Observation", "SAO 183459"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.775,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.50935565),
        dec: Angle.Degrees(-30.10408376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198297"},
        {"Hipparcos Number", "HIP 102861"},
        {"Smithsonian Astrophysical Observation", "SAO 212481"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.58022071),
        dec: Angle.Degrees(-30.10287044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147148"},
        {"Hipparcos Number", "HIP 80119"},
        {"Geneva Identification System", "GEN# +1.00147148"},
        {"Smithsonian Astrophysical Observation", "SAO 184335"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.31617211),
        dec: Angle.Degrees(-30.10118052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4585"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.68260539),
        dec: Angle.Degrees(-30.09942149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127233"},
        {"Hipparcos Number", "HIP 70969"},
        {"Geneva Identification System", "GEN# +1.00127233"},
        {"Smithsonian Astrophysical Observation", "SAO 182618"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.74434689),
        dec: Angle.Degrees(-30.09767894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23939"},
        {"Hipparcos Number", "HIP 17739"},
        {"Geneva Identification System", "GEN# +1.00023939"},
        {"Smithsonian Astrophysical Observation", "SAO 194536"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.98418335),
        dec: Angle.Degrees(-30.09726425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39666"},
        {"Geneva Identification System", "GEN# -0.02905535"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.58948427),
        dec: Angle.Degrees(-30.09688658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173859"},
        {"Hipparcos Number", "HIP 92304"},
        {"Geneva Identification System", "GEN# +1.00173859"},
        {"Smithsonian Astrophysical Observation", "SAO 210594"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.19783829),
        dec: Angle.Degrees(-30.09644757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94375"},
        {"Hipparcos Number", "HIP 53226"},
        {"Geneva Identification System", "GEN# +1.00094375"},
        {"Smithsonian Astrophysical Observation", "SAO 179309"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.31139920),
        dec: Angle.Degrees(-30.09630705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46971"},
        {"Hipparcos Number", "HIP 31398"},
        {"Smithsonian Astrophysical Observation", "SAO 196962"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.72605820),
        dec: Angle.Degrees(-30.09203601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205136"},
        {"Hipparcos Number", "HIP 106486"},
        {"Geneva Identification System", "GEN# +1.00205136"},
        {"Smithsonian Astrophysical Observation", "SAO 213096"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.52273339),
        dec: Angle.Degrees(-30.09188679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38798",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38798"},
        {"New General Catalogue", "NGC 2489 47"},
    },
    visualMagnitude: 12.10,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.10678603),
        dec: Angle.Degrees(-30.09164921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23657"},
        {"Hipparcos Number", "HIP 17565"},
        {"Fundamental Katalog 5th Edition", "FK5 4343"},
        {"Smithsonian Astrophysical Observation", "SAO 194508"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.42925534),
        dec: Angle.Degrees(-30.09041131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17105"},
    },
    visualMagnitude: 11.76,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.96686107),
        dec: Angle.Degrees(-30.08783260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9135 A"},
        {"Henry Draper", "HD 123769"},
        {"Hipparcos Number", "HIP 69225"},
        {"Smithsonian Astrophysical Observation", "SAO 182305"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.59752704),
        dec: Angle.Degrees(-30.08768061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52445"},
        {"Hipparcos Number", "HIP 33686"},
        {"Smithsonian Astrophysical Observation", "SAO 197447"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.97820340),
        dec: Angle.Degrees(-30.08732263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222054"},
        {"Hipparcos Number", "HIP 116580"},
        {"Smithsonian Astrophysical Observation", "SAO 214665"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.37576545),
        dec: Angle.Degrees(-30.08637540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43119"},
        {"Hipparcos Number", "HIP 29527"},
        {"Smithsonian Astrophysical Observation", "SAO 196596"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.30746129),
        dec: Angle.Degrees(-30.08624247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141599"},
        {"Hipparcos Number", "HIP 77641"},
        {"Geneva Identification System", "GEN# +1.00141599"},
        {"Smithsonian Astrophysical Observation", "SAO 183855"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.77159485),
        dec: Angle.Degrees(-30.08609907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74142"},
        {"Hipparcos Number", "HIP 42626"},
        {"Smithsonian Astrophysical Observation", "SAO 176305"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.30758314),
        dec: Angle.Degrees(-30.08543835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108412"},
        {"Hipparcos Number", "HIP 60778"},
        {"Smithsonian Astrophysical Observation", "SAO 180811"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.86967011),
        dec: Angle.Degrees(-30.08515649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109534"},
        {"Hipparcos Number", "HIP 61452"},
        {"Smithsonian Astrophysical Observation", "SAO 180931"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.89642111),
        dec: Angle.Degrees(-30.08475662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57014"},
        {"Hipparcos Number", "HIP 35356"},
        {"Smithsonian Astrophysical Observation", "SAO 173429"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.54129717),
        dec: Angle.Degrees(-30.08460410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40917"},
        {"Hipparcos Number", "HIP 28463"},
        {"Geneva Identification System", "GEN# +1.00040917"},
        {"Smithsonian Astrophysical Observation", "SAO 196401"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.14842538),
        dec: Angle.Degrees(-30.08403452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78467"},
        {"Hipparcos Number", "HIP 44771"},
        {"Geneva Identification System", "GEN# +1.00078467"},
        {"Smithsonian Astrophysical Observation", "SAO 176986"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.86906772),
        dec: Angle.Degrees(-30.08295465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219971"},
        {"Hipparcos Number", "HIP 115235"},
        {"Smithsonian Astrophysical Observation", "SAO 214473"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.10551891),
        dec: Angle.Degrees(-30.07982986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61944"},
        {"Hipparcos Number", "HIP 37385"},
        {"Celescope Catalog", "CEL 1974"},
        {"Geneva Identification System", "GEN# +1.00061944"},
        {"Smithsonian Astrophysical Observation", "SAO 174266"},
        {"Wilson Evans Batten Catalogue", "WEB 7398"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.10944629),
        dec: Angle.Degrees(-30.07976226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52465"},
        {"Hipparcos Number", "HIP 33692"},
        {"Smithsonian Astrophysical Observation", "SAO 197448"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.01146314),
        dec: Angle.Degrees(-30.07824108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58200"},
        {"Hipparcos Number", "HIP 35829"},
        {"Smithsonian Astrophysical Observation", "SAO 173617"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.83043752),
        dec: Angle.Degrees(-30.07804666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49524"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.67604438),
        dec: Angle.Degrees(-30.07719986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24360"},
        {"Hipparcos Number", "HIP 18044"},
        {"Smithsonian Astrophysical Observation", "SAO 194581"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.85156937),
        dec: Angle.Degrees(-30.07599680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148501"},
        {"Hipparcos Number", "HIP 80779"},
        {"Smithsonian Astrophysical Observation", "SAO 184418"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.41244486),
        dec: Angle.Degrees(-30.07532573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19828"},
        {"Smithsonian Astrophysical Observation", "SAO 194867"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.77630946),
        dec: Angle.Degrees(-30.07486775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14657"},
        {"Smithsonian Astrophysical Observation", "SAO 194117"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.34228897),
        dec: Angle.Degrees(-30.07357665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 118.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90557"},
        {"Hipparcos Number", "HIP 51143"},
        {"Smithsonian Astrophysical Observation", "SAO 178827"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.71257056),
        dec: Angle.Degrees(-30.07292784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27016"},
        {"Hipparcos Number", "HIP 19827"},
        {"Smithsonian Astrophysical Observation", "SAO 194866"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.77528788),
        dec: Angle.Degrees(-30.07195370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35129"},
        {"Hipparcos Number", "HIP 24996"},
        {"Smithsonian Astrophysical Observation", "SAO 195769"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.29612253),
        dec: Angle.Degrees(-30.07185532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188883"},
        {"Hipparcos Number", "HIP 98307"},
        {"Geneva Identification System", "GEN# +1.00188883"},
        {"Smithsonian Astrophysical Observation", "SAO 211700"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.61792511),
        dec: Angle.Degrees(-30.07177976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67054"},
        {"Hipparcos Number", "HIP 39570"},
        {"Smithsonian Astrophysical Observation", "SAO 175138"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.27748283),
        dec: Angle.Degrees(-30.07022775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112241"},
        {"Hipparcos Number", "HIP 63083"},
        {"Fundamental Katalog 5th Edition", "FK5 3031"},
        {"Smithsonian Astrophysical Observation", "SAO 181231"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.88518821),
        dec: Angle.Degrees(-30.07008567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112553"},
        {"Smithsonian Astrophysical Observation", "SAO 214089"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.94639967),
        dec: Angle.Degrees(-30.06877022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 394"},
        {"Hipparcos Number", "HIP 686"},
        {"Geneva Identification System", "GEN# +4.09010128"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.11287951),
        dec: Angle.Degrees(-30.06855565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136084"},
        {"Hipparcos Number", "HIP 75016"},
        {"Smithsonian Astrophysical Observation", "SAO 183375"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.93354078),
        dec: Angle.Degrees(-30.06767089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41320"},
        {"Smithsonian Astrophysical Observation", "SAO 175810"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.46479595),
        dec: Angle.Degrees(-30.06708297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224820"},
        {"Hipparcos Number", "HIP 77"},
        {"Geneva Identification System", "GEN# +4.09010023"},
        {"Smithsonian Astrophysical Observation", "SAO 214920"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.23052169),
        dec: Angle.Degrees(-30.06417333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30122",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Furud"},
        {"Henry Draper", "HD 44402"},
        {"Hipparcos Number", "HIP 30122"},
        {"Celescope Catalog", "CEL 1191"},
        {"Fundamental Katalog 5th Edition", "FK5 240"},
        {"Geneva Identification System", "GEN# +1.00044402"},
        {"Smithsonian Astrophysical Observation", "SAO 196698"},
        {"Wilson Evans Batten Catalogue", "WEB 5991"},
    },
    visualMagnitude: 3.02,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.07827982),
        dec: Angle.Degrees(-30.06337656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70099",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70099"},
    },
    visualMagnitude: 11.58,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.16206992),
        dec: Angle.Degrees(-30.06105831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16897"},
        {"Hipparcos Number", "HIP 12570"},
        {"Smithsonian Astrophysical Observation", "SAO 193863"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.41417616),
        dec: Angle.Degrees(-30.06089401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104103"},
        {"Hipparcos Number", "HIP 58463"},
        {"Smithsonian Astrophysical Observation", "SAO 180356"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.84296047),
        dec: Angle.Degrees(-30.06081202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45749"},
        {"Hipparcos Number", "HIP 30765"},
        {"Smithsonian Astrophysical Observation", "SAO 196853"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.96820512),
        dec: Angle.Degrees(-30.05986871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8163"},
        {"Geneva Identification System", "GEN# -0.03000599"},
    },
    visualMagnitude: 11.39,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.24859941),
        dec: Angle.Degrees(-30.05918726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60956"},
        {"Hipparcos Number", "HIP 36946"},
        {"Smithsonian Astrophysical Observation", "SAO 174082"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.93667351),
        dec: Angle.Degrees(-30.05907487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31803",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31803"},
        {"Smithsonian Astrophysical Observation", "SAO 197037"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.73607181),
        dec: Angle.Degrees(-30.05761786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194414"},
        {"Hipparcos Number", "HIP 100821"},
        {"Smithsonian Astrophysical Observation", "SAO 212123"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.64508734),
        dec: Angle.Degrees(-30.05615827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55122"},
        {"Hipparcos Number", "HIP 34632"},
        {"Smithsonian Astrophysical Observation", "SAO 173130"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.60068624),
        dec: Angle.Degrees(-30.05553532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23829"},
        {"Hipparcos Number", "HIP 17667"},
        {"Smithsonian Astrophysical Observation", "SAO 194525"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.75351624),
        dec: Angle.Degrees(-30.05515210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167909"},
        {"Hipparcos Number", "HIP 89716"},
        {"Smithsonian Astrophysical Observation", "SAO 209982"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.64145487),
        dec: Angle.Degrees(-30.05427338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219069"},
        {"Hipparcos Number", "HIP 114634"},
        {"Smithsonian Astrophysical Observation", "SAO 214389"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.32701241),
        dec: Angle.Degrees(-30.05418803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102025"},
        {"Geneva Identification System", "GEN# -0.03018090"},
        {"Smithsonian Astrophysical Observation", "SAO 212336"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.12704765),
        dec: Angle.Degrees(-30.05194522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61943"},
        {"Hipparcos Number", "HIP 37388"},
        {"Smithsonian Astrophysical Observation", "SAO 174269"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.12093154),
        dec: Angle.Degrees(-30.04947016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218283"},
        {"Hipparcos Number", "HIP 114139"},
        {"Geneva Identification System", "GEN# +1.00218283"},
        {"Smithsonian Astrophysical Observation", "SAO 214314"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.74145216),
        dec: Angle.Degrees(-30.04814113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38788"},
        {"New General Catalogue", "NGC 2489 17"},
    },
    visualMagnitude: 12.19,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.08953657),
        dec: Angle.Degrees(-30.04683655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9159"},
        {"Hipparcos Number", "HIP 6967"},
        {"Geneva Identification System", "GEN# +1.00009159"},
        {"Smithsonian Astrophysical Observation", "SAO 193144"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.42149452),
        dec: Angle.Degrees(-30.04614950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16307"},
        {"Hipparcos Number", "HIP 12122"},
        {"Geneva Identification System", "GEN# +1.00016307"},
        {"Smithsonian Astrophysical Observation", "SAO 193795"},
    },
    visualMagnitude: 5.74,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.03865189),
        dec: Angle.Degrees(-30.04496366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109160"},
        {"Hipparcos Number", "HIP 61232"},
        {"Geneva Identification System", "GEN# +1.00109160"},
        {"Smithsonian Astrophysical Observation", "SAO 180884"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.20868634),
        dec: Angle.Degrees(-30.04473398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140636"},
        {"Hipparcos Number", "HIP 77196"},
        {"Smithsonian Astrophysical Observation", "SAO 183763"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.44345986),
        dec: Angle.Degrees(-30.04140596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72298"},
        {"Hipparcos Number", "HIP 41764"},
        {"Geneva Identification System", "GEN# +1.00072298"},
        {"Smithsonian Astrophysical Observation", "SAO 175986"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.74852412),
        dec: Angle.Degrees(-30.04019481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73256"},
        {"Hipparcos Number", "HIP 42214"},
        {"Geneva Identification System", "GEN# +1.00073256"},
        {"Smithsonian Astrophysical Observation", "SAO 176159"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09640507),
        dec: Angle.Degrees(-30.03778638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35668"},
        {"Smithsonian Astrophysical Observation", "SAO 173549"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.39141246),
        dec: Angle.Degrees(-30.03738881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208213"},
        {"Hipparcos Number", "HIP 108215"},
        {"Geneva Identification System", "GEN# +1.00208213"},
        {"Smithsonian Astrophysical Observation", "SAO 213400"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.84242795),
        dec: Angle.Degrees(-30.03496390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81662"},
        {"Hipparcos Number", "HIP 46279"},
        {"Smithsonian Astrophysical Observation", "SAO 177446"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.54595636),
        dec: Angle.Degrees(-30.03479427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100670"},
        {"Hipparcos Number", "HIP 56504"},
        {"Smithsonian Astrophysical Observation", "SAO 180006"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.75700837),
        dec: Angle.Degrees(-30.03187832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 343"},
        {"Hipparcos Number", "HIP 653"},
        {"Geneva Identification System", "GEN# +4.09010126"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.00786726),
        dec: Angle.Degrees(-30.03169007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175476"},
        {"Hipparcos Number", "HIP 93002"},
        {"Smithsonian Astrophysical Observation", "SAO 210744"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.19391894),
        dec: Angle.Degrees(-30.02871116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214902"},
        {"Hipparcos Number", "HIP 112065"},
        {"Geneva Identification System", "GEN# +1.00214902"},
        {"Smithsonian Astrophysical Observation", "SAO 214019"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.47576900),
        dec: Angle.Degrees(-30.02855796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171936"},
        {"Hipparcos Number", "HIP 91424"},
        {"Geneva Identification System", "GEN# +1.00171936"},
        {"Smithsonian Astrophysical Observation", "SAO 210399"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.67447388),
        dec: Angle.Degrees(-30.02789550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31026"},
        {"Smithsonian Astrophysical Observation", "SAO 171863"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.65336286),
        dec: Angle.Degrees(-30.02696570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36135"},
        {"Hipparcos Number", "HIP 25598"},
        {"Smithsonian Astrophysical Observation", "SAO 195881"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.04777550),
        dec: Angle.Degrees(-30.02672868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108129"},
        {"Hipparcos Number", "HIP 60617"},
        {"Smithsonian Astrophysical Observation", "SAO 180787"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.35750097),
        dec: Angle.Degrees(-30.02510952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75929",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75929"},
        {"Smithsonian Astrophysical Observation", "SAO 183526"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.62169721),
        dec: Angle.Degrees(-30.02317859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71936"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.69165883),
        dec: Angle.Degrees(-30.02261287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -148.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30608"},
        {"Hipparcos Number", "HIP 22280"},
        {"Geneva Identification System", "GEN# +1.00030608"},
        {"Smithsonian Astrophysical Observation", "SAO 195300"},
        {"Wilson Evans Batten Catalogue", "WEB 4294"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.95649059),
        dec: Angle.Degrees(-30.02059732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213042"},
        {"Hipparcos Number", "HIP 110996"},
        {"Cincinnati Publication", "Ci 20 1364"},
        {"Geneva Identification System", "GEN# +1.00213042"},
        {"Smithsonian Astrophysical Observation", "SAO 213859"},
        {"Wilson Evans Batten Catalogue", "WEB 19871"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.31286507),
        dec: Angle.Degrees(-30.01643212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -813.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111948"},
        {"Hipparcos Number", "HIP 62885"},
        {"Smithsonian Astrophysical Observation", "SAO 181193"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.32119017),
        dec: Angle.Degrees(-30.01543302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64810"},
        {"Smithsonian Astrophysical Observation", "SAO 181511"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.24924732),
        dec: Angle.Degrees(-30.01509050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41211"},
        {"Hipparcos Number", "HIP 28611"},
        {"Smithsonian Astrophysical Observation", "SAO 196431"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.58252857),
        dec: Angle.Degrees(-30.01451369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166550"},
        {"Hipparcos Number", "HIP 89220"},
        {"Geneva Identification System", "GEN# +1.00166550"},
        {"Smithsonian Astrophysical Observation", "SAO 209850"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.11110657),
        dec: Angle.Degrees(-30.01390725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90502"},
        {"Hipparcos Number", "HIP 51101"},
        {"Geneva Identification System", "GEN# +1.00090502"},
        {"Smithsonian Astrophysical Observation", "SAO 178819"},
        {"Wilson Evans Batten Catalogue", "WEB 9341"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.60450927),
        dec: Angle.Degrees(-30.01241436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121065"},
        {"Hipparcos Number", "HIP 67852"},
        {"Smithsonian Astrophysical Observation", "SAO 182056"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.47095700),
        dec: Angle.Degrees(-30.01071314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220621"},
        {"Hipparcos Number", "HIP 115631"},
        {"Smithsonian Astrophysical Observation", "SAO 214536"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.36197259),
        dec: Angle.Degrees(-30.00762646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178606"},
        {"Hipparcos Number", "HIP 94184"},
        {"Geneva Identification System", "GEN# +1.00178606"},
        {"Smithsonian Astrophysical Observation", "SAO 211011"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.61492791),
        dec: Angle.Degrees(-30.00695952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192433"},
        {"Hipparcos Number", "HIP 99878"},
        {"Fundamental Katalog 5th Edition", "FK5 3621"},
        {"Geneva Identification System", "GEN# +1.00192433"},
        {"Smithsonian Astrophysical Observation", "SAO 211940"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.96077438),
        dec: Angle.Degrees(-30.00529660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69879"},
        {"Hipparcos Number", "HIP 40656"},
        {"Geneva Identification System", "GEN# +1.00069879"},
        {"Smithsonian Astrophysical Observation", "SAO 175543"},
        {"Wilson Evans Batten Catalogue", "WEB 7902"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.49275494),
        dec: Angle.Degrees(-30.00370618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34692"},
        {"Hipparcos Number", "HIP 24713"},
        {"Smithsonian Astrophysical Observation", "SAO 195727"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.51419281),
        dec: Angle.Degrees(-30.00257774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12438"},
        {"Hipparcos Number", "HIP 9440"},
        {"Geneva Identification System", "GEN# +1.00012438"},
        {"Smithsonian Astrophysical Observation", "SAO 193455"},
        {"Wilson Evans Batten Catalogue", "WEB 1979"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.31165140),
        dec: Angle.Degrees(-30.00156583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54225"},
        {"Hipparcos Number", "HIP 34303"},
        {"Smithsonian Astrophysical Observation", "SAO 172985"},
    },
    visualMagnitude: 9.71,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.68595634),
        dec: Angle.Degrees(-30.00152551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218810"},
        {"Hipparcos Number", "HIP 114487"},
        {"Geneva Identification System", "GEN# +1.00218810"},
        {"Smithsonian Astrophysical Observation", "SAO 214369"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.79855521),
        dec: Angle.Degrees(-30.00144551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102337"},
        {"Geneva Identification System", "GEN# -0.03018140"},
        {"Smithsonian Astrophysical Observation", "SAO 212391"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.02636533),
        dec: Angle.Degrees(-30.00133359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -318.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 317339"},
        {"Hipparcos Number", "HIP 89628"},
        {"Smithsonian Astrophysical Observation", "SAO 209958"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.36914306),
        dec: Angle.Degrees(-30.00112453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44868"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.13832097),
        dec: Angle.Degrees(-29.99934157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54729"},
        {"Hipparcos Number", "HIP 34469"},
        {"Smithsonian Astrophysical Observation", "SAO 173061"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.16211780),
        dec: Angle.Degrees(-29.99855419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112710"},
        {"Hipparcos Number", "HIP 63357"},
        {"Smithsonian Astrophysical Observation", "SAO 181283"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.73822957),
        dec: Angle.Degrees(-29.99850819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195900"},
        {"Hipparcos Number", "HIP 101576"},
        {"Smithsonian Astrophysical Observation", "SAO 212255"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.78225362),
        dec: Angle.Degrees(-29.99822919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148716"},
        {"Hipparcos Number", "HIP 80896"},
        {"Geneva Identification System", "GEN# +1.00148716"},
        {"Smithsonian Astrophysical Observation", "SAO 184435"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.79615132),
        dec: Angle.Degrees(-29.99783734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41274"},
        {"Hipparcos Number", "HIP 28635"},
        {"Smithsonian Astrophysical Observation", "SAO 171175"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.69859847),
        dec: Angle.Degrees(-29.99700918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13376"},
        {"Hipparcos Number", "HIP 10108"},
        {"Geneva Identification System", "GEN# +1.00013376"},
        {"Smithsonian Astrophysical Observation", "SAO 193546"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.51696595),
        dec: Angle.Degrees(-29.99611287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142727"},
        {"Hipparcos Number", "HIP 78136"},
        {"Geneva Identification System", "GEN# +1.00142727"},
        {"Smithsonian Astrophysical Observation", "SAO 183966"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.32368631),
        dec: Angle.Degrees(-29.99601614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93849"},
        {"Hipparcos Number", "HIP 52939"},
        {"Geneva Identification System", "GEN# +1.00093849"},
        {"Smithsonian Astrophysical Observation", "SAO 179261"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.39778138),
        dec: Angle.Degrees(-29.99437698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165767"},
        {"Henry Draper 2", "HD 165768"},
        {"Hipparcos Number", "HIP 88907"},
        {"Geneva Identification System", "GEN# +1.00165767"},
        {"Smithsonian Astrophysical Observation", "SAO 209769"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.22713917),
        dec: Angle.Degrees(-29.99293829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39606",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6585 C"},
        {"Hipparcos Number", "HIP 39606"},
        {"Smithsonian Astrophysical Observation", "SAO 175157"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.40220043),
        dec: Angle.Degrees(-29.99246210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39610",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6585 AB"},
        {"Henry Draper", "HD 67162"},
        {"Hipparcos Number", "HIP 39610"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.41604348),
        dec: Angle.Degrees(-29.99199247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61637"},
        {"Hipparcos Number", "HIP 37251"},
        {"Smithsonian Astrophysical Observation", "SAO 174207"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.75561672),
        dec: Angle.Degrees(-29.99181603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96433"},
        {"Smithsonian Astrophysical Observation", "SAO 211404"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.09349490),
        dec: Angle.Degrees(-29.99118278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76016"},
        {"Hipparcos Number", "HIP 43591"},
        {"Smithsonian Astrophysical Observation", "SAO 176622"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.16144571),
        dec: Angle.Degrees(-29.99037018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133434"},
        {"Hipparcos Number", "HIP 73824"},
        {"Smithsonian Astrophysical Observation", "SAO 183153"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.32633419),
        dec: Angle.Degrees(-29.99033167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19436"},
        {"Hipparcos Number", "HIP 14463"},
        {"Smithsonian Astrophysical Observation", "SAO 194088"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.66469836),
        dec: Angle.Degrees(-29.98738524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20912"},
        {"Hipparcos Number", "HIP 15635"},
        {"Smithsonian Astrophysical Observation", "SAO 194247"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.33003216),
        dec: Angle.Degrees(-29.98727975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154753"},
        {"Hipparcos Number", "HIP 83871"},
        {"Smithsonian Astrophysical Observation", "SAO 185061"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.12889724),
        dec: Angle.Degrees(-29.98549017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9349"},
        {"Hipparcos Number", "HIP 7100"},
        {"Geneva Identification System", "GEN# +1.00009349"},
        {"Smithsonian Astrophysical Observation", "SAO 193161"},
        {"Wilson Evans Batten Catalogue", "WEB 1533"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.87431200),
        dec: Angle.Degrees(-29.98504754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92080"},
        {"Hipparcos Number", "HIP 52001"},
        {"Geneva Identification System", "GEN# +1.00092080"},
        {"Smithsonian Astrophysical Observation", "SAO 179044"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.36133336),
        dec: Angle.Degrees(-29.98461193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194181"},
        {"Hipparcos Number", "HIP 100732"},
        {"Fundamental Katalog 5th Edition", "FK5 5802"},
        {"Smithsonian Astrophysical Observation", "SAO 212106"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.33709796),
        dec: Angle.Degrees(-29.98457758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103381"},
        {"Hipparcos Number", "HIP 58029"},
        {"Geneva Identification System", "GEN# +1.00103381"},
        {"Smithsonian Astrophysical Observation", "SAO 180280"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.52255891),
        dec: Angle.Degrees(-29.98244944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208870"},
        {"Hipparcos Number", "HIP 108579"},
        {"Smithsonian Astrophysical Observation", "SAO 213460"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.93265701),
        dec: Angle.Degrees(-29.98188657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98715"},
        {"Hipparcos Number", "HIP 55444"},
        {"Fundamental Katalog 5th Edition", "FK5 4998"},
        {"Smithsonian Astrophysical Observation", "SAO 179799"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.32046035),
        dec: Angle.Degrees(-29.98152598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152215"},
        {"Hipparcos Number", "HIP 82606"},
        {"Smithsonian Astrophysical Observation", "SAO 184748"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.31259244),
        dec: Angle.Degrees(-29.98146526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173064"},
        {"Hipparcos Number", "HIP 91965"},
        {"Smithsonian Astrophysical Observation", "SAO 210519"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.17601022),
        dec: Angle.Degrees(-29.98016602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163083"},
        {"Hipparcos Number", "HIP 87760"},
        {"Geneva Identification System", "GEN# +1.00163083"},
        {"Smithsonian Astrophysical Observation", "SAO 185941"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.90386100),
        dec: Angle.Degrees(-29.97757401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33935"},
        {"Hipparcos Number", "HIP 24263"},
        {"Smithsonian Astrophysical Observation", "SAO 195650"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.11513606),
        dec: Angle.Degrees(-29.97680313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72644"},
        {"Hipparcos Number", "HIP 41947"},
        {"Smithsonian Astrophysical Observation", "SAO 176064"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.26742280),
        dec: Angle.Degrees(-29.97565800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154994"},
        {"Hipparcos Number", "HIP 83985"},
        {"Geneva Identification System", "GEN# +1.00154994"},
        {"Smithsonian Astrophysical Observation", "SAO 185094"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.53454128),
        dec: Angle.Degrees(-29.97316812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72708"},
        {"Smithsonian Astrophysical Observation", "SAO 182939"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.98830991),
        dec: Angle.Degrees(-29.97287229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96723"},
        {"Hipparcos Number", "HIP 54430"},
        {"Geneva Identification System", "GEN# +1.00096723"},
        {"Smithsonian Astrophysical Observation", "SAO 179568"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.06570976),
        dec: Angle.Degrees(-29.97245501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223631"},
        {"Hipparcos Number", "HIP 117625"},
        {"Smithsonian Astrophysical Observation", "SAO 214815"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.83087106),
        dec: Angle.Degrees(-29.96833137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109573"},
        {"Smithsonian Astrophysical Observation", "SAO 213628"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.95745160),
        dec: Angle.Degrees(-29.96825759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139648"},
        {"Hipparcos Number", "HIP 76754"},
        {"Geneva Identification System", "GEN# +1.00139648"},
        {"Smithsonian Astrophysical Observation", "SAO 183684"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.09029268),
        dec: Angle.Degrees(-29.96743070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96380"},
        {"Hipparcos Number", "HIP 54285"},
        {"Geneva Identification System", "GEN# +1.00096380"},
        {"Smithsonian Astrophysical Observation", "SAO 179535"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.57956743),
        dec: Angle.Degrees(-29.96732226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85770",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10601 AB"},
        {"Henry Draper", "HD 315939"},
        {"Hipparcos Number", "HIP 85770"},
        {"Geneva Identification System", "GEN# +1.00315939J"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.88770728),
        dec: Angle.Degrees(-29.96729340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40127"},
        {"Hipparcos Number", "HIP 28025"},
        {"Smithsonian Astrophysical Observation", "SAO 171022"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.90881435),
        dec: Angle.Degrees(-29.96689303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66932"},
        {"Hipparcos Number", "HIP 39521"},
        {"Geneva Identification System", "GEN# +1.00066932"},
        {"Smithsonian Astrophysical Observation", "SAO 175122"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.16153690),
        dec: Angle.Degrees(-29.96599297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87794"},
        {"Hipparcos Number", "HIP 49531"},
        {"Geneva Identification System", "GEN# +1.00087794"},
        {"Smithsonian Astrophysical Observation", "SAO 178426"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.70852426),
        dec: Angle.Degrees(-29.96598971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107074"},
        {"Hipparcos Number", "HIP 60043"},
        {"Fundamental Katalog 5th Edition", "FK5 5089"},
        {"Geneva Identification System", "GEN# +1.00107074"},
        {"Smithsonian Astrophysical Observation", "SAO 180673"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.70099691),
        dec: Angle.Degrees(-29.96081879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91"},
        {"Hipparcos Number", "HIP 477"},
        {"Geneva Identification System", "GEN# +4.09010104"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.42893454),
        dec: Angle.Degrees(-29.96063430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28389"},
        {"Hipparcos Number", "HIP 20801"},
        {"Smithsonian Astrophysical Observation", "SAO 195030"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.85847473),
        dec: Angle.Degrees(-29.96057573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173502"},
        {"Hipparcos Number", "HIP 92152"},
        {"Geneva Identification System", "GEN# +1.00173502"},
        {"Smithsonian Astrophysical Observation", "SAO 210563"},
    },
    visualMagnitude: 9.73,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.73288261),
        dec: Angle.Degrees(-29.95995922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8000"},
        {"Hipparcos Number", "HIP 6151"},
        {"Geneva Identification System", "GEN# +1.00008000"},
        {"Smithsonian Astrophysical Observation", "SAO 193048"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.73488176),
        dec: Angle.Degrees(-29.95931501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1474"},
        {"Hipparcos Number", "HIP 1500"},
        {"Geneva Identification System", "GEN# +1.00001474"},
        {"Smithsonian Astrophysical Observation", "SAO 192456"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.67487484),
        dec: Angle.Degrees(-29.95688954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72687"},
        {"Hipparcos Number", "HIP 41967"},
        {"Geneva Identification System", "GEN# +1.00072687"},
        {"Smithsonian Astrophysical Observation", "SAO 176075"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.31419775),
        dec: Angle.Degrees(-29.95663223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9660"},
        {"Hipparcos Number", "HIP 7315"},
        {"Smithsonian Astrophysical Observation", "SAO 193182"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.54690652),
        dec: Angle.Degrees(-29.95618654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28401"},
    },
    visualMagnitude: 11.88,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.97545118),
        dec: Angle.Degrees(-29.95435857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78521"},
        {"Hipparcos Number", "HIP 44799"},
        {"Smithsonian Astrophysical Observation", "SAO 176995"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.94470776),
        dec: Angle.Degrees(-29.95426606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177687"},
        {"Hipparcos Number", "HIP 93861"},
        {"Smithsonian Astrophysical Observation", "SAO 210939"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.72870161),
        dec: Angle.Degrees(-29.95347427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71912"},
        {"Hipparcos Number", "HIP 41602"},
        {"Geneva Identification System", "GEN# +1.00071912"},
        {"Smithsonian Astrophysical Observation", "SAO 175919"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.21815177),
        dec: Angle.Degrees(-29.95121740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63050"},
        {"Hipparcos Number", "HIP 37872"},
        {"Smithsonian Astrophysical Observation", "SAO 174477"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.44284463),
        dec: Angle.Degrees(-29.95004789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16118"},
        {"Hipparcos Number", "HIP 11979"},
        {"Geneva Identification System", "GEN# +1.00016118"},
        {"Smithsonian Astrophysical Observation", "SAO 193781"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.63449529),
        dec: Angle.Degrees(-29.94965794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79982",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9995 AB"},
        {"Henry Draper", "HD 146852"},
        {"Hipparcos Number", "HIP 79982"},
        {"Smithsonian Astrophysical Observation", "SAO 184311"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.88752586),
        dec: Angle.Degrees(-29.94855296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63274"},
        {"Hipparcos Number", "HIP 37957"},
        {"Geneva Identification System", "GEN# +1.00063274"},
        {"Smithsonian Astrophysical Observation", "SAO 174522"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.70841868),
        dec: Angle.Degrees(-29.94844925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50095"},
        {"Hipparcos Number", "HIP 32804"},
        {"Geneva Identification System", "GEN# +1.00050095"},
        {"Smithsonian Astrophysical Observation", "SAO 172411"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.57553393),
        dec: Angle.Degrees(-29.94801169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151509"},
        {"Hipparcos Number", "HIP 82309"},
        {"Smithsonian Astrophysical Observation", "SAO 184663"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.26649254),
        dec: Angle.Degrees(-29.94589319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77112"},
        {"Smithsonian Astrophysical Observation", "SAO 183750"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.18283933),
        dec: Angle.Degrees(-29.94413206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85413",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10550 AB"},
        {"Henry Draper", "HD 315843"},
        {"Hipparcos Number", "HIP 85413"},
        {"Smithsonian Astrophysical Observation", "SAO 185409"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.80781483),
        dec: Angle.Degrees(-29.94200398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36942"},
        {"Hipparcos Number", "HIP 26087"},
        {"Smithsonian Astrophysical Observation", "SAO 170560"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.46035475),
        dec: Angle.Degrees(-29.94053137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151312"},
        {"Hipparcos Number", "HIP 82215"},
        {"Smithsonian Astrophysical Observation", "SAO 184643"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.94280780),
        dec: Angle.Degrees(-29.93949481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129761"},
        {"Hipparcos Number", "HIP 72128"},
        {"Smithsonian Astrophysical Observation", "SAO 182842"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.31878856),
        dec: Angle.Degrees(-29.93866296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89829"},
        {"Hipparcos Number", "HIP 50732"},
        {"Fundamental Katalog 5th Edition", "FK5 4920"},
        {"Smithsonian Astrophysical Observation", "SAO 178725"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.38474446),
        dec: Angle.Degrees(-29.93798660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187829"},
        {"Hipparcos Number", "HIP 97848"},
        {"Smithsonian Astrophysical Observation", "SAO 211628"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.26909163),
        dec: Angle.Degrees(-29.93763139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56620"},
        {"Hipparcos Number", "HIP 35201"},
        {"Smithsonian Astrophysical Observation", "SAO 173355"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.12535655),
        dec: Angle.Degrees(-29.93756401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171352"},
        {"Hipparcos Number", "HIP 91149"},
        {"Smithsonian Astrophysical Observation", "SAO 187019"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.93149215),
        dec: Angle.Degrees(-29.93752333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203017"},
        {"Hipparcos Number", "HIP 105356"},
        {"Smithsonian Astrophysical Observation", "SAO 212921"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.10431194),
        dec: Angle.Degrees(-29.93523927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166423"},
        {"Hipparcos Number", "HIP 89163"},
        {"Smithsonian Astrophysical Observation", "SAO 186433"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.94728674),
        dec: Angle.Degrees(-29.93497838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99553"},
        {"Hipparcos Number", "HIP 55864"},
        {"Smithsonian Astrophysical Observation", "SAO 179892"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.75259554),
        dec: Angle.Degrees(-29.93465296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16047"},
        {"Hipparcos Number", "HIP 11917"},
        {"Geneva Identification System", "GEN# +1.00016047"},
        {"Smithsonian Astrophysical Observation", "SAO 193772"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.46023593),
        dec: Angle.Degrees(-29.93341356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221858"},
        {"Hipparcos Number", "HIP 116453"},
        {"Geneva Identification System", "GEN# +1.00221858"},
        {"Smithsonian Astrophysical Observation", "SAO 214644"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.95416074),
        dec: Angle.Degrees(-29.93326211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71334"},
        {"Hipparcos Number", "HIP 41317"},
        {"Geneva Identification System", "GEN# +1.00071334"},
        {"Smithsonian Astrophysical Observation", "SAO 175807"},
        {"Wilson Evans Batten Catalogue", "WEB 7996"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.45592412),
        dec: Angle.Degrees(-29.92988208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -291.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56045"},
        {"Hipparcos Number", "HIP 34968"},
        {"Celescope Catalog", "CEL 1697"},
        {"Smithsonian Astrophysical Observation", "SAO 173263"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.53586534),
        dec: Angle.Degrees(-29.92943708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70231"},
        {"Smithsonian Astrophysical Observation", "SAO 182469"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.52498324),
        dec: Angle.Degrees(-29.92570060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149980"},
        {"Hipparcos Number", "HIP 81542"},
        {"Smithsonian Astrophysical Observation", "SAO 184523"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.81834306),
        dec: Angle.Degrees(-29.92424853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66273",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8957 AB"},
        {"Henry Draper", "HD 118072"},
        {"Hipparcos Number", "HIP 66273"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.73932801),
        dec: Angle.Degrees(-29.92330549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94791"},
        {"Smithsonian Astrophysical Observation", "SAO 211130"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.30614830),
        dec: Angle.Degrees(-29.91981631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10050 AB"},
        {"Henry Draper", "HD 147936"},
        {"Hipparcos Number", "HIP 80490"},
        {"Smithsonian Astrophysical Observation", "SAO 184384"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.45248430),
        dec: Angle.Degrees(-29.91858795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183639"},
        {"Hipparcos Number", "HIP 96043"},
        {"Smithsonian Astrophysical Observation", "SAO 211333"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.92692669),
        dec: Angle.Degrees(-29.91811565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35056"},
        {"Hipparcos Number", "HIP 24946"},
        {"Geneva Identification System", "GEN# +1.00035056"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.15824845),
        dec: Angle.Degrees(-29.91809427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12134"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.07430236),
        dec: Angle.Degrees(-29.91786339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218760"},
        {"Hipparcos Number", "HIP 114455"},
        {"Geneva Identification System", "GEN# +1.00218760"},
        {"Smithsonian Astrophysical Observation", "SAO 214364"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.70213803),
        dec: Angle.Degrees(-29.91765370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 449.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110141"},
        {"Hipparcos Number", "HIP 61830"},
        {"Smithsonian Astrophysical Observation", "SAO 181004"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.06901677),
        dec: Angle.Degrees(-29.91727910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165155"},
        {"Hipparcos Number", "HIP 88650"},
        {"Geneva Identification System", "GEN# +1.00165155"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.48874265),
        dec: Angle.Degrees(-29.91724416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40126"},
        {"Hipparcos Number", "HIP 28021"},
        {"Geneva Identification System", "GEN# +1.00040126"},
        {"Smithsonian Astrophysical Observation", "SAO 171020"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.90241660),
        dec: Angle.Degrees(-29.91697630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209476"},
        {"Hipparcos Number", "HIP 108952"},
        {"Geneva Identification System", "GEN# +1.00209476"},
        {"Smithsonian Astrophysical Observation", "SAO 213517"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.09930944),
        dec: Angle.Degrees(-29.91653781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38467"},
        {"Hipparcos Number", "HIP 27090"},
        {"Geneva Identification System", "GEN# +1.00038467"},
        {"Smithsonian Astrophysical Observation", "SAO 170771"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.16404799),
        dec: Angle.Degrees(-29.91623480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224567"},
        {"Hipparcos Number", "HIP 118241"},
        {"Geneva Identification System", "GEN# +4.09010006"},
        {"Smithsonian Astrophysical Observation", "SAO 214895"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.74658208),
        dec: Angle.Degrees(-29.91596901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 180.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170123"},
        {"Hipparcos Number", "HIP 90588"},
        {"Geneva Identification System", "GEN# +1.00170123"},
        {"Smithsonian Astrophysical Observation", "SAO 186865"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.27102854),
        dec: Angle.Degrees(-29.91451359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14845"},
        {"Hipparcos Number", "HIP 11096"},
        {"Smithsonian Astrophysical Observation", "SAO 193675"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.71900074),
        dec: Angle.Degrees(-29.91420597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78076"},
        {"Hipparcos Number", "HIP 44602"},
        {"Smithsonian Astrophysical Observation", "SAO 176927"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.31131308),
        dec: Angle.Degrees(-29.91398826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173120"},
        {"Hipparcos Number", "HIP 91991"},
        {"Smithsonian Astrophysical Observation", "SAO 187217"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.24411610),
        dec: Angle.Degrees(-29.91153694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66785",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8993 A"},
        {"Henry Draper", "HD 119012"},
        {"Hipparcos Number", "HIP 66785"},
        {"Smithsonian Astrophysical Observation", "SAO 181858"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.31260299),
        dec: Angle.Degrees(-29.91112089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38552"},
        {"Hipparcos Number", "HIP 27148"},
        {"Smithsonian Astrophysical Observation", "SAO 170793"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.33040076),
        dec: Angle.Degrees(-29.91089172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68758"},
        {"Hipparcos Number", "HIP 40211"},
        {"Geneva Identification System", "GEN# +1.00068758"},
        {"Smithsonian Astrophysical Observation", "SAO 175390"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.19136513),
        dec: Angle.Degrees(-29.91085082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9770"},
        {"Hipparcos Number", "HIP 7372"},
        {"Geneva Identification System", "GEN# +1.00009770"},
        {"Smithsonian Astrophysical Observation", "SAO 193189"},
        {"Wilson Evans Batten Catalogue", "WEB 1585"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.75398479),
        dec: Angle.Degrees(-29.91056753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66784",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8993 B"},
        {"Hipparcos Number", "HIP 66784"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.30736611),
        dec: Angle.Degrees(-29.90969827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70908"},
    },
    visualMagnitude: 11.26,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.50787258),
        dec: Angle.Degrees(-29.90802121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219554"},
        {"Hipparcos Number", "HIP 114934"},
        {"Smithsonian Astrophysical Observation", "SAO 214428"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.20733019),
        dec: Angle.Degrees(-29.90772267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7463",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "CCD J01361-2954AB"},
        {"Henry Draper", "HD 9906"},
        {"Hipparcos Number", "HIP 7463"},
        {"Geneva Identification System", "GEN# +1.00009906J"},
        {"Smithsonian Astrophysical Observation", "SAO 193201"},
        {"Wilson Evans Batten Catalogue", "WEB 1598"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.03512124),
        dec: Angle.Degrees(-29.90743360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39707"},
        {"Geneva Identification System", "GEN# +2.25330052"},
        {"New General Catalogue", "NGC 2533 52"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.74504085),
        dec: Angle.Degrees(-29.90666534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85278"},
        {"Hipparcos Number", "HIP 48240"},
        {"Geneva Identification System", "GEN# +1.00085278"},
        {"Smithsonian Astrophysical Observation", "SAO 178070"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.51752130),
        dec: Angle.Degrees(-29.90525915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209335"},
        {"Hipparcos Number", "HIP 108871"},
        {"Geneva Identification System", "GEN# +1.00209335"},
        {"Smithsonian Astrophysical Observation", "SAO 213502"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.82093473),
        dec: Angle.Degrees(-29.90448853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29514"},
        {"Hipparcos Number", "HIP 21550"},
        {"Smithsonian Astrophysical Observation", "SAO 195174"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.40995422),
        dec: Angle.Degrees(-29.90382613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23856"},
        {"Hipparcos Number", "HIP 17689"},
        {"Geneva Identification System", "GEN# +1.00023856"},
        {"Smithsonian Astrophysical Observation", "SAO 194531"},
        {"Wilson Evans Batten Catalogue", "WEB 3377"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.83276739),
        dec: Angle.Degrees(-29.90158791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83931",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10357 AB"},
        {"Henry Draper", "HD 154883"},
        {"Hipparcos Number", "HIP 83931"},
        {"Smithsonian Astrophysical Observation", "SAO 185079"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.33695037),
        dec: Angle.Degrees(-29.90049917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78438"},
        {"Smithsonian Astrophysical Observation", "SAO 184018"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.20364810),
        dec: Angle.Degrees(-29.90004429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122755"},
        {"Hipparcos Number", "HIP 68757"},
        {"Smithsonian Astrophysical Observation", "SAO 182213"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.09904744),
        dec: Angle.Degrees(-29.89960503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124039"},
        {"Hipparcos Number", "HIP 69360"},
        {"Smithsonian Astrophysical Observation", "SAO 182334"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.95536083),
        dec: Angle.Degrees(-29.89795237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29550",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Amadioha"},
        {"Henry Draper", "HD 43197"},
        {"Hipparcos Number", "HIP 29550"},
        {"Geneva Identification System", "GEN# +1.00043197"},
        {"Smithsonian Astrophysical Observation", "SAO 171427"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.39817431),
        dec: Angle.Degrees(-29.89730323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 148.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67473"},
        {"Hipparcos Number", "HIP 39713"},
        {"Geneva Identification System", "GEN# +2.25330011"},
        {"Smithsonian Astrophysical Observation", "SAO 175203"},
        {"New General Catalogue", "NGC 2533 11"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.75882205),
        dec: Angle.Degrees(-29.89671566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25659"},
        {"Geneva Identification System", "GEN# -0.02902277"},
        {"Wilson Evans Batten Catalogue", "WEB 4978"},
    },
    visualMagnitude: 11.61,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.21115852),
        dec: Angle.Degrees(-29.89594032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 375.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -272.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63250"},
        {"Hipparcos Number", "HIP 37955"},
        {"Geneva Identification System", "GEN# +1.00063250"},
        {"Smithsonian Astrophysical Observation", "SAO 174521"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.70136159),
        dec: Angle.Degrees(-29.89533385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149894"},
        {"Hipparcos Number", "HIP 81498"},
        {"Geneva Identification System", "GEN# +1.00149894"},
        {"Smithsonian Astrophysical Observation", "SAO 184516"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.69450017),
        dec: Angle.Degrees(-29.89230732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95469"},
        {"Hipparcos Number", "HIP 53835"},
        {"Geneva Identification System", "GEN# +1.00095469"},
        {"Smithsonian Astrophysical Observation", "SAO 179430"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.20668698),
        dec: Angle.Degrees(-29.88914066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77729",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9813 A"},
        {"Henry Draper", "HD 141832"},
        {"Hipparcos Number", "HIP 77729"},
        {"Fundamental Katalog 5th Edition", "FK5 5403"},
        {"Geneva Identification System", "GEN# +1.00141832"},
        {"Smithsonian Astrophysical Observation", "SAO 183873"},
        {"Wilson Evans Batten Catalogue", "WEB 13151"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.05370687),
        dec: Angle.Degrees(-29.88634407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -136.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13807"},
        {"Hipparcos Number", "HIP 10381"},
        {"Geneva Identification System", "GEN# +1.00013807"},
        {"Smithsonian Astrophysical Observation", "SAO 193585"},
    },
    visualMagnitude: 10.20,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.42358311),
        dec: Angle.Degrees(-29.88595595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121449"},
        {"Hipparcos Number", "HIP 68051"},
        {"Smithsonian Astrophysical Observation", "SAO 182098"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.00973337),
        dec: Angle.Degrees(-29.88593570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102071"},
        {"Hipparcos Number", "HIP 57271"},
        {"Geneva Identification System", "GEN# +1.00102071"},
        {"Smithsonian Astrophysical Observation", "SAO 180155"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.16400111),
        dec: Angle.Degrees(-29.88499842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171811"},
        {"Hipparcos Number", "HIP 91365"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.51067808),
        dec: Angle.Degrees(-29.88214687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17275"},
        {"Hipparcos Number", "HIP 12880"},
        {"Smithsonian Astrophysical Observation", "SAO 193892"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.39387702),
        dec: Angle.Degrees(-29.88046384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93506",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ascella"},
        {"Aitken", "ADS 11950 AB"},
        {"Henry Draper", "HD 176687"},
        {"Hipparcos Number", "HIP 93506"},
        {"Geneva Identification System", "GEN# +1.00176687J"},
        {"Smithsonian Astrophysical Observation", "SAO 187600"},
        {"Wilson Evans Batten Catalogue", "WEB 16231"},
    },
    visualMagnitude: 2.60,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.65301428),
        dec: Angle.Degrees(-29.88011429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
