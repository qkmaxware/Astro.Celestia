using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_101() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80801"},
        {"Smithsonian Astrophysical Observation", "SAO 46123"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.48417353),
        dec: Angle.Degrees(+46.19365900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30303",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4970 AB"},
        {"Henry Draper", "HD 44124"},
        {"Hipparcos Number", "HIP 30303"},
        {"Smithsonian Astrophysical Observation", "SAO 41048"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.60570681),
        dec: Angle.Degrees(+46.19463111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15595"},
        {"Hipparcos Number", "HIP 11773"},
        {"Smithsonian Astrophysical Observation", "SAO 38090"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.98096862),
        dec: Angle.Degrees(+46.19483766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197997"},
        {"Hipparcos Number", "HIP 102457"},
        {"Smithsonian Astrophysical Observation", "SAO 50035"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.42509651),
        dec: Angle.Degrees(+46.19694960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86944"},
        {"Hipparcos Number", "HIP 49239"},
        {"Smithsonian Astrophysical Observation", "SAO 43156"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.77287453),
        dec: Angle.Degrees(+46.19711290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207953"},
        {"Hipparcos Number", "HIP 107907"},
        {"Smithsonian Astrophysical Observation", "SAO 51376"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.94120363),
        dec: Angle.Degrees(+46.19898968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222143"},
        {"Hipparcos Number", "HIP 116613"},
        {"Cincinnati Publication", "Ci 18 3099"},
        {"Geneva Identification System", "GEN# +1.00222143"},
        {"Smithsonian Astrophysical Observation", "SAO 53210"},
        {"Wilson Evans Batten Catalogue", "WEB 20587"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.49244611),
        dec: Angle.Degrees(+46.19946357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 357.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16385"},
        {"Hipparcos Number", "HIP 12362"},
        {"Smithsonian Astrophysical Observation", "SAO 38195"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.78702908),
        dec: Angle.Degrees(+46.20351157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92787"},
        {"Hipparcos Number", "HIP 52469"},
        {"Fundamental Katalog 5th Edition", "FK5 1276"},
        {"Geneva Identification System", "GEN# +1.00092787"},
        {"Smithsonian Astrophysical Observation", "SAO 43444"},
        {"Wilson Evans Batten Catalogue", "WEB 9557"},
    },
    visualMagnitude: 5.18,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.88798925),
        dec: Angle.Degrees(+46.20403760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -268.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51715",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7831 AB"},
        {"Hipparcos Number", "HIP 51715"},
        {"Smithsonian Astrophysical Observation", "SAO 43384"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.49208001),
        dec: Angle.Degrees(+46.20532988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92855"},
        {"Hipparcos Number", "HIP 52498"},
        {"Geneva Identification System", "GEN# +1.00092855"},
        {"Smithsonian Astrophysical Observation", "SAO 43449"},
        {"Wilson Evans Batten Catalogue", "WEB 9560"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.00352238),
        dec: Angle.Degrees(+46.20680558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -270.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215856"},
        {"Hipparcos Number", "HIP 112511"},
        {"Smithsonian Astrophysical Observation", "SAO 52364"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.85131161),
        dec: Angle.Degrees(+46.20773795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70900"},
        {"Smithsonian Astrophysical Observation", "SAO 45078"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.47382565),
        dec: Angle.Degrees(+46.20888047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37050"},
        {"Hipparcos Number", "HIP 26490"},
        {"Smithsonian Astrophysical Observation", "SAO 40496"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.51561435),
        dec: Angle.Degrees(+46.20896330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47707"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.90312830),
        dec: Angle.Degrees(+46.21314861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53973",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53973"},
        {"Smithsonian Astrophysical Observation", "SAO 43588"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.62638837),
        dec: Angle.Degrees(+46.21423272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1374"},
        {"Hipparcos Number", "HIP 1456"},
        {"Geneva Identification System", "GEN# +1.00001374"},
        {"Smithsonian Astrophysical Observation", "SAO 36247"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.53829434),
        dec: Angle.Degrees(+46.21435458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215705"},
        {"Hipparcos Number", "HIP 112428"},
        {"Smithsonian Astrophysical Observation", "SAO 52352"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.58772956),
        dec: Angle.Degrees(+46.21513424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65914"},
        {"Hipparcos Number", "HIP 39394"},
        {"Fundamental Katalog 5th Edition", "FK5 4724"},
        {"Geneva Identification System", "GEN# +1.00065914"},
        {"Smithsonian Astrophysical Observation", "SAO 42139"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.80301844),
        dec: Angle.Degrees(+46.21752001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26907"},
        {"Hipparcos Number", "HIP 20000"},
        {"Celescope Catalog", "CEL 377"},
        {"Smithsonian Astrophysical Observation", "SAO 39438"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.33238601),
        dec: Angle.Degrees(+46.21767795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222516"},
        {"Hipparcos Number", "HIP 116849"},
        {"Geneva Identification System", "GEN# +1.00222516J"},
        {"Smithsonian Astrophysical Observation", "SAO 53270"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.27310950),
        dec: Angle.Degrees(+46.21834506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171654"},
        {"Hipparcos Number", "HIP 90999"},
        {"Fundamental Katalog 5th Edition", "FK5 1483"},
        {"Geneva Identification System", "GEN# +1.00171654"},
        {"Smithsonian Astrophysical Observation", "SAO 47600"},
        {"Wilson Evans Batten Catalogue", "WEB 15612"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.44859256),
        dec: Angle.Degrees(+46.21912094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119348"},
        {"Hipparcos Number", "HIP 66829"},
        {"Smithsonian Astrophysical Observation", "SAO 44715"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.44887176),
        dec: Angle.Degrees(+46.21976249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67332"},
        {"Smithsonian Astrophysical Observation", "SAO 44755"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.00610510),
        dec: Angle.Degrees(+46.22058230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89312"},
        {"Smithsonian Astrophysical Observation", "SAO 47319"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.36125644),
        dec: Angle.Degrees(+46.22262406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 139.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145120"},
        {"Hipparcos Number", "HIP 78967"},
        {"Smithsonian Astrophysical Observation", "SAO 45898"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.875,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.80833148),
        dec: Angle.Degrees(+46.22278147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97406"},
        {"Hipparcos Number", "HIP 54794"},
        {"Geneva Identification System", "GEN# +1.00097406"},
        {"Smithsonian Astrophysical Observation", "SAO 43645"},
        {"Wilson Evans Batten Catalogue", "WEB 9888"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.27110634),
        dec: Angle.Degrees(+46.22307631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115443"},
        {"Hipparcos Number", "HIP 64771"},
        {"Smithsonian Astrophysical Observation", "SAO 44540"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.11473474),
        dec: Angle.Degrees(+46.22414084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57046"},
        {"Hipparcos Number", "HIP 35684"},
        {"Geneva Identification System", "GEN# +1.00057046"},
        {"Smithsonian Astrophysical Observation", "SAO 41711"},
        {"Wilson Evans Batten Catalogue", "WEB 7108"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.44866766),
        dec: Angle.Degrees(+46.22532740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146079"},
        {"Hipparcos Number", "HIP 79398"},
        {"Geneva Identification System", "GEN# +1.00146079"},
        {"Smithsonian Astrophysical Observation", "SAO 45964"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.06355486),
        dec: Angle.Degrees(+46.22549363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 220.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7998"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.67978225),
        dec: Angle.Degrees(+46.22678445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 168.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104714"},
        {"Smithsonian Astrophysical Observation", "SAO 50574"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.17478786),
        dec: Angle.Degrees(+46.22711752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19366",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3007 AB"},
        {"Henry Draper", "HD 25987"},
        {"Hipparcos Number", "HIP 19366"},
        {"Smithsonian Astrophysical Observation", "SAO 39339"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.22727435),
        dec: Angle.Degrees(+46.22782849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82460"},
        {"Hipparcos Number", "HIP 46903"},
        {"Smithsonian Astrophysical Observation", "SAO 42917"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.36981599),
        dec: Angle.Degrees(+46.22867465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10874"},
        {"Hipparcos Number", "HIP 8370"},
        {"Fundamental Katalog 5th Edition", "FK5 2119"},
        {"Geneva Identification System", "GEN# +1.00010874"},
        {"Smithsonian Astrophysical Observation", "SAO 37513"},
        {"Wilson Evans Batten Catalogue", "WEB 1779"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.95001171),
        dec: Angle.Degrees(+46.22988460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26906"},
        {"Hipparcos Number", "HIP 19991"},
        {"Fundamental Katalog 5th Edition", "FK5 4393"},
        {"Renson", "Renson 6870"},
        {"Smithsonian Astrophysical Observation", "SAO 39436"},
        {"Wilson Evans Batten Catalogue", "WEB 3814"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.31819732),
        dec: Angle.Degrees(+46.23055690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19768"},
        {"Hipparcos Number", "HIP 14946"},
        {"Smithsonian Astrophysical Observation", "SAO 38645"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.16983987),
        dec: Angle.Degrees(+46.23069626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199311"},
        {"Hipparcos Number", "HIP 103213"},
        {"Celescope Catalog", "CEL 5205"},
        {"Geneva Identification System", "GEN# +1.00199311"},
        {"Renson", "Renson 55530"},
        {"Smithsonian Astrophysical Observation", "SAO 50218"},
        {"Wilson Evans Batten Catalogue", "WEB 18751"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.66632896),
        dec: Angle.Degrees(+46.23119128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215507"},
        {"Hipparcos Number", "HIP 112322"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.26248826),
        dec: Angle.Degrees(+46.23301802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29203"},
        {"Hipparcos Number", "HIP 21583"},
        {"Smithsonian Astrophysical Observation", "SAO 39658"},
        {"Wilson Evans Batten Catalogue", "WEB 4142"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.52440025),
        dec: Angle.Degrees(+46.23370588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27846"},
        {"Hipparcos Number", "HIP 20683"},
        {"Celescope Catalog", "CEL 397"},
        {"Geneva Identification System", "GEN# +1.00027846"},
        {"Smithsonian Astrophysical Observation", "SAO 39524"},
        {"Wilson Evans Batten Catalogue", "WEB 3962"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.45836976),
        dec: Angle.Degrees(+46.23386718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 616 AB"},
        {"Henry Draper", "HD 4134"},
        {"Hipparcos Number", "HIP 3454"},
        {"Smithsonian Astrophysical Observation", "SAO 36611"},
        {"Wilson Evans Batten Catalogue", "WEB 610"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.04669052),
        dec: Angle.Degrees(+46.23561757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165298"},
        {"Hipparcos Number", "HIP 88393"},
        {"Geneva Identification System", "GEN# +1.00165298"},
        {"Smithsonian Astrophysical Observation", "SAO 47171"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.74900339),
        dec: Angle.Degrees(+46.23574238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16135"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.97174592),
        dec: Angle.Degrees(+46.24047769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157325"},
        {"Hipparcos Number", "HIP 84835"},
        {"Fundamental Katalog 5th Edition", "FK5 3377"},
        {"Geneva Identification System", "GEN# +1.00157325"},
        {"Smithsonian Astrophysical Observation", "SAO 46645"},
        {"Wilson Evans Batten Catalogue", "WEB 14323"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.08811224),
        dec: Angle.Degrees(+46.24068047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88160"},
        {"Hipparcos Number", "HIP 49884"},
        {"Smithsonian Astrophysical Observation", "SAO 43221"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.79389525),
        dec: Angle.Degrees(+46.24161667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89594"},
        {"Hipparcos Number", "HIP 50710"},
        {"Smithsonian Astrophysical Observation", "SAO 43298"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.31760387),
        dec: Angle.Degrees(+46.24582936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60070"},
        {"Smithsonian Astrophysical Observation", "SAO 44120"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.77093518),
        dec: Angle.Degrees(+46.24704218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44533"},
        {"Smithsonian Astrophysical Observation", "SAO 42672"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.11137373),
        dec: Angle.Degrees(+46.24818173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105622"},
        {"New General Catalogue", "NGC 7062 201"},
    },
    visualMagnitude: 12.15,
    bvColour: 2.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.89670800),
        dec: Angle.Degrees(+46.24851141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71245"},
        {"Hipparcos Number", "HIP 41525"},
        {"Smithsonian Astrophysical Observation", "SAO 42376"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.02991526),
        dec: Angle.Degrees(+46.24886152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132467"},
        {"Hipparcos Number", "HIP 73207"},
        {"Geneva Identification System", "GEN# +1.00132467"},
        {"Smithsonian Astrophysical Observation", "SAO 45304"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.42936439),
        dec: Angle.Degrees(+46.25126902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103557",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199986"},
        {"Hipparcos Number", "HIP 103557"},
        {"Geneva Identification System", "GEN# +1.00199986"},
        {"Smithsonian Astrophysical Observation", "SAO 50314"},
        {"Wilson Evans Batten Catalogue", "WEB 18841"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.72768412),
        dec: Angle.Degrees(+46.25261241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151287"},
        {"Hipparcos Number", "HIP 81948"},
        {"Geneva Identification System", "GEN# +1.00151287"},
        {"Smithsonian Astrophysical Observation", "SAO 46256"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.08734796),
        dec: Angle.Degrees(+46.25276507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17898"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.42035718),
        dec: Angle.Degrees(+46.25548887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205199"},
        {"Hipparcos Number", "HIP 106341"},
        {"Smithsonian Astrophysical Observation", "SAO 50998"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.06142297),
        dec: Angle.Degrees(+46.25725648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16563",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2594 A"},
        {"Henry Draper", "HD 21845"},
        {"Hipparcos Number", "HIP 16563"},
        {"Smithsonian Astrophysical Observation", "SAO 38935"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.30597056),
        dec: Angle.Degrees(+46.25780038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99900"},
        {"Hipparcos Number", "HIP 56098"},
        {"Geneva Identification System", "GEN# +1.00099900"},
        {"Smithsonian Astrophysical Observation", "SAO 43778"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.48941315),
        dec: Angle.Degrees(+46.25805545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23897"},
        {"Hipparcos Number", "HIP 17980"},
        {"Smithsonian Astrophysical Observation", "SAO 39139"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.65075112),
        dec: Angle.Degrees(+46.26125118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136730"},
        {"Hipparcos Number", "HIP 75074"},
        {"Smithsonian Astrophysical Observation", "SAO 45494"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.12635630),
        dec: Angle.Degrees(+46.26373062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170002"},
        {"Hipparcos Number", "HIP 90258"},
        {"Geneva Identification System", "GEN# +1.00170002"},
        {"Smithsonian Astrophysical Observation", "SAO 47475"},
        {"Wilson Evans Batten Catalogue", "WEB 15442"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.25232451),
        dec: Angle.Degrees(+46.26737371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 155",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 155"},
        {"Smithsonian Astrophysical Observation", "SAO 53582"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.49113894),
        dec: Angle.Degrees(+46.26916275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206329"},
        {"Hipparcos Number", "HIP 106983"},
        {"Smithsonian Astrophysical Observation", "SAO 51166"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.01816183),
        dec: Angle.Degrees(+46.27171967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158446"},
        {"Hipparcos Number", "HIP 85400"},
        {"Geneva Identification System", "GEN# +1.00158446"},
        {"Smithsonian Astrophysical Observation", "SAO 46726"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.76486340),
        dec: Angle.Degrees(+46.27172163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213732"},
        {"Hipparcos Number", "HIP 111292"},
        {"Renson", "Renson 59290"},
    },
    visualMagnitude: 10.10,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.17937180),
        dec: Angle.Degrees(+46.27240631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166067"},
        {"Hipparcos Number", "HIP 88715"},
        {"Geneva Identification System", "GEN# +1.00166067"},
        {"Smithsonian Astrophysical Observation", "SAO 47224"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.66176601),
        dec: Angle.Degrees(+46.27328565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50658"},
        {"Hipparcos Number", "HIP 33377"},
        {"Geneva Identification System", "GEN# +1.00050658"},
        {"Smithsonian Astrophysical Observation", "SAO 41446"},
        {"Wilson Evans Batten Catalogue", "WEB 6708"},
    },
    visualMagnitude: 5.85,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.13358487),
        dec: Angle.Degrees(+46.27398621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83257",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10311 A"},
        {"Henry Draper", "HD 154082"},
        {"Hipparcos Number", "HIP 83257"},
        {"Smithsonian Astrophysical Observation", "SAO 46438"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.25223361),
        dec: Angle.Degrees(+46.27411169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103879"},
        {"Smithsonian Astrophysical Observation", "SAO 50393"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.73351307),
        dec: Angle.Degrees(+46.27423273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18024",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18024"},
        {"Smithsonian Astrophysical Observation", "SAO 39147"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.78312241),
        dec: Angle.Degrees(+46.27564549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3043"},
        {"Smithsonian Astrophysical Observation", "SAO 36540"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.66988152),
        dec: Angle.Degrees(+46.27616240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153059"},
        {"Hipparcos Number", "HIP 82776"},
        {"Smithsonian Astrophysical Observation", "SAO 46366"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.75208784),
        dec: Angle.Degrees(+46.27620893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22390"},
        {"Hipparcos Number", "HIP 16955"},
        {"Smithsonian Astrophysical Observation", "SAO 38998"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.52560164),
        dec: Angle.Degrees(+46.27635547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80674"},
        {"Hipparcos Number", "HIP 45985"},
        {"Smithsonian Astrophysical Observation", "SAO 42829"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.67173347),
        dec: Angle.Degrees(+46.27860058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42534",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6908 AB"},
        {"Hipparcos Number", "HIP 42534"},
        {"Smithsonian Astrophysical Observation", "SAO 42476"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.07246034),
        dec: Angle.Degrees(+46.27992939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10335",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10335"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.29601134),
        dec: Angle.Degrees(+46.28085420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119170"},
        {"Hipparcos Number", "HIP 66718"},
        {"Geneva Identification System", "GEN# +1.00119170"},
        {"Smithsonian Astrophysical Observation", "SAO 44707"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.13846979),
        dec: Angle.Degrees(+46.28090146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87899"},
        {"Hipparcos Number", "HIP 49738"},
        {"Geneva Identification System", "GEN# +1.00087899"},
        {"Smithsonian Astrophysical Observation", "SAO 43212"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.30989046),
        dec: Angle.Degrees(+46.28405670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105140"},
        {"Hipparcos Number", "HIP 59044"},
        {"Fundamental Katalog 5th Edition", "FK5 5069"},
        {"Geneva Identification System", "GEN# +1.00105140"},
        {"Smithsonian Astrophysical Observation", "SAO 44032"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.58115439),
        dec: Angle.Degrees(+46.28415434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71678"},
        {"Hipparcos Number", "HIP 41734"},
        {"Smithsonian Astrophysical Observation", "SAO 42399"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.64971461),
        dec: Angle.Degrees(+46.28618740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58549"},
        {"Hipparcos Number", "HIP 36294"},
        {"Geneva Identification System", "GEN# +1.00058549"},
        {"Smithsonian Astrophysical Observation", "SAO 41787"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.06697350),
        dec: Angle.Degrees(+46.28628068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222064"},
        {"Hipparcos Number", "HIP 116540"},
        {"Smithsonian Astrophysical Observation", "SAO 53191"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.27439794),
        dec: Angle.Degrees(+46.28738936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115058"},
        {"Cincinnati Publication", "Ci 20 1416"},
    },
    visualMagnitude: 10.92,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.57357828),
        dec: Angle.Degrees(+46.28896124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 331.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99559"},
        {"Hipparcos Number", "HIP 55917"},
        {"Geneva Identification System", "GEN# +1.00099559"},
        {"Smithsonian Astrophysical Observation", "SAO 43744"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.91438720),
        dec: Angle.Degrees(+46.29284136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28714",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28714"},
        {"Wilson Evans Batten Catalogue", "WEB 5617"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.97377984),
        dec: Angle.Degrees(+46.29302568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195048"},
        {"Hipparcos Number", "HIP 100863"},
        {"Smithsonian Astrophysical Observation", "SAO 49638"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.77035402),
        dec: Angle.Degrees(+46.29418706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141374"},
        {"Hipparcos Number", "HIP 77296"},
        {"Smithsonian Astrophysical Observation", "SAO 45723"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.71556208),
        dec: Angle.Degrees(+46.29675702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123085"},
        {"Hipparcos Number", "HIP 68758"},
        {"Smithsonian Astrophysical Observation", "SAO 44871"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.10176816),
        dec: Angle.Degrees(+46.29678560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191240"},
        {"Hipparcos Number", "HIP 99089"},
        {"Smithsonian Astrophysical Observation", "SAO 49198"},
        {"Wilson Evans Batten Catalogue", "WEB 17625"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.74139543),
        dec: Angle.Degrees(+46.29950516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192239"},
        {"Hipparcos Number", "HIP 99542"},
        {"Smithsonian Astrophysical Observation", "SAO 49312"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.02283248),
        dec: Angle.Degrees(+46.29979221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 291.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67649"},
        {"Smithsonian Astrophysical Observation", "SAO 44780"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.90581298),
        dec: Angle.Degrees(+46.30283108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218851"},
        {"Hipparcos Number", "HIP 114452"},
        {"Geneva Identification System", "GEN# +1.00218851"},
        {"Wilson Evans Batten Catalogue", "WEB 20315"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.69241876),
        dec: Angle.Degrees(+46.30298016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184498"},
        {"Hipparcos Number", "HIP 96129"},
        {"Geneva Identification System", "GEN# +1.00184498"},
        {"Smithsonian Astrophysical Observation", "SAO 48573"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.18429678),
        dec: Angle.Degrees(+46.31063110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79992",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10010 A"},
        {"Henry Draper", "HD 147394"},
        {"Hipparcos Number", "HIP 79992"},
        {"Fundamental Katalog 5th Edition", "FK5 608"},
        {"Geneva Identification System", "GEN# +1.00147394"},
        {"Smithsonian Astrophysical Observation", "SAO 46028"},
        {"Wilson Evans Batten Catalogue", "WEB 13540"},
    },
    visualMagnitude: 3.91,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.93519958),
        dec: Angle.Degrees(+46.31327084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58681"},
        {"Hipparcos Number", "HIP 36351"},
        {"Smithsonian Astrophysical Observation", "SAO 41799"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.21942210),
        dec: Angle.Degrees(+46.31477733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174177"},
        {"Hipparcos Number", "HIP 92156"},
        {"Geneva Identification System", "GEN# +1.00174177"},
        {"Smithsonian Astrophysical Observation", "SAO 47798"},
        {"Wilson Evans Batten Catalogue", "WEB 15890"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.74610599),
        dec: Angle.Degrees(+46.31496028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38832"},
        {"Hipparcos Number", "HIP 27630"},
        {"Smithsonian Astrophysical Observation", "SAO 40645"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.74338539),
        dec: Angle.Degrees(+46.31654147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115502"},
        {"Hipparcos Number", "HIP 64798"},
        {"Geneva Identification System", "GEN# +1.00115502"},
        {"Smithsonian Astrophysical Observation", "SAO 44544"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.21480672),
        dec: Angle.Degrees(+46.31812658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102306",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14219 A"},
        {"Henry Draper", "HD 197717"},
        {"Hipparcos Number", "HIP 102306"},
        {"Smithsonian Astrophysical Observation", "SAO 50000"},
        {"Wilson Evans Batten Catalogue", "WEB 18522"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.93396793),
        dec: Angle.Degrees(+46.31817069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104921",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104921"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.79840366),
        dec: Angle.Degrees(+46.31974673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24469"},
        {"Hipparcos Number", "HIP 18359"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.88640228),
        dec: Angle.Degrees(+46.31983011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96532",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12713 A"},
        {"Hipparcos Number", "HIP 96532"},
        {"New General Catalogue", "NGC 6811 113"},
    },
    visualMagnitude: 11.49,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.38379599),
        dec: Angle.Degrees(+46.32085580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1711"},
        {"Hipparcos Number", "HIP 1711"},
        {"Smithsonian Astrophysical Observation", "SAO 36295"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.38661139),
        dec: Angle.Degrees(+46.32165724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193536"},
        {"Hipparcos Number", "HIP 100142"},
        {"Celescope Catalog", "CEL 5023"},
        {"Geneva Identification System", "GEN# +1.00193536"},
        {"Smithsonian Astrophysical Observation", "SAO 49462"},
        {"Wilson Evans Batten Catalogue", "WEB 18036"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.70696744),
        dec: Angle.Degrees(+46.32221345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86574"},
        {"Renson", "Renson 45380"},
        {"Smithsonian Astrophysical Observation", "SAO 46889"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.38198535),
        dec: Angle.Degrees(+46.32325547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55969"},
        {"Hipparcos Number", "HIP 35291"},
        {"Smithsonian Astrophysical Observation", "SAO 41664"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.36265762),
        dec: Angle.Degrees(+46.32391303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179890"},
        {"Hipparcos Number", "HIP 94335"},
        {"Smithsonian Astrophysical Observation", "SAO 48190"},
        {"Wilson Evans Batten Catalogue", "WEB 16432"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.02026065),
        dec: Angle.Degrees(+46.32401865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124694"},
        {"Hipparcos Number", "HIP 69518"},
        {"Geneva Identification System", "GEN# +1.00124694"},
        {"Smithsonian Astrophysical Observation", "SAO 44946"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.46435706),
        dec: Angle.Degrees(+46.32514444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42867"},
        {"Geneva Identification System", "GEN# +0.04601426"},
        {"Smithsonian Astrophysical Observation", "SAO 42517"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.03770090),
        dec: Angle.Degrees(+46.32627807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67997"},
        {"Smithsonian Astrophysical Observation", "SAO 44801"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.87076873),
        dec: Angle.Degrees(+46.32676037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217262"},
        {"Hipparcos Number", "HIP 113474"},
        {"Geneva Identification System", "GEN# +1.00217262"},
        {"Smithsonian Astrophysical Observation", "SAO 52554"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.70657105),
        dec: Angle.Degrees(+46.32729279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218052"},
        {"Hipparcos Number", "HIP 113949"},
        {"Smithsonian Astrophysical Observation", "SAO 52654"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.14335632),
        dec: Angle.Degrees(+46.33005437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159410"},
        {"Hipparcos Number", "HIP 85824"},
        {"Smithsonian Astrophysical Observation", "SAO 46784"},
        {"Wilson Evans Batten Catalogue", "WEB 14482"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.05670707),
        dec: Angle.Degrees(+46.33047894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200776"},
        {"Hipparcos Number", "HIP 103968"},
        {"Celescope Catalog", "CEL 5240"},
        {"Geneva Identification System", "GEN# +1.00200776"},
        {"Smithsonian Astrophysical Observation", "SAO 50411"},
        {"Wilson Evans Batten Catalogue", "WEB 18935"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.97413979),
        dec: Angle.Degrees(+46.33053377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184147"},
        {"Hipparcos Number", "HIP 95980"},
        {"Smithsonian Astrophysical Observation", "SAO 48541"},
    },
    visualMagnitude: 7.17,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.75454304),
        dec: Angle.Degrees(+46.33178266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151235"},
        {"Hipparcos Number", "HIP 81929"},
        {"Geneva Identification System", "GEN# +1.00151235"},
        {"Renson", "Renson 42770"},
        {"Smithsonian Astrophysical Observation", "SAO 46255"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.00956163),
        dec: Angle.Degrees(+46.33202663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18982"},
        {"Hipparcos Number", "HIP 14336"},
        {"Fundamental Katalog 5th Edition", "FK5 4280"},
        {"Smithsonian Astrophysical Observation", "SAO 38552"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.21142781),
        dec: Angle.Degrees(+46.33741542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6292",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1090 A"},
        {"Henry Draper", "HD 8044"},
        {"Hipparcos Number", "HIP 6292"},
        {"Smithsonian Astrophysical Observation", "SAO 37136"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.18440983),
        dec: Angle.Degrees(+46.33846791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11253"},
        {"Hipparcos Number", "HIP 8684"},
        {"Smithsonian Astrophysical Observation", "SAO 37568"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.93147894),
        dec: Angle.Degrees(+46.33871738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68588",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9090 AB"},
        {"Hipparcos Number", "HIP 68588"},
        {"Cincinnati Publication", "Ci 20 829"},
        {"Geneva Identification System", "GEN# +0.04702112"},
        {"Wilson Evans Batten Catalogue", "WEB 12012"},
    },
    visualMagnitude: 13.09,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)14, (int)02, 28.4600),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)20, 27.700)
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
    primaryId: "HIP 85686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159137"},
        {"Hipparcos Number", "HIP 85686"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.66425787),
        dec: Angle.Degrees(+46.34175222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -224.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 185.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6291",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1090 B"},
        {"Hipparcos Number", "HIP 6291"},
        {"Smithsonian Astrophysical Observation", "SAO 37135"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.18108047),
        dec: Angle.Degrees(+46.34341910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10006"},
        {"Hipparcos Number", "HIP 7668"},
        {"Smithsonian Astrophysical Observation", "SAO 37397"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.67848760),
        dec: Angle.Degrees(+46.34645938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96538"},
        {"New General Catalogue", "NGC 6811 106"},
    },
    visualMagnitude: 11.38,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.39577155),
        dec: Angle.Degrees(+46.34829945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199394"},
        {"Hipparcos Number", "HIP 103263"},
        {"Geneva Identification System", "GEN# +1.00199394"},
        {"Smithsonian Astrophysical Observation", "SAO 50225"},
        {"Wilson Evans Batten Catalogue", "WEB 18763"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.78807402),
        dec: Angle.Degrees(+46.35026239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102449"},
        {"Geneva Identification System", "GEN# +0.04503260"},
        {"Geneva Identification System 2", "GEN# +7.30401533"},
        {"Smithsonian Astrophysical Observation", "SAO 50033"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.39700903),
        dec: Angle.Degrees(+46.35058733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15555 B"},
        {"Hipparcos Number", "HIP 108710"},
        {"Smithsonian Astrophysical Observation", "SAO 51559"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.32247696),
        dec: Angle.Degrees(+46.35157266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103405"},
        {"Hipparcos Number", "HIP 58060"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.61896317),
        dec: Angle.Degrees(+46.35218119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203482"},
        {"Hipparcos Number", "HIP 105414"},
        {"Smithsonian Astrophysical Observation", "SAO 50743"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.27031455),
        dec: Angle.Degrees(+46.35294639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108712",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15555 A"},
        {"Hipparcos Number", "HIP 108712"},
        {"Smithsonian Astrophysical Observation", "SAO 51561"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.32896904),
        dec: Angle.Degrees(+46.35309619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197961"},
        {"Hipparcos Number", "HIP 102430"},
        {"Celescope Catalog", "CEL 5161"},
        {"Geneva Identification System", "GEN# +1.00197961"},
        {"Smithsonian Astrophysical Observation", "SAO 50027"},
        {"Wilson Evans Batten Catalogue", "WEB 18546"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.33743785),
        dec: Angle.Degrees(+46.35484700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16185"},
        {"Hipparcos Number", "HIP 12226"},
        {"Smithsonian Astrophysical Observation", "SAO 38173"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.35224417),
        dec: Angle.Degrees(+46.35486694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154815"},
        {"Hipparcos Number", "HIP 83623"},
        {"Smithsonian Astrophysical Observation", "SAO 46482"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.35741348),
        dec: Angle.Degrees(+46.35577910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47411"},
        {"Hipparcos Number", "HIP 31974"},
        {"Smithsonian Astrophysical Observation", "SAO 41260"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.23186898),
        dec: Angle.Degrees(+46.35636367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136922"},
        {"Hipparcos Number", "HIP 75148"},
        {"Smithsonian Astrophysical Observation", "SAO 45504"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.37265536),
        dec: Angle.Degrees(+46.35665849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224166"},
        {"Hipparcos Number", "HIP 117963"},
        {"Geneva Identification System", "GEN# +1.00224166"},
        {"Renson", "Renson 61440"},
        {"Smithsonian Astrophysical Observation", "SAO 53487"},
        {"Wilson Evans Batten Catalogue", "WEB 20747"},
    },
    visualMagnitude: 6.94,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.90806103),
        dec: Angle.Degrees(+46.35832487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97486"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.21202566),
        dec: Angle.Degrees(+46.35885779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43380"},
        {"Hipparcos Number", "HIP 29949"},
        {"Geneva Identification System", "GEN# +1.00043380"},
        {"Smithsonian Astrophysical Observation", "SAO 41010"},
        {"Wilson Evans Batten Catalogue", "WEB 5937"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.57022944),
        dec: Angle.Degrees(+46.36076039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49206",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7613 AB"},
        {"Henry Draper", "HD 86872"},
        {"Hipparcos Number", "HIP 49206"},
        {"Smithsonian Astrophysical Observation", "SAO 43152"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.64876258),
        dec: Angle.Degrees(+46.36184753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73103"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.11809882),
        dec: Angle.Degrees(+46.36223921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169571"},
        {"Hipparcos Number", "HIP 90079"},
        {"Geneva Identification System", "GEN# +1.00169571"},
        {"Smithsonian Astrophysical Observation", "SAO 47448"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.74834629),
        dec: Angle.Degrees(+46.36246529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215411"},
        {"Hipparcos Number", "HIP 112262"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.07864019),
        dec: Angle.Degrees(+46.36353908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4406"},
        {"Hipparcos Number", "HIP 3662"},
        {"Geneva Identification System", "GEN# +1.00004406"},
        {"Smithsonian Astrophysical Observation", "SAO 36652"},
        {"Wilson Evans Batten Catalogue", "WEB 651"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.71567486),
        dec: Angle.Degrees(+46.36366796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25931"},
        {"Hipparcos Number", "HIP 19315"},
        {"Smithsonian Astrophysical Observation", "SAO 39333"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.10681882),
        dec: Angle.Degrees(+46.36597430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110667",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110667"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.28754885),
        dec: Angle.Degrees(+46.36682406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220474"},
        {"Hipparcos Number", "HIP 115487"},
        {"Smithsonian Astrophysical Observation", "SAO 52967"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.91617803),
        dec: Angle.Degrees(+46.36824278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216037"},
        {"Hipparcos Number", "HIP 112639"},
        {"Smithsonian Astrophysical Observation", "SAO 52387"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.19665854),
        dec: Angle.Degrees(+46.36973945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117403"},
        {"Hipparcos Number", "HIP 65803"},
        {"Geneva Identification System", "GEN# +1.00117403"},
        {"Smithsonian Astrophysical Observation", "SAO 44627"},
        {"Wilson Evans Batten Catalogue", "WEB 11644"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.32806560),
        dec: Angle.Degrees(+46.37088689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216797"},
        {"Hipparcos Number", "HIP 113187"},
        {"Smithsonian Astrophysical Observation", "SAO 52491"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.80748876),
        dec: Angle.Degrees(+46.37227374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99211",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13428 AB"},
        {"Henry Draper", "HD 191528"},
        {"Hipparcos Number", "HIP 99211"},
        {"Geneva Identification System", "GEN# +1.00191528J"},
        {"Renson", "Renson 53380"},
        {"Smithsonian Astrophysical Observation", "SAO 49231"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.11307279),
        dec: Angle.Degrees(+46.37487793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45069"},
        {"Geneva Identification System", "GEN# +9.80115058"},
    },
    visualMagnitude: 12.10,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.70044853),
        dec: Angle.Degrees(+46.37742031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218844"},
        {"Hipparcos Number", "HIP 114441"},
        {"Smithsonian Astrophysical Observation", "SAO 52765"},
    },
    visualMagnitude: 8.20,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.65701674),
        dec: Angle.Degrees(+46.37788143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105599"},
        {"Hipparcos Number", "HIP 59268"},
        {"Smithsonian Astrophysical Observation", "SAO 44057"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.35053066),
        dec: Angle.Degrees(+46.37939691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117111",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16965"},
        {"Aitken 2", "ADS 16965 A"},
        {"Henry Draper", "HD 222900"},
        {"Hipparcos Number", "HIP 117111"},
        {"Smithsonian Astrophysical Observation", "SAO 53332"},
        {"Wilson Evans Batten Catalogue", "WEB 20643"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.13392851),
        dec: Angle.Degrees(+46.38016664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62997"},
        {"Geneva Identification System", "GEN# +0.04702001"},
        {"Wilson Evans Batten Catalogue", "WEB 11169"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.63314542),
        dec: Angle.Degrees(+46.38156430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103704"},
        {"Geneva Identification System", "GEN# +0.04503361"},
        {"Smithsonian Astrophysical Observation", "SAO 50354"},
        {"Wilson Evans Batten Catalogue", "WEB 18877"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.21967625),
        dec: Angle.Degrees(+46.38312730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2599"},
        {"Hipparcos Number", "HIP 2335"},
        {"Smithsonian Astrophysical Observation", "SAO 36416"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.46435895),
        dec: Angle.Degrees(+46.38503682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114189"},
        {"Hipparcos Number", "HIP 64110"},
        {"Smithsonian Astrophysical Observation", "SAO 44483"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.08929640),
        dec: Angle.Degrees(+46.38514978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186176"},
        {"Hipparcos Number", "HIP 96817"},
        {"Geneva Identification System", "GEN# +1.00186176"},
        {"Smithsonian Astrophysical Observation", "SAO 48717"},
        {"Wilson Evans Batten Catalogue", "WEB 16994"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.19484411),
        dec: Angle.Degrees(+46.38558437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138421"},
        {"Hipparcos Number", "HIP 75899"},
        {"Fundamental Katalog 5th Edition", "FK5 5371"},
        {"Smithsonian Astrophysical Observation", "SAO 45575"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.53994460),
        dec: Angle.Degrees(+46.38606831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19706"},
        {"Hipparcos Number", "HIP 14892"},
        {"Geneva Identification System", "GEN# +1.00019706"},
        {"Smithsonian Astrophysical Observation", "SAO 38634"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.04735015),
        dec: Angle.Degrees(+46.38611898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102156"},
        {"Smithsonian Astrophysical Observation", "SAO 49953"},
        {"Wilson Evans Batten Catalogue", "WEB 18482"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.48750184),
        dec: Angle.Degrees(+46.38667720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114200",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16526 A"},
        {"Henry Draper", "HD 218452"},
        {"Hipparcos Number", "HIP 114200"},
        {"Fundamental Katalog 5th Edition", "FK5 3852"},
        {"Geneva Identification System", "GEN# +1.00218452"},
        {"Smithsonian Astrophysical Observation", "SAO 52711"},
        {"Wilson Evans Batten Catalogue", "WEB 20281"},
    },
    visualMagnitude: 5.30,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.91365671),
        dec: Angle.Degrees(+46.38730373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 487"},
        {"Hipparcos Number", "HIP 767"},
        {"Smithsonian Astrophysical Observation", "SAO 36109"},
        {"Wilson Evans Batten Catalogue", "WEB 130"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.36489397),
        dec: Angle.Degrees(+46.38790478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112860"},
        {"Hipparcos Number", "HIP 63369"},
        {"Geneva Identification System", "GEN# +1.00112860"},
        {"Smithsonian Astrophysical Observation", "SAO 44411"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.77058783),
        dec: Angle.Degrees(+46.38891967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55161",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55161"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.40001942),
        dec: Angle.Degrees(+46.38958086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 817",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 119 AB"},
        {"Henry Draper", "HD 556"},
        {"Hipparcos Number", "HIP 817"},
        {"Smithsonian Astrophysical Observation", "SAO 36118"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.51326491),
        dec: Angle.Degrees(+46.39035323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21661",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21661"},
        {"Geneva Identification System", "GEN# +0.04600899"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.76250974),
        dec: Angle.Degrees(+46.39043917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109346"},
        {"Smithsonian Astrophysical Observation", "SAO 51695"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.27969939),
        dec: Angle.Degrees(+46.39100646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150377"},
        {"Hipparcos Number", "HIP 81482"},
        {"Smithsonian Astrophysical Observation", "SAO 46207"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.63154590),
        dec: Angle.Degrees(+46.39381691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15510"},
        {"Hipparcos Number", "HIP 11719"},
        {"Geneva Identification System", "GEN# +1.00015510"},
        {"Smithsonian Astrophysical Observation", "SAO 38084"},
        {"Wilson Evans Batten Catalogue", "WEB 2434"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.81534040),
        dec: Angle.Degrees(+46.39499143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42783"},
        {"Hipparcos Number", "HIP 29667"},
        {"Geneva Identification System", "GEN# +1.00042783"},
        {"Smithsonian Astrophysical Observation", "SAO 40967"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.74450998),
        dec: Angle.Degrees(+46.39576524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100562"},
        {"Smithsonian Astrophysical Observation", "SAO 49571"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.86864305),
        dec: Angle.Degrees(+46.39603707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81975"},
        {"Hipparcos Number", "HIP 46629"},
        {"Smithsonian Astrophysical Observation", "SAO 42896"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.63574007),
        dec: Angle.Degrees(+46.39950597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9251"},
        {"Hipparcos Number", "HIP 7132"},
        {"Smithsonian Astrophysical Observation", "SAO 37293"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.97303399),
        dec: Angle.Degrees(+46.39985169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51824"},
        {"Smithsonian Astrophysical Observation", "SAO 43391"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.81177108),
        dec: Angle.Degrees(+46.40515527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168619"},
        {"Hipparcos Number", "HIP 89694"},
        {"Geneva Identification System", "GEN# +1.00168619"},
        {"Smithsonian Astrophysical Observation", "SAO 47376"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.57476780),
        dec: Angle.Degrees(+46.40712192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66228"},
        {"Smithsonian Astrophysical Observation", "SAO 44667"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.60365816),
        dec: Angle.Degrees(+46.40772760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60948"},
    },
    visualMagnitude: 11.37,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.40405241),
        dec: Angle.Degrees(+46.40974304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224559"},
        {"Hipparcos Number", "HIP 118214"},
        {"Geneva Identification System", "GEN# +1.00224559"},
        {"Smithsonian Astrophysical Observation", "SAO 53540"},
        {"Wilson Evans Batten Catalogue", "WEB 20780"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.69344326),
        dec: Angle.Degrees(+46.41317736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181117"},
        {"Hipparcos Number", "HIP 94776"},
        {"Smithsonian Astrophysical Observation", "SAO 48286"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.26980282),
        dec: Angle.Degrees(+46.41325770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109046",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109046"},
        {"Geneva Identification System", "GEN# +2.72090098"},
        {"New General Catalogue", "NGC 7209 98"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.35549815),
        dec: Angle.Degrees(+46.41383882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12625"},
        {"Smithsonian Astrophysical Observation", "SAO 38252"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.56844690),
        dec: Angle.Degrees(+46.41513766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61942",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61942"},
        {"Geneva Identification System", "GEN# +0.04701982"},
        {"Smithsonian Astrophysical Observation", "SAO 44287"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.41765884),
        dec: Angle.Degrees(+46.41625698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196196"},
        {"Hipparcos Number", "HIP 101486"},
        {"Celescope Catalog", "CEL 5118"},
        {"Geneva Identification System", "GEN# +1.00196196"},
        {"Smithsonian Astrophysical Observation", "SAO 49806"},
    },
    visualMagnitude: 7.67,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.49270578),
        dec: Angle.Degrees(+46.41629735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105959",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204482"},
        {"Hipparcos Number", "HIP 105959"},
        {"Smithsonian Astrophysical Observation", "SAO 50882"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.87910070),
        dec: Angle.Degrees(+46.41657395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26331"},
        {"Hipparcos Number", "HIP 19602"},
        {"Smithsonian Astrophysical Observation", "SAO 39374"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.00423347),
        dec: Angle.Degrees(+46.41835150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212029"},
        {"Hipparcos Number", "HIP 110291"},
        {"Geneva Identification System", "GEN# +1.00212029"},
        {"Smithsonian Astrophysical Observation", "SAO 51893"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.10004065),
        dec: Angle.Degrees(+46.41840989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -190.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173288"},
        {"Hipparcos Number", "HIP 91717"},
        {"Smithsonian Astrophysical Observation", "SAO 47721"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.54449854),
        dec: Angle.Degrees(+46.41884739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223047"},
        {"Hipparcos Number", "HIP 117221"},
        {"Fundamental Katalog 5th Edition", "FK5 1622"},
        {"Geneva Identification System", "GEN# +1.00223047"},
        {"Smithsonian Astrophysical Observation", "SAO 53355"},
        {"Wilson Evans Batten Catalogue", "WEB 20654"},
    },
    visualMagnitude: 4.97,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.50849555),
        dec: Angle.Degrees(+46.42029095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26956"},
        {"Smithsonian Astrophysical Observation", "SAO 40554"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.80297623),
        dec: Angle.Degrees(+46.42149487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170710"},
        {"Hipparcos Number", "HIP 90551"},
        {"Geneva Identification System", "GEN# +1.00170710"},
        {"Smithsonian Astrophysical Observation", "SAO 47524"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.14834925),
        dec: Angle.Degrees(+46.42326635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43244"},
        {"Hipparcos Number", "HIP 29884"},
        {"Geneva Identification System", "GEN# +1.00043244"},
        {"Smithsonian Astrophysical Observation", "SAO 40999"},
        {"Wilson Evans Batten Catalogue", "WEB 5916"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.39451401),
        dec: Angle.Degrees(+46.42392575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204812"},
        {"Hipparcos Number", "HIP 106108"},
        {"Smithsonian Astrophysical Observation", "SAO 50935"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.40300599),
        dec: Angle.Degrees(+46.42645377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108981"},
        {"Geneva Identification System", "GEN# +2.72090046"},
        {"New General Catalogue", "NGC 7209 46"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.17312285),
        dec: Angle.Degrees(+46.42725214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73592"},
        {"Hipparcos Number", "HIP 42599"},
        {"Geneva Identification System", "GEN# +1.00073592"},
        {"Smithsonian Astrophysical Observation", "SAO 42484"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.23319833),
        dec: Angle.Degrees(+46.42971750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100040"},
        {"Smithsonian Astrophysical Observation", "SAO 49435"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.43951779),
        dec: Angle.Degrees(+46.43606854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64867"},
        {"Hipparcos Number", "HIP 38937"},
        {"Geneva Identification System", "GEN# +1.00064867"},
        {"Smithsonian Astrophysical Observation", "SAO 42091"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.50718022),
        dec: Angle.Degrees(+46.43757088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135574"},
        {"Hipparcos Number", "HIP 74572"},
        {"Smithsonian Astrophysical Observation", "SAO 45446"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.54578459),
        dec: Angle.Degrees(+46.43832753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95368",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12412 AB"},
        {"Henry Draper", "HD 182754"},
        {"Hipparcos Number", "HIP 95368"},
        {"Celescope Catalog", "CEL 4745"},
        {"Geneva Identification System", "GEN# +1.00182754J"},
        {"Smithsonian Astrophysical Observation", "SAO 48406"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.02302687),
        dec: Angle.Degrees(+46.43841904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33381"},
        {"Hipparcos Number", "HIP 24241"},
        {"Smithsonian Astrophysical Observation", "SAO 40104"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.06914086),
        dec: Angle.Degrees(+46.43875125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28280"},
        {"Hipparcos Number", "HIP 20975"},
        {"Renson", "Renson 7220"},
        {"Smithsonian Astrophysical Observation", "SAO 39564"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.48240297),
        dec: Angle.Degrees(+46.43903776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165523"},
        {"Hipparcos Number", "HIP 88485"},
        {"Geneva Identification System", "GEN# +1.00165523"},
        {"Smithsonian Astrophysical Observation", "SAO 47187"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.02094730),
        dec: Angle.Degrees(+46.44202168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98628"},
        {"Hipparcos Number", "HIP 55449"},
        {"Smithsonian Astrophysical Observation", "SAO 43707"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.34523883),
        dec: Angle.Degrees(+46.44429183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18219",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2830 AB"},
        {"Henry Draper", "HD 24276"},
        {"Hipparcos Number", "HIP 18219"},
        {"Smithsonian Astrophysical Observation", "SAO 39177"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.43584119),
        dec: Angle.Degrees(+46.45056152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31266"},
        {"Hipparcos Number", "HIP 22965"},
        {"Smithsonian Astrophysical Observation", "SAO 39878"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.12764000),
        dec: Angle.Degrees(+46.45105158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215026"},
        {"Hipparcos Number", "HIP 112039"},
        {"Smithsonian Astrophysical Observation", "SAO 52272"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.39367472),
        dec: Angle.Degrees(+46.45179297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107492"},
        {"Celescope Catalog", "CEL 5383"},
        {"Smithsonian Astrophysical Observation", "SAO 51279"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.57809334),
        dec: Angle.Degrees(+46.45303491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95631"},
        {"Smithsonian Astrophysical Observation", "SAO 48459"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.77407025),
        dec: Angle.Degrees(+46.45403980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112940"},
        {"Hipparcos Number", "HIP 63410"},
        {"Geneva Identification System", "GEN# +1.00112940"},
        {"Renson", "Renson 32810"},
        {"Smithsonian Astrophysical Observation", "SAO 44417"},
        {"Wilson Evans Batten Catalogue", "WEB 11225"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.90567233),
        dec: Angle.Degrees(+46.45552455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65457"},
        {"Smithsonian Astrophysical Observation", "SAO 44599"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.23381777),
        dec: Angle.Degrees(+46.45559421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10556"},
    },
    visualMagnitude: 11.15,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.98098125),
        dec: Angle.Degrees(+46.45767086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 230.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130667"},
        {"Hipparcos Number", "HIP 72381"},
        {"Geneva Identification System", "GEN# +1.00130667"},
        {"Smithsonian Astrophysical Observation", "SAO 45219"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.99648398),
        dec: Angle.Degrees(+46.45783936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158066"},
        {"Hipparcos Number", "HIP 85218"},
        {"Smithsonian Astrophysical Observation", "SAO 46703"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.20321102),
        dec: Angle.Degrees(+46.45799770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113577"},
        {"Hipparcos Number", "HIP 63764"},
        {"Geneva Identification System", "GEN# +1.00113577"},
        {"Smithsonian Astrophysical Observation", "SAO 44449"},
        {"Wilson Evans Batten Catalogue", "WEB 11279"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.04390597),
        dec: Angle.Degrees(+46.45912593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222107"},
        {"Hipparcos Number", "HIP 116584"},
        {"Cincinnati Publication", "Ci 20 1442"},
        {"Fundamental Katalog 5th Edition", "FK5 890"},
        {"Geneva Identification System", "GEN# +1.00222107"},
        {"Smithsonian Astrophysical Observation", "SAO 53204"},
        {"Wilson Evans Batten Catalogue", "WEB 20581"},
    },
    visualMagnitude: 3.81,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.39044870),
        dec: Angle.Degrees(+46.45917621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -421.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9861"},
        {"Hipparcos Number", "HIP 7550"},
        {"Geneva Identification System", "GEN# +1.00009861"},
        {"Smithsonian Astrophysical Observation", "SAO 37369"},
        {"Wilson Evans Batten Catalogue", "WEB 1615"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.32038104),
        dec: Angle.Degrees(+46.45960188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221169"},
        {"Hipparcos Number", "HIP 115944"},
        {"Smithsonian Astrophysical Observation", "SAO 53074"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.36222432),
        dec: Angle.Degrees(+46.46494539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184938"},
        {"Hipparcos Number", "HIP 96296"},
        {"Geneva Identification System", "GEN# +1.00184938"},
        {"Smithsonian Astrophysical Observation", "SAO 48608"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.68970163),
        dec: Angle.Degrees(+46.46754423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48914"},
        {"Smithsonian Astrophysical Observation", "SAO 43124"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.67536247),
        dec: Angle.Degrees(+46.46841904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58117",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8347 D"},
        {"Henry Draper", "HD 103498"},
        {"Hipparcos Number", "HIP 58117"},
        {"Geneva Identification System", "GEN# +1.00103498"},
        {"Renson", "Renson 29830"},
        {"Smithsonian Astrophysical Observation", "SAO 43946"},
        {"Wilson Evans Batten Catalogue", "WEB 10407"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.79717288),
        dec: Angle.Degrees(+46.46978128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14213"},
        {"Hipparcos Number", "HIP 10814"},
        {"Geneva Identification System", "GEN# +1.00014213"},
        {"Smithsonian Astrophysical Observation", "SAO 37947"},
        {"Wilson Evans Batten Catalogue", "WEB 2279"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.79518193),
        dec: Angle.Degrees(+46.47228976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117750"},
        {"Geneva Identification System", "GEN# +0.04504348"},
        {"Smithsonian Astrophysical Observation", "SAO 53440"},
    },
    visualMagnitude: 9.48,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.20322995),
        dec: Angle.Degrees(+46.47298270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46016"},
        {"Hipparcos Number", "HIP 31238"},
        {"Smithsonian Astrophysical Observation", "SAO 41168"},
        {"Wilson Evans Batten Catalogue", "WEB 6244"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.29032511),
        dec: Angle.Degrees(+46.47623540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115020"},
        {"Hipparcos Number", "HIP 64538"},
        {"Geneva Identification System", "GEN# +1.00115020"},
        {"Smithsonian Astrophysical Observation", "SAO 44520"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.42120902),
        dec: Angle.Degrees(+46.47627673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83492"},
        {"Hipparcos Number", "HIP 47450"},
        {"Smithsonian Astrophysical Observation", "SAO 42970"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.05237718),
        dec: Angle.Degrees(+46.47638059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131446"},
        {"Hipparcos Number", "HIP 72718"},
        {"Smithsonian Astrophysical Observation", "SAO 45246"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.01346817),
        dec: Angle.Degrees(+46.47675015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8347 AB"},
        {"Henry Draper", "HD 103483"},
        {"Hipparcos Number", "HIP 58112"},
        {"Geneva Identification System", "GEN# +1.00103483"},
        {"Smithsonian Astrophysical Observation", "SAO 43945"},
        {"Wilson Evans Batten Catalogue", "WEB 10405"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.77391815),
        dec: Angle.Degrees(+46.47683910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32697"},
        {"Hipparcos Number", "HIP 23827"},
        {"Smithsonian Astrophysical Observation", "SAO 40032"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.84254118),
        dec: Angle.Degrees(+46.47818002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134531"},
        {"Hipparcos Number", "HIP 74108"},
        {"Smithsonian Astrophysical Observation", "SAO 45399"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.18536547),
        dec: Angle.Degrees(+46.47889136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52738",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52738"},
        {"Geneva Identification System", "GEN# +0.04701812"},
        {"Renson", "Renson 26940"},
        {"Smithsonian Astrophysical Observation", "SAO 43470"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.72577403),
        dec: Angle.Degrees(+46.47950257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109034"},
        {"Geneva Identification System", "GEN# +2.72090089"},
        {"New General Catalogue", "NGC 7209 89"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.32342033),
        dec: Angle.Degrees(+46.48350807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116027"},
        {"Hipparcos Number", "HIP 65060"},
        {"Smithsonian Astrophysical Observation", "SAO 44569"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.03700223),
        dec: Angle.Degrees(+46.48353279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187071"},
        {"Hipparcos Number", "HIP 97243"},
        {"Smithsonian Astrophysical Observation", "SAO 48811"},
        {"Wilson Evans Batten Catalogue", "WEB 17078"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.46492770),
        dec: Angle.Degrees(+46.48554315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1648"},
        {"Hipparcos Number", "HIP 1671"},
        {"Smithsonian Astrophysical Observation", "SAO 36285"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.22920564),
        dec: Angle.Degrees(+46.48601579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177079"},
        {"Hipparcos Number", "HIP 93359"},
        {"Smithsonian Astrophysical Observation", "SAO 48002"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.24077223),
        dec: Angle.Degrees(+46.48995728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61659"},
        {"Hipparcos Number", "HIP 37564"},
        {"Geneva Identification System", "GEN# +1.00061659"},
        {"Renson", "Renson 16920"},
        {"Smithsonian Astrophysical Observation", "SAO 41949"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.65103900),
        dec: Angle.Degrees(+46.49124713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114957"},
        {"Hipparcos Number", "HIP 64502"},
        {"Fundamental Katalog 5th Edition", "FK5 5166"},
        {"Geneva Identification System", "GEN# +1.00114957"},
        {"Smithsonian Astrophysical Observation", "SAO 44513"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.30943823),
        dec: Angle.Degrees(+46.49398407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94976"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.90656830),
        dec: Angle.Degrees(+46.49436381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27396"},
        {"Hipparcos Number", "HIP 20354"},
        {"Celescope Catalog", "CEL 388"},
        {"Fundamental Katalog 5th Edition", "FK5 2319"},
        {"Geneva Identification System", "GEN# +1.00027396"},
        {"Smithsonian Astrophysical Observation", "SAO 39483"},
        {"Wilson Evans Batten Catalogue", "WEB 3884"},
    },
    visualMagnitude: 4.80,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.38811942),
        dec: Angle.Degrees(+46.49896290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49633"},
        {"Hipparcos Number", "HIP 32949"},
        {"Geneva Identification System", "GEN# +1.00049633"},
        {"Smithsonian Astrophysical Observation", "SAO 41392"},
        {"Wilson Evans Batten Catalogue", "WEB 6633"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.94927645),
        dec: Angle.Degrees(+46.49994814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11270"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.28523797),
        dec: Angle.Degrees(+46.50000953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57329"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.32106488),
        dec: Angle.Degrees(+46.50015978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65860",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65860"},
        {"Geneva Identification System", "GEN# +0.04702064"},
    },
    visualMagnitude: 10.87,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.49886789),
        dec: Angle.Degrees(+46.50136620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17228"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.34736995),
        dec: Angle.Degrees(+46.50214140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155370"},
        {"Hipparcos Number", "HIP 83907"},
        {"Geneva Identification System", "GEN# +1.00155370"},
        {"Smithsonian Astrophysical Observation", "SAO 46518"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.22846158),
        dec: Angle.Degrees(+46.50541817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101715"},
        {"Hipparcos Number", "HIP 57114"},
        {"Smithsonian Astrophysical Observation", "SAO 43870"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.63172789),
        dec: Angle.Degrees(+46.50660432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214918"},
        {"Hipparcos Number", "HIP 111968"},
        {"Smithsonian Astrophysical Observation", "SAO 52256"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.20608918),
        dec: Angle.Degrees(+46.50811929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4695"},
        {"Hipparcos Number", "HIP 3854"},
        {"Smithsonian Astrophysical Observation", "SAO 36693"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.37956757),
        dec: Angle.Degrees(+46.51092235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25571"},
        {"Smithsonian Astrophysical Observation", "SAO 40351"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.98044106),
        dec: Angle.Degrees(+46.51145580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176022"},
        {"Hipparcos Number", "HIP 92921"},
        {"Smithsonian Astrophysical Observation", "SAO 47930"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.97728959),
        dec: Angle.Degrees(+46.51329980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104013"},
        {"Geneva Identification System", "GEN# +0.04503388J"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.08839076),
        dec: Angle.Degrees(+46.51818369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63949"},
        {"Geneva Identification System", "GEN# +0.04702018"},
        {"Smithsonian Astrophysical Observation", "SAO 44472"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.58903118),
        dec: Angle.Degrees(+46.51986061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120215"},
        {"Hipparcos Number", "HIP 67255"},
        {"Smithsonian Astrophysical Observation", "SAO 44748"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.77545218),
        dec: Angle.Degrees(+46.51986126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58520"},
        {"Hipparcos Number", "HIP 36281"},
        {"Geneva Identification System", "GEN# +1.00058520"},
        {"Smithsonian Astrophysical Observation", "SAO 41783"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.03605769),
        dec: Angle.Degrees(+46.52181254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109019"},
        {"New General Catalogue", "NGC 7209 77"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.29138145),
        dec: Angle.Degrees(+46.52368678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9068"},
        {"Fundamental Katalog 5th Edition", "FK5 4175"},
        {"Smithsonian Astrophysical Observation", "SAO 37627"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.18475550),
        dec: Angle.Degrees(+46.52391780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219397"},
        {"Hipparcos Number", "HIP 114781"},
        {"Smithsonian Astrophysical Observation", "SAO 52835"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.75510905),
        dec: Angle.Degrees(+46.52433356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51599",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7819 AB"},
        {"Henry Draper", "HD 91160"},
        {"Hipparcos Number", "HIP 51599"},
        {"Smithsonian Astrophysical Observation", "SAO 43373"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.10353733),
        dec: Angle.Degrees(+46.52620748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100571",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13801 A"},
        {"Henry Draper", "HD 194423"},
        {"Hipparcos Number", "HIP 100571"},
        {"Celescope Catalog", "CEL 5048"},
        {"Fundamental Katalog 5th Edition", "FK5 5799"},
        {"Geneva Identification System", "GEN# +1.00194423"},
        {"Smithsonian Astrophysical Observation", "SAO 49573"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.91401222),
        dec: Angle.Degrees(+46.52793633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26330"},
        {"Hipparcos Number", "HIP 19603"},
        {"Geneva Identification System", "GEN# +1.00026330"},
        {"Smithsonian Astrophysical Observation", "SAO 39373"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.00449425),
        dec: Angle.Degrees(+46.52846827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213483"},
        {"Hipparcos Number", "HIP 111128"},
        {"Smithsonian Astrophysical Observation", "SAO 52091"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.69350226),
        dec: Angle.Degrees(+46.52879473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200830"},
        {"Hipparcos Number", "HIP 104007"},
        {"Celescope Catalog", "CEL 5241"},
        {"Geneva Identification System", "GEN# +1.00200830"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.07589540),
        dec: Angle.Degrees(+46.53134029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198151"},
        {"Hipparcos Number", "HIP 102530"},
        {"Celescope Catalog", "CEL 5164"},
        {"Geneva Identification System", "GEN# +1.00198151J"},
        {"Smithsonian Astrophysical Observation", "SAO 50050"},
        {"Wilson Evans Batten Catalogue", "WEB 18574"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.66085551),
        dec: Angle.Degrees(+46.53172772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44692"},
        {"Hipparcos Number", "HIP 30559"},
        {"Smithsonian Astrophysical Observation", "SAO 41084"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.35906055),
        dec: Angle.Degrees(+46.53365678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40160"},
        {"Hipparcos Number", "HIP 28364"},
        {"Celescope Catalog", "CEL 1050"},
        {"Geneva Identification System", "GEN# +1.00040160"},
        {"Smithsonian Astrophysical Observation", "SAO 40748"},
        {"Wilson Evans Batten Catalogue", "WEB 5542"},
    },
    visualMagnitude: 7.48,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.88676129),
        dec: Angle.Degrees(+46.53477339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59555"},
        {"Hipparcos Number", "HIP 36672"},
        {"Geneva Identification System", "GEN# +1.00059555"},
        {"Smithsonian Astrophysical Observation", "SAO 41841"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.16654212),
        dec: Angle.Degrees(+46.53494246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8190"},
    },
    visualMagnitude: 11.42,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.32451293),
        dec: Angle.Degrees(+46.53498099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 395.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 214.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204933"},
        {"Hipparcos Number", "HIP 106187"},
        {"Smithsonian Astrophysical Observation", "SAO 50951"},
        {"Wilson Evans Batten Catalogue", "WEB 19242"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.62472164),
        dec: Angle.Degrees(+46.53582614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110351",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15862 A"},
        {"Henry Draper", "HD 212120"},
        {"Hipparcos Number", "HIP 110351"},
        {"Geneva Identification System", "GEN# +1.00212120A"},
        {"Smithsonian Astrophysical Observation", "SAO 51904"},
        {"Wilson Evans Batten Catalogue", "WEB 19791"},
    },
    visualMagnitude: 4.55,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.25636792),
        dec: Angle.Degrees(+46.53656484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50718"},
        {"Hipparcos Number", "HIP 33389"},
        {"Smithsonian Astrophysical Observation", "SAO 41447"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.15269507),
        dec: Angle.Degrees(+46.53861527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152951"},
        {"Hipparcos Number", "HIP 82702"},
        {"Smithsonian Astrophysical Observation", "SAO 46362"},
        {"Wilson Evans Batten Catalogue", "WEB 13975"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.57825825),
        dec: Angle.Degrees(+46.53908623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204771"},
        {"Hipparcos Number", "HIP 106093"},
        {"Fundamental Katalog 5th Edition", "FK5 807"},
        {"Geneva Identification System", "GEN# +1.00204771"},
        {"Smithsonian Astrophysical Observation", "SAO 50934"},
        {"Wilson Evans Batten Catalogue", "WEB 19229"},
    },
    visualMagnitude: 5.22,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.36213795),
        dec: Angle.Degrees(+46.54033179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71740",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9341 AB"},
        {"Henry Draper", "HD 129335"},
        {"Hipparcos Number", "HIP 71740"},
        {"Smithsonian Astrophysical Observation", "SAO 45165"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.12667119),
        dec: Angle.Degrees(+46.54254622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193513"},
        {"Hipparcos Number", "HIP 100131"},
        {"Smithsonian Astrophysical Observation", "SAO 49458"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.68703248),
        dec: Angle.Degrees(+46.54357250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113940"},
        {"Smithsonian Astrophysical Observation", "SAO 52653"},
    },
    visualMagnitude: 9.43,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.10533022),
        dec: Angle.Degrees(+46.54521304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103409"},
        {"Geneva Identification System", "GEN# +0.04503341"},
        {"Smithsonian Astrophysical Observation", "SAO 50277"},
        {"Wilson Evans Batten Catalogue", "WEB 18803"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.26117464),
        dec: Angle.Degrees(+46.54575679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1650",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1650"},
        {"Smithsonian Astrophysical Observation", "SAO 36281"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.17308397),
        dec: Angle.Degrees(+46.54602813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97193"},
        {"Hipparcos Number", "HIP 54689"},
        {"Geneva Identification System", "GEN# +1.00097193"},
        {"Smithsonian Astrophysical Observation", "SAO 43640"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.93788058),
        dec: Angle.Degrees(+46.54710595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91840"},
        {"Hipparcos Number", "HIP 51973"},
        {"Geneva Identification System", "GEN# +1.00091840"},
        {"Smithsonian Astrophysical Observation", "SAO 43410"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.29445662),
        dec: Angle.Degrees(+46.54814376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216511"},
        {"Hipparcos Number", "HIP 112981"},
        {"Smithsonian Astrophysical Observation", "SAO 52450"},
        {"Wilson Evans Batten Catalogue", "WEB 20116"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.20562255),
        dec: Angle.Degrees(+46.54843006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14982"},
        {"Hipparcos Number", "HIP 11358"},
        {"Smithsonian Astrophysical Observation", "SAO 38022"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.56430887),
        dec: Angle.Degrees(+46.54892043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108011"},
        {"Smithsonian Astrophysical Observation", "SAO 51400"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.24269086),
        dec: Angle.Degrees(+46.55158422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149576"},
        {"Hipparcos Number", "HIP 81072"},
        {"Geneva Identification System", "GEN# +1.00149576"},
        {"Smithsonian Astrophysical Observation", "SAO 46157"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.38440453),
        dec: Angle.Degrees(+46.55327893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123032"},
        {"Hipparcos Number", "HIP 68724"},
        {"Smithsonian Astrophysical Observation", "SAO 44870"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.02302356),
        dec: Angle.Degrees(+46.55433828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2370"},
        {"Hipparcos Number", "HIP 2198"},
        {"Smithsonian Astrophysical Observation", "SAO 36385"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.95077832),
        dec: Angle.Degrees(+46.55500714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155656"},
        {"Hipparcos Number", "HIP 84031"},
        {"Smithsonian Astrophysical Observation", "SAO 46542"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.66796212),
        dec: Angle.Degrees(+46.55623573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63279"},
        {"Hipparcos Number", "HIP 38254"},
        {"Smithsonian Astrophysical Observation", "SAO 42024"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.54557283),
        dec: Angle.Degrees(+46.55736818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103187"},
        {"Hipparcos Number", "HIP 57944"},
        {"Geneva Identification System", "GEN# +1.00103187"},
        {"Smithsonian Astrophysical Observation", "SAO 43933"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.24692356),
        dec: Angle.Degrees(+46.55857262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66315"},
        {"Cincinnati Publication", "Ci 20 790"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.86984415),
        dec: Angle.Degrees(+46.55994457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 465.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -558.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204536"},
        {"Hipparcos Number", "HIP 105986"},
        {"Celescope Catalog", "CEL 5318"},
        {"Geneva Identification System", "GEN# +1.00204536"},
        {"Smithsonian Astrophysical Observation", "SAO 50890"},
        {"Wilson Evans Batten Catalogue", "WEB 19214"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.97634764),
        dec: Angle.Degrees(+46.56151625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95379"},
        {"Hipparcos Number", "HIP 53876"},
        {"Smithsonian Astrophysical Observation", "SAO 43572"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.33646096),
        dec: Angle.Degrees(+46.56361976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213871"},
        {"Hipparcos Number", "HIP 111360"},
        {"Renson", "Renson 59320"},
        {"Smithsonian Astrophysical Observation", "SAO 52143"},
        {"Wilson Evans Batten Catalogue", "WEB 19917"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.40656144),
        dec: Angle.Degrees(+46.56528160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48506"},
        {"Smithsonian Astrophysical Observation", "SAO 43088"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.38142550),
        dec: Angle.Degrees(+46.56560272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103795"},
        {"Hipparcos Number", "HIP 58286"},
        {"Smithsonian Astrophysical Observation", "SAO 43962"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.30909802),
        dec: Angle.Degrees(+46.56868204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15364"},
        {"Smithsonian Astrophysical Observation", "SAO 38706"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.52179982),
        dec: Angle.Degrees(+46.56879002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20497"},
        {"Hipparcos Number", "HIP 15491"},
        {"Smithsonian Astrophysical Observation", "SAO 38721"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.90896209),
        dec: Angle.Degrees(+46.57213344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24559"},
        {"Hipparcos Number", "HIP 18423"},
        {"Smithsonian Astrophysical Observation", "SAO 39201"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.08408180),
        dec: Angle.Degrees(+46.57247588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109851",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109851"},
    },
    visualMagnitude: 9.80,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.72951915),
        dec: Angle.Degrees(+46.57335439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46015"},
        {"Hipparcos Number", "HIP 31245"},
        {"Smithsonian Astrophysical Observation", "SAO 41170"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.30217880),
        dec: Angle.Degrees(+46.57416789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130987"},
        {"Hipparcos Number", "HIP 72513"},
        {"Fundamental Katalog 5th Edition", "FK5 5316"},
        {"Geneva Identification System", "GEN# +1.00130987"},
        {"Smithsonian Astrophysical Observation", "SAO 45228"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.39616836),
        dec: Angle.Degrees(+46.57488653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15811"},
        {"Wilson Evans Batten Catalogue", "WEB 3021"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.91828359),
        dec: Angle.Degrees(+46.57656503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48035",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48035"},
        {"Smithsonian Astrophysical Observation", "SAO 43038"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.88203835),
        dec: Angle.Degrees(+46.57670904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103700",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14561 AB"},
        {"Henry Draper", "HD 200269"},
        {"Hipparcos Number", "HIP 103700"},
        {"Celescope Catalog", "CEL 5230"},
        {"Geneva Identification System", "GEN# +1.00200269"},
        {"Smithsonian Astrophysical Observation", "SAO 50353"},
        {"Wilson Evans Batten Catalogue", "WEB 18875"},
    },
    visualMagnitude: 7.24,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.20772934),
        dec: Angle.Degrees(+46.57858662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28531",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28531"},
        {"Smithsonian Astrophysical Observation", "SAO 40784"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.33333201),
        dec: Angle.Degrees(+46.58032294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141156"},
        {"Hipparcos Number", "HIP 77193"},
        {"Smithsonian Astrophysical Observation", "SAO 45713"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.42995028),
        dec: Angle.Degrees(+46.58066547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15145"},
        {"Wilson Evans Batten Catalogue", "WEB 2917"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.81019595),
        dec: Angle.Degrees(+46.58106350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209638"},
        {"Hipparcos Number", "HIP 108916"},
        {"Smithsonian Astrophysical Observation", "SAO 51605"},
        {"New General Catalogue", "NGC 7209 13"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.93987491),
        dec: Angle.Degrees(+46.58321848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22156"},
        {"Hipparcos Number", "HIP 16790"},
        {"Geneva Identification System", "GEN# +1.00022156"},
        {"Smithsonian Astrophysical Observation", "SAO 38975"},
        {"Wilson Evans Batten Catalogue", "WEB 3195"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.01905156),
        dec: Angle.Degrees(+46.58446479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40978"},
        {"Hipparcos Number", "HIP 28783"},
        {"Celescope Catalog", "CEL 1067"},
        {"Geneva Identification System", "GEN# +1.00040978"},
        {"Smithsonian Astrophysical Observation", "SAO 40834"},
        {"Wilson Evans Batten Catalogue", "WEB 5629"},
    },
    visualMagnitude: 7.30,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.16004463),
        dec: Angle.Degrees(+46.58511912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15579"},
        {"Hipparcos Number", "HIP 11770"},
        {"Geneva Identification System", "GEN# +1.00015579"},
        {"Smithsonian Astrophysical Observation", "SAO 38089"},
        {"Wilson Evans Batten Catalogue", "WEB 2442"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.97527292),
        dec: Angle.Degrees(+46.58554655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87938",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87938"},
        {"Geneva Identification System", "GEN# +9.80204039"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.46241105),
        dec: Angle.Degrees(+46.58724154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 575.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60258"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.33835850),
        dec: Angle.Degrees(+46.59002505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98734"},
        {"Hipparcos Number", "HIP 55512"},
        {"Geneva Identification System", "GEN# +1.00098734"},
        {"Smithsonian Astrophysical Observation", "SAO 43716"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.54170564),
        dec: Angle.Degrees(+46.59160860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123253"},
        {"Hipparcos Number", "HIP 68811"},
        {"Geneva Identification System", "GEN# +1.00123253"},
        {"Smithsonian Astrophysical Observation", "SAO 44877"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.31591415),
        dec: Angle.Degrees(+46.59165749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208728"},
        {"Hipparcos Number", "HIP 108353"},
        {"Geneva Identification System", "GEN# +1.00208728"},
        {"Smithsonian Astrophysical Observation", "SAO 51476"},
        {"Wilson Evans Batten Catalogue", "WEB 19517"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.27042800),
        dec: Angle.Degrees(+46.59243927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131883"},
        {"Hipparcos Number", "HIP 72952"},
        {"Smithsonian Astrophysical Observation", "SAO 45270"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.64000294),
        dec: Angle.Degrees(+46.59381756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5091"},
        {"Hipparcos Number", "HIP 4178"},
        {"Smithsonian Astrophysical Observation", "SAO 36746"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.33748069),
        dec: Angle.Degrees(+46.59533702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122132"},
        {"Hipparcos Number", "HIP 68290"},
        {"Geneva Identification System", "GEN# +1.00122132"},
        {"Smithsonian Astrophysical Observation", "SAO 44824"},
        {"Wilson Evans Batten Catalogue", "WEB 11982"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.69045478),
        dec: Angle.Degrees(+46.59625157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100576"},
        {"Hipparcos Number", "HIP 56481"},
        {"Smithsonian Astrophysical Observation", "SAO 43811"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.69441889),
        dec: Angle.Degrees(+46.59665672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106056"},
        {"Hipparcos Number", "HIP 59493"},
        {"Geneva Identification System", "GEN# +1.00106056"},
        {"Smithsonian Astrophysical Observation", "SAO 44075"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.01157640),
        dec: Angle.Degrees(+46.60081922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108105"},
        {"Smithsonian Astrophysical Observation", "SAO 51416"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.54843498),
        dec: Angle.Degrees(+46.60101118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196018"},
        {"Hipparcos Number", "HIP 101393"},
        {"Geneva Identification System", "GEN# +1.00196018"},
        {"Wilson Evans Batten Catalogue", "WEB 18321"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.22623220),
        dec: Angle.Degrees(+46.60128664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199891"},
        {"Hipparcos Number", "HIP 103523"},
        {"Geneva Identification System", "GEN# +1.00199891"},
        {"Smithsonian Astrophysical Observation", "SAO 50304"},
        {"Wilson Evans Batten Catalogue", "WEB 18833"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.60397897),
        dec: Angle.Degrees(+46.60397444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47310"},
        {"Hipparcos Number", "HIP 31926"},
        {"Smithsonian Astrophysical Observation", "SAO 41252"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.08087576),
        dec: Angle.Degrees(+46.60630244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126894"},
        {"Hipparcos Number", "HIP 70633"},
        {"Smithsonian Astrophysical Observation", "SAO 45053"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.72426732),
        dec: Angle.Degrees(+46.61327586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150030"},
        {"Hipparcos Number", "HIP 81289"},
        {"Fundamental Katalog 5th Edition", "FK5 3314"},
        {"Geneva Identification System", "GEN# +1.00150030"},
        {"Smithsonian Astrophysical Observation", "SAO 46184"},
        {"Wilson Evans Batten Catalogue", "WEB 13736"},
    },
    visualMagnitude: 5.83,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.04671628),
        dec: Angle.Degrees(+46.61332505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1241"},
        {"Hipparcos Number", "HIP 1346"},
        {"Geneva Identification System", "GEN# +1.00001241"},
        {"Smithsonian Astrophysical Observation", "SAO 36233"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.21562979),
        dec: Angle.Degrees(+46.61432799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61337"},
        {"Hipparcos Number", "HIP 37423"},
        {"Smithsonian Astrophysical Observation", "SAO 41928"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.23631155),
        dec: Angle.Degrees(+46.61592570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45116"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.87963821),
        dec: Angle.Degrees(+46.61716909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -352.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224341"},
        {"Hipparcos Number", "HIP 118060"},
        {"Smithsonian Astrophysical Observation", "SAO 53508"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.24564798),
        dec: Angle.Degrees(+46.61771462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23426"},
        {"Hipparcos Number", "HIP 17665"},
        {"Smithsonian Astrophysical Observation", "SAO 39097"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.74888559),
        dec: Angle.Degrees(+46.61779199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215399"},
        {"Hipparcos Number", "HIP 112252"},
        {"Geneva Identification System", "GEN# +1.00215399"},
        {"Smithsonian Astrophysical Observation", "SAO 52318"},
        {"Wilson Evans Batten Catalogue", "WEB 20032"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.04011723),
        dec: Angle.Degrees(+46.61859721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186925"},
        {"Hipparcos Number", "HIP 97178"},
        {"Geneva Identification System", "GEN# +1.00186925"},
        {"Smithsonian Astrophysical Observation", "SAO 48799"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.27117705),
        dec: Angle.Degrees(+46.61939558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39074",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6491 AB"},
        {"Henry Draper", "HD 65219"},
        {"Hipparcos Number", "HIP 39074"},
        {"Smithsonian Astrophysical Observation", "SAO 42109"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.91997036),
        dec: Angle.Degrees(+46.62015023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84829"},
        {"Hipparcos Number", "HIP 48183"},
        {"Smithsonian Astrophysical Observation", "SAO 43055"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.31782885),
        dec: Angle.Degrees(+46.62182050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59953"},
        {"Wilson Evans Batten Catalogue", "WEB 10655"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.45314070),
        dec: Angle.Degrees(+46.62270423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -423.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62374"},
    },
    visualMagnitude: 11.71,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.75683366),
        dec: Angle.Degrees(+46.62666333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -761.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7017"},
        {"Hipparcos Number", "HIP 5554"},
        {"Smithsonian Astrophysical Observation", "SAO 37000"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.81216261),
        dec: Angle.Degrees(+46.62984555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174019"},
        {"Hipparcos Number", "HIP 92095"},
        {"Smithsonian Astrophysical Observation", "SAO 47784"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.54302286),
        dec: Angle.Degrees(+46.63079280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213190"},
        {"Hipparcos Number", "HIP 110953"},
        {"Smithsonian Astrophysical Observation", "SAO 52044"},
    },
    visualMagnitude: 9.10,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.19869078),
        dec: Angle.Degrees(+46.63085588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174852"},
        {"Hipparcos Number", "HIP 92440"},
        {"Smithsonian Astrophysical Observation", "SAO 47843"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.58064386),
        dec: Angle.Degrees(+46.63574310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79526",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9975 AB"},
        {"Henry Draper", "HD 146327"},
        {"Hipparcos Number", "HIP 79526"},
        {"Smithsonian Astrophysical Observation", "SAO 45976"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.43209855),
        dec: Angle.Degrees(+46.63963476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110898"},
        {"Smithsonian Astrophysical Observation", "SAO 52029"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.02843182),
        dec: Angle.Degrees(+46.64107074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30597"},
        {"Hipparcos Number", "HIP 22560"},
        {"Smithsonian Astrophysical Observation", "SAO 39804"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.82110805),
        dec: Angle.Degrees(+46.64205817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160116"},
        {"Hipparcos Number", "HIP 86100"},
        {"Smithsonian Astrophysical Observation", "SAO 46825"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.94541412),
        dec: Angle.Degrees(+46.64228357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163075"},
        {"Hipparcos Number", "HIP 87434"},
        {"Geneva Identification System", "GEN# +1.00163075"},
        {"Smithsonian Astrophysical Observation", "SAO 47023"},
        {"Wilson Evans Batten Catalogue", "WEB 14749"},
    },
    visualMagnitude: 6.37,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.00368246),
        dec: Angle.Degrees(+46.64385563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43405",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43405"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.62225743),
        dec: Angle.Degrees(+46.64587478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43724"},
        {"Hipparcos Number", "HIP 30108"},
        {"Geneva Identification System", "GEN# +1.00043724"},
        {"Smithsonian Astrophysical Observation", "SAO 41027"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.03970662),
        dec: Angle.Degrees(+46.64687839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152238"},
        {"Hipparcos Number", "HIP 82375"},
        {"Smithsonian Astrophysical Observation", "SAO 46315"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.49758200),
        dec: Angle.Degrees(+46.64898528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92539"},
        {"Hipparcos Number", "HIP 52355"},
        {"Geneva Identification System", "GEN# +1.00092539J"},
        {"Smithsonian Astrophysical Observation", "SAO 43433"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.49717485),
        dec: Angle.Degrees(+46.64993048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102931"},
        {"Geneva Identification System", "GEN# +0.04603075"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.80686039),
        dec: Angle.Degrees(+46.65158085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79302"},
        {"Hipparcos Number", "HIP 45382"},
        {"Smithsonian Astrophysical Observation", "SAO 42765"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.72371183),
        dec: Angle.Degrees(+46.65254884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5373"},
        {"Hipparcos Number", "HIP 4386"},
        {"Geneva Identification System", "GEN# +1.00005373"},
        {"Smithsonian Astrophysical Observation", "SAO 36781"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.05486404),
        dec: Angle.Degrees(+46.65412496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112082"},
        {"Hipparcos Number", "HIP 62891"},
        {"Geneva Identification System", "GEN# +1.00112082"},
        {"Smithsonian Astrophysical Observation", "SAO 44376"},
        {"Wilson Evans Batten Catalogue", "WEB 11150"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.33341088),
        dec: Angle.Degrees(+46.65637682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72189",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72189"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.48692764),
        dec: Angle.Degrees(+46.65691453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99967"},
        {"Hipparcos Number", "HIP 56135"},
        {"Geneva Identification System", "GEN# +1.00099967"},
        {"Smithsonian Astrophysical Observation", "SAO 43784"},
        {"Wilson Evans Batten Catalogue", "WEB 10077"},
    },
    visualMagnitude: 6.30,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.60345695),
        dec: Angle.Degrees(+46.65746586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17127"},
        {"Hipparcos Number", "HIP 12938"},
        {"Smithsonian Astrophysical Observation", "SAO 38318"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.59590127),
        dec: Angle.Degrees(+46.65810509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7265"},
        {"Hipparcos Number", "HIP 5728"},
        {"Geneva Identification System", "GEN# +1.00007265"},
        {"Smithsonian Astrophysical Observation", "SAO 37036"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.41664708),
        dec: Angle.Degrees(+46.65811916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60254",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60254"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.32932334),
        dec: Angle.Degrees(+46.65835775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32050"},
        {"Hipparcos Number", "HIP 23477"},
        {"Smithsonian Astrophysical Observation", "SAO 39967"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.69432901),
        dec: Angle.Degrees(+46.66028766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18295"},
        {"Hipparcos Number", "HIP 13821"},
        {"Geneva Identification System", "GEN# +1.00018295"},
        {"Smithsonian Astrophysical Observation", "SAO 38472"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.47547384),
        dec: Angle.Degrees(+46.66126688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102827",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14350 A"},
        {"Henry Draper", "HD 198625"},
        {"Hipparcos Number", "HIP 102827"},
        {"Celescope Catalog", "CEL 5180"},
        {"Geneva Identification System", "GEN# +1.00198625"},
        {"Smithsonian Astrophysical Observation", "SAO 50119"},
        {"Wilson Evans Batten Catalogue", "WEB 18650"},
    },
    visualMagnitude: 6.33,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.47767395),
        dec: Angle.Degrees(+46.66132783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13834"},
        {"Hipparcos Number", "HIP 10581"},
        {"Geneva Identification System", "GEN# +1.00013834"},
        {"Smithsonian Astrophysical Observation", "SAO 37910"},
        {"Wilson Evans Batten Catalogue", "WEB 2226"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.04845547),
        dec: Angle.Degrees(+46.66174539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76045"},
    },
    visualMagnitude: 10.40,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.95368107),
        dec: Angle.Degrees(+46.66225899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 379.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79951"},
        {"Smithsonian Astrophysical Observation", "SAO 46023"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.79451237),
        dec: Angle.Degrees(+46.66471645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101790"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.43799784),
        dec: Angle.Degrees(+46.66495904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188854"},
        {"Hipparcos Number", "HIP 98028"},
        {"Geneva Identification System", "GEN# +1.00188854"},
        {"Renson", "Renson 52220"},
        {"Smithsonian Astrophysical Observation", "SAO 48979"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.80019209),
        dec: Angle.Degrees(+46.66566527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189915"},
        {"Hipparcos Number", "HIP 98486"},
        {"Smithsonian Astrophysical Observation", "SAO 49074"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.11680175),
        dec: Angle.Degrees(+46.66570182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92941"},
        {"Smithsonian Astrophysical Observation", "SAO 47935"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.03861967),
        dec: Angle.Degrees(+46.66571664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101066",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101066"},
        {"Geneva Identification System", "GEN# +0.04602948"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.33409681),
        dec: Angle.Degrees(+46.66640813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52952"},
        {"Hipparcos Number", "HIP 34206"},
        {"Smithsonian Astrophysical Observation", "SAO 41542"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.39410425),
        dec: Angle.Degrees(+46.66830678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190944"},
        {"Hipparcos Number", "HIP 98950"},
        {"Celescope Catalog", "CEL 4927"},
        {"Geneva Identification System", "GEN# +1.00190944"},
        {"Smithsonian Astrophysical Observation", "SAO 49171"},
        {"Wilson Evans Batten Catalogue", "WEB 17567"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.35693833),
        dec: Angle.Degrees(+46.67182679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77946"},
        {"Hipparcos Number", "HIP 44746"},
        {"Smithsonian Astrophysical Observation", "SAO 42697"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.77831659),
        dec: Angle.Degrees(+46.67269815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2807"},
    },
    visualMagnitude: 10.78,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.92927105),
        dec: Angle.Degrees(+46.67334670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97354"},
        {"Hipparcos Number", "HIP 54768"},
        {"Geneva Identification System", "GEN# +1.00097354"},
        {"Smithsonian Astrophysical Observation", "SAO 43644"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.19144162),
        dec: Angle.Degrees(+46.67459366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75001"},
    },
    visualMagnitude: 11.27,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.87811492),
        dec: Angle.Degrees(+46.67603811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139214"},
        {"Hipparcos Number", "HIP 76290"},
        {"Geneva Identification System", "GEN# +1.00139214"},
        {"Smithsonian Astrophysical Observation", "SAO 45624"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.76506288),
        dec: Angle.Degrees(+46.67611251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221672"},
        {"Hipparcos Number", "HIP 116297"},
        {"Smithsonian Astrophysical Observation", "SAO 53149"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.45507826),
        dec: Angle.Degrees(+46.68109832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109781"},
        {"Hipparcos Number", "HIP 61574"},
        {"Geneva Identification System", "GEN# +1.00109781"},
        {"Smithsonian Astrophysical Observation", "SAO 44252"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.26111541),
        dec: Angle.Degrees(+46.68204649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87226"},
        {"Renson", "Renson 45870"},
        {"Smithsonian Astrophysical Observation", "SAO 46985"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.33194156),
        dec: Angle.Degrees(+46.68334495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17818",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2774 AB"},
        {"Henry Draper", "HD 23652"},
        {"Hipparcos Number", "HIP 17818"},
        {"Smithsonian Astrophysical Observation", "SAO 39119"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.19009055),
        dec: Angle.Degrees(+46.68404326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45466"},
        {"Hipparcos Number", "HIP 30972"},
        {"Fundamental Katalog 5th Edition", "FK5 2496"},
        {"Geneva Identification System", "GEN# +1.00045466"},
        {"Smithsonian Astrophysical Observation", "SAO 41130"},
        {"Wilson Evans Batten Catalogue", "WEB 6167"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.51241701),
        dec: Angle.Degrees(+46.68553561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13679"},
        {"Hipparcos Number", "HIP 10456"},
        {"Geneva Identification System", "GEN# +1.00013679"},
        {"Smithsonian Astrophysical Observation", "SAO 37889"},
    },
    visualMagnitude: 6.90,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.69308471),
        dec: Angle.Degrees(+46.68754101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17278"},
    },
    visualMagnitude: 11.86,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.50175295),
        dec: Angle.Degrees(+46.68876903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25930"},
        {"Hipparcos Number", "HIP 19323"},
        {"Smithsonian Astrophysical Observation", "SAO 39335"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.12413831),
        dec: Angle.Degrees(+46.69066973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43205",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43205"},
        {"Smithsonian Astrophysical Observation", "SAO 42551"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.02611937),
        dec: Angle.Degrees(+46.69185919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15853"},
        {"Hipparcos Number", "HIP 11974"},
        {"Smithsonian Astrophysical Observation", "SAO 38130"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.61630163),
        dec: Angle.Degrees(+46.69343312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196178"},
        {"Hipparcos Number", "HIP 101475"},
        {"Celescope Catalog", "CEL 5117"},
        {"Geneva Identification System", "GEN# +1.00196178A"},
        {"Renson", "Renson 54690"},
        {"Smithsonian Astrophysical Observation", "SAO 49804"},
        {"Wilson Evans Batten Catalogue", "WEB 18337"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.47848189),
        dec: Angle.Degrees(+46.69386159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26897"},
        {"Hipparcos Number", "HIP 19992"},
        {"Smithsonian Astrophysical Observation", "SAO 39435"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.32035909),
        dec: Angle.Degrees(+46.69671043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115993"},
        {"Hipparcos Number", "HIP 65048"},
        {"Smithsonian Astrophysical Observation", "SAO 44568"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.00268031),
        dec: Angle.Degrees(+46.69710763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103691"},
        {"Hipparcos Number", "HIP 58223"},
        {"Geneva Identification System", "GEN# +1.00103691"},
        {"Smithsonian Astrophysical Observation", "SAO 43952"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.12396019),
        dec: Angle.Degrees(+46.69731724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216878"},
        {"Hipparcos Number", "HIP 113254"},
        {"Geneva Identification System", "GEN# +1.00216878"},
        {"Smithsonian Astrophysical Observation", "SAO 52506"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.00937846),
        dec: Angle.Degrees(+46.69755805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28645"},
        {"Hipparcos Number", "HIP 21227"},
        {"Smithsonian Astrophysical Observation", "SAO 39597"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.30848141),
        dec: Angle.Degrees(+46.69862093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10712"},
        {"Hipparcos Number", "HIP 8213"},
        {"Geneva Identification System", "GEN# +1.00010712"},
        {"Smithsonian Astrophysical Observation", "SAO 37486"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.43950664),
        dec: Angle.Degrees(+46.70116815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147663"},
        {"Hipparcos Number", "HIP 80106"},
        {"Smithsonian Astrophysical Observation", "SAO 46045"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.28075483),
        dec: Angle.Degrees(+46.70209703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42170"},
        {"Smithsonian Astrophysical Observation", "SAO 42439"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.95971809),
        dec: Angle.Degrees(+46.70313682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211150"},
        {"Hipparcos Number", "HIP 109778"},
        {"Smithsonian Astrophysical Observation", "SAO 51786"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.53745720),
        dec: Angle.Degrees(+46.70341611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53298"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.51813129),
        dec: Angle.Degrees(+46.70402718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50763"},
        {"Hipparcos Number", "HIP 33415"},
        {"Geneva Identification System", "GEN# +1.00050763"},
        {"Smithsonian Astrophysical Observation", "SAO 41450"},
        {"Wilson Evans Batten Catalogue", "WEB 6714"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.23387146),
        dec: Angle.Degrees(+46.70553754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39905"},
        {"Hipparcos Number", "HIP 28233"},
        {"Geneva Identification System", "GEN# +1.00039905"},
        {"Smithsonian Astrophysical Observation", "SAO 40729"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.47968919),
        dec: Angle.Degrees(+46.70683615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204341"},
        {"Hipparcos Number", "HIP 105868"},
        {"Smithsonian Astrophysical Observation", "SAO 50852"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.62136943),
        dec: Angle.Degrees(+46.71012033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59633",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8467 AB"},
        {"Hipparcos Number", "HIP 59633"},
        {"Smithsonian Astrophysical Observation", "SAO 44083"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.44756157),
        dec: Angle.Degrees(+46.71073691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51124"},
        {"Smithsonian Astrophysical Observation", "SAO 43338"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.66811056),
        dec: Angle.Degrees(+46.71075245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13554 C"},
        {"Henry Draper", "HD 192579"},
        {"Hipparcos Number", "HIP 99676"},
        {"Celescope Catalog", "CEL 4981"},
        {"Geneva Identification System", "GEN# +1.00192579"},
        {"Smithsonian Astrophysical Observation", "SAO 49338"},
        {"Wilson Evans Batten Catalogue", "WEB 17876"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.41331844),
        dec: Angle.Degrees(+46.71185552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204153"},
        {"Hipparcos Number", "HIP 105769"},
        {"Celescope Catalog", "CEL 5310"},
        {"Geneva Identification System", "GEN# +1.00204153"},
        {"Smithsonian Astrophysical Observation", "SAO 50824"},
        {"Wilson Evans Batten Catalogue", "WEB 19195"},
    },
    visualMagnitude: 5.59,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.33078455),
        dec: Angle.Degrees(+46.71422433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90416"},
        {"Hipparcos Number", "HIP 51182"},
        {"Geneva Identification System", "GEN# +1.00090416"},
        {"Smithsonian Astrophysical Observation", "SAO 43341"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.80972649),
        dec: Angle.Degrees(+46.71476622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140414"},
        {"Hipparcos Number", "HIP 76853"},
        {"Geneva Identification System", "GEN# +1.00140414"},
        {"Smithsonian Astrophysical Observation", "SAO 45682"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.38990464),
        dec: Angle.Degrees(+46.71827455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63669"},
        {"Smithsonian Astrophysical Observation", "SAO 44441"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.73662844),
        dec: Angle.Degrees(+46.71870164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16505 AB"},
        {"Henry Draper", "HD 218196"},
        {"Hipparcos Number", "HIP 114027"},
        {"Smithsonian Astrophysical Observation", "SAO 52669"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.37562365),
        dec: Angle.Degrees(+46.72072807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156630"},
        {"Hipparcos Number", "HIP 84492"},
        {"Geneva Identification System", "GEN# +1.00156630"},
        {"Smithsonian Astrophysical Observation", "SAO 46598"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.10180245),
        dec: Angle.Degrees(+46.72082755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38449"},
        {"Hipparcos Number", "HIP 27409"},
        {"Smithsonian Astrophysical Observation", "SAO 40612"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.06052998),
        dec: Angle.Degrees(+46.72179172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109986",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15801 AB"},
        {"Hipparcos Number", "HIP 109986"},
        {"Smithsonian Astrophysical Observation", "SAO 51828"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.14221431),
        dec: Angle.Degrees(+46.72836436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118212",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118212"},
        {"Cincinnati Publication", "Ci 18 3143"},
        {"Cincinnati Publication 2", "Ci 20 1466"},
        {"Geneva Identification System", "GEN# +0.04504378"},
        {"Smithsonian Astrophysical Observation", "SAO 53537"},
        {"Wilson Evans Batten Catalogue", "WEB 20778"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.67892108),
        dec: Angle.Degrees(+46.72917338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 668.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203535"},
        {"Hipparcos Number", "HIP 105430"},
        {"Smithsonian Astrophysical Observation", "SAO 50751"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.33515193),
        dec: Angle.Degrees(+46.72979943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144248"},
        {"Hipparcos Number", "HIP 78598"},
        {"Geneva Identification System", "GEN# +1.00144248"},
        {"Smithsonian Astrophysical Observation", "SAO 45868"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.71307793),
        dec: Angle.Degrees(+46.73077509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198915"},
        {"Hipparcos Number", "HIP 102987"},
        {"Celescope Catalog", "CEL 5190"},
        {"Geneva Identification System", "GEN# +1.00198915"},
        {"Smithsonian Astrophysical Observation", "SAO 50150"},
        {"Wilson Evans Batten Catalogue", "WEB 18693"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.98894648),
        dec: Angle.Degrees(+46.73477837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216396"},
        {"Hipparcos Number", "HIP 112907"},
        {"Smithsonian Astrophysical Observation", "SAO 52435"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.96184783),
        dec: Angle.Degrees(+46.73554351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167260"},
        {"Hipparcos Number", "HIP 89186"},
        {"Geneva Identification System", "GEN# +1.00167260"},
        {"Smithsonian Astrophysical Observation", "SAO 47298"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.02149899),
        dec: Angle.Degrees(+46.73664612)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175034"},
        {"Hipparcos Number", "HIP 92513"},
        {"Smithsonian Astrophysical Observation", "SAO 47860"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.79997015),
        dec: Angle.Degrees(+46.73819693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99194"},
        {"Hipparcos Number", "HIP 55748"},
        {"Geneva Identification System", "GEN# +1.00099194"},
        {"Smithsonian Astrophysical Observation", "SAO 43735"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.33506527),
        dec: Angle.Degrees(+46.74100256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99675",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13554 AP"},
        {"Henry Draper", "HD 192577"},
        {"Henry Draper 2", "HD 192578"},
        {"Hipparcos Number", "HIP 99675"},
        {"Fundamental Katalog 5th Edition", "FK5 757"},
        {"Smithsonian Astrophysical Observation", "SAO 49337"},
        {"Wilson Evans Batten Catalogue", "WEB 17871"},
    },
    visualMagnitude: 3.80,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.40792782),
        dec: Angle.Degrees(+46.74132417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190698"},
        {"Hipparcos Number", "HIP 98827"},
        {"Smithsonian Astrophysical Observation", "SAO 49144"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.04126281),
        dec: Angle.Degrees(+46.74180982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188967"},
        {"Hipparcos Number", "HIP 98064"},
        {"Smithsonian Astrophysical Observation", "SAO 48992"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.95650283),
        dec: Angle.Degrees(+46.74434045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209857"},
        {"Hipparcos Number", "HIP 109033"},
        {"Geneva Identification System", "GEN# +2.72090086"},
        {"Smithsonian Astrophysical Observation", "SAO 51632"},
        {"Wilson Evans Batten Catalogue", "WEB 19606"},
        {"New General Catalogue", "NGC 7209 86"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.31885169),
        dec: Angle.Degrees(+46.74488477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128509"},
        {"Hipparcos Number", "HIP 71381"},
        {"Smithsonian Astrophysical Observation", "SAO 45126"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.95690752),
        dec: Angle.Degrees(+46.74634808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109400"},
        {"Hipparcos Number", "HIP 61334"},
        {"Geneva Identification System", "GEN# +1.00109400"},
        {"Smithsonian Astrophysical Observation", "SAO 44233"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.51439530),
        dec: Angle.Degrees(+46.74776452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71705"},
        {"Hipparcos Number", "HIP 41739"},
        {"Geneva Identification System", "GEN# +1.00071705"},
        {"Smithsonian Astrophysical Observation", "SAO 42400"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.67366578),
        dec: Angle.Degrees(+46.74953681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57671"},
        {"Geneva Identification System", "GEN# +0.04701906"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.42892371),
        dec: Angle.Degrees(+46.75090843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76507"},
        {"Hipparcos Number", "HIP 44053"},
        {"Smithsonian Astrophysical Observation", "SAO 42623"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.57567039),
        dec: Angle.Degrees(+46.75175747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219842"},
        {"Hipparcos Number", "HIP 115083"},
        {"Smithsonian Astrophysical Observation", "SAO 52884"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.63860925),
        dec: Angle.Degrees(+46.75512362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230"},
        {"Hipparcos Number", "HIP 591"},
        {"Smithsonian Astrophysical Observation", "SAO 36074"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.79591904),
        dec: Angle.Degrees(+46.75702172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41929"},
        {"Hipparcos Number", "HIP 29265"},
        {"Smithsonian Astrophysical Observation", "SAO 40907"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.54933285),
        dec: Angle.Degrees(+46.75872423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7927",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1330 A"},
        {"Henry Draper", "HD 10321"},
        {"Hipparcos Number", "HIP 7927"},
        {"Smithsonian Astrophysical Observation", "SAO 37437"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.47298920),
        dec: Angle.Degrees(+46.75900569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73651"},
        {"Smithsonian Astrophysical Observation", "SAO 45350"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.82612207),
        dec: Angle.Degrees(+46.78132634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115867"},
        {"Smithsonian Astrophysical Observation", "SAO 53062"},
    },
    visualMagnitude: 9.46,
    bvColour: 1.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.12770044),
        dec: Angle.Degrees(+46.76016068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77916"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.68123450),
        dec: Angle.Degrees(+46.76067466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89268"},
        {"Hipparcos Number", "HIP 50509"},
        {"Geneva Identification System", "GEN# +1.00089268"},
        {"Smithsonian Astrophysical Observation", "SAO 43281"},
        {"Wilson Evans Batten Catalogue", "WEB 9265"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.74487172),
        dec: Angle.Degrees(+46.76085520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46777"},
        {"Hipparcos Number", "HIP 31675"},
        {"Smithsonian Astrophysical Observation", "SAO 41214"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.42170537),
        dec: Angle.Degrees(+46.76297734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214020"},
        {"Hipparcos Number", "HIP 111448"},
    },
    visualMagnitude: 10.24,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.66557314),
        dec: Angle.Degrees(+46.76527649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176131"},
        {"Hipparcos Number", "HIP 92978"},
        {"Geneva Identification System", "GEN# +1.00176131"},
        {"Smithsonian Astrophysical Observation", "SAO 47941"},
        {"Wilson Evans Batten Catalogue", "WEB 16103"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.13389420),
        dec: Angle.Degrees(+46.76635493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36680"},
        {"Smithsonian Astrophysical Observation", "SAO 41842"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.19020922),
        dec: Angle.Degrees(+46.76941495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126453"},
        {"Hipparcos Number", "HIP 70393"},
        {"Geneva Identification System", "GEN# +1.00126453"},
        {"Smithsonian Astrophysical Observation", "SAO 45036"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.03256930),
        dec: Angle.Degrees(+46.76968156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88734",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11085 BC"},
        {"Hipparcos Number", "HIP 88734"},
    },
    visualMagnitude: 11.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)18, (int)06, 54.1100),
        dec: Angle.DegreesMinutesSeconds((int)+46, (int)46, 18.500)
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
    primaryId: "HIP 46055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80810"},
        {"Hipparcos Number", "HIP 46055"},
        {"Geneva Identification System", "GEN# +1.00080810"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.87817650),
        dec: Angle.Degrees(+46.77226552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 984",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 149"},
        {"Henry Draper", "HD 764"},
        {"Hipparcos Number", "HIP 984"},
        {"Smithsonian Astrophysical Observation", "SAO 36152"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.04294341),
        dec: Angle.Degrees(+46.77490907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111938"},
        {"Hipparcos Number", "HIP 62816"},
        {"Geneva Identification System", "GEN# +1.00111938"},
        {"Smithsonian Astrophysical Observation", "SAO 44364"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.07778418),
        dec: Angle.Degrees(+46.77769622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112220"},
        {"Hipparcos Number", "HIP 62992"},
        {"Geneva Identification System", "GEN# +1.00112220"},
        {"Smithsonian Astrophysical Observation", "SAO 44382"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.61702672),
        dec: Angle.Degrees(+46.77781860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26824"},
        {"Hipparcos Number", "HIP 19952"},
        {"Smithsonian Astrophysical Observation", "SAO 39430"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.18754549),
        dec: Angle.Degrees(+46.77815625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11085 A"},
        {"Henry Draper", "HD 166118"},
        {"Hipparcos Number", "HIP 88733"},
        {"Geneva Identification System", "GEN# +1.00166118"},
        {"Smithsonian Astrophysical Observation", "SAO 47227"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.72526719),
        dec: Angle.Degrees(+46.77848310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20558"},
        {"Hipparcos Number", "HIP 15541"},
        {"Smithsonian Astrophysical Observation", "SAO 38733"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.05822974),
        dec: Angle.Degrees(+46.78099932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62755"},
    },
    visualMagnitude: 11.34,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.89402864),
        dec: Angle.Degrees(+59.84053491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221440"},
        {"Hipparcos Number", "HIP 116147"},
        {"Smithsonian Astrophysical Observation", "SAO 53122"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.98993567),
        dec: Angle.Degrees(+46.78459946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128184"},
        {"Hipparcos Number", "HIP 71235"},
        {"Geneva Identification System", "GEN# +1.00128184"},
        {"Smithsonian Astrophysical Observation", "SAO 45117"},
        {"Wilson Evans Batten Catalogue", "WEB 12309"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.52106240),
        dec: Angle.Degrees(+46.78647069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216066"},
        {"Hipparcos Number", "HIP 112667"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.24986096),
        dec: Angle.Degrees(+46.78767084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37059",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6199 AB"},
        {"Hipparcos Number", "HIP 37059"},
        {"Smithsonian Astrophysical Observation", "SAO 41883"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.24082146),
        dec: Angle.Degrees(+46.78837006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110278"},
        {"Hipparcos Number", "HIP 61855"},
        {"Geneva Identification System", "GEN# +1.00110278"},
        {"Smithsonian Astrophysical Observation", "SAO 44278"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.15802492),
        dec: Angle.Degrees(+46.78966631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88985"},
        {"Hipparcos Number", "HIP 50362"},
        {"Smithsonian Astrophysical Observation", "SAO 43266"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.24836061),
        dec: Angle.Degrees(+46.78968866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42304"},
        {"Smithsonian Astrophysical Observation", "SAO 42455"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.37838707),
        dec: Angle.Degrees(+46.79119842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155393"},
        {"Hipparcos Number", "HIP 83912"},
        {"Smithsonian Astrophysical Observation", "SAO 46521"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.24589943),
        dec: Angle.Degrees(+46.79273549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219814"},
        {"Hipparcos Number", "HIP 115069"},
        {"Smithsonian Astrophysical Observation", "SAO 52883"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.60135583),
        dec: Angle.Degrees(+46.79309307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150029"},
        {"Hipparcos Number", "HIP 81293"},
        {"Geneva Identification System", "GEN# +1.00150029"},
        {"Smithsonian Astrophysical Observation", "SAO 46185"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.06057417),
        dec: Angle.Degrees(+46.79421917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70386"},
        {"Hipparcos Number", "HIP 41143"},
        {"Geneva Identification System", "GEN# +1.00070386"},
        {"Smithsonian Astrophysical Observation", "SAO 42330"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.91108566),
        dec: Angle.Degrees(+46.79422309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93915"},
        {"Hipparcos Number", "HIP 53051"},
        {"Geneva Identification System", "GEN# +1.00093915"},
        {"Smithsonian Astrophysical Observation", "SAO 43492"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.81122431),
        dec: Angle.Degrees(+46.79635171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66151",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8945 AB"},
        {"Hipparcos Number", "HIP 66151"},
        {"Geneva Identification System", "GEN# +0.04702068J"},
        {"Smithsonian Astrophysical Observation", "SAO 44658"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.39165295),
        dec: Angle.Degrees(+46.79676000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139798"},
        {"Hipparcos Number", "HIP 76568"},
        {"Fundamental Katalog 5th Edition", "FK5 1412"},
        {"Geneva Identification System", "GEN# +1.00139798"},
        {"Smithsonian Astrophysical Observation", "SAO 45650"},
        {"Wilson Evans Batten Catalogue", "WEB 12998"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.56726549),
        dec: Angle.Degrees(+46.79799524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68831"},
        {"Hipparcos Number", "HIP 40503"},
        {"Smithsonian Astrophysical Observation", "SAO 42257"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.04112513),
        dec: Angle.Degrees(+46.80222539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23690"},
        {"Hipparcos Number", "HIP 17839"},
        {"Smithsonian Astrophysical Observation", "SAO 39123"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.25408087),
        dec: Angle.Degrees(+46.80276531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90368"},
        {"Smithsonian Astrophysical Observation", "SAO 47496"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.59534249),
        dec: Angle.Degrees(+46.80383184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44831"},
        {"Hipparcos Number", "HIP 30641"},
        {"Smithsonian Astrophysical Observation", "SAO 41096"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.59454752),
        dec: Angle.Degrees(+46.80539538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170313"},
        {"Hipparcos Number", "HIP 90370"},
        {"Geneva Identification System", "GEN# +1.00170313"},
        {"Smithsonian Astrophysical Observation", "SAO 47497"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.60182026),
        dec: Angle.Degrees(+46.80891356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24994"},
        {"Hipparcos Number", "HIP 18698"},
        {"Smithsonian Astrophysical Observation", "SAO 39239"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.08846580),
        dec: Angle.Degrees(+46.80894251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172469"},
        {"Hipparcos Number", "HIP 91363"},
        {"Smithsonian Astrophysical Observation", "SAO 47666"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.50430131),
        dec: Angle.Degrees(+46.81018520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57880"},
        {"Hipparcos Number", "HIP 36029"},
        {"Smithsonian Astrophysical Observation", "SAO 41753"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.36600039),
        dec: Angle.Degrees(+46.81042364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82095"},
        {"Smithsonian Astrophysical Observation", "SAO 46274"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.54837233),
        dec: Angle.Degrees(+46.81189478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 259.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10286"},
        {"Hipparcos Number", "HIP 7908"},
        {"Smithsonian Astrophysical Observation", "SAO 37430"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.41457663),
        dec: Angle.Degrees(+46.81255203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156796"},
        {"Hipparcos Number", "HIP 84564"},
        {"Geneva Identification System", "GEN# +1.00156796"},
        {"Smithsonian Astrophysical Observation", "SAO 46611"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.30331070),
        dec: Angle.Degrees(+46.81256828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60810"},
        {"Geneva Identification System", "GEN# +0.04701963"},
        {"Smithsonian Astrophysical Observation", "SAO 44185"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.95710894),
        dec: Angle.Degrees(+46.81480918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99639",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13554 D"},
        {"Henry Draper", "HD 192514"},
        {"Hipparcos Number", "HIP 99639"},
        {"Celescope Catalog", "CEL 4980"},
        {"Geneva Identification System", "GEN# +1.00192514"},
        {"Renson", "Renson 53640"},
        {"Smithsonian Astrophysical Observation", "SAO 49332"},
        {"Wilson Evans Batten Catalogue", "WEB 17858"},
    },
    visualMagnitude: 4.80,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.32517496),
        dec: Angle.Degrees(+46.81567038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79763"},
        {"Hipparcos Number", "HIP 45590"},
        {"Fundamental Katalog 5th Edition", "FK5 2738"},
        {"Geneva Identification System", "GEN# +1.00079763"},
        {"Smithsonian Astrophysical Observation", "SAO 42790"},
        {"Wilson Evans Batten Catalogue", "WEB 8664"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.37985665),
        dec: Angle.Degrees(+46.81719916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73346"},
        {"Geneva Identification System", "GEN# +0.04702190"},
        {"Smithsonian Astrophysical Observation", "SAO 45318"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.83477582),
        dec: Angle.Degrees(+46.81763692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35312"},
        {"Hipparcos Number", "HIP 25420"},
        {"Smithsonian Astrophysical Observation", "SAO 40329"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.56050976),
        dec: Angle.Degrees(+46.81907098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219624"},
        {"Hipparcos Number", "HIP 114928"},
        {"Smithsonian Astrophysical Observation", "SAO 52855"},
    },
    visualMagnitude: 8.53,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.19098817),
        dec: Angle.Degrees(+46.81912897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65627"},
        {"Geneva Identification System", "GEN# +0.04702060"},
        {"Smithsonian Astrophysical Observation", "SAO 44614"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.82555671),
        dec: Angle.Degrees(+46.82008214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164631"},
        {"Hipparcos Number", "HIP 88113"},
        {"Geneva Identification System", "GEN# +1.00164631"},
        {"Smithsonian Astrophysical Observation", "SAO 47117"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.93554394),
        dec: Angle.Degrees(+46.82138488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36927"},
        {"Hipparcos Number", "HIP 26424"},
        {"Smithsonian Astrophysical Observation", "SAO 40488"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.35964264),
        dec: Angle.Degrees(+46.82149184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66774"},
        {"Hipparcos Number", "HIP 39724"},
        {"Smithsonian Astrophysical Observation", "SAO 42173"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.79313617),
        dec: Angle.Degrees(+46.82172030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217089"},
        {"Hipparcos Number", "HIP 113356"},
        {"Geneva Identification System", "GEN# +1.00217089"},
        {"Smithsonian Astrophysical Observation", "SAO 52530"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.36216056),
        dec: Angle.Degrees(+46.82269121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207529"},
        {"Hipparcos Number", "HIP 107654"},
        {"Geneva Identification System", "GEN# +1.00207529"},
        {"Smithsonian Astrophysical Observation", "SAO 51320"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.09268576),
        dec: Angle.Degrees(+46.82591169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14034",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14034"},
        {"Smithsonian Astrophysical Observation", "SAO 38505"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.17614478),
        dec: Angle.Degrees(+46.82696075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190782"},
        {"Hipparcos Number", "HIP 98867"},
        {"Smithsonian Astrophysical Observation", "SAO 49154"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.15891886),
        dec: Angle.Degrees(+46.82930110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106862"},
        {"Smithsonian Astrophysical Observation", "SAO 51135"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.65060396),
        dec: Angle.Degrees(+46.82936018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217634"},
        {"Hipparcos Number", "HIP 113679"},
        {"Geneva Identification System", "GEN# +1.00217634"},
        {"Smithsonian Astrophysical Observation", "SAO 52604"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.36705057),
        dec: Angle.Degrees(+46.82995138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83015",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10283 AB"},
        {"Henry Draper", "HD 153526"},
        {"Hipparcos Number", "HIP 83015"},
        {"Smithsonian Astrophysical Observation", "SAO 46407"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.46006763),
        dec: Angle.Degrees(+46.82999139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50727"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.36408306),
        dec: Angle.Degrees(+46.83142627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107306"},
        {"Smithsonian Astrophysical Observation", "SAO 51239"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.00946357),
        dec: Angle.Degrees(+46.83152113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117340",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17006 AB"},
        {"Henry Draper", "HD 223229"},
        {"Hipparcos Number", "HIP 117340"},
        {"Geneva Identification System", "GEN# +1.00223229J"},
        {"Smithsonian Astrophysical Observation", "SAO 53374"},
        {"Wilson Evans Batten Catalogue", "WEB 20673"},
    },
    visualMagnitude: 6.08,
    bvColour: -0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.88770252),
        dec: Angle.Degrees(+46.83257654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101133"},
        {"Hipparcos Number", "HIP 56789"},
        {"Fundamental Katalog 5th Edition", "FK5 2931"},
        {"Geneva Identification System", "GEN# +1.00101133"},
        {"Smithsonian Astrophysical Observation", "SAO 43839"},
        {"Wilson Evans Batten Catalogue", "WEB 10223"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.63976309),
        dec: Angle.Degrees(+46.83427569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81912"},
        {"Hipparcos Number", "HIP 46599"},
        {"Geneva Identification System", "GEN# +1.00081912"},
        {"Smithsonian Astrophysical Observation", "SAO 42894"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.53736864),
        dec: Angle.Degrees(+46.83538142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123573"},
        {"Hipparcos Number", "HIP 68969"},
        {"Geneva Identification System", "GEN# +1.00123573"},
        {"Smithsonian Astrophysical Observation", "SAO 44895"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.79863495),
        dec: Angle.Degrees(+46.83617798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193722"},
        {"Hipparcos Number", "HIP 100250"},
        {"Celescope Catalog", "CEL 5029"},
        {"Geneva Identification System", "GEN# +1.00193722"},
        {"Renson", "Renson 54060"},
        {"Smithsonian Astrophysical Observation", "SAO 49482"},
        {"Wilson Evans Batten Catalogue", "WEB 18071"},
    },
    visualMagnitude: 6.49,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.98351514),
        dec: Angle.Degrees(+46.83730538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18592"},
        {"Hipparcos Number", "HIP 14058"},
        {"Smithsonian Astrophysical Observation", "SAO 38509"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.27760177),
        dec: Angle.Degrees(+46.83908863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59168"},
        {"Geneva Identification System", "GEN# +0.04701929"},
        {"Smithsonian Astrophysical Observation", "SAO 44044"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.00621668),
        dec: Angle.Degrees(+46.83965500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80303"},
        {"Smithsonian Astrophysical Observation", "SAO 46061"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.90197520),
        dec: Angle.Degrees(+46.84082390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 205.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92278"},
        {"Hipparcos Number", "HIP 52216"},
        {"Fundamental Katalog 5th Edition", "FK5 4950"},
        {"Geneva Identification System", "GEN# +1.00092278"},
        {"Smithsonian Astrophysical Observation", "SAO 43423"},
        {"Wilson Evans Batten Catalogue", "WEB 9512"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.03165162),
        dec: Angle.Degrees(+46.84083724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5717"},
        {"Hipparcos Number", "HIP 4633"},
        {"Celescope Catalog", "CEL 103"},
        {"Geneva Identification System", "GEN# +1.00005717"},
        {"Smithsonian Astrophysical Observation", "SAO 36824"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.86515099),
        dec: Angle.Degrees(+46.84122356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16933"},
        {"Hipparcos Number", "HIP 12804"},
        {"Geneva Identification System", "GEN# +1.00016933"},
        {"Smithsonian Astrophysical Observation", "SAO 38294"},
        {"Wilson Evans Batten Catalogue", "WEB 2602"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.13769061),
        dec: Angle.Degrees(+46.84171508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111121",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111121"},
        {"Smithsonian Astrophysical Observation", "SAO 52085"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.66069910),
        dec: Angle.Degrees(+46.84177253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17656"},
        {"Hipparcos Number", "HIP 13339"},
        {"Fundamental Katalog 5th Edition", "FK5 2197"},
        {"Geneva Identification System", "GEN# +1.00017656"},
        {"Smithsonian Astrophysical Observation", "SAO 38397"},
        {"Wilson Evans Batten Catalogue", "WEB 2673"},
    },
    visualMagnitude: 5.86,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.92396836),
        dec: Angle.Degrees(+46.84200204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6645"},
        {"Hipparcos Number", "HIP 5303"},
        {"Geneva Identification System", "GEN# +1.00006645J"},
        {"Wilson Evans Batten Catalogue", "WEB 1138"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.95656160),
        dec: Angle.Degrees(+46.84212334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12352"},
        {"Hipparcos Number", "HIP 9508"},
        {"Geneva Identification System", "GEN# +1.00012352"},
        {"Smithsonian Astrophysical Observation", "SAO 37713"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.58331336),
        dec: Angle.Degrees(+46.84255204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11657",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11657"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.58637534),
        dec: Angle.Degrees(+46.84566487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134942B"},
        {"Hipparcos Number", "HIP 74281"},
        {"Geneva Identification System", "GEN# +1.00134942B"},
        {"Smithsonian Astrophysical Observation", "SAO 45416"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.70898542),
        dec: Angle.Degrees(+46.84837153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21932"},
        {"Hipparcos Number", "HIP 16644"},
        {"Smithsonian Astrophysical Observation", "SAO 38947"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.54104023),
        dec: Angle.Degrees(+46.84921057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134942"},
        {"Hipparcos Number", "HIP 74278"},
        {"Geneva Identification System", "GEN# +1.00134942A"},
        {"Smithsonian Astrophysical Observation", "SAO 45415"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.70183384),
        dec: Angle.Degrees(+46.85010457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114283"},
        {"Hipparcos Number", "HIP 64155"},
        {"Geneva Identification System", "GEN# +1.00114283"},
        {"Smithsonian Astrophysical Observation", "SAO 44487"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.23504639),
        dec: Angle.Degrees(+46.85350240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28005"},
        {"Hipparcos Number", "HIP 20800"},
        {"Cincinnati Publication", "Ci 18 585"},
        {"Geneva Identification System", "GEN# +1.00028005"},
        {"Smithsonian Astrophysical Observation", "SAO 39540"},
        {"Wilson Evans Batten Catalogue", "WEB 3990"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.85264573),
        dec: Angle.Degrees(+46.85388868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86916",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86916"},
        {"Wilson Evans Batten Catalogue", "WEB 14662"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.38988016),
        dec: Angle.Degrees(+46.85535248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203013"},
        {"Hipparcos Number", "HIP 105153"},
        {"Celescope Catalog", "CEL 5289"},
        {"Smithsonian Astrophysical Observation", "SAO 50681"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.51209497),
        dec: Angle.Degrees(+46.85729633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213833"},
        {"Hipparcos Number", "HIP 111340"},
        {"Smithsonian Astrophysical Observation", "SAO 52139"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.35448109),
        dec: Angle.Degrees(+46.85748671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158296"},
        {"Hipparcos Number", "HIP 85323"},
        {"Smithsonian Astrophysical Observation", "SAO 46715"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.54144071),
        dec: Angle.Degrees(+46.85853797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12741"},
        {"Hipparcos Number", "HIP 9805"},
        {"Geneva Identification System", "GEN# +1.00012741"},
        {"Smithsonian Astrophysical Observation", "SAO 37765"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.54335612),
        dec: Angle.Degrees(+46.85999594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222555"},
        {"Hipparcos Number", "HIP 116870"},
        {"Smithsonian Astrophysical Observation", "SAO 53274"},
        {"Wilson Evans Batten Catalogue", "WEB 20618"},
    },
    visualMagnitude: 7.42,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.33430045),
        dec: Angle.Degrees(+46.86007548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43713"},
        {"Geneva Identification System", "GEN# +0.04701621"},
        {"Smithsonian Astrophysical Observation", "SAO 42590"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.53851097),
        dec: Angle.Degrees(+46.86010123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206963"},
        {"Hipparcos Number", "HIP 107339"},
        {"Geneva Identification System", "GEN# +1.00206963"},
        {"Smithsonian Astrophysical Observation", "SAO 51244"},
        {"Wilson Evans Batten Catalogue", "WEB 19383"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.10594455),
        dec: Angle.Degrees(+46.86277227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200753"},
        {"Hipparcos Number", "HIP 103949"},
        {"Celescope Catalog", "CEL 5239"},
        {"Geneva Identification System", "GEN# +1.00200753"},
        {"Smithsonian Astrophysical Observation", "SAO 50408"},
        {"Wilson Evans Batten Catalogue", "WEB 18930"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.93124960),
        dec: Angle.Degrees(+46.86328998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208835"},
        {"Hipparcos Number", "HIP 108424"},
        {"Celescope Catalog", "CEL 5412"},
        {"Geneva Identification System", "GEN# +1.00208835"},
        {"Renson", "Renson 58070"},
        {"Smithsonian Astrophysical Observation", "SAO 51488"},
        {"Wilson Evans Batten Catalogue", "WEB 19525"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.46398375),
        dec: Angle.Degrees(+46.86444076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48326"},
        {"Hipparcos Number", "HIP 32361"},
        {"Geneva Identification System", "GEN# +1.00048326"},
        {"Smithsonian Astrophysical Observation", "SAO 41312"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.32154091),
        dec: Angle.Degrees(+46.86465484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23581",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23581"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.04577836),
        dec: Angle.Degrees(+46.86481369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75528"},
        {"Smithsonian Astrophysical Observation", "SAO 45537"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.44536675),
        dec: Angle.Degrees(+46.86606350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80441",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80441"},
        {"Geneva Identification System", "GEN# +0.04702339"},
        {"Smithsonian Astrophysical Observation", "SAO 46078"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.30910360),
        dec: Angle.Degrees(+46.86827588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153969"},
        {"Hipparcos Number", "HIP 83210"},
        {"Smithsonian Astrophysical Observation", "SAO 46434"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.08613520),
        dec: Angle.Degrees(+46.87176624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91029"},
        {"Hipparcos Number", "HIP 51531"},
        {"Geneva Identification System", "GEN# +1.00091029"},
        {"Smithsonian Astrophysical Observation", "SAO 43369"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.88326384),
        dec: Angle.Degrees(+46.87422878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5344"},
        {"Hipparcos Number", "HIP 4358"},
        {"Celescope Catalog", "CEL 99"},
        {"Geneva Identification System", "GEN# +1.00005344"},
        {"Smithsonian Astrophysical Observation", "SAO 36775"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.96054083),
        dec: Angle.Degrees(+46.87583374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146360"},
        {"Hipparcos Number", "HIP 79547"},
        {"Geneva Identification System", "GEN# +1.00146360"},
        {"Smithsonian Astrophysical Observation", "SAO 45977"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.47990055),
        dec: Angle.Degrees(+46.87623710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34607"},
        {"Smithsonian Astrophysical Observation", "SAO 41595"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.52827472),
        dec: Angle.Degrees(+46.88059814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36304"},
        {"Hipparcos Number", "HIP 26023"},
        {"Smithsonian Astrophysical Observation", "SAO 40417"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.28450891),
        dec: Angle.Degrees(+46.88153266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5279"},
        {"Hipparcos Number", "HIP 4306"},
        {"Smithsonian Astrophysical Observation", "SAO 36764"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.79042876),
        dec: Angle.Degrees(+46.88298000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71165"},
        {"Smithsonian Astrophysical Observation", "SAO 45111"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.33067335),
        dec: Angle.Degrees(+46.88400637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134366"},
        {"Hipparcos Number", "HIP 74036"},
        {"Smithsonian Astrophysical Observation", "SAO 45395"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.95637160),
        dec: Angle.Degrees(+46.88508162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29328"},
        {"Smithsonian Astrophysical Observation", "SAO 40915"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.75942835),
        dec: Angle.Degrees(+46.88515743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90283",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11343 AB"},
        {"Henry Draper", "HD 170074"},
        {"Hipparcos Number", "HIP 90283"},
        {"Smithsonian Astrophysical Observation", "SAO 47479"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.32289775),
        dec: Angle.Degrees(+46.88540232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196832"},
        {"Hipparcos Number", "HIP 101825"},
        {"Celescope Catalog", "CEL 5133"},
        {"Geneva Identification System", "GEN# +1.00196832"},
        {"Smithsonian Astrophysical Observation", "SAO 49883"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.52471161),
        dec: Angle.Degrees(+46.88580882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8328"},
        {"Hipparcos Number", "HIP 6498"},
        {"Geneva Identification System", "GEN# +1.00008328"},
        {"Smithsonian Astrophysical Observation", "SAO 37167"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.86855224),
        dec: Angle.Degrees(+46.89074454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60760",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60760"},
        {"Smithsonian Astrophysical Observation", "SAO 44182"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.80859628),
        dec: Angle.Degrees(+46.89177185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36842"},
        {"Smithsonian Astrophysical Observation", "SAO 41856"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.63280840),
        dec: Angle.Degrees(+46.89277186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9645"},
        {"Hipparcos Number", "HIP 7412"},
        {"Renson", "Renson 2360"},
        {"Smithsonian Astrophysical Observation", "SAO 37340"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.88909666),
        dec: Angle.Degrees(+46.89279580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4385"},
        {"Hipparcos Number", "HIP 3638"},
        {"Smithsonian Astrophysical Observation", "SAO 36650"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.65739623),
        dec: Angle.Degrees(+46.89376955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106092"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.36179709),
        dec: Angle.Degrees(+46.89546137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30978"},
        {"Geneva Identification System", "GEN# +0.04601148"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.52494688),
        dec: Angle.Degrees(+46.89554666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14448"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.61613947),
        dec: Angle.Degrees(+46.89795866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94586"},
        {"Hipparcos Number", "HIP 53445"},
        {"Smithsonian Astrophysical Observation", "SAO 43527"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.99971228),
        dec: Angle.Degrees(+46.89924388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40928"},
        {"Hipparcos Number", "HIP 28759"},
        {"Smithsonian Astrophysical Observation", "SAO 40827"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.08669769),
        dec: Angle.Degrees(+46.89982693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211947"},
        {"Hipparcos Number", "HIP 110242"},
        {"Smithsonian Astrophysical Observation", "SAO 51880"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.95767820),
        dec: Angle.Degrees(+46.90039035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84009"},
        {"Geneva Identification System", "GEN# +0.04702437"},
        {"Smithsonian Astrophysical Observation", "SAO 46536"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.58638234),
        dec: Angle.Degrees(+46.90076147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73971"},
        {"Hipparcos Number", "HIP 42777"},
        {"Geneva Identification System", "GEN# +1.00073971"},
        {"Smithsonian Astrophysical Observation", "SAO 42508"},
        {"Wilson Evans Batten Catalogue", "WEB 8261"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.75080939),
        dec: Angle.Degrees(+46.90099532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82582"},
        {"Hipparcos Number", "HIP 46963"},
        {"Geneva Identification System", "GEN# +1.00082582"},
        {"Smithsonian Astrophysical Observation", "SAO 42924"},
        {"Wilson Evans Batten Catalogue", "WEB 8853"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.58174239),
        dec: Angle.Degrees(+46.90211825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207608"},
        {"Hipparcos Number", "HIP 107692"},
        {"Geneva Identification System", "GEN# +1.00207608"},
        {"Smithsonian Astrophysical Observation", "SAO 51327"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.22808959),
        dec: Angle.Degrees(+46.90308978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99052"},
        {"Hipparcos Number", "HIP 55669"},
        {"Geneva Identification System", "GEN# +1.00099052"},
        {"Smithsonian Astrophysical Observation", "SAO 43731"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.09765244),
        dec: Angle.Degrees(+46.90337669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140770"},
        {"Hipparcos Number", "HIP 77016"},
        {"Geneva Identification System", "GEN# +1.00140770"},
        {"Smithsonian Astrophysical Observation", "SAO 45697"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.87764211),
        dec: Angle.Degrees(+46.90374488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24241"},
        {"Hipparcos Number", "HIP 18188"},
        {"Geneva Identification System", "GEN# +1.00024241"},
        {"Smithsonian Astrophysical Observation", "SAO 39173"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.36842925),
        dec: Angle.Degrees(+46.90392895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137257"},
        {"Hipparcos Number", "HIP 75307"},
        {"Geneva Identification System", "GEN# +1.00137257"},
        {"Smithsonian Astrophysical Observation", "SAO 45516"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.79302172),
        dec: Angle.Degrees(+46.90631547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55507"},
        {"Smithsonian Astrophysical Observation", "SAO 43715"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.52466408),
        dec: Angle.Degrees(+46.90871853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23684",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3659 AB"},
        {"Henry Draper", "HD 32416"},
        {"Hipparcos Number", "HIP 23684"},
        {"Smithsonian Astrophysical Observation", "SAO 40008"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.36371278),
        dec: Angle.Degrees(+46.91638827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192141"},
        {"Hipparcos Number", "HIP 99490"},
        {"Geneva Identification System", "GEN# +1.00192141"},
        {"Smithsonian Astrophysical Observation", "SAO 49296"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.86185664),
        dec: Angle.Degrees(+46.91842972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40131"},
        {"Hipparcos Number", "HIP 28340"},
        {"Celescope Catalog", "CEL 1047"},
        {"Geneva Identification System", "GEN# +1.00040131"},
        {"Smithsonian Astrophysical Observation", "SAO 40745"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.83464176),
        dec: Angle.Degrees(+46.91845796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66804",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66804"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.40521218),
        dec: Angle.Degrees(+46.91894075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94779"},
        {"Hipparcos Number", "HIP 53548"},
        {"Geneva Identification System", "GEN# +1.00094779"},
        {"Renson", "Renson 27340"},
        {"Smithsonian Astrophysical Observation", "SAO 43542"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.32196339),
        dec: Angle.Degrees(+46.91933144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26252"},
        {"Hipparcos Number", "HIP 19553"},
        {"Geneva Identification System", "GEN# +1.00026252"},
        {"Smithsonian Astrophysical Observation", "SAO 39360"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.82039204),
        dec: Angle.Degrees(+46.92056752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210457"},
        {"Hipparcos Number", "HIP 109372"},
        {"Geneva Identification System", "GEN# +1.00210457"},
        {"Smithsonian Astrophysical Observation", "SAO 51705"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.36767400),
        dec: Angle.Degrees(+46.92081483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60593",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60593"},
        {"Smithsonian Astrophysical Observation", "SAO 44167"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.29069260),
        dec: Angle.Degrees(+46.92149392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45950"},
        {"Hipparcos Number", "HIP 31209"},
        {"Smithsonian Astrophysical Observation", "SAO 41162"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.20575713),
        dec: Angle.Degrees(+46.92291186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218325"},
        {"Hipparcos Number", "HIP 114100"},
        {"Geneva Identification System", "GEN# +1.00218325"},
        {"Smithsonian Astrophysical Observation", "SAO 52685"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.63734592),
        dec: Angle.Degrees(+46.92362067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78417",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78417"},
        {"Wilson Evans Batten Catalogue", "WEB 13255"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.13451878),
        dec: Angle.Degrees(+46.92377838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25616"},
        {"Hipparcos Number", "HIP 19127"},
        {"Smithsonian Astrophysical Observation", "SAO 39308"},
        {"Wilson Evans Batten Catalogue", "WEB 3672"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.50878274),
        dec: Angle.Degrees(+46.92568730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136579"},
        {"Hipparcos Number", "HIP 75086"},
        {"Smithsonian Astrophysical Observation", "SAO 45498"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.15595341),
        dec: Angle.Degrees(+46.92572855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139920"},
        {"Hipparcos Number", "HIP 76630"},
        {"Smithsonian Astrophysical Observation", "SAO 45661"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.74538197),
        dec: Angle.Degrees(+46.92660833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214311"},
        {"Hipparcos Number", "HIP 111591"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.10433968),
        dec: Angle.Degrees(+46.92750596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153093"},
        {"Hipparcos Number", "HIP 82785"},
        {"Geneva Identification System", "GEN# +1.00153093"},
        {"Smithsonian Astrophysical Observation", "SAO 46367"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.77415653),
        dec: Angle.Degrees(+46.92762455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56887"},
        {"Hipparcos Number", "HIP 35636"},
        {"Smithsonian Astrophysical Observation", "SAO 41706"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.30975989),
        dec: Angle.Degrees(+46.92837344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45558",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45558"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.28203593),
        dec: Angle.Degrees(+46.93005124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54253"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.48443184),
        dec: Angle.Degrees(+46.93015748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93408",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11964 A"},
        {"Henry Draper", "HD 177196"},
        {"Hipparcos Number", "HIP 93408"},
        {"Geneva Identification System", "GEN# +1.00177196"},
        {"Smithsonian Astrophysical Observation", "SAO 48011"},
        {"Wilson Evans Batten Catalogue", "WEB 16204"},
    },
    visualMagnitude: 5.00,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.35983210),
        dec: Angle.Degrees(+46.93502175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216682"},
        {"Hipparcos Number", "HIP 113098"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.56373728),
        dec: Angle.Degrees(+46.93538837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90383"},
        {"Hipparcos Number", "HIP 51163"},
        {"Geneva Identification System", "GEN# +1.00090383"},
        {"Smithsonian Astrophysical Observation", "SAO 43340"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.75981681),
        dec: Angle.Degrees(+46.93728002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2560 A"},
        {"Henry Draper", "HD 21455"},
        {"Hipparcos Number", "HIP 16252"},
        {"Geneva Identification System", "GEN# +5.20200861"},
        {"Smithsonian Astrophysical Observation", "SAO 38874"},
        {"Wilson Evans Batten Catalogue", "WEB 3098"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.35943439),
        dec: Angle.Degrees(+46.93793775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67045"},
        {"Hipparcos Number", "HIP 39813"},
        {"Smithsonian Astrophysical Observation", "SAO 42183"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.03043145),
        dec: Angle.Degrees(+46.93835163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224720"},
        {"Hipparcos Number", "HIP 11"},
        {"Smithsonian Astrophysical Observation", "SAO 53560"},
        {"Wilson Evans Batten Catalogue", "WEB 2"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.03729695),
        dec: Angle.Degrees(+46.94000154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67871"},
        {"Hipparcos Number", "HIP 40158"},
        {"Smithsonian Astrophysical Observation", "SAO 42222"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.02102221),
        dec: Angle.Degrees(+46.94168806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33297"},
        {"Hipparcos Number", "HIP 24198"},
        {"Celescope Catalog", "CEL 556"},
        {"Geneva Identification System", "GEN# +1.00033297"},
        {"Smithsonian Astrophysical Observation", "SAO 40092"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.92560792),
        dec: Angle.Degrees(+46.94228664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218324"},
        {"Hipparcos Number", "HIP 114105"},
        {"Smithsonian Astrophysical Observation", "SAO 52688"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.65407005),
        dec: Angle.Degrees(+46.94266346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80079"},
        {"Hipparcos Number", "HIP 45722"},
        {"Smithsonian Astrophysical Observation", "SAO 42803"},
    },
    visualMagnitude: 6.91,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.81397832),
        dec: Angle.Degrees(+46.94381260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85977",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10644 A"},
        {"Henry Draper", "HD 159813"},
        {"Henry Draper 2", "HD 159813A"},
        {"Hipparcos Number", "HIP 85977"},
        {"Smithsonian Astrophysical Observation", "SAO 46803"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.58094998),
        dec: Angle.Degrees(+46.94404077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 309.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202252"},
        {"Hipparcos Number", "HIP 104737"},
        {"Smithsonian Astrophysical Observation", "SAO 50582"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.25976579),
        dec: Angle.Degrees(+46.94623807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183969"},
        {"Hipparcos Number", "HIP 95879"},
        {"Smithsonian Astrophysical Observation", "SAO 48516"},
    },
    visualMagnitude: 6.88,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.49542621),
        dec: Angle.Degrees(+46.94648564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86411"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.84759216),
        dec: Angle.Degrees(+46.94706686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -403.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157323"},
        {"Hipparcos Number", "HIP 84830"},
        {"Geneva Identification System", "GEN# +1.00157323"},
        {"Smithsonian Astrophysical Observation", "SAO 46644"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.07049239),
        dec: Angle.Degrees(+46.94736650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9860"},
        {"Hipparcos Number", "HIP 7551"},
        {"Smithsonian Astrophysical Observation", "SAO 37368"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.32128376),
        dec: Angle.Degrees(+46.94873887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20296"},
        {"Hipparcos Number", "HIP 15322"},
        {"Geneva Identification System", "GEN# +5.20200341"},
        {"Smithsonian Astrophysical Observation", "SAO 38702"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.41409691),
        dec: Angle.Degrees(+46.94899911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114704"},
        {"Hipparcos Number", "HIP 64360"},
        {"Smithsonian Astrophysical Observation", "SAO 44501"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.87461671),
        dec: Angle.Degrees(+46.95217490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24532"},
        {"Hipparcos Number", "HIP 18415"},
        {"Smithsonian Astrophysical Observation", "SAO 39198"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.05243206),
        dec: Angle.Degrees(+46.95229309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86145"},
        {"Hipparcos Number", "HIP 48862"},
        {"Smithsonian Astrophysical Observation", "SAO 43116"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.48674877),
        dec: Angle.Degrees(+46.95273776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176731"},
        {"Hipparcos Number", "HIP 93228"},
        {"Smithsonian Astrophysical Observation", "SAO 47985"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.85436919),
        dec: Angle.Degrees(+46.95329257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88896"},
        {"Hipparcos Number", "HIP 50310"},
        {"Smithsonian Astrophysical Observation", "SAO 43256"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.08152940),
        dec: Angle.Degrees(+46.95407238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3045",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 538 A"},
        {"Henry Draper", "HD 3531"},
        {"Hipparcos Number", "HIP 3045"},
        {"Geneva Identification System", "GEN# +1.00003531"},
        {"Smithsonian Astrophysical Observation", "SAO 36542"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.67335193),
        dec: Angle.Degrees(+46.95682893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24950",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3903 B"},
        {"Henry Draper", "HD 34534"},
        {"Hipparcos Number", "HIP 24950"},
        {"Geneva Identification System", "GEN# +1.00034534"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.16289582),
        dec: Angle.Degrees(+46.95734607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9816"},
        {"Smithsonian Astrophysical Observation", "SAO 37766"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.56855528),
        dec: Angle.Degrees(+46.95744286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183031"},
        {"Hipparcos Number", "HIP 95491"},
        {"Smithsonian Astrophysical Observation", "SAO 48423"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.35763619),
        dec: Angle.Degrees(+46.95811853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61069"},
        {"Smithsonian Astrophysical Observation", "SAO 44209"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.74283097),
        dec: Angle.Degrees(+46.96014625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33167"},
        {"Hipparcos Number", "HIP 24109"},
        {"Geneva Identification System", "GEN# +1.00033167"},
        {"Smithsonian Astrophysical Observation", "SAO 40077"},
        {"Wilson Evans Batten Catalogue", "WEB 4688"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.67862860),
        dec: Angle.Degrees(+46.96243511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104490"},
        {"Smithsonian Astrophysical Observation", "SAO 50527"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.50337202),
        dec: Angle.Degrees(+46.96295466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201065"},
        {"Hipparcos Number", "HIP 104115"},
        {"Geneva Identification System", "GEN# +1.00201065"},
        {"Smithsonian Astrophysical Observation", "SAO 50438"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.39913327),
        dec: Angle.Degrees(+46.96327950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3903 A"},
        {"Henry Draper", "HD 34533"},
        {"Hipparcos Number", "HIP 24951"},
        {"Geneva Identification System", "GEN# +1.00034533"},
        {"Renson", "Renson 8816"},
        {"Smithsonian Astrophysical Observation", "SAO 40251"},
        {"Wilson Evans Batten Catalogue", "WEB 4832"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.16319356),
        dec: Angle.Degrees(+46.96380531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57668"},
        {"Hipparcos Number", "HIP 35949"},
        {"Geneva Identification System", "GEN# +1.00057668"},
        {"Smithsonian Astrophysical Observation", "SAO 41743"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.16072185),
        dec: Angle.Degrees(+46.96544771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29818"},
        {"Hipparcos Number", "HIP 22032"},
        {"Geneva Identification System", "GEN# +1.00029818"},
        {"Smithsonian Astrophysical Observation", "SAO 39710"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.04613416),
        dec: Angle.Degrees(+46.96566529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83595",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10338 A"},
        {"Henry Draper", "HD 154759"},
        {"Hipparcos Number", "HIP 83595"},
        {"Geneva Identification System", "GEN# +1.00154759"},
        {"Smithsonian Astrophysical Observation", "SAO 46479"},
        {"Wilson Evans Batten Catalogue", "WEB 14134"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.27291037),
        dec: Angle.Degrees(+46.96718764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202328"},
        {"Hipparcos Number", "HIP 104779"},
        {"Smithsonian Astrophysical Observation", "SAO 50591"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.39578421),
        dec: Angle.Degrees(+46.96724871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8770"},
        {"Hipparcos Number", "HIP 6785"},
        {"Smithsonian Astrophysical Observation", "SAO 37225"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.83392027),
        dec: Angle.Degrees(+46.97012651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145799"},
        {"Hipparcos Number", "HIP 79281"},
        {"Smithsonian Astrophysical Observation", "SAO 45945"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.71857333),
        dec: Angle.Degrees(+46.97074241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97439"},
        {"Hipparcos Number", "HIP 54822"},
        {"Smithsonian Astrophysical Observation", "SAO 43648"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.34054227),
        dec: Angle.Degrees(+46.97087971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56586"},
        {"Hipparcos Number", "HIP 35520"},
        {"Geneva Identification System", "GEN# +1.00056586"},
        {"Smithsonian Astrophysical Observation", "SAO 41695"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.97859385),
        dec: Angle.Degrees(+46.97259379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23156"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.72641797),
        dec: Angle.Degrees(+46.97297056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69641",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9183 AB"},
        {"Henry Draper", "HD 124952"},
        {"Hipparcos Number", "HIP 69641"},
        {"Smithsonian Astrophysical Observation", "SAO 44956"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.80057698),
        dec: Angle.Degrees(+46.97412509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9043"},
        {"Hipparcos Number", "HIP 6995"},
        {"Smithsonian Astrophysical Observation", "SAO 37270"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.50641624),
        dec: Angle.Degrees(+46.97416889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33601"},
        {"Hipparcos Number", "HIP 24380"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.45626404),
        dec: Angle.Degrees(+46.97670426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55401"},
    },
    visualMagnitude: 12.27,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.18427123),
        dec: Angle.Degrees(+46.97734529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113644"},
        {"Smithsonian Astrophysical Observation", "SAO 52596"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.23899498),
        dec: Angle.Degrees(+46.97892888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89067"},
        {"Geneva Identification System", "GEN# +0.04602435"},
        {"Smithsonian Astrophysical Observation", "SAO 47277"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.67425410),
        dec: Angle.Degrees(+46.98148674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180162"},
        {"Hipparcos Number", "HIP 94438"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.31464005),
        dec: Angle.Degrees(+46.98218515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38400"},
        {"Hipparcos Number", "HIP 27372"},
        {"Geneva Identification System", "GEN# +1.00038400"},
        {"Smithsonian Astrophysical Observation", "SAO 40610"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.95829154),
        dec: Angle.Degrees(+46.98367490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21153"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.02652091),
        dec: Angle.Degrees(+46.98398627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37425"},
        {"Geneva Identification System", "GEN# +0.04701474"},
        {"Smithsonian Astrophysical Observation", "SAO 41927"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.23951478),
        dec: Angle.Degrees(+46.98584519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141399"},
        {"Hipparcos Number", "HIP 77301"},
        {"Geneva Identification System", "GEN# +1.00141399"},
        {"Smithsonian Astrophysical Observation", "SAO 45726"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.72460781),
        dec: Angle.Degrees(+46.98624664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34887"},
        {"Hipparcos Number", "HIP 25166"},
        {"Geneva Identification System", "GEN# +1.00034887"},
        {"Smithsonian Astrophysical Observation", "SAO 40289"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.76294957),
        dec: Angle.Degrees(+46.98698851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29997"},
        {"Hipparcos Number", "HIP 22153"},
        {"Smithsonian Astrophysical Observation", "SAO 39734"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.50104894),
        dec: Angle.Degrees(+46.98860897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45274",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7243 AB"},
        {"Henry Draper", "HD 79107"},
        {"Hipparcos Number", "HIP 45274"},
        {"Smithsonian Astrophysical Observation", "SAO 42755"},
        {"Wilson Evans Batten Catalogue", "WEB 8625"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.41158414),
        dec: Angle.Degrees(+46.99039412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33368"},
        {"Geneva Identification System", "GEN# +6.20030483"},
    },
    visualMagnitude: 10.91,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.09234729),
        dec: Angle.Degrees(+46.99106055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18873",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2940 AB"},
        {"Henry Draper", "HD 25246"},
        {"Hipparcos Number", "HIP 18873"},
        {"Smithsonian Astrophysical Observation", "SAO 39264"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.68419453),
        dec: Angle.Degrees(+46.99698995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89914",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89914"},
        {"Smithsonian Astrophysical Observation", "SAO 47406"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.21432715),
        dec: Angle.Degrees(+46.99787978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95802"},
        {"Smithsonian Astrophysical Observation", "SAO 48505"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.29562991),
        dec: Angle.Degrees(+46.99790019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181096"},
        {"Hipparcos Number", "HIP 94755"},
        {"Fundamental Katalog 5th Edition", "FK5 3541"},
        {"Geneva Identification System", "GEN# +1.00181096"},
        {"Smithsonian Astrophysical Observation", "SAO 48278"},
        {"Wilson Evans Batten Catalogue", "WEB 16535"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.21414473),
        dec: Angle.Degrees(+46.99839321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 291.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8709",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8709"},
        {"Geneva Identification System", "GEN# +6.10060279"},
    },
    visualMagnitude: 12.44,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.01232553),
        dec: Angle.Degrees(+47.00155059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116475"},
        {"Hipparcos Number", "HIP 65309"},
        {"Smithsonian Astrophysical Observation", "SAO 44590"},
        {"Wilson Evans Batten Catalogue", "WEB 11528"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.77292569),
        dec: Angle.Degrees(+47.00195483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52250"},
        {"Smithsonian Astrophysical Observation", "SAO 43427"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.13856517),
        dec: Angle.Degrees(+47.00255334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9057"},
        {"Hipparcos Number", "HIP 6999"},
        {"Geneva Identification System", "GEN# +1.00009057"},
        {"Smithsonian Astrophysical Observation", "SAO 37275"},
        {"Wilson Evans Batten Catalogue", "WEB 1513"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.52542506),
        dec: Angle.Degrees(+47.00737711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109496"},
        {"Hipparcos Number", "HIP 61380"},
        {"Smithsonian Astrophysical Observation", "SAO 44236"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.67705530),
        dec: Angle.Degrees(+47.00740626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109633"},
        {"Smithsonian Astrophysical Observation", "SAO 51764"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.13344477),
        dec: Angle.Degrees(+47.01107192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221573"},
        {"Hipparcos Number", "HIP 116222"},
        {"Geneva Identification System", "GEN# +1.00221573"},
        {"Smithsonian Astrophysical Observation", "SAO 53136"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.22317593),
        dec: Angle.Degrees(+47.01233937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91702"},
        {"Geneva Identification System", "GEN# +0.04602536"},
        {"Smithsonian Astrophysical Observation", "SAO 47719"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.51900349),
        dec: Angle.Degrees(+47.01602334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87612"},
        {"Smithsonian Astrophysical Observation", "SAO 47044"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.46710109),
        dec: Angle.Degrees(+47.01623488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -162.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53013",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53013"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.68788224),
        dec: Angle.Degrees(+47.01631654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217713"},
        {"Hipparcos Number", "HIP 113731"},
        {"Smithsonian Astrophysical Observation", "SAO 52612"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.49331868),
        dec: Angle.Degrees(+47.01661998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200478"},
        {"Hipparcos Number", "HIP 103796"},
        {"Geneva Identification System", "GEN# +1.00200478"},
        {"Smithsonian Astrophysical Observation", "SAO 50373"},
        {"Wilson Evans Batten Catalogue", "WEB 18890"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.48915232),
        dec: Angle.Degrees(+47.01941870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21046"},
        {"Hipparcos Number", "HIP 15971"},
        {"Smithsonian Astrophysical Observation", "SAO 38814"},
        {"Wilson Evans Batten Catalogue", "WEB 3048"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.40682862),
        dec: Angle.Degrees(+47.02070272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157907"},
        {"Hipparcos Number", "HIP 85123"},
        {"Geneva Identification System", "GEN# +1.00157907"},
        {"Smithsonian Astrophysical Observation", "SAO 46692"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.95338189),
        dec: Angle.Degrees(+47.02131077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25184",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3948 A"},
        {"Henry Draper", "HD 34903"},
        {"Hipparcos Number", "HIP 25184"},
        {"Smithsonian Astrophysical Observation", "SAO 40294"},
        {"Wilson Evans Batten Catalogue", "WEB 4879"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.80255835),
        dec: Angle.Degrees(+47.02164447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15970"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.40288466),
        dec: Angle.Degrees(+47.02355470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4058"},
        {"Hipparcos Number", "HIP 3414"},
        {"Geneva Identification System", "GEN# +1.00004058"},
        {"Renson", "Renson 1120"},
        {"Smithsonian Astrophysical Observation", "SAO 36602"},
        {"Wilson Evans Batten Catalogue", "WEB 603"},
    },
    visualMagnitude: 4.95,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.86704470),
        dec: Angle.Degrees(+47.02463657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15410",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2454 AB"},
        {"Henry Draper", "HD 20400"},
        {"Hipparcos Number", "HIP 15410"},
        {"Smithsonian Astrophysical Observation", "SAO 38712"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.66911445),
        dec: Angle.Degrees(+47.02553506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183612"},
        {"Hipparcos Number", "HIP 95725"},
        {"Geneva Identification System", "GEN# +1.00183612"},
        {"Smithsonian Astrophysical Observation", "SAO 48488"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.05438146),
        dec: Angle.Degrees(+47.02630924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188209"},
        {"Hipparcos Number", "HIP 97757"},
        {"Celescope Catalog", "CEL 4863"},
        {"Fundamental Katalog 5th Edition", "FK5 3588"},
        {"Geneva Identification System", "GEN# +1.00188209"},
        {"Smithsonian Astrophysical Observation", "SAO 48917"},
        {"Wilson Evans Batten Catalogue", "WEB 17196"},
    },
    visualMagnitude: 5.60,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.99613200),
        dec: Angle.Degrees(+47.02734867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16737"},
        {"Hipparcos Number", "HIP 12652"},
        {"Geneva Identification System", "GEN# +1.00016737"},
        {"Smithsonian Astrophysical Observation", "SAO 38261"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.63138302),
        dec: Angle.Degrees(+47.02984978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53948"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.57164329),
        dec: Angle.Degrees(+47.03039165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215039"},
        {"Hipparcos Number", "HIP 112045"},
        {"Smithsonian Astrophysical Observation", "SAO 52276"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.41373054),
        dec: Angle.Degrees(+47.03254910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30006"},
        {"Geneva Identification System", "GEN# +0.04701284"},
        {"Smithsonian Astrophysical Observation", "SAO 41015"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.73463447),
        dec: Angle.Degrees(+47.03336214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69348"},
        {"Hipparcos Number", "HIP 40709"},
        {"Geneva Identification System", "GEN# +1.00069348"},
        {"Smithsonian Astrophysical Observation", "SAO 42281"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.64564463),
        dec: Angle.Degrees(+47.03410154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178797"},
        {"Hipparcos Number", "HIP 93946"},
        {"Smithsonian Astrophysical Observation", "SAO 48115"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.93243039),
        dec: Angle.Degrees(+47.03579067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5638"},
        {"Hipparcos Number", "HIP 4584"},
        {"Celescope Catalog", "CEL 102"},
        {"Geneva Identification System", "GEN# +1.00005638"},
        {"Smithsonian Astrophysical Observation", "SAO 36817"},
        {"Wilson Evans Batten Catalogue", "WEB 841"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.67957818),
        dec: Angle.Degrees(+47.03660631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87641"},
        {"Geneva Identification System", "GEN# +0.04702555"},
        {"Renson", "Renson 46240"},
        {"Smithsonian Astrophysical Observation", "SAO 47049"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.53072856),
        dec: Angle.Degrees(+47.03712419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9227"},
        {"Smithsonian Astrophysical Observation", "SAO 37669"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.64884799),
        dec: Angle.Degrees(+47.03955168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61722"},
    },
    visualMagnitude: 12.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.76820008),
        dec: Angle.Degrees(+47.04002676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 386.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146638"},
        {"Hipparcos Number", "HIP 79647"},
        {"Smithsonian Astrophysical Observation", "SAO 45993"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.79964841),
        dec: Angle.Degrees(+47.04004906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64267"},
        {"Smithsonian Astrophysical Observation", "SAO 44494"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.58479558),
        dec: Angle.Degrees(+47.04108846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5377"},
        {"Smithsonian Astrophysical Observation", "SAO 36961"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.19540327),
        dec: Angle.Degrees(+47.04333514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214859"},
        {"Hipparcos Number", "HIP 111927"},
        {"Smithsonian Astrophysical Observation", "SAO 52250"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.08094243),
        dec: Angle.Degrees(+47.04724438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4900",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4900"},
        {"Wilson Evans Batten Catalogue", "WEB 969"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.71822517),
        dec: Angle.Degrees(+47.04761136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 396.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106420"},
        {"Hipparcos Number", "HIP 59685"},
        {"Geneva Identification System", "GEN# +1.00106420"},
        {"Smithsonian Astrophysical Observation", "SAO 44088"},
        {"Wilson Evans Batten Catalogue", "WEB 10607"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.59181090),
        dec: Angle.Degrees(+47.04808810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34248"},
        {"Hipparcos Number", "HIP 24748"},
        {"Geneva Identification System", "GEN# +1.00034248"},
        {"Smithsonian Astrophysical Observation", "SAO 40213"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.60127028),
        dec: Angle.Degrees(+47.04819108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52552"},
        {"Hipparcos Number", "HIP 34070"},
        {"Geneva Identification System", "GEN# +1.00052552"},
        {"Smithsonian Astrophysical Observation", "SAO 41531"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.99609731),
        dec: Angle.Degrees(+47.04993240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102767"},
        {"Geneva Identification System", "GEN# +0.04603062"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.31851336),
        dec: Angle.Degrees(+47.05139014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90060",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90060"},
        {"Geneva Identification System", "GEN# +0.04602473"},
        {"Smithsonian Astrophysical Observation", "SAO 47440"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.67957829),
        dec: Angle.Degrees(+47.05395127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57810"},
        {"Smithsonian Astrophysical Observation", "SAO 43913"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.80546319),
        dec: Angle.Degrees(+47.05755148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76042"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.94451544),
        dec: Angle.Degrees(+47.05756049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 155.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -297.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86932"},
        {"Smithsonian Astrophysical Observation", "SAO 46938"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.43783391),
        dec: Angle.Degrees(+47.05812342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27858"},
        {"Hipparcos Number", "HIP 20689"},
        {"Smithsonian Astrophysical Observation", "SAO 39525"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.47107266),
        dec: Angle.Degrees(+47.05847509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214781"},
        {"Hipparcos Number", "HIP 111877"},
        {"Fundamental Katalog 5th Edition", "FK5 5999"},
        {"Geneva Identification System", "GEN# +1.00214781"},
        {"Smithsonian Astrophysical Observation", "SAO 52240"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.92044111),
        dec: Angle.Degrees(+47.05923960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50876"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.82586318),
        dec: Angle.Degrees(+47.06015702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8043"},
        {"Hipparcos Number", "HIP 6294"},
        {"Geneva Identification System", "GEN# +1.00008043"},
        {"Renson", "Renson 1984"},
        {"Smithsonian Astrophysical Observation", "SAO 37137"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.19728573),
        dec: Angle.Degrees(+47.06050961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184216"},
        {"Hipparcos Number", "HIP 96006"},
        {"Geneva Identification System", "GEN# +1.00184216"},
        {"Smithsonian Astrophysical Observation", "SAO 48547"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.81094386),
        dec: Angle.Degrees(+47.06080444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137629"},
        {"Hipparcos Number", "HIP 75479"},
        {"Geneva Identification System", "GEN# +1.00137629"},
        {"Smithsonian Astrophysical Observation", "SAO 45529"},
        {"Wilson Evans Batten Catalogue", "WEB 12869"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.28355577),
        dec: Angle.Degrees(+47.06090607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180867"},
        {"Hipparcos Number", "HIP 94675"},
        {"Geneva Identification System", "GEN# +1.00180867"},
        {"Smithsonian Astrophysical Observation", "SAO 48258"},
        {"Wilson Evans Batten Catalogue", "WEB 16508"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.97780824),
        dec: Angle.Degrees(+47.06125032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29814"},
        {"Cincinnati Publication", "Ci 20 380"},
        {"Geneva Identification System", "GEN# +0.04701276A"},
        {"Smithsonian Astrophysical Observation", "SAO 40986"},
        {"Wilson Evans Batten Catalogue", "WEB 5894"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.17878597),
        dec: Angle.Degrees(+47.06154420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -493.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21540"},
        {"Hipparcos Number", "HIP 16326"},
        {"Geneva Identification System", "GEN# +5.20200903"},
        {"Smithsonian Astrophysical Observation", "SAO 38887"},
        {"Wilson Evans Batten Catalogue", "WEB 3117"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.61241071),
        dec: Angle.Degrees(+47.06329470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222630"},
        {"Hipparcos Number", "HIP 116931"},
        {"Smithsonian Astrophysical Observation", "SAO 53290"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.53713589),
        dec: Angle.Degrees(+47.06340356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48363"},
        {"Hipparcos Number", "HIP 32373"},
        {"Geneva Identification System", "GEN# +1.00048363"},
        {"Smithsonian Astrophysical Observation", "SAO 41313"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.35479739),
        dec: Angle.Degrees(+47.06709147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213944"},
        {"Hipparcos Number", "HIP 111402"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.53371313),
        dec: Angle.Degrees(+47.07119777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37237"},
        {"Smithsonian Astrophysical Observation", "SAO 41905"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.72111429),
        dec: Angle.Degrees(+47.07387534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20459"},
        {"Geneva Identification System", "GEN# +0.04600873"},
        {"Smithsonian Astrophysical Observation", "SAO 39497"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.75496760),
        dec: Angle.Degrees(+47.07501337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117400",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117400"},
    },
    visualMagnitude: 10.90,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.06345496),
        dec: Angle.Degrees(+47.07520081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154345"},
        {"Hipparcos Number", "HIP 83389"},
        {"Cincinnati Publication", "Ci 20 1015"},
        {"Cincinnati Publication 2", "Ci 18 2277"},
        {"Geneva Identification System", "GEN# +1.00154345"},
        {"Smithsonian Astrophysical Observation", "SAO 46452"},
        {"Wilson Evans Batten Catalogue", "WEB 14095"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.65124140),
        dec: Angle.Degrees(+47.07980407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 854.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117397"},
        {"Smithsonian Astrophysical Observation", "SAO 53386"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.05524903),
        dec: Angle.Degrees(+47.08336318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2254"},
        {"Hipparcos Number", "HIP 2103"},
        {"Smithsonian Astrophysical Observation", "SAO 36370"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.66803133),
        dec: Angle.Degrees(+47.08384041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8663",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1469 AB"},
        {"Henry Draper", "HD 11252"},
        {"Hipparcos Number", "HIP 8663"},
        {"Smithsonian Astrophysical Observation", "SAO 37562"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.90563150),
        dec: Angle.Degrees(+47.08667089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117572",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17039 AB"},
        {"Hipparcos Number", "HIP 117572"},
        {"Geneva Identification System", "GEN# +0.04604185J"},
        {"Smithsonian Astrophysical Observation", "SAO 53414"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.64978651),
        dec: Angle.Degrees(+47.08715419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83"},
        {"Hipparcos Number", "HIP 485"},
        {"Smithsonian Astrophysical Observation", "SAO 36051"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.44777978),
        dec: Angle.Degrees(+47.08729369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94701"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.04953019),
        dec: Angle.Degrees(+47.08741186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205600"},
        {"Hipparcos Number", "HIP 106571"},
        {"Celescope Catalog", "CEL 5344"},
        {"Geneva Identification System", "GEN# +1.00205600"},
        {"Smithsonian Astrophysical Observation", "SAO 51057"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.75176769),
        dec: Angle.Degrees(+47.08991297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189013"},
        {"Hipparcos Number", "HIP 98071"},
        {"Celescope Catalog", "CEL 4880"},
        {"Geneva Identification System", "GEN# +1.00189013"},
        {"Smithsonian Astrophysical Observation", "SAO 48993"},
        {"Wilson Evans Batten Catalogue", "WEB 17283"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.97523474),
        dec: Angle.Degrees(+47.09007651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22136"},
        {"Hipparcos Number", "HIP 16782"},
        {"Geneva Identification System", "GEN# +5.20201153"},
        {"Renson", "Renson 5570"},
        {"Smithsonian Astrophysical Observation", "SAO 38971"},
        {"Wilson Evans Batten Catalogue", "WEB 3192"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.99362928),
        dec: Angle.Degrees(+47.09109076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16927"},
        {"Geneva Identification System", "GEN# +5.20201247"},
        {"Smithsonian Astrophysical Observation", "SAO 38995"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.46038905),
        dec: Angle.Degrees(+47.09427489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11884"},
        {"Hipparcos Number", "HIP 9163"},
        {"Geneva Identification System", "GEN# +1.00011884"},
        {"Smithsonian Astrophysical Observation", "SAO 37648"},
        {"Wilson Evans Batten Catalogue", "WEB 1925"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.49679170),
        dec: Angle.Degrees(+47.09553693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210820"},
        {"Hipparcos Number", "HIP 109591"},
        {"Celescope Catalog", "CEL 5454"},
        {"Geneva Identification System", "GEN# +1.00210820"},
        {"Smithsonian Astrophysical Observation", "SAO 51750"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.00746093),
        dec: Angle.Degrees(+47.09561859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39464"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.99272243),
        dec: Angle.Degrees(+47.09699815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34366"},
        {"Smithsonian Astrophysical Observation", "SAO 41567"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.85127993),
        dec: Angle.Degrees(+47.09769048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5049"},
        {"Hipparcos Number", "HIP 4139"},
        {"Smithsonian Astrophysical Observation", "SAO 36740"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.23458178),
        dec: Angle.Degrees(+47.09857730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24011"},
        {"Hipparcos Number", "HIP 18062"},
        {"Geneva Identification System", "GEN# +1.00024011"},
        {"Smithsonian Astrophysical Observation", "SAO 39154"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.90984046),
        dec: Angle.Degrees(+47.09900336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218949"},
        {"Hipparcos Number", "HIP 114512"},
        {"Fundamental Katalog 5th Edition", "FK5 6049"},
        {"Geneva Identification System", "GEN# +1.00218949"},
        {"Smithsonian Astrophysical Observation", "SAO 52780"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.91226657),
        dec: Angle.Degrees(+47.09909723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212713"},
        {"Hipparcos Number", "HIP 110684"},
        {"Geneva Identification System", "GEN# +1.00212713"},
        {"Smithsonian Astrophysical Observation", "SAO 51979"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.35667536),
        dec: Angle.Degrees(+47.10348331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195392"},
        {"Hipparcos Number", "HIP 101058"},
        {"Geneva Identification System", "GEN# +1.00195392"},
        {"Smithsonian Astrophysical Observation", "SAO 49690"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.29609230),
        dec: Angle.Degrees(+47.10485381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40995"},
        {"Hipparcos Number", "HIP 28797"},
        {"Geneva Identification System", "GEN# +1.00040995"},
        {"Smithsonian Astrophysical Observation", "SAO 40836"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.19591571),
        dec: Angle.Degrees(+47.10521641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83503"},
        {"Smithsonian Astrophysical Observation", "SAO 46466"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.99017476),
        dec: Angle.Degrees(+47.10697884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 98.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74628"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.72187837),
        dec: Angle.Degrees(+47.10762699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152172"},
        {"Hipparcos Number", "HIP 82344"},
        {"Geneva Identification System", "GEN# +1.00152172"},
        {"Smithsonian Astrophysical Observation", "SAO 46310"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.38014086),
        dec: Angle.Degrees(+47.10799107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52001"},
        {"Hipparcos Number", "HIP 33876"},
        {"Smithsonian Astrophysical Observation", "SAO 41505"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.48310395),
        dec: Angle.Degrees(+47.10856117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18768"},
        {"Hipparcos Number", "HIP 14181"},
        {"Geneva Identification System", "GEN# +1.00018768"},
        {"Smithsonian Astrophysical Observation", "SAO 38527"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.71755954),
        dec: Angle.Degrees(+47.11069746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198182"},
        {"Hipparcos Number", "HIP 102551"},
        {"Smithsonian Astrophysical Observation", "SAO 50054"},
        {"Wilson Evans Batten Catalogue", "WEB 18581"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.72101546),
        dec: Angle.Degrees(+47.11148147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13322"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.86789182),
        dec: Angle.Degrees(+47.11288419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171726"},
        {"Hipparcos Number", "HIP 91022"},
        {"Geneva Identification System", "GEN# +1.00171726"},
        {"Smithsonian Astrophysical Observation", "SAO 47606"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.52382238),
        dec: Angle.Degrees(+47.11314872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104989"},
        {"Smithsonian Astrophysical Observation", "SAO 50641"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.96672929),
        dec: Angle.Degrees(+47.11432733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9709"},
        {"Hipparcos Number", "HIP 7457"},
        {"Geneva Identification System", "GEN# +1.00009709"},
        {"Smithsonian Astrophysical Observation", "SAO 37345"},
        {"Wilson Evans Batten Catalogue", "WEB 1597"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.01278639),
        dec: Angle.Degrees(+47.11449716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77891"},
        {"Hipparcos Number", "HIP 44727"},
        {"Smithsonian Astrophysical Observation", "SAO 42695"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.71081661),
        dec: Angle.Degrees(+47.11495242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -306.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106556"},
        {"Hipparcos Number", "HIP 59760"},
        {"Geneva Identification System", "GEN# +1.00106556"},
        {"Smithsonian Astrophysical Observation", "SAO 44092"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.81513889),
        dec: Angle.Degrees(+47.11552861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143467"},
        {"Hipparcos Number", "HIP 78220"},
        {"Geneva Identification System", "GEN# +1.00143467"},
        {"Smithsonian Astrophysical Observation", "SAO 45814"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.59815250),
        dec: Angle.Degrees(+47.11756834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192179"},
        {"Hipparcos Number", "HIP 99502"},
        {"Geneva Identification System", "GEN# +1.00192179"},
        {"Smithsonian Astrophysical Observation", "SAO 49302"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.89973718),
        dec: Angle.Degrees(+47.11842638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8583"},
        {"Hipparcos Number", "HIP 6680"},
        {"Geneva Identification System", "GEN# +1.00008583"},
        {"Smithsonian Astrophysical Observation", "SAO 37195"},
        {"Wilson Evans Batten Catalogue", "WEB 1458"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.42018352),
        dec: Angle.Degrees(+47.11853284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166559"},
        {"Hipparcos Number", "HIP 88894"},
        {"Smithsonian Astrophysical Observation", "SAO 47260"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.21065920),
        dec: Angle.Degrees(+47.11978041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43794"},
        {"Hipparcos Number", "HIP 30138"},
        {"Smithsonian Astrophysical Observation", "SAO 41031"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.13990861),
        dec: Angle.Degrees(+47.12029309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72963"},
        {"Hipparcos Number", "HIP 42301"},
        {"Geneva Identification System", "GEN# +1.00072963"},
        {"Smithsonian Astrophysical Observation", "SAO 42454"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.37336484),
        dec: Angle.Degrees(+47.12041238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44494"},
        {"Hipparcos Number", "HIP 30488"},
        {"Geneva Identification System", "GEN# +1.00044494"},
        {"Smithsonian Astrophysical Observation", "SAO 41071"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.13045432),
        dec: Angle.Degrees(+47.12094327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26706"},
        {"Geneva Identification System", "GEN# +0.04701184"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.12962603),
        dec: Angle.Degrees(+47.12266996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2836"},
        {"Hipparcos Number", "HIP 2535"},
        {"Smithsonian Astrophysical Observation", "SAO 36449"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.04108986),
        dec: Angle.Degrees(+47.12285603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111152"},
        {"Smithsonian Astrophysical Observation", "SAO 52098"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.78605515),
        dec: Angle.Degrees(+47.12308197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59810"},
        {"Smithsonian Astrophysical Observation", "SAO 44095"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.97957615),
        dec: Angle.Degrees(+47.12704358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12718",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12718"},
        {"Geneva Identification System", "GEN# +0.04600616"},
        {"Smithsonian Astrophysical Observation", "SAO 38277"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.86211878),
        dec: Angle.Degrees(+47.12796364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87001"},
        {"Hipparcos Number", "HIP 49266"},
        {"Smithsonian Astrophysical Observation", "SAO 43159"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.85045383),
        dec: Angle.Degrees(+47.12838813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62628"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.49606794),
        dec: Angle.Degrees(+47.13087030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -311.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39413"},
        {"Hipparcos Number", "HIP 27946"},
        {"Smithsonian Astrophysical Observation", "SAO 40690"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.70851301),
        dec: Angle.Degrees(+47.13092366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107193"},
        {"Geneva Identification System", "GEN# +0.04603410"},
        {"Smithsonian Astrophysical Observation", "SAO 51218"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.68044712),
        dec: Angle.Degrees(+47.13137423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39917",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39917"},
        {"Smithsonian Astrophysical Observation", "SAO 42195"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.28909313),
        dec: Angle.Degrees(+47.13185348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63456"},
        {"Hipparcos Number", "HIP 38330"},
        {"Geneva Identification System", "GEN# +1.00063456"},
        {"Smithsonian Astrophysical Observation", "SAO 42032"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.77595179),
        dec: Angle.Degrees(+47.13421319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41815",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41815"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.87748673),
        dec: Angle.Degrees(+47.13562439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215225"},
        {"Hipparcos Number", "HIP 112150"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.74062287),
        dec: Angle.Degrees(+47.13573732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56245"},
        {"Hipparcos Number", "HIP 35402"},
        {"Geneva Identification System", "GEN# +1.00056245"},
        {"Smithsonian Astrophysical Observation", "SAO 41684"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.65434255),
        dec: Angle.Degrees(+47.13649148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207952"},
        {"Hipparcos Number", "HIP 107900"},
        {"Smithsonian Astrophysical Observation", "SAO 51374"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.92341322),
        dec: Angle.Degrees(+47.13708445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72392"},
        {"Hipparcos Number", "HIP 42072"},
        {"Geneva Identification System", "GEN# +1.00072392"},
        {"Smithsonian Astrophysical Observation", "SAO 42433"},
        {"Wilson Evans Batten Catalogue", "WEB 8088"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.62402299),
        dec: Angle.Degrees(+47.13962047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115809"},
        {"Hipparcos Number", "HIP 64950"},
        {"Geneva Identification System", "GEN# +1.00115809"},
        {"Smithsonian Astrophysical Observation", "SAO 44562"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.69854258),
        dec: Angle.Degrees(+47.14033573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109463"},
        {"Smithsonian Astrophysical Observation", "SAO 51727"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.63550954),
        dec: Angle.Degrees(+47.14056533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105237"},
        {"Hipparcos Number", "HIP 59083"},
        {"Geneva Identification System", "GEN# +1.00105237"},
        {"Smithsonian Astrophysical Observation", "SAO 44034"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.74806722),
        dec: Angle.Degrees(+47.14237958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17456"},
        {"Hipparcos Number", "HIP 13181"},
        {"Smithsonian Astrophysical Observation", "SAO 38369"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.39615383),
        dec: Angle.Degrees(+47.14255282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144002"},
        {"Hipparcos Number", "HIP 78502"},
        {"Smithsonian Astrophysical Observation", "SAO 45850"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.38600225),
        dec: Angle.Degrees(+47.14260446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191374"},
        {"Hipparcos Number", "HIP 99134"},
        {"Geneva Identification System", "GEN# +1.00191374"},
        {"Smithsonian Astrophysical Observation", "SAO 49207"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.88815134),
        dec: Angle.Degrees(+47.14464003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188819"},
        {"Hipparcos Number", "HIP 97992"},
        {"Geneva Identification System", "GEN# +1.00188819"},
        {"Smithsonian Astrophysical Observation", "SAO 48972"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.72568484),
        dec: Angle.Degrees(+47.14532792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160570"},
        {"Hipparcos Number", "HIP 86328"},
        {"Geneva Identification System", "GEN# +1.00160570"},
        {"Smithsonian Astrophysical Observation", "SAO 46858"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.58600054),
        dec: Angle.Degrees(+47.14609608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37937",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37937"},
        {"Smithsonian Astrophysical Observation", "SAO 41987"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.63885212),
        dec: Angle.Degrees(+47.14634441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127263"},
        {"Hipparcos Number", "HIP 70814"},
        {"Fundamental Katalog 5th Edition", "FK5 5281"},
        {"Geneva Identification System", "GEN# +1.00127263"},
        {"Renson", "Renson 36220"},
        {"Smithsonian Astrophysical Observation", "SAO 45069"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.23162766),
        dec: Angle.Degrees(+47.15048494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112859"},
        {"Hipparcos Number", "HIP 63368"},
        {"Geneva Identification System", "GEN# +1.00112859"},
        {"Smithsonian Astrophysical Observation", "SAO 44410"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.76606122),
        dec: Angle.Degrees(+47.15140901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77929"},
        {"Hipparcos Number", "HIP 44744"},
        {"Smithsonian Astrophysical Observation", "SAO 42696"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.77358017),
        dec: Angle.Degrees(+47.15333111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20023"},
        {"Hipparcos Number", "HIP 15105"},
        {"Geneva Identification System", "GEN# +2.12450001"},
        {"Smithsonian Astrophysical Observation", "SAO 38671"},
        {"New General Catalogue", "NGC 1245 1"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.71100501),
        dec: Angle.Degrees(+47.15506018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208362"},
        {"Hipparcos Number", "HIP 108147"},
        {"Geneva Identification System", "GEN# +1.00208362"},
        {"Smithsonian Astrophysical Observation", "SAO 51425"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.65286558),
        dec: Angle.Degrees(+47.15519268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44471",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alkaphrah"},
        {"Aitken", "ADS 7158 AB"},
        {"Henry Draper", "HD 77327"},
        {"Hipparcos Number", "HIP 44471"},
        {"Fundamental Katalog 5th Edition", "FK5 341"},
        {"Geneva Identification System", "GEN# +1.00077327J"},
        {"Smithsonian Astrophysical Observation", "SAO 42661"},
        {"Wilson Evans Batten Catalogue", "WEB 8522"},
    },
    visualMagnitude: 3.57,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.90649494),
        dec: Angle.Degrees(+47.15665934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104384"},
        {"Cincinnati Publication", "Ci 20 1262"},
        {"Geneva Identification System", "GEN# +9.80212024"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.19336194),
        dec: Angle.Degrees(+47.15711509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 423.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13512",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2199 A"},
        {"Henry Draper", "HD 17891"},
        {"Hipparcos Number", "HIP 13512"},
        {"Geneva Identification System", "GEN# +1.00017891"},
        {"Smithsonian Astrophysical Observation", "SAO 38424"},
        {"Wilson Evans Batten Catalogue", "WEB 2696"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.50404067),
        dec: Angle.Degrees(+47.16092308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18155"},
        {"Hipparcos Number", "HIP 13713"},
        {"Geneva Identification System", "GEN# +1.00018155"},
        {"Smithsonian Astrophysical Observation", "SAO 38455"},
        {"Wilson Evans Batten Catalogue", "WEB 2719"},
    },
    visualMagnitude: 6.05,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.13876856),
        dec: Angle.Degrees(+47.16400397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69690"},
        {"Smithsonian Astrophysical Observation", "SAO 44962"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.98102948),
        dec: Angle.Degrees(+47.16407254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14944 AB"},
        {"Henry Draper", "HD 203938"},
        {"Hipparcos Number", "HIP 105640"},
        {"Geneva Identification System", "GEN# +1.00203938J"},
        {"Smithsonian Astrophysical Observation", "SAO 50792"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.95907285),
        dec: Angle.Degrees(+47.16456289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196090"},
        {"Hipparcos Number", "HIP 101423"},
        {"Geneva Identification System", "GEN# +1.00196090"},
        {"Smithsonian Astrophysical Observation", "SAO 49786"},
        {"Wilson Evans Batten Catalogue", "WEB 18324"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.30986660),
        dec: Angle.Degrees(+47.16591599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112170",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16214 ABC"},
        {"Henry Draper", "HD 215242"},
        {"Hipparcos Number", "HIP 112170"},
        {"Geneva Identification System", "GEN# +1.00215242"},
        {"Smithsonian Astrophysical Observation", "SAO 52296"},
        {"Wilson Evans Batten Catalogue", "WEB 20019"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.76798825),
        dec: Angle.Degrees(+47.16876137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8507"},
        {"Hipparcos Number", "HIP 6617"},
        {"Geneva Identification System", "GEN# +1.00008507"},
        {"Smithsonian Astrophysical Observation", "SAO 37181"},
        {"Wilson Evans Batten Catalogue", "WEB 1448"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.24289728),
        dec: Angle.Degrees(+47.16890307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24488",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3812 AB"},
        {"Henry Draper", "HD 33798"},
        {"Hipparcos Number", "HIP 24488"},
        {"Smithsonian Astrophysical Observation", "SAO 40158"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.81407723),
        dec: Angle.Degrees(+47.17098693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104674"},
        {"Hipparcos Number", "HIP 58768"},
        {"Smithsonian Astrophysical Observation", "SAO 44012"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.79935599),
        dec: Angle.Degrees(+47.17142169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110969",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110969"},
        {"Geneva Identification System", "GEN# +0.04603717"},
        {"Smithsonian Astrophysical Observation", "SAO 52050"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.24627700),
        dec: Angle.Degrees(+47.17152418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204906"},
        {"Hipparcos Number", "HIP 106168"},
        {"Geneva Identification System", "GEN# +1.00204906"},
        {"Smithsonian Astrophysical Observation", "SAO 50947"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.57525647),
        dec: Angle.Degrees(+47.17194939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92840"},
        {"Hipparcos Number", "HIP 52497"},
        {"Geneva Identification System", "GEN# +1.00092840"},
        {"Smithsonian Astrophysical Observation", "SAO 43448"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.00173117),
        dec: Angle.Degrees(+47.17266787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70592"},
        {"Hipparcos Number", "HIP 41227"},
        {"Smithsonian Astrophysical Observation", "SAO 42340"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.19053340),
        dec: Angle.Degrees(+47.17267562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50039"},
        {"Smithsonian Astrophysical Observation", "SAO 43236"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.24721274),
        dec: Angle.Degrees(+47.17566142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157775"},
        {"Hipparcos Number", "HIP 85052"},
        {"Geneva Identification System", "GEN# +1.00157775"},
        {"Smithsonian Astrophysical Observation", "SAO 46681"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.73398124),
        dec: Angle.Degrees(+47.17657117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68014"},
        {"Hipparcos Number", "HIP 40212"},
        {"Smithsonian Astrophysical Observation", "SAO 42226"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.19250894),
        dec: Angle.Degrees(+47.17665371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10881"},
        {"Hipparcos Number", "HIP 8376"},
        {"Geneva Identification System", "GEN# +1.00010881"},
        {"Smithsonian Astrophysical Observation", "SAO 37516"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.98350007),
        dec: Angle.Degrees(+47.17701709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107852",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15382 AB"},
        {"Henry Draper", "HD 207886"},
        {"Hipparcos Number", "HIP 107852"},
        {"Renson", "Renson 57810"},
        {"Smithsonian Astrophysical Observation", "SAO 51368"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.76596857),
        dec: Angle.Degrees(+47.17799997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108087"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.48408807),
        dec: Angle.Degrees(+47.17926010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102173"},
        {"Geneva Identification System", "GEN# +0.04603014"},
        {"Smithsonian Astrophysical Observation", "SAO 49958"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.54305268),
        dec: Angle.Degrees(+47.17936252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117935",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17100 AB"},
        {"Hipparcos Number", "HIP 117935"},
        {"Smithsonian Astrophysical Observation", "SAO 53481"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.84108584),
        dec: Angle.Degrees(+47.17958873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215772"},
        {"Hipparcos Number", "HIP 112474"},
        {"Geneva Identification System", "GEN# +1.00215772"},
        {"Smithsonian Astrophysical Observation", "SAO 52359"},
        {"Wilson Evans Batten Catalogue", "WEB 20056"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.72911045),
        dec: Angle.Degrees(+47.18140090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94758"},
        {"Smithsonian Astrophysical Observation", "SAO 48280"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.21805324),
        dec: Angle.Degrees(+47.18224347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107610"},
        {"Hipparcos Number", "HIP 60305"},
        {"Fundamental Katalog 5th Edition", "FK5 2991"},
        {"Geneva Identification System", "GEN# +1.00107610"},
        {"Smithsonian Astrophysical Observation", "SAO 44141"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.48457714),
        dec: Angle.Degrees(+47.18225964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67450",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67450"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.34776993),
        dec: Angle.Degrees(+47.18357133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113337",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113337"},
        {"Geneva Identification System", "GEN# +0.04603884"},
        {"Renson", "Renson 59910"},
        {"Smithsonian Astrophysical Observation", "SAO 52527"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.28677850),
        dec: Angle.Degrees(+47.18549332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69085",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69085"},
        {"Smithsonian Astrophysical Observation", "SAO 44906"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.10697398),
        dec: Angle.Degrees(+47.18601044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65276"},
        {"Smithsonian Astrophysical Observation", "SAO 44586"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.68354858),
        dec: Angle.Degrees(+47.18687120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100432"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.48896366),
        dec: Angle.Degrees(+47.19047314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81740"},
        {"Hipparcos Number", "HIP 46497"},
        {"Geneva Identification System", "GEN# +1.00081740"},
        {"Smithsonian Astrophysical Observation", "SAO 42880"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.24686090),
        dec: Angle.Degrees(+47.19134518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93108",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11899 AB"},
        {"Henry Draper", "HD 176465"},
        {"Hipparcos Number", "HIP 93108"},
        {"Smithsonian Astrophysical Observation", "SAO 47960"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.51468050),
        dec: Angle.Degrees(+47.19184461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36157"},
        {"Hipparcos Number", "HIP 25941"},
        {"Celescope Catalog", "CEL 747"},
        {"Geneva Identification System", "GEN# +1.00036157"},
        {"Smithsonian Astrophysical Observation", "SAO 40398"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.04193952),
        dec: Angle.Degrees(+47.19274865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 904"},
        {"Hipparcos Number", "HIP 1090"},
        {"Geneva Identification System", "GEN# +1.00000904"},
        {"Smithsonian Astrophysical Observation", "SAO 36176"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.40403325),
        dec: Angle.Degrees(+47.19327100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220654"},
        {"Hipparcos Number", "HIP 115608"},
        {"Geneva Identification System", "GEN# +1.00220654"},
        {"Smithsonian Astrophysical Observation", "SAO 52995"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.29012290),
        dec: Angle.Degrees(+47.19450423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30377"},
        {"Hipparcos Number", "HIP 22413"},
        {"Smithsonian Astrophysical Observation", "SAO 39777"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.35499783),
        dec: Angle.Degrees(+47.19474005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48401"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.01827087),
        dec: Angle.Degrees(+47.19523788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7189"},
        {"Hipparcos Number", "HIP 5677"},
        {"Geneva Identification System", "GEN# +1.00007189"},
        {"Smithsonian Astrophysical Observation", "SAO 37024"},
        {"Wilson Evans Batten Catalogue", "WEB 1289"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.24008334),
        dec: Angle.Degrees(+47.19529285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95295",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12397 A"},
        {"Henry Draper", "HD 182614"},
        {"Hipparcos Number", "HIP 95295"},
        {"Smithsonian Astrophysical Observation", "SAO 48391"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.81178477),
        dec: Angle.Degrees(+47.19583467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199596"},
        {"Hipparcos Number", "HIP 103373"},
        {"Geneva Identification System", "GEN# +1.00199596"},
        {"Smithsonian Astrophysical Observation", "SAO 50264"},
        {"Wilson Evans Batten Catalogue", "WEB 18794"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.15367487),
        dec: Angle.Degrees(+47.19585291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112264"},
        {"Hipparcos Number", "HIP 63024"},
        {"Fundamental Katalog 5th Edition", "FK5 3030"},
        {"Geneva Identification System", "GEN# +1.00112264"},
        {"Smithsonian Astrophysical Observation", "SAO 44383"},
        {"Wilson Evans Batten Catalogue", "WEB 11175"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.73556688),
        dec: Angle.Degrees(+47.19673771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13501"},
        {"Smithsonian Astrophysical Observation", "SAO 38423"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.46850450),
        dec: Angle.Degrees(+47.19695545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138213"},
        {"Hipparcos Number", "HIP 75770"},
        {"Geneva Identification System", "GEN# +1.00138213"},
        {"Renson", "Renson 39360"},
        {"Smithsonian Astrophysical Observation", "SAO 45562"},
        {"Wilson Evans Batten Catalogue", "WEB 12899"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.18504295),
        dec: Angle.Degrees(+47.20150189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215547"},
        {"Hipparcos Number", "HIP 112339"},
        {"Geneva Identification System", "GEN# +1.00215547"},
        {"Smithsonian Astrophysical Observation", "SAO 52334"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.31604417),
        dec: Angle.Degrees(+47.20378914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33022",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5525 AB"},
        {"Henry Draper", "HD 49858"},
        {"Hipparcos Number", "HIP 33022"},
        {"Smithsonian Astrophysical Observation", "SAO 41402"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.20173449),
        dec: Angle.Degrees(+47.20527649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200369"},
        {"Hipparcos Number", "HIP 103753"},
        {"Geneva Identification System", "GEN# +1.00200369"},
        {"Renson", "Renson 55820"},
        {"Smithsonian Astrophysical Observation", "SAO 50364"},
        {"Wilson Evans Batten Catalogue", "WEB 18882"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.36678780),
        dec: Angle.Degrees(+47.20554009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204003"},
        {"Hipparcos Number", "HIP 105670"},
        {"Geneva Identification System", "GEN# +1.00204003"},
        {"Smithsonian Astrophysical Observation", "SAO 50801"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.05081378),
        dec: Angle.Degrees(+47.20649341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116766"},
        {"Geneva Identification System", "GEN# +0.04604117"},
        {"Smithsonian Astrophysical Observation", "SAO 53253"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.97077412),
        dec: Angle.Degrees(+47.20717431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65339",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65339"},
        {"Geneva Identification System", "GEN# +0.04702056"},
        {"Smithsonian Astrophysical Observation", "SAO 44594"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.88060404),
        dec: Angle.Degrees(+47.20851605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186514"},
        {"Hipparcos Number", "HIP 96982"},
        {"Geneva Identification System", "GEN# +1.00186514"},
        {"Smithsonian Astrophysical Observation", "SAO 48759"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.69822272),
        dec: Angle.Degrees(+47.20892599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13323"},
        {"Hipparcos Number", "HIP 10230"},
        {"Geneva Identification System", "GEN# +1.00013323"},
        {"Smithsonian Astrophysical Observation", "SAO 37844"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.88262272),
        dec: Angle.Degrees(+47.20910625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3327"},
        {"Smithsonian Astrophysical Observation", "SAO 36589"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.60005266),
        dec: Angle.Degrees(+47.21119523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52505",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52505"},
        {"Smithsonian Astrophysical Observation", "SAO 43452"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.03995797),
        dec: Angle.Degrees(+47.21458435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109611",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109611"},
        {"Smithsonian Astrophysical Observation", "SAO 51756"},
    },
    visualMagnitude: 9.58,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.06845935),
        dec: Angle.Degrees(+47.21485870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17412"},
        {"Hipparcos Number", "HIP 13155"},
        {"Smithsonian Astrophysical Observation", "SAO 38357"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.29446140),
        dec: Angle.Degrees(+47.21799868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12492"},
        {"Geneva Identification System", "GEN# +0.04600603"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.17693256),
        dec: Angle.Degrees(+47.21805816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46014"},
        {"Hipparcos Number", "HIP 31255"},
        {"Smithsonian Astrophysical Observation", "SAO 41173"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.33175656),
        dec: Angle.Degrees(+47.21839202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214198"},
        {"Hipparcos Number", "HIP 111540"},
        {"Geneva Identification System", "GEN# +1.00214198"},
        {"Smithsonian Astrophysical Observation", "SAO 52169"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.95529514),
        dec: Angle.Degrees(+47.21985204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18474"},
        {"Hipparcos Number", "HIP 13965"},
        {"Geneva Identification System", "GEN# +1.00018474"},
        {"Smithsonian Astrophysical Observation", "SAO 38493"},
        {"Wilson Evans Batten Catalogue", "WEB 2756"},
    },
    visualMagnitude: 5.47,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.95742747),
        dec: Angle.Degrees(+47.22063875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167763"},
        {"Hipparcos Number", "HIP 89374"},
        {"Geneva Identification System", "GEN# +1.00167763"},
        {"Smithsonian Astrophysical Observation", "SAO 47332"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.58194621),
        dec: Angle.Degrees(+47.22064302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15428"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.71676583),
        dec: Angle.Degrees(+47.22432039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19107",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2971 A"},
        {"Henry Draper", "HD 25568"},
        {"Hipparcos Number", "HIP 19107"},
        {"Smithsonian Astrophysical Observation", "SAO 39305"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.43145436),
        dec: Angle.Degrees(+47.22479927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164077"},
        {"Hipparcos Number", "HIP 87888"},
        {"Smithsonian Astrophysical Observation", "SAO 47089"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.29438267),
        dec: Angle.Degrees(+47.22620077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107983"},
        {"Geneva Identification System", "GEN# +3.51460006"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.14208772),
        dec: Angle.Degrees(+47.22878723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92259"},
        {"Smithsonian Astrophysical Observation", "SAO 47820"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.03049410),
        dec: Angle.Degrees(+47.22996963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53266",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7964 A"},
        {"Hipparcos Number", "HIP 53266"},
        {"Smithsonian Astrophysical Observation", "SAO 43508"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.40693728),
        dec: Angle.Degrees(+47.23072026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12823"},
        {"Hipparcos Number", "HIP 9868"},
        {"Geneva Identification System", "GEN# +1.00012823"},
        {"Smithsonian Astrophysical Observation", "SAO 37775"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.73628547),
        dec: Angle.Degrees(+47.23093041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117815"},
        {"Hipparcos Number", "HIP 66004"},
        {"Geneva Identification System", "GEN# +1.00117815"},
        {"Smithsonian Astrophysical Observation", "SAO 44642"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.98363313),
        dec: Angle.Degrees(+47.23442602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209813"},
        {"Hipparcos Number", "HIP 109002"},
        {"Geneva Identification System", "GEN# +1.00209813"},
        {"Smithsonian Astrophysical Observation", "SAO 51628"},
        {"Wilson Evans Batten Catalogue", "WEB 19600"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.23565588),
        dec: Angle.Degrees(+47.23450320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123874"},
        {"Hipparcos Number", "HIP 69121"},
        {"Smithsonian Astrophysical Observation", "SAO 44909"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.23431940),
        dec: Angle.Degrees(+47.23476488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129334"},
        {"Hipparcos Number", "HIP 71741"},
        {"Smithsonian Astrophysical Observation", "SAO 45166"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.12774748),
        dec: Angle.Degrees(+47.23947593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144205"},
        {"Hipparcos Number", "HIP 78574"},
        {"Smithsonian Astrophysical Observation", "SAO 45863"},
        {"Wilson Evans Batten Catalogue", "WEB 13281"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.66346753),
        dec: Angle.Degrees(+47.24019862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55575"},
        {"Hipparcos Number", "HIP 35136"},
        {"Fundamental Katalog 5th Edition", "FK5 1190"},
        {"Geneva Identification System", "GEN# +1.00055575"},
        {"Smithsonian Astrophysical Observation", "SAO 41644"},
        {"Wilson Evans Batten Catalogue", "WEB 7020"},
    },
    visualMagnitude: 5.54,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.95880519),
        dec: Angle.Degrees(+47.24041621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37813",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37813"},
        {"Smithsonian Astrophysical Observation", "SAO 41975"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.29232624),
        dec: Angle.Degrees(+47.24101525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215287"},
        {"Hipparcos Number", "HIP 112188"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.83243616),
        dec: Angle.Degrees(+47.24176529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5434",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 940 AB"},
        {"Henry Draper", "HD 6811"},
        {"Hipparcos Number", "HIP 5434"},
        {"Celescope Catalog", "CEL 122"},
        {"Geneva Identification System", "GEN# +1.00006811"},
        {"Smithsonian Astrophysical Observation", "SAO 36972"},
        {"Wilson Evans Batten Catalogue", "WEB 1186"},
    },
    visualMagnitude: 4.26,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.37550908),
        dec: Angle.Degrees(+47.24182410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1222"},
        {"Hipparcos Number", "HIP 1343"},
        {"Geneva Identification System", "GEN# +1.00001222"},
        {"Smithsonian Astrophysical Observation", "SAO 36232"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.20723209),
        dec: Angle.Degrees(+47.24403905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99954"},
        {"Hipparcos Number", "HIP 56129"},
        {"Geneva Identification System", "GEN# +1.00099954"},
        {"Smithsonian Astrophysical Observation", "SAO 43781"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.58172000),
        dec: Angle.Degrees(+47.24462545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160739"},
        {"Hipparcos Number", "HIP 86398"},
        {"Geneva Identification System", "GEN# +1.00160739"},
        {"Smithsonian Astrophysical Observation", "SAO 46869"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.81343091),
        dec: Angle.Degrees(+47.24470375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97045",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12849 A"},
        {"Henry Draper", "HD 186618"},
        {"Hipparcos Number", "HIP 97045"},
        {"Celescope Catalog", "CEL 4829"},
        {"Geneva Identification System", "GEN# +1.00186618"},
        {"Smithsonian Astrophysical Observation", "SAO 48768"},
        {"Wilson Evans Batten Catalogue", "WEB 17030"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.84370077),
        dec: Angle.Degrees(+47.24471800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152942"},
        {"Hipparcos Number", "HIP 82690"},
        {"Smithsonian Astrophysical Observation", "SAO 46359"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.53885470),
        dec: Angle.Degrees(+47.24548206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61425"},
        {"Geneva Identification System", "GEN# +0.04802038"},
        {"Wilson Evans Batten Catalogue", "WEB 10935"},
    },
    visualMagnitude: 10.97,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.80657301),
        dec: Angle.Degrees(+47.24624141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 229",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10 AB"},
        {"Henry Draper", "HD 225034"},
        {"Hipparcos Number", "HIP 229"},
        {"Smithsonian Astrophysical Observation", "SAO 36011"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.71393463),
        dec: Angle.Degrees(+47.25228068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3159",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 559 AB"},
        {"Henry Draper", "HD 3700"},
        {"Hipparcos Number", "HIP 3159"},
        {"Renson", "Renson 990"},
        {"Smithsonian Astrophysical Observation", "SAO 36564"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.05412719),
        dec: Angle.Degrees(+47.25585420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37448",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37448"},
        {"Smithsonian Astrophysical Observation", "SAO 41935"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.31361916),
        dec: Angle.Degrees(+47.25613032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100801",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100801"},
        {"Smithsonian Astrophysical Observation", "SAO 49622"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.58434208),
        dec: Angle.Degrees(+47.25656049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201522"},
        {"Hipparcos Number", "HIP 104361"},
        {"Geneva Identification System", "GEN# +1.00201522"},
        {"Smithsonian Astrophysical Observation", "SAO 50489"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.12344279),
        dec: Angle.Degrees(+47.25704853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103576"},
        {"Hipparcos Number", "HIP 58157"},
        {"Geneva Identification System", "GEN# +1.00103576"},
        {"Smithsonian Astrophysical Observation", "SAO 43948"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.90843844),
        dec: Angle.Degrees(+47.25749051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52496"},
        {"Hipparcos Number", "HIP 34046"},
        {"Geneva Identification System", "GEN# +1.00052496"},
        {"Smithsonian Astrophysical Observation", "SAO 41529"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.94163505),
        dec: Angle.Degrees(+47.25918483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22267"},
        {"Hipparcos Number", "HIP 16869"},
        {"Smithsonian Astrophysical Observation", "SAO 38985"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.26968924),
        dec: Angle.Degrees(+47.26145321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219813"},
        {"Hipparcos Number", "HIP 115067"},
        {"Smithsonian Astrophysical Observation", "SAO 52882"},
        {"Wilson Evans Batten Catalogue", "WEB 20385"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.59828079),
        dec: Angle.Degrees(+47.26168493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68387",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68387"},
        {"Smithsonian Astrophysical Observation", "SAO 44837"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.99172453),
        dec: Angle.Degrees(+47.26168984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205059"},
        {"Hipparcos Number", "HIP 106266"},
        {"Geneva Identification System", "GEN# +1.00205059"},
        {"Smithsonian Astrophysical Observation", "SAO 50976"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.86327883),
        dec: Angle.Degrees(+47.26246130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7915"},
        {"Smithsonian Astrophysical Observation", "SAO 37431"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.42883389),
        dec: Angle.Degrees(+47.26596539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21122"},
        {"Hipparcos Number", "HIP 16036"},
        {"Smithsonian Astrophysical Observation", "SAO 38829"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.63598452),
        dec: Angle.Degrees(+47.26648807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55003"},
        {"Hipparcos Number", "HIP 34926"},
        {"Geneva Identification System", "GEN# +1.00055003"},
        {"Smithsonian Astrophysical Observation", "SAO 41628"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.40522272),
        dec: Angle.Degrees(+47.26670844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85644"},
        {"Smithsonian Astrophysical Observation", "SAO 46756"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.53128688),
        dec: Angle.Degrees(+47.26812481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117210",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117210"},
        {"Geneva Identification System", "GEN# +0.04604159"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.49742741),
        dec: Angle.Degrees(+47.26876420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116172"},
        {"Hipparcos Number", "HIP 65154"},
        {"Smithsonian Astrophysical Observation", "SAO 44577"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.28045482),
        dec: Angle.Degrees(+47.26975278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157906"},
        {"Hipparcos Number", "HIP 85118"},
        {"Geneva Identification System", "GEN# +1.00157906"},
        {"Smithsonian Astrophysical Observation", "SAO 46691"},
        {"Wilson Evans Batten Catalogue", "WEB 14372"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.93587528),
        dec: Angle.Degrees(+47.27062592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104396",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14693 A"},
        {"Henry Draper", "HD 201599"},
        {"Hipparcos Number", "HIP 104396"},
        {"Geneva Identification System", "GEN# +1.00201599"},
        {"Smithsonian Astrophysical Observation", "SAO 50498"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.24104141),
        dec: Angle.Degrees(+47.27100058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149651"},
        {"Hipparcos Number", "HIP 81101"},
        {"Smithsonian Astrophysical Observation", "SAO 46160"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.47920342),
        dec: Angle.Degrees(+47.27154921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221024"},
        {"Hipparcos Number", "HIP 115854"},
        {"Smithsonian Astrophysical Observation", "SAO 53057"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.08763700),
        dec: Angle.Degrees(+47.27421927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21942"},
        {"Hipparcos Number", "HIP 16652"},
        {"Geneva Identification System", "GEN# +5.20201090"},
        {"Smithsonian Astrophysical Observation", "SAO 38950"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.56615596),
        dec: Angle.Degrees(+47.27594995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9477 A"},
        {"Henry Draper", "HD 133029"},
        {"Hipparcos Number", "HIP 73454"},
        {"Geneva Identification System", "GEN# +1.00133029A"},
        {"Renson", "Renson 37770"},
        {"Smithsonian Astrophysical Observation", "SAO 45326"},
        {"Wilson Evans Batten Catalogue", "WEB 12570"},
    },
    visualMagnitude: 6.35,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.16135610),
        dec: Angle.Degrees(+47.27740376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201359"},
        {"Hipparcos Number", "HIP 104268"},
        {"Celescope Catalog", "CEL 5247"},
        {"Geneva Identification System", "GEN# +1.00201359"},
        {"Smithsonian Astrophysical Observation", "SAO 50476"},
        {"Wilson Evans Batten Catalogue", "WEB 18992"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.84872423),
        dec: Angle.Degrees(+47.27751470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50865"},
        {"Hipparcos Number", "HIP 33452"},
        {"Smithsonian Astrophysical Observation", "SAO 41455"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.32670767),
        dec: Angle.Degrees(+47.27759442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20077"},
        {"Hipparcos Number", "HIP 15159"},
        {"Geneva Identification System", "GEN# +2.12450002"},
        {"Smithsonian Astrophysical Observation", "SAO 38679"},
        {"New General Catalogue", "NGC 1245 2"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.84567593),
        dec: Angle.Degrees(+47.27828678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1211"},
        {"Hipparcos Number", "HIP 1337"},
        {"Geneva Identification System", "GEN# +1.00001211"},
        {"Smithsonian Astrophysical Observation", "SAO 36230"},
    },
    visualMagnitude: 8.32,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.18666277),
        dec: Angle.Degrees(+47.27941028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216731"},
        {"Hipparcos Number", "HIP 113129"},
        {"Smithsonian Astrophysical Observation", "SAO 52478"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.64652150),
        dec: Angle.Degrees(+47.28224770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6374",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1099 AB"},
        {"Henry Draper", "HD 8161"},
        {"Hipparcos Number", "HIP 6374"},
        {"Smithsonian Astrophysical Observation", "SAO 37149"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.48293376),
        dec: Angle.Degrees(+47.28235943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99899"},
        {"Hipparcos Number", "HIP 56094"},
        {"Smithsonian Astrophysical Observation", "SAO 43777"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.47679838),
        dec: Angle.Degrees(+47.28465884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177390"},
        {"Henry Draper 2", "HD 177391"},
        {"Hipparcos Number", "HIP 93473"},
        {"Geneva Identification System", "GEN# +1.00177390"},
        {"Renson", "Renson 49480"},
        {"Smithsonian Astrophysical Observation", "SAO 48025"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.54253016),
        dec: Angle.Degrees(+47.28729410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18440"},
        {"Hipparcos Number", "HIP 13941"},
        {"Smithsonian Astrophysical Observation", "SAO 38491"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.89661551),
        dec: Angle.Degrees(+47.28740514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10424"},
        {"Smithsonian Astrophysical Observation", "SAO 37884"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.58378104),
        dec: Angle.Degrees(+47.28787238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6552 AB"},
        {"Henry Draper", "HD 66263"},
        {"Hipparcos Number", "HIP 39533"},
        {"Smithsonian Astrophysical Observation", "SAO 42157"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.18519862),
        dec: Angle.Degrees(+47.28987670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48008"},
        {"Smithsonian Astrophysical Observation", "SAO 43035"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.80653505),
        dec: Angle.Degrees(+47.29012635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36401",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6107 AB"},
        {"Henry Draper", "HD 58778"},
        {"Hipparcos Number", "HIP 36401"},
        {"Smithsonian Astrophysical Observation", "SAO 41805"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.35891634),
        dec: Angle.Degrees(+47.29019781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25603"},
        {"Hipparcos Number", "HIP 19134"},
        {"Smithsonian Astrophysical Observation", "SAO 39310"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.51526856),
        dec: Angle.Degrees(+47.29031433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68482"},
        {"Hipparcos Number", "HIP 40383"},
        {"Geneva Identification System", "GEN# +1.00068482"},
        {"Smithsonian Astrophysical Observation", "SAO 42239"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.66765595),
        dec: Angle.Degrees(+47.29265557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106485"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.51348921),
        dec: Angle.Degrees(+47.29481368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197850"},
        {"Hipparcos Number", "HIP 102377"},
        {"Smithsonian Astrophysical Observation", "SAO 50011"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.15187347),
        dec: Angle.Degrees(+47.29693651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105259"},
        {"Hipparcos Number", "HIP 59096"},
        {"Geneva Identification System", "GEN# +1.00105259"},
        {"Smithsonian Astrophysical Observation", "SAO 44038"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.78359414),
        dec: Angle.Degrees(+47.29827827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220820"},
        {"Hipparcos Number", "HIP 115711"},
        {"Smithsonian Astrophysical Observation", "SAO 53024"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.64892546),
        dec: Angle.Degrees(+47.30069240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71227"},
        {"Hipparcos Number", "HIP 41526"},
        {"Geneva Identification System", "GEN# +1.00071227"},
        {"Smithsonian Astrophysical Observation", "SAO 42375"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.03739624),
        dec: Angle.Degrees(+47.30230254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86011"},
        {"Hipparcos Number", "HIP 48791"},
        {"Smithsonian Astrophysical Observation", "SAO 43109"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.26922700),
        dec: Angle.Degrees(+47.30359911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18041"},
        {"Hipparcos Number", "HIP 13635"},
        {"Smithsonian Astrophysical Observation", "SAO 38442"},
        {"Wilson Evans Batten Catalogue", "WEB 2706"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.89125242),
        dec: Angle.Degrees(+47.30445649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 826",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 826"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.52801043),
        dec: Angle.Degrees(+47.30683960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196569"},
        {"Hipparcos Number", "HIP 101665"},
        {"Smithsonian Astrophysical Observation", "SAO 49850"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.10968357),
        dec: Angle.Degrees(+47.30742584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19279"},
        {"Hipparcos Number", "HIP 14544"},
        {"Geneva Identification System", "GEN# +1.00019279"},
        {"Smithsonian Astrophysical Observation", "SAO 38587"},
        {"Wilson Evans Batten Catalogue", "WEB 2826"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.94725062),
        dec: Angle.Degrees(+47.30870585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88984"},
        {"Hipparcos Number", "HIP 50366"},
        {"Geneva Identification System", "GEN# +1.00088984"},
        {"Smithsonian Astrophysical Observation", "SAO 43267"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.25366198),
        dec: Angle.Degrees(+47.30875306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14372"},
        {"Hipparcos Number", "HIP 10924"},
        {"Geneva Identification System", "GEN# +1.00014372"},
        {"Smithsonian Astrophysical Observation", "SAO 37955"},
        {"Wilson Evans Batten Catalogue", "WEB 2301"},
    },
    visualMagnitude: 6.17,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.17292662),
        dec: Angle.Degrees(+47.31082911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28049",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28049"},
        {"Celescope Catalog", "CEL 1030"},
        {"Geneva Identification System", "GEN# +0.04701213"},
        {"Smithsonian Astrophysical Observation", "SAO 40701"},
    },
    visualMagnitude: 9.40,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.97467758),
        dec: Angle.Degrees(+47.31160434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139689"},
        {"Hipparcos Number", "HIP 76520"},
        {"Geneva Identification System", "GEN# +1.00139689"},
        {"Smithsonian Astrophysical Observation", "SAO 45644"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.41363036),
        dec: Angle.Degrees(+47.31292392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50252"},
        {"Smithsonian Astrophysical Observation", "SAO 43249"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.91382285),
        dec: Angle.Degrees(+47.31392038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5799"},
        {"Hipparcos Number", "HIP 4688"},
        {"Smithsonian Astrophysical Observation", "SAO 36835"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.05521457),
        dec: Angle.Degrees(+47.31852919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54907"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.63893185),
        dec: Angle.Degrees(+47.31943203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101565"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.76218793),
        dec: Angle.Degrees(+47.32087546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9747"},
        {"Hipparcos Number", "HIP 7483"},
        {"Geneva Identification System", "GEN# +1.00009747"},
        {"Smithsonian Astrophysical Observation", "SAO 37350"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.09482725),
        dec: Angle.Degrees(+47.32588920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109120"},
        {"Smithsonian Astrophysical Observation", "SAO 51654"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.55008661),
        dec: Angle.Degrees(+47.32662119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186305"},
        {"Hipparcos Number", "HIP 96872"},
        {"Smithsonian Astrophysical Observation", "SAO 48734"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.36476366),
        dec: Angle.Degrees(+47.32808256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34268"},
        {"Hipparcos Number", "HIP 24764"},
        {"Geneva Identification System", "GEN# +1.00034268"},
        {"Smithsonian Astrophysical Observation", "SAO 40216"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.63488644),
        dec: Angle.Degrees(+47.32934855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81082"},
        {"Hipparcos Number", "HIP 46198"},
        {"Smithsonian Astrophysical Observation", "SAO 42845"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.29313562),
        dec: Angle.Degrees(+47.33277890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138556"},
        {"Hipparcos Number", "HIP 75984"},
        {"Smithsonian Astrophysical Observation", "SAO 45586"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.76002604),
        dec: Angle.Degrees(+47.33383303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13257"},
        {"Hipparcos Number", "HIP 10187"},
        {"Smithsonian Astrophysical Observation", "SAO 37837"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.73811025),
        dec: Angle.Degrees(+47.33734100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62668"},
        {"Hipparcos Number", "HIP 38003"},
        {"Smithsonian Astrophysical Observation", "SAO 41995"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.83676838),
        dec: Angle.Degrees(+47.33823810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31265"},
        {"Hipparcos Number", "HIP 22978"},
        {"Celescope Catalog", "CEL 489"},
        {"Geneva Identification System", "GEN# +1.00031265"},
        {"Smithsonian Astrophysical Observation", "SAO 39880"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.17797401),
        dec: Angle.Degrees(+47.34013763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63745"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.96731640),
        dec: Angle.Degrees(+47.34020062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18844"},
        {"Hipparcos Number", "HIP 14242"},
        {"Smithsonian Astrophysical Observation", "SAO 38537"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.91669148),
        dec: Angle.Degrees(+47.34083615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148681"},
        {"Hipparcos Number", "HIP 80613"},
        {"Smithsonian Astrophysical Observation", "SAO 46100"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.89109793),
        dec: Angle.Degrees(+47.34176591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84413"},
        {"Smithsonian Astrophysical Observation", "SAO 46587"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.86167965),
        dec: Angle.Degrees(+47.34419370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101963",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14142 AB"},
        {"Henry Draper", "HD 197118"},
        {"Hipparcos Number", "HIP 101963"},
        {"Celescope Catalog", "CEL 5137"},
        {"Geneva Identification System", "GEN# +1.00197118J"},
        {"Smithsonian Astrophysical Observation", "SAO 49908"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.93733146),
        dec: Angle.Degrees(+47.34526431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113493",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113493"},
        {"Smithsonian Astrophysical Observation", "SAO 52559"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.76822407),
        dec: Angle.Degrees(+47.34571939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14629",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14629"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.23569505),
        dec: Angle.Degrees(+47.34640131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86585",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86585"},
        {"Smithsonian Astrophysical Observation", "SAO 46893"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.42317924),
        dec: Angle.Degrees(+47.34669141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11845",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11845"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.22774112),
        dec: Angle.Degrees(+47.34815751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16885",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16885"},
        {"Wilson Evans Batten Catalogue", "WEB 3212"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.32313492),
        dec: Angle.Degrees(+47.34830824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12579"},
        {"Smithsonian Astrophysical Observation", "SAO 38230"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.44040947),
        dec: Angle.Degrees(+47.35105991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -288.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220210"},
        {"Hipparcos Number", "HIP 115334"},
        {"Smithsonian Astrophysical Observation", "SAO 52938"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.41129729),
        dec: Angle.Degrees(+47.35114061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224165"},
        {"Hipparcos Number", "HIP 117956"},
        {"Geneva Identification System", "GEN# +1.00224165"},
        {"Smithsonian Astrophysical Observation", "SAO 53486"},
        {"Wilson Evans Batten Catalogue", "WEB 20746"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.88952016),
        dec: Angle.Degrees(+47.35582163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16642"},
        {"Hipparcos Number", "HIP 12565"},
        {"Renson", "Renson 4172"},
        {"Smithsonian Astrophysical Observation", "SAO 38226"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.39544070),
        dec: Angle.Degrees(+47.35640411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28987"},
        {"Hipparcos Number", "HIP 21435"},
        {"Geneva Identification System", "GEN# +1.00028987"},
        {"Smithsonian Astrophysical Observation", "SAO 39633"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.05434594),
        dec: Angle.Degrees(+47.35662327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83006",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10288 C"},
        {"Henry Draper", "HD 153525"},
        {"Hipparcos Number", "HIP 83006"},
        {"Geneva Identification System", "GEN# +1.00153525"},
        {"Smithsonian Astrophysical Observation", "SAO 46403"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.42645006),
        dec: Angle.Degrees(+47.36150562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 262.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49554"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.77115149),
        dec: Angle.Degrees(+47.36301257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189636"},
        {"Hipparcos Number", "HIP 98345"},
        {"Smithsonian Astrophysical Observation", "SAO 49052"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.71626316),
        dec: Angle.Degrees(+47.36341693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108989"},
        {"Smithsonian Astrophysical Observation", "SAO 51625"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.19222254),
        dec: Angle.Degrees(+47.36431738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108652"},
        {"Smithsonian Astrophysical Observation", "SAO 51546"},
    },
    visualMagnitude: 9.37,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.16405892),
        dec: Angle.Degrees(+47.36483602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83020",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10288 A"},
        {"Henry Draper", "HD 153557"},
        {"Henry Draper 2", "HD 153557A"},
        {"Hipparcos Number", "HIP 83020"},
        {"Geneva Identification System", "GEN# +1.00153557A"},
        {"Smithsonian Astrophysical Observation", "SAO 46409"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.47211191),
        dec: Angle.Degrees(+47.36602661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 272.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90425"},
        {"Smithsonian Astrophysical Observation", "SAO 47505"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.75343631),
        dec: Angle.Degrees(+47.36946990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49601"},
        {"Hipparcos Number", "HIP 32919"},
        {"Geneva Identification System", "GEN# +1.00049601"},
        {"Wilson Evans Batten Catalogue", "WEB 6624"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.88585412),
        dec: Angle.Degrees(+47.36950310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -247.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -692.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88775"},
        {"Hipparcos Number", "HIP 50245"},
        {"Geneva Identification System", "GEN# +1.00088775"},
        {"Smithsonian Astrophysical Observation", "SAO 43248"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.88773653),
        dec: Angle.Degrees(+47.36969224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153286"},
        {"Hipparcos Number", "HIP 82864"},
        {"Geneva Identification System", "GEN# +1.00153286"},
        {"Renson", "Renson 43370"},
        {"Smithsonian Astrophysical Observation", "SAO 46378"},
        {"Wilson Evans Batten Catalogue", "WEB 14008"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.01908617),
        dec: Angle.Degrees(+47.37067663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28986"},
        {"Hipparcos Number", "HIP 21437"},
        {"Geneva Identification System", "GEN# +1.00028986"},
        {"Smithsonian Astrophysical Observation", "SAO 39634"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.06282275),
        dec: Angle.Degrees(+47.37109598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49174"},
        {"Smithsonian Astrophysical Observation", "SAO 43150"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.53370663),
        dec: Angle.Degrees(+47.37147079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219874"},
        {"Hipparcos Number", "HIP 115108"},
        {"Geneva Identification System", "GEN# +1.00219874"},
        {"Smithsonian Astrophysical Observation", "SAO 52889"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.72063433),
        dec: Angle.Degrees(+47.37178356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51371"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.38375022),
        dec: Angle.Degrees(+47.37189269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111129"},
        {"Hipparcos Number", "HIP 62355"},
        {"Smithsonian Astrophysical Observation", "SAO 44324"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.65621698),
        dec: Angle.Degrees(+47.37231267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21363"},
        {"Hipparcos Number", "HIP 16199"},
        {"Geneva Identification System", "GEN# +5.20200816"},
        {"Smithsonian Astrophysical Observation", "SAO 38861"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.17120606),
        dec: Angle.Degrees(+47.37237158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14797"},
        {"Hipparcos Number", "HIP 11226"},
        {"Smithsonian Astrophysical Observation", "SAO 38006"},
        {"Wilson Evans Batten Catalogue", "WEB 2351"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.12490181),
        dec: Angle.Degrees(+47.37274450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179959"},
        {"Hipparcos Number", "HIP 94351"},
        {"Smithsonian Astrophysical Observation", "SAO 48194"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.06544451),
        dec: Angle.Degrees(+47.37499251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4911",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 862 AB"},
        {"Henry Draper", "HD 6114"},
        {"Hipparcos Number", "HIP 4911"},
        {"Geneva Identification System", "GEN# +1.00006114"},
        {"Smithsonian Astrophysical Observation", "SAO 36875"},
        {"Wilson Evans Batten Catalogue", "WEB 970"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.75613404),
        dec: Angle.Degrees(+47.37619549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66262"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.70869094),
        dec: Angle.Degrees(+47.37624944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -336.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188074"},
        {"Hipparcos Number", "HIP 97700"},
        {"Geneva Identification System", "GEN# +1.00188074"},
        {"Smithsonian Astrophysical Observation", "SAO 48907"},
        {"Wilson Evans Batten Catalogue", "WEB 17185"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.83069652),
        dec: Angle.Degrees(+47.37719407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14212"},
        {"Hipparcos Number", "HIP 10819"},
        {"Fundamental Katalog 5th Edition", "FK5 1063"},
        {"Geneva Identification System", "GEN# +1.00014212"},
        {"Smithsonian Astrophysical Observation", "SAO 37948"},
        {"Wilson Evans Batten Catalogue", "WEB 2281"},
    },
    visualMagnitude: 5.31,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.82019851),
        dec: Angle.Degrees(+47.37998782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72191"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.48959503),
        dec: Angle.Degrees(+47.38134399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17109"},
    },
    visualMagnitude: 10.91,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.97320424),
        dec: Angle.Degrees(+47.38384626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64106"},
        {"Hipparcos Number", "HIP 38623"},
        {"Geneva Identification System", "GEN# +1.00064106"},
        {"Smithsonian Astrophysical Observation", "SAO 42055"},
        {"Wilson Evans Batten Catalogue", "WEB 7581"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.62199178),
        dec: Angle.Degrees(+47.38597337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17685"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.82209859),
        dec: Angle.Degrees(+47.38602642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113111",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16355 AB"},
        {"Henry Draper", "HD 216713"},
        {"Hipparcos Number", "HIP 113111"},
        {"Smithsonian Astrophysical Observation", "SAO 52476"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.58834928),
        dec: Angle.Degrees(+47.38728547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43523"},
        {"Hipparcos Number", "HIP 30023"},
        {"Geneva Identification System", "GEN# +1.00043523"},
        {"Smithsonian Astrophysical Observation", "SAO 41016"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.77008184),
        dec: Angle.Degrees(+47.39411450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115652"},
        {"Smithsonian Astrophysical Observation", "SAO 53006"},
    },
    visualMagnitude: 9.50,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.42801373),
        dec: Angle.Degrees(+47.39457011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99599"},
        {"Wilson Evans Batten Catalogue", "WEB 17834"},
    },
    visualMagnitude: 10.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.18794924),
        dec: Angle.Degrees(+47.39482913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5334"},
        {"Hipparcos Number", "HIP 4348"},
        {"Celescope Catalog", "CEL 98"},
        {"Geneva Identification System", "GEN# +1.00005334"},
        {"Smithsonian Astrophysical Observation", "SAO 36774"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.93354463),
        dec: Angle.Degrees(+47.39651985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45971"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.63361034),
        dec: Angle.Degrees(+47.39824991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19993"},
        {"Geneva Identification System", "GEN# +0.04700965"},
        {"Wilson Evans Batten Catalogue", "WEB 3818"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.32167413),
        dec: Angle.Degrees(+47.40019902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39064"},
        {"Hipparcos Number", "HIP 27768"},
        {"Geneva Identification System", "GEN# +1.00039064"},
        {"Smithsonian Astrophysical Observation", "SAO 40667"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.14280384),
        dec: Angle.Degrees(+47.40022327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159062"},
        {"Hipparcos Number", "HIP 85653"},
        {"Geneva Identification System", "GEN# +1.00159062"},
        {"Smithsonian Astrophysical Observation", "SAO 46762"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.56781302),
        dec: Angle.Degrees(+47.40201668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68416"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.08745689),
        dec: Angle.Degrees(+47.40224501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104955"},
        {"Hipparcos Number", "HIP 58938"},
        {"Geneva Identification System", "GEN# +1.00104955"},
        {"Smithsonian Astrophysical Observation", "SAO 44020"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.27806829),
        dec: Angle.Degrees(+47.40242414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40927"},
        {"Geneva Identification System", "GEN# +1.00069894C"},
        {"Smithsonian Astrophysical Observation", "SAO 42303"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.28440643),
        dec: Angle.Degrees(+47.40253113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164921"},
        {"Hipparcos Number", "HIP 88234"},
        {"Smithsonian Astrophysical Observation", "SAO 47140"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.27062048),
        dec: Angle.Degrees(+47.40307968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100823"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.65386763),
        dec: Angle.Degrees(+47.40405507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88486",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88486"},
        {"Smithsonian Astrophysical Observation", "SAO 47189"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.02547888),
        dec: Angle.Degrees(+47.40407072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45105"},
        {"Hipparcos Number", "HIP 30762"},
        {"Fundamental Katalog 5th Edition", "FK5 4587"},
        {"Geneva Identification System", "GEN# +1.00045105"},
        {"Renson", "Renson 11960"},
        {"Smithsonian Astrophysical Observation", "SAO 41109"},
        {"Wilson Evans Batten Catalogue", "WEB 6133"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.96239721),
        dec: Angle.Degrees(+47.40491842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3454"},
        {"Hipparcos Number", "HIP 2981"},
        {"Geneva Identification System", "GEN# +1.00003454"},
        {"Smithsonian Astrophysical Observation", "SAO 36529"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.48706616),
        dec: Angle.Degrees(+47.40791719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102214"},
        {"Smithsonian Astrophysical Observation", "SAO 49968"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.66244384),
        dec: Angle.Degrees(+47.40904572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51669"},
    },
    visualMagnitude: 11.20,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.34073488),
        dec: Angle.Degrees(+47.40977869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -254.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215344"},
        {"Hipparcos Number", "HIP 112221"},
        {"Smithsonian Astrophysical Observation", "SAO 52310"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.92329593),
        dec: Angle.Degrees(+47.41178587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40925",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6746 A"},
        {"Henry Draper", "HD 69894"},
        {"Hipparcos Number", "HIP 40925"},
        {"Smithsonian Astrophysical Observation", "SAO 42302"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.28111217),
        dec: Angle.Degrees(+47.41305754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119370"},
        {"Hipparcos Number", "HIP 66836"},
        {"Smithsonian Astrophysical Observation", "SAO 44717"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.46567518),
        dec: Angle.Degrees(+47.41403297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15911"},
        {"Geneva Identification System", "GEN# +5.20200632"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.22957856),
        dec: Angle.Degrees(+47.41507971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158329"},
        {"Hipparcos Number", "HIP 85343"},
        {"Smithsonian Astrophysical Observation", "SAO 46719"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.59511215),
        dec: Angle.Degrees(+47.41564492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152812"},
        {"Hipparcos Number", "HIP 82611"},
        {"Geneva Identification System", "GEN# +1.00152812"},
        {"Smithsonian Astrophysical Observation", "SAO 46349"},
        {"Wilson Evans Batten Catalogue", "WEB 13948"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.32330049),
        dec: Angle.Degrees(+47.41649815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 93.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199478"},
        {"Hipparcos Number", "HIP 103312"},
        {"Geneva Identification System", "GEN# +1.00199478"},
        {"Smithsonian Astrophysical Observation", "SAO 50246"},
        {"Wilson Evans Batten Catalogue", "WEB 18776"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.95752483),
        dec: Angle.Degrees(+47.41766542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61076",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61076"},
        {"Smithsonian Astrophysical Observation", "SAO 44210"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.76452613),
        dec: Angle.Degrees(+47.41794096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40913",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6746 D"},
        {"Henry Draper", "HD 69865"},
        {"Hipparcos Number", "HIP 40913"},
        {"Geneva Identification System", "GEN# +1.00069865"},
        {"Smithsonian Astrophysical Observation", "SAO 42300"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.25023802),
        dec: Angle.Degrees(+47.41904951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11188"},
        {"Hipparcos Number", "HIP 8609"},
        {"Geneva Identification System", "GEN# +1.00011188"},
        {"Smithsonian Astrophysical Observation", "SAO 37556"},
        {"Wilson Evans Batten Catalogue", "WEB 1824"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.76068529),
        dec: Angle.Degrees(+47.41957472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7758"},
        {"Hipparcos Number", "HIP 6087"},
        {"Geneva Identification System", "GEN# +1.00007758"},
        {"Smithsonian Astrophysical Observation", "SAO 37096"},
        {"Wilson Evans Batten Catalogue", "WEB 1371"},
    },
    visualMagnitude: 6.29,
    bvColour: 1.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.54225774),
        dec: Angle.Degrees(+47.41971636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42350"},
        {"Hipparcos Number", "HIP 29472"},
        {"Geneva Identification System", "GEN# +1.00042350"},
        {"Smithsonian Astrophysical Observation", "SAO 40940"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.14830374),
        dec: Angle.Degrees(+47.42046821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54325"},
        {"Smithsonian Astrophysical Observation", "SAO 43613"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.70233605),
        dec: Angle.Degrees(+47.42115916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21855"},
        {"Hipparcos Number", "HIP 16574"},
        {"Geneva Identification System", "GEN# +5.20201056"},
        {"Smithsonian Astrophysical Observation", "SAO 38939"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.34263813),
        dec: Angle.Degrees(+47.42211338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208797"},
        {"Hipparcos Number", "HIP 108393"},
        {"Smithsonian Astrophysical Observation", "SAO 51486"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.40383265),
        dec: Angle.Degrees(+47.42295050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224999"},
        {"Hipparcos Number", "HIP 195"},
        {"Geneva Identification System", "GEN# +1.00224999"},
        {"Smithsonian Astrophysical Observation", "SAO 53592"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.62573691),
        dec: Angle.Degrees(+47.42295978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78108"},
        {"Hipparcos Number", "HIP 44830"},
        {"Smithsonian Astrophysical Observation", "SAO 42708"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.02628806),
        dec: Angle.Degrees(+47.42365004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116457"},
        {"Smithsonian Astrophysical Observation", "SAO 53174"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.96205064),
        dec: Angle.Degrees(+47.42739020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185148"},
        {"Hipparcos Number", "HIP 96363"},
        {"Smithsonian Astrophysical Observation", "SAO 48627"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.88835220),
        dec: Angle.Degrees(+47.43580979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171972"},
        {"Hipparcos Number", "HIP 91123"},
        {"Smithsonian Astrophysical Observation", "SAO 47623"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.81451896),
        dec: Angle.Degrees(+47.43631009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192802"},
        {"Hipparcos Number", "HIP 99785"},
        {"Celescope Catalog", "CEL 4992"},
        {"Geneva Identification System", "GEN# +1.00192802"},
        {"Smithsonian Astrophysical Observation", "SAO 49358"},
    },
    visualMagnitude: 7.28,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.68985553),
        dec: Angle.Degrees(+47.44059020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31205"},
        {"Hipparcos Number", "HIP 22948"},
        {"Celescope Catalog", "CEL 488"},
        {"Geneva Identification System", "GEN# +1.00031205"},
        {"Renson", "Renson 8007"},
        {"Smithsonian Astrophysical Observation", "SAO 39876"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.06140002),
        dec: Angle.Degrees(+47.44082354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175955"},
        {"Hipparcos Number", "HIP 92885"},
        {"Smithsonian Astrophysical Observation", "SAO 47924"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.88907069),
        dec: Angle.Degrees(+47.44090524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
