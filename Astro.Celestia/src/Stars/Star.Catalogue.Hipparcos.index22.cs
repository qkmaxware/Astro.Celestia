using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_22() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86754"},
        {"Hipparcos Number", "HIP 48975"},
        {"Fundamental Katalog 5th Edition", "FK5 2806"},
        {"Geneva Identification System", "GEN# +1.00086754"},
        {"Smithsonian Astrophysical Observation", "SAO 221668"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.85924179),
        dec: Angle.Degrees(-44.95543796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136715"},
        {"Hipparcos Number", "HIP 75351"},
        {"Smithsonian Astrophysical Observation", "SAO 225728"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.96694180),
        dec: Angle.Degrees(-44.95540582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28873"},
        {"Hipparcos Number", "HIP 21060"},
        {"Fundamental Katalog 5th Edition", "FK5 167"},
        {"Geneva Identification System", "GEN# +1.00028873"},
        {"Smithsonian Astrophysical Observation", "SAO 216850"},
        {"Wilson Evans Batten Catalogue", "WEB 4052"},
    },
    visualMagnitude: 5.07,
    bvColour: -0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.70874038),
        dec: Angle.Degrees(-44.95374351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147150"},
        {"Hipparcos Number", "HIP 80180"},
        {"Smithsonian Astrophysical Observation", "SAO 226689"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.51844631),
        dec: Angle.Degrees(-44.95124381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167650"},
        {"Hipparcos Number", "HIP 89701"},
        {"Smithsonian Astrophysical Observation", "SAO 228890"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.60485142),
        dec: Angle.Degrees(-44.94947047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200554"},
        {"Hipparcos Number", "HIP 104125"},
        {"Smithsonian Astrophysical Observation", "SAO 230518"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.42072713),
        dec: Angle.Degrees(-44.94902259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95217"},
        {"Cincinnati Publication", "Ci 20 1146"},
        {"Geneva Identification System", "GEN# -0.04513161"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.57758761),
        dec: Angle.Degrees(-44.94805585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -416.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32931"},
        {"Hipparcos Number", "HIP 23604"},
        {"Smithsonian Astrophysical Observation", "SAO 217158"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.13647501),
        dec: Angle.Degrees(-44.94770643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189951"},
        {"Hipparcos Number", "HIP 98859"},
        {"Geneva Identification System", "GEN# +1.00189951"},
        {"Smithsonian Astrophysical Observation", "SAO 230024"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.12404019),
        dec: Angle.Degrees(-44.94690258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24576"},
        {"Hipparcos Number", "HIP 18139"},
        {"Geneva Identification System", "GEN# +1.00024576"},
        {"Smithsonian Astrophysical Observation", "SAO 216534"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.16583196),
        dec: Angle.Degrees(-44.94680659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72919"},
        {"Hipparcos Number", "HIP 42007"},
        {"Celescope Catalog", "CEL 2654"},
        {"Geneva Identification System", "GEN# +1.00072919"},
        {"Smithsonian Astrophysical Observation", "SAO 220107"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.42754723),
        dec: Angle.Degrees(-44.94607529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26244"},
        {"Hipparcos Number", "HIP 19212"},
        {"Geneva Identification System", "GEN# +1.00026244"},
        {"Smithsonian Astrophysical Observation", "SAO 216652"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.77569035),
        dec: Angle.Degrees(-44.94563886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165753"},
        {"Hipparcos Number", "HIP 88990"},
        {"Geneva Identification System", "GEN# +1.00165753"},
        {"Smithsonian Astrophysical Observation", "SAO 228758"},
        {"Wilson Evans Batten Catalogue", "WEB 15093"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.45192442),
        dec: Angle.Degrees(-44.94547114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139961"},
        {"Hipparcos Number", "HIP 76961"},
        {"Geneva Identification System", "GEN# +1.00139961"},
        {"Geneva Identification System 2", "GEN# -0.04410333"},
        {"Smithsonian Astrophysical Observation", "SAO 226097"},
        {"Wilson Evans Batten Catalogue", "WEB 13053"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.72072191),
        dec: Angle.Degrees(-44.94444953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -187.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85314",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85314"},
    },
    visualMagnitude: 11.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.50416561),
        dec: Angle.Degrees(-44.94403931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207145"},
        {"Hipparcos Number", "HIP 107638"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.03666090),
        dec: Angle.Degrees(-44.94263876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136300"},
        {"Hipparcos Number", "HIP 75161"},
        {"Celescope Catalog", "CEL 4365"},
        {"Geneva Identification System", "GEN# +1.00136300"},
        {"Smithsonian Astrophysical Observation", "SAO 225692"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.39291779),
        dec: Angle.Degrees(-44.93817222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8023"},
        {"Hipparcos Number", "HIP 6147"},
        {"Geneva Identification System", "GEN# +1.00008023"},
        {"Smithsonian Astrophysical Observation", "SAO 215452"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.72767374),
        dec: Angle.Degrees(-44.93689236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126298"},
        {"Hipparcos Number", "HIP 70542"},
        {"Geneva Identification System", "GEN# +1.00126298"},
        {"Smithsonian Astrophysical Observation", "SAO 224914"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.46312066),
        dec: Angle.Degrees(-44.93502408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95137"},
        {"Hipparcos Number", "HIP 53638"},
        {"Smithsonian Astrophysical Observation", "SAO 222460"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.59849091),
        dec: Angle.Degrees(-44.93460071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223923"},
        {"Hipparcos Number", "HIP 117823"},
        {"Smithsonian Astrophysical Observation", "SAO 231834"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.43523433),
        dec: Angle.Degrees(-44.93452401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 89.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178227"},
        {"Hipparcos Number", "HIP 94153"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.47569808),
        dec: Angle.Degrees(-44.93234171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131242"},
        {"Hipparcos Number", "HIP 72900"},
        {"Smithsonian Astrophysical Observation", "SAO 225281"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.48718693),
        dec: Angle.Degrees(-44.93013163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162931"},
        {"Hipparcos Number", "HIP 87767"},
        {"Fundamental Katalog 5th Edition", "FK5 5574"},
        {"Smithsonian Astrophysical Observation", "SAO 228546"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.93414734),
        dec: Angle.Degrees(-44.93003059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133041"},
        {"Hipparcos Number", "HIP 73703"},
        {"Smithsonian Astrophysical Observation", "SAO 225409"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.95755998),
        dec: Angle.Degrees(-44.92949847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58624"},
    },
    visualMagnitude: 10.30,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.33711906),
        dec: Angle.Degrees(-44.92931261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50943"},
        {"Hipparcos Number", "HIP 33061"},
        {"Smithsonian Astrophysical Observation", "SAO 218285"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.30371730),
        dec: Angle.Degrees(-44.92887259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328333"},
        {"Hipparcos Number", "HIP 80921"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.86868657),
        dec: Angle.Degrees(-44.92883092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130904"},
        {"Hipparcos Number", "HIP 72738"},
        {"Geneva Identification System", "GEN# +1.00130904"},
        {"Smithsonian Astrophysical Observation", "SAO 225256"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.06464070),
        dec: Angle.Degrees(-44.92701935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38172"},
        {"Hipparcos Number", "HIP 26819"},
        {"Fundamental Katalog 5th Edition", "FK5 4519"},
        {"Smithsonian Astrophysical Observation", "SAO 217478"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.41510254),
        dec: Angle.Degrees(-44.92677595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110037"},
        {"Hipparcos Number", "HIP 61773"},
        {"Smithsonian Astrophysical Observation", "SAO 223579"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.91248167),
        dec: Angle.Degrees(-44.92664875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105498"},
        {"Hipparcos Number", "HIP 59218"},
        {"Geneva Identification System", "GEN# +1.00105498"},
        {"Smithsonian Astrophysical Observation", "SAO 223238"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.17942642),
        dec: Angle.Degrees(-44.92600251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31117"},
        {"Hipparcos Number", "HIP 22537"},
        {"Smithsonian Astrophysical Observation", "SAO 217039"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.76257924),
        dec: Angle.Degrees(-44.92579007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49062"},
    },
    visualMagnitude: 9.93,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.17625675),
        dec: Angle.Degrees(-44.92177021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205652"},
        {"Hipparcos Number", "HIP 106816"},
        {"Smithsonian Astrophysical Observation", "SAO 230764"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.50638781),
        dec: Angle.Degrees(-44.92019555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114138"},
        {"Hipparcos Number", "HIP 64190"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.33186408),
        dec: Angle.Degrees(-44.91823739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30041"},
        {"Hipparcos Number", "HIP 21851"},
        {"Geneva Identification System", "GEN# +1.00030041"},
        {"Smithsonian Astrophysical Observation", "SAO 216940"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.47757382),
        dec: Angle.Degrees(-44.91596393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199340"},
        {"Hipparcos Number", "HIP 103501"},
        {"Geneva Identification System", "GEN# +1.00199340"},
        {"Renson", "Renson 55540"},
        {"Smithsonian Astrophysical Observation", "SAO 230463"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.54186486),
        dec: Angle.Degrees(-44.91571018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41778"},
        {"Hipparcos Number", "HIP 28803"},
        {"Smithsonian Astrophysical Observation", "SAO 217707"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.22283166),
        dec: Angle.Degrees(-44.91519567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153549"},
        {"Hipparcos Number", "HIP 83368"},
        {"Smithsonian Astrophysical Observation", "SAO 227565"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.58402281),
        dec: Angle.Degrees(-44.91466500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42917"},
        {"Hipparcos Number", "HIP 29355"},
        {"Fundamental Katalog 5th Edition", "FK5 4564"},
        {"Smithsonian Astrophysical Observation", "SAO 217764"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.81416759),
        dec: Angle.Degrees(-44.91433214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59868"},
        {"Hipparcos Number", "HIP 36427"},
        {"Celescope Catalog", "CEL 1894"},
        {"Geneva Identification System", "GEN# +1.00059868"},
        {"Smithsonian Astrophysical Observation", "SAO 218761"},
    },
    visualMagnitude: 7.84,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.45004618),
        dec: Angle.Degrees(-44.91195274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67907"},
        {"Hipparcos Number", "HIP 39830"},
        {"Geneva Identification System", "GEN# +1.00067907"},
        {"Smithsonian Astrophysical Observation", "SAO 219461"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.06409326),
        dec: Angle.Degrees(-44.91092249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95408"},
        {"Hipparcos Number", "HIP 53782"},
        {"Smithsonian Astrophysical Observation", "SAO 222490"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.06457802),
        dec: Angle.Degrees(-44.91072415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220112"},
        {"Hipparcos Number", "HIP 115322"},
        {"Smithsonian Astrophysical Observation", "SAO 231562"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.36870575),
        dec: Angle.Degrees(-44.91037145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82321"},
        {"Hipparcos Number", "HIP 46577"},
        {"Geneva Identification System", "GEN# +1.00082321"},
        {"Smithsonian Astrophysical Observation", "SAO 221225"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.47243263),
        dec: Angle.Degrees(-44.90910531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80057"},
        {"Hipparcos Number", "HIP 45481"},
        {"Geneva Identification System", "GEN# +1.00080057J"},
        {"Smithsonian Astrophysical Observation", "SAO 221010"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.01680800),
        dec: Angle.Degrees(-44.89873417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41071"},
        {"Hipparcos Number", "HIP 28474"},
        {"Geneva Identification System", "GEN# +1.00041071"},
        {"Smithsonian Astrophysical Observation", "SAO 217667"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.17202127),
        dec: Angle.Degrees(-44.89730687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59555"},
        {"Smithsonian Astrophysical Observation", "SAO 223281"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.21631312),
        dec: Angle.Degrees(-44.89534472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137620"},
        {"Hipparcos Number", "HIP 75771"},
        {"Celescope Catalog", "CEL 4373"},
        {"Geneva Identification System", "GEN# +1.00137620"},
        {"Smithsonian Astrophysical Observation", "SAO 225821"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.18775721),
        dec: Angle.Degrees(-44.89279445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221943"},
        {"Hipparcos Number", "HIP 116510"},
        {"Geneva Identification System", "GEN# +1.00221943"},
        {"Smithsonian Astrophysical Observation", "SAO 231692"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.14150031),
        dec: Angle.Degrees(-44.89277575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52748"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.77088720),
        dec: Angle.Degrees(-44.89244297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106143"},
        {"Hipparcos Number", "HIP 59562"},
        {"Geneva Identification System", "GEN# +1.00106143"},
        {"Smithsonian Astrophysical Observation", "SAO 223282"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.22026522),
        dec: Angle.Degrees(-44.89218425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205488"},
        {"Hipparcos Number", "HIP 106718"},
        {"Smithsonian Astrophysical Observation", "SAO 230755"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.24907678),
        dec: Angle.Degrees(-44.89186953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152250"},
        {"Hipparcos Number", "HIP 82711"},
        {"Geneva Identification System", "GEN# +1.00152250"},
        {"Smithsonian Astrophysical Observation", "SAO 227387"},
        {"Wilson Evans Batten Catalogue", "WEB 13977"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.59658334),
        dec: Angle.Degrees(-44.89184365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198247"},
        {"Hipparcos Number", "HIP 102887"},
        {"Smithsonian Astrophysical Observation", "SAO 230400"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.66807802),
        dec: Angle.Degrees(-44.88862075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51024"},
        {"Geneva Identification System", "GEN# -0.04406469"},
    },
    visualMagnitude: 11.18,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.35558094),
        dec: Angle.Degrees(-44.88836848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148708"},
        {"Hipparcos Number", "HIP 80965"},
        {"Smithsonian Astrophysical Observation", "SAO 226858"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.99766318),
        dec: Angle.Degrees(-44.88677316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110167",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110167"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.71925544),
        dec: Angle.Degrees(-44.88625697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196952"},
        {"Hipparcos Number", "HIP 102181"},
        {"Fundamental Katalog 5th Edition", "FK5 5821"},
        {"Smithsonian Astrophysical Observation", "SAO 230330"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.56547449),
        dec: Angle.Degrees(-44.88520796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144260"},
        {"Hipparcos Number", "HIP 78935"},
        {"Smithsonian Astrophysical Observation", "SAO 226509"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.70846329),
        dec: Angle.Degrees(-44.88504853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10633"},
        {"Hipparcos Number", "HIP 8011"},
        {"Smithsonian Astrophysical Observation", "SAO 215625"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.71312870),
        dec: Angle.Degrees(-44.88497087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177270"},
        {"Hipparcos Number", "HIP 93789"},
        {"Smithsonian Astrophysical Observation", "SAO 229487"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.51178859),
        dec: Angle.Degrees(-44.88264285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63153"},
        {"Hipparcos Number", "HIP 37837"},
        {"Celescope Catalog", "CEL 2020"},
        {"Geneva Identification System", "GEN# +1.00063153"},
        {"Smithsonian Astrophysical Observation", "SAO 218961"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.35447813),
        dec: Angle.Degrees(-44.88257605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4663"},
        {"Hipparcos Number", "HIP 3756"},
        {"Smithsonian Astrophysical Observation", "SAO 215240"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.05041366),
        dec: Angle.Degrees(-44.88254410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10191"},
        {"Hipparcos Number", "HIP 7662"},
        {"Smithsonian Astrophysical Observation", "SAO 215595"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.66063468),
        dec: Angle.Degrees(-44.87900357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84551"},
        {"Hipparcos Number", "HIP 47802"},
        {"Smithsonian Astrophysical Observation", "SAO 221445"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.17415083),
        dec: Angle.Degrees(-44.87778810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136019"},
        {"Hipparcos Number", "HIP 75036"},
        {"Smithsonian Astrophysical Observation", "SAO 225661"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.99521849),
        dec: Angle.Degrees(-44.87687704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39312"},
        {"Hipparcos Number", "HIP 27512"},
        {"Geneva Identification System", "GEN# +1.00039312"},
        {"Smithsonian Astrophysical Observation", "SAO 217559"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.39220514),
        dec: Angle.Degrees(-44.87540774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42890"},
        {"Hipparcos Number", "HIP 29333"},
        {"Smithsonian Astrophysical Observation", "SAO 217760"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.76628589),
        dec: Angle.Degrees(-44.87404628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216444"},
        {"Hipparcos Number", "HIP 113040"},
        {"Smithsonian Astrophysical Observation", "SAO 231344"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.39609935),
        dec: Angle.Degrees(-44.87393743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207559"},
        {"Hipparcos Number", "HIP 107850"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.76188296),
        dec: Angle.Degrees(-44.87236698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125650"},
        {"Hipparcos Number", "HIP 70227"},
        {"Smithsonian Astrophysical Observation", "SAO 224866"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.51110434),
        dec: Angle.Degrees(-44.87216178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76998"},
        {"Hipparcos Number", "HIP 44034"},
        {"Celescope Catalog", "CEL 3114"},
        {"Geneva Identification System", "GEN# +1.00076998"},
        {"Smithsonian Astrophysical Observation", "SAO 220702"},
    },
    visualMagnitude: 9.22,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.50094366),
        dec: Angle.Degrees(-44.86950776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137154"},
        {"Hipparcos Number", "HIP 75557"},
        {"Smithsonian Astrophysical Observation", "SAO 225767"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.52723728),
        dec: Angle.Degrees(-44.86814859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79186"},
        {"Hipparcos Number", "HIP 45085"},
        {"Geneva Identification System", "GEN# +1.00079186"},
        {"Smithsonian Astrophysical Observation", "SAO 220928"},
        {"Wilson Evans Batten Catalogue", "WEB 8605"},
    },
    visualMagnitude: 4.99,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.76834415),
        dec: Angle.Degrees(-44.86791223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129791"},
        {"Hipparcos Number", "HIP 72192"},
        {"Celescope Catalog", "CEL 4321"},
        {"Geneva Identification System", "GEN# +1.00129791A"},
        {"Smithsonian Astrophysical Observation", "SAO 225174"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.49025105),
        dec: Angle.Degrees(-44.86747296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70892"},
        {"Hipparcos Number", "HIP 41055"},
        {"Celescope Catalog", "CEL 2441"},
        {"Geneva Identification System", "GEN# +1.00070892"},
        {"Smithsonian Astrophysical Observation", "SAO 219847"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.65726500),
        dec: Angle.Degrees(-44.86570207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103390"},
    },
    visualMagnitude: 11.42,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.19738642),
        dec: Angle.Degrees(-44.86358869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190897"},
        {"Hipparcos Number", "HIP 99268"},
        {"Geneva Identification System", "GEN# +1.00190897J"},
        {"Smithsonian Astrophysical Observation", "SAO 230069"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.25738011),
        dec: Angle.Degrees(-44.86273513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36095"},
        {"Hipparcos Number", "HIP 25489"},
        {"Smithsonian Astrophysical Observation", "SAO 217341"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.77648690),
        dec: Angle.Degrees(-44.86213226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105905"},
        {"Hipparcos Number", "HIP 59419"},
        {"Geneva Identification System", "GEN# +1.00105905"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.83060515),
        dec: Angle.Degrees(-44.86129694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104226"},
        {"Hipparcos Number", "HIP 58527"},
        {"Fundamental Katalog 5th Edition", "FK5 5054"},
        {"Geneva Identification System", "GEN# +1.00104226"},
        {"Smithsonian Astrophysical Observation", "SAO 223163"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.03789190),
        dec: Angle.Degrees(-44.86050836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67843"},
        {"Hipparcos Number", "HIP 39798"},
        {"Smithsonian Astrophysical Observation", "SAO 219452"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.99355441),
        dec: Angle.Degrees(-44.86012834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33742"},
        {"Hipparcos Number", "HIP 24060"},
        {"Smithsonian Astrophysical Observation", "SAO 217212"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.54483361),
        dec: Angle.Degrees(-44.86003193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82386"},
        {"Hipparcos Number", "HIP 46615"},
        {"Geneva Identification System", "GEN# +1.00082386"},
        {"Smithsonian Astrophysical Observation", "SAO 221228"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.58067328),
        dec: Angle.Degrees(-44.85985839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216377"},
        {"Hipparcos Number", "HIP 112995"},
        {"Smithsonian Astrophysical Observation", "SAO 231339"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.25470038),
        dec: Angle.Degrees(-44.85873452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117210"},
        {"Hipparcos Number", "HIP 65825"},
        {"Smithsonian Astrophysical Observation", "SAO 224183"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.41045447),
        dec: Angle.Degrees(-44.85793691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191556"},
        {"Hipparcos Number", "HIP 99565"},
        {"Geneva Identification System", "GEN# +1.00191556"},
        {"Smithsonian Astrophysical Observation", "SAO 230098"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.07886595),
        dec: Angle.Degrees(-44.85601299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28299"},
        {"Hipparcos Number", "HIP 20678"},
        {"Geneva Identification System", "GEN# +1.00028299"},
        {"Renson", "Renson 7230"},
        {"Smithsonian Astrophysical Observation", "SAO 216798"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.44363318),
        dec: Angle.Degrees(-44.85430883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10921"},
        {"Hipparcos Number", "HIP 8259"},
        {"Smithsonian Astrophysical Observation", "SAO 215643"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.58248105),
        dec: Angle.Degrees(-44.85393181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173150"},
        {"Hipparcos Number", "HIP 92083"},
        {"Geneva Identification System", "GEN# +1.00173150"},
        {"Smithsonian Astrophysical Observation", "SAO 229258"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.51335428),
        dec: Angle.Degrees(-44.85262642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3526"},
        {"Hipparcos Number", "HIP 2979"},
        {"Smithsonian Astrophysical Observation", "SAO 215171"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.48155869),
        dec: Angle.Degrees(-44.85250022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198325"},
        {"Hipparcos Number", "HIP 102925"},
        {"Smithsonian Astrophysical Observation", "SAO 230402"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.79074579),
        dec: Angle.Degrees(-44.85219175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206972"},
        {"Hipparcos Number", "HIP 107551"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.74642237),
        dec: Angle.Degrees(-44.85161096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329213"},
        {"Hipparcos Number", "HIP 83012"},
        {"Geneva Identification System", "GEN# +2.62490001"},
        {"New General Catalogue", "NGC 6249 1"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.44900456),
        dec: Angle.Degrees(-44.85147890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120395"},
        {"Hipparcos Number", "HIP 67527"},
        {"Smithsonian Astrophysical Observation", "SAO 224476"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.53187007),
        dec: Angle.Degrees(-44.85072206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92364"},
        {"Hipparcos Number", "HIP 52134"},
        {"Smithsonian Astrophysical Observation", "SAO 222226"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.76700735),
        dec: Angle.Degrees(-44.85005644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204960"},
        {"Hipparcos Number", "HIP 106429"},
        {"Fundamental Katalog 5th Edition", "FK5 1567"},
        {"Geneva Identification System", "GEN# +1.00204960"},
        {"Smithsonian Astrophysical Observation", "SAO 230737"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.34805400),
        dec: Angle.Degrees(-44.84869460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137234"},
        {"Hipparcos Number", "HIP 75585"},
        {"Smithsonian Astrophysical Observation", "SAO 225778"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.62749356),
        dec: Angle.Degrees(-44.84788016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116671"},
        {"Hipparcos Number", "HIP 65521"},
        {"Geneva Identification System", "GEN# +1.00116671"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.45818253),
        dec: Angle.Degrees(-44.84727073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86179"},
        {"Hipparcos Number", "HIP 48676"},
        {"Smithsonian Astrophysical Observation", "SAO 221610"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.91742867),
        dec: Angle.Degrees(-44.84673760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203915"},
        {"Hipparcos Number", "HIP 105878"},
        {"Geneva Identification System", "GEN# +1.00203915"},
        {"Smithsonian Astrophysical Observation", "SAO 230688"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.64960451),
        dec: Angle.Degrees(-44.84650441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87579"},
        {"Hipparcos Number", "HIP 49372"},
        {"Smithsonian Astrophysical Observation", "SAO 221754"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.18078135),
        dec: Angle.Degrees(-44.84474570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221323"},
        {"Hipparcos Number", "HIP 116097"},
        {"Fundamental Katalog 5th Edition", "FK5 3883"},
        {"Geneva Identification System", "GEN# +1.00221323"},
        {"Smithsonian Astrophysical Observation", "SAO 231642"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.86217374),
        dec: Angle.Degrees(-44.84352938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217522"},
        {"Hipparcos Number", "HIP 113711"},
        {"Geneva Identification System", "GEN# +1.00217522"},
        {"Renson", "Renson 60000"},
        {"Smithsonian Astrophysical Observation", "SAO 231398"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.44539802),
        dec: Angle.Degrees(-44.84068909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87024"},
        {"Hipparcos Number", "HIP 49093"},
        {"Smithsonian Astrophysical Observation", "SAO 221702"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.30395291),
        dec: Angle.Degrees(-44.83289446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120961"},
        {"Hipparcos Number", "HIP 67830"},
        {"Smithsonian Astrophysical Observation", "SAO 224512"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.42085938),
        dec: Angle.Degrees(-44.83147362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32517"},
        {"Hipparcos Number", "HIP 23381"},
        {"Geneva Identification System", "GEN# +1.00032517"},
        {"Smithsonian Astrophysical Observation", "SAO 217124"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.40067591),
        dec: Angle.Degrees(-44.83010043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61763"},
        {"Hipparcos Number", "HIP 37228"},
        {"Smithsonian Astrophysical Observation", "SAO 218860"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.69584170),
        dec: Angle.Degrees(-44.82998023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67621"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.83802938),
        dec: Angle.Degrees(-44.82934654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32048"},
        {"Hipparcos Number", "HIP 23108"},
        {"Smithsonian Astrophysical Observation", "SAO 217089"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.58288419),
        dec: Angle.Degrees(-44.82889618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223066"},
        {"Hipparcos Number", "HIP 117255"},
        {"Smithsonian Astrophysical Observation", "SAO 231774"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.63639032),
        dec: Angle.Degrees(-44.82857546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221352"},
        {"Hipparcos Number", "HIP 116120"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.93118242),
        dec: Angle.Degrees(-44.82566103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207107"},
        {"Hipparcos Number", "HIP 107619"},
        {"Geneva Identification System", "GEN# +1.00207107"},
        {"Smithsonian Astrophysical Observation", "SAO 230842"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.97099649),
        dec: Angle.Degrees(-44.82447179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29226"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.43570730),
        dec: Angle.Degrees(-44.82416550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133821"},
        {"Hipparcos Number", "HIP 74043"},
        {"Smithsonian Astrophysical Observation", "SAO 225467"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.98077593),
        dec: Angle.Degrees(-44.82387070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126318"},
        {"Hipparcos Number", "HIP 70558"},
        {"Smithsonian Astrophysical Observation", "SAO 224916"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.49386589),
        dec: Angle.Degrees(-44.82309851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33331"},
        {"Hipparcos Number", "HIP 23833"},
        {"Fundamental Katalog 5th Edition", "FK5 1143"},
        {"Geneva Identification System", "GEN# +1.00033331"},
        {"Renson", "Renson 8510"},
        {"Smithsonian Astrophysical Observation", "SAO 217185"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.85801004),
        dec: Angle.Degrees(-44.82172000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11988"},
        {"Hipparcos Number", "HIP 9050"},
        {"Smithsonian Astrophysical Observation", "SAO 215708"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.14946415),
        dec: Angle.Degrees(-44.81994916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105381"},
        {"Hipparcos Number", "HIP 59166"},
        {"Geneva Identification System", "GEN# +1.00105381"},
        {"Smithsonian Astrophysical Observation", "SAO 223232"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.00343085),
        dec: Angle.Degrees(-44.81945245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83090"},
        {"Hipparcos Number", "HIP 46996"},
        {"Smithsonian Astrophysical Observation", "SAO 221300"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.67750789),
        dec: Angle.Degrees(-44.81626300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3584"},
        {"Hipparcos Number", "HIP 3016"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.59813028),
        dec: Angle.Degrees(-44.81608241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59367"},
        {"Hipparcos Number", "HIP 36216"},
        {"Smithsonian Astrophysical Observation", "SAO 218737"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.87711943),
        dec: Angle.Degrees(-44.81589553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147124"},
        {"Hipparcos Number", "HIP 80168"},
        {"Smithsonian Astrophysical Observation", "SAO 226687"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.47909014),
        dec: Angle.Degrees(-44.81560383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148259"},
        {"Hipparcos Number", "HIP 80721"},
        {"Geneva Identification System", "GEN# +1.00148259"},
        {"Smithsonian Astrophysical Observation", "SAO 226801"},
        {"Wilson Evans Batten Catalogue", "WEB 13652"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.20786603),
        dec: Angle.Degrees(-44.81261043)
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
    primaryId: "HIP 48627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86069"},
        {"Hipparcos Number", "HIP 48627"},
        {"Geneva Identification System", "GEN# +1.00086069"},
        {"Smithsonian Astrophysical Observation", "SAO 221600"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.74125550),
        dec: Angle.Degrees(-44.81094953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78097"},
        {"Hipparcos Number", "HIP 44562"},
        {"Geneva Identification System", "GEN# +1.00078097"},
        {"Smithsonian Astrophysical Observation", "SAO 220815"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.19542071),
        dec: Angle.Degrees(-44.81038473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94973"},
        {"Hipparcos Number", "HIP 53542"},
        {"Geneva Identification System", "GEN# +1.00094973"},
        {"Smithsonian Astrophysical Observation", "SAO 222444"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.29697128),
        dec: Angle.Degrees(-44.80971752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16022"},
        {"Hipparcos Number", "HIP 11858"},
        {"Smithsonian Astrophysical Observation", "SAO 215940"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.26103531),
        dec: Angle.Degrees(-44.80964270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203985"},
        {"Hipparcos Number", "HIP 105911"},
        {"Geneva Identification System", "GEN# +1.00203985"},
        {"Smithsonian Astrophysical Observation", "SAO 230691"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.75462752),
        dec: Angle.Degrees(-44.80901766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 184.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6797"},
        {"Hipparcos Number", "HIP 5320"},
        {"Smithsonian Astrophysical Observation", "SAO 215377"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.00653646),
        dec: Angle.Degrees(-44.80828998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127273"},
        {"Hipparcos Number", "HIP 71046"},
        {"Smithsonian Astrophysical Observation", "SAO 224997"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.94609122),
        dec: Angle.Degrees(-44.80668197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10003"},
        {"Hipparcos Number", "HIP 7503"},
        {"Geneva Identification System", "GEN# +1.00010003"},
        {"Smithsonian Astrophysical Observation", "SAO 215579"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.17277883),
        dec: Angle.Degrees(-44.80550292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121790"},
        {"Hipparcos Number", "HIP 68282"},
        {"Celescope Catalog", "CEL 4291"},
        {"Fundamental Katalog 5th Edition", "FK5 3112"},
        {"Geneva Identification System", "GEN# +1.00121790"},
        {"Smithsonian Astrophysical Observation", "SAO 224585"},
        {"Wilson Evans Batten Catalogue", "WEB 11980"},
    },
    visualMagnitude: 3.87,
    bvColour: -0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.66988070),
        dec: Angle.Degrees(-44.80353140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11279"},
        {"Hipparcos Number", "HIP 8510"},
        {"Smithsonian Astrophysical Observation", "SAO 215671"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.43621312),
        dec: Angle.Degrees(-44.80314213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38939B"},
        {"Hipparcos Number", "HIP 27297"},
        {"Smithsonian Astrophysical Observation", "SAO 217532"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.75891145),
        dec: Angle.Degrees(-44.80259658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82183"},
        {"Hipparcos Number", "HIP 46507"},
        {"Geneva Identification System", "GEN# +1.00082183"},
        {"Smithsonian Astrophysical Observation", "SAO 221209"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.27840493),
        dec: Angle.Degrees(-44.80128758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38939"},
        {"Hipparcos Number", "HIP 27294"},
        {"Smithsonian Astrophysical Observation", "SAO 217531"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.75177163),
        dec: Angle.Degrees(-44.80020389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95294",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Arkab Posterior"},
        {"Henry Draper", "HD 181623"},
        {"Hipparcos Number", "HIP 95294"},
        {"Geneva Identification System", "GEN# +1.00181623"},
        {"Smithsonian Astrophysical Observation", "SAO 229654"},
        {"Wilson Evans Batten Catalogue", "WEB 16651"},
    },
    visualMagnitude: 4.27,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.80441920),
        dec: Angle.Degrees(-44.79964788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54476"},
        {"Hipparcos Number", "HIP 34305"},
        {"Geneva Identification System", "GEN# +1.00054476"},
        {"Smithsonian Astrophysical Observation", "SAO 218461"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.68799308),
        dec: Angle.Degrees(-44.79916266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217747"},
        {"Hipparcos Number", "HIP 113857"},
        {"Smithsonian Astrophysical Observation", "SAO 231413"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.86506108),
        dec: Angle.Degrees(-44.79881035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3750"},
        {"Hipparcos Number", "HIP 3137"},
        {"Geneva Identification System", "GEN# +1.00003750"},
        {"Smithsonian Astrophysical Observation", "SAO 215185"},
    },
    visualMagnitude: 6.00,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.96631161),
        dec: Angle.Degrees(-44.79633326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327602"},
        {"Hipparcos Number", "HIP 78320"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.87181397),
        dec: Angle.Degrees(-44.79495607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186897"},
        {"Hipparcos Number", "HIP 97495"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.24226243),
        dec: Angle.Degrees(-44.79463979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135709"},
        {"Hipparcos Number", "HIP 74878"},
        {"Smithsonian Astrophysical Observation", "SAO 225630"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.54522389),
        dec: Angle.Degrees(-44.79351706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163358"},
        {"Hipparcos Number", "HIP 87947"},
        {"Smithsonian Astrophysical Observation", "SAO 228579"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.48989075),
        dec: Angle.Degrees(-44.79221810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157063"},
        {"Hipparcos Number", "HIP 85075"},
        {"Geneva Identification System", "GEN# +1.00157063"},
        {"Renson", "Renson 44170"},
        {"Smithsonian Astrophysical Observation", "SAO 227888"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.80302272),
        dec: Angle.Degrees(-44.79147888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221859"},
        {"Hipparcos Number", "HIP 116455"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.95795324),
        dec: Angle.Degrees(-44.79081699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44665"},
        {"Hipparcos Number", "HIP 30158"},
        {"Smithsonian Astrophysical Observation", "SAO 217871"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.19450110),
        dec: Angle.Degrees(-44.78936684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 82.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223132"},
        {"Hipparcos Number", "HIP 117300"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.76144809),
        dec: Angle.Degrees(-44.78828227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29628"},
        {"Hipparcos Number", "HIP 21570"},
        {"Smithsonian Astrophysical Observation", "SAO 216905"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.46270014),
        dec: Angle.Degrees(-44.78154784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112288"},
        {"Hipparcos Number", "HIP 63133"},
        {"Smithsonian Astrophysical Observation", "SAO 223767"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.03004552),
        dec: Angle.Degrees(-44.78085976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24200"},
        {"Hipparcos Number", "HIP 17857"},
        {"Geneva Identification System", "GEN# +1.00024200"},
        {"Smithsonian Astrophysical Observation", "SAO 216503"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.33190801),
        dec: Angle.Degrees(-44.77993919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27602"},
        {"Hipparcos Number", "HIP 20167"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.83281888),
        dec: Angle.Degrees(-44.77991229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33115"},
        {"Hipparcos Number", "HIP 23713"},
        {"Smithsonian Astrophysical Observation", "SAO 217175"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.47440433),
        dec: Angle.Degrees(-44.77885861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155985"},
        {"Hipparcos Number", "HIP 84556"},
        {"Celescope Catalog", "CEL 4492"},
        {"Geneva Identification System", "GEN# +1.00155985"},
        {"Smithsonian Astrophysical Observation", "SAO 227778"},
        {"Wilson Evans Batten Catalogue", "WEB 14274"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.27308305),
        dec: Angle.Degrees(-44.77858705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122919"},
        {"Hipparcos Number", "HIP 68846"},
        {"Geneva Identification System", "GEN# +1.00122919"},
        {"Smithsonian Astrophysical Observation", "SAO 224669"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.45737048),
        dec: Angle.Degrees(-44.77780592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36447"},
        {"Hipparcos Number", "HIP 25723"},
        {"Smithsonian Astrophysical Observation", "SAO 217361"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.39474859),
        dec: Angle.Degrees(-44.77619598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44764"},
        {"Hipparcos Number", "HIP 30206"},
        {"Smithsonian Astrophysical Observation", "SAO 217876"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.33058421),
        dec: Angle.Degrees(-44.77366352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23591"},
        {"Hipparcos Number", "HIP 17452"},
        {"Smithsonian Astrophysical Observation", "SAO 216465"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.11662905),
        dec: Angle.Degrees(-44.77258890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197239"},
        {"Hipparcos Number", "HIP 102338"},
        {"Geneva Identification System", "GEN# +1.00197239"},
        {"Smithsonian Astrophysical Observation", "SAO 230342"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.03130788),
        dec: Angle.Degrees(-44.77197392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95337"},
        {"Hipparcos Number", "HIP 53749"},
        {"Smithsonian Astrophysical Observation", "SAO 222480"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.95544378),
        dec: Angle.Degrees(-44.77182241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222457"},
        {"Hipparcos Number", "HIP 116839"},
        {"Smithsonian Astrophysical Observation", "SAO 231733"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.23677300),
        dec: Angle.Degrees(-44.77087080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100425"},
        {"Hipparcos Number", "HIP 56353"},
        {"Smithsonian Astrophysical Observation", "SAO 222858"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.27017017),
        dec: Angle.Degrees(-44.77055611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66586"},
        {"Hipparcos Number", "HIP 39314"},
        {"Smithsonian Astrophysical Observation", "SAO 219329"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.57048957),
        dec: Angle.Degrees(-44.76980065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112593"},
        {"Hipparcos Number", "HIP 63294"},
    },
    visualMagnitude: 9.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.57307613),
        dec: Angle.Degrees(-44.76723905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160618"},
        {"Hipparcos Number", "HIP 86718"},
        {"Smithsonian Astrophysical Observation", "SAO 228323"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.78090967),
        dec: Angle.Degrees(-44.76674097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14298"},
        {"Hipparcos Number", "HIP 10676"},
        {"Smithsonian Astrophysical Observation", "SAO 215855"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.34051917),
        dec: Angle.Degrees(-44.76392610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63252"},
        {"Hipparcos Number", "HIP 37887"},
        {"Smithsonian Astrophysical Observation", "SAO 218971"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.47619403),
        dec: Angle.Degrees(-44.76170124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45633"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.52687367),
        dec: Angle.Degrees(-44.76023490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89231"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.13769198),
        dec: Angle.Degrees(-44.75899974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16371"},
        {"Hipparcos Number", "HIP 12117"},
        {"Geneva Identification System", "GEN# +1.00016371"},
        {"Smithsonian Astrophysical Observation", "SAO 215961"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.03086098),
        dec: Angle.Degrees(-44.75895423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44737"},
        {"Hipparcos Number", "HIP 30199"},
        {"Smithsonian Astrophysical Observation", "SAO 217873"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.29706739),
        dec: Angle.Degrees(-44.75859724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208603"},
        {"Hipparcos Number", "HIP 108475"},
        {"Geneva Identification System", "GEN# +1.00208603"},
        {"Smithsonian Astrophysical Observation", "SAO 230919"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.62088328),
        dec: Angle.Degrees(-44.75583829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84816"},
        {"Hipparcos Number", "HIP 47963"},
        {"Geneva Identification System", "GEN# +1.00084816"},
        {"Smithsonian Astrophysical Observation", "SAO 221484"},
        {"Wilson Evans Batten Catalogue", "WEB 8973"},
    },
    visualMagnitude: 5.58,
    bvColour: -0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.62658773),
        dec: Angle.Degrees(-44.75505925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200444"},
        {"Hipparcos Number", "HIP 104061"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.23571470),
        dec: Angle.Degrees(-44.75444281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183314"},
        {"Hipparcos Number", "HIP 95972"},
        {"Smithsonian Astrophysical Observation", "SAO 229725"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.74086521),
        dec: Angle.Degrees(-44.75425467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100818"},
        {"Geneva Identification System", "GEN# +6.20145055"},
    },
    visualMagnitude: 11.58,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.63371566),
        dec: Angle.Degrees(-44.75393626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173020"},
        {"Hipparcos Number", "HIP 92025"},
        {"Smithsonian Astrophysical Observation", "SAO 229247"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.36644062),
        dec: Angle.Degrees(-44.75366109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88564"},
    },
    visualMagnitude: 10.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.25314915),
        dec: Angle.Degrees(-44.75308753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192960"},
        {"Hipparcos Number", "HIP 100209"},
        {"Geneva Identification System", "GEN# +1.00192960"},
        {"Smithsonian Astrophysical Observation", "SAO 230153"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.87598538),
        dec: Angle.Degrees(-44.75284597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113009"},
        {"Hipparcos Number", "HIP 63541"},
        {"Geneva Identification System", "GEN# +1.00113009"},
        {"Smithsonian Astrophysical Observation", "SAO 223842"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.31297652),
        dec: Angle.Degrees(-44.75183260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83487"},
        {"Hipparcos Number", "HIP 47218"},
        {"Smithsonian Astrophysical Observation", "SAO 221352"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.35447212),
        dec: Angle.Degrees(-44.75151935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63948"},
        {"Hipparcos Number", "HIP 38183"},
        {"Geneva Identification System", "GEN# +1.00063948"},
        {"Smithsonian Astrophysical Observation", "SAO 219040"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.36797937),
        dec: Angle.Degrees(-44.75122662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69191"},
        {"Hipparcos Number", "HIP 40320"},
        {"Geneva Identification System", "GEN# +1.00069191"},
        {"Smithsonian Astrophysical Observation", "SAO 219639"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.49198082),
        dec: Angle.Degrees(-44.75102575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127236"},
        {"Hipparcos Number", "HIP 71023"},
        {"Smithsonian Astrophysical Observation", "SAO 224992"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.88922660),
        dec: Angle.Degrees(-44.75049811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108267"},
        {"Hipparcos Number", "HIP 60709"},
        {"Geneva Identification System", "GEN# +1.00108267"},
        {"Smithsonian Astrophysical Observation", "SAO 223439"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.63135719),
        dec: Angle.Degrees(-44.74876659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210471"},
        {"Hipparcos Number", "HIP 109565"},
        {"Geneva Identification System", "GEN# +1.00210471"},
        {"Smithsonian Astrophysical Observation", "SAO 231020"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.91977943),
        dec: Angle.Degrees(-44.74846198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223680"},
        {"Hipparcos Number", "HIP 117660"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.93031944),
        dec: Angle.Degrees(-44.74725637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213081"},
        {"Hipparcos Number", "HIP 111048"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.46015426),
        dec: Angle.Degrees(-44.74673321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195187"},
        {"Hipparcos Number", "HIP 101267"},
        {"Smithsonian Astrophysical Observation", "SAO 230253"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.89908030),
        dec: Angle.Degrees(-44.74646851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196141"},
        {"Hipparcos Number", "HIP 101726"},
        {"Geneva Identification System", "GEN# +1.00196141"},
        {"Smithsonian Astrophysical Observation", "SAO 230296"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.29804316),
        dec: Angle.Degrees(-44.74460488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72230"},
        {"Hipparcos Number", "HIP 41684"},
        {"Celescope Catalog", "CEL 2575"},
        {"Geneva Identification System", "GEN# +1.00072230"},
        {"Smithsonian Astrophysical Observation", "SAO 220009"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.46349376),
        dec: Angle.Degrees(-44.74345062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12277"},
        {"Hipparcos Number", "HIP 9284"},
        {"Geneva Identification System", "GEN# +1.00012277"},
        {"Smithsonian Astrophysical Observation", "SAO 215724"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.83037426),
        dec: Angle.Degrees(-44.74213181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156919"},
        {"Hipparcos Number", "HIP 84998"},
        {"Smithsonian Astrophysical Observation", "SAO 227877"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.59981319),
        dec: Angle.Degrees(-44.74175672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158175"},
        {"Hipparcos Number", "HIP 85628"},
        {"Celescope Catalog", "CEL 4522"},
        {"Geneva Identification System", "GEN# +1.00158175"},
        {"Renson", "Renson 44480"},
        {"Smithsonian Astrophysical Observation", "SAO 228029"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.46737736),
        dec: Angle.Degrees(-44.74161619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216866"},
        {"Hipparcos Number", "HIP 113325"},
        {"Smithsonian Astrophysical Observation", "SAO 231365"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.26408009),
        dec: Angle.Degrees(-44.73990858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9542"},
        {"Hipparcos Number", "HIP 7195"},
        {"Geneva Identification System", "GEN# +1.00009542"},
        {"Smithsonian Astrophysical Observation", "SAO 215550"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.18317750),
        dec: Angle.Degrees(-44.73901366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25138"},
        {"Hipparcos Number", "HIP 18526"},
        {"Geneva Identification System", "GEN# +1.00025138J"},
        {"Smithsonian Astrophysical Observation", "SAO 216578"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.42682117),
        dec: Angle.Degrees(-44.73853646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100228"},
        {"Hipparcos Number", "HIP 56228"},
        {"Smithsonian Astrophysical Observation", "SAO 222845"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.89819421),
        dec: Angle.Degrees(-44.73849046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14133"},
        {"Hipparcos Number", "HIP 10546"},
        {"Smithsonian Astrophysical Observation", "SAO 215841"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.96190637),
        dec: Angle.Degrees(-44.73761542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72350"},
        {"Hipparcos Number", "HIP 41737"},
        {"Celescope Catalog", "CEL 2591"},
        {"Geneva Identification System", "GEN# +1.00072350J"},
        {"Smithsonian Astrophysical Observation", "SAO 220025"},
        {"Wilson Evans Batten Catalogue", "WEB 8045"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.66349041),
        dec: Angle.Degrees(-44.73733165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144736"},
        {"Hipparcos Number", "HIP 79136"},
        {"Smithsonian Astrophysical Observation", "SAO 226538"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.29388995),
        dec: Angle.Degrees(-44.73324011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18672"},
        {"Hipparcos Number", "HIP 13866"},
        {"Smithsonian Astrophysical Observation", "SAO 216118"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.64231059),
        dec: Angle.Degrees(-44.73319976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25843"},
        {"Hipparcos Number", "HIP 18959"},
        {"Geneva Identification System", "GEN# +1.00025843"},
        {"Renson", "Renson 6570"},
        {"Smithsonian Astrophysical Observation", "SAO 216624"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.93813263),
        dec: Angle.Degrees(-44.73299155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16635"},
        {"Hipparcos Number", "HIP 12308"},
        {"Geneva Identification System", "GEN# +1.00016635"},
        {"Smithsonian Astrophysical Observation", "SAO 215982"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.62631693),
        dec: Angle.Degrees(-44.73289975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124435"},
        {"Hipparcos Number", "HIP 69604"},
        {"Smithsonian Astrophysical Observation", "SAO 224790"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.68874621),
        dec: Angle.Degrees(-44.73064019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28199"},
        {"Hipparcos Number", "HIP 20611"},
        {"Smithsonian Astrophysical Observation", "SAO 216789"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.22485828),
        dec: Angle.Degrees(-44.72951131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42304"},
        {"Hipparcos Number", "HIP 29057"},
        {"Geneva Identification System", "GEN# +1.00042304"},
        {"Smithsonian Astrophysical Observation", "SAO 217729"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.94579595),
        dec: Angle.Degrees(-44.72938592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88590"},
        {"Hipparcos Number", "HIP 49951"},
        {"Geneva Identification System", "GEN# +1.00088590"},
        {"Smithsonian Astrophysical Observation", "SAO 221852"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.97923667),
        dec: Angle.Degrees(-44.72876573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54503"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.25650384),
        dec: Angle.Degrees(-44.72552983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218859"},
        {"Hipparcos Number", "HIP 114528"},
        {"Smithsonian Astrophysical Observation", "SAO 231484"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.96330683),
        dec: Angle.Degrees(-44.72539935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210023"},
        {"Hipparcos Number", "HIP 109292"},
        {"Geneva Identification System", "GEN# +1.00210023"},
        {"Smithsonian Astrophysical Observation", "SAO 230997"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.11107552),
        dec: Angle.Degrees(-44.72522493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72127"},
        {"Hipparcos Number", "HIP 41639"},
        {"Celescope Catalog", "CEL 2564"},
        {"Geneva Identification System", "GEN# +1.00072127J"},
        {"Wilson Evans Batten Catalogue", "WEB 8036"},
    },
    visualMagnitude: 5.03,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.36453332),
        dec: Angle.Degrees(-44.72482773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200501"},
        {"Hipparcos Number", "HIP 104099"},
        {"Smithsonian Astrophysical Observation", "SAO 230514"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.35258835),
        dec: Angle.Degrees(-44.72416723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138907"},
        {"Hipparcos Number", "HIP 76447"},
        {"Smithsonian Astrophysical Observation", "SAO 225971"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.19406536),
        dec: Angle.Degrees(-44.72254352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75790"},
        {"Hipparcos Number", "HIP 43388"},
        {"Geneva Identification System", "GEN# +1.00075790J"},
        {"Smithsonian Astrophysical Observation", "SAO 220555"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.57893641),
        dec: Angle.Degrees(-44.72113921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140011"},
        {"Hipparcos Number", "HIP 76990"},
        {"Smithsonian Astrophysical Observation", "SAO 226108"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.79995695),
        dec: Angle.Degrees(-44.71974881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224286"},
        {"Hipparcos Number", "HIP 118045"},
        {"Geneva Identification System", "GEN# +1.00224286"},
        {"Smithsonian Astrophysical Observation", "SAO 231858"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.16095046),
        dec: Angle.Degrees(-44.71889537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111235"},
        {"Hipparcos Number", "HIP 62483"},
        {"Geneva Identification System", "GEN# +1.00111235"},
        {"Smithsonian Astrophysical Observation", "SAO 223677"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.06871443),
        dec: Angle.Degrees(-44.71875254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138326"},
        {"Hipparcos Number", "HIP 76148"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.30074724),
        dec: Angle.Degrees(-44.71727418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97146",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97146"},
    },
    visualMagnitude: 10.90,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.17570807),
        dec: Angle.Degrees(-44.71373896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 203.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210836"},
        {"Hipparcos Number", "HIP 109782"},
        {"Smithsonian Astrophysical Observation", "SAO 231043"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.55144487),
        dec: Angle.Degrees(-44.71355113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12524"},
        {"Hipparcos Number", "HIP 9459"},
        {"Fundamental Katalog 5th Edition", "FK5 2138"},
        {"Geneva Identification System", "GEN# +1.00012524"},
        {"Smithsonian Astrophysical Observation", "SAO 215739"},
        {"Wilson Evans Batten Catalogue", "WEB 1983"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.42667654),
        dec: Angle.Degrees(-44.71339037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84743"},
        {"Hipparcos Number", "HIP 47918"},
        {"Geneva Identification System", "GEN# +1.00084743"},
        {"Smithsonian Astrophysical Observation", "SAO 221473"},
        {"Wilson Evans Batten Catalogue", "WEB 8965"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.49849150),
        dec: Angle.Degrees(-44.71329916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117288"},
        {"Hipparcos Number", "HIP 65870"},
        {"Smithsonian Astrophysical Observation", "SAO 224194"},
        {"Smithsonian Astrophysical Observation 2", "SAO 224195"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.51723434),
        dec: Angle.Degrees(-44.71255072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151112"},
        {"Hipparcos Number", "HIP 82178"},
        {"Smithsonian Astrophysical Observation", "SAO 227207"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.84083345),
        dec: Angle.Degrees(-44.71193454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16634"},
        {"Hipparcos Number", "HIP 12309"},
        {"Fundamental Katalog 5th Edition", "FK5 4242"},
        {"Geneva Identification System", "GEN# +1.00016634"},
        {"Smithsonian Astrophysical Observation", "SAO 215983"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.62919878),
        dec: Angle.Degrees(-44.70765231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129529"},
        {"Hipparcos Number", "HIP 72065"},
        {"Smithsonian Astrophysical Observation", "SAO 225152"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.10914742),
        dec: Angle.Degrees(-44.70756292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93355"},
        {"Hipparcos Number", "HIP 52653"},
        {"Smithsonian Astrophysical Observation", "SAO 222308"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.50586104),
        dec: Angle.Degrees(-44.70476802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115236"},
        {"Hipparcos Number", "HIP 64778"},
        {"Geneva Identification System", "GEN# +1.00115236"},
        {"Smithsonian Astrophysical Observation", "SAO 224021"},
    },
    visualMagnitude: 6.85,
    bvColour: 2.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.13268799),
        dec: Angle.Degrees(-44.70437723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131637"},
        {"Hipparcos Number", "HIP 73102"},
        {"Celescope Catalog", "CEL 4326"},
        {"Geneva Identification System", "GEN# +1.00131637"},
        {"Smithsonian Astrophysical Observation", "SAO 225304"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.10332478),
        dec: Angle.Degrees(-44.70423785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16536"},
        {"Geneva Identification System", "GEN# -0.04501184"},
    },
    visualMagnitude: 11.47,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.23380442),
        dec: Angle.Degrees(-44.70227047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -311.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53418"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.90395184),
        dec: Angle.Degrees(-44.70076356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154454"},
        {"Hipparcos Number", "HIP 83807"},
        {"Fundamental Katalog 5th Edition", "FK5 5509"},
        {"Geneva Identification System", "GEN# +1.00154454"},
        {"Smithsonian Astrophysical Observation", "SAO 227643"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.91431816),
        dec: Angle.Degrees(-44.69989592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21325"},
        {"Hipparcos Number", "HIP 15888"},
        {"Smithsonian Astrophysical Observation", "SAO 216303"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.15724314),
        dec: Angle.Degrees(-44.69840606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131544"},
        {"Hipparcos Number", "HIP 73057"},
        {"Geneva Identification System", "GEN# +1.00131544"},
        {"Smithsonian Astrophysical Observation", "SAO 225297"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.95184254),
        dec: Angle.Degrees(-44.69669188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113584"},
        {"Hipparcos Number", "HIP 63863"},
        {"Renson", "Renson 32930"},
        {"Smithsonian Astrophysical Observation", "SAO 223890"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.32186574),
        dec: Angle.Degrees(-44.69603029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140759"},
        {"Hipparcos Number", "HIP 77333"},
        {"Smithsonian Astrophysical Observation", "SAO 226196"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.81939397),
        dec: Angle.Degrees(-44.69600160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208117"},
        {"Hipparcos Number", "HIP 108194"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.79719366),
        dec: Angle.Degrees(-44.69360443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60906"},
        {"Hipparcos Number", "HIP 36863"},
        {"Smithsonian Astrophysical Observation", "SAO 218817"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.68225222),
        dec: Angle.Degrees(-44.69205360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100003"},
        {"Hipparcos Number", "HIP 56104"},
        {"Smithsonian Astrophysical Observation", "SAO 222821"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.50315983),
        dec: Angle.Degrees(-44.69076637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213658"},
        {"Hipparcos Number", "HIP 111382"},
        {"Geneva Identification System", "GEN# +1.00213658"},
        {"Smithsonian Astrophysical Observation", "SAO 231192"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.47790597),
        dec: Angle.Degrees(-44.69032848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87538"},
        {"Hipparcos Number", "HIP 49357"},
        {"Smithsonian Astrophysical Observation", "SAO 221752"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.13957876),
        dec: Angle.Degrees(-44.69000497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136504"},
        {"Hipparcos Number", "HIP 75264"},
        {"Celescope Catalog", "CEL 4368"},
        {"Geneva Identification System", "GEN# +1.00136504"},
        {"Smithsonian Astrophysical Observation", "SAO 225712"},
        {"Wilson Evans Batten Catalogue", "WEB 12838"},
    },
    visualMagnitude: 3.37,
    bvColour: -0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.67036465),
        dec: Angle.Degrees(-44.68957314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122982"},
        {"Hipparcos Number", "HIP 68867"},
        {"Geneva Identification System", "GEN# +1.00122982"},
        {"Smithsonian Astrophysical Observation", "SAO 224674"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.53439671),
        dec: Angle.Degrees(-44.68903932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328044"},
        {"Hipparcos Number", "HIP 80145"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.39058962),
        dec: Angle.Degrees(-44.68883288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55476"},
        {"Hipparcos Number", "HIP 34675"},
        {"Smithsonian Astrophysical Observation", "SAO 218511"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.71397726),
        dec: Angle.Degrees(-44.68756965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94590"},
        {"Hipparcos Number", "HIP 53343"},
        {"Geneva Identification System", "GEN# +1.00094590"},
        {"Smithsonian Astrophysical Observation", "SAO 222416"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.64432275),
        dec: Angle.Degrees(-44.68740094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38175",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38175"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.33645726),
        dec: Angle.Degrees(-44.68643970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155619"},
        {"Hipparcos Number", "HIP 84368"},
        {"Smithsonian Astrophysical Observation", "SAO 227742"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.72837797),
        dec: Angle.Degrees(-44.68262095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39280"},
        {"Hipparcos Number", "HIP 27499"},
        {"Geneva Identification System", "GEN# +1.00039280"},
        {"Smithsonian Astrophysical Observation", "SAO 217557"},
        {"Wilson Evans Batten Catalogue", "WEB 5401"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.34322920),
        dec: Angle.Degrees(-44.68259715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143464"},
        {"Hipparcos Number", "HIP 78556"},
        {"Geneva Identification System", "GEN# +1.00143464"},
        {"Smithsonian Astrophysical Observation", "SAO 226458"},
        {"Wilson Evans Batten Catalogue", "WEB 13279"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.58967883),
        dec: Angle.Degrees(-44.68151465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108049"},
        {"Hipparcos Number", "HIP 60583"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.26306667),
        dec: Angle.Degrees(-44.68082615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26854"},
        {"Hipparcos Number", "HIP 19656"},
        {"Geneva Identification System", "GEN# +1.00026854"},
        {"Smithsonian Astrophysical Observation", "SAO 216698"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.17982080),
        dec: Angle.Degrees(-44.68081946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189121"},
        {"Hipparcos Number", "HIP 98472"},
        {"Geneva Identification System", "GEN# +1.00189121"},
        {"Smithsonian Astrophysical Observation", "SAO 229975"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.08623321),
        dec: Angle.Degrees(-44.68056527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32137"},
        {"Hipparcos Number", "HIP 23152"},
        {"Smithsonian Astrophysical Observation", "SAO 217096"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.72037501),
        dec: Angle.Degrees(-44.67706764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110621"},
        {"Hipparcos Number", "HIP 62108"},
        {"Geneva Identification System", "GEN# +1.00110621"},
        {"Smithsonian Astrophysical Observation", "SAO 223628"},
        {"Wilson Evans Batten Catalogue", "WEB 11039"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.93084437),
        dec: Angle.Degrees(-44.67539091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109409"},
        {"Hipparcos Number", "HIP 61379"},
        {"Geneva Identification System", "GEN# +1.00109409"},
        {"Smithsonian Astrophysical Observation", "SAO 223527"},
        {"Wilson Evans Batten Catalogue", "WEB 10924"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.67690229),
        dec: Angle.Degrees(-44.67251655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -206.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8501"},
        {"Hipparcos Number", "HIP 6475"},
        {"Geneva Identification System", "GEN# +1.00008501"},
        {"Smithsonian Astrophysical Observation", "SAO 215483"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.81941375),
        dec: Angle.Degrees(-44.67154830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66605"},
        {"Hipparcos Number", "HIP 39329"},
        {"Renson", "Renson 18400"},
        {"Smithsonian Astrophysical Observation", "SAO 219333"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.61291484),
        dec: Angle.Degrees(-44.66699691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69883"},
        {"Hipparcos Number", "HIP 40583"},
        {"Celescope Catalog", "CEL 2317"},
        {"Geneva Identification System", "GEN# +1.00069883"},
        {"Smithsonian Astrophysical Observation", "SAO 219732"},
    },
    visualMagnitude: 8.91,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.29779208),
        dec: Angle.Degrees(-44.66678915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 563"},
        {"Hipparcos Number", "HIP 805"},
        {"Geneva Identification System", "GEN# +1.00000563"},
        {"Smithsonian Astrophysical Observation", "SAO 214987"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.48641063),
        dec: Angle.Degrees(-44.66648659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205934"},
        {"Hipparcos Number", "HIP 106971"},
        {"Smithsonian Astrophysical Observation", "SAO 230779"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.97526853),
        dec: Angle.Degrees(-44.66573013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103452"},
        {"Hipparcos Number", "HIP 58077"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.65143400),
        dec: Angle.Degrees(-44.66505767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129623"},
        {"Hipparcos Number", "HIP 72106"},
        {"Geneva Identification System", "GEN# +1.00129623"},
        {"Smithsonian Astrophysical Observation", "SAO 225159"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.24965727),
        dec: Angle.Degrees(-44.66499777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164748"},
        {"Hipparcos Number", "HIP 88553"},
        {"Geneva Identification System", "GEN# +1.00164748"},
        {"Smithsonian Astrophysical Observation", "SAO 228678"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.22376463),
        dec: Angle.Degrees(-44.66220140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139664"},
        {"Hipparcos Number", "HIP 76829"},
        {"Geneva Identification System", "GEN# +1.00139664"},
        {"Smithsonian Astrophysical Observation", "SAO 226064"},
        {"Wilson Evans Batten Catalogue", "WEB 13033"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.29798226),
        dec: Angle.Degrees(-44.66055926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -168.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -265.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125649"},
        {"Hipparcos Number", "HIP 70229"},
        {"Fundamental Katalog 5th Edition", "FK5 5268"},
        {"Geneva Identification System", "GEN# +1.00125649"},
        {"Smithsonian Astrophysical Observation", "SAO 224867"},
        {"Wilson Evans Batten Catalogue", "WEB 12194"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.51449785),
        dec: Angle.Degrees(-44.65865063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9404"},
        {"Hipparcos Number", "HIP 7099"},
        {"Geneva Identification System", "GEN# +1.00009404"},
        {"Smithsonian Astrophysical Observation", "SAO 215537"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.87346957),
        dec: Angle.Degrees(-44.65601374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17125"},
        {"Hipparcos Number", "HIP 12712"},
        {"Smithsonian Astrophysical Observation", "SAO 216020"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.84463171),
        dec: Angle.Degrees(-44.65384421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134158"},
        {"Hipparcos Number", "HIP 74208"},
        {"Smithsonian Astrophysical Observation", "SAO 225495"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.46718385),
        dec: Angle.Degrees(-44.65294228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149852"},
        {"Hipparcos Number", "HIP 81547"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.83007607),
        dec: Angle.Degrees(-44.65199664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1345"},
        {"Hipparcos Number", "HIP 1391"},
        {"Geneva Identification System", "GEN# +1.00001345"},
        {"Smithsonian Astrophysical Observation", "SAO 215037"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.34964232),
        dec: Angle.Degrees(-44.65127253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166677"},
        {"Hipparcos Number", "HIP 89353"},
        {"Smithsonian Astrophysical Observation", "SAO 228827"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.49798108),
        dec: Angle.Degrees(-44.65117166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47445"},
        {"Hipparcos Number", "HIP 31573"},
        {"Geneva Identification System", "GEN# +1.00047445"},
        {"Smithsonian Astrophysical Observation", "SAO 218058"},
    },
    visualMagnitude: 8.93,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.12025985),
        dec: Angle.Degrees(-44.65115741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1107"},
        {"Hipparcos Number", "HIP 1212"},
        {"Smithsonian Astrophysical Observation", "SAO 215019"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.78995406),
        dec: Angle.Degrees(-44.65056308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222985"},
        {"Hipparcos Number", "HIP 117193"},
        {"Smithsonian Astrophysical Observation", "SAO 231764"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.43648272),
        dec: Angle.Degrees(-44.65018949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223887"},
        {"Hipparcos Number", "HIP 117802"},
        {"Smithsonian Astrophysical Observation", "SAO 231829"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.35658211),
        dec: Angle.Degrees(-44.64977798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1806"},
        {"Hipparcos Number", "HIP 1761"},
        {"Smithsonian Astrophysical Observation", "SAO 215068"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.58009970),
        dec: Angle.Degrees(-44.64900652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114068"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.53053741),
        dec: Angle.Degrees(-44.64625355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185218"},
        {"Hipparcos Number", "HIP 96748"},
        {"Smithsonian Astrophysical Observation", "SAO 229804"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.01149768),
        dec: Angle.Degrees(-44.64600124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98892"},
        {"Hipparcos Number", "HIP 55528"},
        {"Geneva Identification System", "GEN# +1.00098892"},
        {"Smithsonian Astrophysical Observation", "SAO 222751"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.59644589),
        dec: Angle.Degrees(-44.64584748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22435"},
        {"Hipparcos Number", "HIP 16696"},
        {"Geneva Identification System", "GEN# +1.00022435"},
        {"Smithsonian Astrophysical Observation", "SAO 216388"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.70453964),
        dec: Angle.Degrees(-44.64338876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77740"},
        {"Hipparcos Number", "HIP 44410"},
        {"Celescope Catalog", "CEL 3162"},
        {"Geneva Identification System", "GEN# +1.00077740"},
        {"Smithsonian Astrophysical Observation", "SAO 220777"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.69292774),
        dec: Angle.Degrees(-44.64266626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172836"},
        {"Hipparcos Number", "HIP 91939"},
        {"Smithsonian Astrophysical Observation", "SAO 229234"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.12729591),
        dec: Angle.Degrees(-44.64179025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101371"},
        {"Hipparcos Number", "HIP 56887"},
        {"Smithsonian Astrophysical Observation", "SAO 222936"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.93631161),
        dec: Angle.Degrees(-44.64175762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56096"},
        {"Hipparcos Number", "HIP 34922"},
        {"Geneva Identification System", "GEN# +1.00056096"},
        {"Smithsonian Astrophysical Observation", "SAO 218549"},
        {"Wilson Evans Batten Catalogue", "WEB 6981"},
    },
    visualMagnitude: 4.42,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.38429537),
        dec: Angle.Degrees(-44.64052957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 325.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328900"},
        {"Hipparcos Number", "HIP 82507"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.95067864),
        dec: Angle.Degrees(-44.64052496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189855"},
        {"Hipparcos Number", "HIP 98798"},
        {"Geneva Identification System", "GEN# +1.00189855"},
        {"Smithsonian Astrophysical Observation", "SAO 230018"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.99215484),
        dec: Angle.Degrees(-44.63864115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3157"},
        {"Hipparcos Number", "HIP 2714"},
        {"Smithsonian Astrophysical Observation", "SAO 215149"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.62727996),
        dec: Angle.Degrees(-44.63737285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69257"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.67342565),
        dec: Angle.Degrees(-44.63563711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160797"},
        {"Hipparcos Number", "HIP 86788"},
        {"Celescope Catalog", "CEL 4558"},
        {"Geneva Identification System", "GEN# +1.00160797"},
        {"Smithsonian Astrophysical Observation", "SAO 228347"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.01007225),
        dec: Angle.Degrees(-44.63525415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53199"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.20920844),
        dec: Angle.Degrees(-44.63397358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213774"},
        {"Hipparcos Number", "HIP 111447"},
        {"Geneva Identification System", "GEN# +1.00213774"},
        {"Smithsonian Astrophysical Observation", "SAO 231198"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.66419930),
        dec: Angle.Degrees(-44.63383698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74752"},
        {"Hipparcos Number", "HIP 42861"},
        {"Smithsonian Astrophysical Observation", "SAO 220366"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.01508441),
        dec: Angle.Degrees(-44.63376245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78616"},
        {"Hipparcos Number", "HIP 44790"},
        {"Celescope Catalog", "CEL 3194"},
        {"Geneva Identification System", "GEN# +1.00078616J"},
        {"Smithsonian Astrophysical Observation", "SAO 220873"},
        {"Wilson Evans Batten Catalogue", "WEB 8562"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.92717183),
        dec: Angle.Degrees(-44.63245555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62318"},
        {"Hipparcos Number", "HIP 37461"},
        {"Celescope Catalog", "CEL 1983"},
        {"Geneva Identification System", "GEN# +1.00062318"},
        {"Smithsonian Astrophysical Observation", "SAO 218905"},
    },
    visualMagnitude: 6.41,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.34051593),
        dec: Angle.Degrees(-44.63217873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28160"},
        {"Smithsonian Astrophysical Observation", "SAO 150967"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.26017079),
        dec: Angle.Degrees(-13.87451357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157624"},
        {"Hipparcos Number", "HIP 85357"},
        {"Celescope Catalog", "CEL 4513"},
        {"Geneva Identification System", "GEN# +1.00157624"},
        {"Smithsonian Astrophysical Observation", "SAO 227962"},
    },
    visualMagnitude: 7.88,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.63300312),
        dec: Angle.Degrees(-44.62936018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100191"},
        {"Hipparcos Number", "HIP 56214"},
        {"Smithsonian Astrophysical Observation", "SAO 222839"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.85313423),
        dec: Angle.Degrees(-44.62806121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29667"},
        {"Hipparcos Number", "HIP 21593"},
        {"Fundamental Katalog 5th Edition", "FK5 4417"},
        {"Geneva Identification System", "GEN# +1.00029667"},
        {"Smithsonian Astrophysical Observation", "SAO 216908"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.54279909),
        dec: Angle.Degrees(-44.62641363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45571"},
        {"Hipparcos Number", "HIP 30615"},
        {"Smithsonian Astrophysical Observation", "SAO 217923"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.51084798),
        dec: Angle.Degrees(-44.62603692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95630"},
        {"Hipparcos Number", "HIP 53900"},
        {"Smithsonian Astrophysical Observation", "SAO 222503"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.42718112),
        dec: Angle.Degrees(-44.62561082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183338"},
        {"Hipparcos Number", "HIP 95990"},
        {"Geneva Identification System", "GEN# +1.00183338"},
        {"Smithsonian Astrophysical Observation", "SAO 229726"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.77372084),
        dec: Angle.Degrees(-44.62432216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22000"},
        {"Hipparcos Number", "HIP 16375"},
        {"Smithsonian Astrophysical Observation", "SAO 216360"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.74367955),
        dec: Angle.Degrees(-44.62385310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139598"},
        {"Hipparcos Number", "HIP 76799"},
        {"Smithsonian Astrophysical Observation", "SAO 226058"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.21434438),
        dec: Angle.Degrees(-44.62273076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24392"},
        {"Hipparcos Number", "HIP 18005"},
        {"Geneva Identification System", "GEN# +1.00024392"},
        {"Smithsonian Astrophysical Observation", "SAO 216518"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.74319719),
        dec: Angle.Degrees(-44.62232326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7581"},
        {"Hipparcos Number", "HIP 5861"},
        {"Geneva Identification System", "GEN# +1.00007581"},
        {"Smithsonian Astrophysical Observation", "SAO 215429"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.79321394),
        dec: Angle.Degrees(-44.62143273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136185"},
        {"Hipparcos Number", "HIP 75109"},
        {"Smithsonian Astrophysical Observation", "SAO 225681"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.22165761),
        dec: Angle.Degrees(-44.62107181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71787"},
        {"Hipparcos Number", "HIP 41466"},
        {"Geneva Identification System", "GEN# +1.00071787"},
        {"Smithsonian Astrophysical Observation", "SAO 219951"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.87512130),
        dec: Angle.Degrees(-44.62075496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65248"},
        {"Hipparcos Number", "HIP 38746"},
        {"Smithsonian Astrophysical Observation", "SAO 219161"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.98239716),
        dec: Angle.Degrees(-44.62047535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43789"},
        {"Hipparcos Number", "HIP 29753"},
        {"Smithsonian Astrophysical Observation", "SAO 217817"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.98571270),
        dec: Angle.Degrees(-44.61965637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91437"},
        {"Hipparcos Number", "HIP 51610"},
        {"Geneva Identification System", "GEN# +1.00091437"},
        {"Smithsonian Astrophysical Observation", "SAO 222129"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.14008597),
        dec: Angle.Degrees(-44.61845030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86938"},
    },
    visualMagnitude: 11.91,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.47215672),
        dec: Angle.Degrees(-13.30643178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23770"},
        {"Hipparcos Number", "HIP 17574"},
        {"Smithsonian Astrophysical Observation", "SAO 216474"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.45636639),
        dec: Angle.Degrees(-44.61827955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58238"},
        {"Hipparcos Number", "HIP 35767"},
        {"Celescope Catalog", "CEL 1817"},
        {"Geneva Identification System", "GEN# +1.00058238"},
        {"Smithsonian Astrophysical Observation", "SAO 218678"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.66180316),
        dec: Angle.Degrees(-44.61782423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37597"},
        {"Hipparcos Number", "HIP 26423"},
        {"Smithsonian Astrophysical Observation", "SAO 217434"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.35575905),
        dec: Angle.Degrees(-44.61591146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83181"},
        {"Hipparcos Number", "HIP 47045"},
        {"Renson", "Renson 23720"},
        {"Smithsonian Astrophysical Observation", "SAO 221305"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.81704068),
        dec: Angle.Degrees(-44.61466212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122613"},
        {"Hipparcos Number", "HIP 68717"},
        {"Smithsonian Astrophysical Observation", "SAO 224647"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.00838050),
        dec: Angle.Degrees(-44.61442870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111229",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111229"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.03289006),
        dec: Angle.Degrees(-44.61101170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84460"},
        {"Hipparcos Number", "HIP 47755"},
        {"Smithsonian Astrophysical Observation", "SAO 221436"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.03118221),
        dec: Angle.Degrees(-44.61066449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161157"},
        {"Hipparcos Number", "HIP 86956"},
        {"Geneva Identification System", "GEN# +1.00161157"},
        {"Smithsonian Astrophysical Observation", "SAO 228392"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.53638140),
        dec: Angle.Degrees(-44.60932705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191827"},
        {"Hipparcos Number", "HIP 99678"},
        {"Smithsonian Astrophysical Observation", "SAO 230109"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.41825802),
        dec: Angle.Degrees(-44.60866518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49421"},
        {"Hipparcos Number", "HIP 32437"},
        {"Geneva Identification System", "GEN# +1.00049421"},
        {"Smithsonian Astrophysical Observation", "SAO 218181"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.55668703),
        dec: Angle.Degrees(-44.60843135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2546"},
        {"Hipparcos Number", "HIP 2266"},
        {"Smithsonian Astrophysical Observation", "SAO 215108"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.21715947),
        dec: Angle.Degrees(-44.60687716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18198"},
        {"Hipparcos Number", "HIP 13498"},
        {"Smithsonian Astrophysical Observation", "SAO 216086"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.46275848),
        dec: Angle.Degrees(-44.60579733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215877"},
        {"Hipparcos Number", "HIP 112663"},
        {"Geneva Identification System", "GEN# +1.00215877"},
        {"Smithsonian Astrophysical Observation", "SAO 231311"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.24367125),
        dec: Angle.Degrees(-44.60387545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6836"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.99998423),
        dec: Angle.Degrees(-44.60378441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 123.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83954"},
        {"Hipparcos Number", "HIP 47458"},
        {"Smithsonian Astrophysical Observation", "SAO 221395"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.11854453),
        dec: Angle.Degrees(-44.60153839)
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
    primaryId: "HIP 39272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66478"},
        {"Hipparcos Number", "HIP 39272"},
        {"Geneva Identification System", "GEN# +1.00066478"},
        {"Smithsonian Astrophysical Observation", "SAO 219321"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.46357879),
        dec: Angle.Degrees(-44.59992036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52171"},
        {"Hipparcos Number", "HIP 33514"},
        {"Smithsonian Astrophysical Observation", "SAO 218348"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.49591769),
        dec: Angle.Degrees(-44.59730949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217808"},
        {"Hipparcos Number", "HIP 113888"},
        {"Geneva Identification System", "GEN# +1.00217808"},
        {"Smithsonian Astrophysical Observation", "SAO 231416"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.96667607),
        dec: Angle.Degrees(-44.59501081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10190"},
        {"Hipparcos Number", "HIP 7667"},
        {"Geneva Identification System", "GEN# +1.00010190J"},
        {"Smithsonian Astrophysical Observation", "SAO 215596"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.67764695),
        dec: Angle.Degrees(-44.59432958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170522"},
        {"Hipparcos Number", "HIP 90852"},
        {"Fundamental Katalog 5th Edition", "FK5 5627"},
        {"Smithsonian Astrophysical Observation", "SAO 229096"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.00783977),
        dec: Angle.Degrees(-44.59403048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124633"},
        {"Hipparcos Number", "HIP 69686"},
        {"Smithsonian Astrophysical Observation", "SAO 224803"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.97215283),
        dec: Angle.Degrees(-44.59322843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85544",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85544"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.23860543),
        dec: Angle.Degrees(-44.59313782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25762"},
        {"Hipparcos Number", "HIP 18901"},
        {"Geneva Identification System", "GEN# +1.00025762"},
        {"Smithsonian Astrophysical Observation", "SAO 216617"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.76966833),
        dec: Angle.Degrees(-44.59198869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23166"},
        {"Hipparcos Number", "HIP 17208"},
        {"Smithsonian Astrophysical Observation", "SAO 216440"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.29545296),
        dec: Angle.Degrees(-44.59011913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114294"},
        {"Hipparcos Number", "HIP 64259"},
        {"Smithsonian Astrophysical Observation", "SAO 223949"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.55678578),
        dec: Angle.Degrees(-44.58989629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -199.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193572"},
        {"Hipparcos Number", "HIP 100487"},
        {"Geneva Identification System", "GEN# +1.00193572"},
        {"Renson", "Renson 54030"},
        {"Smithsonian Astrophysical Observation", "SAO 230178"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.65877261),
        dec: Angle.Degrees(-44.58720796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73669"},
    },
    visualMagnitude: 11.38,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.88614055),
        dec: Angle.Degrees(-44.58716898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210038"},
        {"Hipparcos Number", "HIP 109299"},
        {"Smithsonian Astrophysical Observation", "SAO 230998"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.14227189),
        dec: Angle.Degrees(-44.58670454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329572"},
        {"Hipparcos Number", "HIP 84221"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.23116423),
        dec: Angle.Degrees(-44.58669657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35488",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Bernes 135"},
        {"Hipparcos Number", "HIP 35488"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.86777027),
        dec: Angle.Degrees(-44.58650017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121274"},
        {"Hipparcos Number", "HIP 68000"},
        {"Geneva Identification System", "GEN# +1.00121274"},
        {"Smithsonian Astrophysical Observation", "SAO 224542"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.88261106),
        dec: Angle.Degrees(-44.58621864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166138"},
        {"Hipparcos Number", "HIP 89135"},
        {"Smithsonian Astrophysical Observation", "SAO 228781"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.86623170),
        dec: Angle.Degrees(-44.58607508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85821"},
        {"Hipparcos Number", "HIP 48483"},
        {"Geneva Identification System", "GEN# +1.00085821"},
        {"Smithsonian Astrophysical Observation", "SAO 221575"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.31735403),
        dec: Angle.Degrees(-44.58465235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33823"},
        {"Hipparcos Number", "HIP 24122"},
        {"Smithsonian Astrophysical Observation", "SAO 217220"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.71704771),
        dec: Angle.Degrees(-44.58431687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22296"},
        {"Hipparcos Number", "HIP 16588"},
        {"Smithsonian Astrophysical Observation", "SAO 216382"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.39176663),
        dec: Angle.Degrees(-44.58374635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79586"},
        {"Hipparcos Number", "HIP 45265"},
        {"Smithsonian Astrophysical Observation", "SAO 220963"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.38145791),
        dec: Angle.Degrees(-44.58132492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64181"},
        {"Hipparcos Number", "HIP 38292"},
        {"Geneva Identification System", "GEN# +1.00064181"},
        {"Smithsonian Astrophysical Observation", "SAO 219059"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.67715212),
        dec: Angle.Degrees(-44.57997832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32081"},
        {"Hipparcos Number", "HIP 23115"},
        {"Geneva Identification System", "GEN# +1.00032081"},
        {"Renson", "Renson 8170"},
        {"Smithsonian Astrophysical Observation", "SAO 217091"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.60605965),
        dec: Angle.Degrees(-44.57741555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58741"},
        {"Hipparcos Number", "HIP 35970"},
        {"Smithsonian Astrophysical Observation", "SAO 218705"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.20696882),
        dec: Angle.Degrees(-44.57602358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69213"},
        {"Hipparcos Number", "HIP 40330"},
        {"Celescope Catalog", "CEL 2265"},
        {"Geneva Identification System", "GEN# +1.00069213"},
        {"Smithsonian Astrophysical Observation", "SAO 219640"},
        {"Wilson Evans Batten Catalogue", "WEB 7866"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.52135220),
        dec: Angle.Degrees(-44.57586846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199000"},
        {"Hipparcos Number", "HIP 103308"},
        {"Geneva Identification System", "GEN# +1.00199000"},
        {"Smithsonian Astrophysical Observation", "SAO 230442"},
        {"Wilson Evans Batten Catalogue", "WEB 18775"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.94090980),
        dec: Angle.Degrees(-44.57575335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214216"},
        {"Hipparcos Number", "HIP 111689"},
        {"Geneva Identification System", "GEN# +1.00214216"},
        {"Smithsonian Astrophysical Observation", "SAO 231221"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.37908342),
        dec: Angle.Degrees(-44.57553211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46143"},
        {"Hipparcos Number", "HIP 30927"},
        {"Smithsonian Astrophysical Observation", "SAO 217966"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.36383696),
        dec: Angle.Degrees(-44.57449084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33811"},
        {"Hipparcos Number", "HIP 24110"},
        {"Geneva Identification System", "GEN# +1.00033811"},
        {"Smithsonian Astrophysical Observation", "SAO 217218"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.67925495),
        dec: Angle.Degrees(-44.57222559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 182.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154247"},
        {"Hipparcos Number", "HIP 83704"},
        {"Celescope Catalog", "CEL 4477"},
        {"Geneva Identification System", "GEN# +1.00154247"},
        {"Smithsonian Astrophysical Observation", "SAO 227622"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.60553001),
        dec: Angle.Degrees(-44.57205478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89136"},
        {"Hipparcos Number", "HIP 50276"},
        {"Smithsonian Astrophysical Observation", "SAO 221919"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.98218282),
        dec: Angle.Degrees(-44.57096809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5188"},
        {"Hipparcos Number", "HIP 4163"},
        {"Smithsonian Astrophysical Observation", "SAO 215278"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.29447108),
        dec: Angle.Degrees(-44.57082849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178731"},
        {"Hipparcos Number", "HIP 94322"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.97233596),
        dec: Angle.Degrees(-44.57029103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23307"},
        {"Hipparcos Number", "HIP 17311"},
        {"Smithsonian Astrophysical Observation", "SAO 216451"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.58571991),
        dec: Angle.Degrees(-44.56881728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 353",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 353"},
    },
    visualMagnitude: 11.63,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.11103092),
        dec: Angle.Degrees(-44.56734318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97685"},
        {"Hipparcos Number", "HIP 54859"},
        {"Smithsonian Astrophysical Observation", "SAO 222655"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.49011790),
        dec: Angle.Degrees(-44.56716810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78959"},
        {"Hipparcos Number", "HIP 44952"},
        {"Smithsonian Astrophysical Observation", "SAO 220902"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.37435542),
        dec: Angle.Degrees(-44.56667575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215105"},
        {"Hipparcos Number", "HIP 112207"},
        {"Geneva Identification System", "GEN# +1.00215105"},
        {"Smithsonian Astrophysical Observation", "SAO 231264"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.88358697),
        dec: Angle.Degrees(-44.56647806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195441"},
        {"Hipparcos Number", "HIP 101417"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.28428374),
        dec: Angle.Degrees(-44.56541826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141366"},
        {"Hipparcos Number", "HIP 77603"},
        {"Geneva Identification System", "GEN# +1.00141366"},
        {"Smithsonian Astrophysical Observation", "SAO 226273"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.683,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.64274690),
        dec: Angle.Degrees(-44.56502622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31370"},
        {"Hipparcos Number", "HIP 22713"},
        {"Smithsonian Astrophysical Observation", "SAO 217055"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.26514170),
        dec: Angle.Degrees(-44.56420233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113293"},
        {"Hipparcos Number", "HIP 63704"},
        {"Smithsonian Astrophysical Observation", "SAO 223866"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.82443668),
        dec: Angle.Degrees(-44.56259785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40219"},
        {"Hipparcos Number", "HIP 27992"},
        {"Smithsonian Astrophysical Observation", "SAO 217618"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.80751603),
        dec: Angle.Degrees(-44.56157954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13964"},
        {"Hipparcos Number", "HIP 10447"},
        {"Smithsonian Astrophysical Observation", "SAO 215833"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.66195281),
        dec: Angle.Degrees(-44.56134082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55349"},
        {"Hipparcos Number", "HIP 34634"},
        {"Smithsonian Astrophysical Observation", "SAO 218503"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.61050488),
        dec: Angle.Degrees(-44.56107425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108279"},
        {"Hipparcos Number", "HIP 60721"},
        {"Smithsonian Astrophysical Observation", "SAO 223441"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.65775812),
        dec: Angle.Degrees(-44.55997486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218165"},
        {"Hipparcos Number", "HIP 114077"},
        {"Smithsonian Astrophysical Observation", "SAO 231438"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.56853870),
        dec: Angle.Degrees(-44.55953718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91794"},
        {"Hipparcos Number", "HIP 51811"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.78314652),
        dec: Angle.Degrees(-44.55822048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154948"},
        {"Hipparcos Number", "HIP 84033"},
        {"Geneva Identification System", "GEN# +1.00154948"},
        {"Smithsonian Astrophysical Observation", "SAO 227688"},
        {"Wilson Evans Batten Catalogue", "WEB 14198"},
    },
    visualMagnitude: 5.06,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.67646022),
        dec: Angle.Degrees(-44.55755110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167487"},
        {"Hipparcos Number", "HIP 89638"},
        {"Smithsonian Astrophysical Observation", "SAO 228877"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.40191285),
        dec: Angle.Degrees(-44.55345100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30360"},
        {"Hipparcos Number", "HIP 22069"},
        {"Smithsonian Astrophysical Observation", "SAO 216976"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.20206872),
        dec: Angle.Degrees(-44.55213784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219437"},
        {"Hipparcos Number", "HIP 114885"},
        {"Cincinnati Publication", "Ci 20 1410"},
        {"Smithsonian Astrophysical Observation", "SAO 231526"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.07351734),
        dec: Angle.Degrees(-44.54908922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 493.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 137.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183577"},
        {"Hipparcos Number", "HIP 96095"},
        {"Geneva Identification System", "GEN# +1.00183577"},
        {"Smithsonian Astrophysical Observation", "SAO 229734"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.05879640),
        dec: Angle.Degrees(-44.54646647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38409"},
        {"Hipparcos Number", "HIP 26963"},
        {"Smithsonian Astrophysical Observation", "SAO 217490"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.82684056),
        dec: Angle.Degrees(-44.54505652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72997"},
        {"Hipparcos Number", "HIP 42036"},
        {"Celescope Catalog", "CEL 2658"},
        {"Geneva Identification System", "GEN# +4.27040013"},
        {"Smithsonian Astrophysical Observation", "SAO 220117"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.53395451),
        dec: Angle.Degrees(-44.54484921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63663"},
        {"Hipparcos Number", "HIP 38058"},
        {"Celescope Catalog", "CEL 2045"},
        {"Smithsonian Astrophysical Observation", "SAO 219005"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.00262787),
        dec: Angle.Degrees(-44.54482894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161455"},
        {"Hipparcos Number", "HIP 87104"},
        {"Smithsonian Astrophysical Observation", "SAO 228422"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.96481971),
        dec: Angle.Degrees(-44.54356762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12360"},
        {"Hipparcos Number", "HIP 9344"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.99769157),
        dec: Angle.Degrees(-44.54354409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74868"},
        {"Hipparcos Number", "HIP 42922"},
        {"Celescope Catalog", "CEL 2847"},
        {"Geneva Identification System", "GEN# +1.00074868"},
        {"Smithsonian Astrophysical Observation", "SAO 220387"},
        {"Wilson Evans Batten Catalogue", "WEB 8297"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.21218280),
        dec: Angle.Degrees(-44.54292426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 134.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89854"},
        {"Hipparcos Number", "HIP 50712"},
        {"Smithsonian Astrophysical Observation", "SAO 221981"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.32100023),
        dec: Angle.Degrees(-44.53975115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82207"},
        {"Hipparcos Number", "HIP 46523"},
        {"Geneva Identification System", "GEN# +1.00082207"},
        {"Smithsonian Astrophysical Observation", "SAO 221213"},
        {"Wilson Evans Batten Catalogue", "WEB 8781"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.32816995),
        dec: Angle.Degrees(-44.53897160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209662"},
        {"Hipparcos Number", "HIP 109106"},
        {"Geneva Identification System", "GEN# +1.00209662"},
        {"Smithsonian Astrophysical Observation", "SAO 230976"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.51362392),
        dec: Angle.Degrees(-44.53709436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174337"},
        {"Hipparcos Number", "HIP 92603"},
        {"Smithsonian Astrophysical Observation", "SAO 229331"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.03679089),
        dec: Angle.Degrees(-44.53638725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202081"},
        {"Hipparcos Number", "HIP 104909"},
        {"Geneva Identification System", "GEN# +1.00202081"},
        {"Smithsonian Astrophysical Observation", "SAO 230594"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.76457811),
        dec: Angle.Degrees(-44.53600571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82241"},
        {"Hipparcos Number", "HIP 46535"},
        {"Geneva Identification System", "GEN# +1.00082241"},
        {"Smithsonian Astrophysical Observation", "SAO 221216"},
        {"Wilson Evans Batten Catalogue", "WEB 8783"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.36937517),
        dec: Angle.Degrees(-44.53238215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142304"},
        {"Hipparcos Number", "HIP 78004"},
        {"Geneva Identification System", "GEN# +1.00142304"},
        {"Smithsonian Astrophysical Observation", "SAO 226369"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.92955866),
        dec: Angle.Degrees(-44.53237120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70079",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70079"},
    },
    visualMagnitude: 14.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.11755778),
        dec: Angle.Degrees(-44.53230408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130416"},
        {"Hipparcos Number", "HIP 72516"},
        {"Geneva Identification System", "GEN# +1.00130416"},
        {"Smithsonian Astrophysical Observation", "SAO 225212"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.39818251),
        dec: Angle.Degrees(-44.53221926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8681"},
        {"Hipparcos Number", "HIP 6595"},
        {"Geneva Identification System", "GEN# +1.00008681"},
        {"Smithsonian Astrophysical Observation", "SAO 215494"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.17467728),
        dec: Angle.Degrees(-44.52852794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73090"},
        {"Hipparcos Number", "HIP 42085"},
        {"Celescope Catalog", "CEL 2671"},
        {"Geneva Identification System", "GEN# +4.27040012"},
        {"Smithsonian Astrophysical Observation", "SAO 220133"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.66912781),
        dec: Angle.Degrees(-44.52833312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39604"},
        {"Hipparcos Number", "HIP 27669"},
        {"Smithsonian Astrophysical Observation", "SAO 217575"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.86834972),
        dec: Angle.Degrees(-44.52811544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183154"},
        {"Hipparcos Number", "HIP 95896"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.54066587),
        dec: Angle.Degrees(-44.52616504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142256"},
        {"Hipparcos Number", "HIP 77968"},
        {"Geneva Identification System", "GEN# +1.00142256"},
        {"Smithsonian Astrophysical Observation", "SAO 226363"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.84540890),
        dec: Angle.Degrees(-44.52596631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196325"},
        {"Hipparcos Number", "HIP 101855"},
        {"Smithsonian Astrophysical Observation", "SAO 230305"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.59843921),
        dec: Angle.Degrees(-44.52470958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192844"},
        {"Hipparcos Number", "HIP 100152"},
        {"Geneva Identification System", "GEN# +1.00192844"},
        {"Smithsonian Astrophysical Observation", "SAO 230146"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.73560821),
        dec: Angle.Degrees(-44.52445436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71933"},
        {"Hipparcos Number", "HIP 41543"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.07197863),
        dec: Angle.Degrees(-44.52384039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41545"},
    },
    visualMagnitude: 12.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.07789525),
        dec: Angle.Degrees(-44.52220697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50751"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)10, (int)21, 47.6400),
        dec: Angle.DegreesMinutesSeconds((int)-44, (int)31, 14.900)
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
    primaryId: "HIP 45108",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45108"},
    },
    visualMagnitude: 10.85,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)09, (int)11, 25.7300),
        dec: Angle.DegreesMinutesSeconds((int)-44, (int)31, 09.800)
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
    primaryId: "HIP 83330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153463"},
        {"Hipparcos Number", "HIP 83330"},
        {"Geneva Identification System", "GEN# +1.00153463"},
        {"Smithsonian Astrophysical Observation", "SAO 227559"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.46220125),
        dec: Angle.Degrees(-44.51888398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103776"},
    },
    visualMagnitude: 11.02,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.43336793),
        dec: Angle.Degrees(-44.51846582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45106",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45106"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.85160285),
        dec: Angle.Degrees(-44.51650006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -243.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118588"},
        {"Hipparcos Number", "HIP 66566"},
        {"Smithsonian Astrophysical Observation", "SAO 224303"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.67874844),
        dec: Angle.Degrees(-44.51624123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195569"},
        {"Hipparcos Number", "HIP 101477"},
        {"Fundamental Katalog 5th Edition", "FK5 3643"},
        {"Geneva Identification System", "GEN# +1.00195569"},
        {"Smithsonian Astrophysical Observation", "SAO 230276"},
        {"Wilson Evans Batten Catalogue", "WEB 18332"},
    },
    visualMagnitude: 5.12,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.47942959),
        dec: Angle.Degrees(-44.51596141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18211"},
        {"Hipparcos Number", "HIP 13503"},
        {"Smithsonian Astrophysical Observation", "SAO 216087"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.48432005),
        dec: Angle.Degrees(-44.51536193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90726"},
        {"Hipparcos Number", "HIP 51209"},
        {"Smithsonian Astrophysical Observation", "SAO 222070"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.89671213),
        dec: Angle.Degrees(-44.51359754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105134"},
        {"Hipparcos Number", "HIP 59039"},
        {"Smithsonian Astrophysical Observation", "SAO 223218"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.56255580),
        dec: Angle.Degrees(-44.51204265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116554"},
        {"Hipparcos Number", "HIP 65460"},
        {"Smithsonian Astrophysical Observation", "SAO 224121"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.25196529),
        dec: Angle.Degrees(-44.51142036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89920"},
        {"Hipparcos Number", "HIP 50754"},
        {"Geneva Identification System", "GEN# +1.00089920"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.45627952),
        dec: Angle.Degrees(-44.51073346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103619"},
        {"Hipparcos Number", "HIP 58168"},
        {"Geneva Identification System", "GEN# +1.00103619"},
        {"Renson", "Renson 29890"},
        {"Smithsonian Astrophysical Observation", "SAO 223116"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.94210516),
        dec: Angle.Degrees(-44.51012915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125528"},
        {"Hipparcos Number", "HIP 70147"},
        {"Geneva Identification System", "GEN# +1.00125528"},
        {"Smithsonian Astrophysical Observation", "SAO 224853"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.29050275),
        dec: Angle.Degrees(-44.50986019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73059"},
        {"Hipparcos Number", "HIP 42073"},
        {"Celescope Catalog", "CEL 2669"},
        {"Geneva Identification System", "GEN# +4.27040011"},
        {"Smithsonian Astrophysical Observation", "SAO 220126"},
    },
    visualMagnitude: 9.27,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.62512128),
        dec: Angle.Degrees(-44.50628758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135416"},
        {"Hipparcos Number", "HIP 74740"},
        {"Smithsonian Astrophysical Observation", "SAO 225604"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.11899720),
        dec: Angle.Degrees(-44.50362758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171103"},
        {"Hipparcos Number", "HIP 91106"},
        {"Smithsonian Astrophysical Observation", "SAO 229128"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.76067559),
        dec: Angle.Degrees(-44.50362048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215800"},
        {"Hipparcos Number", "HIP 112601"},
        {"Geneva Identification System", "GEN# +1.00215800"},
        {"Smithsonian Astrophysical Observation", "SAO 231305"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.08757315),
        dec: Angle.Degrees(-44.50119513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128894"},
        {"Hipparcos Number", "HIP 71772"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.22222702),
        dec: Angle.Degrees(-44.50089732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134687"},
        {"Hipparcos Number", "HIP 74449"},
        {"Celescope Catalog", "CEL 4350"},
        {"Geneva Identification System", "GEN# +1.00134687"},
        {"Smithsonian Astrophysical Observation", "SAO 225539"},
        {"Wilson Evans Batten Catalogue", "WEB 12701"},
    },
    visualMagnitude: 4.83,
    bvColour: -0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.20668641),
        dec: Angle.Degrees(-44.50035965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223776"},
        {"Hipparcos Number", "HIP 117729"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.15224932),
        dec: Angle.Degrees(-44.50000752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166619"},
        {"Hipparcos Number", "HIP 89332"},
        {"Smithsonian Astrophysical Observation", "SAO 228818"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.41152300),
        dec: Angle.Degrees(-44.49991571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158746"},
        {"Hipparcos Number", "HIP 85886"},
        {"Celescope Catalog", "CEL 4525"},
        {"Geneva Identification System", "GEN# +1.00158746"},
        {"Smithsonian Astrophysical Observation", "SAO 228106"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.27529605),
        dec: Angle.Degrees(-44.49879844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221051"},
        {"Hipparcos Number", "HIP 115907"},
        {"Geneva Identification System", "GEN# +1.00221051"},
        {"Smithsonian Astrophysical Observation", "SAO 231622"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.25331359),
        dec: Angle.Degrees(-44.49803575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7261"},
        {"Hipparcos Number", "HIP 5621"},
        {"Geneva Identification System", "GEN# +1.00007261"},
        {"Smithsonian Astrophysical Observation", "SAO 215409"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.03728499),
        dec: Angle.Degrees(-44.49703157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47671"},
        {"Hipparcos Number", "HIP 31679"},
        {"Celescope Catalog", "CEL 1336"},
        {"Geneva Identification System", "GEN# +1.00047671"},
        {"Smithsonian Astrophysical Observation", "SAO 218070"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.42738359),
        dec: Angle.Degrees(-44.49569290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25421"},
        {"Hipparcos Number", "HIP 18711"},
        {"Geneva Identification System", "GEN# +1.00025421"},
        {"Smithsonian Astrophysical Observation", "SAO 216596"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.11664611),
        dec: Angle.Degrees(-44.49311749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201950"},
        {"Hipparcos Number", "HIP 104834"},
        {"Smithsonian Astrophysical Observation", "SAO 230586"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56769362),
        dec: Angle.Degrees(-44.49213068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13290"},
        {"Hipparcos Number", "HIP 9993"},
        {"Smithsonian Astrophysical Observation", "SAO 215782"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.17390447),
        dec: Angle.Degrees(-44.49192265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77195"},
        {"Geneva Identification System", "GEN# -0.04410370"},
        {"Wilson Evans Batten Catalogue", "WEB 13084"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.44030402),
        dec: Angle.Degrees(-44.49148384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219507"},
        {"Hipparcos Number", "HIP 114921"},
        {"Geneva Identification System", "GEN# +1.00219507"},
        {"Smithsonian Astrophysical Observation", "SAO 231532"},
    },
    visualMagnitude: 5.92,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.16578399),
        dec: Angle.Degrees(-44.48914171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13755"},
        {"Hipparcos Number", "HIP 10304"},
        {"Geneva Identification System", "GEN# +1.00013755"},
        {"Smithsonian Astrophysical Observation", "SAO 215818"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.19615999),
        dec: Angle.Degrees(-44.48903718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108294"},
        {"Hipparcos Number", "HIP 60730"},
        {"Smithsonian Astrophysical Observation", "SAO 223442"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.70552997),
        dec: Angle.Degrees(-44.48692465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73700"},
        {"Hipparcos Number", "HIP 42340"},
        {"Smithsonian Astrophysical Observation", "SAO 220213"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.48303148),
        dec: Angle.Degrees(-44.48581956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91323"},
        {"Hipparcos Number", "HIP 51548"},
        {"Geneva Identification System", "GEN# +1.00091323J"},
        {"Smithsonian Astrophysical Observation", "SAO 222122"},
        {"Wilson Evans Batten Catalogue", "WEB 9402"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.93286851),
        dec: Angle.Degrees(-44.48484761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133954"},
        {"Hipparcos Number", "HIP 74104"},
        {"Geneva Identification System", "GEN# +1.00133954"},
        {"Smithsonian Astrophysical Observation", "SAO 225480"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.17718977),
        dec: Angle.Degrees(-44.48448984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25842"},
        {"Hipparcos Number", "HIP 18958"},
        {"Geneva Identification System", "GEN# +1.00025842A"},
        {"Smithsonian Astrophysical Observation", "SAO 216623"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.93817253),
        dec: Angle.Degrees(-44.48147351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16768"},
        {"Hipparcos Number", "HIP 12415"},
        {"Smithsonian Astrophysical Observation", "SAO 215997"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.95154040),
        dec: Angle.Degrees(-44.48111714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42345"},
        {"Hipparcos Number", "HIP 29069"},
        {"Smithsonian Astrophysical Observation", "SAO 217731"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.98456608),
        dec: Angle.Degrees(-44.47832764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174153"},
        {"Hipparcos Number", "HIP 92519"},
        {"Geneva Identification System", "GEN# +1.00174153"},
        {"Smithsonian Astrophysical Observation", "SAO 229322"},
        {"Wilson Evans Batten Catalogue", "WEB 16001"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.83223256),
        dec: Angle.Degrees(-44.47545357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217027"},
        {"Hipparcos Number", "HIP 113422"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.56591729),
        dec: Angle.Degrees(-44.47327980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42881"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.09582438),
        dec: Angle.Degrees(-44.47278670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 137.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22704"},
        {"Hipparcos Number", "HIP 16881"},
        {"Smithsonian Astrophysical Observation", "SAO 216406"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.30875202),
        dec: Angle.Degrees(-44.47204707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328209"},
        {"Hipparcos Number", "HIP 80755"},
        {"Geneva Identification System", "GEN# +1.00328209"},
        {"Smithsonian Astrophysical Observation", "SAO 226809"},
        {"Wilson Evans Batten Catalogue", "WEB 13657"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.32986912),
        dec: Angle.Degrees(-44.47061111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179726"},
        {"Hipparcos Number", "HIP 94656"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.91646993),
        dec: Angle.Degrees(-44.46956325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189404"},
        {"Hipparcos Number", "HIP 98605"},
        {"Geneva Identification System", "GEN# +1.00189404"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.42466816),
        dec: Angle.Degrees(-44.46948997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88995"},
        {"Hipparcos Number", "HIP 50210"},
        {"Geneva Identification System", "GEN# +1.00088995"},
        {"Smithsonian Astrophysical Observation", "SAO 221904"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.75341604),
        dec: Angle.Degrees(-44.46782477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88338"},
        {"Hipparcos Number", "HIP 49814"},
        {"Smithsonian Astrophysical Observation", "SAO 221821"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.53766940),
        dec: Angle.Degrees(-44.46662736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170219"},
        {"Hipparcos Number", "HIP 90712"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.61625301),
        dec: Angle.Degrees(-44.46538905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208946"},
        {"Hipparcos Number", "HIP 108665"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.21775395),
        dec: Angle.Degrees(-44.46272422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200361"},
        {"Hipparcos Number", "HIP 104024"},
        {"Geneva Identification System", "GEN# +1.00200361"},
        {"Smithsonian Astrophysical Observation", "SAO 230508"},
        {"Wilson Evans Batten Catalogue", "WEB 18949"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.12995595),
        dec: Angle.Degrees(-44.46167303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19778"},
        {"Hipparcos Number", "HIP 14651"},
        {"Smithsonian Astrophysical Observation", "SAO 216185"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.33354383),
        dec: Angle.Degrees(-44.46140219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201264"},
        {"Hipparcos Number", "HIP 104473"},
        {"Geneva Identification System", "GEN# +1.00201264"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.45125853),
        dec: Angle.Degrees(-44.46132096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2120"},
        {"Hipparcos Number", "HIP 1992"},
        {"Smithsonian Astrophysical Observation", "SAO 215086"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.30735119),
        dec: Angle.Degrees(-44.46081522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36206"},
        {"Hipparcos Number", "HIP 25579"},
        {"Smithsonian Astrophysical Observation", "SAO 217344"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.00150986),
        dec: Angle.Degrees(-44.46060651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220945"},
        {"Hipparcos Number", "HIP 115849"},
        {"Geneva Identification System", "GEN# +1.00220945"},
        {"Smithsonian Astrophysical Observation", "SAO 231617"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.06315380),
        dec: Angle.Degrees(-44.46023435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -313.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95241",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Arkab Prior"},
        {"Henry Draper", "HD 181454"},
        {"Hipparcos Number", "HIP 95241"},
        {"Fundamental Katalog 5th Edition", "FK5 1502"},
        {"Geneva Identification System", "GEN# +1.00181454J"},
        {"Geneva Identification System 2", "GEN# +1.00181454A"},
        {"Smithsonian Astrophysical Observation", "SAO 229646"},
        {"Wilson Evans Batten Catalogue", "WEB 16640"},
    },
    visualMagnitude: 3.96,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.65952718),
        dec: Angle.Degrees(-44.45891013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170042"},
        {"Hipparcos Number", "HIP 90634"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.39725415),
        dec: Angle.Degrees(-44.45838986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160339"},
        {"Hipparcos Number", "HIP 86571"},
        {"Geneva Identification System", "GEN# +1.00160339"},
        {"Smithsonian Astrophysical Observation", "SAO 228287"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.36989431),
        dec: Angle.Degrees(-44.45716621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195000"},
        {"Hipparcos Number", "HIP 101173"},
        {"Smithsonian Astrophysical Observation", "SAO 230247"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.60730787),
        dec: Angle.Degrees(-44.45659599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211053"},
        {"Hipparcos Number", "HIP 109902"},
        {"Geneva Identification System", "GEN# +1.00211053"},
        {"Smithsonian Astrophysical Observation", "SAO 231053"},
    },
    visualMagnitude: 6.10,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.89596852),
        dec: Angle.Degrees(-44.45149421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117665"},
        {"Hipparcos Number", "HIP 66068"},
        {"Smithsonian Astrophysical Observation", "SAO 224230"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.16360405),
        dec: Angle.Degrees(-44.45021090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72541"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.46307846),
        dec: Angle.Degrees(-44.44849012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164176"},
        {"Hipparcos Number", "HIP 88310"},
        {"Smithsonian Astrophysical Observation", "SAO 228636"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.52852203),
        dec: Angle.Degrees(-44.44070435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204166"},
        {"Hipparcos Number", "HIP 106000"},
        {"Geneva Identification System", "GEN# +1.00204166"},
        {"Smithsonian Astrophysical Observation", "SAO 230700"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.02826885),
        dec: Angle.Degrees(-44.43802506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109192"},
        {"Hipparcos Number", "HIP 61258"},
        {"Geneva Identification System", "GEN# +1.00109192"},
        {"Smithsonian Astrophysical Observation", "SAO 223506"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.30668961),
        dec: Angle.Degrees(-44.43713994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57464"},
        {"Hipparcos Number", "HIP 35462"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.80495062),
        dec: Angle.Degrees(-44.43547531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80156"},
        {"Hipparcos Number", "HIP 45520"},
        {"Smithsonian Astrophysical Observation", "SAO 221019"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.16549298),
        dec: Angle.Degrees(-44.43460931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143361"},
        {"Hipparcos Number", "HIP 78521"},
        {"Geneva Identification System", "GEN# +1.00143361"},
        {"Smithsonian Astrophysical Observation", "SAO 226454"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.46031775),
        dec: Angle.Degrees(-44.43424666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62061"},
        {"Hipparcos Number", "HIP 37360"},
        {"Geneva Identification System", "GEN# +1.00062061"},
        {"Smithsonian Astrophysical Observation", "SAO 218886"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.03296671),
        dec: Angle.Degrees(-44.43074771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35843"},
        {"Hipparcos Number", "HIP 25359"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.34930704),
        dec: Angle.Degrees(-44.43054227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171256"},
        {"Hipparcos Number", "HIP 91162"},
        {"Smithsonian Astrophysical Observation", "SAO 229134"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.97671816),
        dec: Angle.Degrees(-44.42906139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43788"},
        {"Hipparcos Number", "HIP 29751"},
        {"Smithsonian Astrophysical Observation", "SAO 217816"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.98359565),
        dec: Angle.Degrees(-44.42643019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216009"},
        {"Hipparcos Number", "HIP 112735"},
        {"Geneva Identification System", "GEN# +1.00216009"},
        {"Smithsonian Astrophysical Observation", "SAO 231319"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.46310797),
        dec: Angle.Degrees(-44.42354426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113702"},
        {"Hipparcos Number", "HIP 63930"},
        {"Smithsonian Astrophysical Observation", "SAO 223899"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.53663861),
        dec: Angle.Degrees(-44.42050356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20121"},
        {"Hipparcos Number", "HIP 14913"},
        {"Fundamental Katalog 5th Edition", "FK5 2228"},
        {"Geneva Identification System", "GEN# +1.00020121"},
        {"Smithsonian Astrophysical Observation", "SAO 216209"},
        {"Wilson Evans Batten Catalogue", "WEB 2882"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.10699596),
        dec: Angle.Degrees(-44.41965395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48342"},
        {"Hipparcos Number", "HIP 31968"},
        {"Geneva Identification System", "GEN# +1.00048342"},
        {"Smithsonian Astrophysical Observation", "SAO 218122"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.21380368),
        dec: Angle.Degrees(-44.41531191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212436"},
        {"Hipparcos Number", "HIP 110665"},
        {"Smithsonian Astrophysical Observation", "SAO 231130"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.28232167),
        dec: Angle.Degrees(-44.41368436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77287"},
        {"Hipparcos Number", "HIP 44183"},
        {"Smithsonian Astrophysical Observation", "SAO 220731"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.00968423),
        dec: Angle.Degrees(-44.41290563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94444"},
        {"Hipparcos Number", "HIP 53244"},
        {"Geneva Identification System", "GEN# +1.00094444"},
        {"Smithsonian Astrophysical Observation", "SAO 222403"},
        {"Wilson Evans Batten Catalogue", "WEB 9664"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.35768678),
        dec: Angle.Degrees(-44.41135257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -260.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27302"},
        {"Hipparcos Number", "HIP 19940"},
        {"Smithsonian Astrophysical Observation", "SAO 216731"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.15330322),
        dec: Angle.Degrees(-44.40971333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104508"},
        {"Hipparcos Number", "HIP 58681"},
        {"Smithsonian Astrophysical Observation", "SAO 223178"},
    },
    visualMagnitude: 9.33,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.51587874),
        dec: Angle.Degrees(-44.40802009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3486"},
        {"Hipparcos Number", "HIP 2950"},
        {"Smithsonian Astrophysical Observation", "SAO 215169"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.36925976),
        dec: Angle.Degrees(-44.40782312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138190"},
        {"Hipparcos Number", "HIP 76076"},
        {"Smithsonian Astrophysical Observation", "SAO 225878"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.06343930),
        dec: Angle.Degrees(-44.40731221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155691"},
        {"Hipparcos Number", "HIP 84398"},
        {"Smithsonian Astrophysical Observation", "SAO 227747"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.82232890),
        dec: Angle.Degrees(-44.40672587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95813"},
        {"Hipparcos Number", "HIP 54005"},
        {"Smithsonian Astrophysical Observation", "SAO 222519"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.72641020),
        dec: Angle.Degrees(-44.40596554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101581"},
        {"Hipparcos Number", "HIP 56998"},
        {"Cincinnati Publication", "Ci 20 656"},
        {"Geneva Identification System", "GEN# +1.00101581"},
        {"Smithsonian Astrophysical Observation", "SAO 222956"},
        {"Wilson Evans Batten Catalogue", "WEB 10261"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.26253299),
        dec: Angle.Degrees(-44.40577927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -658.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 242.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205994"},
        {"Hipparcos Number", "HIP 107006"},
        {"Smithsonian Astrophysical Observation", "SAO 230783"},
    },
    visualMagnitude: 8.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.07799745),
        dec: Angle.Degrees(-44.40494896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119657"},
        {"Hipparcos Number", "HIP 67124"},
        {"Smithsonian Astrophysical Observation", "SAO 224400"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.36137395),
        dec: Angle.Degrees(-44.40494725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104954"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.89524852),
        dec: Angle.Degrees(-44.40427953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112076"},
        {"Hipparcos Number", "HIP 62977"},
        {"Smithsonian Astrophysical Observation", "SAO 223742"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.56462531),
        dec: Angle.Degrees(-44.40147030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185887"},
        {"Hipparcos Number", "HIP 97040"},
        {"Smithsonian Astrophysical Observation", "SAO 229831"},
        {"Smithsonian Astrophysical Observation 2", "SAO 229832"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.82966787),
        dec: Angle.Degrees(-44.39728493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138816"},
        {"Hipparcos Number", "HIP 76397"},
        {"Fundamental Katalog 5th Edition", "FK5 1410"},
        {"Geneva Identification System", "GEN# +1.00138816"},
        {"Smithsonian Astrophysical Observation", "SAO 225957"},
        {"Wilson Evans Batten Catalogue", "WEB 12970"},
    },
    visualMagnitude: 5.44,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.05056891),
        dec: Angle.Degrees(-44.39668903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73303"},
        {"Hipparcos Number", "HIP 42183"},
        {"Celescope Catalog", "CEL 2692"},
        {"Geneva Identification System", "GEN# +1.00073303"},
        {"Smithsonian Astrophysical Observation", "SAO 220166"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.00932705),
        dec: Angle.Degrees(-44.39625511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117911"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.74722339),
        dec: Angle.Degrees(-12.95997241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97959"},
        {"Hipparcos Number", "HIP 54983"},
        {"Renson", "Renson 28240"},
        {"Smithsonian Astrophysical Observation", "SAO 222677"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.87318593),
        dec: Angle.Degrees(-44.39540701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154073"},
        {"Hipparcos Number", "HIP 83611"},
        {"Smithsonian Astrophysical Observation", "SAO 227610"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.34181276),
        dec: Angle.Degrees(-44.39289365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131518"},
        {"Hipparcos Number", "HIP 73035"},
        {"Geneva Identification System", "GEN# +1.00131518"},
        {"Smithsonian Astrophysical Observation", "SAO 225294"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.89452856),
        dec: Angle.Degrees(-44.39224868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68891"},
        {"Hipparcos Number", "HIP 40199"},
        {"Smithsonian Astrophysical Observation", "SAO 219609"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.16432814),
        dec: Angle.Degrees(-44.39211644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25740"},
        {"Hipparcos Number", "HIP 18888"},
        {"Geneva Identification System", "GEN# +1.00025740"},
        {"Smithsonian Astrophysical Observation", "SAO 216616"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.74365233),
        dec: Angle.Degrees(-44.39196595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105648"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.98381097),
        dec: Angle.Degrees(-44.39158944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2479"},
        {"Hipparcos Number", "HIP 2233"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.07628203),
        dec: Angle.Degrees(-44.38893179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114947",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114947"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.23748122),
        dec: Angle.Degrees(-44.38492899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98995"},
        {"Hipparcos Number", "HIP 55580"},
        {"Smithsonian Astrophysical Observation", "SAO 222760"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.78385447),
        dec: Angle.Degrees(-44.38244296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19028"},
        {"Hipparcos Number", "HIP 14116"},
        {"Smithsonian Astrophysical Observation", "SAO 216144"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.50862540),
        dec: Angle.Degrees(-44.38240462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328389"},
        {"Hipparcos Number", "HIP 81203"},
        {"Geneva Identification System", "GEN# +1.00328389"},
        {"Smithsonian Astrophysical Observation", "SAO 226927"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.78881210),
        dec: Angle.Degrees(-44.38082060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107693"},
        {"Hipparcos Number", "HIP 60371"},
        {"Smithsonian Astrophysical Observation", "SAO 223392"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.68808041),
        dec: Angle.Degrees(-44.38078033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67365"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.10319012),
        dec: Angle.Degrees(-44.38041037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51209"},
        {"Hipparcos Number", "HIP 33169"},
        {"Smithsonian Astrophysical Observation", "SAO 218294"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.55890071),
        dec: Angle.Degrees(-44.37991895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2144"},
        {"Hipparcos Number", "HIP 2010"},
        {"Smithsonian Astrophysical Observation", "SAO 215087"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.35517038),
        dec: Angle.Degrees(-44.37989785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111078"},
    },
    visualMagnitude: 10.89,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.54043367),
        dec: Angle.Degrees(-44.37945254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150645"},
        {"Hipparcos Number", "HIP 81949"},
        {"Smithsonian Astrophysical Observation", "SAO 227135"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.08792933),
        dec: Angle.Degrees(-44.37867695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93721"},
        {"Hipparcos Number", "HIP 52855"},
        {"Geneva Identification System", "GEN# +1.00093721"},
        {"Smithsonian Astrophysical Observation", "SAO 222342"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.12165270),
        dec: Angle.Degrees(-44.37857087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195141"},
        {"Hipparcos Number", "HIP 101246"},
        {"Smithsonian Astrophysical Observation", "SAO 230251"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.83985667),
        dec: Angle.Degrees(-44.37814776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158584"},
        {"Hipparcos Number", "HIP 85827"},
        {"Smithsonian Astrophysical Observation", "SAO 228086"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.06393281),
        dec: Angle.Degrees(-44.37756689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184955"},
        {"Hipparcos Number", "HIP 96626"},
        {"Smithsonian Astrophysical Observation", "SAO 229787"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.69389643),
        dec: Angle.Degrees(-44.37502554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63175"},
        {"Hipparcos Number", "HIP 37856"},
        {"Celescope Catalog", "CEL 2021"},
        {"Geneva Identification System", "GEN# +1.00063175J"},
        {"Smithsonian Astrophysical Observation", "SAO 218962"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.40113608),
        dec: Angle.Degrees(-44.37389253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35288"},
        {"Hipparcos Number", "HIP 25026"},
        {"Smithsonian Astrophysical Observation", "SAO 217304"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.37449503),
        dec: Angle.Degrees(-44.37348569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96423"},
        {"Hipparcos Number", "HIP 54287"},
        {"Geneva Identification System", "GEN# +1.00096423"},
        {"Smithsonian Astrophysical Observation", "SAO 222569"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.58197092),
        dec: Angle.Degrees(-44.37310640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154196"},
        {"Hipparcos Number", "HIP 83666"},
        {"Smithsonian Astrophysical Observation", "SAO 227617"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.50272732),
        dec: Angle.Degrees(-44.37268248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97576"},
        {"Hipparcos Number", "HIP 54811"},
        {"Fundamental Katalog 5th Edition", "FK5 2894"},
        {"Geneva Identification System", "GEN# +1.00097576"},
        {"Smithsonian Astrophysical Observation", "SAO 222647"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.31120754),
        dec: Angle.Degrees(-44.37222081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182232"},
        {"Hipparcos Number", "HIP 95514"},
        {"Smithsonian Astrophysical Observation", "SAO 229671"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.42764460),
        dec: Angle.Degrees(-44.36951561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5387"},
        {"Hipparcos Number", "HIP 4309"},
        {"Geneva Identification System", "GEN# +1.00005387"},
        {"Smithsonian Astrophysical Observation", "SAO 215289"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.79864875),
        dec: Angle.Degrees(-44.36883234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64575"},
        {"Hipparcos Number", "HIP 38451"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.15340514),
        dec: Angle.Degrees(-44.36858450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26820"},
        {"Hipparcos Number", "HIP 19642"},
        {"Geneva Identification System", "GEN# +1.00026820"},
        {"Smithsonian Astrophysical Observation", "SAO 216694"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.13160551),
        dec: Angle.Degrees(-44.36824930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13710"},
        {"Hipparcos Number", "HIP 10283"},
        {"Smithsonian Astrophysical Observation", "SAO 215816"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.10483836),
        dec: Angle.Degrees(-44.36822783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4990"},
        {"Hipparcos Number", "HIP 4001"},
        {"Smithsonian Astrophysical Observation", "SAO 215263"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.84382724),
        dec: Angle.Degrees(-44.36821799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91214"},
        {"Hipparcos Number", "HIP 51486"},
        {"Smithsonian Astrophysical Observation", "SAO 222109"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.73852561),
        dec: Angle.Degrees(-44.36783639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147688"},
        {"Hipparcos Number", "HIP 80443"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.31319621),
        dec: Angle.Degrees(-44.36749912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108840"},
        {"Hipparcos Number", "HIP 61038"},
        {"Geneva Identification System", "GEN# +1.00108840"},
        {"Smithsonian Astrophysical Observation", "SAO 223478"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.65303067),
        dec: Angle.Degrees(-44.36733292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123585"},
        {"Hipparcos Number", "HIP 69176"},
        {"Geneva Identification System", "GEN# +1.00123585"},
        {"Renson", "Renson 35400"},
        {"Smithsonian Astrophysical Observation", "SAO 224731"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.39902406),
        dec: Angle.Degrees(-44.36692508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24406"},
        {"Hipparcos Number", "HIP 18019"},
        {"Geneva Identification System", "GEN# +1.00024406"},
        {"Smithsonian Astrophysical Observation", "SAO 216520"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.76278728),
        dec: Angle.Degrees(-44.36500292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211744"},
        {"Hipparcos Number", "HIP 110271"},
        {"Geneva Identification System", "GEN# +1.00211744"},
        {"Smithsonian Astrophysical Observation", "SAO 231084"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.04138885),
        dec: Angle.Degrees(-44.36459756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1321"},
        {"Hipparcos Number", "HIP 1376"},
        {"Geneva Identification System", "GEN# +1.00001321"},
        {"Smithsonian Astrophysical Observation", "SAO 215035"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.30066937),
        dec: Angle.Degrees(-44.36429373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135429"},
        {"Hipparcos Number", "HIP 74754"},
        {"Geneva Identification System", "GEN# +1.00135429"},
        {"Smithsonian Astrophysical Observation", "SAO 225611"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.16343037),
        dec: Angle.Degrees(-44.35844303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42448"},
        {"Hipparcos Number", "HIP 29129"},
        {"Geneva Identification System", "GEN# +1.00042448"},
        {"Smithsonian Astrophysical Observation", "SAO 217735"},
        {"Wilson Evans Batten Catalogue", "WEB 5711"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.14431962),
        dec: Angle.Degrees(-44.35622833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140977"},
        {"Hipparcos Number", "HIP 77418"},
        {"Smithsonian Astrophysical Observation", "SAO 226223"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.08020746),
        dec: Angle.Degrees(-44.35177752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136965"},
        {"Hipparcos Number", "HIP 75481"},
        {"Smithsonian Astrophysical Observation", "SAO 225756"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.29155900),
        dec: Angle.Degrees(-44.35103316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67981"},
        {"Hipparcos Number", "HIP 39861"},
        {"Celescope Catalog", "CEL 2181"},
        {"Geneva Identification System", "GEN# +1.00067981"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.14408494),
        dec: Angle.Degrees(-44.35053167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99572"},
        {"Hipparcos Number", "HIP 55860"},
        {"Smithsonian Astrophysical Observation", "SAO 222803"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.73943655),
        dec: Angle.Degrees(-44.35040177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21888"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.57900770),
        dec: Angle.Degrees(-44.34906812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9662"},
        {"Hipparcos Number", "HIP 7286"},
        {"Geneva Identification System", "GEN# +1.00009662"},
        {"Smithsonian Astrophysical Observation", "SAO 215560"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.46841645),
        dec: Angle.Degrees(-44.34826652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17365"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.77641937),
        dec: Angle.Degrees(-12.89441202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46002"},
        {"Hipparcos Number", "HIP 30831"},
        {"Smithsonian Astrophysical Observation", "SAO 217952"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.14902942),
        dec: Angle.Degrees(-44.34815749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69710"},
        {"Hipparcos Number", "HIP 40515"},
        {"Celescope Catalog", "CEL 2304"},
        {"Geneva Identification System", "GEN# +1.00069710"},
        {"Smithsonian Astrophysical Observation", "SAO 219703"},
    },
    visualMagnitude: 9.09,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.07677359),
        dec: Angle.Degrees(-44.34351252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24210"},
        {"Hipparcos Number", "HIP 17868"},
        {"Smithsonian Astrophysical Observation", "SAO 216504"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.35255076),
        dec: Angle.Degrees(-44.34338988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90740"},
        {"Hipparcos Number", "HIP 51217"},
        {"Geneva Identification System", "GEN# +1.00090740"},
        {"Smithsonian Astrophysical Observation", "SAO 222071"},
        {"Wilson Evans Batten Catalogue", "WEB 9362"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.92257849),
        dec: Angle.Degrees(-44.34225867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163145"},
        {"Hipparcos Number", "HIP 87846"},
        {"Fundamental Katalog 5th Edition", "FK5 3425"},
        {"Geneva Identification System", "GEN# +1.00163145"},
        {"Smithsonian Astrophysical Observation", "SAO 228562"},
        {"Wilson Evans Batten Catalogue", "WEB 14829"},
    },
    visualMagnitude: 4.85,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.19760682),
        dec: Angle.Degrees(-44.34219871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190309"},
        {"Hipparcos Number", "HIP 99022"},
        {"Geneva Identification System", "GEN# +1.00190309"},
        {"Smithsonian Astrophysical Observation", "SAO 230037"},
        {"Wilson Evans Batten Catalogue", "WEB 17601"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.54596705),
        dec: Angle.Degrees(-44.34142821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198698"},
        {"Hipparcos Number", "HIP 103133"},
        {"Smithsonian Astrophysical Observation", "SAO 230422"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.43466064),
        dec: Angle.Degrees(-44.34074373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156272"},
        {"Hipparcos Number", "HIP 84689"},
        {"Smithsonian Astrophysical Observation", "SAO 227812"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.69629129),
        dec: Angle.Degrees(-44.33829222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195902"},
        {"Hipparcos Number", "HIP 101623"},
        {"Smithsonian Astrophysical Observation", "SAO 230289"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.94923064),
        dec: Angle.Degrees(-44.33764333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174386"},
        {"Hipparcos Number", "HIP 92622"},
        {"Geneva Identification System", "GEN# +1.00174386"},
        {"Smithsonian Astrophysical Observation", "SAO 229335"},
        {"Wilson Evans Batten Catalogue", "WEB 16020"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.08584815),
        dec: Angle.Degrees(-44.33598264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162171"},
        {"Hipparcos Number", "HIP 87412"},
        {"Smithsonian Astrophysical Observation", "SAO 228493"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.96087949),
        dec: Angle.Degrees(-44.33598204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33649"},
        {"Hipparcos Number", "HIP 24008"},
        {"Geneva Identification System", "GEN# +1.00033649"},
        {"Smithsonian Astrophysical Observation", "SAO 217205"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.41565550),
        dec: Angle.Degrees(-44.33572228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131503"},
        {"Hipparcos Number", "HIP 73024"},
        {"Geneva Identification System", "GEN# +1.00131503"},
        {"Smithsonian Astrophysical Observation", "SAO 225292"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.85757619),
        dec: Angle.Degrees(-44.33403546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76268"},
        {"Hipparcos Number", "HIP 43643"},
        {"Celescope Catalog", "CEL 3040"},
        {"Geneva Identification System", "GEN# +1.00076268"},
        {"Smithsonian Astrophysical Observation", "SAO 220618"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.34292083),
        dec: Angle.Degrees(-44.33308136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11113"},
        {"Hipparcos Number", "HIP 8391"},
        {"Smithsonian Astrophysical Observation", "SAO 215659"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.06061128),
        dec: Angle.Degrees(-44.33258441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99550"},
    },
    visualMagnitude: 11.30,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.03891089),
        dec: Angle.Degrees(-12.89269070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126606"},
        {"Hipparcos Number", "HIP 70716"},
        {"Geneva Identification System", "GEN# +1.00126606"},
        {"Smithsonian Astrophysical Observation", "SAO 224941"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.93955019),
        dec: Angle.Degrees(-44.33019118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118878"},
        {"Hipparcos Number", "HIP 66722"},
        {"Geneva Identification System", "GEN# +1.00118878"},
        {"Smithsonian Astrophysical Observation", "SAO 224322"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.15697611),
        dec: Angle.Degrees(-44.33018533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67268"},
        {"Hipparcos Number", "HIP 39581"},
        {"Geneva Identification System", "GEN# +1.00067268"},
        {"Smithsonian Astrophysical Observation", "SAO 219392"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.32143499),
        dec: Angle.Degrees(-44.32818872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15074"},
        {"Hipparcos Number", "HIP 11216"},
        {"Smithsonian Astrophysical Observation", "SAO 215891"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.09155955),
        dec: Angle.Degrees(-44.32777512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105509"},
        {"Hipparcos Number", "HIP 59229"},
        {"Geneva Identification System", "GEN# +1.00105509"},
        {"Renson", "Renson 30510"},
        {"Smithsonian Astrophysical Observation", "SAO 223241"},
    },
    visualMagnitude: 5.75,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.22432744),
        dec: Angle.Degrees(-44.32588609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212104"},
        {"Hipparcos Number", "HIP 110481"},
        {"Smithsonian Astrophysical Observation", "SAO 231107"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.69042929),
        dec: Angle.Degrees(-44.32480859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202650"},
        {"Hipparcos Number", "HIP 105206"},
        {"Geneva Identification System", "GEN# +1.00202650"},
        {"Smithsonian Astrophysical Observation", "SAO 230623"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.66566827),
        dec: Angle.Degrees(-44.32411845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69567"},
        {"Hipparcos Number", "HIP 40463"},
        {"Celescope Catalog", "CEL 2294"},
        {"Smithsonian Astrophysical Observation", "SAO 219693"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.92672692),
        dec: Angle.Degrees(-44.32287865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158547"},
        {"Hipparcos Number", "HIP 85818"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.03041248),
        dec: Angle.Degrees(-44.32210649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46743"},
        {"Hipparcos Number", "HIP 31217"},
        {"Geneva Identification System", "GEN# +1.00046743"},
        {"Smithsonian Astrophysical Observation", "SAO 218010"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.23002111),
        dec: Angle.Degrees(-44.32177942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107801"},
        {"Hipparcos Number", "HIP 60435"},
        {"Smithsonian Astrophysical Observation", "SAO 223401"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.86369576),
        dec: Angle.Degrees(-44.32036247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205820"},
        {"Hipparcos Number", "HIP 106910"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.78613141),
        dec: Angle.Degrees(-44.31829375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86214"},
        {"Cincinnati Publication", "Ci 20 1046"},
        {"Geneva Identification System", "GEN# -0.04411909"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.26766824),
        dec: Angle.Degrees(-44.31693542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -710.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -937.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49798"},
        {"Hipparcos Number", "HIP 32602"},
        {"Celescope Catalog", "CEL 1390"},
        {"Geneva Identification System", "GEN# +1.00049798"},
        {"Renson", "Renson 13500"},
        {"Smithsonian Astrophysical Observation", "SAO 218207"},
        {"Wilson Evans Batten Catalogue", "WEB 6574"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.01959936),
        dec: Angle.Degrees(-44.31624572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19680"},
        {"Hipparcos Number", "HIP 14602"},
        {"Smithsonian Astrophysical Observation", "SAO 216178"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.13318579),
        dec: Angle.Degrees(-44.31418460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208370"},
        {"Hipparcos Number", "HIP 108337"},
        {"Smithsonian Astrophysical Observation", "SAO 230908"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.23266577),
        dec: Angle.Degrees(-44.31288633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110113"},
        {"Hipparcos Number", "HIP 61820"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.03659896),
        dec: Angle.Degrees(-44.31198500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126093"},
        {"Hipparcos Number", "HIP 70451"},
        {"Smithsonian Astrophysical Observation", "SAO 224903"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.17017995),
        dec: Angle.Degrees(-44.31103431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40305"},
        {"Hipparcos Number", "HIP 28040"},
        {"Smithsonian Astrophysical Observation", "SAO 217626"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.95136334),
        dec: Angle.Degrees(-44.31096601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91212"},
        {"Geneva Identification System", "GEN# -0.04412736"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.10869064),
        dec: Angle.Degrees(-44.30986780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172413"},
        {"Hipparcos Number", "HIP 91710"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54049241),
        dec: Angle.Degrees(-44.30911045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15422"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.68936882),
        dec: Angle.Degrees(-44.30868186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91595",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91595"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.19500038),
        dec: Angle.Degrees(-44.30800290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50568"},
        {"Hipparcos Number", "HIP 32935"},
        {"Geneva Identification System", "GEN# +1.00050568A"},
        {"Smithsonian Astrophysical Observation", "SAO 218259"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.92136883),
        dec: Angle.Degrees(-44.30635236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190480"},
        {"Hipparcos Number", "HIP 99083"},
        {"Geneva Identification System", "GEN# +1.00190480"},
        {"Smithsonian Astrophysical Observation", "SAO 230044"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.73016662),
        dec: Angle.Degrees(-44.30297524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127731"},
        {"Hipparcos Number", "HIP 71258"},
        {"Smithsonian Astrophysical Observation", "SAO 225029"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.59166166),
        dec: Angle.Degrees(-44.30227617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175396"},
        {"Hipparcos Number", "HIP 93056"},
        {"Fundamental Katalog 5th Edition", "FK5 5670"},
        {"Geneva Identification System", "GEN# +1.00175396"},
        {"Smithsonian Astrophysical Observation", "SAO 229398"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.32464081),
        dec: Angle.Degrees(-44.30131906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152097"},
        {"Hipparcos Number", "HIP 82613"},
        {"Smithsonian Astrophysical Observation", "SAO 227347"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.33105944),
        dec: Angle.Degrees(-44.30106694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71304"},
        {"Hipparcos Number", "HIP 41246"},
        {"Celescope Catalog", "CEL 2483"},
        {"Geneva Identification System", "GEN# +1.00071304A"},
        {"Smithsonian Astrophysical Observation", "SAO 219892"},
        {"Wilson Evans Batten Catalogue", "WEB 7980"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.23246687),
        dec: Angle.Degrees(-44.30084571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149640"},
        {"Hipparcos Number", "HIP 81444"},
        {"Geneva Identification System", "GEN# +1.00149640"},
        {"Smithsonian Astrophysical Observation", "SAO 226981"},
        {"Wilson Evans Batten Catalogue", "WEB 13763"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.51141792),
        dec: Angle.Degrees(-44.30038169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59356"},
        {"Hipparcos Number", "HIP 36219"},
        {"Smithsonian Astrophysical Observation", "SAO 218736"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.88068299),
        dec: Angle.Degrees(-44.28460509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166087"},
        {"Hipparcos Number", "HIP 89108"},
        {"Smithsonian Astrophysical Observation", "SAO 228779"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.79969775),
        dec: Angle.Degrees(-44.29934894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180496"},
        {"Hipparcos Number", "HIP 94906"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.68948293),
        dec: Angle.Degrees(-44.29688358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60929"},
        {"Hipparcos Number", "HIP 36875"},
        {"Celescope Catalog", "CEL 1937"},
        {"Geneva Identification System", "GEN# +1.00060929"},
        {"Smithsonian Astrophysical Observation", "SAO 218818"},
    },
    visualMagnitude: 6.81,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.71281461),
        dec: Angle.Degrees(-44.29614752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27317"},
        {"Hipparcos Number", "HIP 19951"},
        {"Smithsonian Astrophysical Observation", "SAO 216733"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.18612569),
        dec: Angle.Degrees(-44.29382424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136486"},
        {"Hipparcos Number", "HIP 75247"},
        {"Celescope Catalog", "CEL 4367"},
        {"Geneva Identification System", "GEN# +1.00136486"},
        {"Smithsonian Astrophysical Observation", "SAO 225711"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.63835146),
        dec: Angle.Degrees(-44.29286012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72512"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.39543803),
        dec: Angle.Degrees(-44.29226749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200872"},
        {"Hipparcos Number", "HIP 104286"},
        {"Smithsonian Astrophysical Observation", "SAO 230532"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.90630933),
        dec: Angle.Degrees(-44.29175789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33499"},
        {"Cincinnati Publication", "Ci 20 407"},
        {"Geneva Identification System", "GEN# +9.51503071"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.44792505),
        dec: Angle.Degrees(-44.29109677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1102.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224750"},
        {"Hipparcos Number", "HIP 25"},
        {"Geneva Identification System", "GEN# +1.00224750"},
        {"Smithsonian Astrophysical Observation", "SAO 231888"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.07936537),
        dec: Angle.Degrees(-44.29029741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97693"},
    },
    visualMagnitude: 10.87,
    bvColour: 1.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.81068163),
        dec: Angle.Degrees(-44.29025406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -286.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144594"},
        {"Hipparcos Number", "HIP 79084"},
        {"Smithsonian Astrophysical Observation", "SAO 226532"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.14836175),
        dec: Angle.Degrees(-44.28995571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87607"},
        {"Geneva Identification System", "GEN# +6.20145004"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.45278875),
        dec: Angle.Degrees(-44.28917502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139525"},
        {"Hipparcos Number", "HIP 76762"},
        {"Celescope Catalog", "CEL 4389"},
        {"Geneva Identification System", "GEN# +1.00139525"},
        {"Renson", "Renson 39720"},
        {"Smithsonian Astrophysical Observation", "SAO 226049"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.10291528),
        dec: Angle.Degrees(-44.28855964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121915"},
        {"Hipparcos Number", "HIP 68354"},
        {"Geneva Identification System", "GEN# +1.00121915"},
        {"Smithsonian Astrophysical Observation", "SAO 224597"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.87636639),
        dec: Angle.Degrees(-44.28559428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93868"},
        {"Hipparcos Number", "HIP 52927"},
        {"Geneva Identification System", "GEN# +1.00093868"},
        {"Smithsonian Astrophysical Observation", "SAO 222362"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.36537343),
        dec: Angle.Degrees(-44.28487551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51719"},
    },
    visualMagnitude: 11.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.50842889),
        dec: Angle.Degrees(-44.00875022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184625"},
        {"Hipparcos Number", "HIP 96519"},
        {"Smithsonian Astrophysical Observation", "SAO 229775"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.32677186),
        dec: Angle.Degrees(-44.28424155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123635"},
        {"Hipparcos Number", "HIP 69192"},
        {"Geneva Identification System", "GEN# +1.00123635J"},
        {"Smithsonian Astrophysical Observation", "SAO 224734"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)09, 55.7600),
        dec: Angle.DegreesMinutesSeconds((int)-44, (int)17, 02.300)
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
    primaryId: "HIP 45820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80817"},
        {"Hipparcos Number", "HIP 45820"},
        {"Geneva Identification System", "GEN# +1.00080817"},
        {"Smithsonian Astrophysical Observation", "SAO 221080"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.13833778),
        dec: Angle.Degrees(-44.28318817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105919"},
        {"Hipparcos Number", "HIP 59433"},
        {"Fundamental Katalog 5th Edition", "FK5 2975"},
        {"Geneva Identification System", "GEN# +1.00105919"},
        {"Smithsonian Astrophysical Observation", "SAO 223269"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.86876154),
        dec: Angle.Degrees(-44.28275840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52576"},
        {"Hipparcos Number", "HIP 33658"},
        {"Geneva Identification System", "GEN# +1.00052576"},
        {"Smithsonian Astrophysical Observation", "SAO 218371"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.88915833),
        dec: Angle.Degrees(-44.28211434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31145"},
        {"Hipparcos Number", "HIP 22546"},
        {"Smithsonian Astrophysical Observation", "SAO 217040"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.78931693),
        dec: Angle.Degrees(-44.28030197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202703"},
        {"Hipparcos Number", "HIP 105242"},
        {"Smithsonian Astrophysical Observation", "SAO 230624"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.76251743),
        dec: Angle.Degrees(-44.27959423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203496"},
        {"Hipparcos Number", "HIP 105647"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.98286590),
        dec: Angle.Degrees(-44.27954408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141962"},
        {"Hipparcos Number", "HIP 77848"},
        {"Geneva Identification System", "GEN# +1.00141962"},
        {"Smithsonian Astrophysical Observation", "SAO 226341"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.42886223),
        dec: Angle.Degrees(-44.27924322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93494"},
        {"Hipparcos Number", "HIP 52740"},
        {"Smithsonian Astrophysical Observation", "SAO 222327"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.72905463),
        dec: Angle.Degrees(-44.27796268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144337"},
        {"Hipparcos Number", "HIP 78974"},
        {"Smithsonian Astrophysical Observation", "SAO 226516"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.82235629),
        dec: Angle.Degrees(-44.27741019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212605"},
        {"Hipparcos Number", "HIP 110765"},
        {"Smithsonian Astrophysical Observation", "SAO 231139"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.60328178),
        dec: Angle.Degrees(-44.27461533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 395"},
        {"Hipparcos Number", "HIP 684"},
        {"Geneva Identification System", "GEN# +1.00000395"},
        {"Smithsonian Astrophysical Observation", "SAO 214977"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.11027964),
        dec: Angle.Degrees(-44.27363457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28886"},
        {"Hipparcos Number", "HIP 21073"},
        {"Geneva Identification System", "GEN# +1.00028886"},
        {"Smithsonian Astrophysical Observation", "SAO 216852"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.75465810),
        dec: Angle.Degrees(-44.27236863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73075"},
        {"Hipparcos Number", "HIP 42078"},
        {"Geneva Identification System", "GEN# +4.27040001"},
        {"Smithsonian Astrophysical Observation", "SAO 220129"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.64871294),
        dec: Angle.Degrees(-44.27022676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63662"},
        {"Hipparcos Number", "HIP 38059"},
        {"Smithsonian Astrophysical Observation", "SAO 219007"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.01015483),
        dec: Angle.Degrees(-44.27014917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155033"},
        {"Hipparcos Number", "HIP 84066"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.79774968),
        dec: Angle.Degrees(-44.26879615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30694"},
        {"Hipparcos Number", "HIP 22268"},
        {"Geneva Identification System", "GEN# +1.00030694"},
        {"Smithsonian Astrophysical Observation", "SAO 216994"},
        {"Wilson Evans Batten Catalogue", "WEB 4288"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.91681561),
        dec: Angle.Degrees(-44.26849967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107492"},
        {"Henry Draper 2", "HD 107493"},
        {"Hipparcos Number", "HIP 60275"},
        {"Geneva Identification System", "GEN# +1.00107492"},
        {"Smithsonian Astrophysical Observation", "SAO 223376"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.38582106),
        dec: Angle.Degrees(-44.26841321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27588"},
        {"Hipparcos Number", "HIP 20161"},
        {"Geneva Identification System", "GEN# +1.00027588A"},
        {"Smithsonian Astrophysical Observation", "SAO 216749"},
        {"Wilson Evans Batten Catalogue", "WEB 3845"},
    },
    visualMagnitude: 5.33,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.81935490),
        dec: Angle.Degrees(-44.26783026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80108"},
        {"Hipparcos Number", "HIP 45505"},
        {"Geneva Identification System", "GEN# +1.00080108"},
        {"Smithsonian Astrophysical Observation", "SAO 221014"},
        {"Wilson Evans Batten Catalogue", "WEB 8653"},
    },
    visualMagnitude: 5.12,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.09598912),
        dec: Angle.Degrees(-44.26574592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76898"},
        {"Hipparcos Number", "HIP 43987"},
        {"Celescope Catalog", "CEL 3103"},
        {"Geneva Identification System", "GEN# +1.00076898"},
        {"Smithsonian Astrophysical Observation", "SAO 220696"},
        {"Wilson Evans Batten Catalogue", "WEB 8456"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.36800775),
        dec: Angle.Degrees(-44.26540945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118897"},
        {"Hipparcos Number", "HIP 66733"},
        {"Smithsonian Astrophysical Observation", "SAO 224325"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.17540471),
        dec: Angle.Degrees(-44.26136872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54469"},
        {"Geneva Identification System", "GEN# -0.04306810"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.16705572),
        dec: Angle.Degrees(-44.25880233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6621"},
        {"Hipparcos Number", "HIP 5187"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.59717626),
        dec: Angle.Degrees(-44.25711928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30541"},
        {"Hipparcos Number", "HIP 22202"},
        {"Geneva Identification System", "GEN# +1.00030541"},
        {"Smithsonian Astrophysical Observation", "SAO 216989"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.61796654),
        dec: Angle.Degrees(-44.25664055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70506"},
        {"Hipparcos Number", "HIP 40884"},
        {"Celescope Catalog", "CEL 2399"},
        {"Smithsonian Astrophysical Observation", "SAO 219811"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.14404544),
        dec: Angle.Degrees(-44.25500207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3143"},
    },
    visualMagnitude: 11.41,
    bvColour: 1.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.99346024),
        dec: Angle.Degrees(-44.25267874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 482.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214987"},
        {"Hipparcos Number", "HIP 112127"},
        {"Geneva Identification System", "GEN# +1.00214987"},
        {"Smithsonian Astrophysical Observation", "SAO 231260"},
    },
    visualMagnitude: 6.06,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.67939148),
        dec: Angle.Degrees(-44.24812216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75009"},
        {"Hipparcos Number", "HIP 42997"},
        {"Celescope Catalog", "CEL 2872"},
        {"Geneva Identification System", "GEN# +1.00075009"},
        {"Smithsonian Astrophysical Observation", "SAO 220412"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.44789870),
        dec: Angle.Degrees(-44.24802773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221806"},
        {"Hipparcos Number", "HIP 116413"},
        {"Smithsonian Astrophysical Observation", "SAO 231678"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.85230401),
        dec: Angle.Degrees(-44.24738308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56433"},
    },
    visualMagnitude: 12.92,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.55239963),
        dec: Angle.Degrees(-43.70481981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132921"},
        {"Hipparcos Number", "HIP 73648"},
        {"Smithsonian Astrophysical Observation", "SAO 225402"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.81507742),
        dec: Angle.Degrees(-44.24708665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139524"},
        {"Hipparcos Number", "HIP 76760"},
        {"Geneva Identification System", "GEN# +1.00139524"},
        {"Smithsonian Astrophysical Observation", "SAO 226048"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.09793276),
        dec: Angle.Degrees(-44.24691841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84399"},
        {"Hipparcos Number", "HIP 47721"},
        {"Smithsonian Astrophysical Observation", "SAO 221430"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.93078905),
        dec: Angle.Degrees(-44.24640832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86844"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.16749424),
        dec: Angle.Degrees(-44.24576207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20828"},
        {"Hipparcos Number", "HIP 15488"},
        {"Smithsonian Astrophysical Observation", "SAO 216262"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.90811911),
        dec: Angle.Degrees(-44.24508996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51063"},
        {"Hipparcos Number", "HIP 33099"},
        {"Smithsonian Astrophysical Observation", "SAO 218289"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.40782775),
        dec: Angle.Degrees(-44.24477113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329666"},
        {"Hipparcos Number", "HIP 84452"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.98955276),
        dec: Angle.Degrees(-44.24408800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102849"},
        {"Hipparcos Number", "HIP 57733"},
        {"Smithsonian Astrophysical Observation", "SAO 223051"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.58586619),
        dec: Angle.Degrees(-44.24378273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90201"},
        {"Hipparcos Number", "HIP 50912"},
        {"Smithsonian Astrophysical Observation", "SAO 222019"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.94735706),
        dec: Angle.Degrees(-44.24243745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6317"},
        {"Hipparcos Number", "HIP 4959"},
        {"Smithsonian Astrophysical Observation", "SAO 215347"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.89722063),
        dec: Angle.Degrees(-44.24189584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129035"},
        {"Hipparcos Number", "HIP 71835"},
        {"Smithsonian Astrophysical Observation", "SAO 225124"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.42305417),
        dec: Angle.Degrees(-44.24183373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172462"},
        {"Hipparcos Number", "HIP 91745"},
        {"Geneva Identification System", "GEN# +1.00172462"},
        {"Smithsonian Astrophysical Observation", "SAO 229216"},
        {"Wilson Evans Batten Catalogue", "WEB 15783"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.62577716),
        dec: Angle.Degrees(-44.24172968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11219"},
        {"Hipparcos Number", "HIP 8477"},
        {"Smithsonian Astrophysical Observation", "SAO 215666"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.32070885),
        dec: Angle.Degrees(-44.24131923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68718"},
        {"Hipparcos Number", "HIP 40126"},
        {"Celescope Catalog", "CEL 2226"},
        {"Geneva Identification System", "GEN# +1.00068718"},
        {"Smithsonian Astrophysical Observation", "SAO 219575"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.94662851),
        dec: Angle.Degrees(-44.24034483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81825"},
        {"Hipparcos Number", "HIP 46319"},
        {"Geneva Identification System", "GEN# +1.00081825"},
        {"Smithsonian Astrophysical Observation", "SAO 221173"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.66919168),
        dec: Angle.Degrees(-44.23962612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67061"},
        {"Hipparcos Number", "HIP 39493"},
        {"Geneva Identification System", "GEN# +1.00067061"},
        {"Smithsonian Astrophysical Observation", "SAO 219375"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.09378195),
        dec: Angle.Degrees(-44.23697577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209883"},
        {"Hipparcos Number", "HIP 109210"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.86919414),
        dec: Angle.Degrees(-44.23581918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204567"},
        {"Hipparcos Number", "HIP 106214"},
        {"Smithsonian Astrophysical Observation", "SAO 230719"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.69895212),
        dec: Angle.Degrees(-44.23407053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136936"},
        {"Hipparcos Number", "HIP 75466"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.24713511),
        dec: Angle.Degrees(-44.23264842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129510"},
        {"Hipparcos Number", "HIP 72057"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.08339870),
        dec: Angle.Degrees(-44.23258290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21165"},
        {"Hipparcos Number", "HIP 15768"},
        {"Smithsonian Astrophysical Observation", "SAO 216290"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.80046555),
        dec: Angle.Degrees(-44.23171967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83829"},
        {"Hipparcos Number", "HIP 47417"},
        {"Smithsonian Astrophysical Observation", "SAO 221383"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.93387014),
        dec: Angle.Degrees(-44.23090963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136184"},
        {"Hipparcos Number", "HIP 75102"},
        {"Smithsonian Astrophysical Observation", "SAO 225678"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.20011441),
        dec: Angle.Degrees(-44.22881972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70716"},
        {"Hipparcos Number", "HIP 40973"},
        {"Celescope Catalog", "CEL 2422"},
        {"Geneva Identification System", "GEN# +1.00070716"},
        {"Smithsonian Astrophysical Observation", "SAO 219834"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.42233978),
        dec: Angle.Degrees(-44.22729371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177522"},
        {"Hipparcos Number", "HIP 93888"},
        {"Smithsonian Astrophysical Observation", "SAO 229499"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.78511879),
        dec: Angle.Degrees(-44.22583561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35765"},
        {"Hipparcos Number", "HIP 25317"},
        {"Fundamental Katalog 5th Edition", "FK5 2407"},
        {"Geneva Identification System", "GEN# +1.00035765"},
        {"Smithsonian Astrophysical Observation", "SAO 217325"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.23157887),
        dec: Angle.Degrees(-44.22570485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67297"},
        {"Hipparcos Number", "HIP 39585"},
        {"Geneva Identification System", "GEN# +1.00067297"},
        {"Smithsonian Astrophysical Observation", "SAO 219397"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.33485340),
        dec: Angle.Degrees(-44.22462733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42902"},
        {"Hipparcos Number", "HIP 29349"},
        {"Geneva Identification System", "GEN# +1.00042902"},
        {"Smithsonian Astrophysical Observation", "SAO 217762"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.80834278),
        dec: Angle.Degrees(-44.22434509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105863"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.61333862),
        dec: Angle.Degrees(-44.22359358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173184"},
        {"Hipparcos Number", "HIP 92094"},
        {"Smithsonian Astrophysical Observation", "SAO 229262"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.53735438),
        dec: Angle.Degrees(-44.22300943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156398"},
        {"Hipparcos Number", "HIP 84748"},
        {"Celescope Catalog", "CEL 4502"},
        {"Geneva Identification System", "GEN# +1.00156398J"},
        {"Renson", "Renson 44054"},
        {"Smithsonian Astrophysical Observation", "SAO 227821"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.85262157),
        dec: Angle.Degrees(-44.22299964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34326"},
        {"Hipparcos Number", "HIP 24439"},
        {"Smithsonian Astrophysical Observation", "SAO 217253"},
    },
    visualMagnitude: 8.48,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.64778295),
        dec: Angle.Degrees(-44.22272706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92500"},
        {"Hipparcos Number", "HIP 52213"},
    },
    visualMagnitude: 9.40,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.01449777),
        dec: Angle.Degrees(-44.22272683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46463"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.13303784),
        dec: Angle.Degrees(-44.22209382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189585"},
        {"Hipparcos Number", "HIP 98678"},
        {"Geneva Identification System", "GEN# +1.00189585"},
        {"Smithsonian Astrophysical Observation", "SAO 230003"},
        {"Wilson Evans Batten Catalogue", "WEB 17465"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.64341577),
        dec: Angle.Degrees(-44.22202432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122014"},
        {"Hipparcos Number", "HIP 68409"},
        {"Smithsonian Astrophysical Observation", "SAO 224605"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.05787596),
        dec: Angle.Degrees(-44.22186193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19693"},
        {"Hipparcos Number", "HIP 14608"},
        {"Smithsonian Astrophysical Observation", "SAO 216181"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.16463180),
        dec: Angle.Degrees(-44.22161149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25073"},
        {"Hipparcos Number", "HIP 18496"},
        {"Smithsonian Astrophysical Observation", "SAO 216574"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.30359253),
        dec: Angle.Degrees(-44.22113781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46682"},
        {"Hipparcos Number", "HIP 31186"},
        {"Smithsonian Astrophysical Observation", "SAO 218005"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.15258983),
        dec: Angle.Degrees(-44.22086464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18497"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.30776298),
        dec: Angle.Degrees(-44.21991742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206321"},
        {"Hipparcos Number", "HIP 107178"},
        {"Smithsonian Astrophysical Observation", "SAO 230800"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.63966529),
        dec: Angle.Degrees(-44.21676908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178113"},
        {"Hipparcos Number", "HIP 94111"},
        {"Fundamental Katalog 5th Edition", "FK5 5685"},
        {"Geneva Identification System", "GEN# +1.00178113"},
        {"Smithsonian Astrophysical Observation", "SAO 229523"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.35144854),
        dec: Angle.Degrees(-44.21538422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67456"},
        {"Smithsonian Astrophysical Observation", "SAO 224465"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.36077050),
        dec: Angle.Degrees(-44.21454865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120273"},
        {"Hipparcos Number", "HIP 67455"},
        {"Geneva Identification System", "GEN# +1.00120273"},
        {"Smithsonian Astrophysical Observation", "SAO 224464"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.35821821),
        dec: Angle.Degrees(-44.21133935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69647"},
        {"Hipparcos Number", "HIP 40493"},
        {"Geneva Identification System", "GEN# +1.00069647"},
        {"Smithsonian Astrophysical Observation", "SAO 219700"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.01421308),
        dec: Angle.Degrees(-44.21128106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201245"},
        {"Hipparcos Number", "HIP 104469"},
        {"Geneva Identification System", "GEN# +1.00201245"},
        {"Smithsonian Astrophysical Observation", "SAO 230552"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.43352628),
        dec: Angle.Degrees(-44.20980976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5894"},
        {"Hipparcos Number", "HIP 4654"},
        {"Smithsonian Astrophysical Observation", "SAO 215318"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.95420377),
        dec: Angle.Degrees(-44.20874821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66944"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.80611968),
        dec: Angle.Degrees(-44.20684439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167096"},
        {"Hipparcos Number", "HIP 89507"},
        {"Geneva Identification System", "GEN# +1.00167096"},
        {"Smithsonian Astrophysical Observation", "SAO 228851"},
        {"Smithsonian Astrophysical Observation 2", "SAO 228854"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.97247295),
        dec: Angle.Degrees(-44.20649632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220157"},
        {"Hipparcos Number", "HIP 115348"},
        {"Smithsonian Astrophysical Observation", "SAO 231564"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.46346191),
        dec: Angle.Degrees(-44.20372578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211000"},
        {"Hipparcos Number", "HIP 109871"},
        {"Smithsonian Astrophysical Observation", "SAO 231049"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.79604522),
        dec: Angle.Degrees(-44.20186244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80660"},
        {"Hipparcos Number", "HIP 45748"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.92395146),
        dec: Angle.Degrees(-44.20148275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24048"},
        {"Hipparcos Number", "HIP 17751"},
        {"Smithsonian Astrophysical Observation", "SAO 216493"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.00680922),
        dec: Angle.Degrees(-44.20072641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202716"},
        {"Hipparcos Number", "HIP 105251"},
        {"Smithsonian Astrophysical Observation", "SAO 230626"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.78126843),
        dec: Angle.Degrees(-44.19881645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124434"},
        {"Hipparcos Number", "HIP 69597"},
        {"Smithsonian Astrophysical Observation", "SAO 224787"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.67791734),
        dec: Angle.Degrees(-44.19848213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122158"},
        {"Hipparcos Number", "HIP 68475"},
        {"Smithsonian Astrophysical Observation", "SAO 224618"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.28593921),
        dec: Angle.Degrees(-44.19762581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7972"},
        {"Hipparcos Number", "HIP 6104"},
        {"Geneva Identification System", "GEN# +1.00007972"},
        {"Smithsonian Astrophysical Observation", "SAO 215449"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.59419282),
        dec: Angle.Degrees(-44.19704670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197900"},
        {"Hipparcos Number", "HIP 102670"},
        {"Geneva Identification System", "GEN# +1.00197900"},
        {"Smithsonian Astrophysical Observation", "SAO 230375"},
        {"Wilson Evans Batten Catalogue", "WEB 18609"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.07648948),
        dec: Angle.Degrees(-44.19670220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97842"},
        {"Hipparcos Number", "HIP 54925"},
        {"Smithsonian Astrophysical Observation", "SAO 222668"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.71103093),
        dec: Angle.Degrees(-44.19646065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21934"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.73562650),
        dec: Angle.Degrees(-44.19527119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182071"},
        {"Hipparcos Number", "HIP 95445"},
        {"Fundamental Katalog 5th Edition", "FK5 5707"},
        {"Smithsonian Astrophysical Observation", "SAO 229666"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.23347993),
        dec: Angle.Degrees(-44.19477888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218023"},
        {"Hipparcos Number", "HIP 114000"},
        {"Smithsonian Astrophysical Observation", "SAO 231427"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.31199646),
        dec: Angle.Degrees(-44.19385857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31826"},
        {"Hipparcos Number", "HIP 22999"},
        {"Geneva Identification System", "GEN# +1.00031826"},
        {"Smithsonian Astrophysical Observation", "SAO 217072"},
        {"Wilson Evans Batten Catalogue", "WEB 4464"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.21159030),
        dec: Angle.Degrees(-44.19255049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119222"},
        {"Hipparcos Number", "HIP 66917"},
        {"Geneva Identification System", "GEN# +1.00119222"},
        {"Smithsonian Astrophysical Observation", "SAO 224356"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.70814451),
        dec: Angle.Degrees(-44.19086453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79331"},
        {"Hipparcos Number", "HIP 45151"},
        {"Geneva Identification System", "GEN# +1.00079331"},
        {"Smithsonian Astrophysical Observation", "SAO 220944"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.98220317),
        dec: Angle.Degrees(-44.18928862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83247"},
        {"Hipparcos Number", "HIP 47082"},
        {"Renson", "Renson 23730"},
        {"Smithsonian Astrophysical Observation", "SAO 221318"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.92205992),
        dec: Angle.Degrees(-44.18815127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70872"},
        {"Hipparcos Number", "HIP 41052"},
        {"Celescope Catalog", "CEL 2439"},
        {"Geneva Identification System", "GEN# +1.00070872"},
        {"Smithsonian Astrophysical Observation", "SAO 219845"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.65151800),
        dec: Angle.Degrees(-44.18602194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109251"},
        {"Hipparcos Number", "HIP 61311"},
        {"Smithsonian Astrophysical Observation", "SAO 223512"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.41355542),
        dec: Angle.Degrees(-44.18407912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95444"},
        {"Hipparcos Number", "HIP 53803"},
        {"Smithsonian Astrophysical Observation", "SAO 222496"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.13076945),
        dec: Angle.Degrees(-44.17992462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129202"},
        {"Hipparcos Number", "HIP 71923"},
        {"Smithsonian Astrophysical Observation", "SAO 225141"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.65484900),
        dec: Angle.Degrees(-44.17850758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79021"},
        {"Hipparcos Number", "HIP 44999"},
        {"Smithsonian Astrophysical Observation", "SAO 220911"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.48432177),
        dec: Angle.Degrees(-44.17573078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191935"},
        {"Hipparcos Number", "HIP 99722"},
        {"Geneva Identification System", "GEN# +1.00191935"},
        {"Smithsonian Astrophysical Observation", "SAO 230113"},
        {"Wilson Evans Batten Catalogue", "WEB 17890"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.52673666),
        dec: Angle.Degrees(-44.17325320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172144"},
        {"Hipparcos Number", "HIP 91588"},
        {"Geneva Identification System", "GEN# +1.00172144"},
        {"Smithsonian Astrophysical Observation", "SAO 229185"},
        {"Wilson Evans Batten Catalogue", "WEB 15748"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.17659688),
        dec: Angle.Degrees(-44.17229307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45795"},
        {"Hipparcos Number", "HIP 30732"},
        {"Smithsonian Astrophysical Observation", "SAO 217938"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.84908212),
        dec: Angle.Degrees(-44.17008802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28914"},
        {"Hipparcos Number", "HIP 21100"},
        {"Geneva Identification System", "GEN# +1.00028914"},
        {"Smithsonian Astrophysical Observation", "SAO 216858"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.81694213),
        dec: Angle.Degrees(-44.16906326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32970"},
        {"Hipparcos Number", "HIP 23630"},
        {"Smithsonian Astrophysical Observation", "SAO 217162"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.20565593),
        dec: Angle.Degrees(-44.16729223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24557"},
        {"Hipparcos Number", "HIP 18120"},
        {"Smithsonian Astrophysical Observation", "SAO 216532"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.11633292),
        dec: Angle.Degrees(-44.16654744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15905"},
        {"Smithsonian Astrophysical Observation", "SAO 148948"},
    },
    visualMagnitude: 9.39,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.21008378),
        dec: Angle.Degrees(-12.84297807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117034"},
        {"Hipparcos Number", "HIP 65713"},
        {"Smithsonian Astrophysical Observation", "SAO 224159"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.08633089),
        dec: Angle.Degrees(-44.16567997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31819",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31819"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.78898615),
        dec: Angle.Degrees(-44.16563732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49501"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.61141700),
        dec: Angle.Degrees(-44.16508848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157243"},
        {"Hipparcos Number", "HIP 85162"},
        {"Celescope Catalog", "CEL 4509"},
        {"Geneva Identification System", "GEN# +1.00157243"},
        {"Smithsonian Astrophysical Observation", "SAO 227911"},
        {"Wilson Evans Batten Catalogue", "WEB 14381"},
    },
    visualMagnitude: 5.10,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.05455256),
        dec: Angle.Degrees(-44.16250170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111720"},
        {"Geneva Identification System", "GEN# +6.20145111"},
    },
    visualMagnitude: 10.28,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.45647045),
        dec: Angle.Degrees(-44.16167203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28246"},
        {"Hipparcos Number", "HIP 20630"},
        {"Geneva Identification System", "GEN# +1.00028246"},
        {"Smithsonian Astrophysical Observation", "SAO 216790"},
        {"Wilson Evans Batten Catalogue", "WEB 3953"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.32957233),
        dec: Angle.Degrees(-44.16105659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72067"},
        {"Hipparcos Number", "HIP 41621"},
        {"Celescope Catalog", "CEL 2555"},
        {"Fundamental Katalog 5th Edition", "FK5 2665"},
        {"Geneva Identification System", "GEN# +1.00072067J"},
        {"Smithsonian Astrophysical Observation", "SAO 219982"},
        {"Wilson Evans Batten Catalogue", "WEB 8031"},
    },
    visualMagnitude: 5.82,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.28155350),
        dec: Angle.Degrees(-44.16043155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143319"},
        {"Hipparcos Number", "HIP 78508"},
        {"Smithsonian Astrophysical Observation", "SAO 226449"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.41039967),
        dec: Angle.Degrees(-44.15736101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149779"},
        {"Hipparcos Number", "HIP 81508"},
        {"Celescope Catalog", "CEL 4422"},
        {"Geneva Identification System", "GEN# +1.00149779"},
        {"Smithsonian Astrophysical Observation", "SAO 226997"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.72451683),
        dec: Angle.Degrees(-44.15720672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165295"},
        {"Hipparcos Number", "HIP 88777"},
        {"Smithsonian Astrophysical Observation", "SAO 228717"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.84389080),
        dec: Angle.Degrees(-44.15716929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130544"},
        {"Hipparcos Number", "HIP 72564"},
        {"Smithsonian Astrophysical Observation", "SAO 225221"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.56022049),
        dec: Angle.Degrees(-44.15707483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159551"},
        {"Hipparcos Number", "HIP 86250"},
        {"Smithsonian Astrophysical Observation", "SAO 228207"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.36797770),
        dec: Angle.Degrees(-44.15617904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16651"},
        {"Hipparcos Number", "HIP 12327"},
        {"Smithsonian Astrophysical Observation", "SAO 215988"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.68638458),
        dec: Angle.Degrees(-44.15447962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126387"},
        {"Hipparcos Number", "HIP 70590"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.58864478),
        dec: Angle.Degrees(-44.15310434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99215"},
        {"Hipparcos Number", "HIP 55693"},
        {"Smithsonian Astrophysical Observation", "SAO 222776"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.17283002),
        dec: Angle.Degrees(-44.15246490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9597"},
        {"Hipparcos Number", "HIP 7242"},
        {"Smithsonian Astrophysical Observation", "SAO 215554"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.32179266),
        dec: Angle.Degrees(-44.15204975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112164"},
        {"Hipparcos Number", "HIP 63033"},
        {"Geneva Identification System", "GEN# +1.00112164"},
        {"Smithsonian Astrophysical Observation", "SAO 223753"},
        {"Wilson Evans Batten Catalogue", "WEB 11176"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.74460949),
        dec: Angle.Degrees(-44.15140639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -230.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76004"},
        {"Hipparcos Number", "HIP 43520"},
        {"Celescope Catalog", "CEL 3013"},
        {"Geneva Identification System", "GEN# +1.00076004"},
        {"Smithsonian Astrophysical Observation", "SAO 220591"},
    },
    visualMagnitude: 6.38,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.95852355),
        dec: Angle.Degrees(-44.15094757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220296"},
        {"Hipparcos Number", "HIP 115440"},
        {"Smithsonian Astrophysical Observation", "SAO 231577"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.74748683),
        dec: Angle.Degrees(-44.14947144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135174"},
        {"Hipparcos Number", "HIP 74657"},
        {"Celescope Catalog", "CEL 4355"},
        {"Geneva Identification System", "GEN# +1.00135174"},
        {"Smithsonian Astrophysical Observation", "SAO 225582"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.83191154),
        dec: Angle.Degrees(-44.14944303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153840"},
        {"Hipparcos Number", "HIP 83498"},
        {"Geneva Identification System", "GEN# +1.00153840"},
        {"Smithsonian Astrophysical Observation", "SAO 227590"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.98103856),
        dec: Angle.Degrees(-44.14941455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120238"},
        {"Hipparcos Number", "HIP 67426"},
        {"Smithsonian Astrophysical Observation", "SAO 224455"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.28549062),
        dec: Angle.Degrees(-44.14906698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66360"},
    },
    visualMagnitude: 11.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.03914423),
        dec: Angle.Degrees(-44.14818542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328584"},
        {"Hipparcos Number", "HIP 81798"},
        {"Geneva Identification System", "GEN# +1.00328584"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.60798007),
        dec: Angle.Degrees(-44.14795246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79694"},
        {"Hipparcos Number", "HIP 45314"},
        {"Celescope Catalog", "CEL 3231"},
        {"Fundamental Katalog 5th Edition", "FK5 2731"},
        {"Geneva Identification System", "GEN# +1.00079694"},
        {"Smithsonian Astrophysical Observation", "SAO 220972"},
        {"Wilson Evans Batten Catalogue", "WEB 8632"},
    },
    visualMagnitude: 5.85,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.53429096),
        dec: Angle.Degrees(-44.14585354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203254"},
        {"Hipparcos Number", "HIP 105541"},
        {"Fundamental Katalog 5th Edition", "FK5 5885"},
        {"Geneva Identification System", "GEN# +1.00203254"},
        {"Smithsonian Astrophysical Observation", "SAO 230655"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.62882903),
        dec: Angle.Degrees(-44.14532492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107022"},
        {"Hipparcos Number", "HIP 60024"},
        {"Geneva Identification System", "GEN# +1.00107022"},
        {"Smithsonian Astrophysical Observation", "SAO 223348"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.65044867),
        dec: Angle.Degrees(-44.14503613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111755"},
    },
    visualMagnitude: 10.42,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.58488728),
        dec: Angle.Degrees(-44.14426058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118338"},
        {"Hipparcos Number", "HIP 66427"},
        {"Fundamental Katalog 5th Edition", "FK5 3084"},
        {"Geneva Identification System", "GEN# +1.00118338"},
        {"Smithsonian Astrophysical Observation", "SAO 224275"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.27521642),
        dec: Angle.Degrees(-44.14316883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38772"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.05038340),
        dec: Angle.Degrees(-44.14259063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176427"},
        {"Hipparcos Number", "HIP 93489"},
        {"Geneva Identification System", "GEN# +1.00176427"},
        {"Smithsonian Astrophysical Observation", "SAO 229447"},
        {"Wilson Evans Batten Catalogue", "WEB 16227"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.59306463),
        dec: Angle.Degrees(-44.14131511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206786"},
        {"Hipparcos Number", "HIP 107439"},
        {"Smithsonian Astrophysical Observation", "SAO 230829"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.41677567),
        dec: Angle.Degrees(-44.13979536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175856"},
        {"Hipparcos Number", "HIP 93229"},
        {"Geneva Identification System", "GEN# +1.00175856"},
        {"Smithsonian Astrophysical Observation", "SAO 229417"},
        {"Wilson Evans Batten Catalogue", "WEB 16162"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.85579177),
        dec: Angle.Degrees(-44.13818490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25795"},
        {"Hipparcos Number", "HIP 18933"},
        {"Geneva Identification System", "GEN# +1.00025795"},
        {"Smithsonian Astrophysical Observation", "SAO 216619"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.87144454),
        dec: Angle.Degrees(-44.13779279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6567"},
    },
    visualMagnitude: 12.01,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.09299881),
        dec: Angle.Degrees(-44.13542367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -262.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -356.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58571"},
        {"Hipparcos Number", "HIP 35898"},
        {"Smithsonian Astrophysical Observation", "SAO 218698"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.00831984),
        dec: Angle.Degrees(-44.13495172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185993"},
        {"Hipparcos Number", "HIP 97076"},
        {"Fundamental Katalog 5th Edition", "FK5 5740"},
        {"Geneva Identification System", "GEN# +1.00185993"},
        {"Smithsonian Astrophysical Observation", "SAO 229835"},
        {"Wilson Evans Batten Catalogue", "WEB 17036"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.92854708),
        dec: Angle.Degrees(-44.13371867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5699"},
        {"Hipparcos Number", "HIP 4537"},
        {"Smithsonian Astrophysical Observation", "SAO 215304"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.52409896),
        dec: Angle.Degrees(-44.13339858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21105"},
        {"Hipparcos Number", "HIP 15729"},
        {"Geneva Identification System", "GEN# +1.00021105"},
        {"Smithsonian Astrophysical Observation", "SAO 216285"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.65903618),
        dec: Angle.Degrees(-44.13176730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156293"},
        {"Hipparcos Number", "HIP 84690"},
        {"Celescope Catalog", "CEL 4499"},
        {"Geneva Identification System", "GEN# +1.00156293"},
        {"Smithsonian Astrophysical Observation", "SAO 227813"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.69932810),
        dec: Angle.Degrees(-44.12970725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196477"},
        {"Hipparcos Number", "HIP 101924"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.82255851),
        dec: Angle.Degrees(-44.12955124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199288"},
        {"Hipparcos Number", "HIP 103458"},
        {"Cincinnati Publication", "Ci 20 1241"},
        {"Geneva Identification System", "GEN# +1.00199288"},
        {"Smithsonian Astrophysical Observation", "SAO 230458"},
        {"Wilson Evans Batten Catalogue", "WEB 18819"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.41870003),
        dec: Angle.Degrees(-44.12700027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -515.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -975.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59420"},
        {"Hipparcos Number", "HIP 36240"},
        {"Smithsonian Astrophysical Observation", "SAO 218742"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.94235526),
        dec: Angle.Degrees(-44.12646017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68015"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.92294948),
        dec: Angle.Degrees(-44.12476090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4138"},
        {"Hipparcos Number", "HIP 3408"},
        {"Geneva Identification System", "GEN# +1.00004138"},
        {"Smithsonian Astrophysical Observation", "SAO 215211"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.84951625),
        dec: Angle.Degrees(-44.12326151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104760"},
        {"Hipparcos Number", "HIP 58813"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.94255679),
        dec: Angle.Degrees(-44.12285186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45738"},
        {"Hipparcos Number", "HIP 30696"},
        {"Geneva Identification System", "GEN# +1.00045738"},
        {"Smithsonian Astrophysical Observation", "SAO 217933"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.74666043),
        dec: Angle.Degrees(-44.12281596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68217"},
        {"Hipparcos Number", "HIP 39961"},
        {"Celescope Catalog", "CEL 2192"},
        {"Fundamental Katalog 5th Edition", "FK5 2634"},
        {"Geneva Identification System", "GEN# +1.00068217"},
        {"Smithsonian Astrophysical Observation", "SAO 219502"},
        {"Wilson Evans Batten Catalogue", "WEB 7791"},
    },
    visualMagnitude: 5.20,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.39967933),
        dec: Angle.Degrees(-44.12277919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222042"},
        {"Hipparcos Number", "HIP 116568"},
        {"Smithsonian Astrophysical Observation", "SAO 231704"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.34276794),
        dec: Angle.Degrees(-44.12266005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20380"},
        {"Hipparcos Number", "HIP 15119"},
        {"Geneva Identification System", "GEN# +1.00020380"},
        {"Smithsonian Astrophysical Observation", "SAO 216227"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.73767547),
        dec: Angle.Degrees(-44.12049308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104759"},
        {"Hipparcos Number", "HIP 58815"},
        {"Geneva Identification System", "GEN# +1.00104759"},
        {"Smithsonian Astrophysical Observation", "SAO 223195"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.94848101),
        dec: Angle.Degrees(-44.11800382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198468"},
        {"Hipparcos Number", "HIP 103006"},
        {"Smithsonian Astrophysical Observation", "SAO 230406"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.03708534),
        dec: Angle.Degrees(-44.11746793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148504"},
        {"Hipparcos Number", "HIP 80830"},
        {"Smithsonian Astrophysical Observation", "SAO 226830"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.60372557),
        dec: Angle.Degrees(-44.11563281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15567"},
        {"Hipparcos Number", "HIP 11551"},
        {"Smithsonian Astrophysical Observation", "SAO 215915"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.21035475),
        dec: Angle.Degrees(-44.11538344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73502"},
        {"Hipparcos Number", "HIP 42257"},
        {"Geneva Identification System", "GEN# +1.00073502"},
        {"Smithsonian Astrophysical Observation", "SAO 220186"},
        {"Wilson Evans Batten Catalogue", "WEB 8119"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.25544439),
        dec: Angle.Degrees(-44.11469433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87348"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.72845740),
        dec: Angle.Degrees(-44.11411406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106456"},
        {"Hipparcos Number", "HIP 59719"},
        {"Geneva Identification System", "GEN# +1.00106456"},
        {"Smithsonian Astrophysical Observation", "SAO 223302"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.71591221),
        dec: Angle.Degrees(-44.11169270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26586",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26586"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.76880020),
        dec: Angle.Degrees(-44.11063126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168905"},
        {"Hipparcos Number", "HIP 90200"},
        {"Fundamental Katalog 5th Edition", "FK5 3461"},
        {"Geneva Identification System", "GEN# +1.00168905"},
        {"Smithsonian Astrophysical Observation", "SAO 228982"},
        {"Wilson Evans Batten Catalogue", "WEB 15426"},
    },
    visualMagnitude: 5.24,
    bvColour: -0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.07600345),
        dec: Angle.Degrees(-44.11020130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176295"},
        {"Hipparcos Number", "HIP 93424"},
        {"Smithsonian Astrophysical Observation", "SAO 229442"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.41119064),
        dec: Angle.Degrees(-44.10997042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65551"},
        {"Hipparcos Number", "HIP 38872"},
        {"Fundamental Katalog 5th Edition", "FK5 2616"},
        {"Geneva Identification System", "GEN# +1.00065551"},
        {"Smithsonian Astrophysical Observation", "SAO 219197"},
        {"Wilson Evans Batten Catalogue", "WEB 7614"},
    },
    visualMagnitude: 5.08,
    bvColour: -0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.32679394),
        dec: Angle.Degrees(-44.10987569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150353"},
        {"Hipparcos Number", "HIP 81804"},
        {"Smithsonian Astrophysical Observation", "SAO 227076"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.62408066),
        dec: Angle.Degrees(-44.10974920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215156"},
        {"Hipparcos Number", "HIP 112236"},
        {"Geneva Identification System", "GEN# +1.00215156"},
        {"Smithsonian Astrophysical Observation", "SAO 231267"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.99530179),
        dec: Angle.Degrees(-44.10802580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137323"},
        {"Hipparcos Number", "HIP 75613"},
        {"Renson", "Renson 39020"},
        {"Smithsonian Astrophysical Observation", "SAO 225793"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.73924281),
        dec: Angle.Degrees(-44.10753709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220327"},
        {"Hipparcos Number", "HIP 115451"},
        {"Smithsonian Astrophysical Observation", "SAO 231580"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.79409835),
        dec: Angle.Degrees(-44.10687974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106411"},
        {"Hipparcos Number", "HIP 59699"},
        {"Geneva Identification System", "GEN# +1.00106411"},
        {"Smithsonian Astrophysical Observation", "SAO 223299"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.63433542),
        dec: Angle.Degrees(-44.10551695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169215"},
        {"Hipparcos Number", "HIP 90323"},
        {"Geneva Identification System", "GEN# +1.00169215"},
        {"Smithsonian Astrophysical Observation", "SAO 229009"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.44038029),
        dec: Angle.Degrees(-44.10523182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154153"},
        {"Hipparcos Number", "HIP 83650"},
        {"Celescope Catalog", "CEL 4475"},
        {"Geneva Identification System", "GEN# +1.00154153"},
        {"Smithsonian Astrophysical Observation", "SAO 227615"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.45193881),
        dec: Angle.Degrees(-44.10510266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102656"},
        {"Hipparcos Number", "HIP 57633"},
        {"Smithsonian Astrophysical Observation", "SAO 223038"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.26617664),
        dec: Angle.Degrees(-44.10439304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4428"},
        {"Hipparcos Number", "HIP 3603"},
        {"Geneva Identification System", "GEN# +1.00004428"},
        {"Smithsonian Astrophysical Observation", "SAO 215234"},
        {"Wilson Evans Batten Catalogue", "WEB 639"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.53225819),
        dec: Angle.Degrees(-44.10366036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101697"},
        {"Hipparcos Number", "HIP 57066"},
        {"Geneva Identification System", "GEN# +1.00101697"},
        {"Smithsonian Astrophysical Observation", "SAO 222965"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.47886580),
        dec: Angle.Degrees(-44.10349027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11138"},
        {"Hipparcos Number", "HIP 8420"},
        {"Geneva Identification System", "GEN# +1.00011138"},
        {"Smithsonian Astrophysical Observation", "SAO 215661"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.15315657),
        dec: Angle.Degrees(-44.10347931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110253"},
        {"Hipparcos Number", "HIP 61905"},
        {"Geneva Identification System", "GEN# +1.00110253"},
        {"Smithsonian Astrophysical Observation", "SAO 223595"},
        {"Wilson Evans Batten Catalogue", "WEB 11004"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.29057169),
        dec: Angle.Degrees(-44.10118311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159808"},
        {"Hipparcos Number", "HIP 86356"},
        {"Smithsonian Astrophysical Observation", "SAO 228231"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.69300239),
        dec: Angle.Degrees(-44.10022316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6191"},
        {"Hipparcos Number", "HIP 4850"},
        {"Smithsonian Astrophysical Observation", "SAO 215339"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.60329306),
        dec: Angle.Degrees(-44.09956205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197824"},
        {"Hipparcos Number", "HIP 102613"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.91408265),
        dec: Angle.Degrees(-44.09642338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73362"},
        {"Geneva Identification System", "GEN# -0.04309510"},
        {"Wilson Evans Batten Catalogue", "WEB 12564"},
    },
    visualMagnitude: 10.17,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.88316855),
        dec: Angle.Degrees(-44.09407201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -266.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -280.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213220"},
        {"Hipparcos Number", "HIP 111127"},
        {"Geneva Identification System", "GEN# +1.00213220"},
        {"Renson", "Renson 59095"},
        {"Smithsonian Astrophysical Observation", "SAO 231170"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.67877853),
        dec: Angle.Degrees(-44.09371413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88874"},
        {"Hipparcos Number", "HIP 50132"},
        {"Smithsonian Astrophysical Observation", "SAO 221887"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.51245120),
        dec: Angle.Degrees(-44.09216909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131627"},
        {"Hipparcos Number", "HIP 73090"},
        {"Geneva Identification System", "GEN# +1.00131627"},
        {"Smithsonian Astrophysical Observation", "SAO 225299"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.06156269),
        dec: Angle.Degrees(-44.09212597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37676"},
        {"Hipparcos Number", "HIP 26507"},
        {"Geneva Identification System", "GEN# +1.00037676"},
        {"Smithsonian Astrophysical Observation", "SAO 217442"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.55439105),
        dec: Angle.Degrees(-44.09029565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169857"},
        {"Hipparcos Number", "HIP 90563"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.19476571),
        dec: Angle.Degrees(-44.08854814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329788"},
        {"Hipparcos Number", "HIP 84754"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.86748185),
        dec: Angle.Degrees(-44.08530388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -260.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88455"},
        {"Hipparcos Number", "HIP 49878"},
        {"Geneva Identification System", "GEN# +1.00088455"},
        {"Smithsonian Astrophysical Observation", "SAO 221839"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.76325104),
        dec: Angle.Degrees(-44.08479287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2652"},
        {"Hipparcos Number", "HIP 2338"},
        {"Smithsonian Astrophysical Observation", "SAO 215114"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.46996277),
        dec: Angle.Degrees(-44.08293211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140602"},
        {"Hipparcos Number", "HIP 77243"},
        {"Geneva Identification System", "GEN# +1.00140602"},
        {"Smithsonian Astrophysical Observation", "SAO 226169"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.58102768),
        dec: Angle.Degrees(-44.08261428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60249"},
        {"Hipparcos Number", "HIP 36592"},
        {"Smithsonian Astrophysical Observation", "SAO 218778"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.88855693),
        dec: Angle.Degrees(-44.08224651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197133"},
        {"Hipparcos Number", "HIP 102263"},
        {"Smithsonian Astrophysical Observation", "SAO 230338"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.81228162),
        dec: Angle.Degrees(-44.08117841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142808"},
        {"Hipparcos Number", "HIP 78221"},
        {"Smithsonian Astrophysical Observation", "SAO 226408"},
        {"Wilson Evans Batten Catalogue", "WEB 13227"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.60010885),
        dec: Angle.Degrees(-44.08073828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17865"},
        {"Hipparcos Number", "HIP 13267"},
        {"Geneva Identification System", "GEN# +1.00017865"},
        {"Smithsonian Astrophysical Observation", "SAO 216064"},
        {"Wilson Evans Batten Catalogue", "WEB 2663"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.67266725),
        dec: Angle.Degrees(-44.08064188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -272.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168147"},
        {"Hipparcos Number", "HIP 89887"},
        {"Geneva Identification System", "GEN# +1.00168147"},
        {"Smithsonian Astrophysical Observation", "SAO 228928"},
        {"Wilson Evans Batten Catalogue", "WEB 15347"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.11839464),
        dec: Angle.Degrees(-44.07687696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7039"},
        {"Hipparcos Number", "HIP 5481"},
        {"Smithsonian Astrophysical Observation", "SAO 215391"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.53372110),
        dec: Angle.Degrees(-44.07678584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75211"},
        {"Hipparcos Number", "HIP 43125"},
        {"Celescope Catalog", "CEL 2902"},
        {"Geneva Identification System", "GEN# +1.00075211"},
        {"Smithsonian Astrophysical Observation", "SAO 220448"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.75665975),
        dec: Angle.Degrees(-44.07469638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204476"},
        {"Hipparcos Number", "HIP 106159"},
        {"Geneva Identification System", "GEN# +1.00204476"},
        {"Smithsonian Astrophysical Observation", "SAO 230716"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.55006870),
        dec: Angle.Degrees(-44.07463789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145510"},
        {"Hipparcos Number", "HIP 79487"},
        {"Fundamental Katalog 5th Edition", "FK5 5428"},
        {"Geneva Identification System", "GEN# +1.00145510"},
        {"Smithsonian Astrophysical Observation", "SAO 226580"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.31153809),
        dec: Angle.Degrees(-44.07363188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24391"},
        {"Hipparcos Number", "HIP 18009"},
        {"Smithsonian Astrophysical Observation", "SAO 216517"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.74551499),
        dec: Angle.Degrees(-44.07126252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96505"},
        {"Hipparcos Number", "HIP 54322"},
        {"Geneva Identification System", "GEN# +1.00096505"},
        {"Smithsonian Astrophysical Observation", "SAO 222573"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.69089784),
        dec: Angle.Degrees(-44.06836789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45681"},
        {"Hipparcos Number", "HIP 30672"},
        {"Smithsonian Astrophysical Observation", "SAO 217931"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.68176086),
        dec: Angle.Degrees(-44.06750154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2962"},
        {"Hipparcos Number", "HIP 2558"},
        {"Smithsonian Astrophysical Observation", "SAO 215137"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.905,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.12766886),
        dec: Angle.Degrees(-44.06597885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105361"},
        {"Hipparcos Number", "HIP 59159"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.98005927),
        dec: Angle.Degrees(-44.06530924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113509"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.81506865),
        dec: Angle.Degrees(-44.06443669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208627"},
        {"Hipparcos Number", "HIP 108484"},
        {"Geneva Identification System", "GEN# +1.00208627"},
        {"Smithsonian Astrophysical Observation", "SAO 230921"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.64562588),
        dec: Angle.Degrees(-44.06248904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212130"},
        {"Hipparcos Number", "HIP 110495"},
        {"Geneva Identification System", "GEN# +1.00212130"},
        {"Smithsonian Astrophysical Observation", "SAO 231110"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.74164351),
        dec: Angle.Degrees(-44.06203991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219010"},
        {"Hipparcos Number", "HIP 114602"},
        {"Smithsonian Astrophysical Observation", "SAO 231492"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.24797750),
        dec: Angle.Degrees(-44.06124659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48311",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48311"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.73474953),
        dec: Angle.Degrees(-44.06061103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14614"},
        {"Hipparcos Number", "HIP 10901"},
        {"Smithsonian Astrophysical Observation", "SAO 215866"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.08682340),
        dec: Angle.Degrees(-44.05823908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192071"},
        {"Hipparcos Number", "HIP 99799"},
        {"Geneva Identification System", "GEN# +1.00192071"},
        {"Smithsonian Astrophysical Observation", "SAO 230117"},
        {"Wilson Evans Batten Catalogue", "WEB 17924"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.72259945),
        dec: Angle.Degrees(-44.05770669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210022"},
        {"Hipparcos Number", "HIP 109288"},
        {"Geneva Identification System", "GEN# +1.00210022"},
        {"Smithsonian Astrophysical Observation", "SAO 230996"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.10549890),
        dec: Angle.Degrees(-44.05728179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45735"},
        {"Smithsonian Astrophysical Observation", "SAO 155089"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.85886350),
        dec: Angle.Degrees(-11.60573347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59777"},
        {"Hipparcos Number", "HIP 36407"},
        {"Smithsonian Astrophysical Observation", "SAO 218759"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.37008458),
        dec: Angle.Degrees(-44.05608354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84477"},
        {"Hipparcos Number", "HIP 47765"},
        {"Smithsonian Astrophysical Observation", "SAO 221440"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.07080817),
        dec: Angle.Degrees(-44.05559522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115470"},
        {"Hipparcos Number", "HIP 64892"},
        {"Geneva Identification System", "GEN# +1.00115470"},
        {"Smithsonian Astrophysical Observation", "SAO 224047"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.52137188),
        dec: Angle.Degrees(-44.05533428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48905"},
        {"Hipparcos Number", "HIP 32219"},
        {"Geneva Identification System", "GEN# +1.00048905"},
        {"Smithsonian Astrophysical Observation", "SAO 218158"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.89002834),
        dec: Angle.Degrees(-44.05507304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19163"},
        {"Hipparcos Number", "HIP 14224"},
        {"Geneva Identification System", "GEN# +1.00019163"},
        {"Smithsonian Astrophysical Observation", "SAO 216152"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.85490301),
        dec: Angle.Degrees(-44.05371244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124963"},
        {"Hipparcos Number", "HIP 69849"},
        {"Smithsonian Astrophysical Observation", "SAO 224821"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.42777225),
        dec: Angle.Degrees(-44.05254563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209355"},
        {"Hipparcos Number", "HIP 108913"},
        {"Smithsonian Astrophysical Observation", "SAO 230962"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.92924360),
        dec: Angle.Degrees(-44.05024257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128650"},
        {"Hipparcos Number", "HIP 71659"},
        {"Smithsonian Astrophysical Observation", "SAO 225094"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.85630261),
        dec: Angle.Degrees(-44.05020363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140286"},
        {"Hipparcos Number", "HIP 77101"},
        {"Smithsonian Astrophysical Observation", "SAO 226136"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.15159476),
        dec: Angle.Degrees(-44.04921666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149038"},
        {"Hipparcos Number", "HIP 81122"},
        {"Fundamental Katalog 5th Edition", "FK5 3311"},
        {"Geneva Identification System", "GEN# +2.61690001"},
        {"Smithsonian Astrophysical Observation", "SAO 226900"},
        {"Wilson Evans Batten Catalogue", "WEB 13717"},
        {"New General Catalogue", "NGC 6169 1"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.52091772),
        dec: Angle.Degrees(-44.04530868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117616"},
        {"Hipparcos Number", "HIP 66035"},
        {"Geneva Identification System", "GEN# +1.00117616"},
        {"Smithsonian Astrophysical Observation", "SAO 224227"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.07604133),
        dec: Angle.Degrees(-44.04459277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72733"},
        {"Hipparcos Number", "HIP 41908"},
        {"Celescope Catalog", "CEL 2627"},
        {"Geneva Identification System", "GEN# +1.00072733"},
        {"Smithsonian Astrophysical Observation", "SAO 220076"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.17584194),
        dec: Angle.Degrees(-44.04411785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173558"},
        {"Hipparcos Number", "HIP 92248"},
        {"Smithsonian Astrophysical Observation", "SAO 229289"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.00041882),
        dec: Angle.Degrees(-44.04115921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202412"},
        {"Hipparcos Number", "HIP 105065"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.25823661),
        dec: Angle.Degrees(-44.03910745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90258"},
        {"Hipparcos Number", "HIP 50937"},
        {"Geneva Identification System", "GEN# +1.00090258"},
        {"Smithsonian Astrophysical Observation", "SAO 222028"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.05098780),
        dec: Angle.Degrees(-44.03824709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36367"},
        {"Smithsonian Astrophysical Observation", "SAO 152933"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.28993819),
        dec: Angle.Degrees(-11.04933291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37433"},
        {"Hipparcos Number", "HIP 26325"},
        {"Smithsonian Astrophysical Observation", "SAO 217425"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.10192728),
        dec: Angle.Degrees(-44.03801882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134234"},
        {"Hipparcos Number", "HIP 74238"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.56338451),
        dec: Angle.Degrees(-44.03787120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7787"},
        {"Hipparcos Number", "HIP 5978"},
        {"Geneva Identification System", "GEN# +1.00007787"},
        {"Smithsonian Astrophysical Observation", "SAO 215437"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.21636516),
        dec: Angle.Degrees(-44.03574842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40733"},
        {"Hipparcos Number", "HIP 28287"},
        {"Geneva Identification System", "GEN# +1.00040733"},
        {"Smithsonian Astrophysical Observation", "SAO 217648"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.65648606),
        dec: Angle.Degrees(-44.03458558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68694"},
        {"Hipparcos Number", "HIP 40122"},
        {"Geneva Identification System", "GEN# +1.00068694"},
        {"Smithsonian Astrophysical Observation", "SAO 219573"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.93383789),
        dec: Angle.Degrees(-44.03394586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211996"},
        {"Hipparcos Number", "HIP 110429"},
        {"Smithsonian Astrophysical Observation", "SAO 231097"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.51114919),
        dec: Angle.Degrees(-44.03277928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127812"},
        {"Hipparcos Number", "HIP 71285"},
        {"Smithsonian Astrophysical Observation", "SAO 225033"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.67430940),
        dec: Angle.Degrees(-44.02831692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199287"},
        {"Hipparcos Number", "HIP 103466"},
        {"Smithsonian Astrophysical Observation", "SAO 230459"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.44064922),
        dec: Angle.Degrees(-44.02787481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197732"},
        {"Hipparcos Number", "HIP 102567"},
        {"Smithsonian Astrophysical Observation", "SAO 230366"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.78312523),
        dec: Angle.Degrees(-44.02426679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71470"},
        {"Hipparcos Number", "HIP 41332"},
        {"Celescope Catalog", "CEL 2501"},
        {"Geneva Identification System", "GEN# +1.00071470"},
        {"Smithsonian Astrophysical Observation", "SAO 219911"},
    },
    visualMagnitude: 8.34,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.49564399),
        dec: Angle.Degrees(-44.02223398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82630"},
        {"Hipparcos Number", "HIP 46759"},
        {"Geneva Identification System", "GEN# +1.00082630"},
        {"Smithsonian Astrophysical Observation", "SAO 221254"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.95346941),
        dec: Angle.Degrees(-44.02201288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86615"},
        {"Smithsonian Astrophysical Observation", "SAO 228297"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.48871927),
        dec: Angle.Degrees(-44.02137090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58459"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.81842771),
        dec: Angle.Degrees(-44.02130038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98964"},
        {"Hipparcos Number", "HIP 55571"},
        {"Smithsonian Astrophysical Observation", "SAO 222759"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.73959762),
        dec: Angle.Degrees(-44.02109555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28164"},
        {"Hipparcos Number", "HIP 20582"},
        {"Smithsonian Astrophysical Observation", "SAO 216786"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.12837276),
        dec: Angle.Degrees(-44.02065128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82"},
        {"Smithsonian Astrophysical Observation", "SAO 165998"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.24803173),
        dec: Angle.Degrees(-10.93580540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85103"},
        {"Hipparcos Number", "HIP 48098"},
        {"Renson", "Renson 24310"},
        {"Smithsonian Astrophysical Observation", "SAO 221503"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.10259345),
        dec: Angle.Degrees(-44.02004153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117550"},
        {"Hipparcos Number", "HIP 65989"},
        {"Geneva Identification System", "GEN# +1.00117550"},
        {"Smithsonian Astrophysical Observation", "SAO 224221"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.832,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.94951908),
        dec: Angle.Degrees(-44.01997114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171499"},
        {"Hipparcos Number", "HIP 91293"},
        {"Smithsonian Astrophysical Observation", "SAO 229147"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.31928401),
        dec: Angle.Degrees(-44.01862534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111619"},
        {"Hipparcos Number", "HIP 62708"},
        {"Smithsonian Astrophysical Observation", "SAO 223705"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.76255012),
        dec: Angle.Degrees(-44.01625044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67757"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.21935340),
        dec: Angle.Degrees(-44.01597756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39655"},
        {"Hipparcos Number", "HIP 27693"},
        {"Geneva Identification System", "GEN# +1.00039655"},
        {"Smithsonian Astrophysical Observation", "SAO 217582"},
        {"Wilson Evans Batten Catalogue", "WEB 5436"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.94638050),
        dec: Angle.Degrees(-44.01445580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67760"},
    },
    visualMagnitude: 12.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.22128211),
        dec: Angle.Degrees(-44.01282050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124208"},
        {"Hipparcos Number", "HIP 69460"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.30879435),
        dec: Angle.Degrees(-44.01276492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188246"},
        {"Hipparcos Number", "HIP 98090"},
        {"Geneva Identification System", "GEN# +1.00188246"},
        {"Smithsonian Astrophysical Observation", "SAO 229934"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.02178890),
        dec: Angle.Degrees(-44.01219489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188868"},
        {"Hipparcos Number", "HIP 98368"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.78035741),
        dec: Angle.Degrees(-44.01079737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188093"},
        {"Hipparcos Number", "HIP 98034"},
        {"Smithsonian Astrophysical Observation", "SAO 229926"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.82388282),
        dec: Angle.Degrees(-44.01070828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138860"},
        {"Hipparcos Number", "HIP 76415"},
        {"Celescope Catalog", "CEL 4384"},
        {"Geneva Identification System", "GEN# +1.00138860"},
        {"Smithsonian Astrophysical Observation", "SAO 225962"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.11128110),
        dec: Angle.Degrees(-44.01037436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41323"},
        {"Hipparcos Number", "HIP 28604"},
        {"Geneva Identification System", "GEN# +1.00041323"},
        {"Smithsonian Astrophysical Observation", "SAO 217685"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.56142234),
        dec: Angle.Degrees(-44.01007461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 314.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109537"},
        {"Hipparcos Number", "HIP 61475"},
        {"Smithsonian Astrophysical Observation", "SAO 223543"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.95541745),
        dec: Angle.Degrees(-44.01000475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40483"},
        {"Hipparcos Number", "HIP 28150"},
        {"Geneva Identification System", "GEN# +1.00040483"},
        {"Smithsonian Astrophysical Observation", "SAO 217634"},
        {"Wilson Evans Batten Catalogue", "WEB 5509"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.22879436),
        dec: Angle.Degrees(-44.00914824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88692"},
        {"Hipparcos Number", "HIP 50023"},
        {"Geneva Identification System", "GEN# +1.00088692"},
        {"Smithsonian Astrophysical Observation", "SAO 221860"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.19267929),
        dec: Angle.Degrees(-44.00884092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3609"},
        {"Hipparcos Number", "HIP 3037"},
        {"Smithsonian Astrophysical Observation", "SAO 215175"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.65292275),
        dec: Angle.Degrees(-44.00809529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110203"},
        {"Hipparcos Number", "HIP 61862"},
        {"Smithsonian Astrophysical Observation", "SAO 223593"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.17497118),
        dec: Angle.Degrees(-44.00579075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41002"},
        {"Hipparcos Number", "HIP 28435"},
        {"Smithsonian Astrophysical Observation", "SAO 217664"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.07421239),
        dec: Angle.Degrees(-44.00577212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103535"},
        {"Hipparcos Number", "HIP 58118"},
        {"Smithsonian Astrophysical Observation", "SAO 223112"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.80365512),
        dec: Angle.Degrees(-44.00429896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57123"},
        {"Hipparcos Number", "HIP 35327"},
        {"Smithsonian Astrophysical Observation", "SAO 218613"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.45103864),
        dec: Angle.Degrees(-44.00303394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111516"},
        {"Hipparcos Number", "HIP 62645"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.54743431),
        dec: Angle.Degrees(-44.00296871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63661"},
        {"Hipparcos Number", "HIP 38066"},
        {"Smithsonian Astrophysical Observation", "SAO 219008"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.01775094),
        dec: Angle.Degrees(-44.00208929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12770"},
        {"Hipparcos Number", "HIP 9646"},
        {"Smithsonian Astrophysical Observation", "SAO 215755"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.99937112),
        dec: Angle.Degrees(-44.00024423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85878"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.25208490),
        dec: Angle.Degrees(-43.99946804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106083"},
        {"Hipparcos Number", "HIP 59529"},
        {"Geneva Identification System", "GEN# +1.00106083"},
        {"Smithsonian Astrophysical Observation", "SAO 223278"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.11354449),
        dec: Angle.Degrees(-43.99938768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74583",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74583"},
    },
    visualMagnitude: 11.72,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.58315337),
        dec: Angle.Degrees(-43.99873808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110967"},
        {"Hipparcos Number", "HIP 62316"},
        {"Smithsonian Astrophysical Observation", "SAO 223659"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.55858841),
        dec: Angle.Degrees(-43.99851538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29348"},
        {"Hipparcos Number", "HIP 21379"},
        {"Smithsonian Astrophysical Observation", "SAO 216885"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.81412989),
        dec: Angle.Degrees(-43.99785355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107232"},
        {"Hipparcos Number", "HIP 60131"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.97939241),
        dec: Angle.Degrees(-43.99783931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75745"},
    },
    visualMagnitude: 11.79,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.11641494),
        dec: Angle.Degrees(-43.99484257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157242"},
        {"Hipparcos Number", "HIP 85168"},
        {"Geneva Identification System", "GEN# +1.00157242"},
        {"Smithsonian Astrophysical Observation", "SAO 227912"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.07649712),
        dec: Angle.Degrees(-43.99414913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123291"},
        {"Hipparcos Number", "HIP 69036"},
        {"Geneva Identification System", "GEN# +1.00123291"},
        {"Smithsonian Astrophysical Observation", "SAO 224711"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.97839505),
        dec: Angle.Degrees(-43.99317285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225201"},
        {"Hipparcos Number", "HIP 340"},
        {"Smithsonian Astrophysical Observation", "SAO 214949"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.07383315),
        dec: Angle.Degrees(-43.98832631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197937"},
        {"Hipparcos Number", "HIP 102693"},
        {"Fundamental Katalog 5th Edition", "FK5 1542"},
        {"Geneva Identification System", "GEN# +1.00197937"},
        {"Smithsonian Astrophysical Observation", "SAO 230379"},
        {"Wilson Evans Batten Catalogue", "WEB 18615"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.12083153),
        dec: Angle.Degrees(-43.98827127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218890"},
        {"Hipparcos Number", "HIP 114541"},
        {"Smithsonian Astrophysical Observation", "SAO 231486"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.01258195),
        dec: Angle.Degrees(-43.98781596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57197"},
        {"Hipparcos Number", "HIP 35347"},
        {"Celescope Catalog", "CEL 1757"},
        {"Geneva Identification System", "GEN# +1.00057197"},
        {"Renson", "Renson 15630"},
        {"Smithsonian Astrophysical Observation", "SAO 218618"},
        {"Wilson Evans Batten Catalogue", "WEB 7055"},
    },
    visualMagnitude: 5.86,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.51773775),
        dec: Angle.Degrees(-43.98677255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228"},
        {"Hipparcos Number", "HIP 573"},
        {"Geneva Identification System", "GEN# +1.00000228"},
        {"Smithsonian Astrophysical Observation", "SAO 214967"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.73459748),
        dec: Angle.Degrees(-43.98527000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111958",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111958"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.18002812),
        dec: Angle.Degrees(-43.98183579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189247"},
        {"Hipparcos Number", "HIP 98516"},
        {"Geneva Identification System", "GEN# +1.00189247"},
        {"Smithsonian Astrophysical Observation", "SAO 229985"},
        {"Wilson Evans Batten Catalogue", "WEB 17398"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.21253716),
        dec: Angle.Degrees(-43.98163659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45076"},
        {"Hipparcos Number", "HIP 30375"},
        {"Smithsonian Astrophysical Observation", "SAO 217898"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.80844604),
        dec: Angle.Degrees(-43.98156793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64659"},
        {"Hipparcos Number", "HIP 38499"},
        {"Smithsonian Astrophysical Observation", "SAO 219103"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.26485675),
        dec: Angle.Degrees(-43.98040155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30788"},
        {"Hipparcos Number", "HIP 22329"},
        {"Fundamental Katalog 5th Edition", "FK5 2360"},
        {"Geneva Identification System", "GEN# +1.00030788"},
        {"Smithsonian Astrophysical Observation", "SAO 217004"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.14073772),
        dec: Angle.Degrees(-43.98003986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115331"},
        {"Hipparcos Number", "HIP 64822"},
        {"Fundamental Katalog 5th Edition", "FK5 1343"},
        {"Geneva Identification System", "GEN# +1.00115331"},
        {"Renson", "Renson 33320"},
        {"Smithsonian Astrophysical Observation", "SAO 224032"},
        {"Wilson Evans Batten Catalogue", "WEB 11456"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.30801256),
        dec: Angle.Degrees(-43.97944198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54678"},
        {"Hipparcos Number", "HIP 34377"},
        {"Smithsonian Astrophysical Observation", "SAO 218473"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.91712830),
        dec: Angle.Degrees(-43.97849656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114137"},
        {"Hipparcos Number", "HIP 64178"},
        {"Smithsonian Astrophysical Observation", "SAO 223933"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.30073147),
        dec: Angle.Degrees(-43.97799145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81575"},
        {"Hipparcos Number", "HIP 46194"},
        {"Geneva Identification System", "GEN# +1.00081575"},
        {"Smithsonian Astrophysical Observation", "SAO 221146"},
        {"Wilson Evans Batten Catalogue", "WEB 8743"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.28289581),
        dec: Angle.Degrees(-43.97670178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70250"},
        {"Hipparcos Number", "HIP 40762"},
        {"Celescope Catalog", "CEL 2366"},
        {"Smithsonian Astrophysical Observation", "SAO 219782"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.80591898),
        dec: Angle.Degrees(-43.97587507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50860"},
        {"Hipparcos Number", "HIP 33015"},
        {"Celescope Catalog", "CEL 1422"},
        {"Geneva Identification System", "GEN# +1.00050860J"},
        {"Smithsonian Astrophysical Observation", "SAO 218278"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.19640231),
        dec: Angle.Degrees(-43.97560689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116214"},
        {"Hipparcos Number", "HIP 65291"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.72094175),
        dec: Angle.Degrees(-43.97492407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158042"},
        {"Hipparcos Number", "HIP 85549"},
        {"Celescope Catalog", "CEL 4520"},
        {"Geneva Identification System", "GEN# +1.00158042"},
        {"Smithsonian Astrophysical Observation", "SAO 228010"},
    },
    visualMagnitude: 6.30,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.25360309),
        dec: Angle.Degrees(-43.97389932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142279"},
        {"Hipparcos Number", "HIP 77976"},
        {"Smithsonian Astrophysical Observation", "SAO 226365"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.85762728),
        dec: Angle.Degrees(-43.97381825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221610"},
        {"Hipparcos Number", "HIP 116296"},
        {"Geneva Identification System", "GEN# +1.00221610"},
        {"Smithsonian Astrophysical Observation", "SAO 231664"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.44588922),
        dec: Angle.Degrees(-43.97149540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11057"},
        {"Hipparcos Number", "HIP 8353"},
        {"Smithsonian Astrophysical Observation", "SAO 215655"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.91879931),
        dec: Angle.Degrees(-43.97108087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77669"},
        {"Hipparcos Number", "HIP 44381"},
        {"Celescope Catalog", "CEL 3157"},
        {"Geneva Identification System", "GEN# +1.00077669"},
        {"Smithsonian Astrophysical Observation", "SAO 220771"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.61023920),
        dec: Angle.Degrees(-43.97005483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33378"},
        {"Hipparcos Number", "HIP 23856"},
        {"Smithsonian Astrophysical Observation", "SAO 217186"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.91252892),
        dec: Angle.Degrees(-43.96991023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119139"},
        {"Hipparcos Number", "HIP 66864"},
        {"Smithsonian Astrophysical Observation", "SAO 224353"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.56662842),
        dec: Angle.Degrees(-43.96687609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209661"},
        {"Hipparcos Number", "HIP 109108"},
        {"Geneva Identification System", "GEN# +1.00209661"},
        {"Smithsonian Astrophysical Observation", "SAO 230977"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.51725094),
        dec: Angle.Degrees(-43.96614212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59530"},
        {"Hipparcos Number", "HIP 36298"},
        {"Celescope Catalog", "CEL 1878"},
        {"Geneva Identification System", "GEN# +1.00059530"},
        {"Smithsonian Astrophysical Observation", "SAO 218748"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.07327557),
        dec: Angle.Degrees(-43.96312019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125912"},
        {"Hipparcos Number", "HIP 70350"},
        {"Geneva Identification System", "GEN# +1.00125912"},
        {"Smithsonian Astrophysical Observation", "SAO 224889"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.90792041),
        dec: Angle.Degrees(-43.96183385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82320"},
        {"Hipparcos Number", "HIP 46571"},
        {"Smithsonian Astrophysical Observation", "SAO 221223"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.46098850),
        dec: Angle.Degrees(-43.95892770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93173"},
        {"Hipparcos Number", "HIP 52559"},
        {"Geneva Identification System", "GEN# +1.00093173"},
        {"Smithsonian Astrophysical Observation", "SAO 222290"},
        {"Wilson Evans Batten Catalogue", "WEB 9574"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.19258926),
        dec: Angle.Degrees(-43.95887312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103076"},
        {"Hipparcos Number", "HIP 57860"},
        {"Smithsonian Astrophysical Observation", "SAO 223077"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.00417924),
        dec: Angle.Degrees(-43.95834639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29047"},
        {"Hipparcos Number", "HIP 21171"},
        {"Smithsonian Astrophysical Observation", "SAO 216862"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.08654712),
        dec: Angle.Degrees(-43.95718720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115508"},
        {"Hipparcos Number", "HIP 64916"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.59308539),
        dec: Angle.Degrees(-43.95523750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200808"},
        {"Hipparcos Number", "HIP 104236"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.78775163),
        dec: Angle.Degrees(-43.95413022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115819"},
        {"Hipparcos Number", "HIP 65077"},
        {"Geneva Identification System", "GEN# +1.00115819"},
        {"Smithsonian Astrophysical Observation", "SAO 224069"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.09148234),
        dec: Angle.Degrees(-43.95289068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111341"},
        {"Hipparcos Number", "HIP 62557"},
        {"Smithsonian Astrophysical Observation", "SAO 223683"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.26630953),
        dec: Angle.Degrees(-43.94920739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225017"},
        {"Hipparcos Number", "HIP 204"},
        {"Smithsonian Astrophysical Observation", "SAO 214940"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.64508403),
        dec: Angle.Degrees(-43.94791349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152650"},
        {"Hipparcos Number", "HIP 82917"},
        {"Smithsonian Astrophysical Observation", "SAO 227472"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.16406877),
        dec: Angle.Degrees(-43.94772087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207411"},
        {"Hipparcos Number", "HIP 107768"},
        {"Smithsonian Astrophysical Observation", "SAO 230857"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.47653652),
        dec: Angle.Degrees(-43.94675679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33921"},
        {"Hipparcos Number", "HIP 24174"},
        {"Smithsonian Astrophysical Observation", "SAO 217226"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.87025114),
        dec: Angle.Degrees(-43.94675334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79789"},
        {"Hipparcos Number", "HIP 45361"},
        {"Smithsonian Astrophysical Observation", "SAO 220984"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.65208004),
        dec: Angle.Degrees(-43.94498453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14396"},
        {"Hipparcos Number", "HIP 10744"},
        {"Smithsonian Astrophysical Observation", "SAO 215857"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.56109051),
        dec: Angle.Degrees(-43.94191958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107433",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107433"},
    },
    visualMagnitude: 10.43,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.39460412),
        dec: Angle.Degrees(-43.94069975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121037"},
        {"Hipparcos Number", "HIP 67870"},
        {"Geneva Identification System", "GEN# +1.00121037"},
        {"Smithsonian Astrophysical Observation", "SAO 224517"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.52077825),
        dec: Angle.Degrees(-43.93726316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41937"},
        {"Hipparcos Number", "HIP 28878"},
        {"Geneva Identification System", "GEN# +1.00041937"},
        {"Smithsonian Astrophysical Observation", "SAO 217715"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.45850433),
        dec: Angle.Degrees(-43.93629235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217138"},
        {"Hipparcos Number", "HIP 113489"},
        {"Smithsonian Astrophysical Observation", "SAO 231379"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.75523433),
        dec: Angle.Degrees(-43.93550798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8962"},
        {"Hipparcos Number", "HIP 6802"},
        {"Geneva Identification System", "GEN# +1.00008962"},
        {"Smithsonian Astrophysical Observation", "SAO 215511"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.87783434),
        dec: Angle.Degrees(-43.93401023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102981"},
        {"Hipparcos Number", "HIP 57809"},
        {"Geneva Identification System", "GEN# +1.00102981"},
        {"Smithsonian Astrophysical Observation", "SAO 223064"},
    },
    visualMagnitude: 6.62,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.80484464),
        dec: Angle.Degrees(-43.93303360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224485"},
        {"Hipparcos Number", "HIP 118187"},
        {"Smithsonian Astrophysical Observation", "SAO 231872"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.60018796),
        dec: Angle.Degrees(-43.93283777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72648"},
        {"Hipparcos Number", "HIP 41878"},
        {"Celescope Catalog", "CEL 2621"},
        {"Geneva Identification System", "GEN# +1.00072648J"},
        {"Smithsonian Astrophysical Observation", "SAO 220063"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.07914029),
        dec: Angle.Degrees(-43.93150136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87031"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.73934896),
        dec: Angle.Degrees(-43.93107946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129055"},
        {"Hipparcos Number", "HIP 71844"},
        {"Geneva Identification System", "GEN# +1.00129055"},
        {"Smithsonian Astrophysical Observation", "SAO 225127"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.44263453),
        dec: Angle.Degrees(-43.93060410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74902",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74902"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.61034098),
        dec: Angle.Degrees(-43.93038808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143677"},
        {"Hipparcos Number", "HIP 78684"},
        {"Smithsonian Astrophysical Observation", "SAO 226467"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.93907877),
        dec: Angle.Degrees(-43.93028853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136857"},
        {"Hipparcos Number", "HIP 75418"},
        {"Smithsonian Astrophysical Observation", "SAO 225745"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.13092883),
        dec: Angle.Degrees(-43.92734981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204047"},
        {"Hipparcos Number", "HIP 105941"},
        {"Smithsonian Astrophysical Observation", "SAO 230695"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.83670538),
        dec: Angle.Degrees(-43.92465091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57302"},
        {"Hipparcos Number", "HIP 35387"},
        {"Smithsonian Astrophysical Observation", "SAO 218626"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.63523764),
        dec: Angle.Degrees(-43.92460833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178817"},
        {"Hipparcos Number", "HIP 94334"},
        {"Smithsonian Astrophysical Observation", "SAO 229548"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.02028612),
        dec: Angle.Degrees(-43.92422835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12226"},
        {"Hipparcos Number", "HIP 9259"},
        {"Smithsonian Astrophysical Observation", "SAO 215722"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.75522804),
        dec: Angle.Degrees(-43.92111745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218321"},
        {"Hipparcos Number", "HIP 114195"},
        {"Smithsonian Astrophysical Observation", "SAO 231449"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.89557541),
        dec: Angle.Degrees(-43.92041604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72066"},
        {"Hipparcos Number", "HIP 41618"},
        {"Geneva Identification System", "GEN# +1.00072066"},
        {"Smithsonian Astrophysical Observation", "SAO 219981"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.27328600),
        dec: Angle.Degrees(-43.91885978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25301"},
        {"Hipparcos Number", "HIP 18635"},
        {"Geneva Identification System", "GEN# +1.00025301"},
        {"Smithsonian Astrophysical Observation", "SAO 216590"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.83444561),
        dec: Angle.Degrees(-43.91745017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191007"},
        {"Hipparcos Number", "HIP 99305"},
        {"Geneva Identification System", "GEN# +1.00191007"},
        {"Smithsonian Astrophysical Observation", "SAO 230071"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.36193537),
        dec: Angle.Degrees(-43.91711908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175395"},
        {"Hipparcos Number", "HIP 93049"},
        {"Smithsonian Astrophysical Observation", "SAO 229397"},
    },
    visualMagnitude: 6.27,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.30963032),
        dec: Angle.Degrees(-43.91694530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83310"},
        {"Hipparcos Number", "HIP 47122"},
        {"Smithsonian Astrophysical Observation", "SAO 221330"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.03654264),
        dec: Angle.Degrees(-43.91693911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14994"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.31290467),
        dec: Angle.Degrees(-43.91642311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6254"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.05736058),
        dec: Angle.Degrees(-43.91608216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8232",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10895"},
        {"Hipparcos Number", "HIP 8232"},
        {"Smithsonian Astrophysical Observation", "SAO 215638"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.50025246),
        dec: Angle.Degrees(-43.91341286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147225"},
        {"Hipparcos Number", "HIP 80212"},
        {"Geneva Identification System", "GEN# +1.00147225A"},
        {"Smithsonian Astrophysical Observation", "SAO 226696"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.62114131),
        dec: Angle.Degrees(-43.91202357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5157"},
        {"Hipparcos Number", "HIP 4134"},
        {"Smithsonian Astrophysical Observation", "SAO 215275"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.22766919),
        dec: Angle.Degrees(-43.91092768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81313"},
        {"Hipparcos Number", "HIP 46056"},
        {"Smithsonian Astrophysical Observation", "SAO 221124"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.88027458),
        dec: Angle.Degrees(-43.90916771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92231"},
        {"Hipparcos Number", "HIP 52049"},
        {"Smithsonian Astrophysical Observation", "SAO 222210"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.53433051),
        dec: Angle.Degrees(-43.90751562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168029"},
        {"Hipparcos Number", "HIP 89838"},
        {"Smithsonian Astrophysical Observation", "SAO 228914"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.00387933),
        dec: Angle.Degrees(-43.90601800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19406"},
        {"Hipparcos Number", "HIP 14395"},
        {"Smithsonian Astrophysical Observation", "SAO 216164"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.42431167),
        dec: Angle.Degrees(-43.90402533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41155"},
        {"Hipparcos Number", "HIP 28508"},
        {"Geneva Identification System", "GEN# +1.00041155"},
        {"Smithsonian Astrophysical Observation", "SAO 217674"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.27310673),
        dec: Angle.Degrees(-43.90316303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9619"},
        {"Hipparcos Number", "HIP 7254"},
        {"Geneva Identification System", "GEN# +1.00009619"},
        {"Smithsonian Astrophysical Observation", "SAO 215556"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.36052550),
        dec: Angle.Degrees(-43.90141420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29987"},
        {"Hipparcos Number", "HIP 21824"},
        {"Geneva Identification System", "GEN# +1.00029987"},
        {"Smithsonian Astrophysical Observation", "SAO 216933"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.37215266),
        dec: Angle.Degrees(-43.90073563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44468"},
        {"Hipparcos Number", "HIP 30083"},
        {"Geneva Identification System", "GEN# +1.00044468"},
        {"Smithsonian Astrophysical Observation", "SAO 217854"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.95672851),
        dec: Angle.Degrees(-43.89991842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 325974"},
        {"Hipparcos Number", "HIP 81737"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.43060174),
        dec: Angle.Degrees(-43.89960440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19215"},
        {"Hipparcos Number", "HIP 14262"},
        {"Smithsonian Astrophysical Observation", "SAO 216156"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.98007672),
        dec: Angle.Degrees(-43.89806662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133166"},
        {"Hipparcos Number", "HIP 73758"},
        {"Smithsonian Astrophysical Observation", "SAO 225418"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.15083114),
        dec: Angle.Degrees(-43.89733420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30440"},
        {"Hipparcos Number", "HIP 22121"},
        {"Smithsonian Astrophysical Observation", "SAO 216981"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.41241147),
        dec: Angle.Degrees(-43.89716449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215629"},
        {"Hipparcos Number", "HIP 112490"},
        {"Geneva Identification System", "GEN# +1.00215629"},
        {"Smithsonian Astrophysical Observation", "SAO 231295"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.78649857),
        dec: Angle.Degrees(-43.89601879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191117"},
        {"Hipparcos Number", "HIP 99364"},
        {"Geneva Identification System", "GEN# +1.00191117"},
        {"Smithsonian Astrophysical Observation", "SAO 230077"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.52441908),
        dec: Angle.Degrees(-43.89419523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17683"},
        {"Hipparcos Number", "HIP 13127"},
        {"Smithsonian Astrophysical Observation", "SAO 216057"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.21150836),
        dec: Angle.Degrees(-43.89144381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78958"},
        {"Hipparcos Number", "HIP 44966"},
        {"Geneva Identification System", "GEN# +1.00078958"},
        {"Wilson Evans Batten Catalogue", "WEB 8589"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.40606963),
        dec: Angle.Degrees(-43.88869343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32939"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.92760534),
        dec: Angle.Degrees(-43.88722884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48244"},
        {"Hipparcos Number", "HIP 31918"},
        {"Smithsonian Astrophysical Observation", "SAO 218116"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.05682375),
        dec: Angle.Degrees(-43.88623526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174978"},
        {"Hipparcos Number", "HIP 92857"},
        {"Geneva Identification System", "GEN# +1.00174978"},
        {"Smithsonian Astrophysical Observation", "SAO 229374"},
        {"Wilson Evans Batten Catalogue", "WEB 16073"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.82679570),
        dec: Angle.Degrees(-43.88587333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55910"},
        {"Hipparcos Number", "HIP 34868"},
        {"Smithsonian Astrophysical Observation", "SAO 218541"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.22066636),
        dec: Angle.Degrees(-43.88518636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182821"},
        {"Hipparcos Number", "HIP 95734"},
        {"Smithsonian Astrophysical Observation", "SAO 229700"},
    },
    visualMagnitude: 7.51,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.09016017),
        dec: Angle.Degrees(-43.88464337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198490"},
        {"Hipparcos Number", "HIP 103016"},
        {"Geneva Identification System", "GEN# +1.00198490"},
        {"Smithsonian Astrophysical Observation", "SAO 230408"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.06305295),
        dec: Angle.Degrees(-43.88362584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81468"},
        {"Hipparcos Number", "HIP 46128"},
        {"Smithsonian Astrophysical Observation", "SAO 221139"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.09756969),
        dec: Angle.Degrees(-43.88331790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1798"},
        {"Hipparcos Number", "HIP 1753"},
        {"Smithsonian Astrophysical Observation", "SAO 215065"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.55169975),
        dec: Angle.Degrees(-43.88100137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65708"},
        {"Hipparcos Number", "HIP 38938"},
        {"Smithsonian Astrophysical Observation", "SAO 219219"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.51472223),
        dec: Angle.Degrees(-43.88053140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37178"},
        {"Hipparcos Number", "HIP 26145"},
        {"Smithsonian Astrophysical Observation", "SAO 217405"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.61068548),
        dec: Angle.Degrees(-43.88031386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113311"},
        {"Hipparcos Number", "HIP 63714"},
        {"Geneva Identification System", "GEN# +1.00113311"},
        {"Smithsonian Astrophysical Observation", "SAO 223869"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.85705598),
        dec: Angle.Degrees(-43.87964865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31116"},
        {"Hipparcos Number", "HIP 22541"},
        {"Geneva Identification System", "GEN# +1.00031116"},
        {"Renson", "Renson 8000"},
        {"Smithsonian Astrophysical Observation", "SAO 217038"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.77196419),
        dec: Angle.Degrees(-43.87608509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146421"},
        {"Hipparcos Number", "HIP 79859"},
        {"Smithsonian Astrophysical Observation", "SAO 226635"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.52179802),
        dec: Angle.Degrees(-43.87462368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41650"},
        {"Hipparcos Number", "HIP 28757"},
        {"Smithsonian Astrophysical Observation", "SAO 217701"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.08641649),
        dec: Angle.Degrees(-43.87452688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26819"},
        {"Hipparcos Number", "HIP 19654"},
        {"Smithsonian Astrophysical Observation", "SAO 216695"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.16509999),
        dec: Angle.Degrees(-43.87450664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95729"},
        {"Hipparcos Number", "HIP 53958"},
        {"Smithsonian Astrophysical Observation", "SAO 222511"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.59564766),
        dec: Angle.Degrees(-43.87353394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44916"},
        {"Hipparcos Number", "HIP 30296"},
        {"Smithsonian Astrophysical Observation", "SAO 217888"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.58748728),
        dec: Angle.Degrees(-43.87299338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
